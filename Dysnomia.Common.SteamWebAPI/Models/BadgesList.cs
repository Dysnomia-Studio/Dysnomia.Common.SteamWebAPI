using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class BadgesList {
		public IList<Badge> badges { get; set; }
	}

	public class Badge {
		public uint badgeid { get; set; }
		public uint level { get; set; }
		public ulong completion_time { get; set; }
		public uint xp { get; set; }
		public ulong scarcity { get; set; }
	}
}
