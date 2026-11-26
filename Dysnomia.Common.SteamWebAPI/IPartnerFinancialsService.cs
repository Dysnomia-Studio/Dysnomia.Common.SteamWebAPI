using Dysnomia.Common.SteamWebAPI.Models;

using System;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
    public interface IPartnerFinancialsService {
        Task<AppWishlistReportingResponse> GetAppWishlistReporting(
             string key,
             ulong appid,
             DateOnly date
        );

        Task<DetailedSalesResponse> GetDetailedSales(
             string key,
             DateOnly date,
             ulong highwatermark_id = 0
        );
    }
}
