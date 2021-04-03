using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class PartnerAppListRoot {
		public PartnerAppList applist { get; set; }
	}

	public class PartnerAppList {
		public PartnerAppListApp apps { get; set; }
	}

	public class PartnerAppListApp {
		public IList<PartnerAppListAppItem> app { get; set; }
	}

	public class PartnerAppListAppItem {
		public ulong appid { get; set; }
		public string app_type { get; set; }
	}
}
