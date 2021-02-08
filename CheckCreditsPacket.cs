using ExaltMultiTool.Proxy.Networking.Packets;

internal class CheckCreditsPacket : Packet
{
	public override PacketType pType => PacketType.CHECKCREDITS;

	public override void readPacketData(PacketReader r)
	{
	}

	public override void writePacketData(PacketWriter w)
	{
	}
}
