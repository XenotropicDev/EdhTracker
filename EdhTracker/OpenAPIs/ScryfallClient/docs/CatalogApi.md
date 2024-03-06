# Org.OpenAPITools.Api.CatalogApi

All URIs are relative to *https://api.scryfall.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CatalogGetArtifactTypes**](CatalogApi.md#cataloggetartifacttypes) | **GET** /catalog/artifact-types |  |
| [**CatalogGetCardNames**](CatalogApi.md#cataloggetcardnames) | **GET** /catalog/card-names |  |
| [**CatalogGetCreatureTypes**](CatalogApi.md#cataloggetcreaturetypes) | **GET** /catalog/creature-types |  |
| [**CatalogGetEnchantmentTypes**](CatalogApi.md#cataloggetenchantmenttypes) | **GET** /catalog/enchantment-types |  |
| [**CatalogGetLandTypes**](CatalogApi.md#cataloggetlandtypes) | **GET** /catalog/land-types |  |
| [**CatalogGetLoyalties**](CatalogApi.md#cataloggetloyalties) | **GET** /catalog/loyalties |  |
| [**CatalogGetPlaneswalkerTypes**](CatalogApi.md#cataloggetplaneswalkertypes) | **GET** /catalog/planeswalker-types |  |
| [**CatalogGetPowers**](CatalogApi.md#cataloggetpowers) | **GET** /catalog/powers |  |
| [**CatalogGetSpellTypes**](CatalogApi.md#cataloggetspelltypes) | **GET** /catalog/spell-types |  |
| [**CatalogGetToughnesses**](CatalogApi.md#cataloggettoughnesses) | **GET** /catalog/thoughnesses |  |
| [**CatalogGetWatermarks**](CatalogApi.md#cataloggetwatermarks) | **GET** /catalog/watermarks |  |
| [**CatalogGetWordBank**](CatalogApi.md#cataloggetwordbank) | **GET** /catalog/word-bank |  |

<a id="cataloggetartifacttypes"></a>
# **CatalogGetArtifactTypes**
> Catalog CatalogGetArtifactTypes ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetArtifactTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetArtifactTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetArtifactTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetArtifactTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetArtifactTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetArtifactTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggetcardnames"></a>
# **CatalogGetCardNames**
> Catalog CatalogGetCardNames ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetCardNamesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetCardNames();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetCardNames: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetCardNamesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetCardNamesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetCardNamesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggetcreaturetypes"></a>
# **CatalogGetCreatureTypes**
> Catalog CatalogGetCreatureTypes ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetCreatureTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetCreatureTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetCreatureTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetCreatureTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetCreatureTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetCreatureTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggetenchantmenttypes"></a>
# **CatalogGetEnchantmentTypes**
> Catalog CatalogGetEnchantmentTypes ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetEnchantmentTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetEnchantmentTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetEnchantmentTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetEnchantmentTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetEnchantmentTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetEnchantmentTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggetlandtypes"></a>
# **CatalogGetLandTypes**
> Catalog CatalogGetLandTypes ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetLandTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetLandTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetLandTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetLandTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetLandTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetLandTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggetloyalties"></a>
# **CatalogGetLoyalties**
> Catalog CatalogGetLoyalties ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetLoyaltiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetLoyalties();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetLoyalties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetLoyaltiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetLoyaltiesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetLoyaltiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggetplaneswalkertypes"></a>
# **CatalogGetPlaneswalkerTypes**
> Catalog CatalogGetPlaneswalkerTypes ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetPlaneswalkerTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetPlaneswalkerTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetPlaneswalkerTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetPlaneswalkerTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetPlaneswalkerTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetPlaneswalkerTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggetpowers"></a>
# **CatalogGetPowers**
> Catalog CatalogGetPowers ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetPowersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetPowers();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetPowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetPowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetPowersWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetPowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggetspelltypes"></a>
# **CatalogGetSpellTypes**
> Catalog CatalogGetSpellTypes ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetSpellTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetSpellTypes();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetSpellTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetSpellTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetSpellTypesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetSpellTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggettoughnesses"></a>
# **CatalogGetToughnesses**
> Catalog CatalogGetToughnesses ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetToughnessesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetToughnesses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetToughnesses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetToughnessesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetToughnessesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetToughnessesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggetwatermarks"></a>
# **CatalogGetWatermarks**
> Catalog CatalogGetWatermarks ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetWatermarksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetWatermarks();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetWatermarks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetWatermarksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetWatermarksWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetWatermarksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

<a id="cataloggetwordbank"></a>
# **CatalogGetWordBank**
> Catalog CatalogGetWordBank ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CatalogGetWordBankExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.scryfall.com";
            var apiInstance = new CatalogApi(config);

            try
            {
                Catalog result = apiInstance.CatalogGetWordBank();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CatalogApi.CatalogGetWordBank: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CatalogGetWordBankWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Catalog> response = apiInstance.CatalogGetWordBankWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CatalogApi.CatalogGetWordBankWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

