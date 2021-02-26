using ExaltMultiTool.Proxy.Networking.Packets;

internal class QueueCancelPacket : Packet {
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public short _Qh0BQXXjPEcRT8iSpFFQRoYAmun;

	public override PacketType pType => PacketType.QUEUECANCEL; // QUEUE_CANCEL

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		_Qh0BQXXjPEcRT8iSpFFQRoYAmun = r.ReadInt16();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		w.Write(_Qh0BQXXjPEcRT8iSpFFQRoYAmun);
	}
}