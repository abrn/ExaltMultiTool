using ExaltMultiTool.Proxy.Networking.Packets;

internal class UpgradePetYardPacket : Packet
{
	public int _PetYardType;

	public override PacketType pType => PacketType.PETYARDUPDATE;

	public override void readPacketData(PacketReader r)
	{
		_PetYardType = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_PetYardType);
	}
}
