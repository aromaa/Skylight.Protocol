namespace Skylight.Protocol.Packets.Data.Room.Object.Data;

public sealed class EmptyItemData : IItemData
{
	public static EmptyItemData Instance { get; } = new();
}
