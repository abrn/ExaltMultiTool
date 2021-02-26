using ExaltMultiTool.Proxy.Networking.Packets;

internal class QueueInfoPacket : Packet {
	public ushort _CurrentPosition;

	public ushort _MaxPosition;

	public override PacketType pType => PacketType.QUEUEINFORMATION;

	public override void readPacketData(PacketReader r)
	{
		_CurrentPosition = r.ReadUInt16();
		_MaxPosition = r.ReadUInt16();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_CurrentPosition);
		w.Write(_MaxPosition);
	}
}