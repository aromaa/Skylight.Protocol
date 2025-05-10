using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Navigator;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE5.Packets.Composers.Navigator;

[PacketComposerId("FLAT_RESULTS")]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class GuestRoomSearchResultPacketComposer : IOutgoingPacketComposer<GuestRoomSearchResultOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in GuestRoomSearchResultOutgoingPacket packet)
	{
		foreach (var rooms in packet.Rooms)
		{
			writer.WriteDelimiterBrokenString($"{rooms.Id}{"/"}{rooms.Name}{"/"}{rooms.OwnerName}{"/"}{"open"}{"/"}{"-"}{"/"}{"-"}{"/"}{"-"}{"/"}{rooms.Host}{"/"}{rooms.Port}{"/"}{rooms.UserCount}{"/"}{"0"}{"/"}{rooms.Description}".ToString(), (byte)'\r');
		}
	}
}
