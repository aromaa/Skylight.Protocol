using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Handshake;

public interface ICompleteDiffieHandshakeIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> PublicKey { get; }
}
