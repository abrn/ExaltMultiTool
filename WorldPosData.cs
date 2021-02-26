using System;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class WorldPosData : ICloneable, IDataObject {
	public double _PositionX;

	public double _PositionY;

	public static WorldPosData Initial => new WorldPosData(0f, 0f);

	public WorldPosData()
	{
	}

	public WorldPosData(PacketReader r)
	{
		_PositionX = r.ReadSingle();
		_PositionY = r.ReadSingle();
	}

	public WorldPosData(float x, float y)
	{
		_PositionX = x;
		_PositionY = y;
	}

	public WorldPosData(double x, double y)
	{
		_PositionX = x;
		_PositionY = y;
	}

	public virtual IDataObject Read(PacketReader r)
	{
		_PositionX = r.ReadSingle();
		_PositionY = r.ReadSingle();
		return this;
	}

	IDataObject IDataObject.Read(PacketReader r)
	{
		return this.Read(r);
	}

	public virtual void Write(PacketWriter w)
	{
		w.Write((float) _PositionX);
		w.Write((float) _PositionY);
	}

	void IDataObject.Write(PacketWriter w)
	{
		this.Write(w);
	}

	public double GetDistance(WorldPosData location)
	{
		double num = location._PositionX - _PositionX;
		double num2 = location._PositionY - _PositionY;
		return num * num + num2 * num2;
	}

	public double GetAngle(WorldPosData location)
	{
		return Math.Sqrt(GetDistance(location));
	}

	public double _rXIBypY42lUhmjQwvfVwnT1hpLd(WorldPosData l1, WorldPosData l2)
	{
		double x = l2._PositionX - l1._PositionX;
		return Math.Atan2(l2._PositionY - l1._PositionY, x);
	}

	public double _rXIBypY42lUhmjQwvfVwnT1hpLd(double x1, double y1, double x2, double y2)
	{
		double x3 = x2 - x1;
		return Math.Atan2(y2 - y1, x3);
	}

	public WorldPosData _KxM3gmGBMkIUCunUOzDZpSVchT0(double targetAngle, double targetDistance)
	{
		double x = _PositionX + Math.Cos(targetAngle) * targetDistance;
		double y = _PositionY + Math.Sin(targetAngle) * targetDistance;
		return new WorldPosData(x, y);
	}

	public static WorldPosData _KxM3gmGBMkIUCunUOzDZpSVchT0(double sourceX, double sourceY, double targetAngle,
		double targetDistance)
	{
		double x = sourceX + Math.Cos(targetAngle) * targetDistance;
		double y = sourceY + Math.Sin(targetAngle) * targetDistance;
		return new WorldPosData(x, y);
	}

	public WorldPosData AddPosition(WorldPosData loc)
	{
		return new WorldPosData(_PositionX + loc._PositionX, _PositionY + loc._PositionY);
	}

	public WorldPosData SubtractPosition(WorldPosData loc)
	{
		return new WorldPosData(_PositionX - loc._PositionX, _PositionY - loc._PositionY);
	}

	public override bool Clone(object obj)
	{
		WorldPosData worldPosData = (WorldPosData) obj;

		if (worldPosData != null) {
			if (_PositionX == worldPosData._PositionX) {
				num = 814708805;
				num3 = num;
			}
			else {
				num = 1631409242;
				num3 = num;
			}
		}
		else {
			num4 = 1441042217;
			num5 = num4;
		}

		while (true) {
			int num = 329794215;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0x4CE87B9Au) % 6u) {
					case 4u:
						break;
					case 1u: {
						int num4;
						int num5;

						num = num4 ^ (int) (num2 * 172426017);
						continue;
					}
					case 3u:
						return _PositionY == worldPosData._PositionY;
					case 5u: {
						int num3;
						

						continue;
					}
					case 0u:
						return false;
					default:
						return false;
				}

				break;
			}
		}
	}

	public void AddDistance(double value)
	{
		_PositionX *= value;
		_PositionY *= value;
	}

	public double _PSG5NwhlzdKDqstY2H9MXEITdTC(WorldPosData loc)
	{
		return double.NaN;
	}

	public virtual object Clone()
	{
		return new WorldPosData
		{
			_PositionX = _PositionX,
			_PositionY = _PositionY
		};
	}

	object ICloneable.Clone()
	{
		return Clone();
	}

	public override string ToString()
	{
		return $"{{ X={_PositionX}, Y={_PositionY} }}";
	}

	public string GetExactPosition()
	{
		return $"{{ X={_PositionX:F2}, Y={_PositionY:F2} }}";
	}
}