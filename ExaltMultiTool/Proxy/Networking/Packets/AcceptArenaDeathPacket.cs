using ExaltMultiTool.Proxy.Networking.Packets;

internal class AcceptArenaDeathPacket : Packet
{
	public int _Currency;

	public override PacketType pType => PacketType.ACCEPTARENADEATH;

	public override void readPacketData(PacketReader r)
	{
		_Currency = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Currency);
	}
}
