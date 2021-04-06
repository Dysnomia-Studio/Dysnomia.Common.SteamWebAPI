using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
	public class AppNewsRoot {
		public AppNews appnews { get; set; }
	}
	public class AppNews {
		public uint appid { get; set; }
		public IList<AppNewsItem> newsitems { get; set; }
		public int count { get; set; }
	}

	public class AppNewsItem {
		public string gid { get; set; }
		public string title { get; set; }
		public string url { get; set; }
		public bool is_external_url { get; set; }
		public string author { get; set; }
		public string contents { get; set; }
		public string feedlabel { get; set; }
		public ulong date { get; set; }
		public string feedname { get; set; }
		public int feed_type { get; set; }
		public uint appid { get; set; }
		public string[] tags { get; set; }
	}
}
