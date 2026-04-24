using System.CodeDom.Compiler;
using System.Reflection;
using System.Text;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;
using static Skylight.Protocol.Generator.Writer.WriterContext;

namespace Skylight.Protocol.Generator.Writer.Handlers;

internal sealed class JoinMappingWriteHandler : MappingWriterHandler
{
	internal override void Read(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		throw new NotImplementedException();
	}

	internal override void Write(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, string? method, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not JoinMappingSyntax joinMapping || type is not Type { IsGenericType: true } genericType)
		{
			throw new NotSupportedException();
		}

		int variableIndex = context.Name.LastIndexOf('.');

		string name = $"{context.Name.Substring(variableIndex + 1)}";

		if (context.Target.Type == typeof(string))
		{
			writer.WriteLineNoTabs($"string.Join({joinMapping.Delimiter}, {context.Name}.Select(value =>");
			writer.WriteLine($"{{");
			writer.Indent++;

			using (context.PushScope("value", true))
			{
				foreach (AbstractMappingSyntax field in joinMapping.Fields)
				{
					context.Write(protocol, writer, method, field, genericType.GetGenericArguments()[0]);
				}
			}

			writer.Indent--;
			writer.Write($"}}))");

			return;
		}

		writer.WriteLine($"System.Text.StringBuilder stringBuilder{name} = new();");
		writer.WriteLine($"foreach (var value in {context.Name})");
		writer.WriteLine($"{{");
		writer.Indent++;
		writer.WriteLine($"if (stringBuilder{name}.Length > 0)");
		writer.WriteLine($"{{");
		writer.Indent++;
		writer.WriteLine($"stringBuilder{name}.Append({joinMapping.Delimiter});");
		writer.Indent--;
		writer.WriteLine($"}}");

		using (context.PushScope("value", true, new TargetData($"stringBuilder{name}", typeof(StringBuilder))))
		{
			foreach (AbstractMappingSyntax field in joinMapping.Fields)
			{
				context.Write(protocol, writer, method, field, genericType.GetGenericArguments()[0]);
			}
		}

		writer.Indent--;
		writer.WriteLine($"}}");

		using (context.PushScope($"stringBuilder{name}", true))
		{
			context.Write(protocol, writer, method, joinMapping.Type, genericType.GetGenericArguments()[0]);
		}
	}
}
