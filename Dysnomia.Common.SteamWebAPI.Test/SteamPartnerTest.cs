using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
    public class SteamPartnerTest : BaseTestClass {
        protected readonly ISteamPartner steamPartner;

        public SteamPartnerTest(ISteamPartner steamPartner) {
            this.steamPartner = steamPartner;
        }

        [Theory(Skip = "No cookie on CI")]
        [InlineData(453273, "Extortion")]
        public async Task QueryPackageSalesAsCSVStringAsync_OK(uint packageId, string packageName) {
            var res = await steamPartner.QueryPackageSalesAsCSVStringAsync(packageId, packageName, new System.DateOnly(2023, 01, 01), new System.DateOnly(2024, 01, 01), STEAM_PARTNER_COOKIE);

            Assert.False(res.StartsWith("<!DOCTYPE HTML>", System.StringComparison.InvariantCultureIgnoreCase));
            Assert.True(res.Length > 0, res);
        }

        [Theory(Skip = "No cookie on CI")]
        [InlineData(453273, "Extortion")]
        public async Task QueryPackageSalesAsync_OK(uint packageId, string packageName) {
            var res = await steamPartner.QueryPackageSalesAsync(packageId, packageName, new System.DateOnly(2023, 01, 01), new System.DateOnly(2024, 01, 01), STEAM_PARTNER_COOKIE);

            Assert.NotEmpty(res);
        }

        [Theory(Skip = "No cookie on CI")]
        [InlineData(1299430, "Extortion")]
        public async Task QueryWishlistActionsAsCSVStringAsync_OK(uint appId, string packageName) {
            var res = await steamPartner.QueryWishlistActionsAsCSVStringAsync(appId, packageName, new System.DateOnly(2023, 01, 01), new System.DateOnly(2024, 01, 01), STEAM_PARTNER_COOKIE);

            Assert.False(res.StartsWith("<!DOCTYPE HTML>", System.StringComparison.InvariantCultureIgnoreCase));
            Assert.True(res.Length > 0, res);
        }

        [Theory(Skip = "No cookie on CI")]
        [InlineData(1299430, "Extortion")]
        public async Task QueryWishlistActionsAsync_OK(uint appId, string packageName) {
            var res = await steamPartner.QueryWishlistActionsAsync(appId, packageName, new System.DateOnly(2023, 01, 01), new System.DateOnly(2024, 01, 01), STEAM_PARTNER_COOKIE);

            Assert.NotEmpty(res);
        }
    }
}
