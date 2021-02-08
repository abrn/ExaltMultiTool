using ExaltMultiTool.Proxy.Networking.Packets;

internal class ArenaDeathPacket : Packet
{
	public int _C4xeOfuhlhu6pgdAMQJYMNi7lkG;

	public override PacketType pType => PacketType.ARENADEATH;

	public override void readPacketData(PacketReader r)
	{
		_C4xeOfuhlhu6pgdAMQJYMNi7lkG = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_C4xeOfuhlhu6pgdAMQJYMNi7lkG);
	}
}
