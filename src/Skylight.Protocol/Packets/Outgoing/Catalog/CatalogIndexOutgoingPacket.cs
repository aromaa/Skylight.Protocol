using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Catalog;

namespace Skylight.Protocol.Packets.Outgoing.Catalog;

public sealed class CatalogIndexOutgoingPacket : IGameOutgoingPacket
{
	public required string CatalogType { get; init; }

	public required CatalogNodeData Root { get; init; }

	public required bool NewAdditionsAvailable { get; init; }

	public CatalogIndexOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public CatalogIndexOutgoingPacket(string catalogType, CatalogNodeData root, bool newAdditionsAvailable)
	{
		this.CatalogType = catalogType;

		this.Root = root;

		this.NewAdditionsAvailable = newAdditionsAvailable;
	}
}
