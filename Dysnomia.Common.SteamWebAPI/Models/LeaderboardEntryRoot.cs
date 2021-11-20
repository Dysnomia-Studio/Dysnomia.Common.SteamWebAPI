using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
    public class LeaderboardEntryRoot {
        public LeaderboardEntryInformation leaderboardEntryInformation { get; set; }
    }

    public class LeaderboardEntryInformation {
        public int appID { get; set; }
        public int leaderboardID { get; set; }
        public int totalLeaderBoardEntryCount { get; set; }
        public IEnumerable<LeaderboardEntry> leaderboardEntries { get; set; }
    }

    public class LeaderboardEntry {
        public string steamID { get; set; }
        public int score { get; set; }
        public uint rank { get; set; }
        public string ugcid { get; set; }
    }
}
