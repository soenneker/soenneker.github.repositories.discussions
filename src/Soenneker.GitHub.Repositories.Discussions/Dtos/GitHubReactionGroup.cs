using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub reaction group.
/// </summary>
public class GitHubReactionGroup
{
    /// <summary>
    /// Gets or sets content.
    /// </summary>
    [JsonPropertyName("content")]
    public string Content { get; set; } = null!; // e.g., "THUMBS_UP", "HEART"

    /// <summary>
    /// Gets or sets total count.
    /// </summary>
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }
}