using System.Runtime.CompilerServices;
using System.Text;
using Net.Buffers;

namespace Skylight.Protocol.Extensions;

public static class PacketWriterExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteDelimiter2BrokenString(ref this PacketWriter writer, string value)
	{
		writer.WriteDelimiterBrokenString(value, 2);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteText(ref this PacketWriter writer, string value)
	{
		writer.WriteBytes(Encoding.UTF8.GetBytes(value));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteBase64UInt32(ref this PacketWriter writer, int bytes, uint value)
	{
		for (int shift = (bytes - 1) * 6; shift >= 0; shift -= 6)
		{
			writer.WriteByte((byte)(0x40 + ((value >> shift) & 0x3F)));
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteVL64Int32(ref this PacketWriter writer, uint value)
	{
		writer.WriteVL64Int32((int)value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteVL64Int32(ref this PacketWriter writer, int value)
	{
		PacketWriter slice = writer.ReservedFixedSlice(1);

		int left = Math.Abs(value);
		int header = left & 3;

		int i = 1;
		for (left >>= 2; left > 0; left >>= 6)
		{
			i++;

			writer.WriteByte((byte)(0x40 + (left & 0x3F)));
		}

		slice.WriteByte((byte)((i << 3) | (value < 0 ? 0x4 : 0) | header));
	}
}
