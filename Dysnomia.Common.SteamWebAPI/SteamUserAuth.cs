using System.Net.Http;
using System.Threading.Tasks;

namespace Dysnomia.Common.SteamWebAPI {
    /// <summary>
    /// Used to access information about users.
    /// https://partner.steamgames.com/doc/webapi/ISteamUserAuth
    /// </summary>
    public class SteamUserAuth(IHttpClientFactory clientFactory) : SteamWebAPIQuerier(clientFactory), ISteamUserAuth {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="steamid">Should be the users steamid, unencrypted.</param>
        /// <param name="sessionkey">Should be a 32 byte random blob of data, which is then encrypted with RSA using the Steam system's public key. Randomness is important here for security.</param>
        /// <param name="encrypted_loginkey">Should be the users hashed loginkey, AES encrypted with the sessionkey.</param>
        /// <returns></returns>
        public async Task<string> AuthenticateUser(ulong steamid, string sessionkey, string encrypted_loginkey) {
            return await this.PostStringAsync(
                string.Format(
                    "{0}/IBroadcastService/ISteamUserAuth/AuthenticateUser/v1/?steamid={1}&sessionkey={2}&encrypted_loginkey={3}",
                    API_URL, steamid, sessionkey, encrypted_loginkey
                ), new StringContent("")
            );
        }

        /// <summary>
        /// Authenticate the user ticket against Valve APIs, used to validate tickets emited from ISteamUser::GetAuthTicketForWebApi() on clientside
        /// </summary>
        /// <param name="key">Steamworks Web API publisher authentication key</param>
        /// <param name="appid">appid of game</param>
        /// <param name="ticket">Convert the ticket from GetAuthSessionTicket from binary to hex into an appropriately sized byte character array and pass the result in as this ticket parameter.</param>
        /// <param name="identity">Identifying string passed as a parameter to GetAuthTicketForWebApi when the ticket was created, used to identify the entity calling this webapi. If this identity string is passed, only tickets created with that parameter will successfully authenticate.</param>
        /// <returns>The user's 64-bit SteamID if the user's ticket is valid</returns>
        public async Task<string> AuthenticateUserTicket(string key, uint appid, string ticket, string identity) {
            return await this.GetStringAsync(
                string.Format(
                    "{0}/ISteamUserAuth/AuthenticateUserTicket/v1/?key={1}&appid={2}&ticket={3}&identity={4}",
                    API_URL, key, appid, ticket, identity
                )
            );
        }
    }
}
