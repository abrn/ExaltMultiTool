using ExaltMultiTool.Proxy.Networking.Packets;

internal class EnemyHitPacket : Packet
{
	public int _Time;

	public byte _BulletId;

	public int _TargetId;

	public bool _Killed;

	public override PacketType pType => PacketType.ENEMYHIT;

	public override void readPacketData(PacketReader r)
	{
		_Time = r.ReadInt32();
		_BulletId = r.ReadByte();
		_TargetId = r.ReadInt32();
		_Killed = r.ReadBoolean();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Time);
		w.Write(_BulletId);
		w.Write(_TargetId);
		w.Write(_Killed);
	}
}
