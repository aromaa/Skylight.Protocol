using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Purse;

public sealed class CreditBalanceOutgoingPacket : IGameOutgoingPacket
{
	public required int Balance { get; init; }

	public CreditBalanceOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public CreditBalanceOutgoingPacket(int balance)
	{
		this.Balance = balance;
	}
}
