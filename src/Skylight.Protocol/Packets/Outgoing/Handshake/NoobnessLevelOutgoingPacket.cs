using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Handshake;

public sealed class NoobnessLevelOutgoingPacket : IGameOutgoingPacket
{
	public required int NoobnessLevel { get; init; }

	public NoobnessLevelOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public NoobnessLevelOutgoingPacket(int noobnessLevel)
	{
		this.NoobnessLevel = noobnessLevel;
	}
}
