namespace Skylight.Protocol.Attributes;

[AttributeUsage(AttributeTargets.Assembly)]
public sealed class GameProtocolAttribute : Attribute
{
	public string Revision { get; }

	public GameProtocolAttribute(string revision)
	{
		this.Revision = revision;
	}
}
