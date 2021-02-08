using ExaltMultiTool.Proxy.Networking.Packets;

internal class PingPacket : Packet
{
	public int _PingHash;

	public override PacketType pType => PacketType.PING;

	public override void readPacketData(PacketReader r)
	{
		_PingHash = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_PingHash);
	}
}
