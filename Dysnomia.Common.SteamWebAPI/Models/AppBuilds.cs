using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class AppBuilds {
		public Dictionary<string, AppBuild> builds { get; set; } = new Dictionary<string, AppBuild>();
	}

	public class AppBuild {
		public ulong BuildID { get; set; }
		public ulong CreationTime { get; set; }
		public string Description { get; set; }
		public ulong AccountIDCreator { get; set; }
		public Dictionary<string, AppBuildDepot> depots { get; set; } = new Dictionary<string, AppBuildDepot>();
	}

	public class AppBuildDepot {
		public ulong DepotID { get; set; }
		public string DepotVersionGID { get; set; }
		public string TotalOriginalBytes { get; set; }
		public string TotalCompressedBytes { get; set; }
	}
}
