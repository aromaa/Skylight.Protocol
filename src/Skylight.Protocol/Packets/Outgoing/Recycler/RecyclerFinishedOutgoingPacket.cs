using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Outgoing.Recycler;

[RemovedOn("WIN63-202111081545-75921380")]
public sealed class RecyclerFinishedOutgoingPacket : IGameOutgoingPacket
{
	public required int Status { get; init; }
	public required int PrizeId { get; init; }

	public RecyclerFinishedOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RecyclerFinishedOutgoingPacket(int status, int prizeId)
	{
		this.Status = status;
		this.PrizeId = prizeId;
	}
}
