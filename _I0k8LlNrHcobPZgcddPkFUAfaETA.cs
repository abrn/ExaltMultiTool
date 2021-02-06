using ExaltMultiTool.Proxy.Networking.Packets;

internal class _I0k8LlNrHcobPZgcddPkFUAfaETA : Packet
{
	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public override PacketType pType => PacketType.REQUESTTRADE;

	public override void readPacketData(PacketReader r)
	{
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
	}
}
