using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.GitHub.Client.Http.Registrars;
using Soenneker.GitHub.Repositories.Discussions.Abstract;
using Soenneker.GitHub.Repositories.Registrars;

namespace Soenneker.GitHub.Repositories.Discussions.Registrars;

/// <summary>
/// A utility library for GitHub repository discussion related operations
/// </summary>
public static class GitHubRepositoriesDiscussionsUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="IGitHubRepositoriesDiscussionsUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddGitHubRepositoriesDiscussionsUtilAsSingleton(this IServiceCollection services)
    {
        services.AddGitHubHttpClientAsSingleton()
                .AddGitHubRepositoriesUtilAsSingleton()
                .TryAddSingleton<IGitHubRepositoriesDiscussionsUtil, GitHubRepositoriesDiscussionsUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="IGitHubRepositoriesDiscussionsUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddGitHubRepositoriesDiscussionsUtilAsScoped(this IServiceCollection services)
    {
        services.AddGitHubHttpClientAsSingleton()
                .AddGitHubRepositoriesUtilAsScoped()
                .TryAddScoped<IGitHubRepositoriesDiscussionsUtil, GitHubRepositoriesDiscussionsUtil>();

        return services;
    }
}