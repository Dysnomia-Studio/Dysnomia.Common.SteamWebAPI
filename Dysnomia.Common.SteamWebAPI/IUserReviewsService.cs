using Dysnomia.Common.SteamWebAPI.Enums;
using Dysnomia.Common.SteamWebAPI.Models;

using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
    public interface IUserReviewsService {
        Task<ReviewRequestResponse> GetAppReviews(
            string key,
            ulong appid,
            EUserReviewsAppReviewsFilter? filter = null,
            string? languages = null,
            uint? day_range = null,
            string? cursor = null,
            EUserReviewsReviewType? review_type = null,
            EUserReviewsPurchaseType? purchase_type = null,
            uint? num_per_page = null,
            bool? filter_offtopic_activity = null,
            string? display_language = null,
            bool? use_review_quality = null,
            uint? date_range_start = null,
            uint? date_range_end = null,
            bool? date_range_exclude = null,
            uint? playtime_min_hours = null,
            uint? playtime_max_hours = null,
            bool? primarily_steam_deck = null,
            string? hardware_os = null,
            string? hardware_cpu = null,
            string? hardware_gpu = null,
            string? hardware_device_type = null
        );
    }
}
