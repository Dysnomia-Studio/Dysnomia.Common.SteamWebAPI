using Microsoft.Extensions.Configuration;

namespace Dysnomia.Common.SteamWebAPI.Test
{
    public abstract class BaseTestClass
    {
        protected const string PUBLISHER_INVALID_KEY = "INVALID";
        protected string PUBLISHER_KEY = "";

        protected const string WEBAPI_INVALID_KEY = "INVALID";
        protected string WEBAPI_KEY = "";

        protected const uint PUBLISHER_APPID = 1299430; // appId of Extortion
        protected const uint TF2_APPID = 440;

        protected const uint PUBLISHER_APPID_WITH_LEADERBOARD = 1730540; // appId of Alchemistry
        protected const uint PUBLISHER_APP_LEADERBOARDID = 7474879; // leaderboard of Alchemistry

        protected ulong STEAMID = 0;
        protected const ulong INVALID_STEAMID = 0;

        protected string STEAMPROFILE;

        public BaseTestClass()
        {
            var config = new ConfigurationBuilder()
                .AddUserSecrets<BaseTestClass>()
                .AddJsonFile("appsettings.json")
                .Build();

            PUBLISHER_KEY = config["PUBLISHER_KEY"];
            WEBAPI_KEY = config["WEBAPI_KEY"];
            STEAMID = ulong.Parse(config["STEAMID"]);
            STEAMPROFILE = config["STEAMPROFILE"];
        }
    }
}
