using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Registration;

public interface IApprovePasswordIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Username { get; }
	public ReadOnlySequence<byte> Password { get; }
}
