using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.RoomSettings;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.RoomSettings;

[PacketComposerId(3638u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RoomSettingsSavedPacketComposer : IOutgoingPacketComposer<RoomSettingsSavedOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RoomSettingsSavedOutgoingPacket packet)
	{
		writer.WriteInt32(packet.RoomId);
	}
}
