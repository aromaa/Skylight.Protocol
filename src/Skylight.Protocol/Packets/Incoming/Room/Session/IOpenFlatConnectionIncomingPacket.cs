using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Room.Session;

public interface IOpenFlatConnectionIncomingPacket : IGameIncomingPacket
{
	public bool IsPublicRoom { get; }
	public int RoomId { get; }
	public ReadOnlySequence<byte> Password { get; }
	public int Unused { get; }
}
