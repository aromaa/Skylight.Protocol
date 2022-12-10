using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Room.Furniture;

public interface IPlacePostItIncomingPacket : IGameIncomingPacket
{
	public int StripId { get; }
	public ReadOnlySequence<byte> Location { get; }
}
