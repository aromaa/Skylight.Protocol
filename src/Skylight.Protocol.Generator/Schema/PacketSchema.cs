using System.Text.Json;
using System.Text.Json.Serialization;
using Skylight.Protocol.Generator.Schema.Mapping;

namespace Skylight.Protocol.Generator.Schema;

public sealed class PacketSchema
{
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public bool Removed { get; set; }

	[JsonConverter(typeof(Converter))]
	public object? Id { get; set; }

	public List<AbstractMappingSchema>? Structure { get; set; }

	public ImportMetadataSchema? ImportMetadata { get; set; }

	public sealed class ImportMetadataSchema
	{
		public string? Id { get; set; }
	}

	public sealed class Converter : JsonConverter<object?>
	{
		public override object? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.TokenType switch
			{
				JsonTokenType.Null => null,
				JsonTokenType.String => reader.GetString(),
				JsonTokenType.Number => reader.GetInt32(),

				_ => throw new NotSupportedException(reader.TokenType.ToString())
			};
		}

		public override void Write(Utf8JsonWriter writer, object? value, JsonSerializerOptions options)
		{
			switch (value)
			{
				case null:
					writer.WriteNullValue();
					break;
				case string stringValue:
					writer.WriteStringValue(stringValue);
					break;
				case int intValue:
					writer.WriteNumberValue(intValue);
					break;
				default:
					throw new NotSupportedException(value.GetType().ToString());
			}
		}
	}
}
