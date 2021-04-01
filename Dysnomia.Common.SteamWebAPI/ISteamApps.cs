using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
	public interface ISteamApps {
		Task<string> GetAppBetas(string key, uint appid);
	}
}
