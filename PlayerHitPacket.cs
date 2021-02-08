using ExaltMultiTool.Proxy.Networking.Packets;

internal class PlayerHitPacket : Packet
{
	public byte _isVjytSCPjaQXfnhSgmbShfAEYC;

	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public override PacketType pType => PacketType.PLAYERHIT;

	public override void readPacketData(PacketReader r)
	{
		_isVjytSCPjaQXfnhSgmbShfAEYC = r.ReadByte();
		_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_isVjytSCPjaQXfnhSgmbShfAEYC);
		w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
	}
}
