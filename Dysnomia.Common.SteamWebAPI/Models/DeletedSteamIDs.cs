using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class DeletedSteamIDsResponse {
		public string rowversion { get; set; }
		public IList<DeletedSteamIDs> steamids { get; set; }
	}

	public class DeletedSteamIDs {
		public string steamid { get; set; }
		public uint appid { get; set; }
	}
}
