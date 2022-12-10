using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Generator.Structure.Mapping;

namespace Skylight.Protocol.Generator.Structure;

internal sealed class PacketStructure
{
	internal string Name { get; }
	internal uint Id { get; }

	internal Type Type { get; }

	internal ImmutableArray<MappingStructure> Mapping { get; }

	internal Dictionary<string, MappingStructure> Fields { get; }

	internal PacketStructure(string name, uint id, Type type, ImmutableArray<MappingStructure> mapping, Dictionary<string, MappingStructure> fields)
	{
		this.Name = name;
		this.Id = id;

		this.Type = type;

		this.Mapping = mapping;

		this.Fields = fields;
	}

	internal bool TryGetField(string name, [NotNullWhen(true)] out MappingStructure? mapping) => this.Fields.TryGetValue(name, out mapping);
}
