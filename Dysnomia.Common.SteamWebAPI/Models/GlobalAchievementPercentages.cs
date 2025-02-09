using Dysnomia.Common.WebAPIWrapper.Helpers;

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Dysnomia.Common.SteamWebAPI.Models {
    public class GlobalAchievementPercentagesRoot {
        public GlobalAchievementPercentagesList achievementpercentages { get; set; }
    }

    public class GlobalAchievementPercentagesList {
        public IList<GlobalAchievementPercentages> achievements { get; set; }
    }

    public class GlobalAchievementPercentages {
        public string name { get; set; }
        [JsonConverter(typeof(StringToFloatConverter))]
        public float percent { get; set; }
    }
}
