/*
 * MyAnimeList API (beta ver.)
 *
 * MyAnimeList.net is the property of MyAnimeList, LLC. ©2019 All Rights Reserved.  ## Versioning  There are multiple versions of the API. You can specify a version by including it in the request uri:  (During closed beta, version starts with '0.')  `https://api.myanimelist.net/v2`  The version is incremented if any backwards incompatible changes are introduced to the API.  Examples of backwards incompatible changes are belows:  - Removing existing endpoints. - Removing existing fields of API responses. - Changing mean of the existing fields.  On the other hand, belows are examples of backwards compatible changes:  - Adding new endpoints. - Adding new optional request parameters. - Adding new fields to existing API responses. - Changing the order of fields in existing API responses. - Changing the contents of fields that suffixed by `_formatted`.   ## Common formats  ### List / Pagination  ```json {   \"data\": [     {...},     {...},     ...   ],   \"paging\": {     \"previous\": \"https://xxx\",     \"next\": \"https://xxx\"   } } ```      ### Date / Time format  <table> <tr> <th>Format <th>Type <th>Sample <th>Description </tr>  <tr> <td>date-time <td>string <td>\"2015-03-02T06:03:11+00:00\"  <td>ISO 8601 </tr>      <tr> <td>date <td>string <td>\"2017-10-23\" or <br>\"2017-10\" or <br>\"2017\" <td> </tr>  <tr> <td>time <td>string <td>\"01:35\" <td> </tr>  </table>  ### Error format   ```json {   \"error\": \"invalid_token\"   \"message\": \"token is invalid\", } ```  ## Common parameters  ### Parameters for endpoints that return a list  | Name | Description | | - -- | - -- | | limit |  | | offset |  |  ### Choosing fields  By default, the API doesn’t return all fields.  You can choose the fields that you want returned with the `fields` parameter.  Example:  ``` fields=synopsis,my_list_status{priority,comments} ```  ### Not Safe For Work  By default, some APIs don’t return nsfw content.  You can control this behavior with the `nsfw` parameter.  | Name | Description | | - -- | - -- | | nsfw | `true` or `false` |   ## Common status codes  | Status code | Error code | Description | | - -- - | - -- - | - -- - | | 400 Bad Request | - | Invalid Parameters | | 401 Unauthorized | invalid_token | Expired access tokens, Invalid access tokens, etc. | | 403 Forbidden | - | DoS detected etc. | | 404 Not Found | - | |  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using Xunit;

namespace OpenMAL.API.Test
{
    /// <summary>
    /// Class for testing AnimeForListAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AnimeForListAllOfTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AnimeForListAllOf
        //private AnimeForListAllOf instance;

        public AnimeForListAllOfTests()
        {
            // TODO uncomment below to create an instance of AnimeForListAllOf
            //instance = new AnimeForListAllOf();
        }

        /// <summary>
        /// Test an instance of AnimeForListAllOf
        /// </summary>
        [Fact]
        public void AnimeForListAllOfInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" AnimeForListAllOf
            //Assert.IsInstanceOfType<AnimeForListAllOf> (instance, "variable 'instance' is a AnimeForListAllOf");
        }

        /// <summary>
        /// Test the property 'AverageEpisodeDuration'
        /// </summary>
        [Fact]
        public void AverageEpisodeDurationTest()
        {
            // TODO unit test for the property 'AverageEpisodeDuration'
        }

        /// <summary>
        /// Test the property 'Broadcast'
        /// </summary>
        [Fact]
        public void BroadcastTest()
        {
            // TODO unit test for the property 'Broadcast'
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'MediaType'
        /// </summary>
        [Fact]
        public void MediaTypeTest()
        {
            // TODO unit test for the property 'MediaType'
        }

        /// <summary>
        /// Test the property 'MyListStatus'
        /// </summary>
        [Fact]
        public void MyListStatusTest()
        {
            // TODO unit test for the property 'MyListStatus'
        }

        /// <summary>
        /// Test the property 'NumEpisodes'
        /// </summary>
        [Fact]
        public void NumEpisodesTest()
        {
            // TODO unit test for the property 'NumEpisodes'
        }

        /// <summary>
        /// Test the property 'Rating'
        /// </summary>
        [Fact]
        public void RatingTest()
        {
            // TODO unit test for the property 'Rating'
        }

        /// <summary>
        /// Test the property 'Source'
        /// </summary>
        [Fact]
        public void SourceTest()
        {
            // TODO unit test for the property 'Source'
        }

        /// <summary>
        /// Test the property 'StartSeason'
        /// </summary>
        [Fact]
        public void StartSeasonTest()
        {
            // TODO unit test for the property 'StartSeason'
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Fact]
        public void StatusTest()
        {
            // TODO unit test for the property 'Status'
        }

        /// <summary>
        /// Test the property 'Studios'
        /// </summary>
        [Fact]
        public void StudiosTest()
        {
            // TODO unit test for the property 'Studios'
        }
    }
}