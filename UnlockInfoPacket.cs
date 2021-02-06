using ExaltMultiTool.Proxy.Networking.Packets;

internal class UnlockInfoPacket : Packet
{
	public int _ItemId;

	public override PacketType pType => PacketType.UNLOCKINFORMATION;

	public override void readPacketData(PacketReader r)
	{
		_ItemId = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_ItemId);
	}
}
