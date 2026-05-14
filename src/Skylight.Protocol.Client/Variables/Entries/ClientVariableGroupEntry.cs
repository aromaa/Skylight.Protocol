namespace Skylight.Protocol.Client.Variables.Entries;

public sealed class ClientVariableGroupEntry : ClientVariableEntry
{
	public ClientVariableSelectStrategy EntrySelectStrategy { get; set; }

	public OrderedDictionary<string, ClientVariableEntry> Entries { get; init; } = [];
}
