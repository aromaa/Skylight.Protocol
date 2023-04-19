using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Room.Avatar;
public interface IChangeMottoIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Motto { get; }
}
