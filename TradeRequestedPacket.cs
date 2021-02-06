using ExaltMultiTool.Proxy.Networking.Packets;

internal class TradeRequestedPacket : Packet
{
	public string _Username;

	public override PacketType pType => PacketType.TRADEREQUESTED;

	public override void readPacketData(PacketReader r)
	{
		_Username = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Username);
	}
}
