using ExaltMultiTool.Proxy.Networking.Packets;

internal class GroundDamagePacket : Packet
{
	public int _Amount;

	public WorldPosData _Position;

	public override PacketType pType => PacketType.GROUNDDAMAGE;

	public override void readPacketData(PacketReader r)
	{
		_Amount = r.ReadInt32();
		_Position = new WorldPosData(r);
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Amount);
		_Position.Write(w);
	}
}
