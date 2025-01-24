using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

public class GitHubLink
{
    [JsonPropertyName("href")]
    public string Href { get; set; } = null!;
}