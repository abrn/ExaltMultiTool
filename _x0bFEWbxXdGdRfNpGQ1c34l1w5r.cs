using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using ExaltMultiTool.Proxy.DataStructures;

internal class _x0bFEWbxXdGdRfNpGQ1c34l1w5r : IDataStructure<ushort>
{
	[CompilerGenerated]
	private sealed class _il6CaNRtC7glK8w1aBjfTEQFOEA
	{
		public Dictionary<ushort, _x0bFEWbxXdGdRfNpGQ1c34l1w5r> _Y47d6cq6yur6qR7gPJQSTOJl5Wm;

		internal void _hEvcE3RIiKIFPj6Gv4aZI4HhHt1A(XElement item)
		{
			_x0bFEWbxXdGdRfNpGQ1c34l1w5r x0bFEWbxXdGdRfNpGQ1c34l1w5r = new _x0bFEWbxXdGdRfNpGQ1c34l1w5r(item);
			_Y47d6cq6yur6qR7gPJQSTOJl5Wm[x0bFEWbxXdGdRfNpGQ1c34l1w5r._QjKHGXZ7ohXwrDQImauPaSixsVg] = x0bFEWbxXdGdRfNpGQ1c34l1w5r;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _FaPUGXnwUk3sNBpjBZwILUnnusO
	{
		public static readonly _FaPUGXnwUk3sNBpjBZwILUnnusO _003C_003E9 = new _FaPUGXnwUk3sNBpjBZwILUnnusO();

		public static Func<XElement, bool> _003C_003E9__0_0;

		internal bool _Pw88G78SkWrXeOpMnSnAqolpzwm(XElement elem)
		{
			return elem._ujE3VgDdVnbxGy9qIazxpFzbjrY("Item");
		}
	}

	[CompilerGenerated]
	private ushort _p6MAdQUIoeJwjajDnswJBZlM1l9;

	public ProjectileStructure _owzIa4SA35UDyEgHwZLCFxJRPQ4;

	public int _Hgcuj8Yk2qRXttXX0EHvRYXq7I;

	public EquipTierEnum _NXYFTPTlBNIfValNYArFYakCddL;

	public byte _8vNcgGDuWbW1NeAU33KZ6cm2n7i;

	public float _DVEKL21Adaqgmr9qa9bysABJurA;

	public uint _q2CnkBKazwZ4CFq9kB6DtVsc2HA;

	public byte _bsCDavhmZ2UDlADyuj8ptf4amTK;

	public byte _YhNTfG1vuMJNUDMG7X4kP1ERPFD;

	public decimal _un2pqQ1kxK1zeYQjxzNqrHVDGKD;

	public float _I9LOulXQ6dWoDQOn1L5GkchnJUC;

	public byte _hoAe0zibJ9dZkQyZ4Bor54UWybA;

	public bool _uDqlrsRe38HAeERN7MRSc3xOFny;

	public bool _9Y5Gwd4s4IBWJQtBZ2eG3yNd0Ld;

	public bool _HR2ygW7BLEiMhHAqeXRnPwDYQmi;

	[CompilerGenerated]
	private string _Qc96P7YDwjC6nKoSJ1iVZ312wic;

	public bool _Fa3c8IOsvjq67IawKczCuEaPBRM;

	public List<_jsZwrE9lzYULBcuBQfPr4S2Du8c> _jCpZRWOsJvipfVcsNeGLqx7e6rd = new List<_jsZwrE9lzYULBcuBQfPr4S2Du8c>();

	public ushort _QjKHGXZ7ohXwrDQImauPaSixsVg
	{
		get;
		private set;
	}

	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb
	{
		get;
		private set;
	}

	internal static Dictionary<ushort, _x0bFEWbxXdGdRfNpGQ1c34l1w5r> _uLt6b1uwFNgoZycBDqE02WmgdfB(XDocument doc)
	{
		Dictionary<ushort, _x0bFEWbxXdGdRfNpGQ1c34l1w5r> _Y47d6cq6yur6qR7gPJQSTOJl5Wm = new Dictionary<ushort, _x0bFEWbxXdGdRfNpGQ1c34l1w5r>();
		(from elem in doc.Element("Objects").Elements("Object")
			where elem._ujE3VgDdVnbxGy9qIazxpFzbjrY("Item")
			select elem)._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(XElement item)
		{
			_x0bFEWbxXdGdRfNpGQ1c34l1w5r x0bFEWbxXdGdRfNpGQ1c34l1w5r = new _x0bFEWbxXdGdRfNpGQ1c34l1w5r(item);
			_Y47d6cq6yur6qR7gPJQSTOJl5Wm[x0bFEWbxXdGdRfNpGQ1c34l1w5r._QjKHGXZ7ohXwrDQImauPaSixsVg] = x0bFEWbxXdGdRfNpGQ1c34l1w5r;
		});
		return _Y47d6cq6yur6qR7gPJQSTOJl5Wm;
	}

	public _x0bFEWbxXdGdRfNpGQ1c34l1w5r(XElement item)
	{
		_QjKHGXZ7ohXwrDQImauPaSixsVg = (ushort)item._4qMIb2N5gf9DdhWw9LENt8TJhOK("type", "0x0")._59ab9VkqetpIwwmGzw45eRNlLMg();
		_NXYFTPTlBNIfValNYArFYakCddL = (item._ujE3VgDdVnbxGy9qIazxpFzbjrY("Tier") ? ((EquipTierEnum)item.Element("Tier").Value._sO4kfypgWPkSczoRzkVQIGw3fyF()) : EquipTierEnum.UT);
		_8vNcgGDuWbW1NeAU33KZ6cm2n7i = (byte)item._bUyefY83pIQc4tdCSCBCAwGEWxF("SlotType", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
		_DVEKL21Adaqgmr9qa9bysABJurA = item._bUyefY83pIQc4tdCSCBCAwGEWxF("RateOfFire", "1")._y09e3EoPW54jYelUtQzj66l0jRF();
		_q2CnkBKazwZ4CFq9kB6DtVsc2HA = (uint)item._bUyefY83pIQc4tdCSCBCAwGEWxF("feedPower", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
		_bsCDavhmZ2UDlADyuj8ptf4amTK = (byte)item._bUyefY83pIQc4tdCSCBCAwGEWxF("BagType", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
		_YhNTfG1vuMJNUDMG7X4kP1ERPFD = (byte)item._bUyefY83pIQc4tdCSCBCAwGEWxF("MpCost", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
		_un2pqQ1kxK1zeYQjxzNqrHVDGKD = (decimal)item._bUyefY83pIQc4tdCSCBCAwGEWxF("Cooldown", "0")._y09e3EoPW54jYelUtQzj66l0jRF();
		_hoAe0zibJ9dZkQyZ4Bor54UWybA = (byte)item._bUyefY83pIQc4tdCSCBCAwGEWxF("FameBonus", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
		_Fa3c8IOsvjq67IawKczCuEaPBRM = item._ujE3VgDdVnbxGy9qIazxpFzbjrY("Potion");
		if (item._ujE3VgDdVnbxGy9qIazxpFzbjrY("Activate"))
		{
			_OYi1qaJT2aAdaDNBCEJR5XP69kU(item.Elements("Activate"));
		}
		if (item._ujE3VgDdVnbxGy9qIazxpFzbjrY("Activate"))
		{
			foreach (XElement item2 in item.Elements("Activate"))
			{
				XAttribute xAttribute = item2.Attribute("radius");
				if (xAttribute != null)
				{
					float.TryParse(xAttribute.Value, out _I9LOulXQ6dWoDQOn1L5GkchnJUC);
				}
			}
		}
		_uDqlrsRe38HAeERN7MRSc3xOFny = item._ujE3VgDdVnbxGy9qIazxpFzbjrY("Soulbound");
		_9Y5Gwd4s4IBWJQtBZ2eG3yNd0Ld = item._ujE3VgDdVnbxGy9qIazxpFzbjrY("Usable");
		_HR2ygW7BLEiMhHAqeXRnPwDYQmi = item._ujE3VgDdVnbxGy9qIazxpFzbjrY("Consumable");
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = item._4qMIb2N5gf9DdhWw9LENt8TJhOK("id", "");
		_Hgcuj8Yk2qRXttXX0EHvRYXq7I = item._bUyefY83pIQc4tdCSCBCAwGEWxF("NumProjectiles", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
		if (item._ujE3VgDdVnbxGy9qIazxpFzbjrY("Projectile"))
		{
			_owzIa4SA35UDyEgHwZLCFxJRPQ4 = new ProjectileStructure(item.Element("Projectile"));
		}
	}

	private void _OYi1qaJT2aAdaDNBCEJR5XP69kU(IEnumerable<XElement> activateXMLs)
	{
		IEnumerator<XElement> enumerator = activateXMLs.GetEnumerator();
		try
		{
			while (true)
			{
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 917993727;
					num2 = num;
				}
				else
				{
					num = 836987830;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x15CA08AAu) % 4u)
					{
					case 2u:
						num = 917993727;
						continue;
					default:
						return;
					case 1u:
					{
						XElement current = enumerator.Current;
						_jCpZRWOsJvipfVcsNeGLqx7e6rd.Add(new _jsZwrE9lzYULBcuBQfPr4S2Du8c(current));
						num = 1547689017;
						continue;
					}
					case 3u:
						break;
					case 0u:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					int num4 = 1779621298;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num4 ^ 0x15CA08AAu) % 3u)
						{
						case 0u:
							break;
						default:
							goto end_IL_0069;
						case 1u:
							goto IL_008e;
						case 2u:
							goto end_IL_0069;
						}
						break;
						IL_008e:
						enumerator.Dispose();
						num4 = (int)((num3 * 1604957102) ^ 0x56F1056);
					}
				}
			}
			end_IL_0069:;
		}
	}

	public override string _SflzbyPcrkdh9uZXinsV7KrbBMw()
	{
		return $"Item: {_WL2DOBxBuX9DARzf2KPoaJbgZiCb} (0x{_QjKHGXZ7ohXwrDQImauPaSixsVg:X})";
	}
}
