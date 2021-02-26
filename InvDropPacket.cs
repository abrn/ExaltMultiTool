using ExaltMultiTool.Proxy.Networking.Packets;

internal class InvDropPacket : Packet {
	public SlotObjectData _SlotObject;

	public bool _Unknown;

	public override PacketType pType => PacketType.INVDROP;

	public override void readPacketData(PacketReader r)
	{
		_SlotObject = new SlotObjectData(r);
		_Unknown = r.ReadBoolean();
	}

	public override void writePacketData(PacketWriter w)
	{
		_SlotObject.WriteSlotObjectData(w);
		w.Write(_Unknown);
	}
}