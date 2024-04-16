namespace Skylight.Protocol.Packets.Data.UserDefinedRoomEvents;

public enum ConditionType
{
	ItemStateMatch = 0,
	UnitsOnItem = 1,
	TriggerOnItem = 2,
	TimerMoreThan = 3,
	TimerLessThan = 4,
	UserCountInRoom = 5,
	InTeam = 6,
	ItemOnTop = 7,
	ItemMatch = 8,
	GroupMember = 10,
	WearingBadge = 11,
	WearingEffect = 12,
	ItemStateNotMatch = 13,
	UnitsNotOnItem = 14,
	TriggerNotOnItem = 15,
	UserCountNotInRoom = 16,
	NotInTeam = 17,
	ItemNotOnTop = 18,
	ItemNotMatch = 19,
	NotGroupMember = 21,
	NotWearingBadge = 22,
	NotWearingEffect = 23,
	DateMatch = 24,
	HoldingHandItem = 25
}
