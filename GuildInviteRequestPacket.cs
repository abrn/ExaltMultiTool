using ExaltMultiTool.Proxy.Networking.Packets;

internal class GuildInviteRequestPacket : Packet {
	public string _Username;

	public string _GuildName;

	public override PacketType pType => PacketType.INVITEDTOGUILD;

	public override void readPacketData(PacketReader r)
	{
		_Username = r.ReadString();
		_GuildName = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Username);
		w.Write(_GuildName);
	}
}