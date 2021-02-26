using ExaltMultiTool.Proxy.Networking.Packets;

internal class ImminentArenaWavePacket : Packet {
	public int _WaveNumber;

	public override PacketType pType => PacketType.IMMINENTARENAWAVE;

	public override void readPacketData(PacketReader r)
	{
		_WaveNumber = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WaveNumber);
	}
}