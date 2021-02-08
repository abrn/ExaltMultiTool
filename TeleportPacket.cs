using ExaltMultiTool.Proxy.Networking.Packets;

internal class TeleportPacket : Packet
{
	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public override PacketType pType => PacketType.TELEPORT;

	public override void readPacketData(PacketReader r)
	{
		_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
	}
}
