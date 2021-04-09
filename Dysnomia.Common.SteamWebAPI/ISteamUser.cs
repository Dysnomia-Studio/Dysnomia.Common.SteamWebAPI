using System.Collections.Generic;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Used to access information and interact with users.
	/// See IPlayerService for additional methods.
	/// 
	/// https://partner.steamgames.com/doc/webapi/ISteamUser
	/// </summary>
	public interface ISteamUser {
		/// <summary>
		/// Checks if the specified user owns the app.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appid">AppID to check for ownership</param>
		/// <returns></returns>
		Task<AppOwnership> CheckAppOwnership(string key, ulong steamid, uint appid);

		/// <summary>
		/// Get price info about one or mutiple apps
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appid">App id</param>
		/// <returns></returns>
		Task<IDictionary<string, AppPriceInfo>> GetAppPriceInfo(string key, ulong steamid, uint appid);

		/// <summary>
		/// Get price info about one or mutiple apps
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appids">App ids (max: 100)</param>
		/// <returns></returns>
		Task<IDictionary<string, AppPriceInfo>> GetAppPriceInfo(string key, ulong steamid, uint[] appids);

		/// <summary>
		/// You can use GetDeletedSteamIDs to retrieve a list of deleted accounts that owned your game(s) before deletion. This API was created to allow for the deletion of user related data for GDPR and other personal information related purposes.
		///
		/// The provided Steamworks Publisher Key is used for both authentication and to generate the list of appids to check against.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="rowversion">An unsigned 64-bit value used to page through deleted accounts. Pass 0 when calling this API for the first time, then pass the value returned from the previous call for each additional request. This value will need to be stored on your server for future calls.</param>
		/// <returns></returns>
		Task<DeletedSteamIDsResponse> GetDeletedSteamIDs(string key, uint rowversion);

		/// <summary>
		/// Gets friend list of a specific user by its steamid
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="relationship">relationship type (ex: friend)</param>
		/// <returns></returns>
		Task<IList<Friend>> GetFriendList(string key, ulong steamid, string relationship = "friend");

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">Target Steam ID</param>
		/// <returns></returns>
		Task<IList<PlayerBan>> GetPlayerBans(string key, ulong steamid);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamids">Target Steam IDs</param>
		/// <returns></returns>
		Task<IList<PlayerBan>> GetPlayerBans(string key, ulong[] steamids);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">Target Steam ID</param>
		/// <returns></returns>
		Task<IList<PlayerSummary>> GetPlayerSummaries(string key, ulong steamid);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamids">Target Steam IDs</param>
		/// <returns></returns>
		Task<IList<PlayerSummary>> GetPlayerSummaries(string key, ulong[] steamids);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <returns></returns>
		Task<IList<PublisherAppOwnership>> GetPublisherAppOwnership(string key, ulong steamid);

		/// <summary>
		/// This method can be used to determine what SteamIDs have ownership changes starting from a particular package or key row version number. From the list of SteamIDs returned, a call to GetPublisherAppOwnership can then return the associated ownership data for the applications in the group associated with the key passed in. A partner may wish to track this data in conjunction with linked Steam Accounts to better understand the state of product ownership on Steam.
		/// 
		/// To begin, make a call to GetPublisherAppOwnershipChanges passing in packagerowversion and cdkeyrowversion with the values of 0 (zero). The response from the call will look something like this:
		/// 
		/// After this first call returns:
		/// 1) Make a call to GetPublisherAppOwnership for each SteamID to get the actual ownership per AppID.Store or use that data as needed.
		/// 2) Once all the SteamIDs have been processed, check the value of moredata.If it is true, make a new call to GetPublisherAppOwnershipChanges passing in the packagerowversion and cdkeyrowversion as returned from the previous call to GetPublisherAppOwnershipChanges.
		/// 3) Repeat Step 1 and 2 until moredata returns false.
		/// 4) Store the final packagerowversion and cdkeyrowversion values for use in future GetPublisherAppOwnershipChanges calls(e.g. 24 hours later) instead of starting at 0 (zero) again.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="packagerowversion">The unsigned 64-bit row version to read package changes from. The row version of data read up to will be returned for use in future calls.</param>
		/// <param name="cdkeyrowversion">The unsigned 64-bit row version to read CD Key changes from. The row version of data read up to will be returned for use in future calls.</param>
		/// <returns></returns>
		Task<AppOwnershipChanges> GetPublisherAppOwnershipChanges(string key, ulong packagerowversion, ulong cdkeyrowversion);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <returns></returns>
		Task<IList<Group>> GetUserGroupList(string key, ulong steamid);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="vanityurl">The vanity URL to get a SteamID for</param>
		/// <param name="url_type">The type of vanity URL. 1 (default): Individual profile, 2: Group, 3: Official game group</param>
		/// <returns></returns>
		Task<ResolveVanityURLResponse> ResolveVanityURL(string key, string vanityurl, uint url_type = 1);
	}
}
