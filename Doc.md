<a name='assembly'></a>
# Dysnomia.Common.SteamWebAPI

## Contents

- [BroadcastService](#T-Dysnomia-Common-SteamWebAPI-BroadcastService 'Dysnomia.Common.SteamWebAPI.BroadcastService')
  - [PostGameDataFrame(key,appid,steamid,broadcast_id,frame_data)](#M-Dysnomia-Common-SteamWebAPI-BroadcastService-PostGameDataFrame-System-String,System-UInt32,System-UInt64,System-UInt64,System-String- 'Dysnomia.Common.SteamWebAPI.BroadcastService.PostGameDataFrame(System.String,System.UInt32,System.UInt64,System.UInt64,System.String)')
- [CheatReportingService](#T-Dysnomia-Common-SteamWebAPI-CheatReportingService 'Dysnomia.Common.SteamWebAPI.CheatReportingService')
  - [GetCheatingReports(key,appid,timeend,timebegin,reportidadmin,includereports,includebans,steamid)](#M-Dysnomia-Common-SteamWebAPI-CheatReportingService-GetCheatingReports-System-String,System-UInt32,System-UInt32,System-UInt32,System-UInt64,System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.CheatReportingService.GetCheatingReports(System.String,System.UInt32,System.UInt32,System.UInt32,System.UInt64,System.Nullable{System.Boolean},System.Nullable{System.Boolean},System.Nullable{System.UInt64})')
  - [RemovePlayerGameBan(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-CheatReportingService-RemovePlayerGameBan-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.CheatReportingService.RemovePlayerGameBan(System.String,System.UInt64,System.UInt32)')
  - [ReportPlayerCheating(key,steamid,appid,steamidreporter,appdata,heuristic,detection,playerreport,noreportid,gamemode,suspicionstarttime,severity)](#M-Dysnomia-Common-SteamWebAPI-CheatReportingService-ReportPlayerCheating-System-String,System-UInt64,System-UInt32,System-Nullable{System-UInt64},System-Nullable{System-UInt64},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.CheatReportingService.ReportPlayerCheating(System.String,System.UInt64,System.UInt32,System.Nullable{System.UInt64},System.Nullable{System.UInt64},System.Nullable{System.Boolean},System.Nullable{System.Boolean},System.Nullable{System.Boolean},System.Nullable{System.Boolean},System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.Nullable{System.UInt32})')
  - [ReportPlayerCheating(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-CheatReportingService-ReportPlayerCheating-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.CheatReportingService.ReportPlayerCheating(System.String,System.UInt64,System.UInt32)')
  - [RequestPlayerGameBan(key,steamid,appid,reportid,cheatDescription,duration,delayban,flags)](#M-Dysnomia-Common-SteamWebAPI-CheatReportingService-RequestPlayerGameBan-System-String,System-UInt64,System-UInt32,System-Nullable{System-UInt64},System-String,System-Nullable{System-UInt32},System-Nullable{System-Boolean},System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.CheatReportingService.RequestPlayerGameBan(System.String,System.UInt64,System.UInt32,System.Nullable{System.UInt64},System.String,System.Nullable{System.UInt32},System.Nullable{System.Boolean},System.Nullable{System.UInt32})')
  - [RequestPlayerGameBan(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-CheatReportingService-RequestPlayerGameBan-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.CheatReportingService.RequestPlayerGameBan(System.String,System.UInt64,System.UInt32)')
- [EAbuseReportContentType](#T-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType')
  - [k_EAbuseReportContentActorUGCImage](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentActorUGCImage 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentActorUGCImage')
  - [k_EAbuseReportContentAll](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentAll 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentAll')
  - [k_EAbuseReportContentAnnouncement](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentAnnouncement 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentAnnouncement')
  - [k_EAbuseReportContentAvatarImage](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentAvatarImage 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentAvatarImage')
  - [k_EAbuseReportContentCheating](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentCheating 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentCheating')
  - [k_EAbuseReportContentComments](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentComments 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentComments')
  - [k_EAbuseReportContentCustomCSS](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentCustomCSS 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentCustomCSS')
  - [k_EAbuseReportContentEventText](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentEventText 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentEventText')
  - [k_EAbuseReportContentNoSelection](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentNoSelection 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentNoSelection')
  - [k_EAbuseReportContentPersonaName](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentPersonaName 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentPersonaName')
  - [k_EAbuseReportContentProfileText](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentProfileText 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentProfileText')
  - [k_EAbuseReportContentProfileURL](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentProfileURL 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentProfileURL')
  - [k_EAbuseReportContentScreenshot](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentScreenshot 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentScreenshot')
  - [k_EAbuseReportContentUGCImage](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentUGCImage 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentUGCImage')
  - [k_EAbuseReportContentUnspecified](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentUnspecified 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentUnspecified')
  - [k_EAbuseReportContentVideo](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentVideo 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentVideo')
  - [k_EAbuseReportContentWebLinks](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentWebLinks 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType.k_EAbuseReportContentWebLinks')
- [EAbuseReportType](#T-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType')
  - [k_EAbuseReportTypeAdultContent](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeAdultContent 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeAdultContent')
  - [k_EAbuseReportTypeAdvertisement](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeAdvertisement 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeAdvertisement')
  - [k_EAbuseReportTypeCheating](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeCheating 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeCheating')
  - [k_EAbuseReportTypeExploit](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeExploit 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeExploit')
  - [k_EAbuseReportTypeHarassment](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeHarassment 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeHarassment')
  - [k_EAbuseReportTypeInappropriate](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeInappropriate 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeInappropriate')
  - [k_EAbuseReportTypeLanguage](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeLanguage 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeLanguage')
  - [k_EAbuseReportTypeNoSelection](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeNoSelection 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeNoSelection')
  - [k_EAbuseReportTypeProhibited](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeProhibited 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeProhibited')
  - [k_EAbuseReportTypeSpamming](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeSpamming 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeSpamming')
  - [k_EAbuseReportTypeSpoofing](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeSpoofing 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeSpoofing')
  - [k_EAbuseReportTypeUnspecified](#F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeUnspecified 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType.k_EAbuseReportTypeUnspecified')
- [IBroadcastService](#T-Dysnomia-Common-SteamWebAPI-IBroadcastService 'Dysnomia.Common.SteamWebAPI.IBroadcastService')
  - [PostGameDataFrame(key,appid,steamid,broadcast_id,frame_data)](#M-Dysnomia-Common-SteamWebAPI-IBroadcastService-PostGameDataFrame-System-String,System-UInt32,System-UInt64,System-UInt64,System-String- 'Dysnomia.Common.SteamWebAPI.IBroadcastService.PostGameDataFrame(System.String,System.UInt32,System.UInt64,System.UInt64,System.String)')
- [ICheatReportingService](#T-Dysnomia-Common-SteamWebAPI-ICheatReportingService 'Dysnomia.Common.SteamWebAPI.ICheatReportingService')
  - [GetCheatingReports(key,appid,timeend,timebegin,reportidadmin,includereports,includebans,steamid)](#M-Dysnomia-Common-SteamWebAPI-ICheatReportingService-GetCheatingReports-System-String,System-UInt32,System-UInt32,System-UInt32,System-UInt64,System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.ICheatReportingService.GetCheatingReports(System.String,System.UInt32,System.UInt32,System.UInt32,System.UInt64,System.Nullable{System.Boolean},System.Nullable{System.Boolean},System.Nullable{System.UInt64})')
  - [ReportPlayerCheating(key,steamid,appid,steamidreporter,appdata,heuristic,detection,playerreport,noreportid,gamemode,suspicionstarttime,severity)](#M-Dysnomia-Common-SteamWebAPI-ICheatReportingService-ReportPlayerCheating-System-String,System-UInt64,System-UInt32,System-Nullable{System-UInt64},System-Nullable{System-UInt64},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.ICheatReportingService.ReportPlayerCheating(System.String,System.UInt64,System.UInt32,System.Nullable{System.UInt64},System.Nullable{System.UInt64},System.Nullable{System.Boolean},System.Nullable{System.Boolean},System.Nullable{System.Boolean},System.Nullable{System.Boolean},System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.Nullable{System.UInt32})')
  - [ReportPlayerCheating(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-ICheatReportingService-ReportPlayerCheating-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ICheatReportingService.ReportPlayerCheating(System.String,System.UInt64,System.UInt32)')
  - [RequestPlayerGameBan(key,steamid,appid,reportid,cheatDescription,duration,delayban,flags)](#M-Dysnomia-Common-SteamWebAPI-ICheatReportingService-RequestPlayerGameBan-System-String,System-UInt64,System-UInt32,System-Nullable{System-UInt64},System-String,System-Nullable{System-UInt32},System-Nullable{System-Boolean},System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.ICheatReportingService.RequestPlayerGameBan(System.String,System.UInt64,System.UInt32,System.Nullable{System.UInt64},System.String,System.Nullable{System.UInt32},System.Nullable{System.Boolean},System.Nullable{System.UInt32})')
  - [RequestPlayerGameBan(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-ICheatReportingService-RequestPlayerGameBan-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ICheatReportingService.RequestPlayerGameBan(System.String,System.UInt64,System.UInt32)')
- [IPlayerService](#T-Dysnomia-Common-SteamWebAPI-IPlayerService 'Dysnomia.Common.SteamWebAPI.IPlayerService')
  - [GetBadges(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-IPlayerService-GetBadges-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.IPlayerService.GetBadges(System.String,System.UInt64)')
  - [GetCommunityBadgeProgress(key,steamid,badgeid)](#M-Dysnomia-Common-SteamWebAPI-IPlayerService-GetCommunityBadgeProgress-System-String,System-UInt64,System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.IPlayerService.GetCommunityBadgeProgress(System.String,System.UInt64,System.Nullable{System.UInt32})')
  - [GetOwnedGames(key,steamid,include_appinfo,include_played_free_games)](#M-Dysnomia-Common-SteamWebAPI-IPlayerService-GetOwnedGames-System-String,System-UInt64,System-Boolean,System-Boolean- 'Dysnomia.Common.SteamWebAPI.IPlayerService.GetOwnedGames(System.String,System.UInt64,System.Boolean,System.Boolean)')
  - [GetRecentlyPlayedGames(key,steamid,count)](#M-Dysnomia-Common-SteamWebAPI-IPlayerService-GetRecentlyPlayedGames-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.IPlayerService.GetRecentlyPlayedGames(System.String,System.UInt64,System.UInt32)')
  - [GetSteamLevel(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-IPlayerService-GetSteamLevel-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.IPlayerService.GetSteamLevel(System.String,System.UInt64)')
  - [IsPlayingSharedGame(key,steamid,appid_playing)](#M-Dysnomia-Common-SteamWebAPI-IPlayerService-IsPlayingSharedGame-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.IPlayerService.IsPlayingSharedGame(System.String,System.UInt64,System.UInt32)')
- [ISteamApps](#T-Dysnomia-Common-SteamWebAPI-ISteamApps 'Dysnomia.Common.SteamWebAPI.ISteamApps')
  - [GetAppBetas(key,appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetAppBetas-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetAppBetas(System.String,System.UInt32)')
  - [GetAppBuilds(key,appid,count)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetAppBuilds-System-String,System-UInt32,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetAppBuilds(System.String,System.UInt32,System.UInt32)')
  - [GetAppDepotVersions(key,appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetAppDepotVersions-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetAppDepotVersions(System.String,System.UInt32)')
  - [GetAppList()](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetAppList 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetAppList')
  - [GetCheatingReports(key,appid,timebegin,timeend,includereports,includebans,reportidmin)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetCheatingReports-System-String,System-UInt32,System-UInt32,System-UInt32,System-Boolean,System-Boolean,System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetCheatingReports(System.String,System.UInt32,System.UInt32,System.UInt32,System.Boolean,System.Boolean,System.Nullable{System.UInt64})')
  - [GetCheatingReports(key,appid,timebegin,timeend,includereports,includebans,reportidmin)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetCheatingReports-System-String,System-UInt32,System-DateTime,System-DateTime,System-Boolean,System-Boolean,System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetCheatingReports(System.String,System.UInt32,System.DateTime,System.DateTime,System.Boolean,System.Boolean,System.Nullable{System.UInt64})')
  - [GetPartnerAppListForWebAPIKey(key,type_filter)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetPartnerAppListForWebAPIKey-System-String,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetPartnerAppListForWebAPIKey(System.String,System.String)')
  - [GetPlayersBanned(key,appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetPlayersBanned-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetPlayersBanned(System.String,System.UInt32)')
  - [GetServerList(key,filter,limit)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetServerList-System-String,System-String,System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetServerList(System.String,System.String,System.Nullable{System.UInt32})')
  - [GetServersAtAddress(addr)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetServersAtAddress-System-String- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetServersAtAddress(System.String)')
  - [SetAppBuildLive(key,appid,buildid,betakey,description)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-SetAppBuildLive-System-String,System-UInt32,System-UInt32,System-String,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamApps.SetAppBuildLive(System.String,System.UInt32,System.UInt32,System.String,System.String)')
  - [UpToDateCheck(appid,version)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-UpToDateCheck-System-UInt32,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamApps.UpToDateCheck(System.UInt32,System.UInt32)')
- [ISteamCommunity](#T-Dysnomia-Common-SteamWebAPI-ISteamCommunity 'Dysnomia.Common.SteamWebAPI.ISteamCommunity')
  - [ReportAbuse(key,steamidActor,steamidTarget,appid,abuseType,contentType,description,gid)](#M-Dysnomia-Common-SteamWebAPI-ISteamCommunity-ReportAbuse-System-String,System-UInt64,System-UInt64,System-UInt32,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType,System-String,System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.ISteamCommunity.ReportAbuse(System.String,System.UInt64,System.UInt64,System.UInt32,Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType,Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType,System.String,System.Nullable{System.UInt64})')
- [ISteamNews](#T-Dysnomia-Common-SteamWebAPI-ISteamNews 'Dysnomia.Common.SteamWebAPI.ISteamNews')
  - [GetNewsForApp(appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForApp(System.UInt32,System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.String)')
  - [GetNewsForApp(appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForApp(System.UInt32,System.Nullable{System.UInt32},System.DateTime,System.Nullable{System.UInt32},System.String)')
  - [GetNewsForApp(appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForApp-System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForApp(System.UInt32)')
  - [GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForAppAuthed(System.String,System.UInt32,System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.String)')
  - [GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForAppAuthed(System.String,System.UInt32,System.Nullable{System.UInt32},System.DateTime,System.Nullable{System.UInt32},System.String)')
  - [GetNewsForAppAuthed(key,appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForAppAuthed-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForAppAuthed(System.String,System.UInt32)')
- [ISteamUserAuth](#T-Dysnomia-Common-SteamWebAPI-ISteamUserAuth 'Dysnomia.Common.SteamWebAPI.ISteamUserAuth')
  - [AuthenticateUser(steamid,sessionkey,encrypted_loginkey)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserAuth-AuthenticateUser-System-UInt64,System-String,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamUserAuth.AuthenticateUser(System.UInt64,System.String,System.String)')
  - [AuthenticateUserTicket(key,appid,ticket)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserAuth-AuthenticateUserTicket-System-String,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamUserAuth.AuthenticateUserTicket(System.String,System.UInt32,System.String)')
- [PlayerService](#T-Dysnomia-Common-SteamWebAPI-PlayerService 'Dysnomia.Common.SteamWebAPI.PlayerService')
  - [GetBadges(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-PlayerService-GetBadges-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.PlayerService.GetBadges(System.String,System.UInt64)')
  - [GetCommunityBadgeProgress(key,steamid,badgeid)](#M-Dysnomia-Common-SteamWebAPI-PlayerService-GetCommunityBadgeProgress-System-String,System-UInt64,System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.PlayerService.GetCommunityBadgeProgress(System.String,System.UInt64,System.Nullable{System.UInt32})')
  - [GetOwnedGames(key,steamid,include_appinfo,include_played_free_games)](#M-Dysnomia-Common-SteamWebAPI-PlayerService-GetOwnedGames-System-String,System-UInt64,System-Boolean,System-Boolean- 'Dysnomia.Common.SteamWebAPI.PlayerService.GetOwnedGames(System.String,System.UInt64,System.Boolean,System.Boolean)')
  - [GetRecentlyPlayedGames(key,steamid,count)](#M-Dysnomia-Common-SteamWebAPI-PlayerService-GetRecentlyPlayedGames-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.PlayerService.GetRecentlyPlayedGames(System.String,System.UInt64,System.UInt32)')
  - [GetSteamLevel(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-PlayerService-GetSteamLevel-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.PlayerService.GetSteamLevel(System.String,System.UInt64)')
  - [IsPlayingSharedGame(key,steamid,appid_playing)](#M-Dysnomia-Common-SteamWebAPI-PlayerService-IsPlayingSharedGame-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.PlayerService.IsPlayingSharedGame(System.String,System.UInt64,System.UInt32)')
- [SteamApps](#T-Dysnomia-Common-SteamWebAPI-SteamApps 'Dysnomia.Common.SteamWebAPI.SteamApps')
  - [GetAppBetas(key,appid)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetAppBetas-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetAppBetas(System.String,System.UInt32)')
  - [GetAppBuilds(key,appid,count)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetAppBuilds-System-String,System-UInt32,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetAppBuilds(System.String,System.UInt32,System.UInt32)')
  - [GetAppDepotVersions(key,appid)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetAppDepotVersions-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetAppDepotVersions(System.String,System.UInt32)')
  - [GetAppList()](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetAppList 'Dysnomia.Common.SteamWebAPI.SteamApps.GetAppList')
  - [GetCheatingReports(key,appid,timebegin,timeend,includereports,includebans,reportidmin)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetCheatingReports-System-String,System-UInt32,System-UInt32,System-UInt32,System-Boolean,System-Boolean,System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetCheatingReports(System.String,System.UInt32,System.UInt32,System.UInt32,System.Boolean,System.Boolean,System.Nullable{System.UInt64})')
  - [GetCheatingReports(key,appid,timebegin,timeend,includereports,includebans,reportidmin)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetCheatingReports-System-String,System-UInt32,System-DateTime,System-DateTime,System-Boolean,System-Boolean,System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetCheatingReports(System.String,System.UInt32,System.DateTime,System.DateTime,System.Boolean,System.Boolean,System.Nullable{System.UInt64})')
  - [GetPartnerAppListForWebAPIKey(key,type_filter)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetPartnerAppListForWebAPIKey-System-String,System-String- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetPartnerAppListForWebAPIKey(System.String,System.String)')
  - [GetPlayersBanned(key,appid)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetPlayersBanned-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetPlayersBanned(System.String,System.UInt32)')
  - [GetServerList(key,filter,limit)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetServerList-System-String,System-String,System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetServerList(System.String,System.String,System.Nullable{System.UInt32})')
  - [GetServersAtAddress(addr)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetServersAtAddress-System-String- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetServersAtAddress(System.String)')
  - [SetAppBuildLive(key,appid,buildid,betakey,description)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-SetAppBuildLive-System-String,System-UInt32,System-UInt32,System-String,System-String- 'Dysnomia.Common.SteamWebAPI.SteamApps.SetAppBuildLive(System.String,System.UInt32,System.UInt32,System.String,System.String)')
  - [UpToDateCheck(appid,version)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-UpToDateCheck-System-UInt32,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamApps.UpToDateCheck(System.UInt32,System.UInt32)')
- [SteamCommunity](#T-Dysnomia-Common-SteamWebAPI-SteamCommunity 'Dysnomia.Common.SteamWebAPI.SteamCommunity')
  - [ReportAbuse(key,steamidActor,steamidTarget,appid,abuseType,contentType,description,gid)](#M-Dysnomia-Common-SteamWebAPI-SteamCommunity-ReportAbuse-System-String,System-UInt64,System-UInt64,System-UInt32,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType,System-String,System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.SteamCommunity.ReportAbuse(System.String,System.UInt64,System.UInt64,System.UInt32,Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType,Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType,System.String,System.Nullable{System.UInt64})')
- [SteamNews](#T-Dysnomia-Common-SteamWebAPI-SteamNews 'Dysnomia.Common.SteamWebAPI.SteamNews')
  - [GetNewsForApp(appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForApp(System.UInt32,System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.String)')
  - [GetNewsForApp(appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForApp(System.UInt32,System.Nullable{System.UInt32},System.DateTime,System.Nullable{System.UInt32},System.String)')
  - [GetNewsForApp(appid)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForApp-System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForApp(System.UInt32)')
  - [GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForAppAuthed(System.String,System.UInt32,System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.String)')
  - [GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForAppAuthed(System.String,System.UInt32,System.Nullable{System.UInt32},System.DateTime,System.Nullable{System.UInt32},System.String)')
  - [GetNewsForAppAuthed(key,appid)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForAppAuthed-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForAppAuthed(System.String,System.UInt32)')
- [SteamUserAuth](#T-Dysnomia-Common-SteamWebAPI-SteamUserAuth 'Dysnomia.Common.SteamWebAPI.SteamUserAuth')
  - [AuthenticateUser(steamid,sessionkey,encrypted_loginkey)](#M-Dysnomia-Common-SteamWebAPI-SteamUserAuth-AuthenticateUser-System-UInt64,System-String,System-String- 'Dysnomia.Common.SteamWebAPI.SteamUserAuth.AuthenticateUser(System.UInt64,System.String,System.String)')
  - [AuthenticateUserTicket(key,appid,ticket)](#M-Dysnomia-Common-SteamWebAPI-SteamUserAuth-AuthenticateUserTicket-System-String,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.SteamUserAuth.AuthenticateUserTicket(System.String,System.UInt32,System.String)')
- [SteamWebAPIQuerier](#T-Dysnomia-Common-SteamWebAPI-SteamWebAPIQuerier 'Dysnomia.Common.SteamWebAPI.SteamWebAPIQuerier')
  - [PROD_MODE](#F-Dysnomia-Common-SteamWebAPI-SteamWebAPIQuerier-PROD_MODE 'Dysnomia.Common.SteamWebAPI.SteamWebAPIQuerier.PROD_MODE')

<a name='T-Dysnomia-Common-SteamWebAPI-BroadcastService'></a>
## BroadcastService `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Provides access to Steam broadcasts.
https://partner.steamgames.com/doc/webapi/IBroadcastService

<a name='M-Dysnomia-Common-SteamWebAPI-BroadcastService-PostGameDataFrame-System-String,System-UInt32,System-UInt64,System-UInt64,System-String-'></a>
### PostGameDataFrame(key,appid,steamid,broadcast_id,frame_data) `method`

##### Summary

Add a game meta data frame to broadcast

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') |  |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') |  |
| broadcast_id | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') |  |
| frame_data | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Dysnomia-Common-SteamWebAPI-CheatReportingService'></a>
## CheatReportingService `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

This service allows your game to report cheats and cheaters to the VAC system and provides the toolset behind the Game Bans system. It enables two independent workflows for detecting and managing cheating in your game:
- Gather community reports of cheating and request bans/suspensions based upon this information.
- Submit detailed information about known cheat software to the VAC system. Once processed, this information will be used to automatically detect and ban players using known cheats.
To use this interface you must first opt in to VAC support. This can be done from the Anti-Cheat Configuration page in the App Admin panel.

https://partner.steamgames.com/doc/webapi/ICheatReportingService

<a name='M-Dysnomia-Common-SteamWebAPI-CheatReportingService-GetCheatingReports-System-String,System-UInt32,System-UInt32,System-UInt32,System-UInt64,System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-UInt64}-'></a>
### GetCheatingReports(key,appid,timeend,timebegin,reportidadmin,includereports,includebans,steamid) `method`

##### Summary

Get a list of cheating reports submitted for this app.

Used to gather the cheating reports so that they may be reviewed and a determination made.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID for the game. |
| timeend | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The end of the time range. Formatted as Unix epoch time (time since Jan 1st, 1970). |
| timebegin | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The beginning of the time range. Formatted as Unix epoch time (time since Jan 1st, 1970). |
| reportidadmin | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Minimum reportID to include. (can pass 0 - end of previous report range) |
| includereports | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Include reports. If false includebans must be true. |
| includebans | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Include ban requests? If false includereports must be true. |
| steamid | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | (Optional) Query just for this Steam ID. |

<a name='M-Dysnomia-Common-SteamWebAPI-CheatReportingService-RemovePlayerGameBan-System-String,System-UInt64,System-UInt32-'></a>
### RemovePlayerGameBan(key,steamid,appid) `method`

##### Summary

Remove a game ban on a player.

 This is used if a Game ban is determined to be a false positive.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Steam ID of the user who is reported as cheating. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The appid of the game. |

<a name='M-Dysnomia-Common-SteamWebAPI-CheatReportingService-ReportPlayerCheating-System-String,System-UInt64,System-UInt32,System-Nullable{System-UInt64},System-Nullable{System-UInt64},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32}-'></a>
### ReportPlayerCheating(key,steamid,appid,steamidreporter,appdata,heuristic,detection,playerreport,noreportid,gamemode,suspicionstarttime,severity) `method`

##### Summary

ReportPlayerCheating is designed to gather community reports of cheating, where one player reports another player within the game.

 It is intended for unreliable data from peers in the game(semi-trusted sources). The back-end that reports the data should ensure that both parties are authenticated,
 but the data in itself is treated as hearsay.Optional parameters may be used to encode the type of cheating that is suspected or additional evidence(an identifier pointing
 to the match/demo for further review).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The Steam ID of the user who is being reported for cheating. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID for the game. |
| steamidreporter | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | (Optional) The Steam ID of the user or game server who is reporting the cheating. |
| appdata | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | (Optional) App specific data about the type of cheating set by developer. (ex 1 = Aimbot, 2 = Wallhack, 3 = Griefing) |
| heuristic | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Extra information about the source of the cheating - was it a heuristic. |
| detection | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Extra information about the source of the cheating - was it a detection. |
| playerreport | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Extra information about the source of the cheating - was it a player report. |
| noreportid | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Don't return reportid. This should only be passed if you don't intend to issue a ban based on this report. |
| gamemode | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | (Optional) Extra information about state of game - was it a specific type of game play or game mode. (0 = generic) |
| suspicionstarttime | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | (Optional) Extra information indicating how far back the game thinks is interesting for this user. Unix epoch time (time since Jan 1st, 1970). |
| severity | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | (Optional) Level of severity of bad action being reported. Scale set by developer. |

<a name='M-Dysnomia-Common-SteamWebAPI-CheatReportingService-ReportPlayerCheating-System-String,System-UInt64,System-UInt32-'></a>
### ReportPlayerCheating(key,steamid,appid) `method`

##### Summary

ReportPlayerCheating is designed to gather community reports of cheating, where one player reports another player within the game.

 It is intended for unreliable data from peers in the game(semi-trusted sources). The back-end that reports the data should ensure that both parties are authenticated,
 but the data in itself is treated as hearsay.Optional parameters may be used to encode the type of cheating that is suspected or additional evidence(an identifier pointing
 to the match/demo for further review).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The Steam ID of the user who is being reported for cheating. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID for the game. |

<a name='M-Dysnomia-Common-SteamWebAPI-CheatReportingService-RequestPlayerGameBan-System-String,System-UInt64,System-UInt32,System-Nullable{System-UInt64},System-String,System-Nullable{System-UInt32},System-Nullable{System-Boolean},System-Nullable{System-UInt32}-'></a>
### RequestPlayerGameBan(key,steamid,appid,reportid,cheatDescription,duration,delayban,flags) `method`

##### Summary

Requests a game ban on a specific player.

This is designed to be used after the incidents from ReportPlayerCheating have been reviewed and cheating has been confirmed.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Steam ID of the user who is reported as cheating. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The appid of the game. |
| reportid | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | The reportid originally used to report cheating. |
| cheatDescription | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text describing cheating infraction. |
| duration | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Ban duration requested in seconds. (duration 0 will issue infinite - less than a year is a suspension and not visible on profile) |
| delayban | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | Delay the ban according to default ban delay rules. |
| flags | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Additional information about the ban request. (Unused) |

<a name='M-Dysnomia-Common-SteamWebAPI-CheatReportingService-RequestPlayerGameBan-System-String,System-UInt64,System-UInt32-'></a>
### RequestPlayerGameBan(key,steamid,appid) `method`

##### Summary

Requests a game ban on a specific player.

This is designed to be used after the incidents from ReportPlayerCheating have been reviewed and cheating has been confirmed.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Steam ID of the user who is reported as cheating. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The appid of the game. |

<a name='T-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType'></a>
## EAbuseReportContentType `type`

##### Namespace

Dysnomia.Common.SteamWebAPI.Enums

##### Summary

Different content types that can be reported as abusive.

 WARNING: These enum values MUST MATCH the values in Steam's ECommunityContentType!
 
 Extracted From TF2 and Source Engine source code

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentActorUGCImage'></a>
### k_EAbuseReportContentActorUGCImage `constants`

##### Summary

Abuse report actor has uploaded a UGC image to server as supporting documentation of their claim

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentAll'></a>
### k_EAbuseReportContentAll `constants`

##### Summary

reset all community content

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentAnnouncement'></a>
### k_EAbuseReportContentAnnouncement `constants`

##### Summary

???

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentAvatarImage'></a>
### k_EAbuseReportContentAvatarImage `constants`

##### Summary

clear avatar image

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentCheating'></a>
### k_EAbuseReportContentCheating `constants`

##### Summary

cheating

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentComments'></a>
### k_EAbuseReportContentComments `constants`

##### Summary

just comments this guy has written

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentCustomCSS'></a>
### k_EAbuseReportContentCustomCSS `constants`

##### Summary

???

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentEventText'></a>
### k_EAbuseReportContentEventText `constants`

##### Summary

???

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentNoSelection'></a>
### k_EAbuseReportContentNoSelection `constants`

##### Summary

dummy ilegal value: the user has not made a selection

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentPersonaName'></a>
### k_EAbuseReportContentPersonaName `constants`

##### Summary

persona name

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentProfileText'></a>
### k_EAbuseReportContentProfileText `constants`

##### Summary

reset profile text

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentProfileURL'></a>
### k_EAbuseReportContentProfileURL `constants`

##### Summary

delete community URL ID

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentScreenshot'></a>
### k_EAbuseReportContentScreenshot `constants`

##### Summary

screenshot

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentUGCImage'></a>
### k_EAbuseReportContentUGCImage `constants`

##### Summary

Image stored in UGC --- the report is accusing the image of being offensive

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentUnspecified'></a>
### k_EAbuseReportContentUnspecified `constants`

##### Summary

we use this to mean "other"

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentVideo'></a>
### k_EAbuseReportContentVideo `constants`

##### Summary

videos

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType-k_EAbuseReportContentWebLinks'></a>
### k_EAbuseReportContentWebLinks `constants`

##### Summary

delete web links

<a name='T-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType'></a>
## EAbuseReportType `type`

##### Namespace

Dysnomia.Common.SteamWebAPI.Enums

##### Summary

Types of reasons why a violation report was issued

WARNING: These enum values MUST MATCH the values in Steam's EAbuseReportType!

Extracted From TF2 and Source Engine source code

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeAdultContent'></a>
### k_EAbuseReportTypeAdultContent `constants`

##### Summary

any kind of adult material, references, etc

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeAdvertisement'></a>
### k_EAbuseReportTypeAdvertisement `constants`

##### Summary

unwanted advertisement

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeCheating'></a>
### k_EAbuseReportTypeCheating `constants`

##### Summary

cheating

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeExploit'></a>
### k_EAbuseReportTypeExploit `constants`

##### Summary

content data attempts to exploit code issue

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeHarassment'></a>
### k_EAbuseReportTypeHarassment `constants`

##### Summary

harassment, discrimination, racism, etc

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeInappropriate'></a>
### k_EAbuseReportTypeInappropriate `constants`

##### Summary

just not ok to post

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeLanguage'></a>
### k_EAbuseReportTypeLanguage `constants`

##### Summary

bad language

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeNoSelection'></a>
### k_EAbuseReportTypeNoSelection `constants`

##### Summary

dummy ilegal value: the user has not made a selection

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeProhibited'></a>
### k_EAbuseReportTypeProhibited `constants`

##### Summary

prohibited by EULA or general law

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeSpamming'></a>
### k_EAbuseReportTypeSpamming `constants`

##### Summary

excessive spamming

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeSpoofing'></a>
### k_EAbuseReportTypeSpoofing `constants`

##### Summary

user/group is impersonating an official contact

<a name='F-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType-k_EAbuseReportTypeUnspecified'></a>
### k_EAbuseReportTypeUnspecified `constants`

##### Summary

???

<a name='T-Dysnomia-Common-SteamWebAPI-IBroadcastService'></a>
## IBroadcastService `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Provides access to Steam broadcasts.
https://partner.steamgames.com/doc/webapi/IBroadcastService

<a name='M-Dysnomia-Common-SteamWebAPI-IBroadcastService-PostGameDataFrame-System-String,System-UInt32,System-UInt64,System-UInt64,System-String-'></a>
### PostGameDataFrame(key,appid,steamid,broadcast_id,frame_data) `method`

##### Summary

Add a game meta data frame to broadcast

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') |  |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') |  |
| broadcast_id | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') |  |
| frame_data | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Dysnomia-Common-SteamWebAPI-ICheatReportingService'></a>
## ICheatReportingService `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

This service allows your game to report cheats and cheaters to the VAC system and provides the toolset behind the Game Bans system. It enables two independent workflows for detecting and managing cheating in your game:
- Gather community reports of cheating and request bans/suspensions based upon this information.
- Submit detailed information about known cheat software to the VAC system. Once processed, this information will be used to automatically detect and ban players using known cheats.
To use this interface you must first opt in to VAC support. This can be done from the Anti-Cheat Configuration page in the App Admin panel.

https://partner.steamgames.com/doc/webapi/ICheatReportingService

<a name='M-Dysnomia-Common-SteamWebAPI-ICheatReportingService-GetCheatingReports-System-String,System-UInt32,System-UInt32,System-UInt32,System-UInt64,System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-UInt64}-'></a>
### GetCheatingReports(key,appid,timeend,timebegin,reportidadmin,includereports,includebans,steamid) `method`

##### Summary

Get a list of cheating reports submitted for this app.

Used to gather the cheating reports so that they may be reviewed and a determination made.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID for the game. |
| timeend | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The end of the time range. Formatted as Unix epoch time (time since Jan 1st, 1970). |
| timebegin | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The beginning of the time range. Formatted as Unix epoch time (time since Jan 1st, 1970). |
| reportidadmin | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Minimum reportID to include. (can pass 0 - end of previous report range) |
| includereports | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Include reports. If false includebans must be true. |
| includebans | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Include ban requests? If false includereports must be true. |
| steamid | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | (Optional) Query just for this Steam ID. |

<a name='M-Dysnomia-Common-SteamWebAPI-ICheatReportingService-ReportPlayerCheating-System-String,System-UInt64,System-UInt32,System-Nullable{System-UInt64},System-Nullable{System-UInt64},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-Boolean},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32}-'></a>
### ReportPlayerCheating(key,steamid,appid,steamidreporter,appdata,heuristic,detection,playerreport,noreportid,gamemode,suspicionstarttime,severity) `method`

##### Summary

ReportPlayerCheating is designed to gather community reports of cheating, where one player reports another player within the game.

 It is intended for unreliable data from peers in the game(semi-trusted sources). The back-end that reports the data should ensure that both parties are authenticated,
 but the data in itself is treated as hearsay.Optional parameters may be used to encode the type of cheating that is suspected or additional evidence(an identifier pointing
 to the match/demo for further review).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The Steam ID of the user who is being reported for cheating. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID for the game. |
| steamidreporter | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | (Optional) The Steam ID of the user or game server who is reporting the cheating. |
| appdata | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | (Optional) App specific data about the type of cheating set by developer. (ex 1 = Aimbot, 2 = Wallhack, 3 = Griefing) |
| heuristic | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Extra information about the source of the cheating - was it a heuristic. |
| detection | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Extra information about the source of the cheating - was it a detection. |
| playerreport | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Extra information about the source of the cheating - was it a player report. |
| noreportid | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | (Optional) Don't return reportid. This should only be passed if you don't intend to issue a ban based on this report. |
| gamemode | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | (Optional) Extra information about state of game - was it a specific type of game play or game mode. (0 = generic) |
| suspicionstarttime | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | (Optional) Extra information indicating how far back the game thinks is interesting for this user. Unix epoch time (time since Jan 1st, 1970). |
| severity | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | (Optional) Level of severity of bad action being reported. Scale set by developer. |

<a name='M-Dysnomia-Common-SteamWebAPI-ICheatReportingService-ReportPlayerCheating-System-String,System-UInt64,System-UInt32-'></a>
### ReportPlayerCheating(key,steamid,appid) `method`

##### Summary

ReportPlayerCheating is designed to gather community reports of cheating, where one player reports another player within the game.

 It is intended for unreliable data from peers in the game(semi-trusted sources). The back-end that reports the data should ensure that both parties are authenticated,
 but the data in itself is treated as hearsay.Optional parameters may be used to encode the type of cheating that is suspected or additional evidence(an identifier pointing
 to the match/demo for further review).

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The Steam ID of the user who is being reported for cheating. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID for the game. |

<a name='M-Dysnomia-Common-SteamWebAPI-ICheatReportingService-RequestPlayerGameBan-System-String,System-UInt64,System-UInt32,System-Nullable{System-UInt64},System-String,System-Nullable{System-UInt32},System-Nullable{System-Boolean},System-Nullable{System-UInt32}-'></a>
### RequestPlayerGameBan(key,steamid,appid,reportid,cheatDescription,duration,delayban,flags) `method`

##### Summary

Requests a game ban on a specific player.

This is designed to be used after the incidents from ReportPlayerCheating have been reviewed and cheating has been confirmed.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Steam ID of the user who is reported as cheating. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The appid of the game. |
| reportid | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | The reportid originally used to report cheating. |
| cheatDescription | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text describing cheating infraction. |
| duration | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Ban duration requested in seconds. (duration 0 will issue infinite - less than a year is a suspension and not visible on profile) |
| delayban | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | Delay the ban according to default ban delay rules. |
| flags | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Additional information about the ban request. (Unused) |

<a name='M-Dysnomia-Common-SteamWebAPI-ICheatReportingService-RequestPlayerGameBan-System-String,System-UInt64,System-UInt32-'></a>
### RequestPlayerGameBan(key,steamid,appid) `method`

##### Summary

Requests a game ban on a specific player.

This is designed to be used after the incidents from ReportPlayerCheating have been reviewed and cheating has been confirmed.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Steam ID of the user who is reported as cheating. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The appid of the game. |

<a name='T-Dysnomia-Common-SteamWebAPI-IPlayerService'></a>
## IPlayerService `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Provides additional methods for interacting with Steam Users.
See ISteamUser for the primary interface.

https://partner.steamgames.com/doc/webapi/IPlayerService

<a name='M-Dysnomia-Common-SteamWebAPI-IPlayerService-GetBadges-System-String,System-UInt64-'></a>
### GetBadges(key,steamid) `method`

##### Summary

Gets badges that are owned by a specific user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |

<a name='M-Dysnomia-Common-SteamWebAPI-IPlayerService-GetCommunityBadgeProgress-System-String,System-UInt64,System-Nullable{System-UInt32}-'></a>
### GetCommunityBadgeProgress(key,steamid,badgeid) `method`

##### Summary

Gets all the quests needed to get the specified badge, and which are completed

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |
| badgeid | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | The badge we're asking about |

<a name='M-Dysnomia-Common-SteamWebAPI-IPlayerService-GetOwnedGames-System-String,System-UInt64,System-Boolean,System-Boolean-'></a>
### GetOwnedGames(key,steamid,include_appinfo,include_played_free_games) `method`

##### Summary

Return a list of games owned by the player

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |
| include_appinfo | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if we want additional details (name, icon) about each game |
| include_played_free_games | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Free games are excluded by default. If this is set, free games the user has played will be returned. |

<a name='M-Dysnomia-Common-SteamWebAPI-IPlayerService-GetRecentlyPlayedGames-System-String,System-UInt64,System-UInt32-'></a>
### GetRecentlyPlayedGames(key,steamid,count) `method`

##### Summary

Gets information about a player's recently played games

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |
| count | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The number of games to return (0 = all) |

<a name='M-Dysnomia-Common-SteamWebAPI-IPlayerService-GetSteamLevel-System-String,System-UInt64-'></a>
### GetSteamLevel(key,steamid) `method`

##### Summary

Returns the Steam Level of a user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |

<a name='M-Dysnomia-Common-SteamWebAPI-IPlayerService-IsPlayingSharedGame-System-String,System-UInt64,System-UInt32-'></a>
### IsPlayingSharedGame(key,steamid,appid_playing) `method`

##### Summary

Returns valid lender SteamID if game currently played is borrowed

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |
| appid_playing | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The game player is currently playing |

<a name='T-Dysnomia-Common-SteamWebAPI-ISteamApps'></a>
## ISteamApps `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to access data about applications on Steam.
https://partner.steamgames.com/doc/webapi/ISteamApps

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetAppBetas-System-String,System-UInt32-'></a>
### GetAppBetas(key,appid) `method`

##### Summary

Gets all of the beta branches for the specified application.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID to get the betas of. |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetAppBuilds-System-String,System-UInt32,System-UInt32-'></a>
### GetAppBuilds(key,appid,count) `method`

##### Summary

Gets an applications build history.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID to get the betas of. |
| count | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The number of builds to retrieve, the default is 10. |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetAppDepotVersions-System-String,System-UInt32-'></a>
### GetAppDepotVersions(key,appid) `method`

##### Summary

Gets all the versions of all the depots for the specified application.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID to get the depot versions for. |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetAppList'></a>
### GetAppList() `method`

##### Summary

Gets the complete list of public apps.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetCheatingReports-System-String,System-UInt32,System-UInt32,System-UInt32,System-Boolean,System-Boolean,System-Nullable{System-UInt64}-'></a>
### GetCheatingReports(key,appid,timebegin,timeend,includereports,includebans,reportidmin) `method`

##### Summary

Get a list of cheating reports submitted for this app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID of game |
| timebegin | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | Time range begin |
| timeend | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | Time range end |
| includereports | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | include reports that were not bans |
| includebans | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | include reports that were bans |
| reportidmin | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | minimum report id |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetCheatingReports-System-String,System-UInt32,System-DateTime,System-DateTime,System-Boolean,System-Boolean,System-Nullable{System-UInt64}-'></a>
### GetCheatingReports(key,appid,timebegin,timeend,includereports,includebans,reportidmin) `method`

##### Summary

Get a list of cheating reports submitted for this app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID of game |
| timebegin | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Time range begin |
| timeend | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Time range end |
| includereports | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | include reports that were not bans |
| includebans | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | include reports that were bans |
| reportidmin | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | minimum report id |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetPartnerAppListForWebAPIKey-System-String,System-String-'></a>
### GetPartnerAppListForWebAPIKey(key,type_filter) `method`

##### Summary

Get a list of appIDs associated with a WebAPI key. Type_filter can used to specify certain app types to be returned.
Possible values are "game,application,tool,demo,dlc,music". When type_filter is blank or not used, all apps are returned.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| type_filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional comma separated list of types to filter on |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetPlayersBanned-System-String,System-UInt32-'></a>
### GetPlayersBanned(key,appid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID of game |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetServerList-System-String,System-String,System-Nullable{System-UInt32}-'></a>
### GetServerList(key,filter,limit) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query filter string |
| limit | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Limit number of servers in the response |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetServersAtAddress-System-String-'></a>
### GetServersAtAddress(addr) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| addr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | IP or IP:queryport to list |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-SetAppBuildLive-System-String,System-UInt32,System-UInt32,System-String,System-String-'></a>
### SetAppBuildLive(key,appid,buildid,betakey,description) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID of game |
| buildid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | BuildID |
| betakey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Beta key, required. Use public for default branch |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional description for this build |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-UpToDateCheck-System-UInt32,System-UInt32-'></a>
### UpToDateCheck(appid,version) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID of game |
| version | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The installed version of the game |

<a name='T-Dysnomia-Common-SteamWebAPI-ISteamCommunity'></a>
## ISteamCommunity `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Provides restricted access to Steam Community features.
https://partner.steamgames.com/doc/webapi/ISteamCommunity

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamCommunity-ReportAbuse-System-String,System-UInt64,System-UInt64,System-UInt32,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType,System-String,System-Nullable{System-UInt64}-'></a>
### ReportAbuse(key,steamidActor,steamidTarget,appid,abuseType,contentType,description,gid) `method`

##### Summary

Allows publishers to report users who are behaving badly on their community hub.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamidActor | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user doing the reporting |
| steamidTarget | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of the entity being accused of abuse |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to check for ownership |
| abuseType | [Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType](#T-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType') | Abuse type code |
| contentType | [Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType](#T-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType') | Content type code |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Narrative from user |
| gid | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | GID of related record (depends on content type) |

<a name='T-Dysnomia-Common-SteamWebAPI-ISteamNews'></a>
## ISteamNews `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Provides access to the Steam News functionality.
https://partner.steamgames.com/doc/webapi/ISteamNews

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String-'></a>
### GetNewsForApp(appid,maxlength,enddate,count,feeds) `method`

##### Summary

Get the news for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |
| maxlength | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit. |
| enddate | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Retrieve posts earlier than this date (unix epoch timestamp) |
| count | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | # of posts to retrieve (default 20) |
| feeds | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Comma-seperated list of feed names to return news for |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String-'></a>
### GetNewsForApp(appid,maxlength,enddate,count,feeds) `method`

##### Summary

Get the news for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |
| maxlength | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit. |
| enddate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Retrieve posts earlier than this date (unix epoch timestamp) |
| count | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | # of posts to retrieve (default 20) |
| feeds | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Comma-seperated list of feed names to return news for |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForApp-System-UInt32-'></a>
### GetNewsForApp(appid) `method`

##### Summary

Get the news for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String-'></a>
### GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds) `method`

##### Summary

Get the news for the specified app. Publisher only version that can return info for unreleased games.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |
| maxlength | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit. |
| enddate | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Retrieve posts earlier than this date (unix epoch timestamp) |
| count | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | # of posts to retrieve (default 20) |
| feeds | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Comma-seperated list of feed names to return news for |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String-'></a>
### GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds) `method`

##### Summary

Get the news for the specified app. Publisher only version that can return info for unreleased games.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |
| maxlength | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit. |
| enddate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Retrieve posts earlier than this date (unix epoch timestamp) |
| count | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | # of posts to retrieve (default 20) |
| feeds | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Comma-seperated list of feed names to return news for |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForAppAuthed-System-String,System-UInt32-'></a>
### GetNewsForAppAuthed(key,appid) `method`

##### Summary

Get the news for the specified app. Publisher only version that can return info for unreleased games.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |

<a name='T-Dysnomia-Common-SteamWebAPI-ISteamUserAuth'></a>
## ISteamUserAuth `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to access information about users.
https://partner.steamgames.com/doc/webapi/ISteamUserAuth

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUserAuth-AuthenticateUser-System-UInt64,System-String,System-String-'></a>
### AuthenticateUser(steamid,sessionkey,encrypted_loginkey) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Should be the users steamid, unencrypted. |
| sessionkey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Should be a 32 byte random blob of data, which is then encrypted with RSA using the Steam system's public key. Randomness is important here for security. |
| encrypted_loginkey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Should be the users hashed loginkey, AES encrypted with the sessionkey. |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUserAuth-AuthenticateUserTicket-System-String,System-UInt32,System-String-'></a>
### AuthenticateUserTicket(key,appid,ticket) `method`

##### Summary



##### Returns

The user's 64-bit SteamID if the user's ticket is valid

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| ticket | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Convert the ticket from GetAuthSessionTicket from binary to hex into an appropriately sized byte character array and pass the result in as this ticket parameter. |

<a name='T-Dysnomia-Common-SteamWebAPI-PlayerService'></a>
## PlayerService `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

<a name='M-Dysnomia-Common-SteamWebAPI-PlayerService-GetBadges-System-String,System-UInt64-'></a>
### GetBadges(key,steamid) `method`

##### Summary

Gets badges that are owned by a specific user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |

<a name='M-Dysnomia-Common-SteamWebAPI-PlayerService-GetCommunityBadgeProgress-System-String,System-UInt64,System-Nullable{System-UInt32}-'></a>
### GetCommunityBadgeProgress(key,steamid,badgeid) `method`

##### Summary

Gets all the quests needed to get the specified badge, and which are completed

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |
| badgeid | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | The badge we're asking about. If null, query everything we can |

<a name='M-Dysnomia-Common-SteamWebAPI-PlayerService-GetOwnedGames-System-String,System-UInt64,System-Boolean,System-Boolean-'></a>
### GetOwnedGames(key,steamid,include_appinfo,include_played_free_games) `method`

##### Summary

Return a list of games owned by the player

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |
| include_appinfo | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | true if we want additional details (name, icon) about each game |
| include_played_free_games | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Free games are excluded by default. If this is set, free games the user has played will be returned. |

<a name='M-Dysnomia-Common-SteamWebAPI-PlayerService-GetRecentlyPlayedGames-System-String,System-UInt64,System-UInt32-'></a>
### GetRecentlyPlayedGames(key,steamid,count) `method`

##### Summary

Gets information about a player's recently played games

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |
| count | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The number of games to return (0 = all) |

<a name='M-Dysnomia-Common-SteamWebAPI-PlayerService-GetSteamLevel-System-String,System-UInt64-'></a>
### GetSteamLevel(key,steamid) `method`

##### Summary

Returns the Steam Level of a user

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |

<a name='M-Dysnomia-Common-SteamWebAPI-PlayerService-IsPlayingSharedGame-System-String,System-UInt64,System-UInt32-'></a>
### IsPlayingSharedGame(key,steamid,appid_playing) `method`

##### Summary

Returns valid lender SteamID if game currently played is borrowed

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The player we're asking about |
| appid_playing | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The game player is currently playing |

<a name='T-Dysnomia-Common-SteamWebAPI-SteamApps'></a>
## SteamApps `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to access data about applications on Steam.
https://partner.steamgames.com/doc/webapi/ISteamApps

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetAppBetas-System-String,System-UInt32-'></a>
### GetAppBetas(key,appid) `method`

##### Summary

Gets all of the beta branches for the specified application.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID to get the betas of. |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetAppBuilds-System-String,System-UInt32,System-UInt32-'></a>
### GetAppBuilds(key,appid,count) `method`

##### Summary

Gets an applications build history.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID to get the betas of. |
| count | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The number of builds to retrieve, the default is 10. |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetAppDepotVersions-System-String,System-UInt32-'></a>
### GetAppDepotVersions(key,appid) `method`

##### Summary

Gets all the versions of all the depots for the specified application.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The App ID to get the depot versions for. |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetAppList'></a>
### GetAppList() `method`

##### Summary

Gets the complete list of public apps.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetCheatingReports-System-String,System-UInt32,System-UInt32,System-UInt32,System-Boolean,System-Boolean,System-Nullable{System-UInt64}-'></a>
### GetCheatingReports(key,appid,timebegin,timeend,includereports,includebans,reportidmin) `method`

##### Summary

Get a list of cheating reports submitted for this app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID of game |
| timebegin | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | Time range begin |
| timeend | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | Time range end |
| includereports | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | include reports that were not bans |
| includebans | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | include reports that were bans |
| reportidmin | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | minimum report id |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetCheatingReports-System-String,System-UInt32,System-DateTime,System-DateTime,System-Boolean,System-Boolean,System-Nullable{System-UInt64}-'></a>
### GetCheatingReports(key,appid,timebegin,timeend,includereports,includebans,reportidmin) `method`

##### Summary

Get a list of cheating reports submitted for this app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID of game |
| timebegin | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Time range begin |
| timeend | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Time range end |
| includereports | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | include reports that were not bans |
| includebans | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | include reports that were bans |
| reportidmin | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | minimum report id |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetPartnerAppListForWebAPIKey-System-String,System-String-'></a>
### GetPartnerAppListForWebAPIKey(key,type_filter) `method`

##### Summary

Get a list of appIDs associated with a WebAPI key. Type_filter can used to specify certain app types to be returned.
Possible values are "game,application,tool,demo,dlc,music". When type_filter is blank or not used, all apps are returned.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| type_filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional comma separated list of types to filter on |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetPlayersBanned-System-String,System-UInt32-'></a>
### GetPlayersBanned(key,appid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID of game |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetServerList-System-String,System-String,System-Nullable{System-UInt32}-'></a>
### GetServerList(key,filter,limit) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Query filter string |
| limit | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Limit number of servers in the response |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetServersAtAddress-System-String-'></a>
### GetServersAtAddress(addr) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| addr | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | IP or IP:queryport to list |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-SetAppBuildLive-System-String,System-UInt32,System-UInt32,System-String,System-String-'></a>
### SetAppBuildLive(key,appid,buildid,betakey,description) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID of game |
| buildid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | BuildID |
| betakey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Beta key, required. Use public for default branch |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optional description for this build |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-UpToDateCheck-System-UInt32,System-UInt32-'></a>
### UpToDateCheck(appid,version) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID of game |
| version | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The installed version of the game |

<a name='T-Dysnomia-Common-SteamWebAPI-SteamCommunity'></a>
## SteamCommunity `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Provides restricted access to Steam Community features.
https://partner.steamgames.com/doc/webapi/ISteamCommunity

<a name='M-Dysnomia-Common-SteamWebAPI-SteamCommunity-ReportAbuse-System-String,System-UInt64,System-UInt64,System-UInt32,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType,System-String,System-Nullable{System-UInt64}-'></a>
### ReportAbuse(key,steamidActor,steamidTarget,appid,abuseType,contentType,description,gid) `method`

##### Summary

Allows publishers to report users who are behaving badly on their community hub.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamidActor | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user doing the reporting |
| steamidTarget | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of the entity being accused of abuse |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to check for ownership |
| abuseType | [Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType](#T-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType') | Abuse type code (see EAbuseReportType enum) |
| contentType | [Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType](#T-Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType 'Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType') | Content type code (see ECommunityContentType enum) |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Narrative from user |
| gid | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | GID of related record (depends on content type) |

<a name='T-Dysnomia-Common-SteamWebAPI-SteamNews'></a>
## SteamNews `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Provides access to the Steam News functionality.
https://partner.steamgames.com/doc/webapi/ISteamNews

<a name='M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String-'></a>
### GetNewsForApp(appid,maxlength,enddate,count,feeds) `method`

##### Summary

Get the news for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |
| maxlength | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit. |
| enddate | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Retrieve posts earlier than this date (unix epoch timestamp) |
| count | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | # of posts to retrieve (default 20) |
| feeds | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Comma-seperated list of feed names to return news for |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String-'></a>
### GetNewsForApp(appid,maxlength,enddate,count,feeds) `method`

##### Summary

Get the news for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |
| maxlength | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit. |
| enddate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Retrieve posts earlier than this date (unix epoch timestamp) |
| count | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | # of posts to retrieve (default 20) |
| feeds | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Comma-seperated list of feed names to return news for |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForApp-System-UInt32-'></a>
### GetNewsForApp(appid) `method`

##### Summary

Get the news for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String-'></a>
### GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds) `method`

##### Summary

Get the news for the specified app. Publisher only version that can return info for unreleased games.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |
| maxlength | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit. |
| enddate | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Retrieve posts earlier than this date (unix epoch timestamp) |
| count | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | # of posts to retrieve (default 20) |
| feeds | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Comma-seperated list of feed names to return news for |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String-'></a>
### GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds) `method`

##### Summary

Get the news for the specified app. Publisher only version that can return info for unreleased games.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |
| maxlength | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit. |
| enddate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Retrieve posts earlier than this date (unix epoch timestamp) |
| count | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | # of posts to retrieve (default 20) |
| feeds | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Comma-seperated list of feed names to return news for |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForAppAuthed-System-String,System-UInt32-'></a>
### GetNewsForAppAuthed(key,appid) `method`

##### Summary

Get the news for the specified app. Publisher only version that can return info for unreleased games.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to retrieve news for |

<a name='T-Dysnomia-Common-SteamWebAPI-SteamUserAuth'></a>
## SteamUserAuth `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to access information about users.
https://partner.steamgames.com/doc/webapi/ISteamUserAuth

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUserAuth-AuthenticateUser-System-UInt64,System-String,System-String-'></a>
### AuthenticateUser(steamid,sessionkey,encrypted_loginkey) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Should be the users steamid, unencrypted. |
| sessionkey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Should be a 32 byte random blob of data, which is then encrypted with RSA using the Steam system's public key. Randomness is important here for security. |
| encrypted_loginkey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Should be the users hashed loginkey, AES encrypted with the sessionkey. |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUserAuth-AuthenticateUserTicket-System-String,System-UInt32,System-String-'></a>
### AuthenticateUserTicket(key,appid,ticket) `method`

##### Summary



##### Returns

The user's 64-bit SteamID if the user's ticket is valid

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| ticket | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Convert the ticket from GetAuthSessionTicket from binary to hex into an appropriately sized byte character array and pass the result in as this ticket parameter. |

<a name='T-Dysnomia-Common-SteamWebAPI-SteamWebAPIQuerier'></a>
## SteamWebAPIQuerier `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

<a name='F-Dysnomia-Common-SteamWebAPI-SteamWebAPIQuerier-PROD_MODE'></a>
### PROD_MODE `constants`

##### Summary

Set that value to true to directly call API at https://partner.steam-api.com/ instead of https://api.steampowered.com/
This means we will not call API through Akamai cache server.
WARNING: if you recieve multiple error returned by https://partner.steam-api.com/ your IP might be banned by the firewall for a while.
See https://partner.steamgames.com/doc/webapi_overview#addresses for more informations