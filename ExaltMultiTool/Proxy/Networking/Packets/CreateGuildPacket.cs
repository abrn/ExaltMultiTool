using ExaltMultiTool.Proxy.Networking.Packets;

internal class CreateGuildPacket : Packet
{
	public string _Name;

	public override PacketType pType => PacketType.CREATEGUILD;

	public override void readPacketData(PacketReader r)
	{
		_Name = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Name);
	}
}
