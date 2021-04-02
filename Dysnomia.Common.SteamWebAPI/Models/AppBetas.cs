using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class AppBetas {
		public Dictionary<string, AppBetasBranch> betas { get; set; } = new Dictionary<string, AppBetasBranch>();
	}

	public class AppBetasBranch {
		public ulong BuildID { get; set; }
		public string Description { get; set; }
		public int ReqPassword { get; set; }
		public int ReqLocalCS { get; set; }

	}
}
