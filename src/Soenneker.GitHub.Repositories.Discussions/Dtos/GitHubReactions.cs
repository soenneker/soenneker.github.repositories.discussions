using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub reactions.
/// </summary>
public class GitHubReactions
{
    /// <summary>
    /// Gets or sets total count.
    /// </summary>
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }

    /// <summary>
    /// Gets or sets plus one.
    /// </summary>
    [JsonPropertyName("plus_one")]
    public int PlusOne { get; set; }

    /// <summary>
    /// Gets or sets minus one.
    /// </summary>
    [JsonPropertyName("minus_one")]
    public int MinusOne { get; set; }

    /// <summary>
    /// Gets or sets laugh.
    /// </summary>
    [JsonPropertyName("laugh")]
    public int Laugh { get; set; }

    /// <summary>
    /// Gets or sets hooray.
    /// </summary>
    [JsonPropertyName("hooray")]
    public int Hooray { get; set; }

    /// <summary>
    /// Gets or sets confused.
    /// </summary>
    [JsonPropertyName("confused")]
    public int Confused { get; set; }

    /// <summary>
    /// Gets or sets heart.
    /// </summary>
    [JsonPropertyName("heart")]
    public int Heart { get; set; }

    /// <summary>
    /// Gets or sets rocket.
    /// </summary>
    [JsonPropertyName("rocket")]
    public int Rocket { get; set; }

    /// <summary>
    /// Gets or sets eyes.
    /// </summary>
    [JsonPropertyName("eyes")]
    public int Eyes { get; set; }
}