using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class GlobalAchievementPercentagesRoot {
		public GlobalAchievementPercentagesList achievementpercentages { get; set; }
	}

	public class GlobalAchievementPercentagesList {
		public IList<GlobalAchievementPercentages> achievements { get; set; }
	}

	public class GlobalAchievementPercentages {
		public string name { get; set; }
		public float percent { get; set; }
	}
}
