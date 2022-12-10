using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Handshake;

public sealed class UniqueMachineIDOutgoingPacket : IGameOutgoingPacket
{
	public required string MachineId { get; init; }

	public UniqueMachineIDOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public UniqueMachineIDOutgoingPacket(string machineId)
	{
		this.MachineId = machineId;
	}
}
