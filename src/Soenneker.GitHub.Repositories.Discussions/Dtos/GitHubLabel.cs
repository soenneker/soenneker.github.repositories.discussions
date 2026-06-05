using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub label.
/// </summary>
public class GitHubLabel
{
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
    /// Gets or sets url.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;

    /// <summary>
    /// Gets or sets name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    /// <summary>
    /// Gets or sets color.
    /// </summary>
    [JsonPropertyName("color")]
    public string Color { get; set; } = null!;

    /// <summary>
    /// Gets or sets a value indicating whether default.
    /// </summary>
    [JsonPropertyName("default")]
    public bool Default { get; set; }
}