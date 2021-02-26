using ExaltMultiTool.Proxy.Networking.Packets;

internal class MovePacket : Packet {
	public int _TickId;

	public int _Time;

	public uint _ServerRealtimeMs;

	public WorldPosData _NewPosition;

	public MoveRecord[] _MoveRecords;

	public override PacketType pType => PacketType.MOVE;

	public override void readPacketData(PacketReader r)
	{
		_TickId = r.ReadInt32();
		_Time = r.ReadInt32();
		_ServerRealtimeMs = r.ReadUInt32();
		_NewPosition = new WorldPosData(r);
		_MoveRecords = new MoveRecord[r.ReadInt16()];
		foreach (var t in _MoveRecords) {
			t.Read(r);
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_TickId);
		w.Write(_Time);
		w.Write(_ServerRealtimeMs);
		_NewPosition.Write(w);
		w.Write((short) _MoveRecords.Length);
		foreach (var t in _MoveRecords) {
			t.Write(w);
		}
	}
}