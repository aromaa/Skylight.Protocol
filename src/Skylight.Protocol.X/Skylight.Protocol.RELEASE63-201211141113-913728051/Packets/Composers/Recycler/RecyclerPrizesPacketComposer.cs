using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Recycler;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Recycler;

[PacketComposerId(201u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class RecyclerPrizesPacketComposer : IOutgoingPacketComposer<RecyclerPrizesOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in RecyclerPrizesOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Rewards.Count);
		foreach (var rewards in packet.Rewards)
		{
			writer.WriteInt32(rewards.Level);
			writer.WriteInt32(rewards.Odds);
			writer.WriteInt32(rewards.Prizes.Count);
			foreach (var prizes in rewards.Prizes)
			{
				writer.WriteFixedUInt16String(prizes.Name);
				writer.WriteInt32(prizes.Items.Count);
				foreach (var items in prizes.Items)
				{
					if (items.Type is Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Floor)
					{
						writer.WriteFixedUInt16String("s");
					}
					else if (items.Type is Skylight.Protocol.Packets.Data.Room.Object.FurnitureType.Wall)
					{
						writer.WriteFixedUInt16String("i");
					}
					else
					{
						throw new NotSupportedException();
					}
					writer.WriteInt32(items.FurnitureId);
				}
			}
		}
	}
}
