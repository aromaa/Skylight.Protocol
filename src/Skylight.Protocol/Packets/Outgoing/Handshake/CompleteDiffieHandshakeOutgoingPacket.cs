using System.Diagnostics.CodeAnalysis;

namespace Skylight.Protocol.Packets.Outgoing.Handshake;

public sealed class CompleteDiffieHandshakeOutgoingPacket : IGameOutgoingPacket
{
	public required string EncryptedPublicKey { get; init; }

	public required bool ServerClientEncryption { get; init; }

	public CompleteDiffieHandshakeOutgoingPacket()
	{
	}

	[SetsRequiredMembers]
	public CompleteDiffieHandshakeOutgoingPacket(string encryptedPublicKey, bool serverClientEncryption)
	{
		this.EncryptedPublicKey = encryptedPublicKey;

		this.ServerClientEncryption = serverClientEncryption;
	}
}
