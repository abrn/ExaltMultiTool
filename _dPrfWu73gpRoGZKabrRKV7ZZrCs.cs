using ExaltMultiTool.Proxy.Networking.Packets;

internal class _dPrfWu73gpRoGZKabrRKV7ZZrCs : Packet
{
	public int _Z7iWeS1W3Ht6ch6jgJJ8aFPGFTj;

	public override PacketType pType => PacketType.PING;

	public override void readPacketData(PacketReader r)
	{
		_Z7iWeS1W3Ht6ch6jgJJ8aFPGFTj = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Z7iWeS1W3Ht6ch6jgJJ8aFPGFTj);
	}
}
