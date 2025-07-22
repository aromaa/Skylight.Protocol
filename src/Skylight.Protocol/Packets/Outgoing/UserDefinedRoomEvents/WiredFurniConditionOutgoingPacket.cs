using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.UserDefinedRoomEvents;

namespace Skylight.Protocol.Packets.Outgoing.UserDefinedRoomEvents;

public sealed class WiredFurniConditionOutgoingPacket<TRoomItemId> : IGameOutgoingPacket
{
	public required TRoomItemId ItemId { get; init; }
	public required int FurnitureId { get; init; }
	public required ConditionType Type { get; init; }

	public required int MaxSelectedItems { get; init; }
	public required List<TRoomItemId> SelectedItems { get; init; }

	public required List<int> IntegerParameters { get; init; }
	public required string StringParameter { get; init; }

	public WiredFurniConditionOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public WiredFurniConditionOutgoingPacket(TRoomItemId itemId, int furnitureId, ConditionType type, int maxSelectedItems, List<TRoomItemId> selectedItems, List<int> integerParameters, string stringParameter)
	{
		this.ItemId = itemId;
		this.FurnitureId = furnitureId;
		this.Type = type;
		this.MaxSelectedItems = maxSelectedItems;
		this.SelectedItems = selectedItems;
		this.IntegerParameters = integerParameters;
		this.StringParameter = stringParameter;
	}
}
