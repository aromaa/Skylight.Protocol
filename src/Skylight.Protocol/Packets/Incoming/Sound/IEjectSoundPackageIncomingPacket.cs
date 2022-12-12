namespace Skylight.Protocol.Packets.Incoming.Sound;

public interface IEjectSoundPackageIncomingPacket : IGameIncomingPacket
{
	public int Slot { get; }
}
