using ExaltMultiTool.Proxy.Networking.Packets;

internal class ImminentArenaWavePacket : Packet
{
	public int _HFKCbZGsDhWUhb8bPzzqjZi7LZN;

	public override PacketType pType => PacketType.IMMINENTARENAWAVE;

	public override void readPacketData(PacketReader r)
	{
		_HFKCbZGsDhWUhb8bPzzqjZi7LZN = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_HFKCbZGsDhWUhb8bPzzqjZi7LZN);
	}
}
