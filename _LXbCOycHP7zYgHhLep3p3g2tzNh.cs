using ExaltMultiTool.Proxy.Networking.Packets;

internal class _LXbCOycHP7zYgHhLep3p3g2tzNh : Packet
{
	public string _V7TDuLXMwmk0AAsub98TQNpZr5G;

	public string _MTTbeAIYRAEUc9BzZzIv47ljsem;

	public override PacketType pType => PacketType.CLAIMLOGINREWARDMSG;

	public override void readPacketData(PacketReader r)
	{
		_V7TDuLXMwmk0AAsub98TQNpZr5G = r.ReadString();
		_MTTbeAIYRAEUc9BzZzIv47ljsem = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_V7TDuLXMwmk0AAsub98TQNpZr5G);
		w.Write(_MTTbeAIYRAEUc9BzZzIv47ljsem);
	}
}
