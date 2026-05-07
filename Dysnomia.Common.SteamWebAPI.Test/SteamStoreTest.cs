using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
    public class SteamStoreTest(ISteamStore steamStore) : BaseTestClass {
        protected readonly ISteamStore steamStore = steamStore;

        [Fact]
        public async Task GetAppPrices() {
            await steamStore.GetAppPrices(new string[] { "440", "10" }); // TF2, CS
        }

        [Fact]
        public async Task GetAppDetails_CS() {
            var res = await steamStore.GetAppDetails("10");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_HL() {
            var res = await steamStore.GetAppDetails("70");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_HL2() {
            var res = await steamStore.GetAppDetails("220");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_TF2() {
            var res = await steamStore.GetAppDetails("440");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_CSGO() {
            var res = await steamStore.GetAppDetails("730");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_Blender() {
            var res = await steamStore.GetAppDetails("365670");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_Cities_Skyline() {
            var res = await steamStore.GetAppDetails("255710");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_SkyrimSE() {
            var res = await steamStore.GetAppDetails("489830");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_HLAlyx() {
            var res = await steamStore.GetAppDetails("546560");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_Cities_Skyline_SH() {
            var res = await steamStore.GetAppDetails("1146930");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_Extortion() {
            var res = await steamStore.GetAppDetails("1299430");
            Assert.True(res.success);
            Assert.NotNull(res.data);
            Assert.Null(res.data.fullgame?.appid);
        }

        [Fact]
        public async Task GetAppDetails_Extortion_Demo() {
            var res = await steamStore.GetAppDetails("1355540");
            Assert.True(res.success);
            Assert.NotNull(res.data);
            Assert.NotNull(res.data.fullgame?.appid);
        }

        [Fact]
        public async Task GetAppDetails_EYE() { // This one has a weird display_type, we add this test to prevent non-compatibility of future modifications
            var res = await steamStore.GetAppDetails("314260");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_XSS() { // This one has some weird data as well
            var res = await steamStore.GetAppDetails("331840");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }

        [Fact]
        public async Task GetAppDetails_InvalidPercentSaving() {
            var res = await steamStore.GetAppDetails("1451150");
            Assert.True(res.success);
            Assert.NotNull(res.data);
        }
    }
}
