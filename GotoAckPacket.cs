using ExaltMultiTool.Proxy.Networking.Packets;

internal class GotoAckPacket : Packet {
	public int _Time;

	public override PacketType pType => PacketType.GOTOACK;

	public override void readPacketData(PacketReader r)
	{
		_Time = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Time);
	}
}