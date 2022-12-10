using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Catalog;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Catalog;

[PacketComposerId(2563u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class CatalogIndexPacketComposer : IOutgoingPacketComposer<CatalogIndexOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in CatalogIndexOutgoingPacket packet)
	{
		writer.WriteBool(packet.Root.Visible);
		writer.WriteInt32(packet.Root.Color);
		writer.WriteInt32(packet.Root.Icon);
		writer.WriteInt32(packet.Root.Id);
		writer.WriteFixedUInt16String(packet.Root.Name);
		writer.WriteFixedUInt16String(packet.Root.Localization);
		Write(ref writer, packet.Root.Children);

		static void Write(ref PacketWriter writer, System.Collections.Generic.ICollection<Skylight.Protocol.Packets.Data.Catalog.CatalogNodeData> childrens)
		{
			writer.WriteInt32(childrens.Count);
			foreach (var children in childrens)
			{
				writer.WriteBool(children.Visible);
				writer.WriteInt32(children.Color);
				writer.WriteInt32(children.Icon);
				writer.WriteInt32(children.Id);
				writer.WriteFixedUInt16String(children.Name);
				writer.WriteFixedUInt16String(children.Localization);
				Write(ref writer, children.Children);
			}

		}
		writer.WriteBool(packet.NewAdditionsAvailable);
	}
}
