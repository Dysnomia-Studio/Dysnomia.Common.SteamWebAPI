namespace Dysnomia.Common.SteamWebAPI.Enums {
	/// <summary>
	/// Types of reasons why a violation report was issued
	/// 
	/// WARNING: These enum values MUST MATCH the values in Steam's EAbuseReportType!
	/// 
	/// Extracted From TF2 & Source Engine source code
	/// </summary>
	public enum EAbuseReportType {
		/// <summary>
		/// dummy ilegal value: the user has not made a selection
		/// </summary>
		k_EAbuseReportTypeNoSelection = -1,
		/// <summary>
		/// ???
		/// </summary>
		k_EAbuseReportTypeUnspecified = 0,
		/// <summary>
		/// just not ok to post
		/// </summary>
		k_EAbuseReportTypeInappropriate = 1,
		/// <summary>
		/// prohibited by EULA or general law
		/// </summary>
		k_EAbuseReportTypeProhibited = 2,
		/// <summary>
		/// excessive spamming
		/// </summary>
		k_EAbuseReportTypeSpamming = 3,
		/// <summary>
		/// unwanted advertisement
		/// </summary>
		k_EAbuseReportTypeAdvertisement = 4,
		/// <summary>
		/// content data attempts to exploit code issue
		/// </summary>
		k_EAbuseReportTypeExploit = 5,
		/// <summary>
		/// user/group is impersonating an official contact
		/// </summary>
		k_EAbuseReportTypeSpoofing = 6,
		/// <summary>
		/// bad language
		/// </summary>
		k_EAbuseReportTypeLanguage = 7,
		/// <summary>
		/// any kind of adult material, references, etc
		/// </summary>
		k_EAbuseReportTypeAdultContent = 8,
		/// <summary>
		/// harassment, discrimination, racism, etc
		/// </summary>
		k_EAbuseReportTypeHarassment = 9,
		/// <summary>
		/// cheating
		/// </summary>
		k_EAbuseReportTypeCheating = 10,
	}
}
