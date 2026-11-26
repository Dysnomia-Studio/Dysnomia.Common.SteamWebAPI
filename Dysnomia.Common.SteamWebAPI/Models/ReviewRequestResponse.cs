namespace Dysnomia.Common.SteamWebAPI.Models {
    public class ReviewRequestResponse {
        public Response response { get; set; }
    }

    public class Response {
        public Query_Summary? query_summary { get; set; }
        public Review[]? reviews { get; set; }
        public string? cursor { get; set; }
        public int total_matching { get; set; }
    }

    public class Query_Summary {
        public int num_reviews { get; set; }
        public int review_score { get; set; }
        public string review_score_desc { get; set; }
        public int total_positive { get; set; }
        public int total_negative { get; set; }
        public int total_reviews { get; set; }
    }

    public class Review {
        public string recommendationid { get; set; }
        public Author author { get; set; }
        public string language { get; set; }
        public string review { get; set; }
        public int timestamp_created { get; set; }
        public int timestamp_updated { get; set; }
        public bool voted_up { get; set; }
        public int votes_up { get; set; }
        public int votes_funny { get; set; }
        public float weighted_vote_score { get; set; }
        public int comment_count { get; set; }
        public bool steam_purchase { get; set; }
        public bool received_for_free { get; set; }
        public bool written_during_early_access { get; set; }
        public string developer_response { get; set; }
        public int timestamp_dev_responded { get; set; }
        public bool primarily_steam_deck { get; set; }
        public bool refunded { get; set; }
    }

    public class Author {
        public string steamid { get; set; }
        public int num_reviews { get; set; }
        public int playtime_forever { get; set; }
        public int playtime_last_two_weeks { get; set; }
        public int playtime_at_review { get; set; }
        public int last_played { get; set; }
    }

}
