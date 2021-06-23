using System.Threading.Tasks;

using Dysnomia.Common.WebAPIWrapper.Exceptions;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
	public class PlayerServiceTest : BaseTestClass {
		protected readonly PlayerService playerServiceQuerier;

		public PlayerServiceTest() {
			this.playerServiceQuerier = new PlayerService();
		}

		[Fact]
		public async Task GetRecentlyPlayedGames_OK_NOLIMIT() {
			var res = await playerServiceQuerier.GetRecentlyPlayedGames(WEBAPI_KEY, STEAMID, 0);

			Assert.True(res.Count >= 0, res.Count.ToString());
		}

		[Fact]
		public async Task GetRecentlyPlayedGames_OK_5LIMIT() {
			var res = await playerServiceQuerier.GetRecentlyPlayedGames(WEBAPI_KEY, STEAMID, 5);

			Assert.True(res.Count >= 0, res.Count.ToString());
			Assert.True(res.Count <= 5, res.Count.ToString());
		}

		[Fact]
		public async Task GetRecentlyPlayedGames_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await playerServiceQuerier.GetRecentlyPlayedGames(WEBAPI_INVALID_KEY, STEAMID, 5);
			});
		}

		[Fact]
		public async Task GetRecentlyPlayedGames_NOK_STEAMID() {
			await Assert.ThrowsAsync<InternalServerErrorException>(async () => {
				await playerServiceQuerier.GetRecentlyPlayedGames(WEBAPI_KEY, INVALID_STEAMID, 5);
			});
		}

		[Fact]
		public async Task GetOwnedGames_OK_FALSEBOOL() {
			var res = await playerServiceQuerier.GetOwnedGames(WEBAPI_KEY, STEAMID, false, false);

			Assert.True(res.Count > 0, res.Count.ToString());
		}

		[Fact]
		public async Task GetOwnedGames_OK_TRUEBOOL() {
			var res = await playerServiceQuerier.GetOwnedGames(WEBAPI_KEY, STEAMID, true, true);

			Assert.True(res.Count > 0, res.Count.ToString());
		}

		[Fact]
		public async Task GetOwnedGames_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await playerServiceQuerier.GetOwnedGames(WEBAPI_INVALID_KEY, STEAMID, false, false);
			});
		}

		[Fact]
		public async Task GetSteamLevel_OK() {
			var res = await playerServiceQuerier.GetSteamLevel(WEBAPI_KEY, STEAMID);

			Assert.True(res > 0, res.ToString());
		}

		[Fact]
		public async Task GetSteamLevel_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await playerServiceQuerier.GetSteamLevel(WEBAPI_INVALID_KEY, STEAMID);
			});
		}

		[Fact]
		public async Task GetBadges_OK() {
			var res = await playerServiceQuerier.GetBadges(WEBAPI_KEY, STEAMID);

			Assert.True(res.Count > 0, res.Count.ToString());
		}

		[Fact]
		public async Task GetBadges_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await playerServiceQuerier.GetBadges(WEBAPI_INVALID_KEY, STEAMID);
			});
		}

		[Fact]
		public async Task GetCommunityBadgeProgress_OK_NULL() {
			var res = await playerServiceQuerier.GetCommunityBadgeProgress(WEBAPI_KEY, STEAMID, null);

			Assert.True(res.Count > 0, res.Count.ToString());
		}

		[Fact]
		public async Task GetCommunityBadgeProgress_OK_NOT_NULL() {
			var res = await playerServiceQuerier.GetCommunityBadgeProgress(WEBAPI_KEY, STEAMID, 14);

			Assert.True(res == null || res.Count > 0);
		}

		[Fact]
		public async Task GetCommunityBadgeProgress_NOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await playerServiceQuerier.GetCommunityBadgeProgress(WEBAPI_INVALID_KEY, STEAMID, null);
			});
		}

		[Fact]
		public async Task IsPlayingSharedGame_OK() {
			var res = await playerServiceQuerier.IsPlayingSharedGame(WEBAPI_KEY, STEAMID, TF2_APPID);

			Assert.Equal(res, "0");
		}

		[Fact]
		public async Task IsPlayingSharedGameNOK_KEY() {
			await Assert.ThrowsAsync<ForbiddenException>(async () => {
				await playerServiceQuerier.IsPlayingSharedGame(WEBAPI_INVALID_KEY, STEAMID, TF2_APPID);
			});
		}
	}
}
