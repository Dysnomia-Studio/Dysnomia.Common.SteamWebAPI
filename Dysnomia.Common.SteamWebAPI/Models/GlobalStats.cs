using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class GlobalStats {
		public int result { get; set; }
		public Dictionary<string, GlobalStatsItem> globalstats { get; set; }
		public string error { get; set; }
	}
	public class GlobalStatsItem {
		public string total { get; set; }
	}
}
