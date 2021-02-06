using ExaltMultiTool.Proxy.Networking.Packets;

internal class KeyInfoPacket : Packet
{
	public byte[] _Key;

	public int _KeyTime;

	public override PacketType pType => PacketType.KEYINFOREQUEST;

	public override void readPacketData(PacketReader r)
	{
		_KeyTime = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_KeyTime);
	}
}
