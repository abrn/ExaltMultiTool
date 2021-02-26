using ExaltMultiTool.Proxy.Networking.Packets;

internal class EvolvePetPacket : Packet {
	public int _PetId;

	public int _InitialSkin;

	public int _FinalSkin;

	public override PacketType pType => PacketType.EVOLVEPET;

	public override void readPacketData(PacketReader r)
	{
		_PetId = r.ReadInt32();
		_InitialSkin = r.ReadInt32();
		_FinalSkin = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_PetId);
		w.Write(_InitialSkin);
		w.Write(_FinalSkin);
	}
}