using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Exceptions;

namespace Dysnomia.Common.SteamWebAPI {
	public class SteamWebAPIQuerier {
		protected async Task ThrowAPIErrors(HttpResponseMessage response) {
			switch (response.StatusCode) {
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
