using Soenneker.GitHub.Repositories.Discussions.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Octokit;
using Soenneker.Extensions.HttpClient;
using Soenneker.Extensions.String;
using Soenneker.Extensions.Task;
using Soenneker.Extensions.ValueTask;
using Soenneker.GitHub.Client.Http.Abstract;
using Soenneker.GitHub.Repositories.Abstract;
using Soenneker.GitHub.Repositories.Discussions.Dtos;
using Soenneker.Utils.Random;

namespace Soenneker.GitHub.Repositories.Discussions;

/// <inheritdoc cref="IGitHubRepositoriesDiscussionsUtil"/>
public class GitHubRepositoriesDiscussionsUtil : IGitHubRepositoriesDiscussionsUtil
{
    private readonly ILogger<GitHubRepositoriesDiscussionsUtil> _logger;
    private readonly IGitHubHttpClient _gitHubHttpClient;
    private readonly IGitHubRepositoriesUtil _gitHubRepositoriesUtil;

    public GitHubRepositoriesDiscussionsUtil(ILogger<GitHubRepositoriesDiscussionsUtil> logger, IGitHubHttpClient gitHubHttpClient, IConfiguration config,
        IGitHubRepositoriesUtil gitHubRepositoriesUtil)
    {
        _logger = logger;
        _gitHubHttpClient = gitHubHttpClient;
        _gitHubRepositoriesUtil = gitHubRepositoriesUtil;
    }

    public async ValueTask Add(string owner, string name, GitHubDiscussion discussion, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Adding discussion to repo ({owner}/{repo}) ...", owner, name);

        var url = $"repos/{owner}/{name}/discussions";

        HttpClient client = await _gitHubHttpClient.Get(cancellationToken).NoSync();

        using var request = new HttpRequestMessage(HttpMethod.Post, url);

        (bool successful, HttpResponseMessage? response) = await client.TrySend(request, _logger, cancellationToken).NoSync();

        if (!successful)
        {
            if (response != null)
            {
                string errorContent = await response.Content.ReadAsStringAsync(cancellationToken).NoSync();
                _logger.LogError("Failed to add discussion: {StatusCode} - {ErrorContent}", response.StatusCode, errorContent);
            }
            else
                _logger.LogError("Failed to add discussion");
        }

        _logger.LogInformation("Discussion added successfully to repo ({owner}/{repo}).", owner, name);
    }

    public async ValueTask<List<GitHubDiscussion>> GetAllForOwner(string owner, string? state = null, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting all discussions for owner ({owner}) ...", owner);

        IReadOnlyList<Repository> allRepos = await _gitHubRepositoriesUtil.GetAllForOwner(owner, cancellationToken).NoSync();

        IEnumerable<Repository> hasDiscussionsFilter = allRepos.Where(c => c.HasDiscussions);

        var allDiscussions = new List<GitHubDiscussion>();

        foreach (Repository repo in hasDiscussionsFilter)
        {
            List<GitHubDiscussion> discussions = await GetAll(owner, repo.Name, state, false, cancellationToken).NoSync();

            if (discussions.Count is not 0)
            {
                allDiscussions.AddRange(discussions);
            }

            await Task.Delay(RandomUtil.Next(50, 200), cancellationToken).NoSync();
        }

        return allDiscussions;
    }

    public async ValueTask<List<GitHubDiscussion>> GetAll(string owner, string name, string? state = null, bool log = true, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Getting all discussions for repo ({owner}/{repo}) ...", owner, name);

        var url = $"repos/{owner}/{name}/discussions?per_page=100";
        var discussions = new List<GitHubDiscussion>();
        var page = 1;
        var hasMore = true;

        HttpClient client = await _gitHubHttpClient.Get(cancellationToken).NoSync();

        while (hasMore)
        {
            var pagedUrl = $"{url}&page={page}";
            using var request = new HttpRequestMessage(HttpMethod.Get, pagedUrl);

            List<GitHubDiscussion>? pageDiscussions = await client.TrySendToType<List<GitHubDiscussion>>(request, _logger, cancellationToken).NoSync();

            if (pageDiscussions is { Count: > 0 })
            {
                if (state.HasContent())
                {
                    foreach (GitHubDiscussion discussion in pageDiscussions)
                    {
                        if (discussion.State == state)
                            discussions.Add(discussion);
                    }
                }
                else
                {
                    discussions.AddRange(pageDiscussions);
                }

                page++;
            }
            else
            {
                hasMore = false;
            }
        }

        if (log)
            _logger.LogInformation("Retrieved {Count} discussions from repo ({owner}/{repo}).", discussions.Count, owner, name);

        return discussions;
    }

    public async ValueTask DeleteAll(string owner, string name, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Deleting all discussions from repo ({owner}/{repo}) ...", owner, name);

        List<GitHubDiscussion> discussions = await GetAll(owner, name, null, true, cancellationToken).NoSync();

        foreach (GitHubDiscussion discussion in discussions)
        {
            await Delete(owner, name, discussion.Number, cancellationToken).NoSync();
        }

        _logger.LogInformation("All discussions deleted from repo ({owner}/{repo}).", owner, name);
    }

    public async ValueTask Delete(string owner, string name, int discussionNumber, CancellationToken cancellationToken = default)
    {
        _logger.LogInformation("Deleting discussion #{discussionNumber} from repo ({owner}/{repo}) ...", discussionNumber, owner, name);

        var url = $"repos/{owner}/{name}/discussions/{discussionNumber}";

        using var request = new HttpRequestMessage(HttpMethod.Delete, url);

        HttpClient client = await _gitHubHttpClient.Get(cancellationToken).NoSync();

        HttpResponseMessage response = await client.SendAsync(request, cancellationToken).NoSync();

        if (!response.IsSuccessStatusCode)
        {
            string errorContent = await response.Content.ReadAsStringAsync(cancellationToken).NoSync();
            _logger.LogError("Failed to delete discussion #{discussionNumber}: {StatusCode} - {ErrorContent}", discussionNumber, response.StatusCode, errorContent);
            response.EnsureSuccessStatusCode();
        }

        _logger.LogInformation("Discussion #{discussionNumber} deleted successfully from repo ({owner}/{repo}).", discussionNumber, owner, name);
    }
}
