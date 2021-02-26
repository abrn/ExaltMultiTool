using ExaltMultiTool.Proxy.Networking.Packets;

internal class ReskinPacket : Packet {
	public int _SkinId;

	public override PacketType pType => PacketType.RESKIN;

	public override void readPacketData(PacketReader r)
	{
		_SkinId = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_SkinId);
	}
}