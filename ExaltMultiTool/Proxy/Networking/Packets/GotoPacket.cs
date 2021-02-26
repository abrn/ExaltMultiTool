using ExaltMultiTool.Proxy.Networking.Packets;

internal class GotoPacket : Packet {
	public int _ObjectId;

	public WorldPosData _Position;

	public override PacketType pType => PacketType.GOTO;

	public override void readPacketData(PacketReader r)
	{
		_ObjectId = r.ReadInt32();
		_Position = new WorldPosData(r);
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_ObjectId);
		_Position.Write(w);
	}
}