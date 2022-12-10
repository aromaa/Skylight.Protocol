using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Handshake;

public interface IUniqueIDIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> MachineId { get; }
	public ReadOnlySequence<byte> Fingerprint { get; }
	public ReadOnlySequence<byte> FlashVersion { get; }
}
