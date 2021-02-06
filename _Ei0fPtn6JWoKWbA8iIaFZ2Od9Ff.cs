using ExaltMultiTool.Proxy.Networking.Packets;

internal class _Ei0fPtn6JWoKWbA8iIaFZ2Od9Ff : Packet
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public override PacketType pType => PacketType.ACCEPTARENADEATH;

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
	}
}
