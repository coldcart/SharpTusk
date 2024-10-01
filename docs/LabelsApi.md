# Tusk.Api.LabelsApi

All URIs are relative to *https://apisandbox.tusklogistics.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetaLabelbyID**](LabelsApi.md#getalabelbyid) | **GET** /v1/label/{label_id} | Get a Label by ID |
| [**PurchaseLabels**](LabelsApi.md#purchaselabels) | **POST** /v1/labels | Purchase Labels |
| [**VoidaLabel**](LabelsApi.md#voidalabel) | **POST** /v1/label/{label_id}/void | Void a Label |

<a id="getalabelbyid"></a>
# **GetaLabelbyID**
> Label GetaLabelbyID (int labelId)

Get a Label by ID

Returns information about a Label

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
    public class GetaLabelbyIDExample
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
            var apiInstance = new LabelsApi(httpClient, config, httpClientHandler);
            var labelId = 56;  // int | ID of Label to return

            try
            {
                // Get a Label by ID
                Label result = apiInstance.GetaLabelbyID(labelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LabelsApi.GetaLabelbyID: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetaLabelbyIDWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Label by ID
    ApiResponse<Label> response = apiInstance.GetaLabelbyIDWithHttpInfo(labelId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LabelsApi.GetaLabelbyIDWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **labelId** | **int** | ID of Label to return |  |

### Return type

[**Label**](Label.md)

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

<a id="purchaselabels"></a>
# **PurchaseLabels**
> ShipmentPurchaseResponse PurchaseLabels (V1LabelsRequest? v1LabelsRequest = null)

Purchase Labels

Purchase Labels. This will also create the Shipment provided. The number of labels purchased will match the number of parcels provided in the shipment.  At this time, there is only one service, \"Tusk Ground\". This endpoint will purchase Label(s) for that service.

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
    public class PurchaseLabelsExample
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
            var apiInstance = new LabelsApi(httpClient, config, httpClientHandler);
            var v1LabelsRequest = new V1LabelsRequest?(); // V1LabelsRequest? |  (optional) 

            try
            {
                // Purchase Labels
                ShipmentPurchaseResponse result = apiInstance.PurchaseLabels(v1LabelsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LabelsApi.PurchaseLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PurchaseLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Purchase Labels
    ApiResponse<ShipmentPurchaseResponse> response = apiInstance.PurchaseLabelsWithHttpInfo(v1LabelsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LabelsApi.PurchaseLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **v1LabelsRequest** | [**V1LabelsRequest?**](V1LabelsRequest?.md) |  | [optional]  |

### Return type

[**ShipmentPurchaseResponse**](ShipmentPurchaseResponse.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Resource created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="voidalabel"></a>
# **VoidaLabel**
> void VoidaLabel (int labelId)

Void a Label

Void the Label, setting its status to CANCELLED, ensuring it will not be charged. Only Labels in CREATED status can be voided.

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
    public class VoidaLabelExample
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
            var apiInstance = new LabelsApi(httpClient, config, httpClientHandler);
            var labelId = 56;  // int | ID of the Label to void.

            try
            {
                // Void a Label
                apiInstance.VoidaLabel(labelId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling LabelsApi.VoidaLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoidaLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Void a Label
    apiInstance.VoidaLabelWithHttpInfo(labelId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling LabelsApi.VoidaLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **labelId** | **int** | ID of the Label to void. |  |

### Return type

void (empty response body)

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

