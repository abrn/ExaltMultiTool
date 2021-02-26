using System;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class _zVFeZ2O0dLyAgYedMwD2SrzVOFB : ICloneable, IDataObject
{
	public int _6HwO75kWNssUCje1MLwKd3pGXmk;

	public int _CmwC8GuQ56hi7QXOmmQpFukQ49j;

	public byte[] _0WMjfJphUj6JnIm1ZkD3ScpYc0F = new byte[0];

	public IDataObject _kCo2RCMYpYNoTPdfGQVnKgPh7Fc(PacketReader r)
	{
		_6HwO75kWNssUCje1MLwKd3pGXmk = r.ReadInt32();
		while (true)
		{
			int num = -1261019675;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90B31AC3u) % 5u)
				{
				case 4u:
					break;
				case 1u:
					_CmwC8GuQ56hi7QXOmmQpFukQ49j = r.ReadInt32();
					num = ((int)num2 * -1328186468) ^ -1494845555;
					continue;
				case 0u:
					_0WMjfJphUj6JnIm1ZkD3ScpYc0F = r.ReadBytes(_0WMjfJphUj6JnIm1ZkD3ScpYc0F.Length);
					num = (int)(num2 * 1547716406) ^ -1160647925;
					continue;
				case 2u:
					_0WMjfJphUj6JnIm1ZkD3ScpYc0F = new byte[_6HwO75kWNssUCje1MLwKd3pGXmk * _CmwC8GuQ56hi7QXOmmQpFukQ49j * 4];
					num = ((int)num2 * -699263701) ^ 0x69B9B20;
					continue;
				default:
					return this;
				}
				break;
			}
		}
	}

	IDataObject IDataObject.Read(PacketReader r)
	{
		return this._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r);
	}

	public void _3Wc8kZJjhbRt6nttAKwD2698imm(PacketWriter w)
	{
		w.Write(_6HwO75kWNssUCje1MLwKd3pGXmk);
		while (true)
		{
			int num = 1834267599;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2283FC9Cu) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					w.Write(_CmwC8GuQ56hi7QXOmmQpFukQ49j);
					num = ((int)num2 * -791883695) ^ -1297506035;
					continue;
				case 2u:
					w.Write(_0WMjfJphUj6JnIm1ZkD3ScpYc0F);
					num = (int)((num2 * 97453392) ^ 0x1E0422ED);
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	void IDataObject.Write(PacketWriter w)
	{
		this._3Wc8kZJjhbRt6nttAKwD2698imm(w);
	}

	public object Clone()
	{
		byte[] destinationArray = new byte[_6HwO75kWNssUCje1MLwKd3pGXmk * _CmwC8GuQ56hi7QXOmmQpFukQ49j * 4];
		
		Array.Copy(_0WMjfJphUj6JnIm1ZkD3ScpYc0F, destinationArray, _0WMjfJphUj6JnIm1ZkD3ScpYc0F.Length);
		
		return new _zVFeZ2O0dLyAgYedMwD2SrzVOFB
		{
			_6HwO75kWNssUCje1MLwKd3pGXmk = _6HwO75kWNssUCje1MLwKd3pGXmk,
			_CmwC8GuQ56hi7QXOmmQpFukQ49j = _CmwC8GuQ56hi7QXOmmQpFukQ49j,
			_0WMjfJphUj6JnIm1ZkD3ScpYc0F = destinationArray
		};
	}

	object ICloneable.Clone()
	{
		return this.Clone();
	}

	public override string ToString()
	{
		return "{ Width=" + _6HwO75kWNssUCje1MLwKd3pGXmk + ", Height=" + _CmwC8GuQ56hi7QXOmmQpFukQ49j + " }";
	}
}
