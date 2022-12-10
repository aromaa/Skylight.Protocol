using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.Navigator;

public interface ICreateFlatIncomingPacket : IGameIncomingPacket
{
	public ReadOnlySequence<byte> RoomName { get; }
	public ReadOnlySequence<byte> Description { get; }
	public ReadOnlySequence<byte> LayoutId { get; }

	public int CategoryId { get; }
	public int MaxUserCount { get; }
	public int TradeMode { get; }
}
