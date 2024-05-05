using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Registration;

public interface IApproveEmailIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Email { get; }
}
