using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Handshake;

public interface ISSOTicketIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> SSOTicket { get; }
	public int Time { get; }
}
