using ExaltMultiTool.Proxy.Networking.Packets;

internal class _DXIZr3yz8ZmAVeVR5qgHl9rpPNc : Packet
{
	public int _qL8Qk0RJEu4lcCGcJpKfz1Fn8tb;

	public int _PWbB7SCLVcYTV40xoOcBn68wTeE;

	public override PacketType pType => PacketType.PLAYSOUND;

	public override void readPacketData(PacketReader r)
	{
		_qL8Qk0RJEu4lcCGcJpKfz1Fn8tb = r.ReadInt32();
		_PWbB7SCLVcYTV40xoOcBn68wTeE = r.ReadByte();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_qL8Qk0RJEu4lcCGcJpKfz1Fn8tb);
		w.Write((byte)_PWbB7SCLVcYTV40xoOcBn68wTeE);
	}
}
