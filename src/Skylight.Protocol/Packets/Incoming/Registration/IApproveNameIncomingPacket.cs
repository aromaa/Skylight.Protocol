using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Registration;

public interface IApproveNameIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Name { get; }
	public int Type { get; }
}
