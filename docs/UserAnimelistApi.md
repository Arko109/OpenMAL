# OpenMAL.API.Api.UserAnimelistApi

All URIs are relative to *https://api.myanimelist.net/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AnimeAnimeIdMyListStatusDelete**](UserAnimelistApi.md#animeanimeidmyliststatusdelete) | **DELETE** /anime/{anime_id}/my_list_status | Delete my anime list item.
[**AnimeAnimeIdMyListStatusPut**](UserAnimelistApi.md#animeanimeidmyliststatusput) | **PATCH** /anime/{anime_id}/my_list_status | Update my anime list status
[**UsersUserIdAnimelistGet**](UserAnimelistApi.md#usersuseridanimelistget) | **GET** /users/{user_name}/animelist | Get user anime list


<a name="animeanimeidmyliststatusdelete"></a>
# **AnimeAnimeIdMyListStatusDelete**
> void AnimeAnimeIdMyListStatusDelete (int animeId)

Delete my anime list item.

If the specified anime does not exist in user's anime list, this endpoint does nothing and returns `404 Not Found`.  So be careful when retrying. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class AnimeAnimeIdMyListStatusDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAnimelistApi(config);
            var animeId = 56;  // int | 

            try
            {
                // Delete my anime list item.
                apiInstance.AnimeAnimeIdMyListStatusDelete(animeId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAnimelistApi.AnimeAnimeIdMyListStatusDelete: " + e.Message );
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
 **animeId** | **int**|  | 

### Return type

void (empty response body)

### Authorization

[main_auth](../README.md#main_auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **404** | Not Found |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="animeanimeidmyliststatusput"></a>
# **AnimeAnimeIdMyListStatusPut**
> AnimeListStatus AnimeAnimeIdMyListStatusPut (int animeId, string status = null, bool? isRewatching = null, int? score = null, int? numWatchedEpisodes = null, int? priority = null, int? numTimesRewatched = null, int? rewatchValue = null, string tags = null, string comments = null)

Update my anime list status

Add specified anime to my anime list.  If specified anime already exists, update its status.  This endpoint updates only values specified by the parameter. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class AnimeAnimeIdMyListStatusPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAnimelistApi(config);
            var animeId = 56;  // int | 
            var status = status_example;  // string | - watching - completed - on_hold - dropped - plan_to_watch  (optional) 
            var isRewatching = true;  // bool? |  (optional) 
            var score = 56;  // int? | 0-10  (optional) 
            var numWatchedEpisodes = 56;  // int? |  (optional) 
            var priority = 56;  // int? | 0-2  (optional) 
            var numTimesRewatched = 56;  // int? |  (optional) 
            var rewatchValue = 56;  // int? | 0-5  (optional) 
            var tags = tags_example;  // string |  (optional) 
            var comments = comments_example;  // string |  (optional) 

            try
            {
                // Update my anime list status
                AnimeListStatus result = apiInstance.AnimeAnimeIdMyListStatusPut(animeId, status, isRewatching, score, numWatchedEpisodes, priority, numTimesRewatched, rewatchValue, tags, comments);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAnimelistApi.AnimeAnimeIdMyListStatusPut: " + e.Message );
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
 **animeId** | **int**|  | 
 **status** | **string**| - watching - completed - on_hold - dropped - plan_to_watch  | [optional] 
 **isRewatching** | **bool?**|  | [optional] 
 **score** | **int?**| 0-10  | [optional] 
 **numWatchedEpisodes** | **int?**|  | [optional] 
 **priority** | **int?**| 0-2  | [optional] 
 **numTimesRewatched** | **int?**|  | [optional] 
 **rewatchValue** | **int?**| 0-5  | [optional] 
 **tags** | **string**|  | [optional] 
 **comments** | **string**|  | [optional] 

### Return type

[**AnimeListStatus**](AnimeListStatus.md)

### Authorization

[main_auth](../README.md#main_auth)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: */*, application/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridanimelistget"></a>
# **UsersUserIdAnimelistGet**
> UserAnimeList UsersUserIdAnimelistGet (string userName, string status = null, string sort = null, int? limit = null, int? offset = null)

Get user anime list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class UsersUserIdAnimelistGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserAnimelistApi(config);
            var userName = userName_example;  // string | User name or `@me`. 
            var status = status_example;  // string | Filters returned anime list by these statuses.  To return all anime, don't specify this field.  Valid values:  - watching - completed - on_hold - dropped - plan_to_watch  (optional) 
            var sort = sort_example;  // string | Valid values:  | Value | Order | | - -- - | - -- - | | `list_score` | Descending | | `list_updated_at` | Descending | | `anime_title` | Ascending | | `anime_start_date` | Descending | | `anime_id` (Under Development) | Ascending |  (optional) 
            var limit = 56;  // int? | The maximum value is 1000.  (optional)  (default to 100)
            var offset = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Get user anime list
                UserAnimeList result = apiInstance.UsersUserIdAnimelistGet(userName, status, sort, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserAnimelistApi.UsersUserIdAnimelistGet: " + e.Message );
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
 **userName** | **string**| User name or &#x60;@me&#x60;.  | 
 **status** | **string**| Filters returned anime list by these statuses.  To return all anime, don&#39;t specify this field.  Valid values:  - watching - completed - on_hold - dropped - plan_to_watch  | [optional] 
 **sort** | **string**| Valid values:  | Value | Order | | - -- - | - -- - | | &#x60;list_score&#x60; | Descending | | &#x60;list_updated_at&#x60; | Descending | | &#x60;anime_title&#x60; | Ascending | | &#x60;anime_start_date&#x60; | Descending | | &#x60;anime_id&#x60; (Under Development) | Ascending |  | [optional] 
 **limit** | **int?**| The maximum value is 1000.  | [optional] [default to 100]
 **offset** | **int?**|  | [optional] [default to 0]

### Return type

[**UserAnimeList**](UserAnimeList.md)

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

