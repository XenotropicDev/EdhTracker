# Org.OpenAPITools.Api.RulingsApi

All URIs are relative to *https://api.scryfall.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**RulingsGetByCodeByNumberId**](RulingsApi.md#rulingsgetbycodebynumberid) | **GET** /cards/{code}/{number}/rulings |  |
| [**RulingsGetById**](RulingsApi.md#rulingsgetbyid) | **GET** /cards/{id}/rulings |  |
| [**RulingsGetByMtgoId**](RulingsApi.md#rulingsgetbymtgoid) | **GET** /cards/mtgo/{id}/rulings |  |
| [**RulingsGetByMultiverseId**](RulingsApi.md#rulingsgetbymultiverseid) | **GET** /cards/multiverse/{id}/rulings |  |

<a id="rulingsgetbycodebynumberid"></a>
# **RulingsGetByCodeByNumberId**
> RulingList RulingsGetByCodeByNumberId (string code, int number)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulingsGetByCodeByNumberIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new RulingsApi(config);
            var code = "code_example";  // string | 
            var number = 56;  // int | 

            try
            {
                RulingList result = apiInstance.RulingsGetByCodeByNumberId(code, number);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulingsApi.RulingsGetByCodeByNumberId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulingsGetByCodeByNumberIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RulingList> response = apiInstance.RulingsGetByCodeByNumberIdWithHttpInfo(code, number);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulingsApi.RulingsGetByCodeByNumberIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **code** | **string** |  |  |
| **number** | **int** |  |  |

### Return type

[**RulingList**](RulingList.md)

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

<a id="rulingsgetbyid"></a>
# **RulingsGetById**
> RulingList RulingsGetById (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulingsGetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new RulingsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                RulingList result = apiInstance.RulingsGetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulingsApi.RulingsGetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulingsGetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RulingList> response = apiInstance.RulingsGetByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulingsApi.RulingsGetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**RulingList**](RulingList.md)

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

<a id="rulingsgetbymtgoid"></a>
# **RulingsGetByMtgoId**
> RulingList RulingsGetByMtgoId (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulingsGetByMtgoIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new RulingsApi(config);
            var id = 56;  // int | 

            try
            {
                RulingList result = apiInstance.RulingsGetByMtgoId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulingsApi.RulingsGetByMtgoId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulingsGetByMtgoIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RulingList> response = apiInstance.RulingsGetByMtgoIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulingsApi.RulingsGetByMtgoIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**RulingList**](RulingList.md)

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

<a id="rulingsgetbymultiverseid"></a>
# **RulingsGetByMultiverseId**
> RulingList RulingsGetByMultiverseId (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RulingsGetByMultiverseIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new RulingsApi(config);
            var id = 56;  // int | 

            try
            {
                RulingList result = apiInstance.RulingsGetByMultiverseId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RulingsApi.RulingsGetByMultiverseId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RulingsGetByMultiverseIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<RulingList> response = apiInstance.RulingsGetByMultiverseIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RulingsApi.RulingsGetByMultiverseIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**RulingList**](RulingList.md)

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

