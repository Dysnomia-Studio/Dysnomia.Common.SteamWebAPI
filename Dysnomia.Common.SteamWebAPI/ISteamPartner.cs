using Dysnomia.Common.SteamWebAPI.Models;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
    /// <summary>
    /// Provide methods to call https://partner.steampowered.com/ APIs
    /// </summary>
    public interface ISteamPartner {
        /// <summary>
        /// Get package sale data from partner.steampowered.com website as a CSV string
        /// </summary>
        /// <param name="packageId">Package id to look at (it is DIFFERENT from app id)</param>
        /// <param name="packageName">Package name (game or bundle name)</param>
        /// <param name="dateStart">Min date for data (included)</param>
        /// <param name="dateEnd">Max date for data (included)</param>
        /// <param name="cookie">Cookies for authentication following the format "steamLoginSecure=TOKEN; steamworksRunas=RUNAS;"</param>
        /// <returns></returns>
        Task<string> QueryPackageSalesAsCSVStringAsync(ulong packageId, string packageName, DateOnly dateStart, DateOnly dateEnd, string cookie);

        /// <summary>
        /// Get package sale data from partner.steampowered.com website as a list
        /// </summary>
        /// <param name="packageId">Package id to look at (it is DIFFERENT from app id)</param>
        /// <param name="packageName">Package name (game or bundle name)</param>
        /// <param name="dateStart">Min date for data (included)</param>
        /// <param name="dateEnd">Max date for data (included)</param>
        /// <param name="cookie">Cookies for authentication following the format "steamLoginSecure=TOKEN; steamworksRunas=RUNAS;"</param>
        /// <returns></returns>
        Task<IEnumerable<PackageSales>> QueryPackageSalesAsync(ulong packageId, string packageName, DateOnly dateStart, DateOnly dateEnd, string cookie);

        /// <summary>
        /// Get wishlist actions data from partner.steampowered.com website as a CSV string
        /// </summary>
        /// <param name="appId">App Id</param>
        /// <param name="packageName">Package name (game or bundle name)</param>
        /// <param name="dateStart">Min date for data (included)</param>
        /// <param name="dateEnd">Max date for data (included)</param>
        /// <param name="cookie">Cookies for authentication following the format "steamLoginSecure=TOKEN; steamworksRunas=RUNAS;"</param>
        /// <returns></returns>
        Task<string> QueryWishlistActionsAsCSVStringAsync(ulong appId, string packageName, DateOnly dateStart, DateOnly dateEnd, string cookie);

        /// <summary>
        /// Get package sale data from partner.steampowered.com website as a list
        /// </summary>
        /// <param name="appId">App Id</param>
        /// <param name="packageName">Package name (game or bundle name)</param>
        /// <param name="dateStart">Min date for data (included)</param>
        /// <param name="dateEnd">Max date for data (included)</param>
        /// <param name="cookie">Cookies for authentication following the format "steamLoginSecure=TOKEN; steamworksRunas=RUNAS;"</param>
        /// <returns></returns>
        Task<IEnumerable<WishlistActions>> QueryWishlistActionsAsync(ulong appId, string packageName, DateOnly dateStart, DateOnly dateEnd, string cookie);
    }
}
