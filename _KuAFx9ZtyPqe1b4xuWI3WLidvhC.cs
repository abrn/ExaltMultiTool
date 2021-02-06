using ExaltMultiTool.Proxy.Networking.Packets;

internal class _KuAFx9ZtyPqe1b4xuWI3WLidvhC : Packet
{
	public int _opt59RqZGla4ErMq6zXbdqEZsQF;

	public override PacketType pType => PacketType.REALMHEROLEFTMSG;

	public override void readPacketData(PacketReader r)
	{
		_opt59RqZGla4ErMq6zXbdqEZsQF = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_opt59RqZGla4ErMq6zXbdqEZsQF);
	}
}
