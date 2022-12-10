namespace Skylight.Protocol.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Parameter, AllowMultiple = true)]
internal sealed class AliasesAttribute : Attribute
{
	internal string Alias { get; }
	internal string Revision { get; }

	internal AliasesAttribute(string alias, string revision)
	{
		this.Alias = alias;
		this.Revision = revision;
	}
}
