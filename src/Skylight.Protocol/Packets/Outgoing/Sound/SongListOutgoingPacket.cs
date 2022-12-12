using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Packets.Data.Sound;

namespace Skylight.Protocol.Packets.Outgoing.Sound;

public sealed class SongListOutgoingPacket : IGameOutgoingPacket
{
	public required ICollection<SongData> Songs { get; init; }

	public SongListOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public SongListOutgoingPacket(ICollection<SongData> songs)
	{
		this.Songs = songs;
	}
}
