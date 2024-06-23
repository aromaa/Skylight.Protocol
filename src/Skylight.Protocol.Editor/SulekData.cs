using System.Text.Json.Serialization;

namespace Skylight.Protocol.Editor;

internal sealed class SulekData
{
	[JsonPropertyName("messages")]
	public required MessagesData Messages { get; set; }

	internal sealed class MessagesData
	{
		[JsonPropertyName("outgoing")]
		public required List<PacketData> Outgoing { get; set; }

		[JsonPropertyName("incoming")]
		public required List<PacketData> Incoming { get; set; }
	}

	internal sealed class PacketData
	{
		[JsonPropertyName("id")]
		public required uint Id { get; set; }

		[JsonPropertyName("name")]
		public required string Name { get; set; }
	}
}
