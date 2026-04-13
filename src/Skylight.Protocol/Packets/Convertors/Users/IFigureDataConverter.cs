namespace Skylight.Protocol.Packets.Convertors.Users;

public interface IFigureDataConverter<in T>
{
	public static abstract string Mobiles(T value);
	public static abstract string Goldfish(T value);
	public static abstract string Classic(T value);
	public static abstract string Modern(T value);
}
