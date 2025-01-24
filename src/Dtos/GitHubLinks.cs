using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

public class GitHubLinks
{
    [JsonPropertyName("self")]
    public GitHubLink Self { get; set; } = null!;

    [JsonPropertyName("comments")]
    public GitHubLink Comments { get; set; } = null!;

    [JsonPropertyName("category")]
    public GitHubLink Category { get; set; } = null!;

    [JsonPropertyName("author")]
    public GitHubLink Author { get; set; } = null!;

    [JsonPropertyName("editor")]
    public GitHubLink? Editor { get; set; }

    [JsonPropertyName("pull_request")]
    public GitHubLink? PullRequest { get; set; }

    [JsonPropertyName("closed_by")]
    public GitHubLink? ClosedBy { get; set; }
}