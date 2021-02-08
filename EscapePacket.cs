using ExaltMultiTool.Proxy.Networking.Packets;

internal class EscapePacket : Packet
{
	public override PacketType pType => PacketType.ESCAPE;

	public override void readPacketData(PacketReader r)
	{
	}

	public override void writePacketData(PacketWriter w)
	{
	}
}
