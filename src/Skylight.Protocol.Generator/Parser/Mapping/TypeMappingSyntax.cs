namespace Skylight.Protocol.Generator.Parser.Mapping;

internal class TypeMappingSyntax : AbstractMappingSyntax
{
	internal Type Type { get; }

	internal string? Method { get; }
	internal string? Name { get; }
	internal string? ExtraData { get; }

	internal TypeMappingSyntax(Type type, string? method = null, string? name = null, string? extraData = null)
	{
		this.Type = type;

		this.Method = method;
		this.Name = name;
		this.ExtraData = extraData;
	}
}
