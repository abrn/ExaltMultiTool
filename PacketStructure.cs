using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class PacketStructure : IDataStructure<byte>
{
	[CompilerGenerated]
	private sealed class _nbCp6Kf2zGoePpluniXaCgqDkEm
	{
		public Dictionary<byte, PacketStructure> _Y47d6cq6yur6qR7gPJQSTOJl5Wm;

		internal void _Iu71vpYAaRocerWHxtZjwfWPbMA(XElement packet)
		{
			PacketStructure packetStructure = new PacketStructure(packet);
			while (true)
			{
				int num = -224975064;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD1DE790Au) % 3u)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						goto IL_0029;
					case 1u:
						return;
					}
					break;
					IL_0029:
					_Y47d6cq6yur6qR7gPJQSTOJl5Wm[packetStructure._QjKHGXZ7ohXwrDQImauPaSixsVg] = packetStructure;
					num = (int)((num2 * 344809797) ^ 0x76A5466E);
				}
			}
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _ZJ4daBd7h0s4BYlhDOAm1kWMfzr
	{
		public static readonly _ZJ4daBd7h0s4BYlhDOAm1kWMfzr _003C_003E9 = new _ZJ4daBd7h0s4BYlhDOAm1kWMfzr();

		internal bool _xcNJqeWBc6PwuAIXmNSEuoazVLR(Type t)
		{
			return _Toi0CdTsRRcLpqFRR8AabzFM20p.IsAssignableFrom(t);
		}
	}

	private static Type _Toi0CdTsRRcLpqFRR8AabzFM20p = typeof(Packet);

	private static Type[] _tbwA3CYsq6dDCAhHaXDRhPwo8xq;

	[CompilerGenerated]
	private byte _p6MAdQUIoeJwjajDnswJBZlM1l9;

	public PacketType _hhdVlV7UnNEwYJGKyXm4ylA4ZAi;

	public Type _bjQd3Vpt6RdoySpzKxn7K2gQGoM;

	public byte _QjKHGXZ7ohXwrDQImauPaSixsVg
	{
		get;
		private set;
	}

	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb => _hhdVlV7UnNEwYJGKyXm4ylA4ZAi.ToString();

	internal static Dictionary<byte, PacketStructure> _uLt6b1uwFNgoZycBDqE02WmgdfB(XDocument doc)
	{
		Dictionary<byte, PacketStructure> _Y47d6cq6yur6qR7gPJQSTOJl5Wm = default(Dictionary<byte, PacketStructure>);
		while (true)
		{
			int num = 1514940714;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41D70669u) % 3u)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0028;
				default:
					doc.Element("Packets").Elements("Packet")._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(XElement packet)
					{
						PacketStructure packetStructure = new PacketStructure(packet);
						while (true)
						{
							int num3 = -224975064;
							while (true)
							{
								uint num4;
								switch ((num4 = (uint)num3 ^ 0xD1DE790Au) % 3u)
								{
								case 0u:
									break;
								default:
									return;
								case 2u:
									goto IL_0029;
								case 1u:
									return;
								}
								break;
								IL_0029:
								_Y47d6cq6yur6qR7gPJQSTOJl5Wm[packetStructure._QjKHGXZ7ohXwrDQImauPaSixsVg] = packetStructure;
								num3 = (int)((num4 * 344809797) ^ 0x76A5466E);
							}
						}
					});
					return _Y47d6cq6yur6qR7gPJQSTOJl5Wm;
				}
				break;
				IL_0028:
				_Y47d6cq6yur6qR7gPJQSTOJl5Wm = new Dictionary<byte, PacketStructure>();
				num = (int)((num2 * 665771772) ^ 0x3CA306C3);
			}
		}
	}

	public PacketStructure(XElement packet)
	{
		Type type = default(Type);
		Type[] tbwA3CYsq6dDCAhHaXDRhPwo8xq = default(Type[]);
		int num3 = default(int);
		while (true)
		{
			int num = -153661677;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9AB4FD06u) % 12u)
				{
				case 8u:
					break;
				default:
					return;
				case 1u:
				{
					_QjKHGXZ7ohXwrDQImauPaSixsVg = (byte)packet._bUyefY83pIQc4tdCSCBCAwGEWxF("PacketId", "")._sO4kfypgWPkSczoRzkVQIGw3fyF();
					int num5;
					int num6;
					if (Enum.TryParse<PacketType>(packet._bUyefY83pIQc4tdCSCBCAwGEWxF("PacketName", ""), out _hhdVlV7UnNEwYJGKyXm4ylA4ZAi))
					{
						num5 = -983037334;
						num6 = num5;
					}
					else
					{
						num5 = -1248876283;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -380517635);
					continue;
				}
				case 3u:
					type = tbwA3CYsq6dDCAhHaXDRhPwo8xq[num3];
					num = -1983266771;
					continue;
				case 11u:
				{
					int num7;
					int num8;
					if ((Activator.CreateInstance(type) as Packet).pType != _hhdVlV7UnNEwYJGKyXm4ylA4ZAi)
					{
						num7 = -1625848052;
						num8 = num7;
					}
					else
					{
						num7 = -363995198;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 587888708);
					continue;
				}
				case 10u:
					num3 = 0;
					num = (int)((num2 * 828699028) ^ 0x515170D5);
					continue;
				case 7u:
				{
					int num4;
					if (num3 < tbwA3CYsq6dDCAhHaXDRhPwo8xq.Length)
					{
						num = -599919683;
						num4 = num;
					}
					else
					{
						num = -1138170685;
						num4 = num;
					}
					continue;
				}
				case 0u:
					_bjQd3Vpt6RdoySpzKxn7K2gQGoM = type;
					num = (int)(num2 * 930373391) ^ -1299215176;
					continue;
				case 2u:
					num3++;
					num = -947115219;
					continue;
				case 9u:
					_bjQd3Vpt6RdoySpzKxn7K2gQGoM = null;
					num = -993439126;
					continue;
				case 4u:
					tbwA3CYsq6dDCAhHaXDRhPwo8xq = _tbwA3CYsq6dDCAhHaXDRhPwo8xq;
					num = ((int)num2 * -1015747719) ^ 0x13F4132C;
					continue;
				case 6u:
					_hhdVlV7UnNEwYJGKyXm4ylA4ZAi = PacketType.UNKNOWN;
					num = (int)(num2 * 25992826) ^ -2106699041;
					continue;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public override string _SflzbyPcrkdh9uZXinsV7KrbBMw()
	{
		return $"Packet: {_hhdVlV7UnNEwYJGKyXm4ylA4ZAi} (0x{_QjKHGXZ7ohXwrDQImauPaSixsVg:X})";
	}

	static PacketStructure()
	{
		while (true)
		{
			int num = -691331321;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xABF39566u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0031;
				case 1u:
					return;
				}
				break;
				IL_0031:
				_tbwA3CYsq6dDCAhHaXDRhPwo8xq = (from t in Assembly.GetAssembly(typeof(LocalProxy)).GetTypes()
					where _Toi0CdTsRRcLpqFRR8AabzFM20p.IsAssignableFrom(t)
					select t).ToArray();
				num = (int)((num2 * 1839486014) ^ 0x69133E6E);
			}
		}
	}
}
