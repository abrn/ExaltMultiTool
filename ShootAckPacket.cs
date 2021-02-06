using ExaltMultiTool.Proxy.Networking.Packets;

internal class ShootAckPacket : Packet
{
	public int _Time;

	public override PacketType pType => PacketType.SHOOTACK;

	public override void readPacketData(PacketReader r)
	{
		_Time = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Time);
	}
}
