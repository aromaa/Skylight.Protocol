using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Room.Object;

namespace Skylight.Protocol.Packets.Data.Catalog;

public sealed class CatalogProductData
{
	public required FurnitureType Type { get; init; }

	public required int FurnitureId { get; init; }
	public required string ExtraData { get; init; } //TODO: Abstraction

	public required int ProductCount { get; init; }

	public required int Expiration { get; init; }

	public CatalogProductData()
	{
	}

	[SetsRequiredMembers]
	public CatalogProductData(FurnitureType type, int furnitureId, string extraData, int productCount, int expiration)
	{
		this.Type = type;

		this.FurnitureId = furnitureId;
		this.ExtraData = extraData;

		this.ProductCount = productCount;

		this.Expiration = expiration;
	}
}
