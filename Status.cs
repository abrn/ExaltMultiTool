using System;
using System.Collections.Generic;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class Status : IDataObject, ICloneable
{
	public int _ObjectId;

	public WorldPosData _Position = new WorldPosData();

	public List<StatData> _Stats;

	public IDataObject Read(PacketReader r)
	{
		_ObjectId = CompressedInt.Read(r);
		_Position.Read(r);
		int statLength = CompressedInt.Read(r);
		_Stats = new List<StatData>(statLength);

		for (int i = 0; i < statLength; i++)
		{
			_Stats.Add(new StatData(r));
		}
		return this;
	}

	public void Write(PacketWriter w)
	{
		CompressedInt.Write(w, _ObjectId);
		_Position.Write(w);
		CompressedInt.Write(w, _Stats.Count);
		foreach (StatData stat in _Stats)
		{
			stat.Write(w);
		}
	}

	public object Clone()
	{
		return new Status
		{
			_Stats = new List<StatData>(_Stats),
			_ObjectId = _ObjectId,
			_Position = (WorldPosData)_Position.Clone()
		};
	}
}
