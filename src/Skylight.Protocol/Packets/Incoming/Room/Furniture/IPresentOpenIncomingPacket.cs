namespace Skylight.Protocol.Packets.Incoming.Room.Furniture;

public interface IPresentOpenIncomingPacket : IGameIncomingPacket
{
	public int ItemId { get; }
}
