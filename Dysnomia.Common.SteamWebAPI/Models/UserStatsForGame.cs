using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class UserStatsForGameRoot {
		public UserStatsForGame playerstats { get; set; }
	}

	public class UserStatsForGame {
		public string steamID { get; set; }
		public string gameName { get; set; }
		public IList<UserStatsForGameStats> stats { get; set; }
		public IList<UserStatsForGameAchievements> achievements { get; set; }
	}

	public class UserStatsForGameStats {
		public string name { get; set; }
		public ulong value { get; set; }
	}

	public class UserStatsForGameAchievements {
		public string name { get; set; }
		public ulong achieved { get; set; }
	}
}
