using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Room.Engine;

//TODO: Packed layout?
public readonly struct TileHeightMap
{
	public required double Height { get; init; }
	public required bool StackingBlocked { get; init; }
	public required bool RoomTile { get; init; }

	public TileHeightMap()
	{
	}

	[SetsRequiredMembers]
	public TileHeightMap(double height, bool stackingBlocked, bool roomTile)
	{
		this.Height = height;
		this.StackingBlocked = stackingBlocked;
		this.RoomTile = roomTile;
	}

	//TODO: This requires more complex support for the generator
	public ushort ModernFormat
	{
		get
		{
			ushort value = ushort.Min((ushort)(this.Height * 256), 0x3FFF);

			if (this.StackingBlocked)
			{
				value |= 0x4000;
			}

			if (!this.RoomTile)
			{
				value |= 0x8000;
			}

			return value;
		}
	}

	public char OldFormat
	{
		get
		{
			//Anything 10 or above is "blocked"
			if (!this.StackingBlocked)
			{
				return (char)('0' + int.Min((int)this.Height, 9));
			}
			else
			{
				return 'a';
			}
		}
	}
}
