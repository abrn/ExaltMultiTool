using ExaltMultiTool.Proxy.Networking.Packets;

internal class QuestRoomMessagePacket : Packet {
	public override PacketType pType => PacketType.QUESTROOMMSG;

	public override void readPacketData(PacketReader r)
	{
	}

	public override void writePacketData(PacketWriter w)
	{
	}
}