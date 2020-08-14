# OpenMAL.API.Api.UserMangalistApi

All URIs are relative to *https://api.myanimelist.net/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MangaMangaIdMyListStatusDelete**](UserMangalistApi.md#mangamangaidmyliststatusdelete) | **DELETE** /manga/{manga_id}/my_list_status | Delete my manga list item.
[**MangaMangaIdMyListStatusPut**](UserMangalistApi.md#mangamangaidmyliststatusput) | **PATCH** /manga/{manga_id}/my_list_status | Update my manga list status
[**UsersUserIdMangalistGet**](UserMangalistApi.md#usersuseridmangalistget) | **GET** /users/{user_name}/mangalist | Get user manga list


<a name="mangamangaidmyliststatusdelete"></a>
# **MangaMangaIdMyListStatusDelete**
> void MangaMangaIdMyListStatusDelete (int mangaId)

Delete my manga list item.

If the specified manga does not exist in user's manga list, this endpoint does nothing and returns `404 Not Found`.  So be careful when retrying. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class MangaMangaIdMyListStatusDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserMangalistApi(config);
            var mangaId = 56;  // int | 

            try
            {
                // Delete my manga list item.
                apiInstance.MangaMangaIdMyListStatusDelete(mangaId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserMangalistApi.MangaMangaIdMyListStatusDelete: " + e.Message );
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

<a name="mangamangaidmyliststatusput"></a>
# **MangaMangaIdMyListStatusPut**
> MangaListStatus MangaMangaIdMyListStatusPut (int mangaId, string status = null, bool? isRereading = null, int? score = null, int? numVolumesRead = null, int? numChaptersRead = null, int? priority = null, int? numTimesReread = null, int? rereadValue = null, string tags = null, string comments = null)

Update my manga list status

Add specified manga to my manga list.  If specified manga already exists, update its status.  This endpoint updates only values specified by the parameter. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class MangaMangaIdMyListStatusPutExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserMangalistApi(config);
            var mangaId = 56;  // int | 
            var status = status_example;  // string | - reading - completed - on_hold - dropped - plan_to_read  (optional) 
            var isRereading = true;  // bool? |  (optional) 
            var score = 56;  // int? | 0-10 (optional) 
            var numVolumesRead = 56;  // int? |  (optional) 
            var numChaptersRead = 56;  // int? |  (optional) 
            var priority = 56;  // int? | 0-2  (optional) 
            var numTimesReread = 56;  // int? |  (optional) 
            var rereadValue = 56;  // int? | 0-5  (optional) 
            var tags = tags_example;  // string |  (optional) 
            var comments = comments_example;  // string |  (optional) 

            try
            {
                // Update my manga list status
                MangaListStatus result = apiInstance.MangaMangaIdMyListStatusPut(mangaId, status, isRereading, score, numVolumesRead, numChaptersRead, priority, numTimesReread, rereadValue, tags, comments);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserMangalistApi.MangaMangaIdMyListStatusPut: " + e.Message );
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
 **status** | **string**| - reading - completed - on_hold - dropped - plan_to_read  | [optional] 
 **isRereading** | **bool?**|  | [optional] 
 **score** | **int?**| 0-10 | [optional] 
 **numVolumesRead** | **int?**|  | [optional] 
 **numChaptersRead** | **int?**|  | [optional] 
 **priority** | **int?**| 0-2  | [optional] 
 **numTimesReread** | **int?**|  | [optional] 
 **rereadValue** | **int?**| 0-5  | [optional] 
 **tags** | **string**|  | [optional] 
 **comments** | **string**|  | [optional] 

### Return type

[**MangaListStatus**](MangaListStatus.md)

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

<a name="usersuseridmangalistget"></a>
# **UsersUserIdMangalistGet**
> UserMangaList UsersUserIdMangalistGet (string userName, string status = null, string sort = null, int? limit = null, int? offset = null)

Get user manga list

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class UsersUserIdMangalistGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            // Configure OAuth2 access token for authorization: main_auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UserMangalistApi(config);
            var userName = userName_example;  // string | User name or `@me`. 
            var status = status_example;  // string | Filters returned manga list by these statuses.  To return all manga, don't specify this field.  Valid values:  - reading - completed - on_hold - dropped - plan_to_read  (optional) 
            var sort = sort_example;  // string | Valid values:  | Value | Order | | - -- - | - -- - | | `list_score` | Descending | | `list_updated_at` | Descending | | `manga_title` | Ascending | | `manga_start_date` | Descending | | `manga_id` (Under Development) | Ascending |  (optional) 
            var limit = 56;  // int? | The maximum value is 1000.  (optional)  (default to 100)
            var offset = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Get user manga list
                UserMangaList result = apiInstance.UsersUserIdMangalistGet(userName, status, sort, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserMangalistApi.UsersUserIdMangalistGet: " + e.Message );
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
 **status** | **string**| Filters returned manga list by these statuses.  To return all manga, don&#39;t specify this field.  Valid values:  - reading - completed - on_hold - dropped - plan_to_read  | [optional] 
 **sort** | **string**| Valid values:  | Value | Order | | - -- - | - -- - | | &#x60;list_score&#x60; | Descending | | &#x60;list_updated_at&#x60; | Descending | | &#x60;manga_title&#x60; | Ascending | | &#x60;manga_start_date&#x60; | Descending | | &#x60;manga_id&#x60; (Under Development) | Ascending |  | [optional] 
 **limit** | **int?**| The maximum value is 1000.  | [optional] [default to 100]
 **offset** | **int?**|  | [optional] [default to 0]

### Return type

[**UserMangaList**](UserMangaList.md)

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

