namespace Skylight.Protocol.Client.Variables.Entries;

public sealed class ClientVariableStaticEntry : ClientVariableEntry
{
	public SortedDictionary<string, ClientVariableStaticEntryValue> Fields { get; set; } = [];
}
