using ExaltMultiTool.Proxy.Networking.Packets;

internal class QuestFetchAskPacket : Packet
{
	public override PacketType pType => PacketType.QUESTFETCHASK;

	public override void readPacketData(PacketReader r)
	{
	}

	public override void writePacketData(PacketWriter w)
	{
	}
}
