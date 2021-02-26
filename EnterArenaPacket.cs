using ExaltMultiTool.Proxy.Networking.Packets;

internal class EnterArenaPacket : Packet {
	public int _Currency;

	public override PacketType pType => PacketType.ENTERARENA;

	public override void readPacketData(PacketReader r)
	{
		_Currency = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Currency);
	}
}