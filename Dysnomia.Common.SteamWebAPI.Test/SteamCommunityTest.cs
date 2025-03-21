using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
    public class SteamCommunityTest : BaseTestClass {
        protected readonly ISteamCommunity steamCommunity;

        public SteamCommunityTest(ISteamCommunity steamCommunity) {
            this.steamCommunity = steamCommunity;
        }

        [Theory]
        [InlineData(1730540, "Alchemistry")]
        [InlineData(1299430, "Extortion")]
        [InlineData(271590, "Grand Theft Auto V Legacy")]
        public async Task GetAppGroupMemberListAsync_OK(uint app, string name) {
            var res = await steamCommunity.GetAppGroupMemberListAsync(app);

            Assert.True(res.memberCount > 0, res.memberCount.ToString());
            Assert.True(res.groupID64 > 0, res.groupID64.ToString());
            Assert.Equal(name, res.groupDetails.groupName);
        }
    }
}
