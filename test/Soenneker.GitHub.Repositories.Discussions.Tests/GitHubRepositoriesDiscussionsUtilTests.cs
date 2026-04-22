using Soenneker.GitHub.Repositories.Discussions.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.GitHub.Repositories.Discussions.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class GitHubRepositoriesDiscussionsUtilTests : HostedUnitTest
{
    private readonly IGitHubRepositoriesDiscussionsUtil _util;

    public GitHubRepositoriesDiscussionsUtilTests(Host host) : base(host)
    {
        _util = Resolve<IGitHubRepositoriesDiscussionsUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
