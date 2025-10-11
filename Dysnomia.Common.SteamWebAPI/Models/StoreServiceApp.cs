using System;
using System.Collections.Generic;
using System.Text;

namespace Dysnomia.Common.SteamWebAPI.Models
{
    public class StoreServiceAppResponse
    {
        public StoreServiceApp[] apps { get; set; }
        public bool have_more_results { get; set; }
        public int last_appid { get; set; }
    }

    public class StoreServiceApp
    {
        public int appid { get; set; }
        public string name { get; set; }
        public int last_modified { get; set; }
        public int price_change_number { get; set; }
    }
}