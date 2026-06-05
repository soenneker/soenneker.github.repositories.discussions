using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub team.
/// </summary>
public class GitHubTeam
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
    /// Gets or sets html url.
    /// </summary>
    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; } = null!;

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
    /// Gets or sets privacy.
    /// </summary>
    [JsonPropertyName("privacy")]
    public string Privacy { get; set; } = null!;

    /// <summary>
    /// Gets or sets permission.
    /// </summary>
    [JsonPropertyName("permission")]
    public string Permission { get; set; } = null!;

    /// <summary>
    /// Gets or sets members url.
    /// </summary>
    [JsonPropertyName("members_url")]
    public string MembersUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets repositories url.
    /// </summary>
    [JsonPropertyName("repositories_url")]
    public string RepositoriesUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets parent.
    /// </summary>
    [JsonPropertyName("parent")]
    public GitHubTeam? Parent { get; set; }
}