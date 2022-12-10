using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Tracking;

public interface IEventLogIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Category { get; }
	public ReadOnlySequence<byte> Type { get; }
	public ReadOnlySequence<byte> Action { get; }

	public ReadOnlySequence<byte> ExtraString { get; }
	public int ExtraInt { get; }
}
