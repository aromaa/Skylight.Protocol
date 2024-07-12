using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Navigator;

namespace Skylight.Protocol.Packets.Outgoing.Navigator;

public sealed class OfficialRoomsOutgoingPacket : IGameOutgoingPacket
{
	public required int NodeMask { get; init; }

	public required ICollection<NavigatorNodeData> Nodes { get; init; }

	public OfficialRoomsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public OfficialRoomsOutgoingPacket(int nodeMask, ICollection<NavigatorNodeData> nodes)
	{
		this.NodeMask = nodeMask;
		this.Nodes = nodes;
	}
}
