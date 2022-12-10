namespace Skylight.Protocol.Generator.Parser.Mapping;

internal class TypeMappingSyntax : AbstractMappingSyntax
{
	internal Type Type { get; }

	internal string? Name { get; }

	internal TypeMappingSyntax(Type type, string? name = null)
	{
		this.Type = type;

		this.Name = name;
	}
}
