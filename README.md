# Tusk - the C# library for the Tusk Logistics API

This is an experimental C# SDK for the Tusk Logistics API. Most of it was generated by the [OpenAPI Generator](https://openapi-generator.tech) project. However, some manual changes were made to the generated code to make it more C#-friendly.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.0
- Generator version: 7.8.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [System.Text.Json](https://www.nuget.org/packages/System.Text.Json/) - 7.0.0 or later
- [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection) - 7.0.0 or later
- [Microsoft.Extensions.Options](https://www.nuget.org/packages/Microsoft.Extensions.Options) - 7.0.0 or later
- [Microsoft.Extensions.Http](https://www.nuget.org/packages/Microsoft.Extensions.Http) - 7.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package System.Text.Json
Install-Package Microsoft.Extensions.DependencyInjection
Install-Package Microsoft.Extensions.Options
Install-Package Microsoft.Extensions.Http
```
<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Tusk.Api;
using Tusk.Client;
using Tusk.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Tusk.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

### Connections
Each ApiClass (properly the ApiClient inside it) will create an instance of HttpClient. It will use that for the entire lifecycle and dispose it when called the Dispose method.

To better manager the connections it's a common practice to reuse the HttpClient and HttpClientHandler (see [here](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests#issues-with-the-original-httpclient-class-available-in-net) for details). To use your own HttpClient instance just pass it to the ApiClass constructor.

```csharp
HttpClientHandler yourHandler = new HttpClientHandler();
HttpClient yourHttpClient = new HttpClient(yourHandler);
var api = new YourApiClass(yourHttpClient, yourHandler);
```

If you want to use an HttpClient and don't have access to the handler, for example in a DI context in Asp.net Core when using IHttpClientFactory.

```csharp
HttpClient yourHttpClient = new HttpClient();
var api = new YourApiClass(yourHttpClient);
```
You'll loose some configuration settings, the features affected are: Setting and Retrieving Cookies, Client Certificates, Proxy settings. You need to either manually handle those in your setup of the HttpClient or they won't be available.

Here an example of DI setup in a sample web project:

```csharp
services.AddHttpClient<YourApiClass>(httpClient =>
   new PetApi(httpClient));
```


<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Tusk.Api;
using Tusk.Client;
using Tusk.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://apisandbox.tusklogistics.com";
            // Configure API key authorization: ApiKeyAuth
            config.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("x-api-key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new LabelsApi(httpClient, config, httpClientHandler);
            var labelId = 56;  // int | ID of Label to return

            try
            {
                // Get a Label by ID
                Label result = apiInstance.GetaLabelbyID(labelId);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling LabelsApi.GetaLabelbyID: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

## Instantiating the TuskClient

The Tusk Client Library provides two main ways to instantiate the `TuskClient`: using dependency injection (DI) or manual instantiation.

### Using Dependency Injection (Recommended)

Dependency Injection is the recommended approach for most applications, especially those using ASP.NET Core or other DI-friendly frameworks.

1. In your `Startup.cs` or wherever you configure your services, add the following:

```csharp
using Tusk.Client;
public void ConfigureServices(IServiceCollection services)
{
    services.AddTuskClient(options =>
    {
        options.BaseUrl = "https://api.tusklogistics.com"; // Optional: Defaults to Tusk API URL
        options.ApiKey = "your-api-key-here";
        options.MaxRetries = 3; // Optional: Default is 3
        options.RetryDelay = TimeSpan.FromSeconds(1); // Optional: Default is 2 seconds
    }, useRetryHandler: true);
    // ... other service configurations
}
```
2. Then, you can inject `TuskClient` into your classes:

```csharp
public class YourService
{
    private readonly TuskClient _tuskClient;

    public YourService(TuskClient tuskClient)
    {
        _tuskClient = tuskClient;
    }

    public async Task<Label> GetLabelById(int labelId)
    {
        return await _tuskClient.LabelsApi.GetaLabelbyID(labelId);
    }
}
```

### Manual Instantiation

For scenarios where you're not using a DI container, you can manually create an instance of `TuskClient` using the `Create` method:


```csharp
using Tusk.Client;
var tuskClient = Helpers.Create(options =>
{
    options.BaseUrl = "https://api.tusklogistics.com"; // Optional: Defaults to Tusk API URL
    options.ApiKey = "your-api-key-here";
    options.MaxRetries = 3; // Optional: Default is 3
options.RetryDelay = TimeSpan.FromSeconds(1); // Optional: Default is 2 seconds
}, useRetryHandler: true);
// Use the client
var result = await tuskClient.LabelsApi.GetLabelAsync("label_id");
```
Remember to dispose of the `TuskClient` when you're done with it if you're not using DI:

```csharp
tuskClient.Dispose();
```

### Notes

- The `useRetryHandler` parameter (default: `false`) enables automatic retrying of failed requests. When `true`, it uses the `MaxRetries` and `RetryDelay` settings from the options.
- Always keep your API key secure and never hard-code it in your source files. Use environment variables or secure configuration management for production environments.
- The `TuskClient` is thread-safe and designed to be used as a singleton. In DI scenarios, it's registered with a scoped lifetime by default.


<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://apisandbox.tusklogistics.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*LabelsApi* | [**GetaLabelbyID**](docs/LabelsApi.md#getalabelbyid) | **GET** /v1/label/{label_id} | Get a Label by ID
*LabelsApi* | [**PurchaseLabels**](docs/LabelsApi.md#purchaselabels) | **POST** /v1/labels | Purchase Labels
*LabelsApi* | [**VoidaLabel**](docs/LabelsApi.md#voidalabel) | **POST** /v1/label/{label_id}/void | Void a Label
*LocationsApi* | [**GetallshipfromLocations**](docs/LocationsApi.md#getallshipfromlocations) | **GET** /v1/location | Get all ship from Locations
*ManifestApi* | [**AddLabelstoManifest**](docs/ManifestApi.md#addlabelstomanifest) | **POST** /v1/manifest/{manifest_id}/addlabels | Add Labels to Manifest
*ManifestApi* | [**CreateaManifest**](docs/ManifestApi.md#createamanifest) | **POST** /v1/manifest/create | Create a Manifest
*ManifestApi* | [**GetaManifestbyID**](docs/ManifestApi.md#getamanifestbyid) | **GET** /v1/manifest/{manifest_id} | Get a Manifest by ID
*ManifestApi* | [**RemoveLabelsfromManifest**](docs/ManifestApi.md#removelabelsfrommanifest) | **POST** /v1/manifest/{manifest_id}/removelabels | Remove Labels from Manifest
*RatesApi* | [**CheckRates**](docs/RatesApi.md#checkrates) | **POST** /v1/rate/check | Check Rates
*ShipmentsApi* | [**GetaShipmentbyID**](docs/ShipmentsApi.md#getashipmentbyid) | **GET** /v1/shipment/{shipment_id} | Get a Shipment by ID
*TrackingApi* | [**GetLabelTrackingHistory**](docs/TrackingApi.md#getlabeltrackinghistory) | **GET** /v1/tracking/label/{label_id}/history | Get Label Tracking History
*TrackingApi* | [**GetLabelTrackingStatus**](docs/TrackingApi.md#getlabeltrackingstatus) | **GET** /v1/tracking/label/{label_id} | Get Label Tracking Status
*TrackingApi* | [**GetShipmentTracking**](docs/TrackingApi.md#getshipmenttracking) | **GET** /v1/tracking/{tracking_number} | Get Shipment Tracking


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.APIError](docs/APIError.md)
 - [Model.Address](docs/Address.md)
 - [Model.CreateShipment](docs/CreateShipment.md)
 - [Model.Delivery](docs/Delivery.md)
 - [Model.Dimensions](docs/Dimensions.md)
 - [Model.Label](docs/Label.md)
 - [Model.Location](docs/Location.md)
 - [Model.Manifest](docs/Manifest.md)
 - [Model.ManifestException](docs/ManifestException.md)
 - [Model.ManifestLabel](docs/ManifestLabel.md)
 - [Model.ManifestOperationResponse](docs/ManifestOperationResponse.md)
 - [Model.Parcel](docs/Parcel.md)
 - [Model.ParcelDimensions](docs/ParcelDimensions.md)
 - [Model.ParcelWeight](docs/ParcelWeight.md)
 - [Model.RateCheck](docs/RateCheck.md)
 - [Model.Shipment](docs/Shipment.md)
 - [Model.ShipmentLabel](docs/ShipmentLabel.md)
 - [Model.ShipmentPurchaseResponse](docs/ShipmentPurchaseResponse.md)
 - [Model.TrackingEvent](docs/TrackingEvent.md)
 - [Model.TrackingLabel](docs/TrackingLabel.md)
 - [Model.TrackingLabelHistory](docs/TrackingLabelHistory.md)
 - [Model.TrackingLabelLocation](docs/TrackingLabelLocation.md)
 - [Model.TrackingLocation](docs/TrackingLocation.md)
 - [Model.TrackingShipment](docs/TrackingShipment.md)
 - [Model.TrackingShipmentLabel](docs/TrackingShipmentLabel.md)
 - [Model.V1LabelsRequest](docs/V1LabelsRequest.md)
 - [Model.V1ManifestAddlabelsRequest](docs/V1ManifestAddlabelsRequest.md)
 - [Model.V1ManifestCreateRequest](docs/V1ManifestCreateRequest.md)
 - [Model.V1ManifestRemovelabelsRequest](docs/V1ManifestRemovelabelsRequest.md)
 - [Model.V1RateCheckRequest](docs/V1RateCheckRequest.md)
 - [Model.V1TrackingLabelHistoryResponse](docs/V1TrackingLabelHistoryResponse.md)
 - [Model.Weight](docs/Weight.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="ApiKeyAuth"></a>
### ApiKeyAuth

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header

