namespace Skylight.Protocol.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter)]
internal sealed class RemovedOnAttribute : Attribute
{
	internal string? Revision { get; }

	internal RemovedOnAttribute(string revision)
	{
		this.Revision = revision;
	}
}
