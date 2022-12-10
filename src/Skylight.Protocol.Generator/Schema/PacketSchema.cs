using Skylight.Protocol.Generator.Schema.Mapping;

namespace Skylight.Protocol.Generator.Schema;

internal sealed class PacketSchema
{
	public uint Id { get; init; }

	public required List<AbstractMappingSchema> Structure { get; init; }
}
