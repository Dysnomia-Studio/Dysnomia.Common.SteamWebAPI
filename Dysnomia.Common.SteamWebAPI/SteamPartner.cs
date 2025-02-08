using Dysnomia.Common.SteamWebAPI.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
    /// <summary>
    /// Provide methods to call https://partner.steampowered.com/ APIs
    /// </summary>
    public class SteamPartner : SteamWebAPIQuerier, ISteamPartner {
        private IHttpClientFactory _clientFactory;

        public SteamPartner(IHttpClientFactory clientFactory) : base(clientFactory) {
            _clientFactory = clientFactory;
        }

        /// <summary>
        /// Get package sale data from partner.steampowered.com website as a CSV string
        /// </summary>
        /// <param name="packageId">Package id to look at (it is DIFFERENT from app id)</param>
        /// <param name="packageName">Package name (game or bundle name)</param>
        /// <param name="dateStart">Min date for data (included)</param>
        /// <param name="dateEnd">Max date for data (included)</param>
        /// <param name="cookie">Cookies for authentication following the format "steamLoginSecure=TOKEN; steamworksRunas=RUNAS;"</param>
        /// <returns></returns>
        public async Task<string> QueryPackageSalesAsCSVStringAsync(ulong packageId, string packageName, DateOnly dateStart, DateOnly dateEnd, string cookie) {
            var url = $"https://partner.steampowered.com/report_csv.php?file={packageName}&params=query=QueryPackageSalesForCSV^pkgID={packageId}^dateStart={dateStart:yyyy-MM-dd}^dateEnd={dateEnd:yyyy-MM-dd}^HasDivisions=0^interpreter=PartnerSalesReportInterpreter";

            return await GetStringAsync(url, new() {
                { "cookie", cookie }
            });
        }

        /// <summary>
        /// Get package sale data from partner.steampowered.com website as a CSV string
        /// </summary>
        /// <param name="packageId">Package id to look at (it is DIFFERENT from app id)</param>
        /// <param name="packageName">Package name (game or bundle name)</param>
        /// <param name="dateStart">Min date for data (included)</param>
        /// <param name="dateEnd">Max date for data (included)</param>
        /// <param name="cookie">Cookies for authentication following the format "steamLoginSecure=TOKEN; steamworksRunas=RUNAS;"</param>
        /// <returns></returns>
        public async Task<IEnumerable<PackageSales>> QueryPackageSalesAsync(ulong packageId, string packageName, DateOnly dateStart, DateOnly dateEnd, string cookie) {
            var csvString = await QueryPackageSalesAsCSVStringAsync(packageId, packageName, dateStart, dateEnd, cookie);
            var csvLines = csvString.Split('\n').ToList();

            /*
             * Let's remove the following lines:
             * 
             * -----------
             * sep=,
             * Steam Sales data for [COMPANY]: [FROM] - [TO]
             * 
             * [HEADER]
             * -----------
             */
            csvLines.RemoveRange(0, 4);

            var result = new List<PackageSales>();
            foreach (var line in csvLines) {
                if (string.IsNullOrWhiteSpace(line)) continue;

                result.Add(PackageSales.FromCSVLine(line));
            }

            return result;
        }

        public async Task<string> QueryWishlistActionsAsCSVStringAsync(ulong appId, string packageName, DateOnly dateStart, DateOnly dateEnd, string cookie) {
            var url = $"https://partner.steampowered.com/report_csv.php?file={packageName}&params=query=QueryWishlistActionsForCSV^appID={appId}^dateStart={dateStart:yyyy-MM-dd}^dateEnd={dateEnd:yyyy-MM-dd}^interpreter=WishlistReportInterpreter";

            return await GetStringAsync(url, new() {
                { "cookie", cookie }
            });
        }

        public async Task<IEnumerable<WishlistActions>> QueryWishlistActionsAsync(ulong appId, string packageName, DateOnly dateStart, DateOnly dateEnd, string cookie) {
            var csvString = await QueryWishlistActionsAsCSVStringAsync(appId, packageName, dateStart, dateEnd, cookie);
            var csvLines = csvString.Split('\n').ToList();

            /*
             * Let's remove the following lines:
             * 
             * -----------
             * sep=,
             * Steam Wishlisting data for [FROM] - [TO]
             * 
             * [HEADER]
             * -----------
             */
            csvLines.RemoveRange(0, 4);

            var result = new List<WishlistActions>();
            foreach (var line in csvLines) {
                if (string.IsNullOrWhiteSpace(line)) continue;

                result.Add(WishlistActions.FromCSVLine(line));
            }

            return result;
        }
    }
}
