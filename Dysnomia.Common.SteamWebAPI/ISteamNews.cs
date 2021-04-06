using System;
using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Provides access to the Steam News functionality.
	/// https://partner.steamgames.com/doc/webapi/ISteamNews
	/// </summary>
	public interface ISteamNews {
		/// <summary>
		/// Get the news for the specified app.
		/// </summary>
		/// <param name="appid">AppID to retrieve news for</param>
		/// <param name="maxlength">Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit.</param>
		/// <param name="enddate">Retrieve posts earlier than this date (unix epoch timestamp)</param>
		/// <param name="count"># of posts to retrieve (default 20)</param>
		/// <param name="feeds">Comma-seperated list of feed names to return news for</param>
		/// <returns></returns>
		Task<AppNews> GetNewsForApp(uint appid, uint? maxlength, uint? enddate, uint? count, string feeds);
		/// <summary>
		/// Get the news for the specified app.
		/// </summary>
		/// <param name="appid">AppID to retrieve news for</param>
		/// <param name="maxlength">Maximum length for the content to return, if this is 0 the full content is returned, if it's less then a blurb is generated to fit.</param>
		/// <param name="enddate">Retrieve posts earlier than this date (unix epoch timestamp)</param>
		/// <param name="count"># of posts to retrieve (default 20)</param>
		/// <param name="feeds">Comma-seperated list of feed names to return news for</param>
		/// <returns></returns>
		Task<AppNews> GetNewsForApp(uint appid, uint? maxlength, DateTime enddate, uint? count, string feeds);
		/// <summary>
		/// Get the news for the specified app.
		/// </summary>
		/// <param name="appid">AppID to retrieve news for</param>
		/// <returns></returns>
		Task<AppNews> GetNewsForApp(uint appid);

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
		Task<AppNews> GetNewsForAppAuthed(string key, uint appid, uint? maxlength, uint? enddate, uint? count, string feeds);

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
		Task<AppNews> GetNewsForAppAuthed(string key, uint appid, uint? maxlength, DateTime enddate, uint? count, string feeds);

		/// <summary>
		/// Get the news for the specified app. Publisher only version that can return info for unreleased games.
		/// </summary>
		/// <param name="key">Steamworks Web API publisher authentication key.</param>
		/// <param name="appid">AppID to retrieve news for</param>
		/// <returns></returns>
		Task<AppNews> GetNewsForAppAuthed(string key, uint appid);
	}
}
