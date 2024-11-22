using Dysnomia.Common.SteamWebAPI.Enums;
using Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList;

using System.Threading.Tasks;

using ECommunityContentType = Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType;

namespace Dysnomia.Common.SteamWebAPI {
    /// <summary>
    /// Provides restricted access to Steam Community features.
    /// https://partner.steamgames.com/doc/webapi/ISteamCommunity
    /// and access to https://steamcommunity.com/ APIs
    /// </summary>
    public interface ISteamCommunity {
        /// <summary>
        /// Allows publishers to report users who are behaving badly on their community hub.
        /// </summary>
        /// <param name="key">Steamworks Web API publisher authentication key.</param>
        /// <param name="steamidActor">SteamID of user doing the reporting</param>
        /// <param name="steamidTarget">SteamID of the entity being accused of abuse</param>
        /// <param name="appid">AppID to check for ownership</param>
        /// <param name="abuseType">Abuse type code</param>
        /// <param name="contentType">Content type code</param>
        /// <param name="description">Narrative from user</param>
        /// <param name="gid">GID of related record (depends on content type)</param>
        /// <returns></returns>
        Task<string> ReportAbuse(string key, ulong steamidActor, ulong steamidTarget, uint appid, EAbuseReportType abuseType, ECommunityContentType contentType, string description, ulong? gid);

        /// <summary>
        /// Get an app group member list, it can be used to get the follower count of an app for example
        /// </summary>
        /// <param name="appId">AppID to query</param>
        /// <param name="page">Page to query</param>
        /// <returns></returns>
        Task<memberList> GetAppGroupMemberListAsync(ulong appId, uint page = 1);
    }
}
