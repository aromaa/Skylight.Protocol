namespace Skylight.Protocol.Packets.Convertors.Room.Engine;

public interface IRoomItemIdConverter<in T>
{
	public static abstract int Convert(T value);
}
