using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;
using Skylight.Protocol.Packets.Data.Recycler;

namespace Skylight.Protocol.Packets.Outgoing.Recycler;

[RemovedOn("WIN63-202111081545-75921380")]
public sealed class RecyclerPrizesOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<RecyclerPrizeLevelData> Rewards { get; init; }

	public RecyclerPrizesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public RecyclerPrizesOutgoingPacket(ICollection<RecyclerPrizeLevelData> rewards)
	{
		this.Rewards = rewards;
	}
}
