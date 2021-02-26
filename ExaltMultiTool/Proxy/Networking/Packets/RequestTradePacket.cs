using ExaltMultiTool.Proxy.Networking.Packets;

internal class RequestTradePacket : Packet {
	public string _Username;

	public override PacketType pType => PacketType.REQUESTTRADE;

	public override void readPacketData(PacketReader r)
	{
		_Username = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Username);
	}
}