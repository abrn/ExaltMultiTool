using ExaltMultiTool.Proxy.Networking.Packets;

internal class AoEPacket : Packet {
	public WorldPosData _Position;

	public float _Radius;

	public ushort _Damage;

	public ConditionEffectEnum _Effect;

	public float _Duration;

	public ushort _OriginalType;

	public int _Color;

	public bool _ArmorBreaking;

	public override PacketType pType => PacketType.AOE;

	public override void readPacketData(PacketReader r)
	{
		_Position = new WorldPosData(r);
		_Radius = r.ReadSingle();
		_Damage = r.ReadUInt16();
		_Effect = (ConditionEffectEnum) r.ReadByte();
		_Duration = r.ReadSingle();
		_OriginalType = r.ReadUInt16();
		_Color = r.ReadInt32();
		_ArmorBreaking = r.ReadBoolean();
	}

	public override void writePacketData(PacketWriter w)
	{
		_Position.Write(w);
		w.Write(_Radius);
		w.Write(_Damage);
		w.Write((byte) _Effect);
		w.Write(_Duration);
		w.Write(_OriginalType);
		w.Write(_Color);
		w.Write(_ArmorBreaking);
	}
}