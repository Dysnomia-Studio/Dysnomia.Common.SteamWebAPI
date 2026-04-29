using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dysnomia.Common.SteamWebAPI.JsonConverters {
    public class RequiredAgeConverter : JsonConverter<uint?> {

        public override uint? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            try {
                if (reader.TokenType == JsonTokenType.Number) {
                    return reader.GetUInt32();
                }

                string text = reader.GetString();
                return uint.Parse(text);
            } catch (Exception) {
                return null;
            }
        }

        public override bool CanConvert(Type typeToConvert) {
            return true;
        }

        public override void Write(Utf8JsonWriter writer, uint? value, JsonSerializerOptions options) {
            JsonSerializer.Serialize(writer, value, options);
        }
    }
}
