using ExaltMultiTool.Proxy.Networking.Packets;

internal class _XbmOucTFf2lAzR2snXyKdOr7FTJ : Packet
{
	public ushort _HRlp0f9oR4tySMNuTZBcZmI2bJe;

	public ushort _KSurbhigRQLtqPXMCa0EaApVLa0;

	public override PacketType pType => PacketType.QUEUEINFORMATION;

	public override void readPacketData(PacketReader r)
	{
		_HRlp0f9oR4tySMNuTZBcZmI2bJe = r.ReadUInt16();
		_KSurbhigRQLtqPXMCa0EaApVLa0 = r.ReadUInt16();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_HRlp0f9oR4tySMNuTZBcZmI2bJe);
		w.Write(_KSurbhigRQLtqPXMCa0EaApVLa0);
	}
}
