using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub pull request.
/// </summary>
public class GitHubPullRequest
{
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets url.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;

    /// <summary>
    /// Gets or sets html url.
    /// </summary>
    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets diff url.
    /// </summary>
    [JsonPropertyName("diff_url")]
    public string DiffUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets patch url.
    /// </summary>
    [JsonPropertyName("patch_url")]
    public string PatchUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets issue url.
    /// </summary>
    [JsonPropertyName("issue_url")]
    public string IssueUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets number.
    /// </summary>
    [JsonPropertyName("number")]
    public int Number { get; set; }

    /// <summary>
    /// Gets or sets state.
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; } = null!; // e.g., "OPEN", "CLOSED"

    /// <summary>
    /// Gets or sets a value indicating whether locked.
    /// </summary>
    [JsonPropertyName("locked")]
    public bool Locked { get; set; }

    /// <summary>
    /// Gets or sets title.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Gets or sets user.
    /// </summary>
    [JsonPropertyName("user")]
    public GitHubUser User { get; set; } = null!;

    /// <summary>
    /// Gets or sets body.
    /// </summary>
    [JsonPropertyName("body")]
    public string Body { get; set; } = null!;

    /// <summary>
    /// Gets or sets created at.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets updated at.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    /// <summary>
    /// Gets or sets closed at.
    /// </summary>
    [JsonPropertyName("closed_at")]
    public DateTimeOffset? ClosedAt { get; set; }

    /// <summary>
    /// Gets or sets merged at.
    /// </summary>
    [JsonPropertyName("merged_at")]
    public DateTimeOffset? MergedAt { get; set; }

    /// <summary>
    /// Gets or sets merge commit sha.
    /// </summary>
    [JsonPropertyName("merge_commit_sha")]
    public string? MergeCommitSha { get; set; }

    /// <summary>
    /// Gets or sets assignees.
    /// </summary>
    [JsonPropertyName("assignees")]
    public List<GitHubUser> Assignees { get; set; } = new();

    /// <summary>
    /// Gets or sets requested reviewers.
    /// </summary>
    [JsonPropertyName("requested_reviewers")]
    public List<GitHubUser> RequestedReviewers { get; set; } = new();

    /// <summary>
    /// Gets or sets requested teams.
    /// </summary>
    [JsonPropertyName("requested_teams")]
    public List<GitHubTeam> RequestedTeams { get; set; } = new();

    /// <summary>
    /// Gets or sets labels.
    /// </summary>
    [JsonPropertyName("labels")]
    public List<GitHubLabel> Labels { get; set; } = new();

    /// <summary>
    /// Gets or sets milestone.
    /// </summary>
    [JsonPropertyName("milestone")]
    public GitHubMilestone? Milestone { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether draft.
    /// </summary>
    [JsonPropertyName("draft")]
    public bool Draft { get; set; }
}