using System;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Exceptions;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
	public class SteamUserStatsTest : BaseTestClass {
		protected readonly ISteamUserStats steamUserStats;

		public SteamUserStatsTest() {
			this.steamUserStats = new SteamUserStats();
		}

		[Fact]
		public async Task GetGlobalAchievementPercentagesForApp() {
			var res = await steamUserStats.GetGlobalAchievementPercentagesForApp(TF2_APPID);

			Assert.True(res.Count > 0, res.Count.ToString());
		}

		[Fact]
		public async Task GetGlobalStatsForGame_1() {
			var stat_name = "global.map.emp_isle";

			var res = await steamUserStats.GetGlobalStatsForGame(17740, new string[] { stat_name });

			Assert.True(res.globalstats.Count == 1, res.globalstats.Count.ToString());

			Assert.True(ulong.Parse(res.globalstats[stat_name].total) > 0, res.globalstats[stat_name].total);
		}

		[Fact]
		public async Task GetGlobalStatsForGame_1_With_Dates() {
			var stat_name = "global.map.emp_isle";

			var res = await steamUserStats.GetGlobalStatsForGame(17740, new string[] { stat_name }, DateTime.Now.AddDays(-40), DateTime.Now);

			Assert.True(res.globalstats.Count == 1, res.globalstats.Count.ToString());

			Assert.True(ulong.Parse(res.globalstats[stat_name].total) > 0, res.globalstats[stat_name].total);
		}

		[Fact]
		public async Task GetGlobalStatsForGame_1_With_Too_Large_Dates() {
			var stat_name = "global.map.emp_isle";

			var res = await steamUserStats.GetGlobalStatsForGame(17740, new string[] { stat_name }, DateTime.Now.AddYears(-10), DateTime.Now);

			Assert.True(res.globalstats == null);
			Assert.True(res.result == 8);
			Assert.True(res.error == "Too many days of history requested. Max is 60");
		}

		[Fact]
		public async Task GetNumberOfCurrentPlayers() {
			var res = await steamUserStats.GetNumberOfCurrentPlayers(TF2_APPID);

			Assert.True(res >= 0, res.ToString());
		}

		[Fact]
		public async Task GetPlayerAchievements_OK() {
			var res = await steamUserStats.GetPlayerAchievements(WEBAPI_KEY, STEAMID, TF2_APPID);

			Assert.True(res.achievements.Count >= 0, res.ToString());
			Assert.True(res.achievements[0].apiname != null);
			Assert.True(res.achievements[0].description == null);
		}

		[Fact]
		public async Task GetPlayerAchievements_OK_Lang() {
			var res = await steamUserStats.GetPlayerAchievements(WEBAPI_KEY, STEAMID, TF2_APPID, "french");

			Assert.True(res.achievements.Count >= 0, res.ToString());
			Assert.True(res.achievements[0].apiname != null);
			Assert.True(res.achievements[0].description != null);
		}

		[Fact]
		public async Task GetPlayerAchievements_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamUserStats.GetPlayerAchievements(WEBAPI_INVALID_KEY, STEAMID, TF2_APPID, "french");
			});
		}

		[Fact]
		public async Task GetSchemaForGame_OK() {
			var res = await steamUserStats.GetSchemaForGame(WEBAPI_KEY, TF2_APPID);

			Assert.True(res.availableGameStats.achievements.Count >= 0);
			Assert.True(res.availableGameStats.stats.Count >= 0);
			Assert.True(res.availableGameStats.achievements[0].description != null);
			Assert.True(res.availableGameStats.stats[0].displayName != null);
		}

		[Fact]
		public async Task GetSchemaForGame_OK_Lang() {
			var res = await steamUserStats.GetSchemaForGame(WEBAPI_KEY, TF2_APPID, "french");

			Assert.True(res.availableGameStats.achievements.Count >= 0);
			Assert.True(res.availableGameStats.stats.Count >= 0);
			Assert.True(res.availableGameStats.achievements[0].description != null);
			Assert.True(res.availableGameStats.stats[0].displayName != null);
		}

		[Fact]
		public async Task GetSchemaForGame_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamUserStats.GetSchemaForGame(WEBAPI_INVALID_KEY, TF2_APPID, "french");
			});
		}

		[Fact]
		public async Task GetUserStatsForGame_OK() {
			var res = await steamUserStats.GetUserStatsForGame(WEBAPI_KEY, STEAMID, TF2_APPID);

			Assert.True(res.achievements.Count >= 0, res.ToString());
			Assert.True(res.achievements[0].name != null);
		}

		[Fact]
		public async Task GetUserStatsForGame_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await steamUserStats.GetUserStatsForGame(WEBAPI_INVALID_KEY, STEAMID, TF2_APPID);
			});
		}
	}
}
