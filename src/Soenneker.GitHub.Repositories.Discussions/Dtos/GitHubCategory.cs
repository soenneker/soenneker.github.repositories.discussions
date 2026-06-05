using System;
using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub category.
/// </summary>
public class GitHubCategory
{
    /// <summary>
    /// Gets or sets id.
    /// </summary>
    [JsonPropertyName("id")]
    public long Id { get; set; }

    /// <summary>
    /// Gets or sets name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Gets or sets slug.
    /// </summary>
    [JsonPropertyName("slug")]
    public string Slug { get; set; } = null!;

    /// <summary>
    /// Gets or sets description.
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

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
    /// Gets or sets a value indicating whether emojis enabled.
    /// </summary>
    [JsonPropertyName("emojis_enabled")]
    public bool EmojisEnabled { get; set; }
}