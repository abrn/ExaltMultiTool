using ExaltMultiTool.Proxy.Networking.Packets;

internal class EditAccountListPacket : Packet
{
	public int _AccountListId;

	public bool _Add;

	public int _ObjectId;

	public override PacketType pType => PacketType.EDITACCOUNTLIST;

	public override void readPacketData(PacketReader r)
	{
		_AccountListId = r.ReadInt32();
		_Add = r.ReadBoolean();
		_ObjectId = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_AccountListId);
		w.Write(_Add);
		w.Write(_ObjectId);
	}
}
