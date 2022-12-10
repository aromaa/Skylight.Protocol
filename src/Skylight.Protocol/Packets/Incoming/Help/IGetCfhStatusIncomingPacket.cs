namespace Skylight.Protocol.Packets.Incoming.Help;

public interface IGetCfhStatusIncomingPacket : IGameIncomingPacket
{
	public bool Display { get; }
}
