using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Tracking;

public sealed class LatencyPingResponseOutgoingPacket : IGameOutgoingPacket
{
	public required int RequestId { get; init; }

	public LatencyPingResponseOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public LatencyPingResponseOutgoingPacket(int requestId)
	{
		this.RequestId = requestId;
	}
}
