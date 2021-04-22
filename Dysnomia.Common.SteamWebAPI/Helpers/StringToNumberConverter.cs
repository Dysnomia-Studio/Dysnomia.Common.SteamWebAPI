using System;
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dysnomia.Common.SteamWebAPI.Helpers {
	public class StringToNumberConverter<T> : JsonConverter<T> {
		public override T Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options) {
			if (reader.TokenType == JsonTokenType.Number) {
				if (typeof(T) == typeof(int)) {
					return (T)(object)reader.GetInt32();
				}
				if (typeof(T) == typeof(uint)) {
					return (T)(object)reader.GetUInt32();
				}
				if (typeof(T) == typeof(long)) {
					return (T)(object)reader.GetInt64();
				}
				if (typeof(T) == typeof(ulong)) {
					return (T)(object)reader.GetUInt64();
				}
			}

			try {
				var s = reader.GetString();
				var converter = TypeDescriptor.GetConverter(typeof(T));
				if (converter != null) {
					// Cast ConvertFromString(string text) : object to (T)
					return (T)converter.ConvertFromString(s);
				}
				return default(T);
			} catch (NotSupportedException) {
				return default(T);
			}

			using (JsonDocument document = JsonDocument.ParseValue(ref reader)) {
				throw new Exception($"unable to parse {document.RootElement.ToString()} to number");
			}
		}

		public override bool CanConvert(Type typeToConvert) {
			return true;
		}

		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options) {
			JsonSerializer.Serialize(writer, value, options);
		}
	}
}
