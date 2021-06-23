using System.Threading.Tasks;

using Dysnomia.Common.WebAPIWrapper.Exceptions;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
	public class SteamUserTest : BaseTestClass {
		protected readonly ISteamUser steamAppsQuerier;

		public SteamUserTest() {
			this.steamAppsQuerier = new SteamUser();
		}

		[Fact]
		public async Task CheckAppOwnership_OK() {
			var res = await steamAppsQuerier.CheckAppOwnership(PUBLISHER_KEY, STEAMID, PUBLISHER_APPID);

			Assert.True(res != null);
		}

		[Fact]
		public async Task CheckAppOwnership_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.CheckAppOwnership(PUBLISHER_INVALID_KEY, STEAMID, PUBLISHER_APPID);
			});
		}

		[Fact]
		public async Task CheckAppOwnership_NOK_APPID() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.CheckAppOwnership(PUBLISHER_KEY, STEAMID, TF2_APPID);
			});
		}

		[Fact]
		public async Task GetAppPriceInfo_OK() {
			var res = await steamAppsQuerier.GetAppPriceInfo(PUBLISHER_KEY, STEAMID, PUBLISHER_APPID);

			Assert.True(res.Count > 0);
		}

		[Fact]
		public async Task GetAppPriceInfo_OK_Array() {
			var res = await steamAppsQuerier.GetAppPriceInfo(PUBLISHER_KEY, STEAMID, new uint[] { PUBLISHER_APPID });

			Assert.True(res.Count > 0);
		}

		[Fact]
		public async Task GetAppPriceInfo_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetAppPriceInfo(PUBLISHER_INVALID_KEY, STEAMID, PUBLISHER_APPID);
			});
		}

		[Fact]
		public async Task GetAppPriceInfo_NOK_APPID() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetAppPriceInfo(PUBLISHER_KEY, STEAMID, TF2_APPID);
			});
		}

		[Fact]
		public async Task GetDeletedSteamIDs_OK() {
			var res = await steamAppsQuerier.GetDeletedSteamIDs(PUBLISHER_KEY, 0);

			Assert.True(res.steamids.Count > 0);
		}

		[Fact]
		public async Task GetDeletedSteamIDs_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetDeletedSteamIDs(PUBLISHER_INVALID_KEY, 0);
			});
		}

		[Fact]
		public async Task GetFriendList_OK() {
			var res = await steamAppsQuerier.GetFriendList(WEBAPI_KEY, STEAMID);

			Assert.True(res.Count > 0);
		}

		[Fact]
		public async Task GetFriendList_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetFriendList(WEBAPI_INVALID_KEY, STEAMID);
			});
		}

		[Fact]
		public async Task GetPlayerBans_OK() {
			var res = await steamAppsQuerier.GetPlayerBans(WEBAPI_KEY, STEAMID);

			Assert.True(res.Count >= 0);
		}

		[Fact]
		public async Task GetPlayerBans_OK_Array() {
			var res = await steamAppsQuerier.GetPlayerBans(WEBAPI_KEY, new ulong[] { STEAMID });

			Assert.True(res.Count >= 0);
		}

		[Fact]
		public async Task GetPlayerBans_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetPlayerBans(WEBAPI_INVALID_KEY, STEAMID);
			});
		}

		[Fact]
		public async Task GetPlayerSummaries_OK() {
			var res = await steamAppsQuerier.GetPlayerSummaries(WEBAPI_KEY, STEAMID);

			Assert.True(res.Count >= 0);
		}

		[Fact]
		public async Task GetPlayerSummaries_OK_Array() {
			var res = await steamAppsQuerier.GetPlayerSummaries(WEBAPI_KEY, new ulong[] { STEAMID });

			Assert.True(res.Count >= 0);
		}

		[Fact]
		public async Task GetPlayerSummaries_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetPlayerSummaries(WEBAPI_INVALID_KEY, STEAMID);
			});
		}

		[Fact]
		public async Task GetPublisherAppOwnership_OK() {
			var res = await steamAppsQuerier.GetPublisherAppOwnership(PUBLISHER_KEY, STEAMID);

			Assert.True(res.Count >= 0);
		}

		[Fact]
		public async Task GetPublisherAppOwnership_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetPublisherAppOwnership(PUBLISHER_INVALID_KEY, STEAMID);
			});
		}

		[Fact]
		public async Task GetPublisherAppOwnershipChanges_OK() {
			var res = await steamAppsQuerier.GetPublisherAppOwnershipChanges(PUBLISHER_KEY, 0, 0);

			Assert.True(res.steamids.Count >= 0);
		}

		[Fact]
		public async Task GetPublisherAppOwnershipChanges_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetPublisherAppOwnershipChanges(PUBLISHER_INVALID_KEY, 0, 0);
			});
		}

		[Fact]
		public async Task GetUserGroupList() {
			var res = await steamAppsQuerier.GetUserGroupList(PUBLISHER_KEY, STEAMID);

			Assert.True(res.Count >= 0);
		}

		[Fact]
		public async Task GetUserGroupList_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetUserGroupList(PUBLISHER_INVALID_KEY, STEAMID);
			});
		}

		[Fact]
		public async Task ResolveVanityURL_OK() {
			var res = await steamAppsQuerier.ResolveVanityURL(WEBAPI_KEY, "elanis42");

			Assert.True(res != null);
		}

		[Fact]
		public async Task ResolveVanityURL_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.ResolveVanityURL(WEBAPI_INVALID_KEY, "elanis42");
			});
		}
	}
}
