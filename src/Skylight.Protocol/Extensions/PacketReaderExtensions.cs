using System.Runtime.CompilerServices;
using Net.Buffers;

namespace Skylight.Protocol.Extensions;

public static class PacketReaderExtensions
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool TryReadBase64UInt32(ref this PacketReader reader, int bytes, out uint value)
	{
		if (reader.Remaining >= bytes)
		{
			value = reader.ReadBase64UInt32(bytes);
			return true;
		}

		Unsafe.SkipInit(out value);

		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint ReadBase64UInt32(ref this PacketReader reader, int bytes)
	{
		uint result = 0;
		for (int shift = (bytes - 1) * 6; shift >= 0; shift -= 6)
		{
			result |= (reader.ReadByte() - 0x40u) << shift;
		}

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint ReadBase128UInt32(ref this PacketReader reader, int bytes)
	{
		uint result = 0;
		for (int shift = (bytes - 1) * 7; shift >= 0; shift -= 7)
		{
			result |= (reader.ReadByte() - 0x80u) << shift;
		}

		return result;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint ReadVL64UInt32(ref this PacketReader reader)
	{
		return (uint)reader.ReadVL64Int32();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int ReadVL64Int32(ref this PacketReader reader)
	{
		byte header = reader.ReadByte();

		int count = (header >> 3) & 0x7;

		int value = header & 0x3;
		for (int i = 1; i < count; i++)
		{
			value |= (reader.ReadByte() - 0x40) << (2 + (6 * (i - 1)));
		}

		if ((header & 0x4) == 0x4)
		{
			return -value;
		}

		return value;
	}
}
