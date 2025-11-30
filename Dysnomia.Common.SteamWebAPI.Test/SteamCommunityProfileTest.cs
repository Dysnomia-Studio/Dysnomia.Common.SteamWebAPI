using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
    public class SteamCommunityProfileTest : BaseTestClass {
        protected readonly ISteamCommunityProfile steamCommunityProfile;

        public SteamCommunityProfileTest(ISteamCommunityProfile steamCommunityProfile) {
            this.steamCommunityProfile = steamCommunityProfile;
        }

        [Fact(Skip = "Invalid server response")]
        public async Task GetProfile_OK() {
            var res = await steamCommunityProfile.GetProfile(STEAMID.ToString());

            Assert.True(res != null);
        }
    }
}
