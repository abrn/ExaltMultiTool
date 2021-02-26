using ExaltMultiTool.Proxy.Networking.Packets;

internal class CreateSuccessPacket : Packet
{
	public int _ObjectId;

	public int _CharId;

	public string _M5JWfqz5mAzF5l7Bqm9i9bP3XCh;

	public override PacketType pType => PacketType.CREATESUCCESS;

	public override void readPacketData(PacketReader r)
	{
		_ObjectId = r.ReadInt32();
		_CharId = r.ReadInt32();
		_M5JWfqz5mAzF5l7Bqm9i9bP3XCh = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_ObjectId);
		w.Write(_CharId);
		w.Write(_M5JWfqz5mAzF5l7Bqm9i9bP3XCh);
	}
}
