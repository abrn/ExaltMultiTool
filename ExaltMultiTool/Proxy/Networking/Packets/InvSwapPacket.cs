using ExaltMultiTool.Proxy.Networking.Packets;

internal class InvSwapPacket : Packet {
	public int _Time;

	public WorldPosData _Position;

	public SlotObjectData _SlotOne;

	public SlotObjectData _SlotTwo;

	public override PacketType pType => PacketType.INVSWAP;

	public override void readPacketData(PacketReader r)
	{
		_Time = r.ReadInt32();
		_Position = new WorldPosData(r);
		_SlotOne = new SlotObjectData(r);
		_SlotTwo = new SlotObjectData(r);
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Time);
		_Position.Write(w);
		_SlotOne.WriteSlotObjectData(w);
		_SlotTwo.WriteSlotObjectData(w);
	}
}