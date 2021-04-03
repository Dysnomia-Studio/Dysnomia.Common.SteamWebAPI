using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class SteamServersAtAddress {
		public IList<SteamServersAtAddressItem> servers { get; set; }
	}

	public class SteamServersAtAddressItem {
		public string addr { get; set; }
		public uint gmsindex { get; set; }
		public uint appid { get; set; }
		public string gamedir { get; set; }
		public uint region { get; set; }
		public bool secure { get; set; }
		public bool lan { get; set; }
		public uint gameport { get; set; }
		public uint specport { get; set; }
	}
}
