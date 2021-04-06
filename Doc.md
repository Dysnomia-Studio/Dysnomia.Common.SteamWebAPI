<a name='assembly'></a>
# Dysnomia.Common.SteamWebAPI

## Contents

- [BroadcastService](#T-Dysnomia-Common-SteamWebAPI-BroadcastService 'Dysnomia.Common.SteamWebAPI.BroadcastService')
  - [PostGameDataFrame(key,appid,steamid,broadcast_id,frame_data)](#M-Dysnomia-Common-SteamWebAPI-BroadcastService-PostGameDataFrame-System-String,System-UInt32,System-UInt64,System-UInt64,System-String- 'Dysnomia.Common.SteamWebAPI.BroadcastService.PostGameDataFrame(System.String,System.UInt32,System.UInt64,System.UInt64,System.String)')
- [IBroadcastService](#T-Dysnomia-Common-SteamWebAPI-IBroadcastService 'Dysnomia.Common.SteamWebAPI.IBroadcastService')
  - [PostGameDataFrame(key,appid,steamid,broadcast_id,frame_data)](#M-Dysnomia-Common-SteamWebAPI-IBroadcastService-PostGameDataFrame-System-String,System-UInt32,System-UInt64,System-UInt64,System-String- 'Dysnomia.Common.SteamWebAPI.IBroadcastService.PostGameDataFrame(System.String,System.UInt32,System.UInt64,System.UInt64,System.String)')
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
- [ISteamUserAuth](#T-Dysnomia-Common-SteamWebAPI-ISteamUserAuth 'Dysnomia.Common.SteamWebAPI.ISteamUserAuth')
  - [AuthenticateUser(steamid,sessionkey,encrypted_loginkey)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserAuth-AuthenticateUser-System-UInt64,System-String,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamUserAuth.AuthenticateUser(System.UInt64,System.String,System.String)')
  - [AuthenticateUserTicket(key,appid,ticket)](#M-Dysnomia-Common-SteamWebAPI-ISteamUserAuth-AuthenticateUserTicket-System-String,System-UInt32,System-String- 'Dysnomia.Common.SteamWebAPI.ISteamUserAuth.AuthenticateUserTicket(System.String,System.UInt32,System.String)')
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
