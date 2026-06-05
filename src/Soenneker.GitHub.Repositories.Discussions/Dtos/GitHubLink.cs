using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub link.
/// </summary>
public class GitHubLink
{
    /// <summary>
    /// Gets or sets href.
    /// </summary>
    [JsonPropertyName("href")]
    public string Href { get; set; } = null!;
}