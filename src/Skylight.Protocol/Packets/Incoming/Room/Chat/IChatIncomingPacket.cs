using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Room.Chat;

public interface IChatIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Text { get; }
	public int StyleId { get; }
	public int TrackingId { get; }
}
