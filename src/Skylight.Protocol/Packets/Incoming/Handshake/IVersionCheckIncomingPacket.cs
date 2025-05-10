using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Handshake;

public interface IVersionCheckIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> VersionId { get; }
	public ReadOnlySequence<byte> ClientUrl { get; }
	public ReadOnlySequence<byte> ExternalVariablesUrl { get; }
}
