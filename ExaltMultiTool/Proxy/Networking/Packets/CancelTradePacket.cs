using ExaltMultiTool.Proxy.Networking.Packets;

internal class CancelTradePacket : Packet
{
	public override PacketType pType => PacketType.CANCELTRADE;

	public override void readPacketData(PacketReader r)
	{
	}

	public override void writePacketData(PacketWriter w)
	{
	}
}
