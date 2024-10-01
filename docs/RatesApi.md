# Tusk.Api.RatesApi

All URIs are relative to *https://apisandbox.tusklogistics.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CheckRates**](RatesApi.md#checkrates) | **POST** /v1/rate/check | Check Rates |

<a id="checkrates"></a>
# **CheckRates**
> List&lt;RateCheck&gt; CheckRates (V1RateCheckRequest? v1RateCheckRequest = null)

Check Rates

Returns a list of objects containing rate information for a simplified Shipment request.

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
    public class CheckRatesExample
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
            var apiInstance = new RatesApi(httpClient, config, httpClientHandler);
            var v1RateCheckRequest = new V1RateCheckRequest?(); // V1RateCheckRequest? |  (optional) 

            try
            {
                // Check Rates
                List<RateCheck> result = apiInstance.CheckRates(v1RateCheckRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RatesApi.CheckRates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CheckRatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check Rates
    ApiResponse<List<RateCheck>> response = apiInstance.CheckRatesWithHttpInfo(v1RateCheckRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RatesApi.CheckRatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **v1RateCheckRequest** | [**V1RateCheckRequest?**](V1RateCheckRequest?.md) |  | [optional]  |

### Return type

[**List&lt;RateCheck&gt;**](RateCheck.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Resource Created |  -  |
| **400** | Bad Request |  -  |
| **401** | Unauthorized |  -  |
| **422** | Unprocessable Entity |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

