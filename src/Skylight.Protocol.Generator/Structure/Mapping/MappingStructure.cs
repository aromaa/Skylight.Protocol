using System.Reflection;
using Skylight.Protocol.Generator.Parser.Mapping;

namespace Skylight.Protocol.Generator.Structure.Mapping;

internal sealed class MappingStructure
{
	internal string? Method { get; }
	internal string? Name { get; }

	internal AbstractMappingSyntax Syntax { get; }
	internal MemberInfo Type { get; }

	internal MappingStructure(string? method, string? name, AbstractMappingSyntax syntax, MemberInfo type)
	{
		this.Method = method;
		this.Name = name;

		this.Syntax = syntax;
		this.Type = type;
	}
}
