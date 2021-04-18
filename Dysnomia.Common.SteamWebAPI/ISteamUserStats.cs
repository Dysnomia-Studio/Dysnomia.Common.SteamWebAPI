using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Used to access information about users.
	/// https://partner.steamgames.com/doc/webapi/ISteamUserStats
	/// </summary>
	public interface ISteamUserStats {
		/// <summary>
		/// Retrieves the global achievement percentages for the specified app.
		/// </summary>
		/// <param name="gameid">GameID to retrieve the achievement percentages for</param>
		/// <returns></returns>
		Task<IList<GlobalAchievementPercentages>> GetGlobalAchievementPercentagesForApp(ulong gameid);

		/// <summary>
		/// Retrieves the global stats percentages for the specified app.
		/// </summary>
		/// <param name="appid">AppID that we're getting global stats for</param>
		/// <param name="names">Stats to get</param>
		/// <param name="startdate">Start date for daily totals (unix epoch timestamp)</param>
		/// <param name="enddate">End date for daily totals (unix epoch timestamp)</param>
		/// <returns></returns>
		Task<GlobalStats> GetGlobalStatsForGame(uint appid, string[] names, uint? startdate = null, uint? enddate = null);

		/// <summary>
		/// Retrieves the global stats percentages for the specified app.
		/// </summary>
		/// <param name="appid">AppID that we're getting global stats for</param>
		/// <param name="names">Stats to get</param>
		/// <param name="startdate">Start date for daily totals</param>
		/// <param name="enddate">End date for daily totals</param>
		/// <returns></returns>
		Task<GlobalStats> GetGlobalStatsForGame(uint appid, string[] names, DateTime startdate, DateTime enddate);

		/// <summary>
		/// Gets the total number of players currently active in the specified app on Steam.
		/// 
		/// Note that this will not return players that are playing while not connected to Steam.
		/// </summary>
		/// <param name="appid">AppID that we're getting user count for</param>
		/// <returns></returns>
		Task<ulong> GetNumberOfCurrentPlayers(uint appid);

		/// <summary>
		/// Gets the list of achievements the specified user has unlocked in an app.
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appid">AppID to get achievements for</param>
		/// <param name="l">(Optional) Language to return strings for (english, french, etc.). null = no translation</param>
		/// <returns></returns>
		Task<PlayerAchievements> GetPlayerAchievements(string key, ulong steamid, uint appid, string l = null);

		/// <summary>
		/// Gets the complete list of stats and achievements for the specified game.
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="appid">appid of game</param>
		/// <param name="l">(Optional) Localized language to return (english, french, etc.). null = no translation</param>
		/// <returns></returns>
		Task<SchemaForGame> GetSchemaForGame(string key, uint appid, string l = null);

		/// <summary>
		/// Gets the list of stats that the specified user has set in an app.
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appid">appid of game</param>
		/// <returns></returns>
		Task<UserStatsForGame> GetUserStatsForGame(string key, ulong steamid, uint appid);

		/// <summary>
		/// Sets a stat for the specified user for the game.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appid">appid of game</param>
		/// <param name="values">Dictionnary listing "Stat name" => "Value"</param>
		/// <returns></returns>
		Task<string> SetUserStatsForGame(string key, ulong steamid, uint appid, Dictionary<string, uint> values);
	}
}
