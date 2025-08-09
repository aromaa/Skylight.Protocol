namespace Skylight.Protocol.Packets.Incoming.Preferences;

public interface ISetSoundSettingsIncomingPacket : IGameIncomingPacket
{
	public int UiVolume { get; }
	public int FurniVolume { get; }
	public int TraxVolume { get; }
}
