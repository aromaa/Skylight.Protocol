namespace Skylight.Protocol.Packets.Incoming.Room.Engine;

public interface IGetItemDataIncomingPacket : IGameIncomingPacket
{
	public int ItemId { get; }
}
