using ExaltMultiTool.Proxy.Networking.Packets;

internal class _Wfwa0wwjHlBYxHNQ25GIgOEASlS : Packet
{
	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public override PacketType pType => PacketType.CHOOSENAME;

	public override void readPacketData(PacketReader r)
	{
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
	}
}
