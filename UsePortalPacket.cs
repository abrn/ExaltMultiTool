using ExaltMultiTool.Proxy.Networking.Packets;

internal class UsePortalPacket : Packet
{
	public int _ObjectId;

	public override PacketType pType => PacketType.USEPORTAL;

	public override void readPacketData(PacketReader r)
	{
		_ObjectId = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_ObjectId);
	}
}
