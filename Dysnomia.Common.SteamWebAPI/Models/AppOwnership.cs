using System;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class AppOwershipRoot {
		public AppOwnership appownership { get; set; }
	}

	public class AppOwnership {
		public bool ownsapp { get; set; }
		public bool permanent { get; set; }
		public DateTime timestamp { get; set; }
		public string ownersteamid { get; set; }
		public bool sitelicense { get; set; }
		public bool timedtrial { get; set; }
		public string result { get; set; }
	}
}
