namespace Dysnomia.Common.SteamWebAPI {
    public static class CsvHelper {
        public static string CleanCsvString(string cellValue) {
            if (cellValue is null || !cellValue.StartsWith('"')) {
                return cellValue;
            }

            var cleanedString = cellValue.Replace("\\\"", "\"");
            cleanedString = cleanedString.Remove(0, 1);
            cleanedString = cleanedString.Remove(cleanedString.Length - 1, 1);

            return cleanedString;
        }
    }
}
