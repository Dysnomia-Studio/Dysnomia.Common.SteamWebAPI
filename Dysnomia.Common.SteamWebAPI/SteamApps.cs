using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Used to access data about applications on Steam.
	/// https://partner.steamgames.com/doc/webapi/ISteamApps
	/// </summary>
	public class SteamApps : SteamWebAPIQuerier, ISteamApps {
		/// <summary>
		/// Gets all of the beta branches for the specified application.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">The App ID to get the betas of.</param>
		/// <returns></returns>
		public async Task<Dictionary<string, AppBetasBranch>> GetAppBetas(string key, uint appid) {
			return (await this.Get<SteamAPIResponse<AppBetas>>(
				string.Format(
					"{0}/ISteamApps/GetAppBetas/v1/?key={1}&appid={2}",
					API_URL, key, appid
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
					"{0}/ISteamApps/GetAppBuilds/v1/?key={1}&appid={2}&count={3}",
					API_URL, key, appid, count
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
					"{0}/ISteamApps/GetAppDepotVersions/v1/?key={1}&appid={2}",
					API_URL, key, appid
				)
			)).response.depots;
		}

		/// <summary>
		/// Gets the complete list of public apps.
		/// </summary>
		/// <returns></returns>
		public async Task<IList<AppListItem>> GetAppList() {
			return (await this.Get<AppListRoot>(API_URL + "/ISteamApps/GetAppList/v2/")).applist.apps;
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
						"{0}/ISteamApps/GetCheatingReports/v1/?key={1}&appid={2}&timebegin={3}&timeend={4}&includereports={5}&includebans={6}{7}",
						API_URL, key, appid, timebegin, timeend, includereports, includebans, reportidminStr
					)
				);

				return await response.Content.ReadAsStringAsync();
			}
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
					"{0}/ISteamApps/GetPartnerAppListForWebAPIKey/v1/?key={1}&type_filter={2}",
					API_URL, key, type_filter
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
					"{0}/ISteamApps/GetPlayersBanned/v1/?key={1}&appid={2}",
					API_URL, key, appid
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
					"{0}/ISteamApps/GetServerList/v1/?key={1}{2}{3}",
					API_URL, key, filterStr, limitStr
				)
			));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="appid">AppID of game</param>
		/// <returns></returns>
		public async Task<SDRConfig> GetSDRConfig(uint appid) {
			return (await this.Get<SDRConfig>(
				string.Format(
					"{0}/ISteamApps/GetSDRConfig/v1/?appid={1}",
					API_URL, appid
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
					"{0}/ISteamApps/GetServersAtAddress/v1/?addr={1}",
					API_URL, addr
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
						"{0}/ISteamApps/SetAppBuildLive/v1/?key={1}&=appid{2}&buildid={3}&betakey={4}&description={5}",
						API_URL, key, appid, buildid, betakey, description
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
						"{0}/ISteamApps/UpToDateCheck/v1/?appid={1}&version={2}",
						API_URL, appid, version
					)
				);

				return await response.Content.ReadAsStringAsync();
			}
		}
	}
}
