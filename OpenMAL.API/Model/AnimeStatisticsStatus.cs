/*
 * MyAnimeList API (beta ver.)
 *
 * MyAnimeList.net is the property of MyAnimeList, LLC. ©2019 All Rights Reserved.  ## Versioning  There are multiple versions of the API. You can specify a version by including it in the request uri:  (During closed beta, version starts with '0.')  `https://api.myanimelist.net/v2`  The version is incremented if any backwards incompatible changes are introduced to the API.  Examples of backwards incompatible changes are belows:  - Removing existing endpoints. - Removing existing fields of API responses. - Changing mean of the existing fields.  On the other hand, belows are examples of backwards compatible changes:  - Adding new endpoints. - Adding new optional request parameters. - Adding new fields to existing API responses. - Changing the order of fields in existing API responses. - Changing the contents of fields that suffixed by `_formatted`.   ## Common formats  ### List / Pagination  ```json {   \"data\": [     {...},     {...},     ...   ],   \"paging\": {     \"previous\": \"https://xxx\",     \"next\": \"https://xxx\"   } } ```      ### Date / Time format  <table> <tr> <th>Format <th>Type <th>Sample <th>Description </tr>  <tr> <td>date-time <td>string <td>\"2015-03-02T06:03:11+00:00\"  <td>ISO 8601 </tr>      <tr> <td>date <td>string <td>\"2017-10-23\" or <br>\"2017-10\" or <br>\"2017\" <td> </tr>  <tr> <td>time <td>string <td>\"01:35\" <td> </tr>  </table>  ### Error format   ```json {   \"error\": \"invalid_token\"   \"message\": \"token is invalid\", } ```  ## Common parameters  ### Parameters for endpoints that return a list  | Name | Description | | - -- | - -- | | limit |  | | offset |  |  ### Choosing fields  By default, the API doesn’t return all fields.  You can choose the fields that you want returned with the `fields` parameter.  Example:  ``` fields=synopsis,my_list_status{priority,comments} ```  ### Not Safe For Work  By default, some APIs don’t return nsfw content.  You can control this behavior with the `nsfw` parameter.  | Name | Description | | - -- | - -- | | nsfw | `true` or `false` |   ## Common status codes  | Status code | Error code | Description | | - -- - | - -- - | - -- - | | 400 Bad Request | - | Invalid Parameters | | 401 Unauthorized | invalid_token | Expired access tokens, Invalid access tokens, etc. | | 403 Forbidden | - | DoS detected etc. | | 404 Not Found | - | |  # Authentication  <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json;
using System;
using System.Runtime.Serialization;
using System.Text;

namespace OpenMAL.API.Model
{
    /// <summary>
    /// AnimeStatisticsStatus
    /// </summary>
    [DataContract]
    public partial class AnimeStatisticsStatus : IEquatable<AnimeStatisticsStatus>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnimeStatisticsStatus"/> class.
        /// </summary>
        /// <param name="watching">watching.</param>
        /// <param name="completed">completed.</param>
        /// <param name="onHold">onHold.</param>
        /// <param name="dropped">dropped.</param>
        /// <param name="planToWatch">planToWatch.</param>
        public AnimeStatisticsStatus(int watching = default(int), int completed = default(int), int onHold = default(int), int dropped = default(int), int planToWatch = default(int))
        {
            this.Watching = watching;
            this.Completed = completed;
            this.OnHold = onHold;
            this.Dropped = dropped;
            this.PlanToWatch = planToWatch;
        }

        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name = "completed", EmitDefaultValue = false)]
        public int Completed { get; set; }
        /// <summary>
        /// Gets or Sets Dropped
        /// </summary>
        [DataMember(Name = "dropped", EmitDefaultValue = false)]
        public int Dropped { get; set; }
        /// <summary>
        /// Gets or Sets OnHold
        /// </summary>
        [DataMember(Name = "on_hold", EmitDefaultValue = false)]
        public int OnHold { get; set; }
        /// <summary>
        /// Gets or Sets PlanToWatch
        /// </summary>
        [DataMember(Name = "plan_to_watch", EmitDefaultValue = false)]
        public int PlanToWatch { get; set; }
        /// <summary>
        /// Gets or Sets Watching
        /// </summary>
        [DataMember(Name = "watching", EmitDefaultValue = false)]
        public int Watching { get; set; }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AnimeStatisticsStatus);
        }

        /// <summary>
        /// Returns true if AnimeStatisticsStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of AnimeStatisticsStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnimeStatisticsStatus input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Watching == input.Watching ||
                    this.Watching.Equals(input.Watching)
                ) &&
                (
                    this.Completed == input.Completed ||
                    this.Completed.Equals(input.Completed)
                ) &&
                (
                    this.OnHold == input.OnHold ||
                    this.OnHold.Equals(input.OnHold)
                ) &&
                (
                    this.Dropped == input.Dropped ||
                    this.Dropped.Equals(input.Dropped)
                ) &&
                (
                    this.PlanToWatch == input.PlanToWatch ||
                    this.PlanToWatch.Equals(input.PlanToWatch)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Watching.GetHashCode();
                hashCode = hashCode * 59 + this.Completed.GetHashCode();
                hashCode = hashCode * 59 + this.OnHold.GetHashCode();
                hashCode = hashCode * 59 + this.Dropped.GetHashCode();
                hashCode = hashCode * 59 + this.PlanToWatch.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AnimeStatisticsStatus {\n");
            sb.Append("  Watching: ").Append(Watching).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  OnHold: ").Append(OnHold).Append("\n");
            sb.Append("  Dropped: ").Append(Dropped).Append("\n");
            sb.Append("  PlanToWatch: ").Append(PlanToWatch).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}