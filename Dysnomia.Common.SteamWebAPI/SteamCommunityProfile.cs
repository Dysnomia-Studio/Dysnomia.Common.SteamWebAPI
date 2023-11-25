using Dysnomia.Common.SteamWebAPI.Models;

using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Used to get data directly from profile in steamcommunity.com website
	/// </summary>
	public class SteamCommunityProfile : SteamWebAPIQuerier, ISteamCommunityProfile {
		public SteamCommunityProfile(IHttpClientFactory clientFactory) : base(clientFactory) {
		}

		public async Task<SteamCommunityProfileModel> GetProfile(string id) {
			var str = await this.GetStringAsync(
				string.Format(
					"https://steamcommunity.com/profiles/{0}/games?tab=all&xml=1",
					id
				)
			);

			var reader = XmlReader.Create(new MemoryStream(Encoding.ASCII.GetBytes(str.Trim())), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
			return new XmlSerializer(typeof(SteamCommunityProfileModel)).Deserialize(reader) as SteamCommunityProfileModel;
		}
	}
}
