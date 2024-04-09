using System.Buffers;

namespace Skylight.Protocol.Packets.Incoming.UserDefinedRoomEvents;

public interface IUpdateActionIncomingPacket : IGameIncomingPacket
{
	public int ItemId { get; }

	public IList<int> SelectedItems { get; }
	public int ItemSelectionType { get; }

	public int ActionDelay { get; }

	public IList<int> IntegerParameters { get; }
	public ReadOnlySequence<byte> StringParameter { get; }
}
