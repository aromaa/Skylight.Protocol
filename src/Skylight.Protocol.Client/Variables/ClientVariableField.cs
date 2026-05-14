using Skylight.Protocol.Client.Variables.Keys;

namespace Skylight.Protocol.Client.Variables;

public sealed class ClientVariableField
{
	public string Name { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;

	public string Type { get; set; } = "string";

	public OrderedDictionary<string, ClientVariableKeySet> KeySets { get; set; } = [];
}
