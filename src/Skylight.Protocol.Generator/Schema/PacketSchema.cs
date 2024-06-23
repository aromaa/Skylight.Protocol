using System.Text.Json.Serialization;
using Skylight.Protocol.Generator.Schema.Mapping;

namespace Skylight.Protocol.Generator.Schema;

public sealed class PacketSchema
{
	public uint Id { get; set; }

	public required List<AbstractMappingSchema> Structure { get; set; }

	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
	public ImportMetadataSchema? ImportMetadata { get; set; }

	public sealed class ImportMetadataSchema
	{
		public string? Id { get; set; }
	}
}
