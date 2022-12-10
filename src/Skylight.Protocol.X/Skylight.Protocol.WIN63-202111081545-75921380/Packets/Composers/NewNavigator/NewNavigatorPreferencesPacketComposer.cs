using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.NewNavigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.NewNavigator;

[PacketComposerId(3574u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class NewNavigatorPreferencesPacketComposer : IOutgoingPacketComposer<NewNavigatorPreferencesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in NewNavigatorPreferencesOutgoingPacket packet)
	{
		writer.WriteInt32(packet.WindowX);
		writer.WriteInt32(packet.WindowY);
		writer.WriteInt32(packet.WindowWidth);
		writer.WriteInt32(packet.WindowHeight);
		writer.WriteBool(packet.LeftPaneHidden);
		writer.WriteInt32(packet.ResultsMode);
	}
}
