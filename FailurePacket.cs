using ExaltMultiTool.Proxy.Networking.Packets;

internal class FailurePacket : Packet {
	public int _Id;

	public string _Description;

	public string _Place;

	public string _ConnectionId;

	public override PacketType pType => PacketType.FAILURE;

	public override void readPacketData(PacketReader r)
	{
		_Id = r.ReadInt32();
		_Description = r.ReadString();
		_Place = r.ReadString();
		_ConnectionId = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Id);
		w.Write(_Description);
		w.Write(_Place);
		w.Write(_ConnectionId);
	}
}