using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Provides access to Steam broadcasts.
	/// https://partner.steamgames.com/doc/webapi/IBroadcastService
	/// </summary>
	public interface IBroadcastService {
		/// <summary>
		/// Add a game meta data frame to broadcast
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid"></param>
		/// <param name="steamid"></param>
		/// <param name="broadcast_id"></param>
		/// <param name="frame_data"></param>
		/// <returns></returns>
		Task<string> PostGameDataFrame(string key, uint appid, ulong steamid, ulong broadcast_id, string frame_data);
	}
}
