using System;
using System.Collections.Generic;

internal class _AunOm2zlKr0KANkRBzogPcg538K : ICloneable
{
	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public WorldPosData _ObXrbtVZcdprxclR2Ggz9jKwlp = new WorldPosData();

	public List<StatData> _Stats;

	public _o4HuntyroiA06gchVr3BoA3ebes _kCo2RCMYpYNoTPdfGQVnKgPh7Fc(PacketReader r)
	{
		_fn2CRnBpjyTWHR9K8SU4iOwhDtK = CompressedInt.Read(r);
		_ObXrbtVZcdprxclR2Ggz9jKwlp._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 302206627;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x62F8B425u) % 9u)
				{
				case 4u:
					break;
				case 6u:
					num4 = CompressedInt.Read(r);
					num = (int)(num2 * 1211264639) ^ -1793772415;
					continue;
				case 0u:
				{
					int num5;
					if (num3 >= num4)
					{
						num = 299163759;
						num5 = num;
					}
					else
					{
						num = 1612846575;
						num5 = num;
					}
					continue;
				}
				case 8u:
					num3 = 0;
					num = ((int)num2 * -1976390726) ^ -800893707;
					continue;
				case 3u:
					_Stats = new List<StatData>(num4);
					num = ((int)num2 * -631471531) ^ 0x2829A36A;
					continue;
				case 7u:
					_Stats.Add(new StatData(r));
					num = 128756763;
					continue;
				case 2u:
					num = (int)(num2 * 1064852125) ^ -1695696398;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1963686638) ^ 0x59BB8D3C;
					continue;
				default:
					return this;
				}
				break;
			}
		}
	}

	public void _3Wc8kZJjhbRt6nttAKwD2698imm(PacketWriter w)
	{
		CompressedInt.write(w, _fn2CRnBpjyTWHR9K8SU4iOwhDtK);
		_ObXrbtVZcdprxclR2Ggz9jKwlp._3Wc8kZJjhbRt6nttAKwD2698imm(w);
		CompressedInt.write(w, _Stats.Count);
		using List<StatData>.Enumerator enumerator = _Stats.GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = 1316894114;
				num2 = num;
			}
			else
			{
				num = 1224011491;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x15B09100u) % 4u)
				{
				case 0u:
					num = 1224011491;
					continue;
				default:
					return;
				case 3u:
					enumerator.Current.Write(w);
					num = 407803761;
					continue;
				case 1u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public object Clone()
	{
		return new _AunOm2zlKr0KANkRBzogPcg538K
		{
			_Stats = new List<StatData>(_Stats),
			_fn2CRnBpjyTWHR9K8SU4iOwhDtK = _fn2CRnBpjyTWHR9K8SU4iOwhDtK,
			_ObXrbtVZcdprxclR2Ggz9jKwlp = (WorldPosData)_ObXrbtVZcdprxclR2Ggz9jKwlp.Clone()
		};
	}
}
