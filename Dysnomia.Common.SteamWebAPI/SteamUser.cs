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
	public class SteamUser : SteamWebAPIQuerier, ISteamUser {
		/// <summary>
		/// Checks if the specified user owns the app.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appid">AppID to check for ownership</param>
		/// <returns></returns>
		public async Task<AppOwnership> CheckAppOwnership(string key, ulong steamid, uint appid) {
			return (await this.Get<AppOwershipRoot>(
				string.Format(
					"{0}/ISteamUser/CheckAppOwnership/v2/?key={1}&steamid={2}&appid={3}",
					API_URL, key, steamid, appid
				)
			)).appownership;
		}

		private async Task<IDictionary<string, AppPriceInfo>> GetAppPriceInfo(string key, ulong steamid, string appids) {
			return (await this.Get<AppPriceInfoRoot>(
				string.Format(
					"{0}/ISteamUser/GetAppPriceInfo/v1/?key={1}&steamid={2}&appids={3}",
					API_URL, key, steamid, appids
				)
			)).price_info;
		}

		/// <summary>
		/// Get price info about one or mutiple apps
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appid">App id</param>
		/// <returns></returns>
		public async Task<IDictionary<string, AppPriceInfo>> GetAppPriceInfo(string key, ulong steamid, uint appid) {
			return await GetAppPriceInfo(key, steamid, appid.ToString());
		}

		/// <summary>
		/// Get price info about one or mutiple apps
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="appids">App ids (max: 100)</param>
		/// <returns></returns>
		public async Task<IDictionary<string, AppPriceInfo>> GetAppPriceInfo(string key, ulong steamid, uint[] appids) {
			return await GetAppPriceInfo(key, steamid, string.Join(",", appids));
		}

		/// <summary>
		/// You can use GetDeletedSteamIDs to retrieve a list of deleted accounts that owned your game(s) before deletion. This API was created to allow for the deletion of user related data for GDPR and other personal information related purposes.
		///
		/// The provided Steamworks Publisher Key is used for both authentication and to generate the list of appids to check against.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="rowversion">An unsigned 64-bit value used to page through deleted accounts. Pass 0 when calling this API for the first time, then pass the value returned from the previous call for each additional request. This value will need to be stored on your server for future calls.</param>
		/// <returns></returns>
		public async Task<DeletedSteamIDsResponse> GetDeletedSteamIDs(string key, uint rowversion) {
			return (await this.Get<SteamAPIResponse<DeletedSteamIDsResponse>>(
				string.Format(
					"{0}/ISteamUser/GetDeletedSteamIDs/v1/?key={1}&rowversion={2}",
					API_URL, key, rowversion
				)
			)).response;
		}

		/// <summary>
		/// Gets friend list of a specific user by its steamid
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="relationship">relationship type (ex: friend)</param>
		/// <returns></returns>
		public async Task<IList<Friend>> GetFriendList(string key, ulong steamid, string relationship = "friend") {
			return (await this.Get<FriendListRoot>(
				string.Format(
					"{0}/ISteamUser/GetFriendList/v1/?key={1}&steamid={2}&relationship={3}",
					API_URL, key, steamid, relationship
				)
			)).friendslist.friends;
		}

		private async Task<IList<PlayerBan>> GetPlayerBans(string key, string steamids) {
			return (await this.Get<PlayerBansRoot>(
				string.Format(
					"{0}/ISteamUser/GetPlayerBans/v1/?key={1}&steamids={2}",
					API_URL, key, steamids
				)
			)).players;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">Target Steam ID</param>
		/// <returns></returns>
		public async Task<IList<PlayerBan>> GetPlayerBans(string key, ulong steamid) {
			return await GetPlayerBans(key, steamid.ToString());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamids">Target Steam IDs</param>
		/// <returns></returns>
		public async Task<IList<PlayerBan>> GetPlayerBans(string key, ulong[] steamids) {
			return await GetPlayerBans(key, string.Join(",", steamids));
		}

		private async Task<IList<PlayerSummary>> GetPlayerSummaries(string key, string steamids) {
			return (await this.Get<SteamAPIResponse<PlayerSummaryRoot>>(
				string.Format(
					"{0}/ISteamUser/GetPlayerSummaries/v1/?key={1}&steamids={2}",
					API_URL, key, steamids
				)
			)).response.players.player;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamid">Target Steam ID</param>
		/// <returns></returns>
		public async Task<IList<PlayerSummary>> GetPlayerSummaries(string key, ulong steamid) {
			return await GetPlayerSummaries(key, steamid.ToString());
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="steamids">Target Steam IDs</param>
		/// <returns></returns>
		public async Task<IList<PlayerSummary>> GetPlayerSummaries(string key, ulong[] steamids) {
			return await GetPlayerSummaries(key, string.Join(",", steamids));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <returns></returns>
		public async Task<IList<PublisherAppOwnership>> GetPublisherAppOwnership(string key, ulong steamid) {
			return (await this.Get<PublisherAppOwnershipRoot>(
				string.Format(
					"{0}/ISteamUser/GetPublisherAppOwnership/v3/?key={1}&steamid={2}",
					API_URL, key, steamid
				)
			)).appownership.apps;
		}

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
		public async Task<AppOwnershipChanges> GetPublisherAppOwnershipChanges(string key, ulong packagerowversion, ulong cdkeyrowversion) {
			return (await this.Get<AppOwnershipChangesRoot>(
				string.Format(
					"{0}/ISteamUser/GetPublisherAppOwnershipChanges/v1/?key={1}&packagerowversion={2}&cdkeyrowversion={3}",
					API_URL, key, packagerowversion, cdkeyrowversion
				)
			)).ownershipchanges;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <returns></returns>
		public async Task<IList<Group>> GetUserGroupList(string key, ulong steamid) {
			return (await this.Get<SteamAPIResponse<GroupRoot>>(
				string.Format(
					"{0}/ISteamUser/GetUserGroupList/v1/?key={1}&steamid={2}",
					API_URL, key, steamid
				)
			)).response.groups;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="packageid">PackageID to grant</param>
		/// <param name="ipaddress">ip address of user in string format (xxx.xxx.xxx.xxx).</param>
		/// <param name="thirdpartykey">Optionally associate third party key during grant. 'thirdpartyappid' will have to be set.</param>
		/// <param name="thirdpartyappid">Has to be set if 'thirdpartykey' is set. The appid associated with the 'thirdpartykey'.</param>
		/// <returns></returns>
		public async Task<string> GrantPackage(string key, ulong steamid, uint packageid, string ipaddress, string thirdpartykey, uint? thirdpartyappid) {
			var ipaddressStr = "";
			if (!string.IsNullOrWhiteSpace(ipaddress)) {
				ipaddressStr = "&ipaddress=" + ipaddress;
			}

			var thirdpartykeyStr = "";
			if (!string.IsNullOrWhiteSpace(thirdpartykey)) {
				thirdpartykeyStr = "&thirdpartykey=" + thirdpartykey;
			}

			var thirdpartyappidStr = "";
			if (thirdpartyappid != null) {
				thirdpartyappidStr = "&thirdpartyappid=" + thirdpartyappid;
			}

			return (await this.PostString(
				string.Format(
					"{0}/ISteamUser/GrantPackage/v2/?key={1}&steamid={2}&packageid={3}{4}{5}{6}",
					API_URL, key, steamid, packageid, ipaddressStr, thirdpartykeyStr, thirdpartyappidStr
				),
				null
			));
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="packageid">PackageID to grant</param>
		/// <returns></returns>
		public async Task<string> GrantPackage(string key, ulong steamid, uint packageid) {
			return await GrantPackage(key, steamid, packageid, null, null, null);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API user authentication key.</param>
		/// <param name="vanityurl">The vanity URL to get a SteamID for</param>
		/// <param name="url_type">The type of vanity URL. 1 (default): Individual profile, 2: Group, 3: Official game group</param>
		/// <returns></returns>
		public async Task<ResolveVanityURLResponse> ResolveVanityURL(string key, string vanityurl, uint url_type = 1) {
			return (await this.Get<SteamAPIResponse<ResolveVanityURLResponse>>(
				string.Format(
					"{0}/ISteamUser/ResolveVanityURL/v1/?key={1}&vanityurl={2}&url_type={3}",
					API_URL, key, vanityurl, url_type
				)
			)).response;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">SteamID of user</param>
		/// <param name="packageid">PackageID to grant</param>
		/// <param name="revokereason">Reason for why to revoke</param>
		/// <returns></returns>
		public async Task<string> RevokePackage(string key, ulong steamid, uint packageid, string revokereason) {
			return (await this.PostString(
				string.Format(
					"{0}/ISteamUser/RevokePackage/v2/?key={1}&steamid={2}&packageid={3}&revokereason={4}",
					API_URL, key, steamid, packageid, revokereason
				),
				null
			));
		}
	}
}
