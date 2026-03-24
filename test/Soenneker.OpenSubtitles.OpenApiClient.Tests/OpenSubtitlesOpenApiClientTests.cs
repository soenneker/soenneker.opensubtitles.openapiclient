using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.OpenSubtitles.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class OpenSubtitlesOpenApiClientTests : FixturedUnitTest
{
    public OpenSubtitlesOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
