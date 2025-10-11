using System.Threading.Tasks;

using Xunit;

namespace Dysnomia.Common.SteamWebAPI.Test {
    public class StoreServiceTest : BaseTestClass {
        protected readonly IStoreService storeService;

        public StoreServiceTest(IStoreService storeService) {
            this.storeService = storeService;
        }

        [Fact]
        public async Task GetAppList() {
            var results = await storeService.GetAppList(WEBAPI_KEY);
            Assert.NotEmpty(results.apps);
        }
    }
}