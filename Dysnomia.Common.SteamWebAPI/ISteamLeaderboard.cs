using Dysnomia.Common.SteamWebAPI.Enums;
using Dysnomia.Common.SteamWebAPI.Models;

using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI
{
    /// <summary>
    /// Used to access Steam leaderboards.
    /// </summary>
    public interface ISteamLeaderboard
    {
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
