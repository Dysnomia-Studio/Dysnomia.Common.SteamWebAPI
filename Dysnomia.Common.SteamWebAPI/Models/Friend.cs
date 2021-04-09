using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class FriendListRoot {
		public FriendList friendslist { get; set; }
	}

	public class FriendList {
		public IList<Friend> friends { get; set; }
	}

	public class Friend {
		public string steamid { get; set; }
		public string relationship { get; set; }
		public ulong friend_since { get; set; }
	}
}
