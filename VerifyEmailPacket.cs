using ExaltMultiTool.Proxy.Networking.Packets;

internal class VerifyEmailPacket : Packet
{
	public override PacketType pType => PacketType.VERIFYEMAIL;

	public override void readPacketData(PacketReader r)
	{
	}

	public override void writePacketData(PacketWriter w)
	{
	}
}
