using Dysnomia.Common.SteamWebAPI.Models;

using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// This class is using steam store API (https://store.steampowered.com/api/)
	/// </summary>
	public class SteamStore : SteamWebAPIQuerier, ISteamStore {
		public SteamStore(IHttpClientFactory clientFactory) : base(clientFactory) {
		}

		public async Task<Dictionary<string, StoreAppDetailsPriceOverview>> GetAppPrices(string[] appids) {
			return await this.Get<Dictionary<string, StoreAppDetailsPriceOverview>>("https://store.steampowered.com/api/appdetails/?filters=price_overview&appids=" + string.Join(",", appids));
		}

		public async Task<StoreAppDetailsRoot> GetAppDetails(string appid) {
			/* @TODO: filters:
				type
				name
				steam_appid
				required_age
				dlc
				detailed_description
				about_the_game
				supported_languages
				detailed_description
				supported_languages
				header_image
				website
				pc_requirements
				mac_requirements
				linux_requirements
			*/

			return (await this.Get<Dictionary<string, StoreAppDetailsRoot>>("https://store.steampowered.com/api/appdetails/?&appids=" + appid))[appid];

		}
	}
}
