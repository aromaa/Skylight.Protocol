using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE5.Packets.Composers.Navigator;

[PacketComposerId("ALLUNITS")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class OfficialRoomsPacketComposer : IOutgoingPacketComposer<OfficialRoomsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in OfficialRoomsOutgoingPacket packet)
	{
		foreach (var nodes in packet.Nodes)
		{
			if (nodes is Skylight.Protocol.Packets.Data.Navigator.NavigatorPublicRoomNode navigatorPublicRoomNode)
			{
				writer.WriteDelimiterBrokenString($"{navigatorPublicRoomNode.Caption}{","}{navigatorPublicRoomNode.UserCount}{","}{navigatorPublicRoomNode.UsersMax}{","}{navigatorPublicRoomNode.Host}{","}{navigatorPublicRoomNode.Port}{","}{navigatorPublicRoomNode.Name}".ToString(), (byte)'\r');
			}
			else
			{
				throw new NotSupportedException();
			}
		}
	}
}
