/*
 * MyAnimeList API (beta ver.)
 *
 * MyAnimeList.net is the property of MyAnimeList, LLC. ©2019 All Rights Reserved.  ## Versioning  There are multiple versions of the API. You can specify a version by including it in the request uri:  (During closed beta, version starts with '0.')  `https://api.myanimelist.net/v2`  The version is incremented if any backwards incompatible changes are introduced to the API.  Examples of backwards incompatible changes are belows:  - Removing existing endpoints. - Removing existing fields of API responses. - Changing mean of the existing fields.  On the other hand, belows are examples of backwards compatible changes:  - Adding new endpoints. - Adding new optional request parameters. - Adding new fields to existing API responses. - Changing the order of fields in existing API responses. - Changing the contents of fields that suffixed by `_formatted`.   ## Common formats  ### List / Pagination  ```json {   \"data\": [     {...},     {...},     ...   ],   \"paging\": {     \"previous\": \"https://xxx\",     \"next\": \"https://xxx\"   } } ```      ### Date / Time format  <table> <tr> <th>Format <th>Type <th>Sample <th>Description </tr>  <tr> <td>date-time <td>string <td>\"2015-03-02T06:03:11+00:00\"  <td>ISO 8601 </tr>      <tr> <td>date <td>string <td>\"2017-10-23\" or <br>\"2017-10\" or <br>\"2017\" <td> </tr>  <tr> <td>time <td>string <td>\"01:35\" <td> </tr>  </table>  ### Error format   ```json {   \"error\": \"invalid_token\"   \"message\": \"token is invalid\", } ```  ## Common parameters  ### Parameters for endpoints that return a list  | Name | Description | | - -- | - -- | | limit |  | | offset |  |  ### Choosing fields  By default, the API doesn’t return all fields.  You can choose the fields that you want returned with the `fields` parameter.  Example:  ``` fields=synopsis,my_list_status{priority,comments} ```  ### Not Safe For Work  By default, some APIs don’t return nsfw content.  You can control this behavior with the `nsfw` parameter.  | Name | Description | | - -- | - -- | | nsfw | `true` or `false` |   ## Common status codes  | Status code | Error code | Description | | - -- - | - -- - | - -- - | | 400 Bad Request | - | Invalid Parameters | | 401 Unauthorized | invalid_token | Expired access tokens, Invalid access tokens, etc. | | 403 Forbidden | - | DoS detected etc. | | 404 Not Found | - | |  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using OpenMAL.API.Api;
using System;
using Xunit;

namespace OpenMAL.API.Test
{
    /// <summary>
    /// Class for testing UserMangalistApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserMangalistApiTests : IDisposable
    {
        private UserMangalistApi instance;

        public UserMangalistApiTests()
        {
            instance = new UserMangalistApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserMangalistApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UserMangalistApi
            //Assert.IsType(typeof(UserMangalistApi), instance, "instance is a UserMangalistApi");
        }

        /// <summary>
        /// Test MangaMangaIdMyListStatusDelete
        /// </summary>
        [Fact]
        public void MangaMangaIdMyListStatusDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int mangaId = null;
            //instance.MangaMangaIdMyListStatusDelete(mangaId);
        }

        /// <summary>
        /// Test MangaMangaIdMyListStatusPut
        /// </summary>
        [Fact]
        public void MangaMangaIdMyListStatusPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int mangaId = null;
            //string status = null;
            //bool? isRereading = null;
            //int? score = null;
            //int? numVolumesRead = null;
            //int? numChaptersRead = null;
            //int? priority = null;
            //int? numTimesReread = null;
            //int? rereadValue = null;
            //string tags = null;
            //string comments = null;
            //var response = instance.MangaMangaIdMyListStatusPut(mangaId, status, isRereading, score, numVolumesRead, numChaptersRead, priority, numTimesReread, rereadValue, tags, comments);
            //Assert.IsType<MangaListStatus> (response, "response is MangaListStatus");
        }

        /// <summary>
        /// Test UsersUserIdMangalistGet
        /// </summary>
        [Fact]
        public void UsersUserIdMangalistGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string userName = null;
            //string status = null;
            //string sort = null;
            //int? limit = null;
            //int? offset = null;
            //var response = instance.UsersUserIdMangalistGet(userName, status, sort, limit, offset);
            //Assert.IsType<UserMangaList> (response, "response is UserMangaList");
        }
    }
}