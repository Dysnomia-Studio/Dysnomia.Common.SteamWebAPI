using Dysnomia.Common.SteamWebAPI.Enums;

using System.Linq;
using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test
{
    public class SteamLeaderboardTest : BaseTestClass
    {
        protected readonly ISteamLeaderboard steamLeaderboard;

        public SteamLeaderboardTest()
        {
            this.steamLeaderboard = new SteamLeaderboard();
        }

        [Fact]
        public async Task GetLeaderboardsForGame_OK()
        {
            var res = await steamLeaderboard.GetLeaderboardsForGame(PUBLISHER_KEY, PUBLISHER_APPID_WITH_LEADERBOARD);

            Assert.True(res != null);
            Assert.True(res.leaderboards != null);
            Assert.True(res.leaderboards.Any());
        }

        [Fact]
        public async Task SetLeaderboardScore_ForceUpdate_OK()
        {
            var res = await steamLeaderboard.SetLeaderboardScore(PUBLISHER_KEY, PUBLISHER_APPID_WITH_LEADERBOARD, PUBLISHER_APP_LEADERBOARDID, STEAMID, 3_600, ScoreMethod.ForceUpdate);

            Assert.True(res != null);
        }

        [Fact]
        public async Task SetLeaderboardScore_KeepBest_Lower_OK()
        {
            var res = await steamLeaderboard.SetLeaderboardScore(PUBLISHER_KEY, PUBLISHER_APPID_WITH_LEADERBOARD, PUBLISHER_APP_LEADERBOARDID, STEAMID, 3_559, ScoreMethod.KeepBest);

            Assert.True(res != null);
        }

        [Fact]
        public async Task SetLeaderboardScore_KeepBest_Higher_OK()
        {
            var res = await steamLeaderboard.SetLeaderboardScore(PUBLISHER_KEY, PUBLISHER_APPID_WITH_LEADERBOARD, PUBLISHER_APP_LEADERBOARDID, STEAMID, 3_601, ScoreMethod.KeepBest);

            Assert.True(res != null);
        }
    }
}
