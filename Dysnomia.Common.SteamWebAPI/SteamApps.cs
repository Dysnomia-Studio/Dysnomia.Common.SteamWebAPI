using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	public class SteamApps : SteamWebAPIQuerier {
		/// <summary>
		/// Gets all of the beta branches for the specified application.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">The App ID to get the betas of.</param>
		/// <returns></returns>
		public async Task<Dictionary<string, AppBetasBranch>> GetAppBetas(string key, uint appid) {
			return (await this.Get<SteamAPIResponse<AppBetas>>(
				string.Format(
					"https://partner.steam-api.com/ISteamApps/GetAppBetas/v1/?key={0}&appid={1}",
					key, appid
				)
			)).response.betas;
		}

		/// <summary>
		/// Gets an applications build history.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">The App ID to get the betas of.</param>
		/// <param name="count">The number of builds to retrieve, the default is 10.</param>
		/// <returns></returns>
		public async Task<Dictionary<string, AppBuild>> GetAppBuilds(string key, uint appid, uint count = 10) {
			return (await this.Get<SteamAPIResponse<AppBuilds>>(
				string.Format(
					"https://partner.steam-api.com/ISteamApps/GetAppBuilds/v1/?key={0}&appid={1}&count={2}",
					key, appid, count
				)
			)).response.builds;
		}

		/// <summary>
		/// Gets all the versions of all the depots for the specified application.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">The App ID to get the depot versions for.</param>
		/// <returns></returns>
		public async Task<Dictionary<string, object>> GetAppDepotVersions(string key, uint appid) {
			return (await this.Get<SteamAPIResponse<AppDepotVersions>>(
				string.Format(
					"https://partner.steam-api.com/ISteamApps/GetAppDepotVersions/v1/?key={0}&appid={1}",
					key, appid
				)
			)).response.depots;
		}

		/// <summary>
		/// Gets the complete list of public apps.
		/// </summary>
		/// <returns></returns>
		public async Task<IList<AppListItem>> GetAppList() {
			return (await this.Get<AppListRoot>("https://api.steampowered.com/ISteamApps/GetAppList/v2/")).applist.apps;
		}

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
		public async Task<string> GetCheatingReports(string key, uint appid, uint timebegin, uint timeend, bool includereports, bool includebans, ulong? reportidmin = null) {
			using (HttpClient httpClient = new HttpClient()) {
				// TODO: re-test later to format this method as the other ones. When I tried, I got an internal server error :/

				string reportidminStr = "";
				if (reportidmin != null) {
					reportidminStr = "&reportidmin=" + reportidmin;
				}

				var response = await httpClient.GetAsync(
					string.Format(
						"https://partner.steam-api.com/ISteamApps/GetCheatingReports/v1/?key={0}&appid={1}&timebegin={2}&timeend={3}&includereports={4}&includebans={5}{6}",
						key, appid, timebegin, timeend, includereports, includebans, reportidminStr
					)
				);

				return await response.Content.ReadAsStringAsync();
			}
		}


		public async Task<string> GetCheatingReports(string key, uint appid, DateTime timebegin, DateTime timeend, bool includereports, bool includebans, ulong? reportidmin = null) {
			return await GetCheatingReports(key, appid, (uint)((DateTimeOffset)timebegin).ToUnixTimeSeconds(), (uint)((DateTimeOffset)timeend).ToUnixTimeSeconds(), includereports, includebans, reportidmin);
		}

		/// <summary>
		/// Get a list of appIDs associated with a WebAPI key. Type_filter can used to specify certain app types to be returned.
		/// Possible values are "game,application,tool,demo,dlc,music". When type_filter is blank or not used, all apps are returned.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="type_filter">Optional comma separated list of types to filter on</param>
		/// <returns></returns>
		public async Task<IEnumerable<PartnerAppListAppItem>> GetPartnerAppListForWebAPIKey(string key, string type_filter = "") {
			return (await this.Get<PartnerAppListRoot>(
				string.Format(
					"https://partner.steam-api.com/ISteamApps/GetPartnerAppListForWebAPIKey/v1/?key={0}&type_filter={1}",
					key, type_filter
				)
			)).applist.apps.app.Where((val) => val != null); // Where() is needed because Steam returns [null] when filter is invalid ...
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">AppID of game</param>
		/// <returns></returns>
		public async Task<PlayersBanned> GetPlayersBanned(string key, uint appid) {
			return (await this.Get<PlayersBanned>(
				string.Format(
					"https://partner.steam-api.com/ISteamApps/GetPlayersBanned/v1/?key={0}&appid={1}",
					key, appid
				)
			));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="filter">Query filter string</param>
		/// <param name="limit">Limit number of servers in the response</param>
		/// <returns></returns>
		public async Task<ServerList> GetServerList(string key, string filter = null, uint? limit = null) {
			string filterStr = "";
			if (filter != null) {
				filterStr = "&filter=" + filter;
			}

			string limitStr = "";
			if (limit != null) {
				limitStr = "&limit=" + limit;
			}

			return (await this.Get<ServerList>(
				string.Format(
					"https://partner.steam-api.com/ISteamApps/GetServerList/v1/?key={0}{1}{2}",
					key, filterStr, limitStr
				)
			));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="addr">IP or IP:queryport to list</param>
		/// <returns></returns>
		public async Task<IList<SteamServersAtAddressItem>> GetServersAtAddress(string addr) {
			return (await this.Get<SteamAPIResponse<SteamServersAtAddress>>(
				string.Format(
					"https://api.steampowered.com/ISteamApps/GetServersAtAddress/v1/?addr={0}",
					addr
				)
			)).response.servers;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">AppID of game</param>
		/// <param name="buildid">BuildID</param>
		/// <param name="betakey">Beta key, required. Use public for default branch</param>
		/// <param name="description">Optional description for this build</param>
		/// <returns></returns>
		public async Task<string> SetAppBuildLive(string key, uint appid, uint buildid, string betakey, string description = "") {
			using (HttpClient httpClient = new HttpClient()) {

				var response = await httpClient.PostAsync(
					string.Format(
						"https://partner.steam-api.com/ISteamApps/SetAppBuildLive/v1/?key={0}&=appid{1}&buildid={2}&betakey={3}&description={4}",
						key, appid, buildid, betakey, description
					),
					new StringContent("")
				);

				return await response.Content.ReadAsStringAsync();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="appid">AppID of game</param>
		/// <param name="version">The installed version of the game</param>
		/// <returns></returns>
		public async Task<string> UpToDateCheck(uint appid, uint version) {
			using (HttpClient httpClient = new HttpClient()) {

				var response = await httpClient.GetAsync(
					string.Format(
						"https://api.steampowered.com/ISteamApps/UpToDateCheck/v1/?appid={0}&version={1}",
						appid, version
					)
				);

				return await response.Content.ReadAsStringAsync();
			}
		}
	}
}
