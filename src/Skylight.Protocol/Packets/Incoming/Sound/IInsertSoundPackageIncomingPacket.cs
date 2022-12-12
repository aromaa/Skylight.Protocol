namespace Skylight.Protocol.Packets.Incoming.Sound;

public interface IInsertSoundPackageIncomingPacket : IGameIncomingPacket
{
	public int SoundSetId { get; }
	public int Slot { get; }
}
