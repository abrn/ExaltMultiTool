using ExaltMultiTool.Proxy.Networking.Packets;

internal class _fUPdRVGlY66uCJkAXdtcnDQC5Au : Packet
{
	public byte _JY0kf7kjdBiAOKRKmdhULNGTehr;

	public override PacketType pType => PacketType.UNKNOWN120;

	public override void readPacketData(PacketReader r)
	{
		_JY0kf7kjdBiAOKRKmdhULNGTehr = r.ReadByte();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_JY0kf7kjdBiAOKRKmdhULNGTehr);
	}
}
