using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Users;

public interface IScrGetUserInfoIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> ProductName { get; }
}
