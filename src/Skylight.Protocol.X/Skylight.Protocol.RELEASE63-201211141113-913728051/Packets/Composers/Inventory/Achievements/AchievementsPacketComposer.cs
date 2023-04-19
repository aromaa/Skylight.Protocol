﻿using System.Globalization;
using Skylight.Protocol.Extensions;
using Skylight.Protocol.Packets.Outgoing.Inventory.Achievements;
using Net.Buffers;
using Net.Communication.Attributes;
using Net.Communication.Outgoing;

namespace Skylight.Protocol.RELEASE63_201211141113_913728051.Packets.Composers.Inventory.Achievements;

[PacketComposerId(1576u)]
[PacketManagerRegister(typeof(GamePacketManager))]
internal sealed class AchievementsPacketComposer : IOutgoingPacketComposer<AchievementsOutgoingPacket>
{
	public void Compose(ref PacketWriter writer, in AchievementsOutgoingPacket packet)
	{
		writer.WriteInt32(packet.Achievements.Count);
		foreach (var achievements in packet.Achievements)
		{
			writer.WriteInt32(achievements.Id);
			writer.WriteInt32(achievements.NextLevel);
			writer.WriteFixedUInt16String(achievements.NextLevelBadgeCode);
			writer.WriteInt32(achievements.PreviousProgressRequirement);
			writer.WriteInt32(achievements.CurrentProgressRequirement);
			writer.WriteInt32(achievements.NextLevelRewardPoints);
			writer.WriteInt32(achievements.NextLevelRewardPointsType);
			writer.WriteInt32(achievements.CurrentProgress);
			writer.WriteBool(achievements.Completed);
			writer.WriteFixedUInt16String(achievements.Category);
			writer.WriteFixedUInt16String("");
			writer.WriteInt32(achievements.MaximumLevel);
			writer.WriteInt32(achievements.DisplayMode);
		}
		writer.WriteFixedUInt16String(packet.DefaultCategory);
	}
}
