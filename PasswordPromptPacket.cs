using ExaltMultiTool.Proxy.Networking.Packets;

internal class PasswordPromptPacket : Packet
{
	public const int _gcDF5ucNX1cRytBCAAE8hBrCTY = 2;

	public const int _gFKQWWd3L8iRvC2M4mSFXjQn2RD = 3;

	public const int _xPVMS2Cn4xket4UbmlH1omWMLxp = 4;

	public int _PromptType;

	public override PacketType pType => PacketType.PASSWORDPROMPT;

	public override void readPacketData(PacketReader r)
	{
		_PromptType = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_PromptType);
	}
}
