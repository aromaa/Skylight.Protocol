namespace Skylight.Protocol.Generator.Parser.Mapping;

internal sealed class GenericTypeMappingSyntax : TypeMappingSyntax
{
	internal AbstractMappingSyntax GenericArgument { get; }

	internal GenericTypeMappingSyntax(Type type, AbstractMappingSyntax genericArgument, string? extraData = null)
		: base(type, extraData: extraData)
	{
		this.GenericArgument = genericArgument;
	}
}
