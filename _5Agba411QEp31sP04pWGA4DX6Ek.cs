using ExaltMultiTool.Proxy.Networking.Packets;

internal class _5Agba411QEp31sP04pWGA4DX6Ek : Packet
{
	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public int _YCfC0ECakwSpoRjhhTPvs25i7e8;

	public override PacketType pType => PacketType.CHANGEGUILDRANK;

	public override void readPacketData(PacketReader r)
	{
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
		_YCfC0ECakwSpoRjhhTPvs25i7e8 = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
		w.Write(_YCfC0ECakwSpoRjhhTPvs25i7e8);
	}
}
