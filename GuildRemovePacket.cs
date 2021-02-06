using ExaltMultiTool.Proxy.Networking.Packets;

internal class GuildRemovePacket : Packet
{
	public string _Username;

	public override PacketType pType => PacketType.GUILDREMOVE;

	public override void readPacketData(PacketReader r)
	{
		_Username = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Username);
	}
}
