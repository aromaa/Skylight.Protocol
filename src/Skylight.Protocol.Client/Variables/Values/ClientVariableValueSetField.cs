namespace Skylight.Protocol.Client.Variables.Values;

public sealed class ClientVariableValueSetField
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public OrderedDictionary<string, ClientVariableValue> Values { get; set; } = [];
}
