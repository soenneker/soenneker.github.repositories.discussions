using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Soenneker.GitHub.Repositories.Discussions;

[JsonSourceGenerationOptions(JsonSerializerDefaults.Web)]
[JsonSerializable(typeof(System.Collections.Generic.List<Dtos.GitHubDiscussion>))]
internal partial class AotJsonContext : JsonSerializerContext
{
    internal static JsonTypeInfo<T> Get<T>(JsonSerializerOptions? options = null) =>
        (JsonTypeInfo<T>)((options is null ? Default : new AotJsonContext(new JsonSerializerOptions(options))).GetTypeInfo(typeof(T))
            ?? throw new NotSupportedException($"No generated JSON metadata for {typeof(T)}."));
}
