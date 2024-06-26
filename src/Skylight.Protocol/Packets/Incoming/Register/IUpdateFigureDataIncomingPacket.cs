using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Register;

public interface IUpdateFigureDataIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> Gender { get; }
	public ReadOnlySequence<byte> Figure { get; }
}
