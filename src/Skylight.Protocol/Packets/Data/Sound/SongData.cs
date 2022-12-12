using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Data.Sound;

public sealed class SongData
{
	public required int Id { get; init; }
	public required string Name { get; init; }

	public required int Length { get; init; }
	public required bool Locked { get; init; }

	public SongData()
	{
	}

	[SetsRequiredMembers]
	public SongData(int id, string name, int length, bool locked)
	{
		this.Id = id;
		this.Name = name;
		this.Length = length;
		this.Locked = locked;
	}
}
