using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Exceptions;

namespace Dysnomia.Common.SteamWebAPI {
	public class SteamWebAPIQuerier {
		protected async Task ThrowAPIErrors(HttpResponseMessage response) {
			switch (response.StatusCode) {
				case HttpStatusCode.Forbidden:
					throw new ForbiddenException(await response.Content.ReadAsStringAsync());
			}
		}

		protected async Task<HttpResponseMessage> Get(string url) {
			using (HttpClient httpClient = new HttpClient()) {
				var response = await httpClient.GetAsync(url);

				await this.ThrowAPIErrors(response);

				return response;
			}
		}
	}
}
