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

			writer.Write(protocol.Protocol switch
			{
				"Fuse" => $"reader.GetReaderRef().TryReadTo(out ReadOnlySequence<byte> {variableName}, (byte)' ') ? {variableName} : reader.ReadBytes(reader.Remaining)",
				"Modern" => $"reader.ReadBytes(reader.ReadInt16())",
				_ => $"reader.ReadBytes(reader.ReadBase64UInt32(2))"
			});
		}
		else if (typeMapping.Type == typeof(int).FromAssembly(typeMapping.Type))
		{
			if (protocol.Protocol is "Fuse")
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

				writer.Write(protocol.Protocol is "Modern"
					? $"({enumType.Namespace}.{enumType.Name})reader.ReadInt32()"
					: $"({enumType.Namespace}.{enumType.Name})reader.ReadVL64UInt32()");
			}
			else if (type == typeof(ReadOnlySequence<byte>).FromAssembly(type))
			{
				//TODO: Fix
				writer.Write(protocol.Protocol is "Modern"
					? $"reader.ReadBytes(4)"
					: "reader.ReadBytes(((reader.ReadByte() >> 3) & 0x7) - 1)");
			}
			else
			{
				writer.Write(protocol.Protocol is "Modern"
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
		else
		{
			throw new NotSupportedException();
		}
	}

	internal override void Write(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
	{
		if (mapping is not TypeMappingSyntax typeMapping)
		{
			throw new NotSupportedException();
		}

		if (type is PropertyInfo propertyInfo)
		{
			type = propertyInfo.PropertyType;
		}

		if (typeMapping.Type == typeof(bool).FromAssembly(typeMapping.Type))
		{
			writer.WriteLine($"writer.WriteBool({context.Name});");
		}
		else if (typeMapping.Type == typeof(short).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(short).FromAssembly(type))
			{
				writer.WriteLine($"writer.WriteInt16({context.Name});");
			}
			else
			{
				writer.WriteLine($"writer.WriteInt16((short){context.Name});");
			}
		}
		else if (typeMapping.Type == typeof(int).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(bool).FromAssembly(type))
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteInt32({context.Name} ? 1 : 0);"
					: $"writer.WriteVL64Int32({context.Name} ? 1 : 0);");
			}
			else if (((Type)type).IsEnum)
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteInt32((int){context.Name});"
					: $"writer.WriteVL64Int32((int){context.Name});");
			}
			else
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteInt32({context.Name});"
					: $"writer.WriteVL64Int32({context.Name});");
			}
		}
		else if (typeMapping.Type == typeof(byte).FromAssembly(typeMapping.Type))
		{
			if (type == typeof(byte).FromAssembly(type))
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteByte({context.Name});"
					: throw new NotSupportedException());
			}
			else if (type == typeof(int).FromAssembly(type))
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteByte((byte){context.Name});"
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
				writer.WriteLine($"writer.WriteFixedUInt16String(string.Join('\\r', {context.Name}.Select(i => (byte)('0' + i)).Chunk((int)packet.Width).Select(c => System.Text.Encoding.UTF8.GetString(c))));");
			}
			else if (type == typeof(double).FromAssembly(type))
			{
				writer.WriteLine(protocol.Protocol is "Modern"
					? $"writer.WriteFixedUInt16String({context.Name}.ToString(CultureInfo.InvariantCulture));"
					: $"writer.WriteDelimiter2BrokenString({context.Name}.ToString(CultureInfo.InvariantCulture));");
			}
			else if (type != typeof(string).FromAssembly(type))
			{
				writer.WriteLine(protocol.Protocol switch
				{
					"Modern" => $"writer.WriteFixedUInt16String({context.Name}.ToString());",
					"Fuse" => $"writer.WriteDelimiterBrokenString({context.Name}.ToString(), (byte)'\\r');",
					_ => $"writer.WriteDelimiter2BrokenString({context.Name}.ToString());"
				});
			}
			else
			{
				writer.WriteLine(protocol.Protocol switch
				{
					"Modern" => $"writer.WriteFixedUInt16String({context.Name});",
					"Fuse" => $"writer.WriteDelimiterBrokenString({context.Name}, (byte)'\\r');",
					_ => $"writer.WriteDelimiter2BrokenString({context.Name});"
				});
			}
		}
		else if (typeMapping.Type == typeof(byte[]).FromAssembly(typeMapping.Type))
		{
			if (typeMapping.ExtraData is not null)
			{
				writer.WriteLine($"writer.WriteBytes(\"{typeMapping.ExtraData}=\"u8);");
				WriteText(ref context, protocol, writer, mapping, type);
				writer.WriteLine($"writer.WriteByte(13);");
			}
			else
			{
				WriteText(ref context, protocol, writer, mapping, type);
			}

			static void WriteText(ref WriterContext context, ProtocolStructure protocol, IndentedTextWriter writer, AbstractMappingSyntax mapping, MemberInfo type)
			{
				if (type == typeof(ICollection<short>).FromAssembly(type))
				{
					writer.WriteLine($"writer.WriteText(string.Join('\\r', {context.Name}.Select(i => (byte)('0' + i)).Chunk((int)packet.Width).Select(c => System.Text.Encoding.UTF8.GetString(c))));");
				}
				else if (type == typeof(DateTime).FromAssembly(type))
				{
					writer.WriteLine($"writer.WriteText({context.Name}.ToString(\"d-M-yyyy\"));");
				}
				else if (type == typeof(ICollection<int>).FromAssembly(type))
				{
					writer.WriteLine($"writer.WriteText('[' + string.Join(',', {context.Name}) + ']');");
				}
				else
				{
					writer.WriteLine($"writer.WriteText({context.Name}.ToString());");
				}
			}
		}
		else
		{
			throw new NotImplementedException();
		}
	}
}
