using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Users;

public interface IGetIgnoredUsersIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Username { get; }
}
