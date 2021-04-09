using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class AppOwnershipChangesRoot {
		public AppOwnershipChanges ownershipchanges { get; set; }
	}

	public class AppOwnershipChanges {
		public IList<AppOwnershipChangesSteamId> steamids { get; set; }
		public string packagerowversion { get; set; }
		public string cdkeyrowversion { get; set; }
		public bool moredata { get; set; }
	}

	public class AppOwnershipChangesSteamId {
		public string steamid { get; set; }
	}
}
