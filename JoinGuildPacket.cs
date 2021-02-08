using ExaltMultiTool.Proxy.Networking.Packets;

internal class JoinGuildPacket : Packet
{
	public string _w1TqG1hi8zKpLFbdlocr31ecHCC;

	public override PacketType pType => PacketType.JOINGUILD;

	public override void readPacketData(PacketReader r)
	{
		_w1TqG1hi8zKpLFbdlocr31ecHCC = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_w1TqG1hi8zKpLFbdlocr31ecHCC);
	}
}
