namespace Skylight.Protocol.Packets.Incoming.Room.Engine;

public interface IPickupObjectIncomingPacket : IGameIncomingPacket
{
	public int ItemType { get; }
	public int ItemId { get; }
}
