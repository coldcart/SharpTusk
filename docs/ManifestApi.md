# Tusk.Api.ManifestApi

All URIs are relative to *https://apisandbox.tusklogistics.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddLabelstoManifest**](ManifestApi.md#addlabelstomanifest) | **POST** /v1/manifest/{manifest_id}/addlabels | Add Labels to Manifest |
| [**CreateaManifest**](ManifestApi.md#createamanifest) | **POST** /v1/manifest/create | Create a Manifest |
| [**GetaManifestbyID**](ManifestApi.md#getamanifestbyid) | **GET** /v1/manifest/{manifest_id} | Get a Manifest by ID |
| [**RemoveLabelsfromManifest**](ManifestApi.md#removelabelsfrommanifest) | **POST** /v1/manifest/{manifest_id}/removelabels | Remove Labels from Manifest |

<a id="addlabelstomanifest"></a>
# **AddLabelstoManifest**
> ManifestOperationResponse AddLabelstoManifest (int manifestId, V1ManifestAddlabelsRequest? v1ManifestAddlabelsRequest = null)

Add Labels to Manifest

Add labels to an existing manifest

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Tusk.Api;
using Tusk.Client;
using Tusk.Model;

namespace Example
{
    public class AddLabelstoManifestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apisandbox.tusklogistics.com";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ManifestApi(httpClient, config, httpClientHandler);
            var manifestId = 56;  // int | ID of Manifest to operate
            var v1ManifestAddlabelsRequest = new V1ManifestAddlabelsRequest?(); // V1ManifestAddlabelsRequest? |  (optional) 

            try
            {
                // Add Labels to Manifest
                ManifestOperationResponse result = apiInstance.AddLabelstoManifest(manifestId, v1ManifestAddlabelsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManifestApi.AddLabelstoManifest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddLabelstoManifestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Labels to Manifest
    ApiResponse<ManifestOperationResponse> response = apiInstance.AddLabelstoManifestWithHttpInfo(manifestId, v1ManifestAddlabelsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManifestApi.AddLabelstoManifestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **manifestId** | **int** | ID of Manifest to operate |  |
| **v1ManifestAddlabelsRequest** | [**V1ManifestAddlabelsRequest?**](V1ManifestAddlabelsRequest?.md) |  | [optional]  |

### Return type

[**ManifestOperationResponse**](ManifestOperationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createamanifest"></a>
# **CreateaManifest**
> ManifestOperationResponse CreateaManifest (V1ManifestCreateRequest? v1ManifestCreateRequest = null)

Create a Manifest

Create manifest for a location with or without labels.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Tusk.Api;
using Tusk.Client;
using Tusk.Model;

namespace Example
{
    public class CreateaManifestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apisandbox.tusklogistics.com";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ManifestApi(httpClient, config, httpClientHandler);
            var v1ManifestCreateRequest = new V1ManifestCreateRequest?(); // V1ManifestCreateRequest? |  (optional) 

            try
            {
                // Create a Manifest
                ManifestOperationResponse result = apiInstance.CreateaManifest(v1ManifestCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManifestApi.CreateaManifest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateaManifestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Manifest
    ApiResponse<ManifestOperationResponse> response = apiInstance.CreateaManifestWithHttpInfo(v1ManifestCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManifestApi.CreateaManifestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **v1ManifestCreateRequest** | [**V1ManifestCreateRequest?**](V1ManifestCreateRequest?.md) |  | [optional]  |

### Return type

[**ManifestOperationResponse**](ManifestOperationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getamanifestbyid"></a>
# **GetaManifestbyID**
> Manifest GetaManifestbyID (int manifestId)

Get a Manifest by ID

Create manifest for a location with or without labels.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Tusk.Api;
using Tusk.Client;
using Tusk.Model;

namespace Example
{
    public class GetaManifestbyIDExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apisandbox.tusklogistics.com";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ManifestApi(httpClient, config, httpClientHandler);
            var manifestId = 56;  // int | ID of Manifest to return

            try
            {
                // Get a Manifest by ID
                Manifest result = apiInstance.GetaManifestbyID(manifestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManifestApi.GetaManifestbyID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetaManifestbyIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Manifest by ID
    ApiResponse<Manifest> response = apiInstance.GetaManifestbyIDWithHttpInfo(manifestId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManifestApi.GetaManifestbyIDWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **manifestId** | **int** | ID of Manifest to return |  |

### Return type

[**Manifest**](Manifest.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removelabelsfrommanifest"></a>
# **RemoveLabelsfromManifest**
> ManifestOperationResponse RemoveLabelsfromManifest (int manifestId, V1ManifestRemovelabelsRequest? v1ManifestRemovelabelsRequest = null)

Remove Labels from Manifest

Remove labels to an existing manifest

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Tusk.Api;
using Tusk.Client;
using Tusk.Model;

namespace Example
{
    public class RemoveLabelsfromManifestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://apisandbox.tusklogistics.com";
            // Configure API key authorization: ApiKeyAuth
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new ManifestApi(httpClient, config, httpClientHandler);
            var manifestId = 56;  // int | ID of Manifest to operate
            var v1ManifestRemovelabelsRequest = new V1ManifestRemovelabelsRequest?(); // V1ManifestRemovelabelsRequest? |  (optional) 

            try
            {
                // Remove Labels from Manifest
                ManifestOperationResponse result = apiInstance.RemoveLabelsfromManifest(manifestId, v1ManifestRemovelabelsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManifestApi.RemoveLabelsfromManifest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveLabelsfromManifestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Labels from Manifest
    ApiResponse<ManifestOperationResponse> response = apiInstance.RemoveLabelsfromManifestWithHttpInfo(manifestId, v1ManifestRemovelabelsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManifestApi.RemoveLabelsfromManifestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **manifestId** | **int** | ID of Manifest to operate |  |
| **v1ManifestRemovelabelsRequest** | [**V1ManifestRemovelabelsRequest?**](V1ManifestRemovelabelsRequest?.md) |  | [optional]  |

### Return type

[**ManifestOperationResponse**](ManifestOperationResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

