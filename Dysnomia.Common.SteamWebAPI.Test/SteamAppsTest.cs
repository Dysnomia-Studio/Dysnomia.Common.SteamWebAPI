using System;
using System.Linq;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Exceptions;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
	public class SteamAppsTest {
		private const string PUBLISHER_INVALID_KEY = "INVALID";
		private const string PUBLISHER_KEY = "";

		private const uint PUBLISHER_APPID = 1299430; // appId of Extortion
		private const uint TF2_APPID = 440;

		private readonly SteamApps steamAppsQuerier;

		public SteamAppsTest() {
			this.steamAppsQuerier = new SteamApps();
		}

		[Fact]
		public async Task GetAppBetas_OK() {
			try {
				var res = await steamAppsQuerier.GetAppBetas(PUBLISHER_KEY, PUBLISHER_APPID);

				Assert.True(res.Count > 0);
			} catch (Exception e) {
				Assert.True(false, e.Message);
			}
		}

		[Fact]
		public async Task GetAppBetas_NOK_KEY() {
			try {
				await steamAppsQuerier.GetAppBetas(PUBLISHER_INVALID_KEY, PUBLISHER_APPID);
			} catch (ForbiddenException) {
				Assert.True(true);
				return;
			} catch (Exception e) {
				Assert.True(false, e.Message);
			}

			Assert.True(false, "Should have thrown");
		}

		[Fact]
		public async Task GetAppBetas_NOK_APPID() {
			try {
				await steamAppsQuerier.GetAppBetas(PUBLISHER_KEY, TF2_APPID);
			} catch (ForbiddenException) {
				Assert.True(true);
				return;
			} catch (Exception e) {
				Assert.True(false, e.Message);
			}

			Assert.True(false, "Should have thrown");
		}

		[Fact]
		public async Task GetAppBuilds_OK() {
			try {
				var res = await steamAppsQuerier.GetAppBuilds(PUBLISHER_KEY, PUBLISHER_APPID);

				Assert.True(res.Count > 0);
				Assert.True(res.First().Value.depots.Count <= 10);
			} catch (Exception e) {
				Assert.True(false, e.Message);
			}
		}

		[Fact]
		public async Task GetAppBuilds_OK_With_Count() {
			try {
				var res = await steamAppsQuerier.GetAppBuilds(PUBLISHER_KEY, PUBLISHER_APPID, 5);

				Assert.True(res.Count > 0);
				Assert.True(res.First().Value.depots.Count <= 5);
			} catch (Exception e) {
				Assert.True(false, e.Message);
			}
		}

		[Fact]
		public async Task GetAppBuilds_NOK_KEY() {
			try {
				await steamAppsQuerier.GetAppBuilds(PUBLISHER_INVALID_KEY, PUBLISHER_APPID);
			} catch (ForbiddenException) {
				Assert.True(true);
				return;
			} catch (Exception e) {
				Assert.True(false, e.Message);
			}

			Assert.True(false, "Should have thrown");
		}

		[Fact]
		public async Task GetAppBuilds_NOK_APPID() {
			try {
				await steamAppsQuerier.GetAppBuilds(PUBLISHER_KEY, TF2_APPID);
			} catch (ForbiddenException) {
				Assert.True(true);
				return;
			} catch (Exception e) {
				Assert.True(false, e.Message);
			}

			Assert.True(false, "Should have thrown");
		}

		[Fact]
		public async Task GetAppDepotVersions_OK() {
			try {
				var res = await steamAppsQuerier.GetAppDepotVersions(PUBLISHER_KEY, PUBLISHER_APPID);

				Assert.True(res.Count > 0);
			} catch (Exception e) {
				Assert.True(false, e.Message);
			}
		}

		[Fact]
		public async Task GetAppDepotVersions_NOK_KEY() {
			try {
				await steamAppsQuerier.GetAppDepotVersions(PUBLISHER_INVALID_KEY, PUBLISHER_APPID);
			} catch (ForbiddenException) {
				Assert.True(true);
				return;
			} catch (Exception e) {
				Assert.True(false, e.Message);
			}

			Assert.True(false, "Should have thrown");
		}

		[Fact]
		public async Task GetAppDepotVersions_NOK_APPID() {
			try {
				await steamAppsQuerier.GetAppDepotVersions(PUBLISHER_KEY, TF2_APPID);
			} catch (ForbiddenException) {
				Assert.True(true);
				return;
			} catch (Exception e) {
				Assert.True(false, e.Message);
			}

			Assert.True(false, "Should have thrown");
		}

		[Fact]
		public async Task GetAppList() {
			var res = await steamAppsQuerier.GetAppList();

			Assert.True(res.Count > 0);
		}
	}
}
