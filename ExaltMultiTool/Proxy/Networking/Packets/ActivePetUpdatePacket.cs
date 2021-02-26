using ExaltMultiTool.Proxy.Networking.Packets;

internal class ActivePetUpdatePacket : Packet
{
	public int _tjbHiRznBpNOVIqL5wnfaZ7vOZB;

	public override PacketType pType => PacketType.ACTIVEPETUPDATE;

	public override void readPacketData(PacketReader r)
	{
		_tjbHiRznBpNOVIqL5wnfaZ7vOZB = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_tjbHiRznBpNOVIqL5wnfaZ7vOZB);
	}
}
