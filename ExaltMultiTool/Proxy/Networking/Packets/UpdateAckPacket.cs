using ExaltMultiTool.Proxy.Networking.Packets;

internal class UpdateAckPacket : Packet
{
	public override PacketType pType => PacketType.UPDATEACK;

	public override void readPacketData(PacketReader r)
	{
	}

	public override void writePacketData(PacketWriter w)
	{
	}
}
