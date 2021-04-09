using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class PlayerBansRoot {
		public IList<PlayerBan> players { get; set; }
	}
	public class PlayerBan {
		public string SteamId { get; set; }
		public bool CommunityBanned { get; set; }
		public bool VACBanned { get; set; }
		public uint NumberOfVACBans { get; set; }
		public uint DaysSinceLastBan { get; set; }
		public uint NumberOfGameBans { get; set; }
		public string EconomyBan { get; set; }
	}
}
