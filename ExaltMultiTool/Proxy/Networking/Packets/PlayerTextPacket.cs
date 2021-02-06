using ExaltMultiTool.Proxy.Networking.Packets;

internal class PlayerTextPacket : Packet {
	public string _Message;

	public override PacketType pType => PacketType.PLAYERTEXT;

	public override void readPacketData(PacketReader r)
	{
		_Message = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Message);
	}
}