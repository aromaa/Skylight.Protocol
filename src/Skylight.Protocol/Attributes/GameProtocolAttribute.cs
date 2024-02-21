namespace Skylight.Protocol.Attributes;

[AttributeUsage(AttributeTargets.Assembly)]
public sealed class GameProtocolAttribute(string revision) : Attribute
{
	public string Revision { get; } = revision;
}
