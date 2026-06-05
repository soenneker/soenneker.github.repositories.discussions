using System;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub milestone.
/// </summary>
public class GitHubMilestone
{
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
    /// Gets or sets labels url.
    /// </summary>
    [JsonPropertyName("labels_url")]
    public string LabelsUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets id.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets node id.
    /// </summary>
    [JsonPropertyName("node_id")]
    public string NodeId { get; set; } = null!;

    /// <summary>
    /// Gets or sets number.
    /// </summary>
    [JsonPropertyName("number")]
    public int Number { get; set; }

    /// <summary>
    /// Gets or sets state.
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; } = null!; // e.g., "open", "closed"

    /// <summary>
    /// Gets or sets title.
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Gets or sets description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    /// <summary>
    /// Gets or sets creator.
    /// </summary>
    [JsonPropertyName("creator")]
    public GitHubUser Creator { get; set; } = null!;

    /// <summary>
    /// Gets or sets open issues.
    /// </summary>
    [JsonPropertyName("open_issues")]
    public int OpenIssues { get; set; }

    /// <summary>
    /// Gets or sets closed issues.
    /// </summary>
    [JsonPropertyName("closed_issues")]
    public int ClosedIssues { get; set; }

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
    /// Gets or sets due on.
    /// </summary>
    [JsonPropertyName("due_on")]
    public DateTimeOffset? DueOn { get; set; }
}