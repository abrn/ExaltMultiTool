using ExaltMultiTool.Proxy.Networking.Packets;

internal class _CppOE2NkBb90oUwZ4SALWD8aVuk : Packet
{
	public int _LWCRtqgUMlKocxQy7x8OnCzLjeE;

	public override PacketType pType => PacketType.ENTERARENA;

	public override void readPacketData(PacketReader r)
	{
		_LWCRtqgUMlKocxQy7x8OnCzLjeE = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_LWCRtqgUMlKocxQy7x8OnCzLjeE);
	}
}
