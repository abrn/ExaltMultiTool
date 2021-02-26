using ExaltMultiTool.Proxy.Networking.Packets;

internal class ExaltationRedeemPacket : Packet {
	public short _ObjectId;

	public int _AttackProgress;

	public int _DefenseProgress;

	public int _SpeedProgress;

	public int _DexterityProgress;

	public int _VitalityProgress;

	public int _WisdomProgress;

	public int _LifeProgress;

	public int _ManaProgress;

	public override PacketType pType => PacketType.EXALTATIONINFORMATION;

	public override void readPacketData(PacketReader r)
	{
		_ObjectId = r.ReadInt16();
		_DexterityProgress = CompressedInt.Read(r);
		_SpeedProgress = CompressedInt.Read(r);
		_VitalityProgress = CompressedInt.Read(r);
		_WisdomProgress = CompressedInt.Read(r);
		_DefenseProgress = CompressedInt.Read(r);
		_AttackProgress = CompressedInt.Read(r);
		_ManaProgress = CompressedInt.Read(r);
		_LifeProgress = CompressedInt.Read(r);
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_ObjectId);
		CompressedInt.Write(w, _DexterityProgress);
		CompressedInt.Write(w, _SpeedProgress);
		CompressedInt.Write(w, _VitalityProgress);
		CompressedInt.Write(w, _WisdomProgress);
		CompressedInt.Write(w, _DefenseProgress);
		CompressedInt.Write(w, _AttackProgress);
		CompressedInt.Write(w, _ManaProgress);
		CompressedInt.Write(w, _LifeProgress);
	}
}