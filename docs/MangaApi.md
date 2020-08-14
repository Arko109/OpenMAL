# OpenMAL.API.Api.MangaApi

All URIs are relative to *https://api.myanimelist.net/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MangaGet**](MangaApi.md#mangaget) | **GET** /manga | Get manga list
[**MangaMangaIdGet**](MangaApi.md#mangamangaidget) | **GET** /manga/{manga_id} | Get manga details
[**MangaRankingGet**](MangaApi.md#mangarankingget) | **GET** /manga/ranking | Get manga ranking


<a name="mangaget"></a>
# **MangaGet**
> MangaList MangaGet (string q = null, int? limit = null, int? offset = null, string fields = null)

Get manga list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class MangaGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            var apiInstance = new MangaApi(config);
            var q = q_example;  // string | Search.  (optional) 
            var limit = 56;  // int? | The maximum value is 100.  (optional)  (default to 100)
            var offset = 56;  // int? |  (optional)  (default to 0)
            var fields = fields_example;  // string |  (optional) 

            try
            {
                // Get manga list
                MangaList result = apiInstance.MangaGet(q, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.MangaGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **q** | **string**| Search.  | [optional] 
 **limit** | **int?**| The maximum value is 100.  | [optional] [default to 100]
 **offset** | **int?**|  | [optional] [default to 0]
 **fields** | **string**|  | [optional] 

### Return type

[**MangaList**](MangaList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mangamangaidget"></a>
# **MangaMangaIdGet**
> MangaForDetails MangaMangaIdGet (int mangaId, string fields = null)

Get manga details

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class MangaMangaIdGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MangaApi(config);
            var mangaId = 56;  // int | 
            var fields = fields_example;  // string |  (optional) 

            try
            {
                // Get manga details
                MangaForDetails result = apiInstance.MangaMangaIdGet(mangaId, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.MangaMangaIdGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mangaId** | **int**|  | 
 **fields** | **string**|  | [optional] 

### Return type

[**MangaForDetails**](MangaForDetails.md)

### Authorization

[main_auth](../README.md#main_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mangarankingget"></a>
# **MangaRankingGet**
> MangaListForRanking MangaRankingGet (string rankingType, int? limit = null, int? offset = null, string fields = null)

Get manga ranking

The returned manga contains the `ranking` field. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class MangaRankingGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MangaApi(config);
            var rankingType = rankingType_example;  // string | | value | | | - -- - | - -- - | | all | All | | manga | Top Manga | | novels | Top Novels | | oneshots | Top One-shots | | doujin | Top Doujinshi | | manhwa | Top Manhwa | | manhua | Top Manhua | | bypopularity | Most Popular | | favorite | Most Favorited |  
            var limit = 56;  // int? | The maximum value is 500.  (optional)  (default to 100)
            var offset = 56;  // int? |  (optional)  (default to 0)
            var fields = fields_example;  // string |  (optional) 

            try
            {
                // Get manga ranking
                MangaListForRanking result = apiInstance.MangaRankingGet(rankingType, limit, offset, fields);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MangaApi.MangaRankingGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rankingType** | **string**| | value | | | - -- - | - -- - | | all | All | | manga | Top Manga | | novels | Top Novels | | oneshots | Top One-shots | | doujin | Top Doujinshi | | manhwa | Top Manhwa | | manhua | Top Manhua | | bypopularity | Most Popular | | favorite | Most Favorited |   | 
 **limit** | **int?**| The maximum value is 500.  | [optional] [default to 100]
 **offset** | **int?**|  | [optional] [default to 0]
 **fields** | **string**|  | [optional] 

### Return type

[**MangaListForRanking**](MangaListForRanking.md)

### Authorization

[main_auth](../README.md#main_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: */*, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

