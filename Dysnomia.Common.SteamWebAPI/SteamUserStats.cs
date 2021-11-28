using Dysnomia.Common.SteamWebAPI.Models;

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Used to access information about users.
	/// https://partner.steamgames.com/doc/webapi/ISteamUserStats
	/// </summary>
	public class SteamUserStats : SteamWebAPIQuerier, ISteamUserStats {
		public SteamUserStats(IHttpClientFactory clientFactory) : base(clientFactory) {
		}

		/// <summary>
		/// Retrieves the global achievement percentages for the specified app.
		/// </summary>
		/// <param name="gameid">GameID to retrieve the achievement percentages for</param>
		/// <returns></returns>
		public async Task<IList<GlobalAchievementPercentages>> GetGlobalAchievementPercentagesForApp(ulong gameid) {
			return (await this.Get<GlobalAchievementPercentagesRoot>(
				string.Format(
					"{0}/ISteamUserStats/GetGlobalAchievementPercentagesForApp/v2/?gameid={1}",
					API_URL, gameid
				)
			)).achievementpercentages.achievements;
		}

		/// <summary>
		/// Retrieves the global stats percentages for the specified app.
		/// </summary>
		/// <param name="appid">AppID that we're getting global stats for</param>
		/// <param name="names">Stats to get</param>
		/// <param name="startdate">Start date for daily totals (unix epoch timestamp)</param>
		/// <param name="enddate">End date for daily totals (unix epoch timestamp)</param>
		/// <returns></returns>
		public async Task<GlobalStats> GetGlobalStatsForGame(uint appid, string[] names, uint? startdate = null, uint? enddate = null) {
			string namesStr = "&count=" + names.Length;
			for (var i = 0; i < names.Length; i++) {
				namesStr += "&name[" + i + "]=" + names[i];
			}

			string startdateStr = "";
			if (startdate != null) {
				startdateStr = "&startdate=" + startdate.ToString();
			}

			string enddateStr = "";
			if (enddate != null) {
				enddateStr = "&enddate=" + enddate.ToString();
			}

			return (await this.Get<SteamAPIResponse<GlobalStats>>(
				string.Format(
					"{0}/ISteamUserStats/GetGlobalStatsForGame/v0001/?format=json&appid={1}{2}{3}{4}",
					API_URL, appid, namesStr, startdateStr, enddateStr
				)
			)).response;
		}

		/// <summary>
		/// Retrieves the global stats percentages for the specified app.
		/// </summary>
		/// <param name="appid">AppID that we're getting global stats for</param>
		/// <param name="names">Stats to get</param>
		/// <param name="startdate">Start date for daily totals</param>
		/// <param name="enddate">End date for daily totals</param>
		/// <returns></returns>
		public async Task<GlobalStats> GetGlobalStatsForGame(uint appid, string[] names, DateTime startdate, DateTime enddate) {
			return await GetGlobalStatsForGame(appid, names, (uint)((DateTimeOffset)startdate).ToUnixTimeSeconds(), (uint)((DateTimeOffset)enddate).ToUnixTimeSeconds());
		}

		/// <summary>
		/// Gets the total number of players currently active in the specified app on Steam.
		/// 
		/// Note that this will not return players that are playing while not connected to Steam.
		/// </summary>
		/// <param name="appid">AppID that we're getting user count for</param>
		/// <returns></returns>
		public async Task<ulong> GetNumberOfCurrentPlayers(uint appid) {
			return (await this.Get<SteamAPIResponse<NumberOfCurrentPlayers>>(
				string.Format(
					"{0}/ISteamUserStats/GetNumberOfCurrentPlayers/v1/?appid={1}",
					API_URL, appid
				)
			)).response.player_count;
		}

		/// <summary>
		/// Gets the list of achievements the specified user has unlocked in an app.
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appid">AppID to get achievements for</param>
		/// <param name="l">(Optional) Language to return strings for (english, french, etc.). null = no translation</param>
		/// <returns></returns>
		public async Task<PlayerAchievements> GetPlayerAchievements(string key, ulong steamid, uint appid, string l = null) {
			string lStr = "";
			if (l != null) {
				lStr = "&l=" + l;
			}

			return (await this.Get<PlayerAchievementsRoot>(
				string.Format(
					"{0}/ISteamUserStats/GetPlayerAchievements/v1/?key={1}&steamid={2}&appid={3}{4}",
					API_URL, key, steamid, appid, lStr
				)
			)).playerstats;
		}

		/// <summary>
		/// Gets the complete list of stats and achievements for the specified game.
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="appid">appid of game</param>
		/// <param name="l">(Optional) Localized language to return (english, french, etc.). null = no translation</param>
		/// <returns></returns>
		public async Task<SchemaForGame> GetSchemaForGame(string key, uint appid, string l = null) {
			string lStr = "";
			if (l != null) {
				lStr = "&l=" + l;
			}

			return (await this.Get<SchemaForGameRoot>(
				string.Format(
					"{0}/ISteamUserStats/GetSchemaForGame/v2/?key={1}&appid={2}{3}",
					API_URL, key, appid, lStr
				)
			)).game;
		}

		/// <summary>
		/// Gets the list of stats that the specified user has set in an app.
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appid">appid of game</param>
		/// <returns></returns>
		public async Task<UserStatsForGame> GetUserStatsForGame(string key, ulong steamid, uint appid) {
			return (await this.Get<UserStatsForGameRoot>(
				string.Format(
					"{0}/ISteamUserStats/GetUserStatsForGame/v2/?key={1}&steamid={2}&appid={3}",
					API_URL, key, steamid, appid
				)
			)).playerstats;
		}

		/// <summary>
		/// Sets a stat for the specified user for the game.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appid">appid of game</param>
		/// <param name="values">Dictionnary listing "Stat name" => "Value"</param>
		/// <returns></returns>
		public async Task<string> SetUserStatsForGame(string key, ulong steamid, uint appid, Dictionary<string, uint> values) {
			string valuesStr = "&count=" + values.Count;
			int i = 0;
			foreach (var item in values) {
				valuesStr += "&name[" + i + "]=" + item.Key;
				valuesStr += "&value[" + i + "]=" + item.Value;
				i++;
			}

			return await this.PostString(
				string.Format(
					"{0}/ISteamUserStats/SetUserStatsForGame/v1/?key={1}&=steamid{2}&appid={3}{4}",
					API_URL, key, steamid, appid, valuesStr
				),
				new StringContent("")
			);
		}
	}
}
