using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

public class GitHubReactionGroup
{
    [JsonPropertyName("content")]
    public string Content { get; set; } = null!; // e.g., "THUMBS_UP", "HEART"

    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }
}