using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.NewNavigator;

public sealed class LiftedRoomData
{
	public required int RoomId { get; init; }
	public required int AreaId { get; init; }

	public required string Image { get; init; }
	public required string Caption { get; init; }

	public LiftedRoomData()
	{
	}

	[SetsRequiredMembers]
	public LiftedRoomData(int roomId, int areaId, string image, string caption)
	{
		this.RoomId = roomId;
		this.AreaId = areaId;

		this.Image = image;
		this.Caption = caption;
	}
}
