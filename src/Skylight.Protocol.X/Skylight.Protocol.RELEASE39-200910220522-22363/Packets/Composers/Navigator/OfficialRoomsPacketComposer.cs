using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE39_200910220522_22363.Packets.Composers.Navigator;

[PacketComposerId(220u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class OfficialRoomsPacketComposer : IOutgoingPacketComposer<OfficialRoomsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in OfficialRoomsOutgoingPacket packet)
	{
		writer.WriteVL64Int32(packet.NodeMask);
		foreach (var nodes in packet.Nodes)
		{
			if (nodes is Skylight.Protocol.Packets.Data.Navigator.NavigatorCategoryNodeData navigatorCategoryNodeData)
			{
				writer.WriteVL64Int32(navigatorCategoryNodeData.Id);
				writer.WriteVL64Int32(0);
				writer.WriteDelimiter2BrokenString(navigatorCategoryNodeData.Caption);
				writer.WriteVL64Int32(navigatorCategoryNodeData.UserCount);
				writer.WriteVL64Int32(navigatorCategoryNodeData.UsersMax);
				writer.WriteVL64Int32(navigatorCategoryNodeData.ParentId);
			}
			else if (nodes is Skylight.Protocol.Packets.Data.Navigator.NavigatorPublicRoomNode navigatorPublicRoomNode)
			{
				writer.WriteVL64Int32(navigatorPublicRoomNode.Id);
				writer.WriteVL64Int32(1);
				writer.WriteDelimiter2BrokenString(navigatorPublicRoomNode.Caption);
				writer.WriteVL64Int32(navigatorPublicRoomNode.UserCount);
				writer.WriteVL64Int32(navigatorPublicRoomNode.UsersMax);
				writer.WriteVL64Int32(navigatorPublicRoomNode.ParentId);
				writer.WriteDelimiter2BrokenString(navigatorPublicRoomNode.Name);
				writer.WriteVL64Int32(navigatorPublicRoomNode.InstanceId);
				writer.WriteVL64Int32(navigatorPublicRoomNode.WorldId);
				writer.WriteDelimiter2BrokenString(navigatorPublicRoomNode.Casts);
				writer.WriteVL64Int32(0);
				writer.WriteVL64Int32(0);
			}
			else
			{
				throw new NotSupportedException();
			}
		}
	}
}
