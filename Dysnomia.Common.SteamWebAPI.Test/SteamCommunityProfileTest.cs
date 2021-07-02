using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
	public class SteamCommunityProfileTest : BaseTestClass {
		protected readonly SteamCommunityProfile steamCommunityProfile;

		public SteamCommunityProfileTest() {
			this.steamCommunityProfile = new SteamCommunityProfile();
		}

		[Fact]
		public async Task GetProfile_OK() {
			var res = await steamCommunityProfile.GetProfile(STEAMPROFILE);

			Assert.True(res != null);
		}
	}
}
