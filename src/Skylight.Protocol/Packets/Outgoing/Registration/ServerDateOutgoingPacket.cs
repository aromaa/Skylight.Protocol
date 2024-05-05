using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Registration;

public sealed class ServerDateOutgoingPacket : IGameOutgoingPacket
{
	public required DateTime Time { get; init; }

	public ServerDateOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public ServerDateOutgoingPacket(DateTime time)
	{
		this.Time = time;
	}
}
