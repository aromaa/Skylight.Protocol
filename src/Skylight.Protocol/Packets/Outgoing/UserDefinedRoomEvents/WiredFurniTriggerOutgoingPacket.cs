﻿using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.UserDefinedRoomEvents;

namespace Skylight.Protocol.Packets.Outgoing.UserDefinedRoomEvents;

public sealed class WiredFurniTriggerOutgoingPacket<TRoomItemId> : IGameOutgoingPacket
{
	public required TRoomItemId ItemId { get; init; }
	public required int FurnitureId { get; init; }
	public required TriggerType Type { get; init; }

	public required int MaxSelectedItems { get; init; }
	public required List<TRoomItemId> SelectedItems { get; init; }

	public required List<int> IntegerParameters { get; init; }
	public required string StringParameter { get; init; }

	public WiredFurniTriggerOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public WiredFurniTriggerOutgoingPacket(TRoomItemId itemId, int furnitureId, TriggerType type, int maxSelectedItems, List<TRoomItemId> selectedItems, List<int> integerParameters, string stringParameter)
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
