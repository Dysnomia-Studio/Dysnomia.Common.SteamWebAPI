namespace Dysnomia.Common.SteamWebAPI.Models {
    public class DetailedSalesResponse {
        public DetailedSalesResponseResponse response { get; set; }
    }

    public class DetailedSalesResponseResponse {
        public Result[]? results { get; set; }
        public Key_Request_Info[]? key_request_info { get; set; }
        public Package_Info[]? package_info { get; set; }
        public App_Info[]? app_info { get; set; }
        public Bundle_Info[]? bundle_info { get; set; }
        public Combined_Discount_Info[]? combined_discount_info { get; set; }
        public Game_Item_Info[]? game_item_info { get; set; }
        public Country_Info[]? country_info { get; set; }
        public string max_id { get; set; }
    }

    public class Result {
        public uint partnerid { get; set; }
        public string date { get; set; }
        public string line_item_type { get; set; }
        public uint? packageid { get; set; }
        public uint? bundleid { get; set; }
        public uint? appid { get; set; }
        public string? package_sale_type { get; set; }
        public string? platform { get; set; }
        public string country_code { get; set; }
        public string? base_price { get; set; }
        public string? sale_price { get; set; }
        public string? currency { get; set; }
        public int? gross_units_sold { get; set; }
        public int? gross_units_returned { get; set; }
        public string? gross_sales_usd { get; set; }
        public string? gross_returns_usd { get; set; }
        public string? net_tax_usd { get; set; }
        public uint primary_appid { get; set; }
        public int? additional_revenue_share_tier { get; set; }
        public int? net_units_sold { get; set; }
        public string? net_sales_usd { get; set; }
        public int? combined_discount_id { get; set; }
        public string view_grant_partnerid { get; set; }
        public int? game_item_id { get; set; }
        public string? avg_sale_price_usd { get; set; }
        public uint? key_request_id { get; set; }
        public int? gross_units_activated { get; set; }
    }

    public class Key_Request_Info {
        public int key_request_id { get; set; }
        public string key_request_notes { get; set; }
        public int game_code_id { get; set; }
        public string game_code_description { get; set; }
        public int territory_code_id { get; set; }
        public string territory_code_description { get; set; }
    }

    public class Package_Info {
        public int packageid { get; set; }
        public string package_name { get; set; }
    }

    public class App_Info {
        public int appid { get; set; }
        public string app_name { get; set; }
    }

    public class Bundle_Info {
        public int bundleid { get; set; }
        public string bundle_name { get; set; }
    }

    public class Combined_Discount_Info {
        public int combined_discount_id { get; set; }
        public string combined_discount_name { get; set; }
        public int total_discount_percentage { get; set; }
        public int[] discount_ids { get; set; }
    }

    public class Game_Item_Info {
        public int appid { get; set; }
        public int game_item_id { get; set; }
        public string game_item_description { get; set; }
        public string game_item_category { get; set; }
    }

    public class Country_Info {
        public string country_code { get; set; }
        public string country_name { get; set; }
        public string region { get; set; }
    }

}
