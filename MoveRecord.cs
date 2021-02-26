internal class MoveRecord : WorldPosData {
	private int _time;

	public MoveRecord(int time, double x, double y)
	{
		_time = time;
		_PositionX = x;
		_PositionY = y;
	}

	public MoveRecord(PacketReader r)
	{
		_time = r.ReadInt32();
		base.Read(r);
	}

	public override IDataObject Read(PacketReader r)
	{
		_time = r.ReadInt32();
		base.Read(r);
		return this;
	}

	public override void Write(PacketWriter w)
	{
		w.Write(_time);
		base.Write(w);
	}

	public override string ToString()
	{
		return "{ Time=" + _time + ", X=" + _PositionX + ", Y=" + _PositionY + " }";
	}
}