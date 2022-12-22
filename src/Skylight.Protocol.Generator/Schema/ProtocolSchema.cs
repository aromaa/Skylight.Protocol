using Skylight.Protocol.Generator.Schema.Mapping;

namespace Skylight.Protocol.Generator.Schema;

public sealed class ProtocolSchema
{
	public required string Revision { get; set; }

	public required string Protocol { get; set; }

	public required SortedDictionary<string, PacketSchema> Incoming { get; set; }
	public required SortedDictionary<string, PacketSchema> Outgoing { get; set; }

	public required SortedDictionary<string, List<AbstractMappingSchema>> Structures { get; set; }
	public required SortedDictionary<string, SortedDictionary<string, string>> Interfaces { get; set; }
}
