# OpenMAL.API.Model.AnimeListStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | - watching - completed - on_hold - dropped - plan_to_watch  | [optional] 
**Score** | **int** | 0-10  | [optional] 
**NumWatchedEpisodes** | **int** | 0 or the number of watched episodes.   | [optional] 
**IsRewatching** | **bool** | If authorized user watches an anime again after completion, this field value is true.  In this case, MyAnimeList treats the anime as &#39;watching&#39; in the user&#39;s anime list.  | [optional] 
**StartDate** | **DateTime?** |  | [optional] 
**FinishDate** | **DateTime?** |  | [optional] 
**Priority** | **int** |  | [optional] 
**NumTimesRewatched** | **int** |  | [optional] 
**RewatchValue** | **int** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**Comments** | **string** | You cannot contain this field in a list.  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

