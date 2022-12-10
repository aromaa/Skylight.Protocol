using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Handshake;

public interface IClientHelloIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> ClientVersion { get; }
	public ReadOnlySequence<byte> ClientName { get; }
	public int ClientType { get; }

	public int Unknown { get; }
}
