using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
	public class SteamStoreTest : BaseTestClass {
		protected readonly ISteamStore steamStore;

		public SteamStoreTest() {
			this.steamStore = new SteamStore();
		}

		[Fact]
		public async Task GetAppPrices() {
			await steamStore.GetAppPrices(new string[] { "440", "10" }); // TF2, CS
		}

		[Fact]
		public async Task GetAppDetails_CS() {
			await steamStore.GetAppDetails("10");
		}

		[Fact]
		public async Task GetAppDetails_HL() {
			await steamStore.GetAppDetails("70");
		}

		[Fact]
		public async Task GetAppDetails_HL2() {
			await steamStore.GetAppDetails("220");
		}

		[Fact]
		public async Task GetAppDetails_TF2() {
			await steamStore.GetAppDetails("440");
		}

		[Fact]
		public async Task GetAppDetails_CSGO() {
			await steamStore.GetAppDetails("730");
		}

		[Fact]
		public async Task GetAppDetails_Blender() {
			await steamStore.GetAppDetails("365670");
		}

		[Fact]
		public async Task GetAppDetails_Cities_Skyline() {
			await steamStore.GetAppDetails("255710");
		}

		[Fact]
		public async Task GetAppDetails_SkyrimSE() {
			await steamStore.GetAppDetails("489830");
		}

		[Fact]
		public async Task GetAppDetails_HLAlyx() {
			await steamStore.GetAppDetails("546560");
		}

		[Fact]
		public async Task GetAppDetails_Cities_Skyline_SH() {
			await steamStore.GetAppDetails("1146930");
		}

		[Fact]
		public async Task GetAppDetails_Extortion() {
			await steamStore.GetAppDetails("1299430");
		}

		[Fact]
		public async Task GetAppDetails_Extortion_Demo() {
			await steamStore.GetAppDetails("1355540");
		}
	}
}
