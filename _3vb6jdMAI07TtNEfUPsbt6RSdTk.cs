using ExaltMultiTool.Proxy.Networking.Packets;

internal class _3vb6jdMAI07TtNEfUPsbt6RSdTk : Packet
{
	public int _7vFayYqfXoqBdjHAYbi8EhSQ15C;

	public int _a86ap9HYVwHYFgKLzAETrP6Yjip;

	public override PacketType pType => PacketType.RESKINUNLOCK;

	public override void readPacketData(PacketReader r)
	{
		_7vFayYqfXoqBdjHAYbi8EhSQ15C = r.ReadInt32();
		_a86ap9HYVwHYFgKLzAETrP6Yjip = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_7vFayYqfXoqBdjHAYbi8EhSQ15C);
		w.Write(_a86ap9HYVwHYFgKLzAETrP6Yjip);
	}
}
