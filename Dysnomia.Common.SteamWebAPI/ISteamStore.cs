using System.Collections.Generic;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// This class is using steam store API (https://store.steampowered.com/api/)
	/// </summary>
	public interface ISteamStore {
		Task<Dictionary<string, StoreAppDetailsPriceOverview>> GetAppPrices(string[] appids);
		Task<StoreAppDetailsRoot> GetAppDetails(string appid);
	}
}