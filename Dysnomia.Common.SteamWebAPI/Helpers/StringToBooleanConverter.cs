using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dysnomia.Common.SteamWebAPI.Helpers {
	class StringToBooleanConverter : JsonConverter<bool> {
		public override bool Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options) {
			if (reader.TokenType == JsonTokenType.String) {
				return reader.GetString() == "true";
			}

			return reader.GetBoolean();
		}
		public override bool CanConvert(Type typeToConvert) {
			return true;
		}

		public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options) {
			JsonSerializer.Serialize(writer, value, options);
		}
	}
}
