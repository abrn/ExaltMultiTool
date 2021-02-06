using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using ExaltMultiTool;

internal class _43cOn6b6nvUWFQb5wNCxMz6wXbD
{
	private struct _0U13Xaadumfh3Rq7bosOpHHI8EN
	{
		public readonly short _J6Qj5cLLcu6lzA6QjEWC7AHwMFB;

		public readonly short _xtqbgJ9lwGkC3oZ29UIr5OCkpsaA;

		public _0U13Xaadumfh3Rq7bosOpHHI8EN(short x, short y)
		{
			_J6Qj5cLLcu6lzA6QjEWC7AHwMFB = x;
			_xtqbgJ9lwGkC3oZ29UIr5OCkpsaA = y;
		}

		public static byte[] _CbMmKhs21CLB3H4EaQTZreneGph(short X, short Y)
		{
			ulong num = (ulong)((X << 12) | Y);
			return new byte[3]
			{
				(byte)(num & 0xFF),
				(byte)((num & 0xFF00) >> 8),
				(byte)((num & 0xFF0000) >> 16)
			};
		}

		public static _0U13Xaadumfh3Rq7bosOpHHI8EN _VuGQzPz5BlDDbNI6o6p0eomGn6K(byte[] bytes)
		{
			uint num = (uint)(bytes[0] | (bytes[1] << 8) | (bytes[2] << 16));
			return new _0U13Xaadumfh3Rq7bosOpHHI8EN((short)(num >> 12), (short)(num & 0xFFF));
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _gNeDDzod0TVEG0yBVZymoO3g5Uz
	{
		public static readonly _gNeDDzod0TVEG0yBVZymoO3g5Uz _003C_003E9 = new _gNeDDzod0TVEG0yBVZymoO3g5Uz();

		public static Func<TileObject, _0U13Xaadumfh3Rq7bosOpHHI8EN> _003C_003E9__21_0;

		public static Func<TileObject, ushort> _003C_003E9__21_1;

		internal _0U13Xaadumfh3Rq7bosOpHHI8EN _fvfEm1v1tELzIOZsQbT5kCWb2jP(TileObject tile)
		{
			return new _0U13Xaadumfh3Rq7bosOpHHI8EN(tile._PositionX, tile._PositionY);
		}

		internal ushort _5JYmMOpKXCwg27JQjcrCz4w43VD(TileObject tile)
		{
			return tile._TileType;
		}
	}

	private const bool _Zzy7Q19bKLXC2sm9VH23wjhnDfE = false;

	private const int _nh2dRpZc18boLQJp3P0xoX85AJj = 14953;

	private const int _PujC7HPlBwNd9LkumU10cGGvtII = 26;

	private const int _X9KTu6ZsXdOCzm2VrrmDgB6clEX = 14607;

	private const int _VCU5TAWHRBcKJ0ykLp3T2xQ61mg = 14773;

	private static readonly int _EN82d0jtZm8Sayd3HQlz8Ln4QtA;

	private const string _L4NHw3UbrV0SNf9eRyvX1MlVaDR = "Realm of the Mad God World ";

	private static Dictionary<string, TileObject[]> _mSvpBPlipdsNUWuyAElUB63MoQT;

	private static Dictionary<byte, Dictionary<_0U13Xaadumfh3Rq7bosOpHHI8EN, ushort>> _1MwomaL4fZiFdEhSaMGMmtPSZkA;

	private static Dictionary<string, int> _2uy3SiURqP8Ecgmfnt4rRpGfe5y;

	private _PlferqYaObizDfc28C5jdKSLGq5 _50w8wVuv8bL5nhKaR2EHxjrTamB;

	private bool _RUI6iBtBZM0XLmrUDMinIhEAG2x;

	private bool _fVjbLMTSqfCctBSedaVkqFVNHDC;

	private TileObject[] _F7Y8qQ4RTW5wNNysh8CWJAOgnnd;

	private int _2rY9Z6KeYzFoyTpIKnOXk8JbiYg;

	private List<TileObject> _nGFHI34bFQlA1D7Rbw8sSPcGyBB;

	private Dictionary<int, int> _EXLS5R4QkJzFpGYxL48SlucMyVB;

	private string _M2RcPC2J4Jc1ncdCsJJYHM1k0ai = "";

	static _43cOn6b6nvUWFQb5wNCxMz6wXbD()
	{
		_EN82d0jtZm8Sayd3HQlz8Ln4QtA = "map_".Length;
		_mSvpBPlipdsNUWuyAElUB63MoQT = null;
		while (true)
		{
			int num = -909844955;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8EC9B7B4u) % 4u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					_1MwomaL4fZiFdEhSaMGMmtPSZkA = null;
					num = (int)((num2 * 1258497993) ^ 0x51215A9A);
					continue;
				case 3u:
					_2uy3SiURqP8Ecgmfnt4rRpGfe5y = new Dictionary<string, int>();
					_a3EFUCdw6YgGgD3X2gxdrKBlSIf();
					num = (int)(num2 * 1100369938) ^ -161641666;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public _43cOn6b6nvUWFQb5wNCxMz6wXbD(_PlferqYaObizDfc28C5jdKSLGq5 client)
	{
		_50w8wVuv8bL5nhKaR2EHxjrTamB = client;
	}

	private static void _a3EFUCdw6YgGgD3X2gxdrKBlSIf()
	{
		//Discarded unreachable code: IL_002f
		if (_mSvpBPlipdsNUWuyAElUB63MoQT != null)
		{
			goto IL_0007;
		}
		goto IL_003f;
		IL_003f:
		Dictionary<string, TileObject[]> dictionary = new Dictionary<string, TileObject[]>();
		int num = -1723108946;
		goto IL_000c;
		IL_000c:
		uint num2;
		switch ((num2 = (uint)num ^ 0xEE85EE1Au) % 4u)
		{
		case 3u:
			break;
		case 1u:
			return;
		case 2u:
			goto IL_003f;
		default:
		{
			IDictionaryEnumerator enumerator = new ResourceManager(typeof(_T9CRlGl5cMye085x04E5GUP8aVo)).GetResourceSet(CultureInfo.CurrentUICulture, createIfNotExists: true, tryParents: true).GetEnumerator();
			try
			{
				string text = default(string);
				byte[] array = default(byte[]);
				ushort type = default(ushort);
				int num6 = default(int);
				int num5 = default(int);
				byte[] array2 = default(byte[]);
				List<TileObject> list = default(List<TileObject>);
				_0U13Xaadumfh3Rq7bosOpHHI8EN _0U13Xaadumfh3Rq7bosOpHHI8EN = default(_0U13Xaadumfh3Rq7bosOpHHI8EN);
				while (enumerator.MoveNext())
				{
					while (true)
					{
						IL_0121:
						DictionaryEntry dictionaryEntry = (DictionaryEntry)enumerator.Current;
						int num3 = -1649133778;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xEE85EE1Au) % 6u)
							{
							case 3u:
								num3 = -121044624;
								continue;
							case 1u:
								break;
							case 5u:
								goto IL_00de;
							case 4u:
								text = dictionaryEntry.Key.ToString();
								num3 = (int)((num2 * 987751107) ^ 0x7F0E522B);
								continue;
							case 2u:
								goto IL_0121;
							default:
								goto IL_0137;
							}
							text = text.Substring(_EN82d0jtZm8Sayd3HQlz8Ln4QtA).Replace('_', ' ');
							array = dictionaryEntry.Value as byte[];
							if (array == null)
							{
								break;
							}
							num3 = (int)((num2 * 718869203) ^ 0xF192C49);
							continue;
							IL_0137:
							MemoryStream memoryStream = new MemoryStream(_VuGQzPz5BlDDbNI6o6p0eomGn6K(array));
							try
							{
								BinaryReader binaryReader = new BinaryReader(memoryStream);
								while (true)
								{
									int num4 = -973823452;
									while (true)
									{
										switch ((num2 = (uint)num4 ^ 0xEE85EE1Au) % 12u)
										{
										case 11u:
											break;
										case 1u:
											type = binaryReader.ReadUInt16();
											num6 = binaryReader.ReadInt32();
											num4 = -471848681;
											continue;
										case 5u:
											num5 = 0;
											num4 = (int)((num2 * 1091198356) ^ 0x63E284FA);
											continue;
										case 9u:
										{
											int num8;
											if (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
											{
												num4 = -2110028965;
												num8 = num4;
											}
											else
											{
												num4 = -713374646;
												num8 = num4;
											}
											continue;
										}
										case 8u:
										{
											array2 = binaryReader.ReadBytes(3);
											int num9;
											if (array2.Length == 3)
											{
												num4 = -2012193032;
												num9 = num4;
											}
											else
											{
												num4 = -820292284;
												num9 = num4;
											}
											continue;
										}
										case 7u:
											num4 = ((int)num2 * -44396139) ^ -270334148;
											continue;
										case 6u:
											list = new List<TileObject>();
											num4 = ((int)num2 * -594207148) ^ -2059152059;
											continue;
										case 2u:
											_0U13Xaadumfh3Rq7bosOpHHI8EN = _0U13Xaadumfh3Rq7bosOpHHI8EN._VuGQzPz5BlDDbNI6o6p0eomGn6K(array2);
											num4 = (int)(num2 * 1206603490) ^ -1667683791;
											continue;
										case 10u:
											num5++;
											num4 = -1471526786;
											continue;
										case 0u:
										{
											int num7;
											if (num5 < num6)
											{
												num4 = -484487338;
												num7 = num4;
											}
											else
											{
												num4 = -1174344401;
												num7 = num4;
											}
											continue;
										}
										case 3u:
											list.Add(new TileObject(_0U13Xaadumfh3Rq7bosOpHHI8EN._J6Qj5cLLcu6lzA6QjEWC7AHwMFB, _0U13Xaadumfh3Rq7bosOpHHI8EN._xtqbgJ9lwGkC3oZ29UIr5OCkpsaA, type));
											num4 = ((int)num2 * -1672513441) ^ -2026670923;
											continue;
										default:
											dictionary.Add(text, list.ToArray());
											goto end_IL_0145;
										}
										break;
									}
								}
								end_IL_0145:;
							}
							finally
							{
								if (memoryStream != null)
								{
									while (true)
									{
										int num10 = -131287716;
										while (true)
										{
											switch ((num2 = (uint)num10 ^ 0xEE85EE1Au) % 3u)
											{
											case 0u:
												break;
											default:
												goto end_IL_02ca;
											case 1u:
												goto IL_02f1;
											case 2u:
												goto end_IL_02ca;
											}
											break;
											IL_02f1:
											((IDisposable)memoryStream).Dispose();
											num10 = ((int)num2 * -355282007) ^ -970136908;
										}
									}
								}
								end_IL_02ca:;
							}
							break;
							IL_00de:
							if (!text.StartsWith("map_"))
							{
								break;
							}
							num3 = (int)(num2 * 848135180) ^ -68506185;
						}
						break;
					}
				}
			}
			finally
			{
				IDisposable disposable = enumerator as IDisposable;
				if (disposable != null)
				{
					while (true)
					{
						int num11 = -1956953417;
						while (true)
						{
							switch ((num2 = (uint)num11 ^ 0xEE85EE1Au) % 3u)
							{
							case 0u:
								break;
							default:
								goto end_IL_0316;
							case 2u:
								goto IL_0345;
							case 1u:
								goto end_IL_0316;
							}
							break;
							IL_0345:
							disposable.Dispose();
							num11 = (int)(num2 * 1561853193) ^ -802070462;
						}
					}
				}
				end_IL_0316:;
			}
			_mSvpBPlipdsNUWuyAElUB63MoQT = new Dictionary<string, TileObject[]>(dictionary.Count);
			_1MwomaL4fZiFdEhSaMGMmtPSZkA = new Dictionary<byte, Dictionary<_0U13Xaadumfh3Rq7bosOpHHI8EN, ushort>>();
			using Dictionary<string, TileObject[]>.Enumerator enumerator2 = dictionary.GetEnumerator();
			TileObject[] value2 = default(TileObject[]);
			KeyValuePair<string, TileObject[]> current = default(KeyValuePair<string, TileObject[]>);
			string fileNameWithoutExtension = default(string);
			Dictionary<_0U13Xaadumfh3Rq7bosOpHHI8EN, ushort> value = default(Dictionary<_0U13Xaadumfh3Rq7bosOpHHI8EN, ushort>);
			byte key = default(byte);
			while (true)
			{
				int num12;
				int num13;
				if (!enumerator2.MoveNext())
				{
					num12 = -205862173;
					num13 = num12;
				}
				else
				{
					num12 = -2092813687;
					num13 = num12;
				}
				while (true)
				{
					switch ((num2 = (uint)num12 ^ 0xEE85EE1Au) % 12u)
					{
					case 0u:
						num12 = -2092813687;
						continue;
					default:
						return;
					case 6u:
						value2 = current.Value.ToArray();
						fileNameWithoutExtension = Path.GetFileNameWithoutExtension(current.Key);
						num12 = -1548691561;
						continue;
					case 11u:
					{
						int num16;
						int num17;
						if (!current.Key.EndsWith(" sand"))
						{
							num16 = 2087199581;
							num17 = num16;
						}
						else
						{
							num16 = 1014365296;
							num17 = num16;
						}
						num12 = num16 ^ (int)(num2 * 490236247);
						continue;
					}
					case 9u:
						value = current.Value.ToDictionary((TileObject tile) => new _0U13Xaadumfh3Rq7bosOpHHI8EN(tile._PositionX, tile._PositionY), (TileObject tile) => tile._TileType);
						num12 = -663268308;
						continue;
					case 3u:
						current = enumerator2.Current;
						num12 = -454491598;
						continue;
					case 2u:
						_1MwomaL4fZiFdEhSaMGMmtPSZkA.Add(key, value);
						num12 = ((int)num2 * -1636683112) ^ -58639676;
						continue;
					case 8u:
						break;
					case 10u:
						num12 = (int)((num2 * 238415657) ^ 0x2F2CB310);
						continue;
					case 1u:
						_mSvpBPlipdsNUWuyAElUB63MoQT.Add(fileNameWithoutExtension, value2);
						num12 = ((int)num2 * -432712447) ^ 0xB7DC363;
						continue;
					case 7u:
					{
						string text2 = current.Key.Substring("Realm of the Mad God World ".Length);
						key = byte.Parse(text2.Substring(0, (text2[1] == ' ') ? 1 : 2));
						num12 = -510030405;
						continue;
					}
					case 4u:
					{
						int num14;
						int num15;
						if (!current.Key.StartsWith("Realm of the Mad God World "))
						{
							num14 = 530027416;
							num15 = num14;
						}
						else
						{
							num14 = 1387078505;
							num15 = num14;
						}
						num12 = num14 ^ ((int)num2 * -1602111185);
						continue;
					}
					case 5u:
						return;
					}
					break;
				}
			}
		}
		}
		goto IL_0007;
		IL_0007:
		num = -1145991845;
		goto IL_000c;
	}

	public void _DT5vfLbxw23gMixKpQ7yxEiQkEe(MapInfoPacket mapInfo)
	{
		//Discarded unreachable code: IL_0084, IL_00ec, IL_02dd
		_2rY9Z6KeYzFoyTpIKnOXk8JbiYg = 0;
		if (_mSvpBPlipdsNUWuyAElUB63MoQT == null)
		{
			goto IL_000e;
		}
		goto IL_0058;
		IL_0058:
		_RUI6iBtBZM0XLmrUDMinIhEAG2x = (_fVjbLMTSqfCctBSedaVkqFVNHDC = mapInfo._MapName == "Realm of the Mad God");
		int num = -521745439;
		goto IL_0013;
		IL_0013:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xCD6CC869u) % 5u)
			{
			case 3u:
				break;
			case 1u:
				Program._et8c2Heqb7KWtXL1gFN1nBBGIVP("client", "Maps list is null, unable to replace maps, trying to parse again");
				num = (int)((num2 * 1618470755) ^ 0x7D4C0262);
				continue;
			case 0u:
				goto IL_0058;
			case 4u:
				_a3EFUCdw6YgGgD3X2gxdrKBlSIf();
				return;
			default:
				goto IL_0097;
			}
			break;
		}
		goto IL_000e;
		IL_0097:
		using (Dictionary<string, TileObject[]>.Enumerator enumerator = _mSvpBPlipdsNUWuyAElUB63MoQT.GetEnumerator())
		{
			KeyValuePair<string, TileObject[]> current = default(KeyValuePair<string, TileObject[]>);
			while (true)
			{
				int num3;
				int num4;
				if (!enumerator.MoveNext())
				{
					num3 = -1062562737;
					num4 = num3;
				}
				else
				{
					num3 = -227710682;
					num4 = num3;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num3 ^ 0xCD6CC869u) % 6u)
					{
					case 5u:
						num3 = -227710682;
						continue;
					default:
						goto end_IL_00a2;
					case 4u:
						_RUI6iBtBZM0XLmrUDMinIhEAG2x = true;
						_fVjbLMTSqfCctBSedaVkqFVNHDC = false;
						goto end_IL_00a2;
					case 3u:
						_F7Y8qQ4RTW5wNNysh8CWJAOgnnd = current.Value;
						num3 = ((int)num2 * -1571859071) ^ 0x3FCCA414;
						continue;
					case 1u:
					{
						current = enumerator.Current;
						int num5;
						if (current.Key == mapInfo._MapName)
						{
							num3 = -1377304854;
							num5 = num3;
						}
						else
						{
							num3 = -1983533319;
							num5 = num3;
						}
						continue;
					}
					case 0u:
						break;
					case 2u:
						goto end_IL_00a2;
					}
					break;
				}
			}
			end_IL_00a2:;
		}
		_M2RcPC2J4Jc1ncdCsJJYHM1k0ai = mapInfo._uV5tlOqeszD4IoJi3t2CRjvcLIB.ToString();
		KeyValuePair<byte, Dictionary<_0U13Xaadumfh3Rq7bosOpHHI8EN, ushort>> current2 = default(KeyValuePair<byte, Dictionary<_0U13Xaadumfh3Rq7bosOpHHI8EN, ushort>>);
		while (true)
		{
			int num6 = -1065850365;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num6 ^ 0xCD6CC869u) % 9u)
				{
				case 6u:
					break;
				case 5u:
					_nGFHI34bFQlA1D7Rbw8sSPcGyBB = new List<TileObject>();
					_EXLS5R4QkJzFpGYxL48SlucMyVB = new Dictionary<int, int>();
					num6 = -278432836;
					continue;
				case 4u:
					_RUI6iBtBZM0XLmrUDMinIhEAG2x = true;
					num6 = (int)((num2 * 1179209461) ^ 0x143AB7EB);
					continue;
				case 0u:
					Program.LogInfoMessage("client", $"Using map {_M2RcPC2J4Jc1ncdCsJJYHM1k0ai} {_2uy3SiURqP8Ecgmfnt4rRpGfe5y[_M2RcPC2J4Jc1ncdCsJJYHM1k0ai]}");
					num6 = ((int)num2 * -366793288) ^ -48295990;
					continue;
				case 2u:
					_F7Y8qQ4RTW5wNNysh8CWJAOgnnd = _mSvpBPlipdsNUWuyAElUB63MoQT[$"Realm of the Mad God World {_2uy3SiURqP8Ecgmfnt4rRpGfe5y[_M2RcPC2J4Jc1ncdCsJJYHM1k0ai]}"];
					num6 = ((int)num2 * -1579361647) ^ 0x6221388A;
					continue;
				case 8u:
				{
					int num9;
					int num10;
					if (_2uy3SiURqP8Ecgmfnt4rRpGfe5y.ContainsKey(_M2RcPC2J4Jc1ncdCsJJYHM1k0ai))
					{
						num9 = 1988329135;
						num10 = num9;
					}
					else
					{
						num9 = 1880217244;
						num10 = num9;
					}
					num6 = num9 ^ ((int)num2 * -1359657911);
					continue;
				}
				case 7u:
					if (mapInfo._MapName == "Realm of the Mad God")
					{
						num6 = (int)((num2 * 769565486) ^ 0x7ACA723);
						continue;
					}
					return;
				case 3u:
					_fVjbLMTSqfCctBSedaVkqFVNHDC = false;
					return;
				default:
				{
					using Dictionary<byte, Dictionary<_0U13Xaadumfh3Rq7bosOpHHI8EN, ushort>>.Enumerator enumerator2 = _1MwomaL4fZiFdEhSaMGMmtPSZkA.GetEnumerator();
					while (true)
					{
						int num7;
						int num8;
						if (enumerator2.MoveNext())
						{
							num7 = -860977485;
							num8 = num7;
						}
						else
						{
							num7 = -465166210;
							num8 = num7;
						}
						while (true)
						{
							switch ((num2 = (uint)num7 ^ 0xCD6CC869u) % 5u)
							{
							case 4u:
								num7 = -860977485;
								continue;
							default:
								return;
							case 1u:
								current2 = enumerator2.Current;
								num7 = -91731151;
								continue;
							case 0u:
								break;
							case 2u:
								_EXLS5R4QkJzFpGYxL48SlucMyVB.Add(current2.Key, 0);
								num7 = ((int)num2 * -1518666757) ^ -787344977;
								continue;
							case 3u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
		IL_000e:
		num = -1343603083;
		goto IL_0013;
	}

	public void _emTnZmGyChlXH4IDm60126G1Snf(UpdatePacket update)
	{
		//Discarded unreachable code: IL_0086, IL_0344, IL_0456
		if (!Settings.Default.EnableMapHack)
		{
			goto IL_000f;
		}
		goto IL_00b6;
		IL_00b6:
		int num;
		if (_RUI6iBtBZM0XLmrUDMinIhEAG2x)
		{
			num = -402633296;
			goto IL_0014;
		}
		return;
		IL_000f:
		num = -368706202;
		goto IL_0014;
		IL_0014:
		KeyValuePair<byte, Dictionary<_0U13Xaadumfh3Rq7bosOpHHI8EN, ushort>> current = default(KeyValuePair<byte, Dictionary<_0U13Xaadumfh3Rq7bosOpHHI8EN, ushort>>);
		_0U13Xaadumfh3Rq7bosOpHHI8EN key = default(_0U13Xaadumfh3Rq7bosOpHHI8EN);
		TileObject current2 = default(TileObject);
		List<TileObject> list = default(List<TileObject>);
		int num14 = default(int);
		while (true)
		{
			int num13;
			uint num2;
			switch ((num2 = (uint)num ^ 0xBA95F1CAu) % 8u)
			{
			case 7u:
				break;
			case 1u:
				if (_fVjbLMTSqfCctBSedaVkqFVNHDC)
				{
					num = (int)((num2 * 161463240) ^ 0x7E609569);
					continue;
				}
				goto IL_03c1;
			case 6u:
				_nGFHI34bFQlA1D7Rbw8sSPcGyBB.AddRange(update._2CIHnoEa49dfPXyqt9nkkBlUcQf);
				num = (int)(num2 * 12203252) ^ -649490241;
				continue;
			case 4u:
				return;
			case 2u:
				if (_mSvpBPlipdsNUWuyAElUB63MoQT != null)
				{
					num = ((int)num2 * -636572978) ^ -489311057;
					continue;
				}
				return;
			case 0u:
				goto IL_00b6;
			case 3u:
				if (_50w8wVuv8bL5nhKaR2EHxjrTamB._XJlaeK8gdtamxYwZJIRc2tEXKcQA == "Realm of the Mad God")
				{
					num = (int)(num2 * 2110633429) ^ -316582061;
					continue;
				}
				goto IL_03c1;
			default:
				{
					using (Dictionary<byte, Dictionary<_0U13Xaadumfh3Rq7bosOpHHI8EN, ushort>>.Enumerator enumerator = _1MwomaL4fZiFdEhSaMGMmtPSZkA.GetEnumerator())
					{
						while (true)
						{
							IL_032c:
							if (enumerator.MoveNext())
							{
								int num3;
								while (true)
								{
									current = enumerator.Current;
									num3 = _EXLS5R4QkJzFpGYxL48SlucMyVB[current.Key];
									int num4 = -538478903;
									while (true)
									{
										switch ((num2 = (uint)num4 ^ 0xBA95F1CAu) % 3u)
										{
										case 0u:
											num4 = -163451708;
											continue;
										case 1u:
											break;
										default:
											goto end_IL_012c;
										}
										break;
									}
									continue;
									end_IL_012c:
									break;
								}
								using (List<TileObject>.Enumerator enumerator2 = _nGFHI34bFQlA1D7Rbw8sSPcGyBB.GetEnumerator())
								{
									while (true)
									{
										int num5;
										int num6;
										if (enumerator2.MoveNext())
										{
											num5 = -2081932463;
											num6 = num5;
										}
										else
										{
											num5 = -899059726;
											num6 = num5;
										}
										while (true)
										{
											switch ((num2 = (uint)num5 ^ 0xBA95F1CAu) % 6u)
											{
											case 0u:
												num5 = -2081932463;
												continue;
											default:
												goto end_IL_015d;
											case 3u:
												num3++;
												num5 = (int)(num2 * 758769517) ^ -1826246932;
												continue;
											case 4u:
											{
												int num8;
												int num9;
												if (current.Value[key] != current2._TileType)
												{
													num8 = -122012875;
													num9 = num8;
												}
												else
												{
													num8 = -253933929;
													num9 = num8;
												}
												num5 = num8 ^ ((int)num2 * -1120840180);
												continue;
											}
											case 1u:
												break;
											case 5u:
											{
												current2 = enumerator2.Current;
												key = new _0U13Xaadumfh3Rq7bosOpHHI8EN(current2._PositionX, current2._PositionY);
												int num7;
												if (current.Value.ContainsKey(key))
												{
													num5 = -2092107386;
													num7 = num5;
												}
												else
												{
													num5 = -1455697755;
													num7 = num5;
												}
												continue;
											}
											case 2u:
												goto end_IL_015d;
											}
											break;
										}
									}
									end_IL_015d:;
								}
								_EXLS5R4QkJzFpGYxL48SlucMyVB[current.Key] = num3;
								if (num3 <= 250)
								{
									continue;
								}
								goto IL_0267;
							}
							int num10 = -1043266707;
							goto IL_026c;
							IL_0267:
							num10 = -1978437788;
							goto IL_026c;
							IL_026c:
							while (true)
							{
								switch ((num2 = (uint)num10 ^ 0xBA95F1CAu) % 10u)
								{
								case 0u:
									break;
								default:
									goto end_IL_0104;
								case 3u:
									_fVjbLMTSqfCctBSedaVkqFVNHDC = false;
									num10 = -315837868;
									continue;
								case 7u:
									_2uy3SiURqP8Ecgmfnt4rRpGfe5y[_M2RcPC2J4Jc1ncdCsJJYHM1k0ai] = current.Key;
									num10 = ((int)num2 * -1697225141) ^ -1265988533;
									continue;
								case 8u:
									num10 = (int)((num2 * 98628744) ^ 0x539B2D29);
									continue;
								case 4u:
								{
									_nGFHI34bFQlA1D7Rbw8sSPcGyBB.Clear();
									int num11;
									int num12;
									if (_2uy3SiURqP8Ecgmfnt4rRpGfe5y.ContainsKey(_M2RcPC2J4Jc1ncdCsJJYHM1k0ai))
									{
										num11 = 359145099;
										num12 = num11;
									}
									else
									{
										num11 = 1752280123;
										num12 = num11;
									}
									num10 = num11 ^ ((int)num2 * -671084626);
									continue;
								}
								case 9u:
									goto IL_032c;
								case 6u:
									goto end_IL_0104;
								case 1u:
									_2uy3SiURqP8Ecgmfnt4rRpGfe5y.Add(_M2RcPC2J4Jc1ncdCsJJYHM1k0ai, current.Key);
									num10 = -1152495719;
									continue;
								case 2u:
									_F7Y8qQ4RTW5wNNysh8CWJAOgnnd = _mSvpBPlipdsNUWuyAElUB63MoQT[$"Realm of the Mad God World {current.Key}"];
									num10 = (int)((num2 * 1914809488) ^ 0x3DC5A94C);
									continue;
								case 5u:
									goto end_IL_0104;
								}
								break;
							}
							goto IL_0267;
						}
						end_IL_0104:;
					}
					goto IL_03c1;
				}
				IL_052f:
				list = new List<TileObject>(Math.Min(_F7Y8qQ4RTW5wNNysh8CWJAOgnnd.Length + update._2CIHnoEa49dfPXyqt9nkkBlUcQf.Length, 2048));
				num13 = -1006583710;
				goto IL_03d1;
				IL_03d1:
				while (true)
				{
					switch ((num2 = (uint)num13 ^ 0xBA95F1CAu) % 14u)
					{
					case 3u:
						break;
					default:
						return;
					case 4u:
						list.AddRange(update._2CIHnoEa49dfPXyqt9nkkBlUcQf);
						num13 = ((int)num2 * -1297623760) ^ -1624655226;
						continue;
					case 10u:
						num14 = _2rY9Z6KeYzFoyTpIKnOXk8JbiYg;
						num13 = ((int)num2 * -371775632) ^ -1307730529;
						continue;
					case 5u:
						return;
					case 0u:
						Program.LogInfoMessage("client", $"Finished replacing whole map! {_2rY9Z6KeYzFoyTpIKnOXk8JbiYg} total tiles replaced");
						num13 = ((int)num2 * -203714704) ^ 0x2E9BD123;
						continue;
					case 8u:
					{
						update._2CIHnoEa49dfPXyqt9nkkBlUcQf = list.ToArray();
						int num17;
						int num18;
						if (num14 == _F7Y8qQ4RTW5wNNysh8CWJAOgnnd.Length)
						{
							num17 = -1190870112;
							num18 = num17;
						}
						else
						{
							num17 = -1280440179;
							num18 = num17;
						}
						num13 = num17 ^ (int)(num2 * 790404844);
						continue;
					}
					case 13u:
					{
						int num15;
						int num16;
						if (list.Count != 2048)
						{
							num15 = -1622895457;
							num16 = num15;
						}
						else
						{
							num15 = -527119539;
							num16 = num15;
						}
						num13 = num15 ^ ((int)num2 * -984372187);
						continue;
					}
					case 6u:
						num14++;
						num13 = ((int)num2 * -1115675601) ^ 0x37A4BAE3;
						continue;
					case 7u:
						goto IL_0510;
					case 9u:
						goto IL_052f;
					case 2u:
						_2rY9Z6KeYzFoyTpIKnOXk8JbiYg = num14;
						num13 = -175943286;
						continue;
					case 1u:
						_RUI6iBtBZM0XLmrUDMinIhEAG2x = false;
						num13 = ((int)num2 * -535985754) ^ 0x4438AA5B;
						continue;
					case 12u:
						list.Add(_F7Y8qQ4RTW5wNNysh8CWJAOgnnd[num14]);
						num13 = -30557449;
						continue;
					case 11u:
						return;
					}
					break;
					IL_0510:
					int num19;
					if (num14 >= _F7Y8qQ4RTW5wNNysh8CWJAOgnnd.Length)
					{
						num13 = -161345380;
						num19 = num13;
					}
					else
					{
						num13 = -1742946340;
						num19 = num13;
					}
				}
				goto IL_03cc;
				IL_03cc:
				num13 = -1924575535;
				goto IL_03d1;
				IL_03c1:
				if (_F7Y8qQ4RTW5wNNysh8CWJAOgnnd == null)
				{
					goto IL_03cc;
				}
				goto IL_052f;
			}
			break;
		}
		goto IL_000f;
	}

	public void _CgwO1K8tgdyKPdKvCtJupNhapLD(PlayerTextPacket playerText)
	{
		//Discarded unreachable code: IL_00cb
		if (Settings.Default.EnableMapHack)
		{
			goto IL_000f;
		}
		goto IL_00f8;
		IL_00f8:
		int num;
		if (playerText._Message == "/savemap")
		{
			num = -2034523241;
			goto IL_0014;
		}
		return;
		IL_000f:
		num = -1425211768;
		goto IL_0014;
		IL_0014:
		int num7 = default(int);
		Dictionary<ushort, List<byte[]>> dictionary = default(Dictionary<ushort, List<byte[]>>);
		_TmFas5PEXYMVmPQTpu3tg3XuoTo tmFas5PEXYMVmPQTpu3tg3XuoTo = default(_TmFas5PEXYMVmPQTpu3tg3XuoTo);
		_TmFas5PEXYMVmPQTpu3tg3XuoTo[] _2CIHnoEa49dfPXyqt9nkkBlUcQf = default(_TmFas5PEXYMVmPQTpu3tg3XuoTo[]);
		byte[] current2 = default(byte[]);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xF3C31F7Fu) % 9u)
			{
			case 0u:
				break;
			case 2u:
			{
				int num16;
				int num17;
				if (!(playerText._Message == "/world"))
				{
					num16 = 359557065;
					num17 = num16;
				}
				else
				{
					num16 = 1371005295;
					num17 = num16;
				}
				num = num16 ^ (int)(num2 * 1488249432);
				continue;
			}
			case 5u:
			{
				_PlferqYaObizDfc28C5jdKSLGq5 plferqYaObizDfc28C5jdKSLGq = _50w8wVuv8bL5nhKaR2EHxjrTamB;
				object message;
				if (!_2uy3SiURqP8Ecgmfnt4rRpGfe5y.ContainsKey(_M2RcPC2J4Jc1ncdCsJJYHM1k0ai))
				{
					message = "Unknown world";
				}
				else
				{
					num7 = _2uy3SiURqP8Ecgmfnt4rRpGfe5y[_M2RcPC2J4Jc1ncdCsJJYHM1k0ai];
					message = "World: " + num7;
				}
				plferqYaObizDfc28C5jdKSLGq._TVcgSr7bcouFhNfw8PyT9bbBIM0((string)message);
				num = -1775528083;
				continue;
			}
			case 1u:
				return;
			case 7u:
				playerText._Send = false;
				num = (int)(num2 * 267922979) ^ -1024591860;
				continue;
			case 3u:
				goto IL_00f8;
			case 6u:
				playerText._Send = false;
				num = (int)(num2 * 1634960326) ^ -929417862;
				continue;
			case 8u:
			{
				int num14;
				int num15;
				if (_50w8wVuv8bL5nhKaR2EHxjrTamB._XJlaeK8gdtamxYwZJIRc2tEXKcQA == "Realm of the Mad God")
				{
					num14 = -163698863;
					num15 = num14;
				}
				else
				{
					num14 = -722224047;
					num15 = num14;
				}
				num = num14 ^ (int)(num2 * 1004678930);
				continue;
			}
			default:
			{
				MemoryStream memoryStream = new MemoryStream();
				try
				{
					BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
					while (true)
					{
						int num3 = -89265098;
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xF3C31F7Fu) % 12u)
							{
							case 10u:
								break;
							case 7u:
							{
								int num9;
								int num10;
								if (!dictionary.ContainsKey(tmFas5PEXYMVmPQTpu3tg3XuoTo._bjQd3Vpt6RdoySpzKxn7K2gQGoM))
								{
									num9 = -1490215132;
									num10 = num9;
								}
								else
								{
									num9 = -1881918106;
									num10 = num9;
								}
								num3 = num9 ^ ((int)num2 * -792750286);
								continue;
							}
							case 4u:
								num7++;
								num3 = -948674857;
								continue;
							case 9u:
								dictionary = new Dictionary<ushort, List<byte[]>>();
								num3 = ((int)num2 * -2104758073) ^ 0x6AE9B9DF;
								continue;
							case 8u:
							{
								int num11;
								int num12;
								if (tmFas5PEXYMVmPQTpu3tg3XuoTo != null)
								{
									num11 = 819786652;
									num12 = num11;
								}
								else
								{
									num11 = 1471684111;
									num12 = num11;
								}
								num3 = num11 ^ ((int)num2 * -965000287);
								continue;
							}
							case 5u:
								dictionary.Add(tmFas5PEXYMVmPQTpu3tg3XuoTo._bjQd3Vpt6RdoySpzKxn7K2gQGoM, new List<byte[]>());
								num3 = ((int)num2 * -610649468) ^ -323213420;
								continue;
							case 2u:
								tmFas5PEXYMVmPQTpu3tg3XuoTo = _2CIHnoEa49dfPXyqt9nkkBlUcQf[num7];
								num3 = -849492505;
								continue;
							case 6u:
								num7 = 0;
								num3 = ((int)num2 * -17774904) ^ 0xADE767;
								continue;
							case 11u:
								_2CIHnoEa49dfPXyqt9nkkBlUcQf = _50w8wVuv8bL5nhKaR2EHxjrTamB._2CIHnoEa49dfPXyqt9nkkBlUcQf;
								num3 = ((int)num2 * -725467737) ^ -2065382304;
								continue;
							case 3u:
								dictionary[tmFas5PEXYMVmPQTpu3tg3XuoTo._bjQd3Vpt6RdoySpzKxn7K2gQGoM].Add(_0U13Xaadumfh3Rq7bosOpHHI8EN._CbMmKhs21CLB3H4EaQTZreneGph(tmFas5PEXYMVmPQTpu3tg3XuoTo._J6Qj5cLLcu6lzA6QjEWC7AHwMFB, tmFas5PEXYMVmPQTpu3tg3XuoTo._xtqbgJ9lwGkC3oZ29UIr5OCkpsaA));
								num3 = -610443369;
								continue;
							case 0u:
							{
								int num8;
								if (num7 >= _2CIHnoEa49dfPXyqt9nkkBlUcQf.Length)
								{
									num3 = -1200236706;
									num8 = num3;
								}
								else
								{
									num3 = -1409471231;
									num8 = num3;
								}
								continue;
							}
							default:
							{
								using (Dictionary<ushort, List<byte[]>>.Enumerator enumerator = dictionary.GetEnumerator())
								{
									while (enumerator.MoveNext())
									{
										KeyValuePair<ushort, List<byte[]>> current;
										while (true)
										{
											current = enumerator.Current;
											binaryWriter.Write(current.Key);
											int num4 = -1646460213;
											while (true)
											{
												switch ((num2 = (uint)num4 ^ 0xF3C31F7Fu) % 4u)
												{
												case 2u:
													num4 = -1353740588;
													continue;
												case 3u:
													break;
												case 0u:
													binaryWriter.Write(current.Value.Count);
													num4 = ((int)num2 * -1418101847) ^ -1184990542;
													continue;
												default:
													goto end_IL_0313;
												}
												break;
											}
											continue;
											end_IL_0313:
											break;
										}
										using List<byte[]>.Enumerator enumerator2 = current.Value.GetEnumerator();
										while (true)
										{
											int num5;
											int num6;
											if (!enumerator2.MoveNext())
											{
												num5 = -976968879;
												num6 = num5;
											}
											else
											{
												num5 = -623500360;
												num6 = num5;
											}
											while (true)
											{
												switch ((num2 = (uint)num5 ^ 0xF3C31F7Fu) % 5u)
												{
												case 4u:
													num5 = -623500360;
													continue;
												default:
													goto end_IL_0360;
												case 1u:
													current2 = enumerator2.Current;
													num5 = -1086682930;
													continue;
												case 2u:
													break;
												case 3u:
													binaryWriter.Write(current2);
													num5 = (int)((num2 * 655791645) ^ 0x30B40C52);
													continue;
												case 0u:
													goto end_IL_0360;
												}
												break;
											}
										}
										end_IL_0360:;
									}
								}
								byte[] bytes = _CbMmKhs21CLB3H4EaQTZreneGph(memoryStream.ToArray());
								File.WriteAllBytes("map_" + _50w8wVuv8bL5nhKaR2EHxjrTamB._XJlaeK8gdtamxYwZJIRc2tEXKcQA + " " + Environment.TickCount + ".gz", bytes);
								return;
							}
							}
							break;
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						while (true)
						{
							int num13 = -1438899801;
							while (true)
							{
								switch ((num2 = (uint)num13 ^ 0xF3C31F7Fu) % 3u)
								{
								case 0u:
									break;
								default:
									goto end_IL_0452;
								case 1u:
									goto IL_0478;
								case 2u:
									goto end_IL_0452;
								}
								break;
								IL_0478:
								((IDisposable)memoryStream).Dispose();
								num13 = ((int)num2 * -1466301804) ^ 0x28A322C2;
							}
						}
					}
					end_IL_0452:;
				}
			}
			}
			break;
		}
		goto IL_000f;
	}

	public static byte[] _CbMmKhs21CLB3H4EaQTZreneGph(byte[] bytes)
	{
		MemoryStream memoryStream = new MemoryStream(bytes);
		MemoryStream memoryStream2;
		try
		{
			MemoryStream memoryStream3 = (memoryStream2 = new MemoryStream());
			try
			{
				GZipStream gZipStream = new GZipStream(memoryStream2, CompressionMode.Compress);
				try
				{
					memoryStream.CopyTo(gZipStream);
				}
				finally
				{
					if (gZipStream != null)
					{
						while (true)
						{
							int num = -1665161838;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)num ^ 0xB76C3CF9u) % 3u)
								{
								case 0u:
									break;
								default:
									goto end_IL_0023;
								case 1u:
									goto IL_0049;
								case 2u:
									goto end_IL_0023;
								}
								break;
								IL_0049:
								((IDisposable)gZipStream).Dispose();
								num = (int)(num2 * 2142458124) ^ -1908273833;
							}
						}
					}
					end_IL_0023:;
				}
			}
			finally
			{
				if (memoryStream3 != null)
				{
					while (true)
					{
						int num3 = -1738385035;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)num3 ^ 0xB76C3CF9u) % 3u)
							{
							case 0u:
								break;
							default:
								goto end_IL_0060;
							case 2u:
								goto IL_0086;
							case 1u:
								goto end_IL_0060;
							}
							break;
							IL_0086:
							((IDisposable)memoryStream3).Dispose();
							num3 = ((int)num2 * -437746241) ^ 0x186870DB;
						}
					}
				}
				end_IL_0060:;
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					int num4 = -1914857774;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num4 ^ 0xB76C3CF9u) % 3u)
						{
						case 0u:
							break;
						default:
							goto end_IL_009d;
						case 1u:
							goto IL_00c3;
						case 2u:
							goto end_IL_009d;
						}
						break;
						IL_00c3:
						((IDisposable)memoryStream).Dispose();
						num4 = ((int)num2 * -1955310449) ^ 0x4EC3784;
					}
				}
			}
			end_IL_009d:;
		}
		return memoryStream2.ToArray();
	}

	public static byte[] _VuGQzPz5BlDDbNI6o6p0eomGn6K(byte[] bytes)
	{
		MemoryStream memoryStream = new MemoryStream(bytes);
		MemoryStream memoryStream2;
		try
		{
			MemoryStream memoryStream3 = (memoryStream2 = new MemoryStream());
			try
			{
				GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress);
				try
				{
					gZipStream.CopyTo(memoryStream2);
				}
				finally
				{
					if (gZipStream != null)
					{
						while (true)
						{
							int num = 999478760;
							while (true)
							{
								uint num2;
								switch ((num2 = (uint)num ^ 0x8C0500Bu) % 3u)
								{
								case 2u:
									break;
								default:
									goto end_IL_0023;
								case 1u:
									goto IL_0049;
								case 0u:
									goto end_IL_0023;
								}
								break;
								IL_0049:
								((IDisposable)gZipStream).Dispose();
								num = ((int)num2 * -2027241816) ^ -1702980331;
							}
						}
					}
					end_IL_0023:;
				}
			}
			finally
			{
				if (memoryStream3 != null)
				{
					while (true)
					{
						int num3 = 98791021;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)num3 ^ 0x8C0500Bu) % 3u)
							{
							case 0u:
								break;
							default:
								goto end_IL_0060;
							case 2u:
								goto IL_0086;
							case 1u:
								goto end_IL_0060;
							}
							break;
							IL_0086:
							((IDisposable)memoryStream3).Dispose();
							num3 = ((int)num2 * -1279440709) ^ -1716477669;
						}
					}
				}
				end_IL_0060:;
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					int num4 = 1201245166;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num4 ^ 0x8C0500Bu) % 3u)
						{
						case 2u:
							break;
						default:
							goto end_IL_009d;
						case 1u:
							goto IL_00c3;
						case 0u:
							goto end_IL_009d;
						}
						break;
						IL_00c3:
						((IDisposable)memoryStream).Dispose();
						num4 = (int)(num2 * 1981735267) ^ -1479112977;
					}
				}
			}
			end_IL_009d:;
		}
		return memoryStream2.ToArray();
	}
}
