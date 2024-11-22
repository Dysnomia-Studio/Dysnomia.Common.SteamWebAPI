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
  - [GetSDRConfig(appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetSDRConfig-System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetSDRConfig(System.UInt32)')
  - [GetServerList(key,filter,limit)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetServerList-System-String,System-String,System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetServerList(System.String,System.String,System.Nullable{System.UInt32})')
  - [GetServersAtAddress(addr)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetServersAtAddress-System-String- 'Dysnomia.Common.SteamWebAPI.ISteamApps.GetServersAtAddress(System.String)')
  - [SetAppBuildLive(key,appid,buildid,betakey,description)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-SetAppBuildLive-System-String,System-UInt32,System-UInt32,System-String,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamApps.SetAppBuildLive(System.String,System.UInt32,System.UInt32,System.String,System.String)')
  - [UpToDateCheck(appid,version)](#M-Dysnomia-Common-SteamWebAPI-ISteamApps-UpToDateCheck-System-UInt32,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamApps.UpToDateCheck(System.UInt32,System.UInt32)')
- [ISteamCommunity](#T-Dysnomia-Common-SteamWebAPI-ISteamCommunity 'Dysnomia.Common.SteamWebAPI.ISteamCommunity')
  - [GetAppGroupMemberListAsync(appId,page)](#M-Dysnomia-Common-SteamWebAPI-ISteamCommunity-GetAppGroupMemberListAsync-System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamCommunity.GetAppGroupMemberListAsync(System.UInt64,System.UInt32)')
  - [ReportAbuse(key,steamidActor,steamidTarget,appid,abuseType,contentType,description,gid)](#M-Dysnomia-Common-SteamWebAPI-ISteamCommunity-ReportAbuse-System-String,System-UInt64,System-UInt64,System-UInt32,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType,System-String,System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.ISteamCommunity.ReportAbuse(System.String,System.UInt64,System.UInt64,System.UInt32,Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType,Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType,System.String,System.Nullable{System.UInt64})')
- [ISteamLeaderboard](#T-Dysnomia-Common-SteamWebAPI-ISteamLeaderboard 'Dysnomia.Common.SteamWebAPI.ISteamLeaderboard')
  - [GetLeaderboardEntries(key,appid,leaderboardid,datarequest,rangestart,rangeend,steamid)](#M-Dysnomia-Common-SteamWebAPI-ISteamLeaderboard-GetLeaderboardEntries-System-String,System-UInt32,System-Int32,System-UInt32,System-Int32,System-Int32,System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.ISteamLeaderboard.GetLeaderboardEntries(System.String,System.UInt32,System.Int32,System.UInt32,System.Int32,System.Int32,System.Nullable{System.UInt64})')
  - [GetLeaderboardsForGame(key,appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamLeaderboard-GetLeaderboardsForGame-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamLeaderboard.GetLeaderboardsForGame(System.String,System.UInt32)')
  - [SetLeaderboardScore(key,appid,leaderboardid,steamid,score,scoremethod)](#M-Dysnomia-Common-SteamWebAPI-ISteamLeaderboard-SetLeaderboardScore-System-String,System-UInt32,System-UInt32,System-UInt64,System-Int32,Dysnomia-Common-SteamWebAPI-Enums-ScoreMethod- 'Dysnomia.Common.SteamWebAPI.ISteamLeaderboard.SetLeaderboardScore(System.String,System.UInt32,System.UInt32,System.UInt64,System.Int32,Dysnomia.Common.SteamWebAPI.Enums.ScoreMethod)')
  - [SetLeaderboardScore(key,appid,leaderboardid,steamid,score,scoremethod)](#M-Dysnomia-Common-SteamWebAPI-ISteamLeaderboard-SetLeaderboardScore-System-String,System-UInt32,System-UInt32,System-UInt64,System-Int32,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamLeaderboard.SetLeaderboardScore(System.String,System.UInt32,System.UInt32,System.UInt64,System.Int32,System.String)')
- [ISteamNews](#T-Dysnomia-Common-SteamWebAPI-ISteamNews 'Dysnomia.Common.SteamWebAPI.ISteamNews')
  - [GetNewsForApp(appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForApp(System.UInt32,System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.String)')
  - [GetNewsForApp(appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForApp(System.UInt32,System.Nullable{System.UInt32},System.DateTime,System.Nullable{System.UInt32},System.String)')
  - [GetNewsForApp(appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForApp-System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForApp(System.UInt32)')
  - [GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForAppAuthed(System.String,System.UInt32,System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.String)')
  - [GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForAppAuthed(System.String,System.UInt32,System.Nullable{System.UInt32},System.DateTime,System.Nullable{System.UInt32},System.String)')
  - [GetNewsForAppAuthed(key,appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamNews-GetNewsForAppAuthed-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamNews.GetNewsForAppAuthed(System.String,System.UInt32)')
- [ISteamStore](#T-Dysnomia-Common-SteamWebAPI-ISteamStore 'Dysnomia.Common.SteamWebAPI.ISteamStore')
- [ISteamUser](#T-Dysnomia-Common-SteamWebAPI-ISteamUser 'Dysnomia.Common.SteamWebAPI.ISteamUser')
  - [CheckAppOwnership(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-CheckAppOwnership-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamUser.CheckAppOwnership(System.String,System.UInt64,System.UInt32)')
  - [GetAppPriceInfo(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetAppPriceInfo-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetAppPriceInfo(System.String,System.UInt64,System.UInt32)')
  - [GetAppPriceInfo(key,steamid,appids)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetAppPriceInfo-System-String,System-UInt64,System-UInt32[]- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetAppPriceInfo(System.String,System.UInt64,System.UInt32[])')
  - [GetDeletedSteamIDs(key,rowversion)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetDeletedSteamIDs-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetDeletedSteamIDs(System.String,System.UInt32)')
  - [GetFriendList(key,steamid,relationship)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetFriendList-System-String,System-UInt64,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetFriendList(System.String,System.UInt64,System.String)')
  - [GetPlayerBans(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPlayerBans-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetPlayerBans(System.String,System.UInt64)')
  - [GetPlayerBans(key,steamids)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPlayerBans-System-String,System-UInt64[]- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetPlayerBans(System.String,System.UInt64[])')
  - [GetPlayerSummaries(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPlayerSummaries-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetPlayerSummaries(System.String,System.UInt64)')
  - [GetPlayerSummaries(key,steamids)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPlayerSummaries-System-String,System-UInt64[]- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetPlayerSummaries(System.String,System.UInt64[])')
  - [GetPublisherAppOwnership(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPublisherAppOwnership-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetPublisherAppOwnership(System.String,System.UInt64)')
  - [GetPublisherAppOwnershipChanges(key,packagerowversion,cdkeyrowversion)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPublisherAppOwnershipChanges-System-String,System-UInt64,System-UInt64- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetPublisherAppOwnershipChanges(System.String,System.UInt64,System.UInt64)')
  - [GetUserGroupList(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetUserGroupList-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GetUserGroupList(System.String,System.UInt64)')
  - [GrantPackage(key,steamid,packageid,ipaddress,thirdpartykey,thirdpartyappid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GrantPackage-System-String,System-UInt64,System-UInt32,System-String,System-String,System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GrantPackage(System.String,System.UInt64,System.UInt32,System.String,System.String,System.Nullable{System.UInt32})')
  - [GrantPackage(key,steamid,packageid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-GrantPackage-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamUser.GrantPackage(System.String,System.UInt64,System.UInt32)')
  - [ResolveVanityURL(key,vanityurl,url_type)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-ResolveVanityURL-System-String,System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamUser.ResolveVanityURL(System.String,System.String,System.UInt32)')
  - [RevokePackage(key,steamid,packageid,revokereason)](#M-Dysnomia-Common-SteamWebAPI-ISteamUser-RevokePackage-System-String,System-UInt64,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamUser.RevokePackage(System.String,System.UInt64,System.UInt32,System.String)')
- [ISteamUserAuth](#T-Dysnomia-Common-SteamWebAPI-ISteamUserAuth 'Dysnomia.Common.SteamWebAPI.ISteamUserAuth')
  - [AuthenticateUser(steamid,sessionkey,encrypted_loginkey)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserAuth-AuthenticateUser-System-UInt64,System-String,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamUserAuth.AuthenticateUser(System.UInt64,System.String,System.String)')
  - [AuthenticateUserTicket(key,appid,ticket)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserAuth-AuthenticateUserTicket-System-String,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamUserAuth.AuthenticateUserTicket(System.String,System.UInt32,System.String)')
- [ISteamUserStats](#T-Dysnomia-Common-SteamWebAPI-ISteamUserStats 'Dysnomia.Common.SteamWebAPI.ISteamUserStats')
  - [GetGlobalAchievementPercentagesForApp(gameid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetGlobalAchievementPercentagesForApp-System-UInt64- 'Dysnomia.Common.SteamWebAPI.ISteamUserStats.GetGlobalAchievementPercentagesForApp(System.UInt64)')
  - [GetGlobalStatsForGame(appid,names,startdate,enddate)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetGlobalStatsForGame-System-UInt32,System-String[],System-Nullable{System-UInt32},System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.ISteamUserStats.GetGlobalStatsForGame(System.UInt32,System.String[],System.Nullable{System.UInt32},System.Nullable{System.UInt32})')
  - [GetGlobalStatsForGame(appid,names,startdate,enddate)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetGlobalStatsForGame-System-UInt32,System-String[],System-DateTime,System-DateTime- 'Dysnomia.Common.SteamWebAPI.ISteamUserStats.GetGlobalStatsForGame(System.UInt32,System.String[],System.DateTime,System.DateTime)')
  - [GetNumberOfCurrentPlayers(appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetNumberOfCurrentPlayers-System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamUserStats.GetNumberOfCurrentPlayers(System.UInt32)')
  - [GetPlayerAchievements(key,steamid,appid,l)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetPlayerAchievements-System-String,System-UInt64,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamUserStats.GetPlayerAchievements(System.String,System.UInt64,System.UInt32,System.String)')
  - [GetSchemaForGame(key,appid,l)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetSchemaForGame-System-String,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamUserStats.GetSchemaForGame(System.String,System.UInt32,System.String)')
  - [GetUserStatsForGame(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetUserStatsForGame-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.ISteamUserStats.GetUserStatsForGame(System.String,System.UInt64,System.UInt32)')
  - [SetUserStatsForGame(key,steamid,appid,values)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-SetUserStatsForGame-System-String,System-UInt64,System-UInt32,System-Collections-Generic-Dictionary{System-String,System-UInt32}- 'Dysnomia.Common.SteamWebAPI.ISteamUserStats.SetUserStatsForGame(System.String,System.UInt64,System.UInt32,System.Collections.Generic.Dictionary{System.String,System.UInt32})')
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
  - [GetSDRConfig(appid)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetSDRConfig-System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetSDRConfig(System.UInt32)')
  - [GetServerList(key,filter,limit)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetServerList-System-String,System-String,System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetServerList(System.String,System.String,System.Nullable{System.UInt32})')
  - [GetServersAtAddress(addr)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-GetServersAtAddress-System-String- 'Dysnomia.Common.SteamWebAPI.SteamApps.GetServersAtAddress(System.String)')
  - [SetAppBuildLive(key,appid,buildid,betakey,description)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-SetAppBuildLive-System-String,System-UInt32,System-UInt32,System-String,System-String- 'Dysnomia.Common.SteamWebAPI.SteamApps.SetAppBuildLive(System.String,System.UInt32,System.UInt32,System.String,System.String)')
  - [UpToDateCheck(appid,version)](#M-Dysnomia-Common-SteamWebAPI-SteamApps-UpToDateCheck-System-UInt32,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamApps.UpToDateCheck(System.UInt32,System.UInt32)')
- [SteamCommunity](#T-Dysnomia-Common-SteamWebAPI-SteamCommunity 'Dysnomia.Common.SteamWebAPI.SteamCommunity')
  - [GetAppGroupMemberListAsync(appId,page)](#M-Dysnomia-Common-SteamWebAPI-SteamCommunity-GetAppGroupMemberListAsync-System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamCommunity.GetAppGroupMemberListAsync(System.UInt64,System.UInt32)')
  - [ReportAbuse(key,steamidActor,steamidTarget,appid,abuseType,contentType,description,gid)](#M-Dysnomia-Common-SteamWebAPI-SteamCommunity-ReportAbuse-System-String,System-UInt64,System-UInt64,System-UInt32,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportType,Dysnomia-Common-SteamWebAPI-Enums-EAbuseReportContentType,System-String,System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.SteamCommunity.ReportAbuse(System.String,System.UInt64,System.UInt64,System.UInt32,Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportType,Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType,System.String,System.Nullable{System.UInt64})')
- [SteamCommunityProfile](#T-Dysnomia-Common-SteamWebAPI-SteamCommunityProfile 'Dysnomia.Common.SteamWebAPI.SteamCommunityProfile')
- [SteamLeaderboard](#T-Dysnomia-Common-SteamWebAPI-SteamLeaderboard 'Dysnomia.Common.SteamWebAPI.SteamLeaderboard')
  - [GetLeaderboardEntries(key,appid,leaderboardid,datarequest,rangestart,rangeend,steamid)](#M-Dysnomia-Common-SteamWebAPI-SteamLeaderboard-GetLeaderboardEntries-System-String,System-UInt32,System-Int32,System-UInt32,System-Int32,System-Int32,System-Nullable{System-UInt64}- 'Dysnomia.Common.SteamWebAPI.SteamLeaderboard.GetLeaderboardEntries(System.String,System.UInt32,System.Int32,System.UInt32,System.Int32,System.Int32,System.Nullable{System.UInt64})')
  - [GetLeaderboardsForGame(key,appid)](#M-Dysnomia-Common-SteamWebAPI-SteamLeaderboard-GetLeaderboardsForGame-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamLeaderboard.GetLeaderboardsForGame(System.String,System.UInt32)')
  - [SetLeaderboardScore(key,appid,leaderboardid,steamid,score,scoremethod)](#M-Dysnomia-Common-SteamWebAPI-SteamLeaderboard-SetLeaderboardScore-System-String,System-UInt32,System-UInt32,System-UInt64,System-Int32,Dysnomia-Common-SteamWebAPI-Enums-ScoreMethod- 'Dysnomia.Common.SteamWebAPI.SteamLeaderboard.SetLeaderboardScore(System.String,System.UInt32,System.UInt32,System.UInt64,System.Int32,Dysnomia.Common.SteamWebAPI.Enums.ScoreMethod)')
  - [SetLeaderboardScore(key,appid,leaderboardid,steamid,score,scoremethod)](#M-Dysnomia-Common-SteamWebAPI-SteamLeaderboard-SetLeaderboardScore-System-String,System-UInt32,System-UInt32,System-UInt64,System-Int32,System-String- 'Dysnomia.Common.SteamWebAPI.SteamLeaderboard.SetLeaderboardScore(System.String,System.UInt32,System.UInt32,System.UInt64,System.Int32,System.String)')
- [SteamNews](#T-Dysnomia-Common-SteamWebAPI-SteamNews 'Dysnomia.Common.SteamWebAPI.SteamNews')
  - [GetNewsForApp(appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForApp(System.UInt32,System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.String)')
  - [GetNewsForApp(appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForApp-System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForApp(System.UInt32,System.Nullable{System.UInt32},System.DateTime,System.Nullable{System.UInt32},System.String)')
  - [GetNewsForApp(appid)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForApp-System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForApp(System.UInt32)')
  - [GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForAppAuthed(System.String,System.UInt32,System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.Nullable{System.UInt32},System.String)')
  - [GetNewsForAppAuthed(key,appid,maxlength,enddate,count,feeds)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForAppAuthed-System-String,System-UInt32,System-Nullable{System-UInt32},System-DateTime,System-Nullable{System-UInt32},System-String- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForAppAuthed(System.String,System.UInt32,System.Nullable{System.UInt32},System.DateTime,System.Nullable{System.UInt32},System.String)')
  - [GetNewsForAppAuthed(key,appid)](#M-Dysnomia-Common-SteamWebAPI-SteamNews-GetNewsForAppAuthed-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamNews.GetNewsForAppAuthed(System.String,System.UInt32)')
- [SteamStore](#T-Dysnomia-Common-SteamWebAPI-SteamStore 'Dysnomia.Common.SteamWebAPI.SteamStore')
- [SteamUser](#T-Dysnomia-Common-SteamWebAPI-SteamUser 'Dysnomia.Common.SteamWebAPI.SteamUser')
  - [CheckAppOwnership(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-CheckAppOwnership-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamUser.CheckAppOwnership(System.String,System.UInt64,System.UInt32)')
  - [GetAppPriceInfo(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetAppPriceInfo-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetAppPriceInfo(System.String,System.UInt64,System.UInt32)')
  - [GetAppPriceInfo(key,steamid,appids)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetAppPriceInfo-System-String,System-UInt64,System-UInt32[]- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetAppPriceInfo(System.String,System.UInt64,System.UInt32[])')
  - [GetDeletedSteamIDs(key,rowversion)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetDeletedSteamIDs-System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetDeletedSteamIDs(System.String,System.UInt32)')
  - [GetFriendList(key,steamid,relationship)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetFriendList-System-String,System-UInt64,System-String- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetFriendList(System.String,System.UInt64,System.String)')
  - [GetPlayerBans(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPlayerBans-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetPlayerBans(System.String,System.UInt64)')
  - [GetPlayerBans(key,steamids)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPlayerBans-System-String,System-UInt64[]- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetPlayerBans(System.String,System.UInt64[])')
  - [GetPlayerSummaries(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPlayerSummaries-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetPlayerSummaries(System.String,System.UInt64)')
  - [GetPlayerSummaries(key,steamids)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPlayerSummaries-System-String,System-UInt64[]- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetPlayerSummaries(System.String,System.UInt64[])')
  - [GetPublisherAppOwnership(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPublisherAppOwnership-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetPublisherAppOwnership(System.String,System.UInt64)')
  - [GetPublisherAppOwnershipChanges(key,packagerowversion,cdkeyrowversion)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPublisherAppOwnershipChanges-System-String,System-UInt64,System-UInt64- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetPublisherAppOwnershipChanges(System.String,System.UInt64,System.UInt64)')
  - [GetUserGroupList(key,steamid)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GetUserGroupList-System-String,System-UInt64- 'Dysnomia.Common.SteamWebAPI.SteamUser.GetUserGroupList(System.String,System.UInt64)')
  - [GrantPackage(key,steamid,packageid,ipaddress,thirdpartykey,thirdpartyappid)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GrantPackage-System-String,System-UInt64,System-UInt32,System-String,System-String,System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.SteamUser.GrantPackage(System.String,System.UInt64,System.UInt32,System.String,System.String,System.Nullable{System.UInt32})')
  - [GrantPackage(key,steamid,packageid)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-GrantPackage-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamUser.GrantPackage(System.String,System.UInt64,System.UInt32)')
  - [ResolveVanityURL(key,vanityurl,url_type)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-ResolveVanityURL-System-String,System-String,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamUser.ResolveVanityURL(System.String,System.String,System.UInt32)')
  - [RevokePackage(key,steamid,packageid,revokereason)](#M-Dysnomia-Common-SteamWebAPI-SteamUser-RevokePackage-System-String,System-UInt64,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.SteamUser.RevokePackage(System.String,System.UInt64,System.UInt32,System.String)')
- [SteamUserAuth](#T-Dysnomia-Common-SteamWebAPI-SteamUserAuth 'Dysnomia.Common.SteamWebAPI.SteamUserAuth')
  - [AuthenticateUser(steamid,sessionkey,encrypted_loginkey)](#M-Dysnomia-Common-SteamWebAPI-SteamUserAuth-AuthenticateUser-System-UInt64,System-String,System-String- 'Dysnomia.Common.SteamWebAPI.SteamUserAuth.AuthenticateUser(System.UInt64,System.String,System.String)')
  - [AuthenticateUserTicket(key,appid,ticket)](#M-Dysnomia-Common-SteamWebAPI-SteamUserAuth-AuthenticateUserTicket-System-String,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.SteamUserAuth.AuthenticateUserTicket(System.String,System.UInt32,System.String)')
- [SteamUserStats](#T-Dysnomia-Common-SteamWebAPI-SteamUserStats 'Dysnomia.Common.SteamWebAPI.SteamUserStats')
  - [GetGlobalAchievementPercentagesForApp(gameid)](#M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetGlobalAchievementPercentagesForApp-System-UInt64- 'Dysnomia.Common.SteamWebAPI.SteamUserStats.GetGlobalAchievementPercentagesForApp(System.UInt64)')
  - [GetGlobalStatsForGame(appid,names,startdate,enddate)](#M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetGlobalStatsForGame-System-UInt32,System-String[],System-Nullable{System-UInt32},System-Nullable{System-UInt32}- 'Dysnomia.Common.SteamWebAPI.SteamUserStats.GetGlobalStatsForGame(System.UInt32,System.String[],System.Nullable{System.UInt32},System.Nullable{System.UInt32})')
  - [GetGlobalStatsForGame(appid,names,startdate,enddate)](#M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetGlobalStatsForGame-System-UInt32,System-String[],System-DateTime,System-DateTime- 'Dysnomia.Common.SteamWebAPI.SteamUserStats.GetGlobalStatsForGame(System.UInt32,System.String[],System.DateTime,System.DateTime)')
  - [GetNumberOfCurrentPlayers(appid)](#M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetNumberOfCurrentPlayers-System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamUserStats.GetNumberOfCurrentPlayers(System.UInt32)')
  - [GetPlayerAchievements(key,steamid,appid,l)](#M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetPlayerAchievements-System-String,System-UInt64,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.SteamUserStats.GetPlayerAchievements(System.String,System.UInt64,System.UInt32,System.String)')
  - [GetSchemaForGame(key,appid,l)](#M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetSchemaForGame-System-String,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.SteamUserStats.GetSchemaForGame(System.String,System.UInt32,System.String)')
  - [GetUserStatsForGame(key,steamid,appid)](#M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetUserStatsForGame-System-String,System-UInt64,System-UInt32- 'Dysnomia.Common.SteamWebAPI.SteamUserStats.GetUserStatsForGame(System.String,System.UInt64,System.UInt32)')
  - [SetUserStatsForGame(key,steamid,appid,values)](#M-Dysnomia-Common-SteamWebAPI-SteamUserStats-SetUserStatsForGame-System-String,System-UInt64,System-UInt32,System-Collections-Generic-Dictionary{System-String,System-UInt32}- 'Dysnomia.Common.SteamWebAPI.SteamUserStats.SetUserStatsForGame(System.String,System.UInt64,System.UInt32,System.Collections.Generic.Dictionary{System.String,System.UInt32})')
- [SteamWebAPIQuerier](#T-Dysnomia-Common-SteamWebAPI-SteamWebAPIQuerier 'Dysnomia.Common.SteamWebAPI.SteamWebAPIQuerier')
  - [PROD_MODE](#P-Dysnomia-Common-SteamWebAPI-SteamWebAPIQuerier-PROD_MODE 'Dysnomia.Common.SteamWebAPI.SteamWebAPIQuerier.PROD_MODE')
- [StoreAppDetails](#T-Dysnomia-Common-SteamWebAPI-Models-StoreAppDetails 'Dysnomia.Common.SteamWebAPI.Models.StoreAppDetails')
  - [controller_support](#P-Dysnomia-Common-SteamWebAPI-Models-StoreAppDetails-controller_support 'Dysnomia.Common.SteamWebAPI.Models.StoreAppDetails.controller_support')
  - [type](#P-Dysnomia-Common-SteamWebAPI-Models-StoreAppDetails-type 'Dysnomia.Common.SteamWebAPI.Models.StoreAppDetails.type')
- [StoreAppDetailsPricePackageGroup](#T-Dysnomia-Common-SteamWebAPI-Models-StoreAppDetailsPricePackageGroup 'Dysnomia.Common.SteamWebAPI.Models.StoreAppDetailsPricePackageGroup')
  - [display_type](#P-Dysnomia-Common-SteamWebAPI-Models-StoreAppDetailsPricePackageGroup-display_type 'Dysnomia.Common.SteamWebAPI.Models.StoreAppDetailsPricePackageGroup.display_type')
- [memberList](#T-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberList')
  - [currentPage](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-currentPage 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberList.currentPage')
  - [groupDetails](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-groupDetails 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberList.groupDetails')
  - [groupID64](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-groupID64 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberList.groupID64')
  - [memberCount](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-memberCount 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberList.memberCount')
  - [members](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-members 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberList.members')
  - [startingMember](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-startingMember 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberList.startingMember')
  - [totalPages](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-totalPages 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberList.totalPages')
- [memberListGroupDetails](#T-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails')
  - [avatarFull](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-avatarFull 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.avatarFull')
  - [avatarIcon](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-avatarIcon 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.avatarIcon')
  - [avatarMedium](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-avatarMedium 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.avatarMedium')
  - [groupName](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-groupName 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.groupName')
  - [groupURL](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-groupURL 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.groupURL')
  - [headline](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-headline 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.headline')
  - [memberCount](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-memberCount 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.memberCount')
  - [membersInChat](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-membersInChat 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.membersInChat')
  - [membersInGame](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-membersInGame 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.membersInGame')
  - [membersOnline](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-membersOnline 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.membersOnline')
  - [summary](#P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-summary 'Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList.memberListGroupDetails.summary')

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

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamApps-GetSDRConfig-System-UInt32-'></a>
### GetSDRConfig(appid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
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
and access to https://steamcommunity.com/ APIs

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamCommunity-GetAppGroupMemberListAsync-System-UInt64,System-UInt32-'></a>
### GetAppGroupMemberListAsync(appId,page) `method`

##### Summary

Get an app group member list, it can be used to get the follower count of an app for example

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | AppID to query |
| page | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | Page to query |

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

<a name='T-Dysnomia-Common-SteamWebAPI-ISteamLeaderboard'></a>
## ISteamLeaderboard `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to access Steam leaderboards.

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamLeaderboard-GetLeaderboardEntries-System-String,System-UInt32,System-Int32,System-UInt32,System-Int32,System-Int32,System-Nullable{System-UInt64}-'></a>
### GetLeaderboardEntries(key,appid,leaderboardid,datarequest,rangestart,rangeend,steamid) `method`

##### Summary

Get entries for a specific app leaderboard

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| leaderboardid | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | SteamID used for friend and around user requests |
| datarequest | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | type of request: RequestGlobal, RequestAroundUser, RequestFriends |
| rangestart | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | range start or 0 |
| rangeend | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | range end or max LB entries |
| steamid | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | SteamID used for friend and around user requests |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamLeaderboard-GetLeaderboardsForGame-System-String,System-UInt32-'></a>
### GetLeaderboardsForGame(key,appid) `method`

##### Summary

Returns leaderboard list for a specific app id

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamLeaderboard-SetLeaderboardScore-System-String,System-UInt32,System-UInt32,System-UInt64,System-Int32,Dysnomia-Common-SteamWebAPI-Enums-ScoreMethod-'></a>
### SetLeaderboardScore(key,appid,leaderboardid,steamid,score,scoremethod) `method`

##### Summary

Set score for a specific user, appid and leaderboard

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| leaderboardid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | numeric ID of the target leaderboard. Can be retrieved from GetLeaderboardsForGame |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | steamID to set the score for |
| score | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | the score to set for this user |
| scoremethod | [Dysnomia.Common.SteamWebAPI.Enums.ScoreMethod](#T-Dysnomia-Common-SteamWebAPI-Enums-ScoreMethod 'Dysnomia.Common.SteamWebAPI.Enums.ScoreMethod') | update method to use. Can be "KeepBest" or "ForceUpdate" |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamLeaderboard-SetLeaderboardScore-System-String,System-UInt32,System-UInt32,System-UInt64,System-Int32,System-String-'></a>
### SetLeaderboardScore(key,appid,leaderboardid,steamid,score,scoremethod) `method`

##### Summary

Set score for a specific user, appid and leaderboard

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| leaderboardid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | numeric ID of the target leaderboard. Can be retrieved from GetLeaderboardsForGame |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | steamID to set the score for |
| score | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | the score to set for this user |
| scoremethod | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | update method to use. Can be "KeepBest" or "ForceUpdate" |

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

<a name='T-Dysnomia-Common-SteamWebAPI-ISteamStore'></a>
## ISteamStore `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

This class is using steam store API (https://store.steampowered.com/api/)

<a name='T-Dysnomia-Common-SteamWebAPI-ISteamUser'></a>
## ISteamUser `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to access information and interact with users.
See IPlayerService for additional methods.

https://partner.steamgames.com/doc/webapi/ISteamUser

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-CheckAppOwnership-System-String,System-UInt64,System-UInt32-'></a>
### CheckAppOwnership(key,steamid,appid) `method`

##### Summary

Checks if the specified user owns the app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to check for ownership |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetAppPriceInfo-System-String,System-UInt64,System-UInt32-'></a>
### GetAppPriceInfo(key,steamid,appid) `method`

##### Summary

Get price info about one or mutiple apps

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | App id |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetAppPriceInfo-System-String,System-UInt64,System-UInt32[]-'></a>
### GetAppPriceInfo(key,steamid,appids) `method`

##### Summary

Get price info about one or mutiple apps

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appids | [System.UInt32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32[] 'System.UInt32[]') | App ids (max: 100) |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetDeletedSteamIDs-System-String,System-UInt32-'></a>
### GetDeletedSteamIDs(key,rowversion) `method`

##### Summary

You can use GetDeletedSteamIDs to retrieve a list of deleted accounts that owned your game(s) before deletion. This API was created to allow for the deletion of user related data for GDPR and other personal information related purposes.

 The provided Steamworks Publisher Key is used for both authentication and to generate the list of appids to check against.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| rowversion | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | An unsigned 64-bit value used to page through deleted accounts. Pass 0 when calling this API for the first time, then pass the value returned from the previous call for each additional request. This value will need to be stored on your server for future calls. |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetFriendList-System-String,System-UInt64,System-String-'></a>
### GetFriendList(key,steamid,relationship) `method`

##### Summary

Gets friend list of a specific user by its steamid

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| relationship | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | relationship type (ex: friend) |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPlayerBans-System-String,System-UInt64-'></a>
### GetPlayerBans(key,steamid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Target Steam ID |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPlayerBans-System-String,System-UInt64[]-'></a>
### GetPlayerBans(key,steamids) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamids | [System.UInt64[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64[] 'System.UInt64[]') | Target Steam IDs |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPlayerSummaries-System-String,System-UInt64-'></a>
### GetPlayerSummaries(key,steamid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Target Steam ID |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPlayerSummaries-System-String,System-UInt64[]-'></a>
### GetPlayerSummaries(key,steamids) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamids | [System.UInt64[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64[] 'System.UInt64[]') | Target Steam IDs |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPublisherAppOwnership-System-String,System-UInt64-'></a>
### GetPublisherAppOwnership(key,steamid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetPublisherAppOwnershipChanges-System-String,System-UInt64,System-UInt64-'></a>
### GetPublisherAppOwnershipChanges(key,packagerowversion,cdkeyrowversion) `method`

##### Summary

This method can be used to determine what SteamIDs have ownership changes starting from a particular package or key row version number. From the list of SteamIDs returned, a call to GetPublisherAppOwnership can then return the associated ownership data for the applications in the group associated with the key passed in. A partner may wish to track this data in conjunction with linked Steam Accounts to better understand the state of product ownership on Steam.

To begin, make a call to GetPublisherAppOwnershipChanges passing in packagerowversion and cdkeyrowversion with the values of 0 (zero). The response from the call will look something like this:

After this first call returns:
1) Make a call to GetPublisherAppOwnership for each SteamID to get the actual ownership per AppID.Store or use that data as needed.
2) Once all the SteamIDs have been processed, check the value of moredata.If it is true, make a new call to GetPublisherAppOwnershipChanges passing in the packagerowversion and cdkeyrowversion as returned from the previous call to GetPublisherAppOwnershipChanges.
3) Repeat Step 1 and 2 until moredata returns false.
4) Store the final packagerowversion and cdkeyrowversion values for use in future GetPublisherAppOwnershipChanges calls(e.g. 24 hours later) instead of starting at 0 (zero) again.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| packagerowversion | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The unsigned 64-bit row version to read package changes from. The row version of data read up to will be returned for use in future calls. |
| cdkeyrowversion | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The unsigned 64-bit row version to read CD Key changes from. The row version of data read up to will be returned for use in future calls. |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GetUserGroupList-System-String,System-UInt64-'></a>
### GetUserGroupList(key,steamid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GrantPackage-System-String,System-UInt64,System-UInt32,System-String,System-String,System-Nullable{System-UInt32}-'></a>
### GrantPackage(key,steamid,packageid,ipaddress,thirdpartykey,thirdpartyappid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| packageid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | PackageID to grant |
| ipaddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | ip address of user in string format (xxx.xxx.xxx.xxx). |
| thirdpartykey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optionally associate third party key during grant. 'thirdpartyappid' will have to be set. |
| thirdpartyappid | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Has to be set if 'thirdpartykey' is set. The appid associated with the 'thirdpartykey'. |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-GrantPackage-System-String,System-UInt64,System-UInt32-'></a>
### GrantPackage(key,steamid,packageid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| packageid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | PackageID to grant |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-ResolveVanityURL-System-String,System-String,System-UInt32-'></a>
### ResolveVanityURL(key,vanityurl,url_type) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| vanityurl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The vanity URL to get a SteamID for |
| url_type | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The type of vanity URL. 1 (default): Individual profile, 2: Group, 3: Official game group |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUser-RevokePackage-System-String,System-UInt64,System-UInt32,System-String-'></a>
### RevokePackage(key,steamid,packageid,revokereason) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| packageid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | PackageID to grant |
| revokereason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reason for why to revoke |

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

<a name='T-Dysnomia-Common-SteamWebAPI-ISteamUserStats'></a>
## ISteamUserStats `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to access information about users.
https://partner.steamgames.com/doc/webapi/ISteamUserStats

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetGlobalAchievementPercentagesForApp-System-UInt64-'></a>
### GetGlobalAchievementPercentagesForApp(gameid) `method`

##### Summary

Retrieves the global achievement percentages for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | GameID to retrieve the achievement percentages for |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetGlobalStatsForGame-System-UInt32,System-String[],System-Nullable{System-UInt32},System-Nullable{System-UInt32}-'></a>
### GetGlobalStatsForGame(appid,names,startdate,enddate) `method`

##### Summary

Retrieves the global stats percentages for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID that we're getting global stats for |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Stats to get |
| startdate | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Start date for daily totals (unix epoch timestamp) |
| enddate | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | End date for daily totals (unix epoch timestamp) |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetGlobalStatsForGame-System-UInt32,System-String[],System-DateTime,System-DateTime-'></a>
### GetGlobalStatsForGame(appid,names,startdate,enddate) `method`

##### Summary

Retrieves the global stats percentages for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID that we're getting global stats for |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Stats to get |
| startdate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Start date for daily totals |
| enddate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | End date for daily totals |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetNumberOfCurrentPlayers-System-UInt32-'></a>
### GetNumberOfCurrentPlayers(appid) `method`

##### Summary

Gets the total number of players currently active in the specified app on Steam.

Note that this will not return players that are playing while not connected to Steam.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID that we're getting user count for |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetPlayerAchievements-System-String,System-UInt64,System-UInt32,System-String-'></a>
### GetPlayerAchievements(key,steamid,appid,l) `method`

##### Summary

Gets the list of achievements the specified user has unlocked in an app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to get achievements for |
| l | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional) Language to return strings for (english, french, etc.). null = no translation |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetSchemaForGame-System-String,System-UInt32,System-String-'></a>
### GetSchemaForGame(key,appid,l) `method`

##### Summary

Gets the complete list of stats and achievements for the specified game.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| l | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional) Localized language to return (english, french, etc.). null = no translation |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-GetUserStatsForGame-System-String,System-UInt64,System-UInt32-'></a>
### GetUserStatsForGame(key,steamid,appid) `method`

##### Summary

Gets the list of stats that the specified user has set in an app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |

<a name='M-Dysnomia-Common-SteamWebAPI-ISteamUserStats-SetUserStatsForGame-System-String,System-UInt64,System-UInt32,System-Collections-Generic-Dictionary{System-String,System-UInt32}-'></a>
### SetUserStatsForGame(key,steamid,appid,values) `method`

##### Summary

Sets a stat for the specified user for the game.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| values | [System.Collections.Generic.Dictionary{System.String,System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.UInt32}') | Dictionnary listing "Stat name" => "Value" |

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

<a name='M-Dysnomia-Common-SteamWebAPI-SteamApps-GetSDRConfig-System-UInt32-'></a>
### GetSDRConfig(appid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
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
and access to https://steamcommunity.com/ APIs

<a name='M-Dysnomia-Common-SteamWebAPI-SteamCommunity-GetAppGroupMemberListAsync-System-UInt64,System-UInt32-'></a>
### GetAppGroupMemberListAsync(appId,page) `method`

##### Summary

Get an app group member list, it can be used to get the follower count of an app for example

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appId | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | AppID to query |
| page | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | Page to query |

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

<a name='T-Dysnomia-Common-SteamWebAPI-SteamCommunityProfile'></a>
## SteamCommunityProfile `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to get data directly from profile in steamcommunity.com website

<a name='T-Dysnomia-Common-SteamWebAPI-SteamLeaderboard'></a>
## SteamLeaderboard `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to access Steam leaderboards.

<a name='M-Dysnomia-Common-SteamWebAPI-SteamLeaderboard-GetLeaderboardEntries-System-String,System-UInt32,System-Int32,System-UInt32,System-Int32,System-Int32,System-Nullable{System-UInt64}-'></a>
### GetLeaderboardEntries(key,appid,leaderboardid,datarequest,rangestart,rangeend,steamid) `method`

##### Summary

Get entries for a specific app leaderboard

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| leaderboardid | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | SteamID used for friend and around user requests |
| datarequest | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | type of request: RequestGlobal, RequestAroundUser, RequestFriends |
| rangestart | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | range start or 0 |
| rangeend | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | range end or max LB entries |
| steamid | [System.Nullable{System.UInt64}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt64}') | SteamID used for friend and around user requests |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamLeaderboard-GetLeaderboardsForGame-System-String,System-UInt32-'></a>
### GetLeaderboardsForGame(key,appid) `method`

##### Summary

Returns leaderboard list for a specific app id

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamLeaderboard-SetLeaderboardScore-System-String,System-UInt32,System-UInt32,System-UInt64,System-Int32,Dysnomia-Common-SteamWebAPI-Enums-ScoreMethod-'></a>
### SetLeaderboardScore(key,appid,leaderboardid,steamid,score,scoremethod) `method`

##### Summary

Set score for a specific user, appid and leaderboard

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| leaderboardid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | numeric ID of the target leaderboard. Can be retrieved from GetLeaderboardsForGame |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | steamID to set the score for |
| score | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | the score to set for this user |
| scoremethod | [Dysnomia.Common.SteamWebAPI.Enums.ScoreMethod](#T-Dysnomia-Common-SteamWebAPI-Enums-ScoreMethod 'Dysnomia.Common.SteamWebAPI.Enums.ScoreMethod') | update method to use. Can be "KeepBest" or "ForceUpdate" |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamLeaderboard-SetLeaderboardScore-System-String,System-UInt32,System-UInt32,System-UInt64,System-Int32,System-String-'></a>
### SetLeaderboardScore(key,appid,leaderboardid,steamid,score,scoremethod) `method`

##### Summary

Set score for a specific user, appid and leaderboard

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| leaderboardid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | numeric ID of the target leaderboard. Can be retrieved from GetLeaderboardsForGame |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | steamID to set the score for |
| score | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | the score to set for this user |
| scoremethod | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | update method to use. Can be "KeepBest" or "ForceUpdate" |

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

<a name='T-Dysnomia-Common-SteamWebAPI-SteamStore'></a>
## SteamStore `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

This class is using steam store API (https://store.steampowered.com/api/)

<a name='T-Dysnomia-Common-SteamWebAPI-SteamUser'></a>
## SteamUser `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to access information and interact with users.
See IPlayerService for additional methods.

https://partner.steamgames.com/doc/webapi/ISteamUser

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-CheckAppOwnership-System-String,System-UInt64,System-UInt32-'></a>
### CheckAppOwnership(key,steamid,appid) `method`

##### Summary

Checks if the specified user owns the app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to check for ownership |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetAppPriceInfo-System-String,System-UInt64,System-UInt32-'></a>
### GetAppPriceInfo(key,steamid,appid) `method`

##### Summary

Get price info about one or mutiple apps

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | App id |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetAppPriceInfo-System-String,System-UInt64,System-UInt32[]-'></a>
### GetAppPriceInfo(key,steamid,appids) `method`

##### Summary

Get price info about one or mutiple apps

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appids | [System.UInt32[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32[] 'System.UInt32[]') | App ids (max: 100) |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetDeletedSteamIDs-System-String,System-UInt32-'></a>
### GetDeletedSteamIDs(key,rowversion) `method`

##### Summary

You can use GetDeletedSteamIDs to retrieve a list of deleted accounts that owned your game(s) before deletion. This API was created to allow for the deletion of user related data for GDPR and other personal information related purposes.

 The provided Steamworks Publisher Key is used for both authentication and to generate the list of appids to check against.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| rowversion | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | An unsigned 64-bit value used to page through deleted accounts. Pass 0 when calling this API for the first time, then pass the value returned from the previous call for each additional request. This value will need to be stored on your server for future calls. |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetFriendList-System-String,System-UInt64,System-String-'></a>
### GetFriendList(key,steamid,relationship) `method`

##### Summary

Gets friend list of a specific user by its steamid

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| relationship | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | relationship type (ex: friend) |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPlayerBans-System-String,System-UInt64-'></a>
### GetPlayerBans(key,steamid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Target Steam ID |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPlayerBans-System-String,System-UInt64[]-'></a>
### GetPlayerBans(key,steamids) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamids | [System.UInt64[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64[] 'System.UInt64[]') | Target Steam IDs |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPlayerSummaries-System-String,System-UInt64-'></a>
### GetPlayerSummaries(key,steamid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | Target Steam ID |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPlayerSummaries-System-String,System-UInt64[]-'></a>
### GetPlayerSummaries(key,steamids) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamids | [System.UInt64[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64[] 'System.UInt64[]') | Target Steam IDs |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPublisherAppOwnership-System-String,System-UInt64-'></a>
### GetPublisherAppOwnership(key,steamid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetPublisherAppOwnershipChanges-System-String,System-UInt64,System-UInt64-'></a>
### GetPublisherAppOwnershipChanges(key,packagerowversion,cdkeyrowversion) `method`

##### Summary

This method can be used to determine what SteamIDs have ownership changes starting from a particular package or key row version number. From the list of SteamIDs returned, a call to GetPublisherAppOwnership can then return the associated ownership data for the applications in the group associated with the key passed in. A partner may wish to track this data in conjunction with linked Steam Accounts to better understand the state of product ownership on Steam.

To begin, make a call to GetPublisherAppOwnershipChanges passing in packagerowversion and cdkeyrowversion with the values of 0 (zero). The response from the call will look something like this:

After this first call returns:
1) Make a call to GetPublisherAppOwnership for each SteamID to get the actual ownership per AppID.Store or use that data as needed.
2) Once all the SteamIDs have been processed, check the value of moredata.If it is true, make a new call to GetPublisherAppOwnershipChanges passing in the packagerowversion and cdkeyrowversion as returned from the previous call to GetPublisherAppOwnershipChanges.
3) Repeat Step 1 and 2 until moredata returns false.
4) Store the final packagerowversion and cdkeyrowversion values for use in future GetPublisherAppOwnershipChanges calls(e.g. 24 hours later) instead of starting at 0 (zero) again.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| packagerowversion | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The unsigned 64-bit row version to read package changes from. The row version of data read up to will be returned for use in future calls. |
| cdkeyrowversion | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | The unsigned 64-bit row version to read CD Key changes from. The row version of data read up to will be returned for use in future calls. |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GetUserGroupList-System-String,System-UInt64-'></a>
### GetUserGroupList(key,steamid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GrantPackage-System-String,System-UInt64,System-UInt32,System-String,System-String,System-Nullable{System-UInt32}-'></a>
### GrantPackage(key,steamid,packageid,ipaddress,thirdpartykey,thirdpartyappid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| packageid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | PackageID to grant |
| ipaddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | ip address of user in string format (xxx.xxx.xxx.xxx). |
| thirdpartykey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Optionally associate third party key during grant. 'thirdpartyappid' will have to be set. |
| thirdpartyappid | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Has to be set if 'thirdpartykey' is set. The appid associated with the 'thirdpartykey'. |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-GrantPackage-System-String,System-UInt64,System-UInt32-'></a>
### GrantPackage(key,steamid,packageid) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| packageid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | PackageID to grant |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-ResolveVanityURL-System-String,System-String,System-UInt32-'></a>
### ResolveVanityURL(key,vanityurl,url_type) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| vanityurl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The vanity URL to get a SteamID for |
| url_type | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | The type of vanity URL. 1 (default): Individual profile, 2: Group, 3: Official game group |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUser-RevokePackage-System-String,System-UInt64,System-UInt32,System-String-'></a>
### RevokePackage(key,steamid,packageid,revokereason) `method`

##### Summary



##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| packageid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | PackageID to grant |
| revokereason | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Reason for why to revoke |

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

<a name='T-Dysnomia-Common-SteamWebAPI-SteamUserStats'></a>
## SteamUserStats `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

##### Summary

Used to access information about users.
https://partner.steamgames.com/doc/webapi/ISteamUserStats

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetGlobalAchievementPercentagesForApp-System-UInt64-'></a>
### GetGlobalAchievementPercentagesForApp(gameid) `method`

##### Summary

Retrieves the global achievement percentages for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| gameid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | GameID to retrieve the achievement percentages for |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetGlobalStatsForGame-System-UInt32,System-String[],System-Nullable{System-UInt32},System-Nullable{System-UInt32}-'></a>
### GetGlobalStatsForGame(appid,names,startdate,enddate) `method`

##### Summary

Retrieves the global stats percentages for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID that we're getting global stats for |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Stats to get |
| startdate | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | Start date for daily totals (unix epoch timestamp) |
| enddate | [System.Nullable{System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.UInt32}') | End date for daily totals (unix epoch timestamp) |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetGlobalStatsForGame-System-UInt32,System-String[],System-DateTime,System-DateTime-'></a>
### GetGlobalStatsForGame(appid,names,startdate,enddate) `method`

##### Summary

Retrieves the global stats percentages for the specified app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID that we're getting global stats for |
| names | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Stats to get |
| startdate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | Start date for daily totals |
| enddate | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | End date for daily totals |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetNumberOfCurrentPlayers-System-UInt32-'></a>
### GetNumberOfCurrentPlayers(appid) `method`

##### Summary

Gets the total number of players currently active in the specified app on Steam.

Note that this will not return players that are playing while not connected to Steam.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID that we're getting user count for |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetPlayerAchievements-System-String,System-UInt64,System-UInt32,System-String-'></a>
### GetPlayerAchievements(key,steamid,appid,l) `method`

##### Summary

Gets the list of achievements the specified user has unlocked in an app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | AppID to get achievements for |
| l | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional) Language to return strings for (english, french, etc.). null = no translation |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetSchemaForGame-System-String,System-UInt32,System-String-'></a>
### GetSchemaForGame(key,appid,l) `method`

##### Summary

Gets the complete list of stats and achievements for the specified game.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| l | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | (Optional) Localized language to return (english, french, etc.). null = no translation |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUserStats-GetUserStatsForGame-System-String,System-UInt64,System-UInt32-'></a>
### GetUserStatsForGame(key,steamid,appid) `method`

##### Summary

Gets the list of stats that the specified user has set in an app.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API user authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |

<a name='M-Dysnomia-Common-SteamWebAPI-SteamUserStats-SetUserStatsForGame-System-String,System-UInt64,System-UInt32,System-Collections-Generic-Dictionary{System-String,System-UInt32}-'></a>
### SetUserStatsForGame(key,steamid,appid,values) `method`

##### Summary

Sets a stat for the specified user for the game.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Steamworks Web API publisher authentication key. |
| steamid | [System.UInt64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt64 'System.UInt64') | SteamID of user |
| appid | [System.UInt32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UInt32 'System.UInt32') | appid of game |
| values | [System.Collections.Generic.Dictionary{System.String,System.UInt32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.UInt32}') | Dictionnary listing "Stat name" => "Value" |

<a name='T-Dysnomia-Common-SteamWebAPI-SteamWebAPIQuerier'></a>
## SteamWebAPIQuerier `type`

##### Namespace

Dysnomia.Common.SteamWebAPI

<a name='P-Dysnomia-Common-SteamWebAPI-SteamWebAPIQuerier-PROD_MODE'></a>
### PROD_MODE `property`

##### Summary

Set that value to true to directly call API at https://partner.steam-api.com/ instead of https://api.steampowered.com/
This means we will not call API through Akamai cache server.
WARNING: if you recieve multiple error returned by https://partner.steam-api.com/ your IP might be banned by the firewall for a while.
See https://partner.steamgames.com/doc/webapi_overview#addresses for more informations

<a name='T-Dysnomia-Common-SteamWebAPI-Models-StoreAppDetails'></a>
## StoreAppDetails `type`

##### Namespace

Dysnomia.Common.SteamWebAPI.Models

<a name='P-Dysnomia-Common-SteamWebAPI-Models-StoreAppDetails-controller_support'></a>
### controller_support `property`

##### Summary

partial, full, or not filled

<a name='P-Dysnomia-Common-SteamWebAPI-Models-StoreAppDetails-type'></a>
### type `property`

##### Summary

Observed values: "game", "dlc", "demo", "advertising", "mod", "video".

<a name='T-Dysnomia-Common-SteamWebAPI-Models-StoreAppDetailsPricePackageGroup'></a>
## StoreAppDetailsPricePackageGroup `type`

##### Namespace

Dysnomia.Common.SteamWebAPI.Models

<a name='P-Dysnomia-Common-SteamWebAPI-Models-StoreAppDetailsPricePackageGroup-display_type'></a>
### display_type `property`

##### Summary

Old rules:
0 - list subs as seperate purchase blocks.
1 - list subs in a dropdown box, contained within a single purchase block for the package group
default - ???

<a name='T-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList'></a>
## memberList `type`

##### Namespace

Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList

##### Remarks

Root object for memberlist call on SteamCommunity XML api

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-currentPage'></a>
### currentPage `property`

##### Remarks

Memberlist current page

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-groupDetails'></a>
### groupDetails `property`

##### Remarks

Group details

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-groupID64'></a>
### groupID64 `property`

##### Remarks

64 bits id of this steam group

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-memberCount'></a>
### memberCount `property`

##### Remarks

Group member count

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-members'></a>
### members `property`

##### Remarks

Member list

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-startingMember'></a>
### startingMember `property`

##### Remarks

Memberlist starting member counter

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberList-totalPages'></a>
### totalPages `property`

##### Remarks

Memberlist page count

<a name='T-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails'></a>
## memberListGroupDetails `type`

##### Namespace

Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList

##### Remarks



<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-avatarFull'></a>
### avatarFull `property`

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-avatarIcon'></a>
### avatarIcon `property`

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-avatarMedium'></a>
### avatarMedium `property`

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-groupName'></a>
### groupName `property`

##### Remarks

Group name

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-groupURL'></a>
### groupURL `property`

##### Remarks

Group id in URL (can be different from 64 bit id)

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-headline'></a>
### headline `property`

##### Remarks

Group headline (empty if it's the group containing followers)

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-memberCount'></a>
### memberCount `property`

##### Remarks

Group member count

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-membersInChat'></a>
### membersInChat `property`

##### Remarks

How many group members are in the chat

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-membersInGame'></a>
### membersInGame `property`

##### Remarks

How many group members are in a game

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-membersOnline'></a>
### membersOnline `property`

##### Remarks

How many group members are online

<a name='P-Dysnomia-Common-SteamWebAPI-Models-SteamCommunityGroupMemberList-memberListGroupDetails-summary'></a>
### summary `property`

##### Remarks

Group summary ("No information given" if it's the group containing followers)
