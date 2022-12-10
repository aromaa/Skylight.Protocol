using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Handshake;

public interface IVersionCheckIncomingPacket : IGameIncomingPacket
{
	public int VersionId { get; }

	public ReadOnlySequence<byte> ClientUrl { get; }
	public ReadOnlySequence<byte> ExternalVariablesUrl { get; }
}
