using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.WIN63_202111081545_75921380.Packets.Composers.Catalog;

[PacketComposerId(2349u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CatalogIndexPacketComposer : IOutgoingPacketComposer<CatalogIndexOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CatalogIndexOutgoingPacket packet)
	{
		writer.WriteBool(packet.Root.Visible);
		writer.WriteInt32(packet.Root.Icon);
		writer.WriteInt32(packet.Root.Id);
		writer.WriteFixedUInt16String(packet.Root.Name);
		writer.WriteFixedUInt16String(packet.Root.Localization);
		writer.WriteInt32(packet.Root.OfferIds.Count);
		foreach (var offerIds in packet.Root.OfferIds)
		{
			writer.WriteInt32(offerIds);
		}
		Write(ref writer, packet.Root.Children);

		static void Write(ref PacketWriter writer, System.Collections.Generic.ICollection<Skylight.Protocol.Packets.Data.Catalog.CatalogNodeData> childrens)
		{
			writer.WriteInt32(childrens.Count);
			foreach (var children in childrens)
			{
				writer.WriteBool(children.Visible);
				writer.WriteInt32(children.Icon);
				writer.WriteInt32(children.Id);
				writer.WriteFixedUInt16String(children.Name);
				writer.WriteFixedUInt16String(children.Localization);
				writer.WriteInt32(children.OfferIds.Count);
				foreach (var offerIds in children.OfferIds)
				{
					writer.WriteInt32(offerIds);
				}
				Write(ref writer, children.Children);
			}

		}
		writer.WriteBool(packet.NewAdditionsAvailable);
		writer.WriteFixedUInt16String(packet.CatalogType);
	}
}
