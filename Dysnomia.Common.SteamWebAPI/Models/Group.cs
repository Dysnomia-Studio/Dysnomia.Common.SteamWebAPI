using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class GroupRoot {
		public IList<Group> groups { get; set; }
		public bool success { get; set; }
	}

	public class Group {
		public string gid { get; set; }
	}
}
