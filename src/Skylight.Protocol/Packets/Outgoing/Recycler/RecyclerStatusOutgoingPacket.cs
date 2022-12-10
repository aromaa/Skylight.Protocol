using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Outgoing.Recycler;

[RemovedOn("WIN63-202111081545-75921380")]
public sealed class RecyclerStatusOutgoingPacket : IGameOutgoingPacket
{
	public required int Status { get; init; }
	public required int Timeout { get; init; }

	public RecyclerStatusOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RecyclerStatusOutgoingPacket(int status, int timeout)
	{
		this.Status = status;
		this.Timeout = timeout;
	}
}
