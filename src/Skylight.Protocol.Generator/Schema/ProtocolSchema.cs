using Skylight.Protocol.Generator.Schema.Mapping;

namespace Skylight.Protocol.Generator.Schema;

internal sealed class ProtocolSchema
{
	public required string Revision { get; init; }

	public required string Protocol { get; init; }

	public required SortedDictionary<string, PacketSchema> Incoming { get; init; }
	public required SortedDictionary<string, PacketSchema> Outgoing { get; init; }

	public required SortedDictionary<string, List<AbstractMappingSchema>> Structures { get; init; }
	public required SortedDictionary<string, SortedDictionary<string, string>> Interfaces { get; init; }
}
