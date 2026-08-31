[![](https://img.shields.io/nuget/v/soenneker.opensubtitles.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.opensubtitles.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.opensubtitles.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.opensubtitles.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.opensubtitles.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.opensubtitles.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.opensubtitles.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.opensubtitles.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.OpenSubtitles.OpenApiClient

Typed request builders and models for searching and downloading subtitles through the OpenSubtitles REST API.

## Installation

```bash
dotnet add package Soenneker.OpenSubtitles.OpenApiClient
```

## Usage

```csharp
using System.Net.Http.Headers;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.OpenSubtitles.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("Api-Key", apiKey);
httpClient.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue("Bearer", userToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new OpenSubtitlesOpenApiClient(adapter);
var subtitles = await client.Subtitles.GetAsync(request =>
{
    request.QueryParameters.Query = "Arrival";
    request.QueryParameters.Languages = "en";
}, cancellationToken);
```

The client defaults to `https://api.opensubtitles.com/api/v1`. Every API request needs the application `Api-Key`; user-specific operations additionally need a bearer token.

For configuration-based credentials and managed client reuse, use [`Soenneker.OpenSubtitles.OpenApiClientUtil`](https://github.com/soenneker/soenneker.opensubtitles.openapiclientutil).
