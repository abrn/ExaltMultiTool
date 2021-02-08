using ExaltMultiTool.Proxy.Networking.Packets;

internal class RealmHeroesLeftPacket : Packet
{
	public int _Amount;

	public override PacketType pType => PacketType.REALMHEROLEFTMSG;

	public override void readPacketData(PacketReader r)
	{
		_Amount = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Amount);
	}
}
