using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class PlayerSummaryRoot {
		public PlayerSummaryList players { get; set; }
	}
	public class PlayerSummaryList {
		public IList<PlayerSummary> player { get; set; }
	}
	public class PlayerSummary {
		public string steamid { get; set; }
		public uint communityvisibilitystate { get; set; }
		public uint profilestate { get; set; }
		public string personaname { get; set; }
		public ulong lastlogoff { get; set; }
		public string profileurl { get; set; }
		public string avatar { get; set; }
		public string avatarmedium { get; set; }
		public string avatarfull { get; set; }
	}
}
