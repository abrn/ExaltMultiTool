using ExaltMultiTool.Proxy.Networking.Packets;

internal class ReskinUnlockPacket : Packet {
	public int _SkinId;

	public int _SkinType;

	public override PacketType pType => PacketType.RESKINUNLOCK;

	public override void readPacketData(PacketReader r)
	{
		_SkinId = r.ReadInt32();
		_SkinType = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_SkinId);
		w.Write(_SkinType);
	}
}