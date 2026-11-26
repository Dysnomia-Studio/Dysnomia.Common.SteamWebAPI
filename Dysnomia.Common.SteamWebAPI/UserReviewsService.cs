using Dysnomia.Common.SteamWebAPI.Enums;
using Dysnomia.Common.SteamWebAPI.Models;

using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
    public class UserReviewsService(IHttpClientFactory clientFactory) : SteamWebAPIQuerier(clientFactory), IUserReviewsService {
        public async Task<ReviewRequestResponse> GetAppReviews(
            string key,
            ulong appid,
            EUserReviewsAppReviewsFilter? filter = null,
            string languages = null,
            uint? day_range = null,
            string cursor = null,
            EUserReviewsReviewType? review_type = null,
            EUserReviewsPurchaseType? purchase_type = null,
            uint? num_per_page = null,
            bool? filter_offtopic_activity = null,
            string display_language = null,
            bool? use_review_quality = null,
            uint? date_range_start = null,
            uint? date_range_end = null,
            bool? date_range_exclude = null,
            uint? playtime_min_hours = null,
            uint? playtime_max_hours = null,
            bool? primarily_steam_deck = null,
            string hardware_os = null,
            string hardware_cpu = null,
            string hardware_gpu = null,
            string hardware_device_type = null
        ) {
            var optionalParams = "";
            if (filter is not null) {
                optionalParams += $"&filter={(int)filter}";
            }
            if (languages is not null) {
                optionalParams += $"&{languages}";
            }
            if (day_range is not null) {
                optionalParams += $"&day_range={day_range}";
            }
            if (cursor is not null) {
                optionalParams += $"&cursor={cursor}";
            }
            if (review_type is not null) {
                optionalParams += $"&review_type={(int)review_type}";
            }
            if (purchase_type is not null) {
                optionalParams += $"&purchase_type={(int)purchase_type}";
            }
            if (num_per_page is not null) {
                optionalParams += $"&num_per_page={num_per_page}";
            }
            if (filter_offtopic_activity is not null) {
                optionalParams += $"&filter_offtopic_activity={filter_offtopic_activity}";
            }
            if (display_language is not null) {
                optionalParams += $"&display_language={display_language}";
            }
            if (use_review_quality is not null) {
                optionalParams += $"&use_review_quality={use_review_quality}";
            }
            if (date_range_start is not null) {
                optionalParams += $"&date_range_start={date_range_start}";
            }
            if (date_range_end is not null) {
                optionalParams += $"&date_range_end={date_range_end}";
            }
            if (date_range_exclude is not null) {
                optionalParams += $"&date_range_exclude={date_range_exclude}";
            }
            if (playtime_min_hours is not null) {
                optionalParams += $"&playtime_min_hours={playtime_min_hours}";
            }
            if (playtime_max_hours is not null) {
                optionalParams += $"&playtime_max_hours={playtime_max_hours}";
            }
            if (primarily_steam_deck is not null) {
                optionalParams += $"&primarily_steam_deck={primarily_steam_deck}";
            }
            if (hardware_os is not null) {
                optionalParams += $"&hardware_os={hardware_os}";
            }
            if (hardware_cpu is not null) {
                optionalParams += $"&hardware_cpu={hardware_cpu}";
            }
            if (hardware_gpu is not null) {
                optionalParams += $"&hardware_gpu={hardware_gpu}";
            }
            if (hardware_device_type is not null) {
                optionalParams += $"&hardware_device_type={hardware_device_type}";
            }

            return (await this.GetAsync<ReviewRequestResponse>(
                string.Format(
                    "{0}/IUserReviewsService/GetAppReviews/v1/?key={1}&appid={2}{3}",
                    API_URL, key, appid, optionalParams
                ),
                null
            ));
        }
    }
}
