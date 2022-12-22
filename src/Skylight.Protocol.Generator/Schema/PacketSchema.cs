using Skylight.Protocol.Generator.Schema.Mapping;

namespace Skylight.Protocol.Generator.Schema;

public sealed class PacketSchema
{
	public uint Id { get; set; }

	public required List<AbstractMappingSchema> Structure { get; set; }
}
