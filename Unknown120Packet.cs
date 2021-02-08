using ExaltMultiTool.Proxy.Networking.Packets;

internal class Unknown120Packet : Packet // lol forge_blueprints_unlocked
{
	public byte _JY0kf7kjdBiAOKRKmdhULNGTehr;
	// public int[] _UnlockedBluePrints

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
