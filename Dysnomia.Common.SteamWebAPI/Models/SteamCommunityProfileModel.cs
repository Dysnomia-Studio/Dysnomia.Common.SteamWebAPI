using System;
using System.Globalization;
using System.Xml.Serialization;

namespace Dysnomia.Common.SteamWebAPI.Models {
	[XmlRoot("gamesList")]
	public class SteamCommunityProfileModel {
		public ulong steamID64 { get; set; }
		public string steamID { get; set; }

		[XmlArray("games")]
		[XmlArrayItem(typeof(SteamCommunityProfileModelGame), ElementName = "game")]
		public SteamCommunityProfileModelGame[] games { get; set; }
	}

	[Serializable()]
	public class SteamCommunityProfileModelGame {
		[XmlElement()]
		public ulong appID { get; set; }
		[XmlElement()]
		public string name { get; set; }
		[XmlElement()]
		public string logo { get; set; }
		[XmlElement()]
		public string storeLink { get; set; }
		[XmlElement()]
		public string statsLink { get; set; }
		[XmlElement()]
		public string globalStatsLink { get; set; }

		[XmlElement()]
		public string hoursLast2WeeksStr { get; set; } // We need string because serializer doesn't like steam number format
		[XmlIgnore]
		public decimal hoursLast2Weeks => decimal.Parse(hoursLast2WeeksStr, CultureInfo.GetCultureInfo("en-US"));

		[XmlElement("hoursOnRecord")]
		public string hoursOnRecordStr { get; set; }
		[XmlIgnore]
		public decimal hoursOnRecord => decimal.Parse(hoursOnRecordStr, CultureInfo.GetCultureInfo("en-US"));
	}
}
