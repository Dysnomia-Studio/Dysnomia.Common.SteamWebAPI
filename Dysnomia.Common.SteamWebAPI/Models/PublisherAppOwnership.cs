using System;
using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class PublisherAppOwnershipRoot {
		public PublisherAppOwnershipList appownership { get; set; }
	}

	public class PublisherAppOwnershipList {
		public IList<PublisherAppOwnership> apps { get; set; }
	}

	public class PublisherAppOwnership {
		public uint appid { get; set; }
		public bool ownsapp { get; set; }
		public bool permanent { get; set; }
		public DateTime timestamp { get; set; }
		public string ownersteamid { get; set; }
		public bool sitelicense { get; set; }
		public bool timedtrial { get; set; }
	}
}
