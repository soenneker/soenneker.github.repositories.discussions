using Soenneker.GitHub.Repositories.Discussions.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace Soenneker.GitHub.Repositories.Discussions.Abstract;

/// <summary>
/// A utility library for GitHub repository discussion related operations
/// </summary>
public interface IGitHubRepositoriesDiscussionsUtil
{
    /// <summary>
    /// Adds a new discussion to the specified repository.
    /// </summary>
    /// <param name="owner">The owner of the repository.</param>
    /// <param name="name">The name of the repository.</param>
    /// <param name="discussion">The discussion details to add.</param>
    /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
    /// <returns>A ValueTask representing the asynchronous operation.</returns>
    ValueTask Add(string owner, string name, GitHubDiscussion discussion, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves all discussions across all repositories for a specified owner.
    /// </summary>
    /// <param name="owner">The owner of the repositories.</param>
    /// <param name="state">Optional state filter for the discussions (e.g., "open" or "closed").</param>
    /// <param name="endAt"></param>
    /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
    /// <param name="startAt"></param>
    /// <returns>A ValueTask containing a list of discussions.</returns>
    ValueTask<List<GitHubDiscussion>> GetAllForOwner(string owner, string? state = null, DateTime? startAt = null, DateTime? endAt = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves all discussions for a specified repository.
    /// </summary>
    /// <param name="owner">The owner of the repository.</param>
    /// <param name="name">The name of the repository.</param>
    /// <param name="state">Optional state filter for the discussions (e.g., "open" or "closed").</param>
    /// <param name="log">Indicates whether to log the results.</param>
    /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
    /// <returns>A ValueTask containing a list of discussions.</returns>
    ValueTask<List<GitHubDiscussion>> GetAll(string owner, string name, string? state = null, bool log = true, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes all discussions from a specified repository.
    /// </summary>
    /// <param name="owner">The owner of the repository.</param>
    /// <param name="name">The name of the repository.</param>
    /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
    /// <returns>A ValueTask representing the asynchronous operation.</returns>
    ValueTask DeleteAll(string owner, string name, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a specific discussion from a repository.
    /// </summary>
    /// <param name="owner">The owner of the repository.</param>
    /// <param name="name">The name of the repository.</param>
    /// <param name="discussionNumber">The number of the discussion to delete.</param>
    /// <param name="cancellationToken">Optional cancellation token for the operation.</param>
    /// <returns>A ValueTask representing the asynchronous operation.</returns>
    ValueTask Delete(string owner, string name, int discussionNumber, CancellationToken cancellationToken = default);
}