using System.Collections.Generic;

namespace Dysnomia.Common.SteamWebAPI.Models {
    public class LeaderBoardForGameRoot {
        public int result { get; set; }
        public IEnumerable<LeaderBoardForGame> leaderboards { get; set; }
    }

    public class LeaderBoardForGame {
        public int id { get; set; }
        public string name { get; set; }
        public int entries { get; set; }
        public string sortmethod { get; set; }
        public string displaytype { get; set; }
        public bool onlytrustedwrites { get; set; }
        public bool onlyfriendsreads { get; set; }
    }
}
