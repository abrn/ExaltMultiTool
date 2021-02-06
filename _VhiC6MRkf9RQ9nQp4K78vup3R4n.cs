using ExaltMultiTool.Proxy.Networking.Packets;

internal class _VhiC6MRkf9RQ9nQp4K78vup3R4n : Packet
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public WorldPosData _ObXrbtVZcdprxclR2Ggz9jKwlp;

	public override PacketType pType => PacketType.GROUNDDAMAGE;

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		_ObXrbtVZcdprxclR2Ggz9jKwlp = new WorldPosData(r);
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		_ObXrbtVZcdprxclR2Ggz9jKwlp._3Wc8kZJjhbRt6nttAKwD2698imm(w);
	}
}
