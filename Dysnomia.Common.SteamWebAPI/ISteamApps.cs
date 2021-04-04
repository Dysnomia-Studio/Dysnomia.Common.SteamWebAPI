using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	public interface ISteamApps {
		/// <summary>
		/// Gets all of the beta branches for the specified application.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">The App ID to get the betas of.</param>
		/// <returns></returns>
		Task<Dictionary<string, AppBetasBranch>> GetAppBetas(string key, uint appid);

		/// <summary>
		/// Gets an applications build history.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">The App ID to get the betas of.</param>
		/// <param name="count">The number of builds to retrieve, the default is 10.</param>
		/// <returns></returns>
		Task<Dictionary<string, AppBuild>> GetAppBuilds(string key, uint appid, uint count = 10);

		/// <summary>
		/// Gets all the versions of all the depots for the specified application.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">The App ID to get the depot versions for.</param>
		/// <returns></returns>
		Task<Dictionary<string, object>> GetAppDepotVersions(string key, uint appid);

		/// <summary>
		/// Gets the complete list of public apps.
		/// </summary>
		/// <returns></returns>
		Task<IList<AppListItem>> GetAppList();

		/// <summary>
		/// Get a list of cheating reports submitted for this app.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">AppID of game</param>
		/// <param name="timebegin">Time range begin</param>
		/// <param name="timeend">Time range end</param>
		/// <param name="includereports">include reports that were not bans</param>
		/// <param name="includebans">include reports that were bans</param>
		/// <param name="reportidmin">minimum report id</param>
		/// <returns></returns>
		Task<string> GetCheatingReports(string key, uint appid, uint timebegin, uint timeend, bool includereports, bool includebans, ulong? reportidmin = null);


		/// <summary>
		/// Get a list of cheating reports submitted for this app.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">AppID of game</param>
		/// <param name="timebegin">Time range begin</param>
		/// <param name="timeend">Time range end</param>
		/// <param name="includereports">include reports that were not bans</param>
		/// <param name="includebans">include reports that were bans</param>
		/// <param name="reportidmin">minimum report id</param>
		/// <returns></returns>
		Task<string> GetCheatingReports(string key, uint appid, DateTime timebegin, DateTime timeend, bool includereports, bool includebans, ulong? reportidmin = null);

		/// <summary>
		/// Get a list of appIDs associated with a WebAPI key. Type_filter can used to specify certain app types to be returned.
		/// Possible values are "game,application,tool,demo,dlc,music". When type_filter is blank or not used, all apps are returned.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="type_filter">Optional comma separated list of types to filter on</param>
		/// <returns></returns>
		Task<IEnumerable<PartnerAppListAppItem>> GetPartnerAppListForWebAPIKey(string key, string type_filter = "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">AppID of game</param>
		/// <returns></returns>
		Task<PlayersBanned> GetPlayersBanned(string key, uint appid);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="filter">Query filter string</param>
		/// <param name="limit">Limit number of servers in the response</param>
		/// <returns></returns>
		Task<ServerList> GetServerList(string key, string filter = null, uint? limit = null);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="addr">IP or IP:queryport to list</param>
		/// <returns></returns>
		Task<IList<SteamServersAtAddressItem>> GetServersAtAddress(string addr);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">AppID of game</param>
		/// <param name="buildid">BuildID</param>
		/// <param name="betakey">Beta key, required. Use public for default branch</param>
		/// <param name="description">Optional description for this build</param>
		/// <returns></returns>
		Task<string> SetAppBuildLive(string key, uint appid, uint buildid, string betakey, string description = "");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="appid">AppID of game</param>
		/// <param name="version">The installed version of the game</param>
		/// <returns></returns>
		Task<string> UpToDateCheck(uint appid, uint version);
	}
}
