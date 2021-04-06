using System;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Provides access to the Steam News functionality.
	/// https://partner.steamgames.com/doc/webapi/ISteamNews
	/// </summary>
	public class SteamNews : SteamWebAPIQuerier, ISteamNews {
		/// <summary>
		/// Get the news for the specified app.
		/// </summary>
		/// <param name="appid">AppID to retrieve news for</param>
		/// <param name="maxlength">Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit.</param>
		/// <param name="enddate">Retrieve posts earlier than this date (unix epoch timestamp)</param>
		/// <param name="count"># of posts to retrieve (default 20)</param>
		/// <param name="feeds">Comma-seperated list of feed names to return news for</param>
		/// <returns></returns>
		public async Task<AppNews> GetNewsForApp(uint appid, uint? maxlength, uint? enddate, uint? count, string feeds) {
			var maxLengthStr = "";
			if (maxlength != null) {
				maxLengthStr = "&maxlength=" + maxlength;
			}

			var enddateStr = "";
			if (enddate != null) {
				enddateStr = "&maxlength=" + enddate;
			}

			var countStr = "";
			if (count != null) {
				countStr = "&maxlength=" + count;
			}

			var feedsStr = "";
			if (feeds != null) {
				feedsStr = "&maxlength=" + feeds;
			}

			return (await this.Get<AppNewsRoot>(
				string.Format(
					"{0}/ISteamNews/GetNewsForApp/v2/?appid={1}{2}{3}{4}{5}",
					API_URL, appid, maxLengthStr, enddateStr, countStr, feedsStr
				)
			)).appnews;
		}

		/// <summary>
		/// Get the news for the specified app.
		/// </summary>
		/// <param name="appid">AppID to retrieve news for</param>
		/// <param name="maxlength">Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit.</param>
		/// <param name="enddate">Retrieve posts earlier than this date (unix epoch timestamp)</param>
		/// <param name="count"># of posts to retrieve (default 20)</param>
		/// <param name="feeds">Comma-seperated list of feed names to return news for</param>
		/// <returns></returns>
		public async Task<AppNews> GetNewsForApp(uint appid, uint? maxlength, DateTime enddate, uint? count, string feeds) {
			return await GetNewsForApp(appid, maxlength, (uint)((DateTimeOffset)enddate).ToUnixTimeSeconds(), count, feeds);
		}

		/// <summary>
		/// Get the news for the specified app.
		/// </summary>
		/// <param name="appid">AppID to retrieve news for</param>
		/// <returns></returns>
		public async Task<AppNews> GetNewsForApp(uint appid) {
			return await GetNewsForApp(appid, null, null, null, null);
		}

		/// <summary>
		/// Get the news for the specified app. Publisher only version that can return info for unreleased games.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">AppID to retrieve news for</param>
		/// <param name="maxlength">Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit.</param>
		/// <param name="enddate">Retrieve posts earlier than this date (unix epoch timestamp)</param>
		/// <param name="count"># of posts to retrieve (default 20)</param>
		/// <param name="feeds">Comma-seperated list of feed names to return news for</param>
		/// <returns></returns>
		public async Task<AppNews> GetNewsForAppAuthed(string key, uint appid, uint? maxlength, uint? enddate, uint? count, string feeds) {
			var maxLengthStr = "";
			if (maxlength != null) {
				maxLengthStr = "&maxlength=" + maxlength;
			}

			var enddateStr = "";
			if (enddate != null) {
				enddateStr = "&maxlength=" + enddate;
			}

			var countStr = "";
			if (count != null) {
				countStr = "&maxlength=" + count;
			}

			var feedsStr = "";
			if (feeds != null) {
				feedsStr = "&maxlength=" + feeds;
			}

			return (await this.Get<AppNewsRoot>(
				string.Format(
					"{0}/ISteamNews/GetNewsForAppAuthed/v2/?key={1}&appid={2}{3}{4}{5}{6}",
					API_URL, key, appid, maxLengthStr, enddateStr, countStr, feedsStr
				)
			)).appnews;
		}

		/// <summary>
		/// Get the news for the specified app. Publisher only version that can return info for unreleased games.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">AppID to retrieve news for</param>
		/// <param name="maxlength">Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit.</param>
		/// <param name="enddate">Retrieve posts earlier than this date (unix epoch timestamp)</param>
		/// <param name="count"># of posts to retrieve (default 20)</param>
		/// <param name="feeds">Comma-seperated list of feed names to return news for</param>
		/// <returns></returns>
		public async Task<AppNews> GetNewsForAppAuthed(string key, uint appid, uint? maxlength, DateTime enddate, uint? count, string feeds) {
			return await GetNewsForAppAuthed(key, appid, maxlength, (uint)((DateTimeOffset)enddate).ToUnixTimeSeconds(), count, feeds);
		}

		/// <summary>
		/// Get the news for the specified app. Publisher only version that can return info for unreleased games.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">AppID to retrieve news for</param>
		/// <returns></returns>
		public async Task<AppNews> GetNewsForAppAuthed(string key, uint appid) {
			return await GetNewsForAppAuthed(key, appid, null, null, null, null);
		}
	}
}
