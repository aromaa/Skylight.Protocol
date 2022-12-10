using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Navigator;

public sealed class OfficialRoomsOutgoingPacket : IGameOutgoingPacket
{
	public required int NodeMask { get; init; }
	public required int NodeId { get; init; }

	public OfficialRoomsOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public OfficialRoomsOutgoingPacket(int nodeMask, int nodeId)
	{
		this.NodeMask = nodeMask;
		this.NodeId = nodeId;
	}
}
