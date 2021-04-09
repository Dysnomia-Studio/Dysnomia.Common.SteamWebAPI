using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Exceptions;

namespace Dysnomia.Common.SteamWebAPI {
	public class SteamWebAPIQuerier {
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


		protected async Task ThrowAPIErrors(HttpResponseMessage response) {
			switch (response.StatusCode) {
				case HttpStatusCode.Unauthorized: // 401
				case HttpStatusCode.Forbidden: // 403
					throw new ForbiddenException(await response.Content.ReadAsStringAsync());

				case HttpStatusCode.InternalServerError: // 500
				case HttpStatusCode.BadGateway: // 502
				case HttpStatusCode.ServiceUnavailable: // 503
				case HttpStatusCode.GatewayTimeout: // 504
					throw new InternalServerErrorException(await response.Content.ReadAsStringAsync());
			}
		}

		protected async Task<T> Get<T>(string url) {
			using (HttpClient httpClient = new HttpClient()) {
				var response = await httpClient.GetAsync(url);

				await this.ThrowAPIErrors(response);

				return JsonSerializer.Deserialize<T>(await response.Content.ReadAsStringAsync());
			}
		}
	}
}
