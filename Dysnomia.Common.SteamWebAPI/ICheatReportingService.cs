using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// This service allows your game to report cheats and cheaters to the VAC system and provides the toolset behind the Game Bans system. It enables two independent workflows for detecting and managing cheating in your game:
	/// - Gather community reports of cheating and request bans/suspensions based upon this information.
	/// - Submit detailed information about known cheat software to the VAC system. Once processed, this information will be used to automatically detect and ban players using known cheats.
	/// To use this interface you must first opt in to VAC support. This can be done from the Anti-Cheat Configuration page in the App Admin panel.
	/// 
	/// https://partner.steamgames.com/doc/webapi/ICheatReportingService
	/// </summary>
	public interface ICheatReportingService {
		/// <summary>
		/// ReportPlayerCheating is designed to gather community reports of cheating, where one player reports another player within the game.
		///
		/// It is intended for unreliable data from peers in the game(semi-trusted sources). The back-end that reports the data should ensure that both parties are authenticated,
		/// but the data in itself is treated as hearsay.Optional parameters may be used to encode the type of cheating that is suspected or additional evidence(an identifier pointing
		/// to the match/demo for further review).
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">The Steam ID of the user who is being reported for cheating.</param>
		/// <param name="appid">The App ID for the game.</param>
		/// <param name="steamidreporter">(Optional) The Steam ID of the user or game server who is reporting the cheating.</param>
		/// <param name="appdata">(Optional) App specific data about the type of cheating set by developer. (ex 1 = Aimbot, 2 = Wallhack, 3 = Griefing)</param>
		/// <param name="heuristic">(Optional) Extra information about the source of the cheating - was it a heuristic.</param>
		/// <param name="detection">(Optional) Extra information about the source of the cheating - was it a detection.</param>
		/// <param name="playerreport">(Optional) Extra information about the source of the cheating - was it a player report.</param>
		/// <param name="noreportid">(Optional) Don't return reportid. This should only be passed if you don't intend to issue a ban based on this report.</param>
		/// <param name="gamemode">(Optional) Extra information about state of game - was it a specific type of game play or game mode. (0 = generic)</param>
		/// <param name="suspicionstarttime">(Optional) Extra information indicating how far back the game thinks is interesting for this user. Unix epoch time (time since Jan 1st, 1970).</param>
		/// <param name="severity">(Optional) Level of severity of bad action being reported. Scale set by developer.</param>
		/// <returns></returns>
		Task<string> ReportPlayerCheating(string key, ulong steamid, uint appid, ulong? steamidreporter, ulong? appdata, bool? heuristic, bool? detection, bool? playerreport, bool? noreportid, uint? gamemode, uint? suspicionstarttime, uint? severity);

		/// <summary>
		/// ReportPlayerCheating is designed to gather community reports of cheating, where one player reports another player within the game.
		///
		/// It is intended for unreliable data from peers in the game(semi-trusted sources). The back-end that reports the data should ensure that both parties are authenticated,
		/// but the data in itself is treated as hearsay.Optional parameters may be used to encode the type of cheating that is suspected or additional evidence(an identifier pointing
		/// to the match/demo for further review).
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">The Steam ID of the user who is being reported for cheating.</param>
		/// <param name="appid">The App ID for the game.</param>
		/// <returns></returns>
		Task<string> ReportPlayerCheating(string key, ulong steamid, uint appid);

		/// <summary>
		/// Requests a game ban on a specific player.
		/// 
		/// This is designed to be used after the incidents from ReportPlayerCheating have been reviewed and cheating has been confirmed.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">Steam ID of the user who is reported as cheating.</param>
		/// <param name="appid">The appid of the game.</param>
		/// <param name="reportid">The reportid originally used to report cheating.</param>
		/// <param name="cheatDescription">Text describing cheating infraction.</param>
		/// <param name="duration">Ban duration requested in seconds. (duration 0 will issue infinite - less than a year is a suspension and not visible on profile)</param>
		/// <param name="delayban">Delay the ban according to default ban delay rules.</param>
		/// <param name="flags">Additional information about the ban request. (Unused)</param>
		/// <returns></returns>
		Task<string> RequestPlayerGameBan(string key, ulong steamid, uint appid, ulong? reportid, string cheatDescription, uint? duration, bool? delayban, uint? flags);

		/// <summary>
		/// Requests a game ban on a specific player.
		/// 
		/// This is designed to be used after the incidents from ReportPlayerCheating have been reviewed and cheating has been confirmed.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">Steam ID of the user who is reported as cheating.</param>
		/// <param name="appid">The appid of the game.</param>
		/// <returns></returns>
		Task<string> RequestPlayerGameBan(string key, ulong steamid, uint appid);

		/// <summary>
		/// Get a list of cheating reports submitted for this app.
		/// 
		/// Used to gather the cheating reports so that they may be reviewed and a determination made.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">The App ID for the game.</param>
		/// <param name="timeend">The end of the time range. Formatted as Unix epoch time (time since Jan 1st, 1970).</param>
		/// <param name="timebegin">The beginning of the time range. Formatted as Unix epoch time (time since Jan 1st, 1970).</param>
		/// <param name="reportidadmin">Minimum reportID to include. (can pass 0 - end of previous report range)</param>
		/// <param name="includereports">(Optional) Include reports. If false includebans must be true.</param>
		/// <param name="includebans">(Optional) Include ban requests? If false includereports must be true.</param>
		/// <param name="steamid">(Optional) Query just for this Steam ID.</param>
		/// <returns></returns>
		Task<string> GetCheatingReports(string key, uint appid, uint timeend, uint timebegin, ulong reportidadmin, bool? includereports, bool? includebans, ulong? steamid);
	}
}
