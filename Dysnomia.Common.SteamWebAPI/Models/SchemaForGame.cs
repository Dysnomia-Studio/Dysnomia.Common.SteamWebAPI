using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class SchemaForGameRoot {
		public SchemaForGame game { get; set; }
	}
	public class SchemaForGame {
		public string gameName { get; set; }
		public string gameVersion { get; set; }
		public SchemaForGameAvailableGameStats availableGameStats { get; set; }
	}

	public class SchemaForGameAvailableGameStats {
		public IList<SchemaForGameStats> stats { get; set; }
		public IList<SchemaForGameAchievements> achievements { get; set; }
	}

	public class SchemaForGameStats {
		public string name { get; set; }
		public uint defaultvalue { get; set; }
		public string displayName { get; set; }
	}

	public class SchemaForGameAchievements {
		public string name { get; set; }
		public uint defaultvalue { get; set; }
		public string displayName { get; set; }
		public uint hidden { get; set; }
		public string description { get; set; }
		public string icon { get; set; }
		public string icongray { get; set; }
	}
}
