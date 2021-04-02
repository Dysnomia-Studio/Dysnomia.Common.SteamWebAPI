using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class AppListRoot {
		public AppList applist { get; set; }
	}

	public class AppList {
		public IList<AppListItem> apps { get; set; } = new List<AppListItem>();
	}

	public class AppListItem {
		public ulong appid { get; set; }
		public string name { get; set; }
	}
}
