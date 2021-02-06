using ExaltMultiTool.Proxy.Networking.Packets;

internal class _Yb4dvnW4MKecM7isJerLtbMutC5 : Packet
{
	public int _HFKCbZGsDhWUhb8bPzzqjZi7LZN;

	public string _N9zjozggCA9FymbKtC3I9dZkIib;

	public override PacketType pType => PacketType.GLOBALNOTIFICATION;

	public override void readPacketData(PacketReader r)
	{
		_HFKCbZGsDhWUhb8bPzzqjZi7LZN = r.ReadInt32();
		_N9zjozggCA9FymbKtC3I9dZkIib = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_HFKCbZGsDhWUhb8bPzzqjZi7LZN);
		w.Write(_N9zjozggCA9FymbKtC3I9dZkIib);
	}
}
