using ExaltMultiTool.Proxy.Networking.Packets;

internal class ChangeNameResultPacket : Packet
{
	public bool _PJSppIZJztu4HXLKvqK1ZeiDLym;

	public string _YQHu6PgPYmZlbS8T6Pv7Vtj9Ktc;

	public override PacketType pType => PacketType.NAMERESULT;

	public override void readPacketData(PacketReader r)
	{
		_PJSppIZJztu4HXLKvqK1ZeiDLym = r.ReadBoolean();
		_YQHu6PgPYmZlbS8T6Pv7Vtj9Ktc = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_PJSppIZJztu4HXLKvqK1ZeiDLym);
		w.Write(_YQHu6PgPYmZlbS8T6Pv7Vtj9Ktc);
	}
}
