using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

public class GitHubTeam
{
    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("node_id")]
    public string NodeId { get; set; } = null!;

    [JsonPropertyName("url")]
    public string Url { get; set; } = null!;

    [JsonPropertyName("html_url")]
    public string HtmlUrl { get; set; } = null!;

    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    [JsonPropertyName("slug")]
    public string Slug { get; set; } = null!;

    [JsonPropertyName("description")]
    public string Description { get; set; } = null!;

    [JsonPropertyName("privacy")]
    public string Privacy { get; set; } = null!;

    [JsonPropertyName("permission")]
    public string Permission { get; set; } = null!;

    [JsonPropertyName("members_url")]
    public string MembersUrl { get; set; } = null!;

    [JsonPropertyName("repositories_url")]
    public string RepositoriesUrl { get; set; } = null!;

    [JsonPropertyName("parent")]
    public GitHubTeam? Parent { get; set; }
}