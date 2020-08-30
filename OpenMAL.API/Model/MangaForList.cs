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
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace OpenMAL.API.Model
{
    /// <summary>
    /// MangaForList
    /// </summary>
    [DataContract]
    public partial class MangaForList : IEquatable<MangaForList>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MangaForList"/> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="mainPicture">mainPicture.</param>
        /// <param name="alternativeTitles">alternativeTitles.</param>
        /// <param name="startDate">startDate.</param>
        /// <param name="endDate">endDate.</param>
        /// <param name="synopsis">Synopsis. The API strips BBCode tags from the result. .</param>
        /// <param name="mean">
        /// Mean score. When the `mean` can not be calculated, such as when the number of user
        /// scores is small, the result does not include this field. .
        /// </param>
        /// <param name="rank">
        /// When the `rank` can not be calculated, such as when the number of user scores is small,
        /// the result does not include this field. .
        /// </param>
        /// <param name="popularity">popularity.</param>
        /// <param name="numListUsers">Number of users who have this work in their list. .</param>
        /// <param name="numScoringUsers">numScoringUsers.</param>
        /// <param name="nsfw">
        /// | Value | Description | | - -- - | - -- - | | white | This work is safe for work | |
        /// gray | This work may be not safe for work | | black | This work is not safe for work | .
        /// </param>
        /// <param name="genres">genres.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="mediaType">
        /// - unknown - manga - novel - one_shot - doujinshi - manhwa - manhua - oel .
        /// </param>
        /// <param name="status">
        /// Publishing status. - finished - currently_publishing - not_yet_published .
        /// </param>
        /// <param name="myListStatus">myListStatus.</param>
        /// <param name="numVolumes">If unknown, it is 0. .</param>
        /// <param name="numChapters">If unknown, it is 0. .</param>
        /// <param name="authors">authors.</param>
        public MangaForList(int id = default(int), string title = default(string), Object mainPicture = default(Object), WorkForListAllOfAlternativeTitles alternativeTitles = default(WorkForListAllOfAlternativeTitles), string startDate = default(string), string endDate = default(string), string synopsis = default(string), float? mean = default(float?), int? rank = default(int?), int? popularity = default(int?), int numListUsers = default(int), int numScoringUsers = default(int), string nsfw = default(string), List<Genre> genres = default(List<Genre>), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), string mediaType = default(string), string status = default(string), Object myListStatus = default(Object), int numVolumes = default(int), int numChapters = default(int), List<PersonRoleEdge> authors = default(List<PersonRoleEdge>))
        {
            this.Id = id;
            this.Title = title;
            this.MainPicture = mainPicture;
            this.AlternativeTitles = alternativeTitles;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Synopsis = synopsis;
            this.Mean = mean;
            this.Rank = rank;
            this.Popularity = popularity;
            this.NumListUsers = numListUsers;
            this.NumScoringUsers = numScoringUsers;
            this.Nsfw = nsfw;
            this.Genres = genres;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.MediaType = mediaType;
            this.Status = status;
            this.MyListStatus = myListStatus;
            this.NumVolumes = numVolumes;
            this.NumChapters = numChapters;
            this.Authors = authors;
        }

        /// <summary>
        /// Gets or Sets AlternativeTitles
        /// </summary>
        [DataMember(Name = "alternative_titles", EmitDefaultValue = true)]
        public WorkForListAllOfAlternativeTitles AlternativeTitles { get; set; }
        /// <summary>
        /// Gets or Sets Authors
        /// </summary>
        [DataMember(Name = "authors", EmitDefaultValue = false)]
        public List<PersonRoleEdge> Authors { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }
        /// <summary>
        /// Gets or Sets EndDate
        /// </summary>
        [DataMember(Name = "end_date", EmitDefaultValue = true)]
        public string EndDate { get; set; }
        /// <summary>
        /// Gets or Sets Genres
        /// </summary>
        [DataMember(Name = "genres", EmitDefaultValue = false)]
        public List<Genre> Genres { get; set; }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets MainPicture
        /// </summary>
        [DataMember(Name = "main_picture", EmitDefaultValue = false)]
        public Object MainPicture { get; set; }
        /// <summary>
        /// Mean score. When the `mean` can not be calculated, such as when the number of user
        /// scores is small, the result does not include this field.
        /// </summary>
        /// <value>
        /// Mean score. When the `mean` can not be calculated, such as when the number of user
        /// scores is small, the result does not include this field.
        /// </value>
        [DataMember(Name = "mean", EmitDefaultValue = true)]
        public float? Mean { get; set; }
        /// <summary>
        /// - unknown - manga - novel - one_shot - doujinshi - manhwa - manhua - oel
        /// </summary>
        /// <value>- unknown - manga - novel - one_shot - doujinshi - manhwa - manhua - oel</value>
        [DataMember(Name = "media_type", EmitDefaultValue = false)]
        public string MediaType { get; set; }
        /// <summary>
        /// Gets or Sets MyListStatus
        /// </summary>
        [DataMember(Name = "my_list_status", EmitDefaultValue = false)]
        public Object MyListStatus { get; set; }
        /// <summary>
        /// | Value | Description | | - -- - | - -- - | | white | This work is safe for work | |
        /// gray | This work may be not safe for work | | black | This work is not safe for work |
        /// </summary>
        /// <value>
        /// | Value | Description | | - -- - | - -- - | | white | This work is safe for work | |
        /// gray | This work may be not safe for work | | black | This work is not safe for work |
        /// </value>
        [DataMember(Name = "nsfw", EmitDefaultValue = true)]
        public string Nsfw { get; set; }
        /// <summary>
        /// If unknown, it is 0.
        /// </summary>
        /// <value>If unknown, it is 0.</value>
        [DataMember(Name = "num_chapters", EmitDefaultValue = false)]
        public int NumChapters { get; set; }
        /// <summary>
        /// Number of users who have this work in their list.
        /// </summary>
        /// <value>Number of users who have this work in their list.</value>
        [DataMember(Name = "num_list_users", EmitDefaultValue = false)]
        public int NumListUsers { get; set; }
        /// <summary>
        /// Gets or Sets NumScoringUsers
        /// </summary>
        [DataMember(Name = "num_scoring_users", EmitDefaultValue = false)]
        public int NumScoringUsers { get; set; }
        /// <summary>
        /// If unknown, it is 0.
        /// </summary>
        /// <value>If unknown, it is 0.</value>
        [DataMember(Name = "num_volumes", EmitDefaultValue = false)]
        public int NumVolumes { get; set; }
        /// <summary>
        /// Gets or Sets Popularity
        /// </summary>
        [DataMember(Name = "popularity", EmitDefaultValue = true)]
        public int? Popularity { get; set; }
        /// <summary>
        /// When the `rank` can not be calculated, such as when the number of user scores is small,
        /// the result does not include this field.
        /// </summary>
        /// <value>
        /// When the `rank` can not be calculated, such as when the number of user scores is small,
        /// the result does not include this field.
        /// </value>
        [DataMember(Name = "rank", EmitDefaultValue = true)]
        public int? Rank { get; set; }
        /// <summary>
        /// Gets or Sets StartDate
        /// </summary>
        [DataMember(Name = "start_date", EmitDefaultValue = true)]
        public string StartDate { get; set; }
        /// <summary>
        /// Publishing status. - finished - currently_publishing - not_yet_published
        /// </summary>
        /// <value>Publishing status. - finished - currently_publishing - not_yet_published</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }
        /// <summary>
        /// Synopsis. The API strips BBCode tags from the result.
        /// </summary>
        /// <value>Synopsis. The API strips BBCode tags from the result.</value>
        [DataMember(Name = "synopsis", EmitDefaultValue = true)]
        public string Synopsis { get; set; }
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as MangaForList);
        }

        /// <summary>
        /// Returns true if MangaForList instances are equal
        /// </summary>
        /// <param name="input">Instance of MangaForList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MangaForList input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) &&
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) &&
                (
                    this.MainPicture == input.MainPicture ||
                    (this.MainPicture != null &&
                    this.MainPicture.Equals(input.MainPicture))
                ) &&
                (
                    this.AlternativeTitles == input.AlternativeTitles ||
                    (this.AlternativeTitles != null &&
                    this.AlternativeTitles.Equals(input.AlternativeTitles))
                ) &&
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) &&
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) &&
                (
                    this.Synopsis == input.Synopsis ||
                    (this.Synopsis != null &&
                    this.Synopsis.Equals(input.Synopsis))
                ) &&
                (
                    this.Mean == input.Mean ||
                    (this.Mean != null &&
                    this.Mean.Equals(input.Mean))
                ) &&
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
                ) &&
                (
                    this.Popularity == input.Popularity ||
                    (this.Popularity != null &&
                    this.Popularity.Equals(input.Popularity))
                ) &&
                (
                    this.NumListUsers == input.NumListUsers ||
                    this.NumListUsers.Equals(input.NumListUsers)
                ) &&
                (
                    this.NumScoringUsers == input.NumScoringUsers ||
                    this.NumScoringUsers.Equals(input.NumScoringUsers)
                ) &&
                (
                    this.Nsfw == input.Nsfw ||
                    (this.Nsfw != null &&
                    this.Nsfw.Equals(input.Nsfw))
                ) &&
                (
                    this.Genres == input.Genres ||
                    this.Genres != null &&
                    input.Genres != null &&
                    this.Genres.SequenceEqual(input.Genres)
                ) &&
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) &&
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) &&
                (
                    this.MediaType == input.MediaType ||
                    (this.MediaType != null &&
                    this.MediaType.Equals(input.MediaType))
                ) &&
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) &&
                (
                    this.MyListStatus == input.MyListStatus ||
                    (this.MyListStatus != null &&
                    this.MyListStatus.Equals(input.MyListStatus))
                ) &&
                (
                    this.NumVolumes == input.NumVolumes ||
                    this.NumVolumes.Equals(input.NumVolumes)
                ) &&
                (
                    this.NumChapters == input.NumChapters ||
                    this.NumChapters.Equals(input.NumChapters)
                ) &&
                (
                    this.Authors == input.Authors ||
                    this.Authors != null &&
                    input.Authors != null &&
                    this.Authors.SequenceEqual(input.Authors)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.MainPicture != null)
                    hashCode = hashCode * 59 + this.MainPicture.GetHashCode();
                if (this.AlternativeTitles != null)
                    hashCode = hashCode * 59 + this.AlternativeTitles.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Synopsis != null)
                    hashCode = hashCode * 59 + this.Synopsis.GetHashCode();
                if (this.Mean != null)
                    hashCode = hashCode * 59 + this.Mean.GetHashCode();
                if (this.Rank != null)
                    hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.Popularity != null)
                    hashCode = hashCode * 59 + this.Popularity.GetHashCode();
                hashCode = hashCode * 59 + this.NumListUsers.GetHashCode();
                hashCode = hashCode * 59 + this.NumScoringUsers.GetHashCode();
                if (this.Nsfw != null)
                    hashCode = hashCode * 59 + this.Nsfw.GetHashCode();
                if (this.Genres != null)
                    hashCode = hashCode * 59 + this.Genres.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.MediaType != null)
                    hashCode = hashCode * 59 + this.MediaType.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.MyListStatus != null)
                    hashCode = hashCode * 59 + this.MyListStatus.GetHashCode();
                hashCode = hashCode * 59 + this.NumVolumes.GetHashCode();
                hashCode = hashCode * 59 + this.NumChapters.GetHashCode();
                if (this.Authors != null)
                    hashCode = hashCode * 59 + this.Authors.GetHashCode();
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
            sb.Append("class MangaForList {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  MainPicture: ").Append(MainPicture).Append("\n");
            sb.Append("  AlternativeTitles: ").Append(AlternativeTitles).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Synopsis: ").Append(Synopsis).Append("\n");
            sb.Append("  Mean: ").Append(Mean).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  Popularity: ").Append(Popularity).Append("\n");
            sb.Append("  NumListUsers: ").Append(NumListUsers).Append("\n");
            sb.Append("  NumScoringUsers: ").Append(NumScoringUsers).Append("\n");
            sb.Append("  Nsfw: ").Append(Nsfw).Append("\n");
            sb.Append("  Genres: ").Append(Genres).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  MyListStatus: ").Append(MyListStatus).Append("\n");
            sb.Append("  NumVolumes: ").Append(NumVolumes).Append("\n");
            sb.Append("  NumChapters: ").Append(NumChapters).Append("\n");
            sb.Append("  Authors: ").Append(Authors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }
}