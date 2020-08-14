# OpenMAL.API.Model.MangaListStatus
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | - reading - completed - on_hold - dropped - plan_to_read  | [optional] 
**Score** | **int** | 0-10  | [optional] 
**NumVolumesRead** | **int** | 0 or the number of read volumes.   | [optional] 
**NumChaptersRead** | **int** | 0 or the number of read chapters.   | [optional] 
**IsRereading** | **bool** | If authorized user reads an manga again after completion, this field value is true.  In this case, MyAnimeList treats the manga as &#39;reading&#39; in the user&#39;s manga list.  | [optional] 
**StartDate** | **DateTime?** |  | [optional] 
**FinishDate** | **DateTime?** |  | [optional] 
**Priority** | **int** |  | [optional] 
**NumTimesReread** | **int** |  | [optional] 
**RereadValue** | **int** |  | [optional] 
**Tags** | **List&lt;string&gt;** |  | [optional] 
**Comments** | **string** | You cannot contain this field in a list.  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

