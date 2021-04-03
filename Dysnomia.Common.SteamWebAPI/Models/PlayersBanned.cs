using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class PlayersBanned {
		public IList<object> accounts { get; set; } // TODO: do a better model, if you ever find what's in that object (my API return was {"accounts":[]} :/)
	}
}
