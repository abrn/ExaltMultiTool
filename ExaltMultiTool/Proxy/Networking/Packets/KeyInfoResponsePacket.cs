using ExaltMultiTool.Proxy.Networking.Packets;

internal class KeyInfoResponsePacket : Packet {
	public byte[] _Key;

	public string _Name;

	public string _Description;

	public string _Creator;

	public override PacketType pType => PacketType.KEYINFORESPONSE;

	public override void readPacketData(PacketReader r)
	{
		_Name = r.ReadString();
		_Description = r.ReadString();
		_Creator = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Name);
		w.Write(_Description);
		w.Write(_Creator);
	}
}