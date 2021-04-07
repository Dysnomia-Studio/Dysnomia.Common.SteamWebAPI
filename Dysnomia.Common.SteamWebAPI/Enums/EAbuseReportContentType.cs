namespace Dysnomia.Common.SteamWebAPI.Enums {
	/// <summary>
	/// Different content types that can be reported as abusive.
	///
	/// WARNING: These enum values MUST MATCH the values in Steam's ECommunityContentType!
	/// 
	/// Extracted From TF2 and Source Engine source code
	/// </summary>
	public enum EAbuseReportContentType {
		/// <summary>
		/// dummy ilegal value: the user has not made a selection
		/// </summary>
		k_EAbuseReportContentNoSelection = -1,
		/// <summary>
		/// we use this to mean "other"
		/// </summary>
		k_EAbuseReportContentUnspecified = 0,
		/// <summary>
		/// reset all community content
		/// </summary>
		k_EAbuseReportContentAll = 1,
		/// <summary>
		/// clear avatar image
		/// </summary>
		k_EAbuseReportContentAvatarImage = 2,
		/// <summary>
		/// reset profile text
		/// </summary>
		k_EAbuseReportContentProfileText = 3,
		/// <summary>
		/// delete web links
		/// </summary>
		k_EAbuseReportContentWebLinks = 4,
		/// <summary>
		/// ???
		/// </summary>
		k_EAbuseReportContentAnnouncement = 5,
		/// <summary>
		/// ???
		/// </summary>
		k_EAbuseReportContentEventText = 6,
		/// <summary>
		/// ???
		/// </summary>
		k_EAbuseReportContentCustomCSS = 7,
		/// <summary>
		/// delete community URL ID
		/// </summary>
		k_EAbuseReportContentProfileURL = 8,
		/// <summary>
		/// just comments this guy has written
		/// </summary>
		k_EAbuseReportContentComments = 9,
		/// <summary>
		/// persona name
		/// </summary>
		k_EAbuseReportContentPersonaName = 10,
		/// <summary>
		/// screenshot
		/// </summary>
		k_EAbuseReportContentScreenshot = 11,
		/// <summary>
		/// videos
		/// </summary>
		k_EAbuseReportContentVideo = 12,
		/// <summary>
		/// cheating
		/// </summary>
		k_EAbuseReportContentCheating = 13,
		/// <summary>
		/// Image stored in UGC --- the report is accusing the image of being offensive
		/// </summary>
		k_EAbuseReportContentUGCImage = 14,
		/// <summary>
		/// Abuse report actor has uploaded a UGC image to server as supporting documentation of their claim
		/// </summary>
		k_EAbuseReportContentActorUGCImage = 15,
	}
}
