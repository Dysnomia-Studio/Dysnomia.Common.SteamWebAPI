namespace Dysnomia.Common.SteamWebAPI.Models {
    public class AppWishlistReportingResponse {
        public AppWishlistReportingResponseResponse response { get; set; }
    }

    public class AppWishlistReportingResponseResponse {
        public ulong? appid { get; set; }
        public string? date { get; set; }
        public Wishlist_Summary? wishlist_summary { get; set; }
        public Country_Summary[]? country_summary { get; set; }
        public Language_Summary[]? language_summary { get; set; }
        public uint? time_generated { get; set; }
        public string? app_min_date { get; set; }
    }

    public class Wishlist_Summary {
        public uint wishlist_adds { get; set; }
        public uint wishlist_deletes { get; set; }
        public uint wishlist_purchases { get; set; }
        public uint wishlist_gifts { get; set; }
        public uint wishlist_adds_windows { get; set; }
        public uint wishlist_adds_mac { get; set; }
        public uint wishlist_adds_linux { get; set; }
    }

    public class Country_Summary {
        public string country_code { get; set; }
        public Wishlist_Summary summary_actions { get; set; }
        public string country_name { get; set; }
        public string region { get; set; }
    }
    public class Language_Summary {
        public int language { get; set; }
        public Wishlist_Summary summary_actions { get; set; }
        public string language_name { get; set; }
    }
}
