namespace Skylight.Protocol.Packets.Data.Registration;

public enum ApprovePasswordResult
{
	Ok = 0,
	TooShort = 1,
	TooLong = 2,
	InvalidChars = 3,
	NoNumber = 4,
	NameAndPassSimilar = 5
}
