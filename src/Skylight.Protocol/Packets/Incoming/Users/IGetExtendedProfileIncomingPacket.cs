namespace Skylight.Protocol.Packets.Incoming.Users;

public interface IGetExtendedProfileIncomingPacket : IGameIncomingPacket
{
	public int UserId { get; }
	public bool Open { get; }
}
