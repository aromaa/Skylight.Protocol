namespace Skylight.Protocol.Packets.Data.UserDefinedRoomEvents;

public enum ActionType
{
	CycleItemState = 0,
	ResetTimers = 1,
	SetItemState = 3,
	MoveItem = 4,
	GiveScore = 6,
	ShowMessage = 7,
	TeleportUnit = 8,
	JoinTeam = 9,
	LeaveTeam = 10,
	ItemChaseUnit = 11,
	ItemAvoidUnit = 12,
	MoveItemDirectionally = 13,
	GiveScoreToTeam = 14,
	RandomItemState = 15,
	GiveReward = 17,
	ExecuteStack = 18,
	KickUnit = 19,
	MuteUnit = 20,
	TeleportBot = 21,
	MoveBot = 22,
	BotTalk = 23,
	GiveHandItem = 24,
	BotFollowUnit = 25,
	ChangeBotLook = 26,
	BotTalkTo = 27
}
