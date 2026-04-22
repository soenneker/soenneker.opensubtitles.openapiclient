using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenSubtitles.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenSubtitlesOpenApiClientTests : HostedUnitTest
{
    public OpenSubtitlesOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
