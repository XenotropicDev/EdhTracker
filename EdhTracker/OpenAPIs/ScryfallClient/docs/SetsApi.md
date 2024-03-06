# Org.OpenAPITools.Api.SetsApi

All URIs are relative to *https://api.scryfall.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**SetsGetAll**](SetsApi.md#setsgetall) | **GET** /sets |  |
| [**SetsGetByCode**](SetsApi.md#setsgetbycode) | **GET** /sets/{code} |  |

<a id="setsgetall"></a>
# **SetsGetAll**
> SetList SetsGetAll ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SetsGetAllExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new SetsApi(config);

            try
            {
                SetList result = apiInstance.SetsGetAll();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetsApi.SetsGetAll: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetsGetAllWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SetList> response = apiInstance.SetsGetAllWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetsApi.SetsGetAllWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**SetList**](SetList.md)

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

<a id="setsgetbycode"></a>
# **SetsGetByCode**
> Set SetsGetByCode (string code)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SetsGetByCodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new SetsApi(config);
            var code = "code_example";  // string | 

            try
            {
                Set result = apiInstance.SetsGetByCode(code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SetsApi.SetsGetByCode: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetsGetByCodeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Set> response = apiInstance.SetsGetByCodeWithHttpInfo(code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SetsApi.SetsGetByCodeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** |  |  |

### Return type

[**Set**](Set.md)

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

