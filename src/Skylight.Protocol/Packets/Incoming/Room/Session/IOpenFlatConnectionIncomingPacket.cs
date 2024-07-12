using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Room.Session;

public interface IOpenFlatConnectionIncomingPacket : IGameIncomingPacket
{
	public int RoomId { get; }
	public ReadOnlySequence<byte> Password { get; }
	public int Unused { get; }
}
