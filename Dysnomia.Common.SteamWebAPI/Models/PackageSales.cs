using System;
using System.Globalization;
using System.Linq;

namespace Dysnomia.Common.SteamWebAPI.Models {
    public class PackageSales {
        public DateOnly Date { get; set; }
        public int BundleId { get; set; }
        public string BundleName { get; set; }
        public uint ProductId { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public string Game { get; set; }
        public string Platform { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public int GrossUnits { get; set; }
        public int ChargebackAndReturns { get; set; }
        public int NetUnits { get; set; }
        public decimal BasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Currency { get; set; }
        public decimal USDGrossSteamSales { get; set; }
        public decimal USDChargebackAndReturns { get; set; }
        public decimal USDNetSteamSales { get; set; }
        public string Tag { get; set; }

        public static PackageSales FromCSVLine(string line) {
            var cells = line.Split(',').Select(CsvHelper.CleanCsvString).ToList();
            return new() {
                Date = DateOnly.ParseExact(cells[0], "yyyy-MM-dd", CultureInfo.InvariantCulture),
                BundleId = int.Parse(cells[1]),
                BundleName = cells[2],
                ProductId = uint.Parse(cells[3]),
                ProductName = cells[4],
                Type = cells[5],
                Game = cells[6],
                Platform = cells[7],
                CountryCode = cells[8],
                Country = cells[9],
                Region = cells[10],
                GrossUnits = int.Parse(cells[11]),
                ChargebackAndReturns = int.Parse(cells[12]),
                NetUnits = int.Parse(cells[13]),
                BasePrice = decimal.Parse(cells[14], CultureInfo.InvariantCulture),
                SalePrice = decimal.Parse(cells[15], CultureInfo.InvariantCulture),
                Currency = cells[16],
                USDGrossSteamSales = decimal.Parse(cells[17], CultureInfo.InvariantCulture),
                USDChargebackAndReturns = decimal.Parse(cells[18], CultureInfo.InvariantCulture),
                USDNetSteamSales = decimal.Parse(cells[19], CultureInfo.InvariantCulture),
                Tag = cells[20],
            };
        }
    }
}
