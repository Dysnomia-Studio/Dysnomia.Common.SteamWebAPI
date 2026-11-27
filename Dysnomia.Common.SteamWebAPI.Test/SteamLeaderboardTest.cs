using Dysnomia.Common.SteamWebAPI.Enums;

using System.Linq;
using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
    public class SteamLeaderboardTest(ISteamLeaderboard steamLeaderboard) : BaseTestClass {
        protected readonly ISteamLeaderboard steamLeaderboard = steamLeaderboard;

        [Fact]
        public async Task GetLeaderboardEntries_OK() {
            var res = await steamLeaderboard.GetLeaderboardEntries(PUBLISHER_KEY, PUBLISHER_APPID_WITH_LEADERBOARD, (int)PUBLISHER_APP_LEADERBOARDID, 1);

            Assert.NotNull(res);
            Assert.True(res.appID == PUBLISHER_APPID_WITH_LEADERBOARD);
            Assert.True(res.leaderboardID == PUBLISHER_APP_LEADERBOARDID);
            Assert.NotNull(res.leaderboardEntries);
            Assert.True(res.leaderboardEntries.Any());
        }

        [Fact]
        public async Task GetLeaderboardsForGame_OK() {
            var res = await steamLeaderboard.GetLeaderboardsForGame(PUBLISHER_KEY, PUBLISHER_APPID_WITH_LEADERBOARD);

            Assert.NotNull(res);
            Assert.NotNull(res.leaderboards);
            Assert.True(res.leaderboards.Any());
        }

        [Fact]
        public async Task SetLeaderboardScore_ForceUpdate_OK() {
            var res = await steamLeaderboard.SetLeaderboardScore(PUBLISHER_KEY, PUBLISHER_APPID_WITH_LEADERBOARD, PUBLISHER_APP_LEADERBOARDID, STEAMID, 3_600, ScoreMethod.ForceUpdate);

            Assert.NotNull(res);
        }

        [Fact]
        public async Task SetLeaderboardScore_KeepBest_Lower_OK() {
            var res = await steamLeaderboard.SetLeaderboardScore(PUBLISHER_KEY, PUBLISHER_APPID_WITH_LEADERBOARD, PUBLISHER_APP_LEADERBOARDID, STEAMID, 3_559, ScoreMethod.KeepBest);

            Assert.NotNull(res);
        }

        [Fact]
        public async Task SetLeaderboardScore_KeepBest_Higher_OK() {
            var res = await steamLeaderboard.SetLeaderboardScore(PUBLISHER_KEY, PUBLISHER_APPID_WITH_LEADERBOARD, PUBLISHER_APP_LEADERBOARDID, STEAMID, 3_601, ScoreMethod.KeepBest);

            Assert.NotNull(res);
        }
    }
}
