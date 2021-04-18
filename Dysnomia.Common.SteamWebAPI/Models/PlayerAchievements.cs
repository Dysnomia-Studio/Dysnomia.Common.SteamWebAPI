using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class PlayerAchievementsRoot {
		public PlayerAchievements playerstats { get; set; }
	}

	public class PlayerAchievements {
		public string steamID { get; set; }
		public string gameName { get; set; }
		public IList<PlayerAchievementsItem> achievements { get; set; }
		public bool success { get; set; }
	}

	public class PlayerAchievementsItem {
		public string apiname { get; set; }
		public uint achieved { get; set; }
		public ulong unlocktime { get; set; }
		public string name { get; set; }
		public string description { get; set; }
	}
}
