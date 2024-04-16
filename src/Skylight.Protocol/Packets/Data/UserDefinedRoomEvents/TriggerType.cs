namespace Skylight.Protocol.Packets.Data.UserDefinedRoomEvents;

public enum TriggerType
{
	UnitSay = 0,
	UnitWalkOn = 1,
	UnitWalkOff = 2,
	Timer = 3,
	UnitUseItem = 4,
	Repeat = 6,
	UnitEnterRoom = 7,
	GameStart = 8,
	GameEnd = 9,
	ScoreAchieved = 10,
	ItemReachUnit = 11,
	RepeatLong = 12,
	BotReachItem = 13,
	BotReachUnit = 14
}
