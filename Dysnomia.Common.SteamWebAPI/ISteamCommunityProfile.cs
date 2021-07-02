using System.Threading.Tasks;

using Dysnomia.Common.SteamWebAPI.Models;

namespace Dysnomia.Common.SteamWebAPI {
	public interface ISteamCommunityProfile {
		Task<SteamCommunityProfileModel> GetProfile(string id);
	}
}
