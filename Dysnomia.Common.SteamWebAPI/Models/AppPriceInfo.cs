using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class AppPriceInfoRoot {
		public IDictionary<string, AppPriceInfo> price_info { get; set; }
	}

	public class AppPriceInfo {
		public uint packageid { get; set; }
		public string currency { get; set; }
		public uint initial_price { get; set; }
		public uint final_price { get; set; }
		public uint discount_percent { get; set; }
	}
}
