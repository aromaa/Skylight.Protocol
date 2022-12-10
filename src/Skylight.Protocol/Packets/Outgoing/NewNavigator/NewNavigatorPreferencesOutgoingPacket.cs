using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Attributes;

namespace Skylight.Protocol.Packets.Outgoing.NewNavigator;

[IntroducedIn("WIN63-202111081545-75921380")]
public sealed class NewNavigatorPreferencesOutgoingPacket : IGameOutgoingPacket
{
	public required int WindowX { get; init; }
	public required int WindowY { get; init; }

	public required int WindowWidth { get; init; }
	public required int WindowHeight { get; init; }

	public required bool LeftPaneHidden { get; init; }
	public required int ResultsMode { get; init; }

	public NewNavigatorPreferencesOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public NewNavigatorPreferencesOutgoingPacket(int windowX, int windowY, int windowWidth, int windowHeight, bool leftPaneHidden, int resultsMode)
	{
		this.WindowX = windowX;
		this.WindowY = windowY;

		this.WindowWidth = windowWidth;
		this.WindowHeight = windowHeight;

		this.LeftPaneHidden = leftPaneHidden;
		this.ResultsMode = resultsMode;
	}
}
