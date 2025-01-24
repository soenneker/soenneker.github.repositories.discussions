using Soenneker.GitHub.Repositories.Discussions.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.GitHub.Repositories.Discussions.Tests;

[Collection("Collection")]
public class GitHubRepositoriesDiscussionsUtilTests : FixturedUnitTest
{
    private readonly IGitHubRepositoriesDiscussionsUtil _util;

    public GitHubRepositoriesDiscussionsUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _util = Resolve<IGitHubRepositoriesDiscussionsUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
