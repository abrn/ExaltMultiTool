using System;

internal class WorldPosData : ICloneable, _o4HuntyroiA06gchVr3BoA3ebes
{
	public double _PositionX;

	public double _PositionY;

	public static WorldPosData _wqLcCTm1kWDEf2iYSYXvp4mO05R => new WorldPosData(0f, 0f);

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

	public virtual _o4HuntyroiA06gchVr3BoA3ebes _kCo2RCMYpYNoTPdfGQVnKgPh7Fc(PacketReader r)
	{
		_PositionX = r.ReadSingle();
		_PositionY = r.ReadSingle();
		return this;
	}

	_o4HuntyroiA06gchVr3BoA3ebes _o4HuntyroiA06gchVr3BoA3ebes.readTileData(PacketReader r)
	{
		return this._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r);
	}

	public virtual void _3Wc8kZJjhbRt6nttAKwD2698imm(PacketWriter w)
	{
		w.Write((float)_PositionX);
		while (true)
		{
			int num = -1475927726;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB16607A5u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_002f;
				case 1u:
					return;
				}
				break;
				IL_002f:
				w.Write((float)_PositionY);
				num = ((int)num2 * -465647702) ^ 0x1184CC4E;
			}
		}
	}

	void _o4HuntyroiA06gchVr3BoA3ebes.writeTileData(PacketWriter w)
	{
		this._3Wc8kZJjhbRt6nttAKwD2698imm(w);
	}

	public double _l97JYrnBrV9Ws5bD3UnHa879cYh(WorldPosData location)
	{
		double num = location._PositionX - _PositionX;
		double num2 = location._PositionY - _PositionY;
		return num * num + num2 * num2;
	}

	public double _zFtZUeGjkS0Ei8GwlFzZbAokBAQ(WorldPosData location)
	{
		return Math.Sqrt(_l97JYrnBrV9Ws5bD3UnHa879cYh(location));
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

	public static WorldPosData _KxM3gmGBMkIUCunUOzDZpSVchT0(double sourceX, double sourceY, double targetAngle, double targetDistance)
	{
		double x = sourceX + Math.Cos(targetAngle) * targetDistance;
		double y = sourceY + Math.Sin(targetAngle) * targetDistance;
		return new WorldPosData(x, y);
	}

	public WorldPosData _UhmQhgJbHmzkOAp7eqNlTZqWAY1(WorldPosData loc)
	{
		return new WorldPosData(_PositionX + loc._PositionX, _PositionY + loc._PositionY);
	}

	public WorldPosData _81bc1KQkWPvwZVKwf5M4k6wRSXe(WorldPosData loc)
	{
		return new WorldPosData(_PositionX - loc._PositionX, _PositionY - loc._PositionY);
	}

	public override bool _5ZXFmKvJ2hXQDu9dbsTuTPppFUP(object obj)
	{
		//Discarded unreachable code: IL_0060, IL_0093
		WorldPosData worldPosData = (WorldPosData)obj;
		while (true)
		{
			int num = 329794215;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4CE87B9Au) % 6u)
				{
				case 4u:
					break;
				case 1u:
				{
					int num4;
					int num5;
					if (worldPosData != null)
					{
						num4 = 2101672636;
						num5 = num4;
					}
					else
					{
						num4 = 1441042217;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 172426017);
					continue;
				}
				case 3u:
					return _PositionY == worldPosData._PositionY;
				case 5u:
				{
					int num3;
					if (_PositionX == worldPosData._PositionX)
					{
						num = 814708805;
						num3 = num;
					}
					else
					{
						num = 1631409242;
						num3 = num;
					}
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
		return this.Clone();
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
