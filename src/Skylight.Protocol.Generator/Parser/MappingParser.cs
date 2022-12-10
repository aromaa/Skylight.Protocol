using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Schema.Mapping;

namespace Skylight.Protocol.Generator.Parser;

internal static class MappingParser
{
	internal static AbstractMappingSyntax Parse(AbstractMappingSchema mapping)
	{
		if (mapping is FieldMappingSchema fieldMapping)
		{
			return ParseType(fieldMapping.Type, fieldMapping.Name);
		}
		else if (mapping is ConstantMappingSchema constantMapping)
		{
			if (ParseType(constantMapping.Type) is TypeMappingSyntax typeMapping)
			{
				return new ConstantMappingSyntax(Convert.ChangeType(constantMapping.Value, typeMapping.Type), typeMapping);
			}
		}
		else if (mapping is ConditionalMappingSchema conditionalMapping)
		{
			return new ConditionalMappingSyntax(conditionalMapping.Condition, Parse(conditionalMapping.WhenTrue));
		}
		else if (mapping is CombineMappingSchema combineMapping)
		{
			return new CombineMappingSyntax(ParseType(combineMapping.Type), combineMapping.Fields.Select(Parse).ToList());
		}

		throw new NotSupportedException();
	}

	private static AbstractMappingSyntax ParseType(string type, string? name = default)
	{
		switch (type)
		{
			case "string":
				return new TypeMappingSyntax(typeof(string), name);
			case "text":
				return new TypeMappingSyntax(typeof(byte[]), name);
			case "int":
				return new TypeMappingSyntax(typeof(int), name);
			case "short":
				return new TypeMappingSyntax(typeof(short), name);
			case "bool":
				return new TypeMappingSyntax(typeof(bool), name);
			case "List":
				return new TypeMappingSyntax(typeof(List<>), name);
			case "BufferedList":
				return new TypeMappingSyntax(typeof(IAsyncEnumerator<>), name);
		}

		int genericArgumentIndex = type.IndexOf('<');
		if (genericArgumentIndex != -1)
		{
			string genericType = type.Substring(0, genericArgumentIndex);
			string genericArgument = type.Substring(genericArgumentIndex + 1, type.LastIndexOf('>') - genericArgumentIndex - 1);

			if (ParseType(genericType) is TypeMappingSyntax typeMapping)
			{
				return new GenericTypeMappingSyntax(typeMapping.Type, ParseType(genericArgument));
			}
		}

		return new ObjectMappingSyntax(type);
	}
}
