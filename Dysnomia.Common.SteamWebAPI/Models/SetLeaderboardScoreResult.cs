namespace Dysnomia.Common.SteamWebAPI.Models {
    public class SetLeaderboardScoreResult {
        public SetLeaderboardScore result { get; set; }
    }

    public class SetLeaderboardScore {
        public int result { get; set; }
        public int leaderboard_entry_count { get; set; }
        public bool score_changed { get; set; }
        public int global_rank_previous { get; set; }
        public int global_rank_new { get; set; }
    }
}
