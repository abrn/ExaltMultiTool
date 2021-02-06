using ExaltMultiTool.Proxy.Networking.Packets;

internal class _XqKxPhuck2qXBOaCGfEaSvcrlJ6 : Packet
{
	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public override PacketType pType => PacketType.USEPORTAL;

	public override void readPacketData(PacketReader r)
	{
		_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
	}
}
