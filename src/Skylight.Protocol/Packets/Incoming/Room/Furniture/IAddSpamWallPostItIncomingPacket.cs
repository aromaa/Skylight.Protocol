using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Room.Furniture;

public interface IAddSpamWallPostItIncomingPacket : IGameIncomingPacket
{
	public int Id { get; }
	public ReadOnlySequence<byte> Location { get; }

	public ReadOnlySequence<byte> Color { get; }
	public ReadOnlySequence<byte> Text { get; }
}
