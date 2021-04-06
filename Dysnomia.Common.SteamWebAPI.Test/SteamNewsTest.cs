using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
	public class SteamNewsTest : BaseTestClass {
		protected readonly SteamNews steamNewsQuerier;

		public SteamNewsTest() {
			this.steamNewsQuerier = new SteamNews();
		}

		[Fact]
		public async Task GetNewsForApp_OK_OneArg() {
			var res = await steamNewsQuerier.GetNewsForApp(PUBLISHER_APPID);

			Assert.True(res.count > 0, res.count.ToString());
			Assert.Equal(res.newsitems.Count, res.count);
		}

		[Fact]
		public async Task GetNewsForAppAuthed_OK_OneArg() {
			var res = await steamNewsQuerier.GetNewsForAppAuthed(PUBLISHER_KEY, PUBLISHER_APPID);

			Assert.True(res.count > 0, res.count.ToString());
			Assert.Equal(res.newsitems.Count, res.count);
		}
	}
}
