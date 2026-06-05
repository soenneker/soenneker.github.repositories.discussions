using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub discussion.
/// </summary>
public class GitHubDiscussion
{
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets number.
    /// </summary>
    [JsonPropertyName("number")]
    public int Number { get; set; }

    /// <summary>
    /// Gets or sets title.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Gets or sets body.
    /// </summary>
    [JsonPropertyName("body")]
    public string Body { get; set; } = null!;

    /// <summary>
    /// Gets or sets body html.
    /// </summary>
    [JsonPropertyName("body_html")]
    public string BodyHtml { get; set; } = null!;

    /// <summary>
    /// Gets or sets body text.
    /// </summary>
    [JsonPropertyName("body_text")]
    public string BodyText { get; set; } = null!;

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
    /// Gets or sets locked reason.
    /// </summary>
    [JsonPropertyName("locked_reason")]
    public string? LockedReason { get; set; }

    /// <summary>
    /// Gets or sets author association.
    /// </summary>
    [JsonPropertyName("author_association")]
    public string AuthorAssociation { get; set; } = null!;

    /// <summary>
    /// Gets or sets active lock reason.
    /// </summary>
    [JsonPropertyName("active_lock_reason")]
    public string? ActiveLockReason { get; set; }

    /// <summary>
    /// Gets or sets category.
    /// </summary>
    [JsonPropertyName("category")]
    public GitHubCategory Category { get; set; } = null!;

    /// <summary>
    /// Gets or sets author.
    /// </summary>
    [JsonPropertyName("author")]
    public GitHubUser Author { get; set; } = null!;

    /// <summary>
    /// Gets or sets editor.
    /// </summary>
    [JsonPropertyName("editor")]
    public GitHubUser? Editor { get; set; }

    /// <summary>
    /// Gets or sets pull request.
    /// </summary>
    [JsonPropertyName("pull_request")]
    public GitHubPullRequest? PullRequest { get; set; }

    /// <summary>
    /// Gets or sets reaction groups.
    /// </summary>
    [JsonPropertyName("reaction_groups")]
    public List<GitHubReactionGroup>? ReactionGroups { get; set; }

    /// <summary>
    /// Gets or sets reactions.
    /// </summary>
    [JsonPropertyName("reactions")]
    public GitHubReactions Reactions { get; set; } = null!;

    /// <summary>
    /// Gets or sets comments.
    /// </summary>
    [JsonPropertyName("comments")]
    public int Comments { get; set; }

    /// <summary>
    /// Gets or sets latest comment url.
    /// </summary>
    [JsonPropertyName("latest_comment_url")]
    public string LatestCommentUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets last comment at.
    /// </summary>
    [JsonPropertyName("last_comment_at")]
    public DateTimeOffset? LastCommentAt { get; set; }

    /// <summary>
    /// Gets or sets last comment id.
    /// </summary>
    [JsonPropertyName("last_comment_id")]
    public long? LastCommentId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether pinned.
    /// </summary>
    [JsonPropertyName("pinned")]
    public bool? Pinned { get; set; }

    /// <summary>
    /// Gets or sets closed at.
    /// </summary>
    [JsonPropertyName("closed_at")]
    public DateTimeOffset? ClosedAt { get; set; }

    /// <summary>
    /// Gets or sets closed by.
    /// </summary>
    [JsonPropertyName("closed_by")]
    public GitHubUser? ClosedBy { get; set; }

    /// <summary>
    /// Gets or sets links.
    /// </summary>
    [JsonPropertyName("_links")]
    public GitHubLinks Links { get; set; } = null!;
}