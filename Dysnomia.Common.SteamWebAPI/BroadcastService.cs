using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Provides access to Steam broadcasts.
	/// https://partner.steamgames.com/doc/webapi/IBroadcastService
	/// </summary>
	public class BroadcastService : SteamWebAPIQuerier, IBroadcastService {
		/// <summary>
		/// Add a game meta data frame to broadcast
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid"></param>
		/// <param name="steamid"></param>
		/// <param name="broadcast_id"></param>
		/// <param name="frame_data"></param>
		/// <returns></returns>
		public async Task<string> PostGameDataFrame(string key, uint appid, ulong steamid, ulong broadcast_id, string frame_data) {
			using (HttpClient httpClient = new HttpClient()) {
				var response = await httpClient.GetAsync(
					string.Format(
						"{0}/IBroadcastService/PostGameDataFrame/v1/?key={1}&appid={2}&steamid={3}&broadcast_id={4}&frame_data={5}",
						API_URL, key, appid, steamid, broadcast_id, frame_data
					)
				);

				return await response.Content.ReadAsStringAsync();
			}
		}
	}
}
