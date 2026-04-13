using System.Buffers;
using System.CodeDom.Compiler;
using System.Reflection;
using Skylight.Protocol.Generator.Extensions;
using Skylight.Protocol.Generator.Parser.Mapping;
using Skylight.Protocol.Generator.Structure;

namespace Skylight.Protocol.Generator.Writer.Handlers;

internal sealed class TypeMappingWriteHandler : MappingWriterHandler
{
	internal override void Read(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not TypeMappingSyntax typeMapping)
		{
			throw new NotSupportedException();
		}

		if (type is PropertyInfo propertyInfo)
		{
			type = propertyInfo.PropertyType;
		}

		if (typeMapping.Type == typeof(string).FromAssembly(typeMapping.Type))
		{
			string variableName = context.Name.Replace('.', '_').ToLowerInvariant();

			if (protocol.Capabilities.Contains("INCOMING_STRING_SPACE_DELIMITED"))
			{
				writer.Write($"reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> {variableName}, (byte)' ') ? {variableName} : reader.ReadBytes(reader.Remaining)");
			}
			else if (protocol.Capabilities.Contains("INCOMING_STRING_SHORT_LENGTH_PREFIXED"))
			{
				writer.Write($"reader.ReadBytes(reader.ReadInt16())");
			}
			else if (protocol.Capabilities.Contains("INCOMING_STRING_BASE64_LENGTH_PREFIXED"))
			{
				writer.Write($"reader.ReadBytes(reader.ReadBase64UInt32(2))");
			}
		}
		else if (typeMapping.Type == typeof(int).FromAssembly(typeMapping.Type))
		{
			if (protocol.Capabilities.Contains("INCOMING_STRING_SPACE_DELIMITED"))
			{
				string variableName = context.Name.Replace('.', '_').ToLowerInvariant();

				if (typeMapping.ExtraData is not { } prefix)
				{
					writer.Write($"Utf8Parser.TryParse(reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> _{variableName}, (byte)' ') ? _{variableName}.ToArray() : reader.ReadBytes(reader.Remaining).ToArray(), out int {variableName}, out _) ? {variableName} : default");
				}
				else
				{
					writer.Write($"Utf8Parser.TryParse(reader.GetReaderRef().IsNext((byte)'{prefix}', advancePast: true) && reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> _{variableName}, (byte)'{prefix}') ? _{variableName}.ToArray() : reader.ReadBytes(reader.Remaining).ToArray(), out int {variableName}, out _) ? {variableName} : default");
				}
			}
			else if (type == typeof(bool).FromAssembly(type))
			{
				writer.Write($"reader.ReadInt32() != 0");
			}
			else if (((Type)type).IsEnum)
			{
				Type enumType = (Type)type;

				writer.Write(!protocol.Capabilities.Contains("VL64")
					? $"({enumType.Namespace}.{enumType.Name})reader.ReadInt32()"
					: $"({enumType.Namespace}.{enumType.Name})reader.ReadVL64UInt32()");
			}
			else if (type == typeof(ReadOnlySequence<byte>).FromAssembly(type))
			{
				//TODO: Fix
				writer.Write(!protocol.Capabilities.Contains("VL64")
					? $"reader.ReadBytes(4)"
					: "reader.ReadBytes(((reader.ReadByte() >> 3) & 0x7) - 1)");
			}
			else
			{
				writer.Write(!protocol.Capabilities.Contains("VL64")
					? $"reader.ReadInt32()"
					: "(int)reader.ReadVL64UInt32()");
			}
		}
		else if (typeMapping.Type == typeof(bool).FromAssembly(typeMapping.Type))
		{
			writer.Write($"reader.ReadBool()");
		}
		else if (typeMapping.Type == typeof(byte[]).FromAssembly(typeMapping.Type))
		{
			writer.Write($"reader.ReadBytes(reader.Remaining)");
		}
		else if (typeMapping.Type == typeof(short).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(ReadOnlySequence<byte>).FromAssembly(type))
			{
				//TODO: Fix
				writer.Write("reader.ReadBytes(2)");
			}
			else
			{
				writer.Write(!protocol.Capabilities.Contains("VL64")
					? "reader.ReadInt16()"
					: "(int)reader.ReadBase64UInt32(2)");
			}
		}
		else
		{
			throw new NotSupportedException();
		}
	}

	internal override void Write(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, string? method, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not TypeMappingSyntax typeMapping)
		{
			throw new NotSupportedException();
		}

		if (type is PropertyInfo propertyInfo)
		{
			type = propertyInfo.PropertyType;
		}

		string target = context.Name;
		if (type is Type { IsGenericType: true } genericType && context.Packet.Type.GetGenericArguments().Any(a => a == genericType))
		{
			if (method is null && genericType.GetMethods() is [MethodInfo singleMethod])
			{
				target = $"{genericType.GetGenericArguments()[0].Name}Converter.{singleMethod.Name}({target})";
			}
			else if (method is not null)
			{
				target = $"{genericType.GetGenericArguments()[0].Name}Converter.{method}({target})";
			}
			else
			{
				throw new ArgumentNullException(nameof(method), "Converter method contains more than single method, you must define the target method.");
			}
		}

		if (typeMapping.Type == typeof(bool).FromAssembly(typeMapping.Type))
		{
			writer.WriteLine($"writer.WriteBool({target});");
		}
		else if (typeMapping.Type == typeof(short).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(short).FromAssembly(type))
			{
				writer.WriteLine($"writer.WriteInt16({target});");
			}
			else
			{
				writer.WriteLine($"writer.WriteInt16((short){target});");
			}
		}
		else if (typeMapping.Type == typeof(int).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(bool).FromAssembly(type))
			{
				writer.WriteLine(!protocol.Capabilities.Contains("VL64")
					? $"writer.WriteInt32({target} ? 1 : 0);"
					: $"writer.WriteVL64Int32({target} ? 1 : 0);");
			}
			else if (((Type)type).IsEnum)
			{
				writer.WriteLine(!protocol.Capabilities.Contains("VL64")
					? $"writer.WriteInt32((int){target});"
					: $"writer.WriteVL64Int32((int){target});");
			}
			else
			{
				writer.WriteLine(!protocol.Capabilities.Contains("VL64")
					? $"writer.WriteInt32({target});"
					: $"writer.WriteVL64Int32({target});");
			}
		}
		else if (typeMapping.Type == typeof(byte).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(byte).FromAssembly(type))
			{
				writer.WriteLine(!protocol.Capabilities.Contains("VL64")
					? $"writer.WriteByte({target});"
					: throw new NotSupportedException());
			}
			else if (type == typeof(int).FromAssembly(type))
			{
				writer.WriteLine(!protocol.Capabilities.Contains("VL64")
					? $"writer.WriteByte((byte){target});"
					: throw new NotSupportedException());
			}
			else
			{
				throw new NotSupportedException();
			}
		}
		else if (typeMapping.Type == typeof(string).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(ICollection<short>).FromAssembly(type))
			{
				writer.WriteLine($"writer.WriteFixedUInt16String(string.Join('\\r', {target}.Select(i => (byte)('0' + i)).Chunk((int)packet.Width).Select(c => System.Text.Encoding.UTF8.GetString(c))));");
			}
			else if (type == typeof(double).FromAssembly(type))
			{
				writer.WriteLine(protocol.Capabilities.Contains("OUTGOING_STRING_SHORT_LENGTH_PREFIXED")
					? $"writer.WriteFixedUInt16String({target}.ToString(CultureInfo.InvariantCulture));"
					: $"writer.WriteDelimiter2BrokenString({target}.ToString(CultureInfo.InvariantCulture));");
			}
			else if (type != typeof(string).FromAssembly(type))
			{
				if (protocol.Capabilities.Contains("OUTGOING_STRING_SHORT_LENGTH_PREFIXED"))
				{
					writer.WriteLine($"writer.WriteFixedUInt16String({target}.ToString());");
				}
				else if (protocol.Capabilities.Contains("OUTGOING_STRING_CR_DELIMITED"))
				{
					writer.WriteLine($"writer.WriteDelimiterBrokenString({target}.ToString(), (byte)'\\r');");
				}
				else if (protocol.Capabilities.Contains("OUTGOING_STRING_STX_DELIMITED"))
				{
					writer.WriteLine($"writer.WriteDelimiter2BrokenString({target}.ToString());");
				}
			}
			else
			{
				if (protocol.Capabilities.Contains("OUTGOING_STRING_SHORT_LENGTH_PREFIXED"))
				{
					writer.WriteLine($"writer.WriteFixedUInt16String({target});");
				}
				else if (protocol.Capabilities.Contains("OUTGOING_STRING_CR_DELIMITED"))
				{
					writer.WriteLine($"writer.WriteDelimiterBrokenString({target}, (byte)'\\r');");
				}
				else if (protocol.Capabilities.Contains("OUTGOING_STRING_STX_DELIMITED"))
				{
					writer.WriteLine($"writer.WriteDelimiter2BrokenString({target});");
				}
			}
		}
		else if (typeMapping.Type == typeof(byte[]).FromAssembly(typeMapping.Type))
		{
			if (typeMapping.ExtraData is not null)
			{
				writer.WriteLine($"writer.WriteBytes(\"{typeMapping.ExtraData}=\"u8);");
				WriteText(ref context, protocol, writer, mapping, type, target);
				writer.WriteLine($"writer.WriteByte(13);");
			}
			else
			{
				WriteText(ref context, protocol, writer, mapping, type, target);
			}

			static void WriteText(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type, string target)
			{
				if (type == typeof(ICollection<short>).FromAssembly(type))
				{
					writer.WriteLine($"writer.WriteText(string.Join('\\r', {target}.Select(i => (byte)('0' + i)).Chunk((int)packet.Width).Select(c => System.Text.Encoding.UTF8.GetString(c))));");
				}
				else if (type == typeof(DateTime).FromAssembly(type))
				{
					writer.WriteLine($"writer.WriteText({target}.ToString(\"d-M-yyyy\"));");
				}
				else if (type == typeof(ICollection<int>).FromAssembly(type))
				{
					writer.WriteLine($"writer.WriteText('[' + string.Join(',', {target}) + ']');");
				}
				else
				{
					writer.WriteLine($"writer.WriteText({target}.ToString());");
				}
			}
		}
		else
		{
			throw new NotImplementedException();
		}
	}
}
