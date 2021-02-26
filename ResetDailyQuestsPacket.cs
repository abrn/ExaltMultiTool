using ExaltMultiTool.Proxy.Networking.Packets;

internal class ResetDailyQuestsPacket : Packet {
	public override PacketType pType => PacketType.RESETDAILYQUESTS;

	public override void readPacketData(PacketReader r)
	{
	}

	public override void writePacketData(PacketWriter w)
	{
	}
}