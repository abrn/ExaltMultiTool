using System;
using System.Linq;
using System.Runtime.CompilerServices;

internal class _B2gBzVDzeVEP19C56oq34otnH9L : ICloneable, IDataObject
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _XzF5X7iZTajzZphbr0PgBIcidJv
	{
		public static readonly _XzF5X7iZTajzZphbr0PgBIcidJv _003C_003E9 = new _XzF5X7iZTajzZphbr0PgBIcidJv();

		public static Func<int, string> _003C_003E9__16_0;

		public static Func<int, string> _003C_003E9__16_1;

		internal string _7HJbblFC6kpnbcPBUB0hhwyp9CP(int x)
		{
			return x + " ";
		}

		internal string _O11O3ivuB9B5x9jKQUweaBH8xnB(int x)
		{
			return x + " ";
		}
	}

	public string _KOjHORhb43q8y4PiIIYbFjhd5NP;

	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public string _MnmGYCb8dvGB8oUd7qbruz9VBWQ;

	public string _OH2RdAEJ3JzMCfcZT4EwnMQdhhx;

	public int[] _E0W0Pyz3ZcZB2MfsOiCX7Avf6es;

	public int[] _tktbhaXMSz2sxAqeBLRBEVG9ZI6;

	public bool _O0kV7ezc95P6PJbVG8sd3mF9G0v;

	public bool _bDriXxQ9hSMQTkTDJrI4sxl4Izo;

	public bool _EkEBwRh2h871CbDHcJyGJZ8hqPk;

	public int _RdTnBIaKd4ABhDrGYB7oNqHgxoZ;

	public int _RVUfzbRunbPBz524BtXZWSS7n1P;

	public _B2gBzVDzeVEP19C56oq34otnH9L()
	{
	}

	public _B2gBzVDzeVEP19C56oq34otnH9L(PacketReader r)
	{
		_KOjHORhb43q8y4PiIIYbFjhd5NP = r.ReadString();
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
		_MnmGYCb8dvGB8oUd7qbruz9VBWQ = r.ReadString();
		_OH2RdAEJ3JzMCfcZT4EwnMQdhhx = r.ReadString();
		_RVUfzbRunbPBz524BtXZWSS7n1P = r.ReadInt32();
		_RdTnBIaKd4ABhDrGYB7oNqHgxoZ = r.ReadInt32();
		_E0W0Pyz3ZcZB2MfsOiCX7Avf6es = new int[r.ReadInt16()];
		for (int i = 0; i < _E0W0Pyz3ZcZB2MfsOiCX7Avf6es.Length; i++)
		{
			_E0W0Pyz3ZcZB2MfsOiCX7Avf6es[i] = r.ReadInt32();
		}
		_tktbhaXMSz2sxAqeBLRBEVG9ZI6 = new int[r.ReadInt16()];
		for (int j = 0; j < _tktbhaXMSz2sxAqeBLRBEVG9ZI6.Length; j++)
		{
			_tktbhaXMSz2sxAqeBLRBEVG9ZI6[j] = r.ReadInt32();
		}
		_O0kV7ezc95P6PJbVG8sd3mF9G0v = r.ReadBoolean();
		_bDriXxQ9hSMQTkTDJrI4sxl4Izo = r.ReadBoolean();
		_EkEBwRh2h871CbDHcJyGJZ8hqPk = r.ReadBoolean();
	}

	public IDataObject _kCo2RCMYpYNoTPdfGQVnKgPh7Fc(PacketReader r)
	{
		_KOjHORhb43q8y4PiIIYbFjhd5NP = r.ReadString();
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = -16188653;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80E425E3u) % 17u)
				{
				case 12u:
					break;
				case 13u:
					_bDriXxQ9hSMQTkTDJrI4sxl4Izo = r.ReadBoolean();
					num = ((int)num2 * -1126216075) ^ 0x204161C2;
					continue;
				case 4u:
					_RdTnBIaKd4ABhDrGYB7oNqHgxoZ = r.ReadInt32();
					num = (int)((num2 * 255109745) ^ 0x4E2AF11A);
					continue;
				case 15u:
					num3++;
					num = (int)((num2 * 92542477) ^ 0x36A9A8F8);
					continue;
				case 8u:
					_tktbhaXMSz2sxAqeBLRBEVG9ZI6 = new int[r.ReadInt16()];
					num4 = 0;
					num = (int)(num2 * 671811585) ^ -1812700938;
					continue;
				case 9u:
					_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
					_MnmGYCb8dvGB8oUd7qbruz9VBWQ = r.ReadString();
					num = ((int)num2 * -314437507) ^ 0x104343C9;
					continue;
				case 11u:
					num4++;
					num = ((int)num2 * -721682340) ^ 0x72857E5D;
					continue;
				case 5u:
					_OH2RdAEJ3JzMCfcZT4EwnMQdhhx = r.ReadString();
					num = ((int)num2 * -1446170012) ^ 0x5A1C2A78;
					continue;
				case 3u:
					_O0kV7ezc95P6PJbVG8sd3mF9G0v = r.ReadBoolean();
					num = ((int)num2 * -601183020) ^ -554591109;
					continue;
				case 6u:
					_E0W0Pyz3ZcZB2MfsOiCX7Avf6es[num3] = r.ReadInt32();
					num = -869107348;
					continue;
				case 2u:
					_tktbhaXMSz2sxAqeBLRBEVG9ZI6[num4] = r.ReadInt32();
					num = -432420902;
					continue;
				case 10u:
				{
					int num6;
					if (num3 >= _E0W0Pyz3ZcZB2MfsOiCX7Avf6es.Length)
					{
						num = -697254092;
						num6 = num;
					}
					else
					{
						num = -846135272;
						num6 = num;
					}
					continue;
				}
				case 0u:
				{
					int num5;
					if (num4 >= _tktbhaXMSz2sxAqeBLRBEVG9ZI6.Length)
					{
						num = -784453429;
						num5 = num;
					}
					else
					{
						num = -2000700865;
						num5 = num;
					}
					continue;
				}
				case 7u:
					_RVUfzbRunbPBz524BtXZWSS7n1P = r.ReadInt32();
					num = (int)(num2 * 505765642) ^ -2048505331;
					continue;
				case 14u:
					_EkEBwRh2h871CbDHcJyGJZ8hqPk = r.ReadBoolean();
					num = ((int)num2 * -1944025235) ^ -625912315;
					continue;
				case 16u:
					_E0W0Pyz3ZcZB2MfsOiCX7Avf6es = new int[r.ReadInt16()];
					num3 = 0;
					num = ((int)num2 * -424454505) ^ 0x4C32E7D4;
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
		//ILSpy generated this explicit interface implementation from .override directive in readPacketData
		return this._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r);
	}

	public void _3Wc8kZJjhbRt6nttAKwD2698imm(PacketWriter w)
	{
		w.Write(_KOjHORhb43q8y4PiIIYbFjhd5NP);
		int num3 = default(int);
		int[] array = default(int[]);
		int value2 = default(int);
		int value = default(int);
		while (true)
		{
			int num = -1624298529;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB2A03D2Cu) % 20u)
				{
				case 6u:
					break;
				default:
					return;
				case 14u:
					num3++;
					num = (int)(num2 * 501261264) ^ -1446736074;
					continue;
				case 9u:
					w.Write(_RVUfzbRunbPBz524BtXZWSS7n1P);
					num = (int)((num2 * 983484570) ^ 0x6A24CF19);
					continue;
				case 12u:
					array = _tktbhaXMSz2sxAqeBLRBEVG9ZI6;
					num = (int)((num2 * 1153127061) ^ 0x25AE9149);
					continue;
				case 0u:
					w.Write(_MnmGYCb8dvGB8oUd7qbruz9VBWQ);
					w.Write(_OH2RdAEJ3JzMCfcZT4EwnMQdhhx);
					num = (int)(num2 * 235815682) ^ -1810458855;
					continue;
				case 19u:
					w.Write(value2);
					num = ((int)num2 * -1328998515) ^ 0x3BAAA027;
					continue;
				case 18u:
					w.Write(_O0kV7ezc95P6PJbVG8sd3mF9G0v);
					w.Write(_bDriXxQ9hSMQTkTDJrI4sxl4Izo);
					w.Write(_EkEBwRh2h871CbDHcJyGJZ8hqPk);
					num = (int)(num2 * 1645388434) ^ -324489947;
					continue;
				case 2u:
					w.Write((short)_E0W0Pyz3ZcZB2MfsOiCX7Avf6es.Length);
					array = _E0W0Pyz3ZcZB2MfsOiCX7Avf6es;
					num3 = 0;
					num = ((int)num2 * -1416275114) ^ 0x6278EC0;
					continue;
				case 11u:
					value2 = array[num3];
					num = -737454889;
					continue;
				case 8u:
					num = (int)((num2 * 1634600384) ^ 0x4B3A05C9);
					continue;
				case 7u:
					w.Write(value);
					num = ((int)num2 * -1099530677) ^ -1882946229;
					continue;
				case 5u:
				{
					int num5;
					if (num3 < array.Length)
					{
						num = -355366181;
						num5 = num;
					}
					else
					{
						num = -1220451507;
						num5 = num;
					}
					continue;
				}
				case 17u:
					num3 = 0;
					num = ((int)num2 * -1464355247) ^ -1921629477;
					continue;
				case 15u:
					w.Write(_RdTnBIaKd4ABhDrGYB7oNqHgxoZ);
					num = (int)(num2 * 316634987) ^ -1681825917;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -773443965) ^ 0x130DC855;
					continue;
				case 3u:
					w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
					num = (int)(num2 * 17834748) ^ -1378014736;
					continue;
				case 10u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -1298424810;
						num4 = num;
					}
					else
					{
						num = -1144289764;
						num4 = num;
					}
					continue;
				}
				case 1u:
					w.Write((short)_tktbhaXMSz2sxAqeBLRBEVG9ZI6.Length);
					num = ((int)num2 * -821277022) ^ -1269313866;
					continue;
				case 16u:
					value = array[num3];
					num = -1322150381;
					continue;
				case 13u:
					return;
				}
				break;
			}
		}
	}

	void IDataObject.Write(PacketWriter w)
	{
		//ILSpy generated this explicit interface implementation from .override directive in writePacketData
		this._3Wc8kZJjhbRt6nttAKwD2698imm(w);
	}

	public object Clone()
	{
		return new _B2gBzVDzeVEP19C56oq34otnH9L
		{
			_KOjHORhb43q8y4PiIIYbFjhd5NP = _KOjHORhb43q8y4PiIIYbFjhd5NP,
			_WL2DOBxBuX9DARzf2KPoaJbgZiCb = _WL2DOBxBuX9DARzf2KPoaJbgZiCb,
			_MnmGYCb8dvGB8oUd7qbruz9VBWQ = _MnmGYCb8dvGB8oUd7qbruz9VBWQ,
			_E0W0Pyz3ZcZB2MfsOiCX7Avf6es = _E0W0Pyz3ZcZB2MfsOiCX7Avf6es,
			_tktbhaXMSz2sxAqeBLRBEVG9ZI6 = _tktbhaXMSz2sxAqeBLRBEVG9ZI6,
			_O0kV7ezc95P6PJbVG8sd3mF9G0v = _O0kV7ezc95P6PJbVG8sd3mF9G0v,
			_bDriXxQ9hSMQTkTDJrI4sxl4Izo = _bDriXxQ9hSMQTkTDJrI4sxl4Izo,
			_RdTnBIaKd4ABhDrGYB7oNqHgxoZ = _RdTnBIaKd4ABhDrGYB7oNqHgxoZ,
			_EkEBwRh2h871CbDHcJyGJZ8hqPk = _EkEBwRh2h871CbDHcJyGJZ8hqPk
		};
	}

	object ICloneable.Clone()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clone
		return this.Clone();
	}

	public override string _SflzbyPcrkdh9uZXinsV7KrbBMw()
	{
		return string.Format("{{ Id={0}, Name={1}, Description={2}, Requirements={3}, Rewards={4}, Completed={5}, ItemOfChoice={6}, Category={7}, Repeatable={8} }}", _KOjHORhb43q8y4PiIIYbFjhd5NP, _WL2DOBxBuX9DARzf2KPoaJbgZiCb, _MnmGYCb8dvGB8oUd7qbruz9VBWQ, _E0W0Pyz3ZcZB2MfsOiCX7Avf6es.Select((int x) => x + " "), _tktbhaXMSz2sxAqeBLRBEVG9ZI6.Select((int x) => x + " "), _O0kV7ezc95P6PJbVG8sd3mF9G0v, _bDriXxQ9hSMQTkTDJrI4sxl4Izo, _RdTnBIaKd4ABhDrGYB7oNqHgxoZ, _EkEBwRh2h871CbDHcJyGJZ8hqPk);
	}

	public string _UZGgz4bP7SMNERWpkWxMiSF1QFb()
	{
		return "{ Name=" + _WL2DOBxBuX9DARzf2KPoaJbgZiCb + ", Id=" + _KOjHORhb43q8y4PiIIYbFjhd5NP + " }";
	}
}
