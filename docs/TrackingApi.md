# Tusk.Api.TrackingApi

All URIs are relative to *https://apisandbox.tusklogistics.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetLabelTrackingHistory**](TrackingApi.md#getlabeltrackinghistory) | **GET** /v1/tracking/label/{label_id}/history | Get Label Tracking History |
| [**GetLabelTrackingStatus**](TrackingApi.md#getlabeltrackingstatus) | **GET** /v1/tracking/label/{label_id} | Get Label Tracking Status |
| [**GetShipmentTracking**](TrackingApi.md#getshipmenttracking) | **GET** /v1/tracking/{tracking_number} | Get Shipment Tracking |

<a id="getlabeltrackinghistory"></a>
# **GetLabelTrackingHistory**
> V1TrackingLabelHistoryResponse GetLabelTrackingHistory (int labelId)

Get Label Tracking History

Get the full tracking history for a label

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
    public class GetLabelTrackingHistoryExample
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
            var apiInstance = new TrackingApi(httpClient, config, httpClientHandler);
            var labelId = 56;  // int | LabelID to return tracking for

            try
            {
                // Get Label Tracking History
                V1TrackingLabelHistoryResponse result = apiInstance.GetLabelTrackingHistory(labelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingApi.GetLabelTrackingHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLabelTrackingHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Label Tracking History
    ApiResponse<V1TrackingLabelHistoryResponse> response = apiInstance.GetLabelTrackingHistoryWithHttpInfo(labelId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingApi.GetLabelTrackingHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **labelId** | **int** | LabelID to return tracking for |  |

### Return type

[**V1TrackingLabelHistoryResponse**](V1TrackingLabelHistoryResponse.md)

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

<a id="getlabeltrackingstatus"></a>
# **GetLabelTrackingStatus**
> TrackingLabel GetLabelTrackingStatus (int labelId)

Get Label Tracking Status

Get the latest status and location

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
    public class GetLabelTrackingStatusExample
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
            var apiInstance = new TrackingApi(httpClient, config, httpClientHandler);
            var labelId = 56;  // int | LabelID to return tracking for

            try
            {
                // Get Label Tracking Status
                TrackingLabel result = apiInstance.GetLabelTrackingStatus(labelId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingApi.GetLabelTrackingStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLabelTrackingStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Label Tracking Status
    ApiResponse<TrackingLabel> response = apiInstance.GetLabelTrackingStatusWithHttpInfo(labelId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingApi.GetLabelTrackingStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **labelId** | **int** | LabelID to return tracking for |  |

### Return type

[**TrackingLabel**](TrackingLabel.md)

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

<a id="getshipmenttracking"></a>
# **GetShipmentTracking**
> TrackingShipment GetShipmentTracking (string trackingNumber)

Get Shipment Tracking

Get the tracking history for an entire Shipment

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
    public class GetShipmentTrackingExample
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
            var apiInstance = new TrackingApi(httpClient, config, httpClientHandler);
            var trackingNumber = "trackingNumber_example";  // string | Tracking number for the Shipment

            try
            {
                // Get Shipment Tracking
                TrackingShipment result = apiInstance.GetShipmentTracking(trackingNumber);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TrackingApi.GetShipmentTracking: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetShipmentTrackingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Shipment Tracking
    ApiResponse<TrackingShipment> response = apiInstance.GetShipmentTrackingWithHttpInfo(trackingNumber);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TrackingApi.GetShipmentTrackingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **trackingNumber** | **string** | Tracking number for the Shipment |  |

### Return type

[**TrackingShipment**](TrackingShipment.md)

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

