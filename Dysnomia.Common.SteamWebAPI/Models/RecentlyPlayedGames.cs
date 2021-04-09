using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class PlayerAppUsage {
		public IList<PlayerAppUsageItem> games { get; set; }
	}

	public class PlayerAppUsageItem {
		public uint appid { get; set; }
		public string name { get; set; }
		public uint playtime_2weeks { get; set; }
		public uint playtime_forever { get; set; }
		public string img_icon_url { get; set; }
		public string img_logo_url { get; set; }
		public uint playtime_windows_forever { get; set; }
		public uint playtime_mac_forever { get; set; }
		public uint playtime_linux_forever { get; set; }
	}
}

