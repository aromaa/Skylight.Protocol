using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Handshake;

public interface IInfoRetrieveIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Username { get; }
	public ReadOnlySequence<byte> Password { get; }
}
