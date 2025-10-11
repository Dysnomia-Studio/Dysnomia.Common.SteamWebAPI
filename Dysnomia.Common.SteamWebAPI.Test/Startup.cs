using Microsoft.Extensions.DependencyInjection;

namespace Dysnomia.Common.SteamWebAPI.Test {
    public class Startup {
        public Startup() {
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {
            services.AddTransient<IBroadcastService, BroadcastService>();
            services.AddTransient<ICheatReportingService, CheatReportingService>();
            services.AddTransient<IPlayerService, PlayerService>();
            services.AddTransient<ISteamApps, SteamApps>();
            services.AddTransient<ISteamCommunity, SteamCommunity>();
            services.AddTransient<ISteamCommunityProfile, SteamCommunityProfile>();
            services.AddTransient<ISteamLeaderboard, SteamLeaderboard>();
            services.AddTransient<ISteamNews, SteamNews>();
            services.AddTransient<ISteamPartner, SteamPartner>();
            services.AddTransient<ISteamStore, SteamStore>();
            services.AddTransient<ISteamUser, SteamUser>();
            services.AddTransient<ISteamUserAuth, SteamUserAuth>();
            services.AddTransient<ISteamUserStats, SteamUserStats>();
            services.AddTransient<IStoreService, StoreService>();

            services.AddHttpClient();
        }
    }
}
