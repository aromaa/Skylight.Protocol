using System.Collections.Frozen;

namespace Skylight.Protocol.Generator.Structure;

internal sealed class ProtocolStructure
{
	internal string Revision { get; }

	internal FrozenSet<string> Capabilities { get; }

	internal Dictionary<string, PacketStructure> Incoming { get; }
	internal Dictionary<string, PacketStructure> Outgoing { get; }

	internal Dictionary<string, ObjectStructure> Structures { get; }
	internal Dictionary<string, Dictionary<string, string>> Interfaces { get; }

	internal ProtocolStructure(string revision, FrozenSet<string> capabilities, Dictionary<string, PacketStructure> incoming, Dictionary<string, PacketStructure> outgoing, Dictionary<string, ObjectStructure> structures, Dictionary<string, Dictionary<string, string>> interfaces)
	{
		this.Revision = revision;

		this.Capabilities = capabilities;

		this.Incoming = incoming;
		this.Outgoing = outgoing;

		this.Structures = structures;
		this.Interfaces = interfaces;
	}
}
