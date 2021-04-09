using System.Collections.Generic;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Provides additional methods for interacting with Steam Users.
	/// See ISteamUser for the primary interface.
	/// 
	/// https://partner.steamgames.com/doc/webapi/IPlayerService
	/// </summary>
	public interface IPlayerService {
		/// <summary>
		/// Gets information about a player's recently played games
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <param name="count">The number of games to return (0 = all)</param>
		/// <returns></returns>
		Task<IList<PlayerAppUsageItem>> GetRecentlyPlayedGames(string key, ulong steamid, uint count);

		/// <summary>
		/// Return a list of games owned by the player
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <param name="include_appinfo">true if we want additional details (name, icon) about each game</param>
		/// <param name="include_played_free_games">Free games are excluded by default. If this is set, free games the user has played will be returned.</param>
		/// <returns></returns>
		Task<IList<PlayerAppUsageItem>> GetOwnedGames(string key, ulong steamid, bool include_appinfo, bool include_played_free_games);

		/// <summary>
		/// Returns the Steam Level of a user
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <returns></returns>
		Task<uint> GetSteamLevel(string key, ulong steamid);

		/// <summary>
		/// Gets badges that are owned by a specific user
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <returns></returns>
		Task<IList<Badge>> GetBadges(string key, ulong steamid);

		/// <summary>
		/// Gets all the quests needed to get the specified badge, and which are completed
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <param name="badgeid">The badge we're asking about</param>
		/// <returns></returns>
		Task<IList<Quest>> GetCommunityBadgeProgress(string key, ulong steamid, uint? badgeid);

		/// <summary>
		/// Returns valid lender SteamID if game currently played is borrowed
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">The player we're asking about</param>
		/// <param name="appid_playing">The game player is currently playing</param>
		/// <returns></returns>
		Task<string> IsPlayingSharedGame(string key, ulong steamid, uint appid_playing);
	}
}
