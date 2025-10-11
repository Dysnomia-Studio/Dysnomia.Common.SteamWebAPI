using Dysnomia.Common.SteamWebAPI.Models;

using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
    public interface IStoreService {
        /// <summary>
        /// Gets a list of apps available on the Steam Store.
        /// </summary>
        /// <param name="key">Steamworks Web API authentication key.</param>
        /// <param name="if_modified_since">Return only items that have been modified since this date.</param>
        /// <param name="have_description_language">Return only items that have a description in this language.</param>
        /// <param name="include_games">Include games (defaults to enabled)</param>
        /// <param name="include_dlc">Include DLC</param>
        /// <param name="include_software">Include software items</param>
        /// <param name="include_videos">Include videos and series</param>
        /// <param name="include_hardware">Include hardware</param>
        /// <param name="last_appId">For continuations, this is the last appid returned from the previous call.</param>
        /// <param name="max_results">Number of results to return at a time. Default 10000, max 50000.</param>
        /// <returns></returns>
        Task<StoreServiceAppResponse> GetAppList(string key, uint? if_modified_since, string have_description_language, bool? include_games, bool? include_dlc, bool? include_software, bool? include_videos, bool? include_hardware, uint? last_appId, uint? max_results);

        /// <summary>
        /// Gets a list of apps available on the Steam Store.
        /// </summary>
        /// <param name="key">Steamworks Web API authentication key.</param>
        /// <returns></returns>
        Task<StoreServiceAppResponse> GetAppList(string key);
    }
}
