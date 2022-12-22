using System.CodeDom.Compiler;
using System.Drawing;
using System.Reflection;
using System.Text;
using Skylight.Protocol.Generator.Extensions;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;

namespace Skylight.Protocol.Generator.Writer.Handlers;

internal sealed class CombineMappingWriteHandler : MappingWriterHandler
{
	internal override void Read(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		throw new NotImplementedException();
	}

	internal override void Write(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not CombineMappingSyntax combineMapping)
		{
			throw new NotSupportedException();
		}

		if (combineMapping.Type is TypeMappingSyntax typeMapping)
		{
			if (typeMapping.Type == typeof(string).FromAssembly(typeMapping.Type))
			{
				StringBuilder stringBuilder = new(@$"$""");

				foreach (AbstractMappingSyntax field in combineMapping.Fields)
				{
					if (field is ConstantMappingSyntax constantMapping)
					{
						stringBuilder.Append($"{{{constantMapping.Value}}}");
					}
					else if (field is TypeMappingSyntax fieldTypeMapping)
					{
						PropertyInfo property = ((Type)type).GetProperty(fieldTypeMapping.Name!)!;
						if (property.PropertyType == typeof(Color).FromAssembly(property.PropertyType))
						{
							stringBuilder.Append($"{{{context.Name}.{fieldTypeMapping.Name}.ToArgb():X6}}");
						}
						else
						{
							stringBuilder.Append($"{{{context.Name}.{fieldTypeMapping.Name}}}");
						}
					}
					else
					{
						throw new NotSupportedException();
					}
				}

				stringBuilder.Append('"');

				using (context.PushScope(stringBuilder.ToString(), true))
				{
					context.Write(protocol, writer, typeMapping, type);
				}

				return;
			}
		}

		throw new NotSupportedException();
	}
}
