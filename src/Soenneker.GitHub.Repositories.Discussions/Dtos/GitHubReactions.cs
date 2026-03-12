using System.Text.Json.Serialization;

namespace Soenneker.GitHub.Repositories.Discussions.Dtos;

public class GitHubReactions
{
    [JsonPropertyName("total_count")]
    public int TotalCount { get; set; }

    [JsonPropertyName("plus_one")]
    public int PlusOne { get; set; }

    [JsonPropertyName("minus_one")]
    public int MinusOne { get; set; }

    [JsonPropertyName("laugh")]
    public int Laugh { get; set; }

    [JsonPropertyName("hooray")]
    public int Hooray { get; set; }

    [JsonPropertyName("confused")]
    public int Confused { get; set; }

    [JsonPropertyName("heart")]
    public int Heart { get; set; }

    [JsonPropertyName("rocket")]
    public int Rocket { get; set; }

    [JsonPropertyName("eyes")]
    public int Eyes { get; set; }
}