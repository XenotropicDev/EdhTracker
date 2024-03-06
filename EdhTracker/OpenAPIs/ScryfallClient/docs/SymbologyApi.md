# Org.OpenAPITools.Api.SymbologyApi

All URIs are relative to *https://api.scryfall.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SymbologyGetAll**](SymbologyApi.md#symbologygetall) | **GET** /symbology |  |
| [**SymbologyParseMana**](SymbologyApi.md#symbologyparsemana) | **GET** /symbology/parse-mana |  |

<a id="symbologygetall"></a>
# **SymbologyGetAll**
> CardSymbolList SymbologyGetAll ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SymbologyGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new SymbologyApi(config);

            try
            {
                CardSymbolList result = apiInstance.SymbologyGetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymbologyApi.SymbologyGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SymbologyGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CardSymbolList> response = apiInstance.SymbologyGetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymbologyApi.SymbologyGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CardSymbolList**](CardSymbolList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="symbologyparsemana"></a>
# **SymbologyParseMana**
> ManaCost SymbologyParseMana (string cost)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SymbologyParseManaExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new SymbologyApi(config);
            var cost = "cost_example";  // string | 

            try
            {
                ManaCost result = apiInstance.SymbologyParseMana(cost);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SymbologyApi.SymbologyParseMana: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SymbologyParseManaWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ManaCost> response = apiInstance.SymbologyParseManaWithHttpInfo(cost);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SymbologyApi.SymbologyParseManaWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cost** | **string** |  |  |

### Return type

[**ManaCost**](ManaCost.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

