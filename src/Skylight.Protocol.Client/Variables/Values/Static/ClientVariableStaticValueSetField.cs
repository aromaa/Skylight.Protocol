namespace Skylight.Protocol.Client.Variables.Values.Static;

public sealed class ClientVariableStaticValueSetField
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public OrderedDictionary<string, ClientVariableStaticValue> Values { get; set; } = [];
}
