using ExaltMultiTool.Proxy.Networking.Packets;

internal class _UxpRknX7gelEcCFZ2Vmq3qfU2Fb : Packet
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public override PacketType pType => PacketType.SHOOTACK;

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
	}
}
