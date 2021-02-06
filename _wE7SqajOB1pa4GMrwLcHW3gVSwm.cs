using ExaltMultiTool.Proxy.Networking.Packets;

internal class _wE7SqajOB1pa4GMrwLcHW3gVSwm : Packet
{
	public byte[] _lX2QobYM0vl29w729rYTPC9jYzf;

	public int _yHzo4xTb5UzqZLQ0cfYFhy0sDUn;

	public override PacketType pType => PacketType.KEYINFOREQUEST;

	public override void readPacketData(PacketReader r)
	{
		_yHzo4xTb5UzqZLQ0cfYFhy0sDUn = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_yHzo4xTb5UzqZLQ0cfYFhy0sDUn);
	}
}
