using Dysnomia.Common.SteamWebAPI.Models;

using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
    /// <summary>
    /// </summary>
    public class StoreService : SteamWebAPIQuerier, IStoreService {
        public StoreService(IHttpClientFactory clientFactory) : base(clientFactory) {
        }

        // TODO: GetAppInfo

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
        public async Task<StoreServiceAppResponse> GetAppList(string key, uint? if_modified_since, string have_description_language, bool? include_games, bool? include_dlc, bool? include_software, bool? include_videos, bool? include_hardware, uint? last_appId, uint? max_results) {
            string if_modified_since_str = "";
            if (if_modified_since != null) {
                if_modified_since_str = string.Format("&if_modified_since={0}", if_modified_since);
            }

            string have_description_language_str = "";
            if (have_description_language != null) {
                have_description_language_str = string.Format("&have_description_language={0}", have_description_language);
            }

            string include_games_str = "";
            if (include_games != null) {
                include_games_str = string.Format("&include_games={0}", include_games);
            }

            string include_dlc_str = "";
            if (include_dlc != null) {
                include_dlc_str = string.Format("&include_dlc={0}", include_dlc);
            }

            string include_software_str = "";
            if (include_software != null) {
                include_software_str = string.Format("&include_software={0}", include_software);
            }

            string include_videos_str = "";
            if (include_videos != null) {
                include_videos_str = string.Format("&include_videos={0}", include_videos);
            }

            string include_hardware_str = "";
            if (include_hardware != null) {
                include_hardware_str = string.Format("&include_hardware={0}", include_hardware);
            }

            string last_appid_str = "";
            if (last_appId != null) {
                last_appid_str = string.Format("&last_appid={0}", last_appId);
            }

            string max_results_str = "";
            if (max_results != null) {
                max_results_str = string.Format("&max_results={0}", max_results);
            }

            return (await this.GetAsync<SteamAPIResponse<StoreServiceAppResponse>>(
                string.Format(
                    "{0}/IStoreService/GetAppList/v1/?key={1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
                    API_URL, key, if_modified_since_str, have_description_language_str, include_games_str, include_dlc_str, include_software_str, include_videos_str, include_hardware_str, last_appid_str, max_results_str
                )
            )).response;
        }

        /// <summary>
        /// Gets a list of apps available on the Steam Store.
        /// </summary>
        /// <param name="key">Steamworks Web API authentication key.</param>
        /// <returns></returns>
        public async Task<StoreServiceAppResponse> GetAppList(string key) {
            return await GetAppList(key, null, null, null, null, null, null, null, null, null);
        }
    }
}
