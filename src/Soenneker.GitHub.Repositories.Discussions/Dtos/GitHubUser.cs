using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

/// <summary>
/// Represents the git hub user.
/// </summary>
public class GitHubUser
{
    /// <summary>
    /// Gets or sets login.
    /// </summary>
    [JsonPropertyName("login")]
    public string Login { get; set; } = null!;

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
    /// Gets or sets avatar url.
    /// </summary>
    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets gravatar id.
    /// </summary>
    [JsonPropertyName("gravatar_id")]
    public string GravatarId { get; set; } = null!;

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
    /// Gets or sets followers url.
    /// </summary>
    [JsonPropertyName("followers_url")]
    public string FollowersUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets following url.
    /// </summary>
    [JsonPropertyName("following_url")]
    public string FollowingUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets gists url.
    /// </summary>
    [JsonPropertyName("gists_url")]
    public string GistsUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets starred url.
    /// </summary>
    [JsonPropertyName("starred_url")]
    public string StarredUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets subscriptions url.
    /// </summary>
    [JsonPropertyName("subscriptions_url")]
    public string SubscriptionsUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets organizations url.
    /// </summary>
    [JsonPropertyName("organizations_url")]
    public string OrganizationsUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets repos url.
    /// </summary>
    [JsonPropertyName("repos_url")]
    public string ReposUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets events url.
    /// </summary>
    [JsonPropertyName("events_url")]
    public string EventsUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets received events url.
    /// </summary>
    [JsonPropertyName("received_events_url")]
    public string ReceivedEventsUrl { get; set; } = null!;

    /// <summary>
    /// Gets or sets type.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = null!; // e.g., "User", "Organization"

    /// <summary>
    /// Gets or sets a value indicating whether site admin.
    /// </summary>
    [JsonPropertyName("site_admin")]
    public bool SiteAdmin { get; set; }
}