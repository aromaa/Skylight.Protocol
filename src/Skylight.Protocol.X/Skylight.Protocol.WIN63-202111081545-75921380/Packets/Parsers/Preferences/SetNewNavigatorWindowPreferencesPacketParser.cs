using System.Buffers;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Incoming.Preferences;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Incoming.Parser;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Parsers.Preferences;

[PacketParserId(985u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class SetNewNavigatorWindowPreferencesPacketParser : IIncomingPacketParser<SetNewNavigatorWindowPreferencesPacketParser.SetNewNavigatorWindowPreferencesIncomingPacket>
{
	public SetNewNavigatorWindowPreferencesIncomingPacket Parse(ref PacketReader reader)
	{
		return new SetNewNavigatorWindowPreferencesIncomingPacket
		{
			WindowX = reader.ReadInt32(),
			WindowY = reader.ReadInt32(),
			WindowWidth = reader.ReadInt32(),
			WindowHeight = reader.ReadInt32(),
			LeftPaneHidden = reader.ReadBool(),
			ResultsMode = reader.ReadInt32()
		};
	}

	internal readonly struct SetNewNavigatorWindowPreferencesIncomingPacket : ISetNewNavigatorWindowPreferencesIncomingPacket
	{
		public int WindowX { get; init; }
		public int WindowY { get; init; }
		public int WindowWidth { get; init; }
		public int WindowHeight { get; init; }
		public bool LeftPaneHidden { get; init; }
		public int ResultsMode { get; init; }
	}
}
