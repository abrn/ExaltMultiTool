using ExaltMultiTool.Proxy.Networking.Packets;

internal class _5mDELbdDeeFjmQtnCFiDaCPaAqz : Packet
{
	public SlotObjectData _GPJ1Yp8tCEXEoq8RmZNbc43WC7C;

	public bool _CkVA852z4XQpJ2SkHxe0itEqlLg;

	public override PacketType pType => PacketType.INVDROP;

	public override void readPacketData(PacketReader r)
	{
		_GPJ1Yp8tCEXEoq8RmZNbc43WC7C = new SlotObjectData(r);
		_CkVA852z4XQpJ2SkHxe0itEqlLg = r.ReadBoolean();
	}

	public override void writePacketData(PacketWriter w)
	{
		_GPJ1Yp8tCEXEoq8RmZNbc43WC7C.WriteSlotObjectData(w);
		w.Write(_CkVA852z4XQpJ2SkHxe0itEqlLg);
	}
}
