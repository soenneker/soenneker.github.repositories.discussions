using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub links.
/// </summary>
public class GitHubLinks
{
    /// <summary>
    /// Gets or sets self.
    /// </summary>
    [JsonPropertyName("self")]
    public GitHubLink Self { get; set; } = null!;

    /// <summary>
    /// Gets or sets comments.
    /// </summary>
    [JsonPropertyName("comments")]
    public GitHubLink Comments { get; set; } = null!;

    /// <summary>
    /// Gets or sets category.
    /// </summary>
    [JsonPropertyName("category")]
    public GitHubLink Category { get; set; } = null!;

    /// <summary>
    /// Gets or sets author.
    /// </summary>
    [JsonPropertyName("author")]
    public GitHubLink Author { get; set; } = null!;

    /// <summary>
    /// Gets or sets editor.
    /// </summary>
    [JsonPropertyName("editor")]
    public GitHubLink? Editor { get; set; }

    /// <summary>
    /// Gets or sets pull request.
    /// </summary>
    [JsonPropertyName("pull_request")]
    public GitHubLink? PullRequest { get; set; }

    /// <summary>
    /// Gets or sets closed by.
    /// </summary>
    [JsonPropertyName("closed_by")]
    public GitHubLink? ClosedBy { get; set; }
}