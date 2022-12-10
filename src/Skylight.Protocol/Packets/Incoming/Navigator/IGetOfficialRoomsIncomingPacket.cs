namespace Skylight.Protocol.Packets.Incoming.Navigator;

public interface IGetOfficialRoomsIncomingPacket : IGameIncomingPacket
{
	public int NodeMask { get; }
	public int NodeId { get; }
	public int Depth { get; }
}
