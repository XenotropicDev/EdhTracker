# Org.OpenAPITools.Api.CardsApi

All URIs are relative to *https://api.scryfall.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CardsAutocomplete**](CardsApi.md#cardsautocomplete) | **GET** /cards/autocomplete |  |
| [**GetByArenaId**](CardsApi.md#Getbyarenaid) | **GET** /cards/arena/{id} |  |
| [**GetByCodeByNumber**](CardsApi.md#Getbycodebynumber) | **GET** /cards/{code}/{number} |  |
| [**GetById**](CardsApi.md#Getbyid) | **GET** /cards/{id} |  |
| [**GetByMtgoId**](CardsApi.md#Getbymtgoid) | **GET** /cards/mtgo/{id} |  |
| [**GetByMultiverseId**](CardsApi.md#Getbymultiverseid) | **GET** /cards/multiverse/{id} |  |
| [**GetNamed**](CardsApi.md#Getnamed) | **GET** /cards/named |  |
| [**GetRandom**](CardsApi.md#Getrandom) | **GET** /cards/random |  |
| [**CardsSearch**](CardsApi.md#cardssearch) | **GET** /cards/search |  |

<a id="cardsautocomplete"></a>
# **CardsAutocomplete**
> Catalog CardsAutocomplete (string q)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CardsAutocompleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CardsApi(config);
            var q = "q_example";  // string | 

            try
            {
                Catalog result = apiInstance.CardsAutocomplete(q);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.CardsAutocomplete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CardsAutocompleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CardsAutocompleteWithHttpInfo(q);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardsApi.CardsAutocompleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string** |  |  |

### Return type

[**Catalog**](Catalog.md)

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

<a id="Getbyarenaid"></a>
# **GetByArenaId**
> Card GetByArenaId (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetByArenaIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CardsApi(config);
            var id = 56;  // int | 

            try
            {
                Card result = apiInstance.GetByArenaId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.GetByArenaId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByArenaIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Card> response = apiInstance.GetByArenaIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardsApi.GetByArenaIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**Card**](Card.md)

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

<a id="Getbycodebynumber"></a>
# **GetByCodeByNumber**
> Card GetByCodeByNumber (string code, int number)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetByCodeByNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CardsApi(config);
            var code = "code_example";  // string | 
            var number = 56;  // int | 

            try
            {
                Card result = apiInstance.GetByCodeByNumber(code, number);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.GetByCodeByNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByCodeByNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Card> response = apiInstance.GetByCodeByNumberWithHttpInfo(code, number);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardsApi.GetByCodeByNumberWithHttpInfo: " + e.Message);
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

[**Card**](Card.md)

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

<a id="Getbyid"></a>
# **GetById**
> Card GetById (Guid id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CardsApi(config);
            var id = "id_example";  // Guid | 

            try
            {
                Card result = apiInstance.GetById(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.GetById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Card> response = apiInstance.GetByIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardsApi.GetByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** |  |  |

### Return type

[**Card**](Card.md)

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

<a id="Getbymtgoid"></a>
# **GetByMtgoId**
> Card GetByMtgoId (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetByMtgoIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CardsApi(config);
            var id = 56;  // int | 

            try
            {
                Card result = apiInstance.GetByMtgoId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.GetByMtgoId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByMtgoIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Card> response = apiInstance.GetByMtgoIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardsApi.GetByMtgoIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**Card**](Card.md)

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

<a id="Getbymultiverseid"></a>
# **GetByMultiverseId**
> Card GetByMultiverseId (int id)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetByMultiverseIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CardsApi(config);
            var id = 56;  // int | 

            try
            {
                Card result = apiInstance.GetByMultiverseId(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.GetByMultiverseId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetByMultiverseIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Card> response = apiInstance.GetByMultiverseIdWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardsApi.GetByMultiverseIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int** |  |  |

### Return type

[**Card**](Card.md)

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

<a id="Getnamed"></a>
# **GetNamed**
> Card GetNamed (string? exact = null, string? fuzzy = null, string? set = null, string? format = null, string? face = null, string? varVersion = null, bool? pretty = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetNamedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CardsApi(config);
            var exact = "exact_example";  // string? |  (optional) 
            var fuzzy = "fuzzy_example";  // string? |  (optional) 
            var set = "set_example";  // string? |  (optional) 
            var format = "format_example";  // string? |  (optional) 
            var face = "face_example";  // string? |  (optional) 
            var varVersion = "varVersion_example";  // string? |  (optional) 
            var pretty = true;  // bool? |  (optional) 

            try
            {
                Card result = apiInstance.GetNamed(exact, fuzzy, set, format, face, varVersion, pretty);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.GetNamed: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNamedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Card> response = apiInstance.GetNamedWithHttpInfo(exact, fuzzy, set, format, face, varVersion, pretty);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardsApi.GetNamedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **exact** | **string?** |  | [optional]  |
| **fuzzy** | **string?** |  | [optional]  |
| **set** | **string?** |  | [optional]  |
| **format** | **string?** |  | [optional]  |
| **face** | **string?** |  | [optional]  |
| **varVersion** | **string?** |  | [optional]  |
| **pretty** | **bool?** |  | [optional]  |

### Return type

[**Card**](Card.md)

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

<a id="Getrandom"></a>
# **GetRandom**
> Card GetRandom ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetRandomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CardsApi(config);

            try
            {
                Card result = apiInstance.GetRandom();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.GetRandom: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRandomWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Card> response = apiInstance.GetRandomWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardsApi.GetRandomWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**Card**](Card.md)

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

<a id="cardssearch"></a>
# **CardsSearch**
> CardList CardsSearch (string q, string? unique = null, string? order = null, string? dir = null, bool? includeExtras = null, int? page = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CardsSearchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CardsApi(config);
            var q = "q_example";  // string | 
            var unique = "cards";  // string? |  (optional) 
            var order = "name";  // string? |  (optional) 
            var dir = "auto";  // string? |  (optional) 
            var includeExtras = true;  // bool? |  (optional) 
            var page = 56;  // int? |  (optional) 

            try
            {
                CardList result = apiInstance.CardsSearch(q, unique, order, dir, includeExtras, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CardsApi.CardsSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CardsSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CardList> response = apiInstance.CardsSearchWithHttpInfo(q, unique, order, dir, includeExtras, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CardsApi.CardsSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string** |  |  |
| **unique** | **string?** |  | [optional]  |
| **order** | **string?** |  | [optional]  |
| **dir** | **string?** |  | [optional]  |
| **includeExtras** | **bool?** |  | [optional]  |
| **page** | **int?** |  | [optional]  |

### Return type

[**CardList**](CardList.md)

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

