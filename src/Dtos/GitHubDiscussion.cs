using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

public class GitHubDiscussion
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("number")]
    public int Number { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("body")]
    public string Body { get; set; } = null!;

    [JsonPropertyName("body_html")]
    public string BodyHtml { get; set; } = null!;

    [JsonPropertyName("body_text")]
    public string BodyText { get; set; } = null!;

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; } = null!; // e.g., "OPEN", "CLOSED"

    [JsonPropertyName("locked")]
    public bool Locked { get; set; }

    [JsonPropertyName("locked_reason")]
    public string? LockedReason { get; set; }

    [JsonPropertyName("author_association")]
    public string AuthorAssociation { get; set; } = null!;

    [JsonPropertyName("active_lock_reason")]
    public string? ActiveLockReason { get; set; }

    [JsonPropertyName("category")]
    public GitHubCategory Category { get; set; } = null!;

    [JsonPropertyName("author")]
    public GitHubUser Author { get; set; } = null!;

    [JsonPropertyName("editor")]
    public GitHubUser? Editor { get; set; }

    [JsonPropertyName("pull_request")]
    public GitHubPullRequest? PullRequest { get; set; }

    [JsonPropertyName("reaction_groups")]
    public List<GitHubReactionGroup>? ReactionGroups { get; set; }

    [JsonPropertyName("reactions")]
    public GitHubReactions Reactions { get; set; } = null!;

    [JsonPropertyName("comments")]
    public int Comments { get; set; }

    [JsonPropertyName("latest_comment_url")]
    public string LatestCommentUrl { get; set; } = null!;

    [JsonPropertyName("last_comment_at")]
    public DateTimeOffset? LastCommentAt { get; set; }

    [JsonPropertyName("last_comment_id")]
    public long? LastCommentId { get; set; }

    [JsonPropertyName("pinned")]
    public bool? Pinned { get; set; }

    [JsonPropertyName("closed_at")]
    public DateTimeOffset? ClosedAt { get; set; }

    [JsonPropertyName("closed_by")]
    public GitHubUser? ClosedBy { get; set; }

    [JsonPropertyName("_links")]
    public GitHubLinks Links { get; set; } = null!;
}