using System.Collections.Generic;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	public class PlayerService : SteamWebAPIQuerier, IPlayerService {
		/// <summary>
		/// Gets information about a player's recently played games
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <param name="count">The number of games to return (0 = all)</param>
		/// <returns></returns>
		public async Task<IList<PlayerAppUsageItem>> GetRecentlyPlayedGames(string key, ulong steamid, uint count) {
			return (await this.Get<SteamAPIResponse<PlayerAppUsage>>(
				string.Format(
					"{0}/IPlayerService/GetRecentlyPlayedGames/v1/?key={1}&steamid={2}&count={3}",
					API_URL, key, steamid, count
				)
			)).response.games;
		}

		/// <summary>
		/// Return a list of games owned by the player
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <param name="include_appinfo">true if we want additional details (name, icon) about each game</param>
		/// <param name="include_played_free_games">Free games are excluded by default. If this is set, free games the user has played will be returned.</param>
		/// <returns></returns>
		public async Task<IList<PlayerAppUsageItem>> GetOwnedGames(string key, ulong steamid, bool include_appinfo, bool include_played_free_games) {
			return (await this.Get<SteamAPIResponse<PlayerAppUsage>>(
				string.Format(
					"{0}/IPlayerService/GetOwnedGames/v1/?key={1}&steamid={2}&include_appinfo={3}&include_played_free_games={4}",
					API_URL, key, steamid, include_appinfo, include_played_free_games
				)
			)).response.games;
		}

		/// <summary>
		/// Returns the Steam Level of a user
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <returns></returns>
		public async Task<uint> GetSteamLevel(string key, ulong steamid) {
			return (await this.Get<SteamAPIResponse<PlayerLevel>>(
				string.Format(
					"{0}/IPlayerService/GetSteamLevel/v1/?key={1}&steamid={2}",
					API_URL, key, steamid
				)
			)).response.player_level;
		}

		/// <summary>
		/// Gets badges that are owned by a specific user
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <returns></returns>
		public async Task<IList<Badge>> GetBadges(string key, ulong steamid) {
			return (await this.Get<SteamAPIResponse<BadgesList>>(
				string.Format(
					"{0}/IPlayerService/GetBadges/v1/?key={1}&steamid={2}",
					API_URL, key, steamid
				)
			)).response.badges;
		}

		/// <summary>
		/// Gets all the quests needed to get the specified badge, and which are completed
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <param name="badgeid">The badge we're asking about. If null, query everything we can</param>
		/// <returns></returns>
		public async Task<IList<Quest>> GetCommunityBadgeProgress(string key, ulong steamid, uint? badgeid) {
			string badgeidStr = "";
			if (badgeid != null) {
				badgeidStr = "&badgeid=" + badgeid;
			}

			return (await this.Get<SteamAPIResponse<QuestList>>(
				string.Format(
					"{0}/IPlayerService/GetCommunityBadgeProgress/v1/?key={1}&steamid={2}{3}",
					API_URL, key, steamid, badgeidStr
				)
			)).response.quests;
		}

		/// <summary>
		/// Returns valid lender SteamID if game currently played is borrowed
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <param name="appid_playing">The game player is currently playing</param>
		/// <returns></returns>
		public async Task<string> IsPlayingSharedGame(string key, ulong steamid, uint appid_playing) {
			return (await this.Get<SteamAPIResponse<SharingGame>>(
				string.Format(
					"{0}/IPlayerService/IsPlayingSharedGame/v1/?key={1}&steamid={2}&appid_playing={3}",
					API_URL, key, steamid, appid_playing
				)
			)).response.lender_steamid;
		}
	}
}
