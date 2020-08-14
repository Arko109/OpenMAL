# OpenMAL.API.Api.ForumApi

All URIs are relative to *https://api.myanimelist.net/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ForumBoardsGet**](ForumApi.md#forumboardsget) | **GET** /forum/boards | Get forum boards
[**ForumTopicGet**](ForumApi.md#forumtopicget) | **GET** /forum/topic/{topic_id} | Get forum topic detail
[**ForumTopicsGet**](ForumApi.md#forumtopicsget) | **GET** /forum/topics | Get forum topics


<a name="forumboardsget"></a>
# **ForumBoardsGet**
> ForumBoards ForumBoardsGet ()

Get forum boards

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class ForumBoardsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            var apiInstance = new ForumApi(config);

            try
            {
                // Get forum boards
                ForumBoards result = apiInstance.ForumBoardsGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumBoardsGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ForumBoards**](ForumBoards.md)

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

<a name="forumtopicget"></a>
# **ForumTopicGet**
> ForumTopic ForumTopicGet (int topicId, int? limit = null, int? offset = null)

Get forum topic detail

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class ForumTopicGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            var apiInstance = new ForumApi(config);
            var topicId = 56;  // int | 
            var limit = 56;  // int? |  (optional)  (default to 100)
            var offset = 56;  // int? |  (optional)  (default to 0)

            try
            {
                // Get forum topic detail
                ForumTopic result = apiInstance.ForumTopicGet(topicId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumTopicGet: " + e.Message );
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
 **topicId** | **int**|  | 
 **limit** | **int?**|  | [optional] [default to 100]
 **offset** | **int?**|  | [optional] [default to 0]

### Return type

[**ForumTopic**](ForumTopic.md)

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

<a name="forumtopicsget"></a>
# **ForumTopicsGet**
> ForumTopics ForumTopicsGet (int? boardId = null, int? subboardId = null, int? limit = null, int? offset = null, string sort = null, string q = null, string topicUserName = null, string userName = null)

Get forum topics

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OpenMAL.API.Api;
using OpenMAL.API.Client;
using OpenMAL.API.Model;

namespace Example
{
    public class ForumTopicsGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.myanimelist.net/v2";
            var apiInstance = new ForumApi(config);
            var boardId = 56;  // int? |  (optional) 
            var subboardId = 56;  // int? |  (optional) 
            var limit = 56;  // int? |  (optional)  (default to 100)
            var offset = 56;  // int? |  (optional)  (default to 0)
            var sort = sort_example;  // string | Currently, only \"recent\" can be set. (optional)  (default to "recent")
            var q = q_example;  // string |  (optional) 
            var topicUserName = topicUserName_example;  // string |  (optional) 
            var userName = userName_example;  // string |  (optional) 

            try
            {
                // Get forum topics
                ForumTopics result = apiInstance.ForumTopicsGet(boardId, subboardId, limit, offset, sort, q, topicUserName, userName);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ForumApi.ForumTopicsGet: " + e.Message );
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
 **boardId** | **int?**|  | [optional] 
 **subboardId** | **int?**|  | [optional] 
 **limit** | **int?**|  | [optional] [default to 100]
 **offset** | **int?**|  | [optional] [default to 0]
 **sort** | **string**| Currently, only \&quot;recent\&quot; can be set. | [optional] [default to &quot;recent&quot;]
 **q** | **string**|  | [optional] 
 **topicUserName** | **string**|  | [optional] 
 **userName** | **string**|  | [optional] 

### Return type

[**ForumTopics**](ForumTopics.md)

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

