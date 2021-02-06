using ExaltMultiTool.Proxy.Networking.Packets;

internal class _bvW9B9nQePjvuk6nYxFBG5wA5YB : Packet
{
	public int _7vFayYqfXoqBdjHAYbi8EhSQ15C;

	public override PacketType pType => PacketType.RESKIN;

	public override void readPacketData(PacketReader r)
	{
		_7vFayYqfXoqBdjHAYbi8EhSQ15C = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_7vFayYqfXoqBdjHAYbi8EhSQ15C);
	}
}
