using Dysnomia.Common.WebAPIWrapper;

namespace Dysnomia.Common.SteamWebAPI {
	public class SteamWebAPIQuerier : WebAPIQuerier {
		/// <summary>
		/// Set that value to true to directly call API at https://partner.steam-api.com/ instead of https://api.steampowered.com/
		/// This means we will not call API through Akamai cache server.
		/// WARNING: if you recieve multiple error returned by https://partner.steam-api.com/ your IP might be banned by the firewall for a while.
		/// See https://partner.steamgames.com/doc/webapi_overview#addresses for more informations
		/// </summary>
		public static bool PROD_MODE = false;

		protected readonly string API_URL;

		protected SteamWebAPIQuerier() {
			if (PROD_MODE) {
				API_URL = "https://partner.steam-api.com";
			} else {
				API_URL = "https://api.steampowered.com";
			}
		}
	}
}
