using ExaltMultiTool.Proxy.Networking.Packets;

internal class FilePacket : Packet {
	public string _FileName;

	public byte[] _FileBytes;

	public override PacketType pType => PacketType.FILE;

	public override void readPacketData(PacketReader r)
	{
		_FileName = r.ReadString();
		_FileBytes = new byte[r.ReadInt32()];
		_FileBytes = r.ReadBytes(_FileBytes.Length);
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_FileName);
		w.Write(_FileBytes.Length);
		w.Write(_FileBytes);
	}
}