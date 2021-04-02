using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class AppDepotVersions {
		public Dictionary<string, object> depots { get; set; } = new Dictionary<string, object>(); // TODO: do a better model, if you ever find what's in that object (my API return was {} :/)
	}
}
