using Dysnomia.Common.SteamWebAPI.Enums;
using Dysnomia.Common.SteamWebAPI.Models.SteamCommunityGroupMemberList;

using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

using ECommunityContentType = Dysnomia.Common.SteamWebAPI.Enums.EAbuseReportContentType;

namespace Dysnomia.Common.SteamWebAPI {
    /// <summary>
    /// Provides restricted access to Steam Community features.
    /// https://partner.steamgames.com/doc/webapi/ISteamCommunity
    /// and access to https://steamcommunity.com/ APIs
    /// </summary>
    public class SteamCommunity : SteamWebAPIQuerier, ISteamCommunity {
        public SteamCommunity(IHttpClientFactory clientFactory) : base(clientFactory) {
        }

        /// <summary>
        /// Allows publishers to report users who are behaving badly on their community hub.
        /// </summary>
        /// <param name="key">Steamworks Web API publisher authentication key.</param>
        /// <param name="steamidActor">SteamID of user doing the reporting</param>
        /// <param name="steamidTarget">SteamID of the entity being accused of abuse</param>
        /// <param name="appid">AppID to check for ownership</param>
        /// <param name="abuseType">Abuse type code (see EAbuseReportType enum)</param>
        /// <param name="contentType">Content type code (see ECommunityContentType enum)</param>
        /// <param name="description">Narrative from user</param>
        /// <param name="gid">GID of related record (depends on content type)</param>
        /// <returns></returns>
        public async Task<string> ReportAbuse(string key, ulong steamidActor, ulong steamidTarget, uint appid, EAbuseReportType abuseType, ECommunityContentType contentType, string description, ulong? gid) {
            string gidStr = "";
            if (gid != null) {
                gidStr = "&gid=" + gid;
            }

            return await this.PostStringAsync(
                string.Format(
                    "{0}/ISteamCommunity/ReportAbuse/v1/?key={1}&steamidActor={2}&steamidTarget={3}&appid={4}&abuseType={5}&contentType={6}&description={7}{8}",
                    API_URL, key, steamidActor, steamidTarget, appid, abuseType, contentType, description, gidStr
                ), new StringContent("")
            );
        }

        /// <summary>
        /// Get an app group member list, it can be used to get the follower count of an app for example
        /// </summary>
        /// <param name="appId">AppID to query</param>
        /// <param name="page">Page to query</param>
        /// <returns></returns>
        public async Task<memberList> GetAppGroupMemberListAsync(ulong appId, uint page = 1) {
            var xmlContent = await this.GetStringAsync($"https://steamcommunity.com/games/{appId}/memberslistxml/?xml=1&p={page}");
            XmlSerializer serializer = new XmlSerializer(typeof(memberList));
            using TextReader reader = new StringReader(xmlContent);

            return (memberList)serializer.Deserialize(reader);
        }
    }
}
