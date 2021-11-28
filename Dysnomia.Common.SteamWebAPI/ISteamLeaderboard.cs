using Dysnomia.Common.SteamWebAPI.Enums;
using Dysnomia.Common.SteamWebAPI.Models;

using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Used to access Steam leaderboards.
	/// </summary>
	public interface ISteamLeaderboard {
		/// <summary>
		/// Get entries for a specific app leaderboard
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">appid of game</param>
		/// <param name="leaderboardid">SteamID used for friend and around user requests</param>
		/// <param name="datarequest">type of request: RequestGlobal, RequestAroundUser, RequestFriends</param>
		/// <param name="rangestart">range start or 0</param>
		/// <param name="rangeend">range end or max LB entries</param>
		/// <param name="steamid">SteamID used for friend and around user requests</param>
		/// <returns></returns>
		Task<LeaderboardEntryInformation> GetLeaderboardEntries(string key, uint appid, int leaderboardid, uint datarequest, int rangestart = 0, int rangeend = int.MaxValue, ulong? steamid = null);

		/// <summary>
		/// Returns leaderboard list for a specific app id
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">appid of game</param>
		/// <returns></returns>
		Task<LeaderBoardForGameRoot> GetLeaderboardsForGame(string key, uint appid);
		/// <summary>
		/// Set score for a specific user, appid and leaderboard
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">appid of game</param>
		/// <param name="leaderboardid">numeric ID of the target leaderboard. Can be retrieved from GetLeaderboardsForGame</param>
		/// <param name="steamid">steamID to set the score for</param>
		/// <param name="score">the score to set for this user</param>
		/// <param name="scoremethod">update method to use. Can be "KeepBest" or "ForceUpdate"</param>
		/// <returns></returns>
		Task<SetLeaderboardScore> SetLeaderboardScore(string key, uint appid, uint leaderboardid, ulong steamid, int score, ScoreMethod scoremethod);
		/// <summary>
		/// Set score for a specific user, appid and leaderboard
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">appid of game</param>
		/// <param name="leaderboardid">numeric ID of the target leaderboard. Can be retrieved from GetLeaderboardsForGame</param>
		/// <param name="steamid">steamID to set the score for</param>
		/// <param name="score">the score to set for this user</param>
		/// <param name="scoremethod">update method to use. Can be "KeepBest" or "ForceUpdate"</param>
		/// <returns></returns>
		Task<SetLeaderboardScore> SetLeaderboardScore(string key, uint appid, uint leaderboardid, ulong steamid, int score, string scoremethod);
	}
}
