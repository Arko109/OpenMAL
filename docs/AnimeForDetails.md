# OpenMAL.API.Model.AnimeForDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** |  | [optional] 
**Title** | **string** |  | [optional] 
**MainPicture** | **Object** |  | [optional] 
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
**Pictures** | [**List&lt;Picture&gt;**](Picture.md) | You cannot contain this field in a list.  | [optional] 
**Background** | **string** | The API strips BBCode tags from the result.  You cannot contain this field in a list.   | [optional] 
**RelatedAnime** | [**List&lt;RelatedAnimeEdge&gt;**](RelatedAnimeEdge.md) | You cannot contain this field in a list.  | [optional] 
**RelatedManga** | [**List&lt;RelatedMangaEdge&gt;**](RelatedMangaEdge.md) | You cannot contain this field in a list.  | [optional] 
**Recommendations** | [**List&lt;AnimeRecommendationAggregationEdgeBase&gt;**](AnimeRecommendationAggregationEdgeBase.md) | Summary of recommended anime for those who like this anime.  You cannot contain this field in a list.  | [optional] 
**Statistics** | **Object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

