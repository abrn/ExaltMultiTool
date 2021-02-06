using ExaltMultiTool.Proxy.Networking.Packets;

internal class _sxNjjakU7HAxr71DQ3pUOYwp77c : Packet
{
	public int _HFKCbZGsDhWUhb8bPzzqjZi7LZN;

	public override PacketType pType => PacketType.PETYARDUPDATE;

	public override void readPacketData(PacketReader r)
	{
		_HFKCbZGsDhWUhb8bPzzqjZi7LZN = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_HFKCbZGsDhWUhb8bPzzqjZi7LZN);
	}
}
