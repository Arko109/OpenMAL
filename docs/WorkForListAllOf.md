# OpenMAL.API.Model.WorkForListAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AlternativeTitles** | [**WorkForListAllOfAlternativeTitles**](WorkForListAllOfAlternativeTitles.md) |  | [optional] 
**StartDate** | **string** |  | [optional] 
**EndDate** | **string** |  | [optional] 
**Synopsis** | **string** | Synopsis.   The API strips BBCode tags from the result.  | [optional] 
**Mean** | **float?** | Mean score.  When the &#x60;mean&#x60; can not be calculated, such as when the number of user scores is small, the result does not include this field.   | [optional] 
**Rank** | **int?** | When the &#x60;rank&#x60; can not be calculated, such as when the number of user scores is small, the result does not include this field.   | [optional] 
**Popularity** | **int?** |  | [optional] 
**NumListUsers** | **int** | Number of users who have this work in their list.  | [optional] 
**NumScoringUsers** | **int** |  | [optional] 
**Nsfw** | **string** | | Value | Description | | - -- - | - -- - | | white | This work is safe for work | | gray | This work may be not safe for work | | black | This work is not safe for work |  | [optional] 
**Genres** | [**List&lt;Genre&gt;**](Genre.md) |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

