using Dysnomia.Common.SteamWebAPI.Models;

using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
    public class PartnerFinancialsService(IHttpClientFactory clientFactory) : SteamWebAPIQuerier(clientFactory), IPartnerFinancialsService {
        public async Task<AppWishlistReportingResponse> GetAppWishlistReporting(
             string key,
             ulong appid,
             DateOnly date
        ) {
            return (await this.GetAsync<AppWishlistReportingResponse>(
              string.Format(
                  "{0}/IPartnerFinancialsService/GetAppWishlistReporting/v1/?key={1}&appid={2}&date={3}",
                  API_URL, key, appid, date.ToString("yyyy-MM-dd")
              ),
              null
          ));
        }

        public async Task<DetailedSalesResponse> GetDetailedSales(
             string key,
             DateOnly date,
             ulong highwatermark_id = 0
        ) {
            return (await this.GetAsync<DetailedSalesResponse>(
              string.Format(
                  "{0}/IPartnerFinancialsService/GetDetailedSales/v1/?key={1}&date={2}&highwatermark_id={3}",
                  API_URL, key, date.ToString("yyyy-MM-dd"), highwatermark_id
              ),
              null
          ));
        }
    }
}
