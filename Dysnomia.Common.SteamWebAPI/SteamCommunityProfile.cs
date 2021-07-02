using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	/// <summary>
	/// Used to get data directly from profile in steamcommunity.com website
	/// </summary>
	public class SteamCommunityProfile : SteamWebAPIQuerier, ISteamCommunityProfile {
		public async Task<SteamCommunityProfileModel> GetProfile(string id) {
			using var client = new HttpClient();

			var res = await client.GetAsync(
				string.Format(
					"https://steamcommunity.com/id/{0}/games?tab=all&xml=1",
					id
				)
			);
			var str = await res.Content.ReadAsStringAsync();

			var reader = XmlReader.Create(new MemoryStream(Encoding.ASCII.GetBytes(str.Trim())), new XmlReaderSettings() { ConformanceLevel = ConformanceLevel.Document });
			return new XmlSerializer(typeof(SteamCommunityProfileModel)).Deserialize(reader) as SteamCommunityProfileModel;
		}
	}
}
