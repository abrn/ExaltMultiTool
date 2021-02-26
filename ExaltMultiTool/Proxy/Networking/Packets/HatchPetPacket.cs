using ExaltMultiTool.Proxy.Networking.Packets;

internal class HatchPetPacket : Packet {
	public string _PetName;

	public int _PetSkin;

	public int _PetType;

	public override PacketType pType => PacketType.HATCHPET;

	public override void readPacketData(PacketReader r)
	{
		_PetName = r.ReadString();
		_PetSkin = r.ReadInt32();
		_PetType = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_PetName);
		w.Write(_PetSkin);
		w.Write(_PetType);
	}
}