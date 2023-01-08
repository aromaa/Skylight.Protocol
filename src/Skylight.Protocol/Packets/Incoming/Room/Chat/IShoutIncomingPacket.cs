using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Room.Chat;

public interface IShoutIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Text { get; }
	public int StyleId { get; }
}
