using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Incoming.Preferences;

[IntroducedIn("WIN63-202111081545-75921380")]
public interface ISetNewNavigatorWindowPreferencesIncomingPacket : IGameIncomingPacket
{
	public int WindowX { get; }
	public int WindowY { get; }

	public int WindowWidth { get; }
	public int WindowHeight { get; }

	public bool LeftPaneHidden { get; }
	public int ResultsMode { get; }
}
