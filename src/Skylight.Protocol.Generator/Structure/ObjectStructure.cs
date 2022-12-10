using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using Skylight.Protocol.Generator.Parser.Mapping;

namespace Skylight.Protocol.Generator.Structure;

internal sealed class ObjectStructure
{
	internal string Name { get; }

	internal bool Recursive { get; }

	internal ImmutableArray<(string? FieldName, AbstractMappingSyntax Mapping)> Mapping { get; }

	private readonly Dictionary<string, AbstractMappingSyntax> fields;

	internal ObjectStructure(string name, bool recursive, ImmutableArray<(string? FieldName, AbstractMappingSyntax Mapping)> mapping, Dictionary<string, AbstractMappingSyntax> fields)
	{
		this.Name = name;

		this.Recursive = recursive;

		this.Mapping = mapping;

		this.fields = fields;
	}

	internal bool TryGetField(string name, [NotNullWhen(true)] out AbstractMappingSyntax? mapping) => this.fields.TryGetValue(name, out mapping);
}
