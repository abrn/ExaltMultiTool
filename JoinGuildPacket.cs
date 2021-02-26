using ExaltMultiTool.Proxy.Networking.Packets;

internal class JoinGuildPacket : Packet {
	public string _GuildName;

	public override PacketType pType => PacketType.JOINGUILD;

	public override void readPacketData(PacketReader r)
	{
		_GuildName = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_GuildName);
	}
}