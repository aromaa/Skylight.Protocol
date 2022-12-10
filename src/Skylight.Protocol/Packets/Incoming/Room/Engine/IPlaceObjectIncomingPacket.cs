using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Room.Engine;

public interface IPlaceObjectIncomingPacket : IGameIncomingPacket
{
	//TODO: Abstract?
	public ReadOnlySequence<byte> Values { get; }
}
