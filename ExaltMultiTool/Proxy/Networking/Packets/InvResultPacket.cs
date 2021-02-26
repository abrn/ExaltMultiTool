using ExaltMultiTool.Proxy.Networking.Packets;

internal class InvResultPacket : Packet {
	public bool _Success;

	public SlotObjectData _SlotOne;

	public SlotObjectData _SlotTwo;

	public override PacketType pType => PacketType.INVRESULT;

	public override void readPacketData(PacketReader r)
	{
		_Success = r.ReadBoolean();
		_SlotOne = new SlotObjectData(r);
		_SlotTwo = new SlotObjectData(r);
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Success);
		_SlotOne.WriteSlotObjectData(w);
		_SlotTwo.WriteSlotObjectData(w);
	}
}