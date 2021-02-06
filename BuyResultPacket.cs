using ExaltMultiTool.Proxy.Networking.Packets;

internal class BuyResultPacket : Packet
{
	public int _ResultType;

	public string _ResultMessage;

	public override PacketType pType => PacketType.BUYRESULT;

	public override void readPacketData(PacketReader r)
	{
		_ResultType = r.ReadInt32();
		_ResultMessage = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_ResultType);
		w.Write(_ResultMessage);
	}
}
