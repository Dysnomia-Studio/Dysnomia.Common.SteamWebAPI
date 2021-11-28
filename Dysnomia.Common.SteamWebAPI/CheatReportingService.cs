using System.Net.Http;
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
	public class CheatReportingService : SteamWebAPIQuerier, ICheatReportingService {
		public CheatReportingService(IHttpClientFactory clientFactory) : base(clientFactory) {
		}

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
		public async Task<string> ReportPlayerCheating(string key, ulong steamid, uint appid, ulong? steamidreporter, ulong? appdata, bool? heuristic, bool? detection, bool? playerreport, bool? noreportid, uint? gamemode, uint? suspicionstarttime, uint? severity) {
			string steamidreporterStr = "";
			if (steamidreporter != null) {
				steamidreporterStr = "&reportidmin=" + steamidreporter;
			}

			string appdataStr = "";
			if (appdata != null) {
				appdataStr = "&appdata=" + appdata;
			}

			string heuristicStr = "";
			if (heuristic != null) {
				heuristicStr = "&heuristic=" + heuristic;
			}

			string detectionStr = "";
			if (detection != null) {
				detectionStr = "&detection=" + detection;
			}

			string playerreportStr = "";
			if (playerreport != null) {
				playerreportStr = "&playerreport=" + playerreport;
			}

			string noreportidStr = "";
			if (noreportid != null) {
				noreportidStr = "&noreportid=" + noreportid;
			}

			string gamemodeStr = "";
			if (gamemode != null) {
				gamemodeStr = "&gamemode=" + gamemode;
			}

			string suspicionstarttimeStr = "";
			if (suspicionstarttime != null) {
				suspicionstarttimeStr = "&suspicionstarttime=" + suspicionstarttime;
			}

			string severityStr = "";
			if (severity != null) {
				severityStr = "&severity=" + severity;
			}

			return await this.PostString(
				string.Format(
					"{0}/ICheatReportingService/ReportPlayerCheating/v1/?key={1}&=steamid{2}&appid={3}{4}{5}{6}{7}{8}{9}{10}{11}{12}",
					API_URL, key, steamid, appid, steamidreporterStr, appdataStr, heuristicStr, detectionStr, playerreportStr, noreportidStr, gamemodeStr, suspicionstarttimeStr, severityStr
				),
				new StringContent("")
			);
		}

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
		public async Task<string> ReportPlayerCheating(string key, ulong steamid, uint appid) {
			return await ReportPlayerCheating(key, steamid, appid, null, null, null, null, null, null, null, null, null);
		}

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
		public async Task<string> RequestPlayerGameBan(string key, ulong steamid, uint appid, ulong? reportid, string cheatDescription, uint? duration, bool? delayban, uint? flags) {
			string reportidStr = "";
			if (reportid != null) {
				reportidStr = "&reportid=" + reportid;
			}

			string cheatDescriptionStr = "";
			if (cheatDescription != null) {
				cheatDescriptionStr = "&cheatDescription=" + cheatDescription;
			}

			string durationStr = "";
			if (duration != null) {
				durationStr = "&duration=" + duration;
			}

			string delaybanStr = "";
			if (delayban != null) {
				delaybanStr = "&delayban=" + delayban;
			}

			string flagsStr = "";
			if (flags != null) {
				flagsStr = "&flags=" + flags;
			}

			return await this.PostString(
				string.Format(
					"{0}/ICheatReportingService/RequestPlayerGameBan/v1/?key={1}&=steamid{2}&appid={3}{4}{5}{6}{7}{8}",
					API_URL, key, steamid, appid, reportidStr, cheatDescriptionStr, durationStr, delaybanStr, flagsStr
				),
				new StringContent("")
			);
		}

		/// <summary>
		/// Requests a game ban on a specific player.
		/// 
		/// This is designed to be used after the incidents from ReportPlayerCheating have been reviewed and cheating has been confirmed.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">Steam ID of the user who is reported as cheating.</param>
		/// <param name="appid">The appid of the game.</param>
		/// <returns></returns>
		public async Task<string> RequestPlayerGameBan(string key, ulong steamid, uint appid) {
			return await RequestPlayerGameBan(key, steamid, appid, null, null, null, null, null);
		}

		/// <summary>
		/// Remove a game ban on a player.
		///
		/// This is used if a Game ban is determined to be a false positive.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="steamid">Steam ID of the user who is reported as cheating.</param>
		/// <param name="appid">The appid of the game.</param>
		/// <returns></returns>
		public async Task<string> RemovePlayerGameBan(string key, ulong steamid, uint appid) {
			return await this.PostString(
				string.Format(
					"{0}/ICheatReportingService/RemovePlayerGameBan/v1/?key={1}&=steamid{2}&appid={3}",
					API_URL, key, steamid, appid
				),
				new StringContent("")
			);
		}

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
		public async Task<string> GetCheatingReports(string key, uint appid, uint timeend, uint timebegin, ulong reportidadmin, bool? includereports, bool? includebans, ulong? steamid) {
			string includereportsStr = "";
			if (includereports != null) {
				includereportsStr = "&includereports=" + includereports;
			}

			string includebansStr = "";
			if (includebans != null) {
				includebansStr = "&includebans=" + includebans;
			}

			string steamidStr = "";
			if (steamid != null) {
				steamidStr = "&steamid=" + steamid;
			}

			return await this.GetString(
				string.Format(
					"{0}/ICheatReportingService/GetCheatingReports/v1/?key={1}{2}&appid={3}&timeend={4}&timebegin={5}&reportidadmin={6}{7}{8}",
					API_URL, key, steamidStr, appid, timeend, timebegin, reportidadmin, includereportsStr, includebansStr
				)
			);
		}

		// TODO: implement ReportCheatData
		// TODO: implement RequestVacStatusForUser
		// TODO: implement StartSecureMultiplayerSession
		// TODO: implement EndSecureMultiplayerSession
	}
}
