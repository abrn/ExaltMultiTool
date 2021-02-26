using ExaltMultiTool.Proxy.Networking.Packets;

internal class PongPacket : Packet {
	public int _PingHash;

	public int _Time;

	public override PacketType pType => PacketType.PONG;

	public override void readPacketData(PacketReader r)
	{
		_PingHash = r.ReadInt32();
		_Time = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_PingHash);
		w.Write(_Time);
	}
}