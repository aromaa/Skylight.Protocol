namespace Skylight.Protocol.Generator.Parser.Mapping;

internal sealed class GenericTypeMappingSyntax : TypeMappingSyntax
{
	internal AbstractMappingSyntax GenericArgument { get; }

	internal GenericTypeMappingSyntax(Type type, AbstractMappingSyntax genericArgument)
		: base(type)
	{
		this.GenericArgument = genericArgument;
	}
}
