using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Avatar;

public interface ISaveWardrobeOutfitIncomingPacket : IGameIncomingPacket
{
	public int SlotId { get; }

	public ReadOnlySequence<byte> Gender { get; }
	public ReadOnlySequence<byte> Figure { get; }
}
