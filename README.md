[![](https://img.shields.io/nuget/v/soenneker.github.repositories.discussions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.github.repositories.discussions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.github.repositories.discussions/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.github.repositories.discussions/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.github.repositories.discussions.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.github.repositories.discussions/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.github.repositories.discussions/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.github.repositories.discussions/actions/workflows/codeql.yml)

# Soenneker.GitHub.Repositories.Discussions

Creates, lists, filters, and deletes GitHub repository discussions.

## Installation

```bash
dotnet add package Soenneker.GitHub.Repositories.Discussions
```

## Configure and register

```json
{
  "GH": {
    "Token": "your-github-token"
  }
}
```

```csharp
using Soenneker.GitHub.Repositories.Discussions.Registrars;

services.AddGitHubRepositoriesDiscussionsUtilAsSingleton();
```

The token needs access to repository discussions and write permission for creation or deletion.

## Create a discussion

```csharp
await discussions.Add(
    "example-org",
    "example-repository",
    new GitHubDiscussion
    {
        Title = "Release feedback",
        Body = "Share feedback for the latest release.",
        Category = new GitHubCategory { Id = categoryId }
    },
    cancellationToken);
```

Creation sends the discussion title, body, and category ID. A failed request throws; it is not logged as a successful creation.

## List discussions

```csharp
List<GitHubDiscussion> open = await discussions.GetAll(
    "example-org",
    "example-repository",
    state: "open",
    cancellationToken: cancellationToken);
```

`GetAll()` follows every page and applies the optional state filter case-insensitively. `GetAllForOwner()` first selects repositories with discussions enabled, honors the repository creation-date window, and then reads each repository sequentially.

`Delete()` and `DeleteAll()` permanently remove discussions. `DeleteAll()` first retrieves the complete discussion list and then deletes each item; a failure stops the operation and can leave earlier deletions completed.
