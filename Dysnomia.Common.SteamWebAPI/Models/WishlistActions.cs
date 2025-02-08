using System;
using System.Globalization;
using System.Linq;

namespace Dysnomia.Common.SteamWebAPI.Models {
    public class WishlistActions {
        public DateOnly Date { get; set; }
        public string Game { get; set; }
        public int Adds { get; set; }
        public int Deletes { get; set; }
        public int PurchasesAndActivations { get; set; }
        public int Gifts { get; set; }

        internal static WishlistActions FromCSVLine(string line) {
            var cells = line.Split(',').Select(CsvHelper.CleanCsvString).ToList();
            return new WishlistActions {
                Date = DateOnly.ParseExact(cells[0], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                Game = cells[1],
                Adds = int.Parse(cells[2]),
                Deletes = int.Parse(cells[3]),
                PurchasesAndActivations = int.Parse(cells[4]),
                Gifts = int.Parse(cells[5]),
            };
        }
    }
}
