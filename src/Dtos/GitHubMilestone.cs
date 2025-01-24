using System;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

public class GitHubMilestone
{
    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;

    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; } = null!;

    [JsonPropertyName("labels_url")]
    public string LabelsUrl { get; set; } = null!;

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("node_id")]
    public string NodeId { get; set; } = null!;

    [JsonPropertyName("number")]
    public int Number { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; } = null!; // e.g., "open", "closed"

    [JsonPropertyName("title")]
    public string Title { get; set; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    [JsonPropertyName("creator")]
    public GitHubUser Creator { get; set; } = null!;

    [JsonPropertyName("open_issues")]
    public int OpenIssues { get; set; }

    [JsonPropertyName("closed_issues")]
    public int ClosedIssues { get; set; }

    [JsonPropertyName("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonPropertyName("closed_at")]
    public DateTimeOffset? ClosedAt { get; set; }

    [JsonPropertyName("due_on")]
    public DateTimeOffset? DueOn { get; set; }
}