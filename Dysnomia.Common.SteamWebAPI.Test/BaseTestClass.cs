using Microsoft.Extensions.Configuration;

namespace Dysnomia.Common.SteamWebAPI.Test {
	public abstract class BaseTestClass {
		protected const string PUBLISHER_INVALID_KEY = "INVALID";
		protected string PUBLISHER_KEY = "";

		protected const string WEBAPI_INVALID_KEY = "INVALID";
		protected string WEBAPI_KEY = "";

		protected const uint PUBLISHER_APPID = 1299430; // appId of Extortion
		protected const uint TF2_APPID = 440;

		protected ulong STEAMID = 0;
		protected const ulong INVALID_STEAMID = 0;

		public BaseTestClass() {
			var config = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json")
				.Build();

			PUBLISHER_KEY = config["PUBLISHER_KEY"];
			WEBAPI_KEY = config["WEBAPI_KEY"];
			STEAMID = ulong.Parse(config["STEAMID"]);
		}
	}
}
