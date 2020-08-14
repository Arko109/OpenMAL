# OpenMAL.API.Model.AnimeForListAllOf
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MediaType** | **string** | - unknown - tv - ova - movie - special - ona - music  | [optional] 
**Status** | **string** | Airing status.   - finished_airing - currently_airing - not_yet_aired  | [optional] 
**MyListStatus** | **Object** |  | [optional] 
**NumEpisodes** | **int** | The total number of episodes of this series. If unknown, it is 0.  | [optional] 
**StartSeason** | **Object** |  | [optional] 
**Broadcast** | [**AnimeForListAllOfBroadcast**](AnimeForListAllOfBroadcast.md) |  | [optional] 
**Source** | **string** | Original work.  - other - original - manga - 4_koma_manga - web_manga - digital_manga - novel - light_novel - visual_novel - game - card_game - book - picture_book - radio - music  | [optional] 
**AverageEpisodeDuration** | **int?** | Average length of episode in seconds.  | [optional] 
**Rating** | **string** | | Value | Description | | - -- - | - -- - | | g | G - All Ages | | pg | PG - Children | | pg_13 | pg_13 - Teens 13 and Older | | r | R - 17+ (violence &amp; profanity) | | r+ | R+ - Profanity &amp; Mild Nudity | | rx | Rx - Hentai |  | [optional] 
**Studios** | [**List&lt;AnimeStudio&gt;**](AnimeStudio.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

