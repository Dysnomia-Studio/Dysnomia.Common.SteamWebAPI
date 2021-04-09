using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class QuestList {
		public IList<Quest> quests { get; set; }
	}

	public class Quest {
		public uint questid { get; set; }
		public bool completed { get; set; }
	}
}
