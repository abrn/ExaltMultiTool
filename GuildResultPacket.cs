using ExaltMultiTool.Proxy.Networking.Packets;

internal class GuildResultPacket : Packet {
	public bool _Success;

	public string _Message;

	public override PacketType pType => PacketType.GUILDRESULT;

	public override void readPacketData(PacketReader r)
	{
		_Success = r.ReadBoolean();
		_Message = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Success);
		w.Write(_Message);
	}
}