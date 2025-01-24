using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

public class GitHubPullRequest
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;

    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; } = null!;

    [JsonPropertyName("diff_url")]
    public string DiffUrl { get; set; } = null!;

    [JsonPropertyName("patch_url")]
    public string PatchUrl { get; set; } = null!;

    [JsonPropertyName("issue_url")]
    public string IssueUrl { get; set; } = null!;

    [JsonPropertyName("number")]
    public int Number { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; } = null!; // e.g., "OPEN", "CLOSED"

    [JsonPropertyName("locked")]
    public bool Locked { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("user")]
    public GitHubUser User { get; set; } = null!;

    [JsonPropertyName("body")]
    public string Body { get; set; } = null!;

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("closed_at")]
    public DateTimeOffset? ClosedAt { get; set; }

    [JsonPropertyName("merged_at")]
    public DateTimeOffset? MergedAt { get; set; }

    [JsonPropertyName("merge_commit_sha")]
    public string? MergeCommitSha { get; set; }

    [JsonPropertyName("assignees")]
    public List<GitHubUser> Assignees { get; set; } = new();

    [JsonPropertyName("requested_reviewers")]
    public List<GitHubUser> RequestedReviewers { get; set; } = new();

    [JsonPropertyName("requested_teams")]
    public List<GitHubTeam> RequestedTeams { get; set; } = new();

    [JsonPropertyName("labels")]
    public List<GitHubLabel> Labels { get; set; } = new();

    [JsonPropertyName("milestone")]
    public GitHubMilestone? Milestone { get; set; }

    [JsonPropertyName("draft")]
    public bool Draft { get; set; }
}