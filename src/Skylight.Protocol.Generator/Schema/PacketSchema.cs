using System.Text.Json.Serialization;
using Skylight.Protocol.Generator.Schema.Mapping;

namespace Skylight.Protocol.Generator.Schema;

public sealed class PacketSchema
{
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	public bool Removed { get; set; }

	public uint? Id { get; set; }

	public List<AbstractMappingSchema>? Structure { get; set; }

	public ImportMetadataSchema? ImportMetadata { get; set; }

	public sealed class ImportMetadataSchema
	{
		public string? Id { get; set; }
	}
}
