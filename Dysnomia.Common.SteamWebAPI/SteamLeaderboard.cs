using Dysnomia.Common.SteamWebAPI.Enums;
using Dysnomia.Common.SteamWebAPI.Models;

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI
{
    /// <summary>
    /// Used to access Steam leaderboards.
    /// </summary>
    public class SteamLeaderboard : SteamWebAPIQuerier, ISteamLeaderboard
    {
        /// <summary>
        /// Returns leaderboard list for a specific app id
        /// </summary>
        /// <param name="key">Steamworks Web API publisher authentication key.</param>
        /// <param name="appid">appid of game</param>
        /// <returns></returns>
        public async Task<LeaderBoardForGameRoot> GetLeaderboardsForGame(string key, uint appid)
        {
            return (await Get<SteamAPIResponse<LeaderBoardForGameRoot>>(
                    string.Format(
                        "{0}/ISteamLeaderboards/GetLeaderboardsForGame/v2/?key={1}&appid={2}",
                        API_URL, key, appid
                    )
            )).response;
        }

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
        public async Task<SetLeaderboardScore> SetLeaderboardScore(string key, uint appid, uint leaderboardid, ulong steamid, int score, ScoreMethod scoremethod)
        {
            return await SetLeaderboardScore(key, appid, leaderboardid, steamid, score, scoremethod.ToString());
        }
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
        public async Task<SetLeaderboardScore> SetLeaderboardScore(string key, uint appid, uint leaderboardid, ulong steamid, int score, string scoremethod)
        {
            HttpContent content = new FormUrlEncodedContent(new[]
{
                new KeyValuePair<string, string>("key", key),
                new KeyValuePair<string, string>("appid", appid.ToString()),
                new KeyValuePair<string, string>("leaderboardid", leaderboardid.ToString()),
                new KeyValuePair<string, string>("steamid", steamid.ToString()),
                new KeyValuePair<string, string>("score", score.ToString()),
                new KeyValuePair<string, string>("scoremethod", scoremethod),
            });

            return (await Post<SetLeaderboardScoreResult>(
                string.Format(
                    "{0}/ISteamLeaderboards/SetLeaderboardScore/v1/",
                    API_URL
                ), content
            )).result;
        }
    }
}
