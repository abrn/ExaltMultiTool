using ExaltMultiTool.Proxy.Networking.Packets;

internal class LoadPacket : Packet
{
	public int _CharId;

	public bool _IsFromArena;

	public override PacketType pType => PacketType.LOAD;

	public override void readPacketData(PacketReader r)
	{
		_CharId = r.ReadInt32();
		_IsFromArena = r.ReadBoolean();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_CharId);
		w.Write(_IsFromArena);
	}
}
