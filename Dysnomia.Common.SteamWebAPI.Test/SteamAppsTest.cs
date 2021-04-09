using System;
using System.Linq;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Exceptions;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
	public class SteamAppsTest : BaseTestClass {
		protected readonly SteamApps steamAppsQuerier;

		public SteamAppsTest() {
			this.steamAppsQuerier = new SteamApps();
		}

		[Fact]
		public async Task GetAppBetas_OK() {
			var res = await steamAppsQuerier.GetAppBetas(PUBLISHER_KEY, PUBLISHER_APPID);

			Assert.True(res.Count > 0, res.Count.ToString());
		}

		[Fact]
		public async Task GetAppBetas_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetAppBetas(PUBLISHER_INVALID_KEY, PUBLISHER_APPID);
			});
		}

		[Fact]
		public async Task GetAppBetas_NOK_APPID() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetAppBetas(PUBLISHER_KEY, TF2_APPID);
			});
		}

		[Fact]
		public async Task GetAppBuilds_OK() {
			var res = await steamAppsQuerier.GetAppBuilds(PUBLISHER_KEY, PUBLISHER_APPID);

			Assert.True(res.Count > 0);
			Assert.True(res.First().Value.depots.Count <= 10);
		}

		[Fact]
		public async Task GetAppBuilds_OK_With_Count() {
			var res = await steamAppsQuerier.GetAppBuilds(PUBLISHER_KEY, PUBLISHER_APPID, 5);

			Assert.True(res.Count > 0);
			Assert.True(res.First().Value.depots.Count <= 5);
		}

		[Fact]
		public async Task GetAppBuilds_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetAppBuilds(PUBLISHER_INVALID_KEY, PUBLISHER_APPID);
			});
		}

		[Fact]
		public async Task GetAppBuilds_NOK_APPID() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetAppBuilds(PUBLISHER_KEY, TF2_APPID);
			});
		}

		[Fact]
		public async Task GetAppDepotVersions_OK() {
			var res = await steamAppsQuerier.GetAppDepotVersions(PUBLISHER_KEY, PUBLISHER_APPID);

			Assert.True(res.Count > 0);
		}

		[Fact]
		public async Task GetAppDepotVersions_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetAppDepotVersions(PUBLISHER_INVALID_KEY, PUBLISHER_APPID);
			});
		}

		[Fact]
		public async Task GetAppDepotVersions_NOK_APPID() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetAppDepotVersions(PUBLISHER_KEY, TF2_APPID);
			});
		}

		[Fact]
		public async Task GetAppList() {
			var res = await steamAppsQuerier.GetAppList();

			Assert.True(res.Count > 0);
		}

		[Fact]
		public async Task GetCheatingReports_OK() {
			await steamAppsQuerier.GetCheatingReports(PUBLISHER_KEY, PUBLISHER_APPID, new DateTime(2020, 01, 01), DateTime.Now, true, true);
		}

		[Fact(Skip = "Currently getting Internal Server Error")]
		public async Task GetCheatingReports_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetCheatingReports(PUBLISHER_INVALID_KEY, PUBLISHER_APPID, new DateTime(2020, 01, 01), DateTime.Now, true, true);
			});
		}

		[Fact]
		public async Task GetPartnerAppListForWebAPIKey_OK_NoFilter() {
			var res = (await steamAppsQuerier.GetPartnerAppListForWebAPIKey(PUBLISHER_KEY)).ToList();

			Assert.True(res.Count >= 0);
		}

		[Fact]
		public async Task GetPartnerAppListForWebAPIKey_OK_ValidFilter() {
			var res = (await steamAppsQuerier.GetPartnerAppListForWebAPIKey(PUBLISHER_KEY, "demo")).ToList();

			Assert.True(res.Count >= 0);
		}

		[Fact]
		public async Task GetPartnerAppListForWebAPIKey_OK_InvalidFilter() {
			var res = (await steamAppsQuerier.GetPartnerAppListForWebAPIKey(PUBLISHER_KEY, "invalid")).ToList();

			Assert.True(res.Count == 0);
		}

		[Fact]
		public async Task GetPartnerAppListForWebAPIKey_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetPartnerAppListForWebAPIKey(PUBLISHER_INVALID_KEY);
			});
		}

		[Fact]
		public async Task GetPlayersBanned_OK() {
			var res = await steamAppsQuerier.GetPlayersBanned(PUBLISHER_KEY, PUBLISHER_APPID);

			Assert.True(res.accounts.Count >= 0);
		}

		[Fact]
		public async Task GetPlayersBanned_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetPlayersBanned(PUBLISHER_INVALID_KEY, PUBLISHER_APPID);
			});
		}

		[Fact]
		public async Task GetPlayersBanned_NOK_APPID() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetPlayersBanned(PUBLISHER_KEY, TF2_APPID);
			});
		}

		[Fact(Skip = "Currently getting Internal Server Error")]
		public async Task GetServerList_OK() {
			await steamAppsQuerier.GetServerList(PUBLISHER_KEY);
		}

		[Fact]
		public async Task GetServerList_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamAppsQuerier.GetServerList(PUBLISHER_INVALID_KEY);
			});
		}

		[Fact]
		public async Task GetServersAtAddress() {
			var res = await steamAppsQuerier.GetServersAtAddress("146.66.152.1"); // 146.66.152.0/24 are EU West CSGO server located in Luxembourg

			Assert.True(res.Count >= 0);
		}


		[Fact]
		public async Task UpToDateCheck_OK() {
			await steamAppsQuerier.UpToDateCheck(PUBLISHER_APPID, 6165393);
		}

		[Fact]
		public async Task UpToDateCheck_NOK_KEY() {
			await steamAppsQuerier.UpToDateCheck(TF2_APPID, 6165393);
		}
	}
}
