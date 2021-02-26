using ExaltMultiTool.Proxy.Networking.Packets;

internal class EnemyShootPacket : Packet {
	public byte _BulletId;

	public int _OwnerId;

	public byte _BulletType;

	public WorldPosData _StartingPos;

	public float _Angle;

	public short _Damage;

	public byte _NumShots;

	public float _AngleInc;

	public override PacketType pType => PacketType.ENEMYSHOOT;

	public override void readPacketData(PacketReader r)
	{
		_BulletId = r.ReadByte();
		_OwnerId = r.ReadInt32();
		_BulletType = r.ReadByte();
		_StartingPos = new WorldPosData(r);
		_Angle = r.ReadSingle();
		_Damage = r.ReadInt16();
		if (r.BaseStream.Position < r.BaseStream.Length) {
			_NumShots = r.ReadByte();
			_AngleInc = r.ReadSingle();
		}

		_NumShots = 1;
		_AngleInc = 0f;
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_BulletId);
		w.Write(_OwnerId);
		w.Write(_BulletType);
		_StartingPos.Write(w);
		w.Write(_Angle);
		w.Write(_Damage);
		if (_NumShots == 1) {
			return;
		}

		w.Write(_NumShots);
		w.Write(_AngleInc);
	}
}