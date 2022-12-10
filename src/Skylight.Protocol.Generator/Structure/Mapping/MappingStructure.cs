using System.Reflection;
using Skylight.Protocol.Generator.Parser.Mapping;

namespace Skylight.Protocol.Generator.Structure.Mapping;

internal sealed class MappingStructure
{
	internal string? Name { get; }

	internal AbstractMappingSyntax Syntax { get; }
	internal MemberInfo Type { get; }

	internal MappingStructure(string? name, AbstractMappingSyntax syntax, MemberInfo type)
	{
		this.Name = name;

		this.Syntax = syntax;
		this.Type = type;
	}
}
