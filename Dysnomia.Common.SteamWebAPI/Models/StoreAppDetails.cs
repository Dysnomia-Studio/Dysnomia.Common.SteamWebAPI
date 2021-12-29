using Dysnomia.Common.WebAPIWrapper.Helpers;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class StoreAppDetailsPriceOverview {
		public bool success { get; set; }
		[JsonConverter(typeof(EmptyArrayToObjectConverter<StoreAppDetailsPriceOverviewData>))] // Steam can return [] here ...
		public StoreAppDetailsPriceOverviewData data { get; set; }
	}
	public class StoreAppDetailsPriceOverviewData {
		public StoreAppDetailsPriceOverviewDetails price_overview { get; set; }
	}

	public class StoreAppDetailsRoot {
		public bool success { get; set; }
		public StoreAppDetails data { get; set; }
	}

	public class StoreAppDetails {
		/// <summary>
		/// Observed values: "game", "dlc", "demo", "advertising", "mod", "video".
		/// </summary>
		public string type { get; set; }
		public string name { get; set; }
		public ulong steam_appid { get; set; }
		[JsonConverter(typeof(StringToNumberConverter<uint>))] // Steam can return a string here ...
		public uint required_age { get; set; }
		/// <summary>
		/// partial, full, or not filled
		/// </summary>
		public string controller_support { get; set; }
		public bool is_free { get; set; }
		public ulong[] dlc { get; set; }
		public string detailed_description { get; set; }
		public string about_the_game { get; set; }
		public string short_description { get; set; }
		public StoreAppDetailsFullGame fullgame { get; set; }
		public string supported_languages { get; set; }
		public string header_image { get; set; }
		public string website { get; set; }
		[JsonConverter(typeof(EmptyArrayToObjectConverter<StoreAppDetailsRequirements>))] // Steam can return [] here ...
		public StoreAppDetailsRequirements pc_requirements { get; set; }
		[JsonConverter(typeof(EmptyArrayToObjectConverter<StoreAppDetailsRequirements>))] // Steam can return [] here ...
		public StoreAppDetailsRequirements mac_requirements { get; set; }
		[JsonConverter(typeof(EmptyArrayToObjectConverter<StoreAppDetailsRequirements>))] // Steam can return [] here ...
		public StoreAppDetailsRequirements linux_requirements { get; set; }
		public string legal_notice { get; set; }
		public string[] developers { get; set; }
		public string[] publishers { get; set; }
		public StoreAppDetailsDemo[] demos { get; set; }
		public StoreAppDetailsPriceOverviewDetails price_overview { get; set; }
		public ulong[] packages { get; set; }
		public StoreAppDetailsPricePackageGroup[] package_groups { get; set; }
		public Dictionary<string, bool> platforms { get; set; }
		public StoreAppDetailsMetacritic metacritic { get; set; }
		public StoreAppDetailsCategory[] categories { get; set; }
		public StoreAppDetailsGenre[] genres { get; set; }
		public StoreAppDetailsScreenshot[] screenshots { get; set; }
		public StoreAppDetailsMovie[] movies { get; set; }
		public StoreAppDetailsRecomendations recommendations { get; set; }
		public StoreAppDetailsAchievements achievements { get; set; }
		public StoreAppDetailsReleaseDate release_date { get; set; }
		public StoreAppDetailsSupportInfo support_info { get; set; }
		public string background { get; set; }
		public StoreAppDetailsContentDescriptors content_descriptors { get; set; }
	}

	public class StoreAppDetailsRequirements {
		public string minimum { get; set; }
		public string recommended { get; set; }
	}

	public class StoreAppDetailsFullGame {
		[JsonConverter(typeof(StringToNumberConverter<ulong>))] // Steam can return a string here ...
		public ulong appid { get; set; }
		public string name { get; set; }
	}

	public class StoreAppDetailsDemo {
		public ulong appid { get; set; }
		public string description { get; set; }
	}

	public class StoreAppDetailsPriceOverviewDetails {
		public string currency { get; set; }
		public uint initial { get; set; }
		public uint final { get; set; }
		public uint discount_percent { get; set; }
		public string initial_formatted { get; set; }
		public string final_formatted { get; set; }
	}

	public class StoreAppDetailsPricePackageGroup {
		public string name { get; set; }
		public string title { get; set; }
		public string description { get; set; }
		public string selection_text { get; set; }
		public string save_text { get; set; }
		/// <summary>
		/// Old rules:
		/// 0 - list subs as seperate purchase blocks.
		/// 1 - list subs in a dropdown box, contained within a single purchase block for the package group
		/// default - ???
		/// </summary>
		[JsonConverter(typeof(WhateverToStringConverter))] // Steam can return a string representing an number, or a number, or even a string like "default" here ... 
		public string display_type { get; set; }
		[JsonConverter(typeof(StringToBooleanConverter))] // Steam can return boolean string version here ...
		public bool is_recurring_subscription { get; set; }
		public StoreAppDetailsPricePackageGroupSubscription[] subs { get; set; }
	}

	public class StoreAppDetailsPricePackageGroupSubscription {
		public ulong packageid { get; set; }
		public string percent_savings_text { get; set; }
		public uint percent_savings { get; set; }
		public string option_text { get; set; }
		public string option_description { get; set; }
		public string can_get_free_license { get; set; }
		public bool is_free_license { get; set; }
		public ulong price_in_cents_with_discount { get; set; }
	}

	public class StoreAppDetailsMetacritic {
		public uint score { get; set; }
		public string url { get; set; }
	}

	public class StoreAppDetailsCategory {
		public ulong id { get; set; }
		public string description { get; set; }
	}

	public class StoreAppDetailsGenre {
		[JsonConverter(typeof(StringToNumberConverter<ulong>))] // Steam can return a string here ...
		public ulong id { get; set; }
		public string description { get; set; }
	}

	public class StoreAppDetailsScreenshot {
		public ulong id { get; set; }
		public string path_thumbnail { get; set; }
		public string path_full { get; set; }
	}

	public class StoreAppDetailsMovie {
		public ulong id { get; set; }
		public string name { get; set; }
		public string thumbnail { get; set; }
		public StoreAppDetailsMovieURL webm { get; set; }
		public StoreAppDetailsMovieURL mp4 { get; set; }
		public bool highlight { get; set; }
	}

	public class StoreAppDetailsMovieURL {
		[JsonPropertyName("480")]
		public string _480 { get; set; }
		public string max { get; set; }
	}

	public class StoreAppDetailsRecomendations {
		public ulong total { get; set; }
	}

	public class StoreAppDetailsAchievements {
		public uint total { get; set; }
		public StoreAppDetailsAchievementsDetails[] highlighted { get; set; }
	}

	public class StoreAppDetailsAchievementsDetails {
		public string name { get; set; }
		public string path { get; set; }
	}

	public class StoreAppDetailsReleaseDate {
		public bool coming_soon { get; set; }
		public string date { get; set; }
	}

	public class StoreAppDetailsSupportInfo {
		public string url { get; set; }
		public string email { get; set; }
	}

	public class StoreAppDetailsContentDescriptors {
		public uint[] ids { get; set; }
		public string notes { get; set; }
	}
}
