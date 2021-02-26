using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.DataStructures;
using ExaltMultiTool.Proxy.Mods;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class Client
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _KFWizMhwJdDRzZZ2uIaYKvVgwdd
	{
		public static readonly _KFWizMhwJdDRzZZ2uIaYKvVgwdd _003C_003E9 = new _KFWizMhwJdDRzZZ2uIaYKvVgwdd();

		internal bool _RkclmOcflCTAKrfHAWmWYNmptiC(_jsZwrE9lzYULBcuBQfPr4S2Du8c activate)
		{
			if (activate._WL2DOBxBuX9DARzf2KPoaJbgZiCb != ActivationTypeEnum.Heal)
			{
				while (true)
				{
					int num = 66756073;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x74521AC8u) % 4u)
						{
						case 3u:
							break;
						case 1u:
						{
							int num3;
							int num4;
							if (activate._WL2DOBxBuX9DARzf2KPoaJbgZiCb != ActivationTypeEnum.HealNova)
							{
								num3 = 105671135;
								num4 = num3;
							}
							else
							{
								num3 = 1357865865;
								num4 = num3;
							}
							num = num3 ^ ((int)num2 * -1743662167);
							continue;
						}
						case 0u:
							goto IL_0053;
						default:
							return false;
						}
						break;
					}
				}
			}
			goto IL_0053;
			IL_0053:
			return activate._Qh0BQXXjPEcRT8iSpFFQRoYAmun > 0;
		}
	}

	[CompilerGenerated]
	private sealed class _rskPkfRxo7wDJPhaY1r2YPk7cHK
	{
		public int _Z7QB00wd3J89SVlpa1TkMKreN71;

		public Client _7DEudk1H4zeA6HRBegB5UK6RcSYA;

		public Packet _knEGtC2dgW3EdybgdHOkjnhOHhCA;

		public bool _r4FcciqdCzxJTrS44vo6fn9Ulpn;

		internal void _QRObcmrWsw1S9V7GBs3arc8ySHV()
		{
			Task.Delay(_Z7QB00wd3J89SVlpa1TkMKreN71).Wait();
			while (true)
			{
				int num = 1839955475;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x206A155Au) % 4u)
					{
					case 3u:
						break;
					default:
						return;
					case 1u:
					{
						_7DEudk1H4zeA6HRBegB5UK6RcSYA.SendPacket(_knEGtC2dgW3EdybgdHOkjnhOHhCA, client: false);
						int num3;
						int num4;
						if (_r4FcciqdCzxJTrS44vo6fn9Ulpn)
						{
							num3 = -1026084545;
							num4 = num3;
						}
						else
						{
							num3 = -1646496967;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 1077843825);
						continue;
					}
					case 0u:
						Console.WriteLine($"Sent packet after {_Z7QB00wd3J89SVlpa1TkMKreN71}ms {_knEGtC2dgW3EdybgdHOkjnhOHhCA}");
						num = ((int)num2 * -1173995700) ^ -1648230832;
						continue;
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	private static readonly string IncomingKey;

	private static readonly string OutgoingKey;

	private int _R1V44R2NEdPZgmExAmhejgtVtQo;

	private int _MGoEUVg87yxb0wl81YAnJbDAulW;

	private object _Gwx0kZiSAw3quYoIxjEIop3DixH = new object();

	private object _AdmkvARnFctcdXLciZNvHDJInwT = new object();

	private object _yd565Ezy4z3WaHBiQxBvko6QJTC = new object();

	private RC4Cipher _uGtu9YeFC4OzTYFKlj7bn66i1mP = new RC4Cipher(IncomingKey);

	private RC4Cipher _nsrrBFBfjlQbceN4gTlrLH5tZwr = new RC4Cipher(OutgoingKey);

	private RC4Cipher _7nagdRNfwEzsojGhddpNUNMOyTN = new RC4Cipher(OutgoingKey);

	private RC4Cipher _ntAEc5DBjY43rTpB2x5NeHQac3K = new RC4Cipher(IncomingKey);

	private NetworkBuffer _7MlbEvLKjcNDHlwkDf6KZ4IEMcc = new NetworkBuffer();

	private NetworkBuffer _YH4gIV1xNd6pYzPqVxTzOxg6BU = new NetworkBuffer();

	private TcpClient _5XbkslECWDrdUntKuoEYQFkXVlX;

	private TcpClient _QyFBNLtlxoQc1TJPzmx0QAJh70w;

	private NetworkStream _IBGB2gFxmPDXBY3vtWT4jbTfDiQ;

	private NetworkStream _l6WDeCVHHMrhbTcgVYNTZajxMYy;

	private bool _3OsEBBAlNlEDnoyP1h3yKjAqqfw;

	public LocalProxy _DumVMPhENnNVyQvhZaHdKZdaaMD;

	public int _UqAoky1lauc0gYPMEYUcYfMlJkC = -1;

	public int _PositionX;

	public int _wfbcaMLbXqoFK8XA49K6agBsnJ2;

	public string CurrentMapName = "";

	private byte _bljpqzndse2l5Ssytdk5w8SDvkC = 1;

	public MapStructure[] _2CIHnoEa49dfPXyqt9nkkBlUcQf = new MapStructure[0];

	public Dictionary<int, PlayerData> _naDcMlPfaanTh6qrJ3cOuO4HNwz = new Dictionary<int, PlayerData>();

	public Dictionary<int, PlayerData> _Aq9hW2NyDqEkITmxzYm6OCQLaDB = new Dictionary<int, PlayerData>();

	public Dictionary<int, PlayerData> _VPArsrlUa0uEsW6OxAYV9WHJAMK = new Dictionary<int, PlayerData>();

	public Dictionary<int, Dictionary<int, Projectile>> _N5GofMpQbwbVNiYLmSHHRmpmKhg = new Dictionary<int, Dictionary<int, Projectile>>();

	public PotionInfo[] PotionSlots = new PotionInfo[0];

	public int _QtBizqH8aHz2ixkvUsA6VqqwHGF;

	public static int[] _RMiC0QFzlD1C8rYuIDkiDIy5r1H;

	private _NXJzFJyDncpkTIZ6UBdQLlK9DDb _qEzzfhETXrgbZF6Y037bCMj1ZiW;

	private AntiDebuff _MQGiUwYJADYUvtWZEyKaTTnHwhG;

	private _5gQBYpWvIJQibBR6ggclQe9CpXV _oSzQCZbBOYIozX7RJv3aqVCVMPx;

	private _l5Dg0EkouGJVudiZMWNbSgNri8O _UEbvS70nnmTDsOCF6FzGLVDj3Aj;

	private _j6xsOu5VJyl0WxN7qnrwKDDPB3e _70M5lCy13kd2dviat1I49qoS0zm;

	private AutoAbility _3EfuLHlaaGhnIb3GCSaEEyNuJL2A;

	private _I5hBdMHPSeVO0cbuEcAkM9I29MW _lUGiNuRFo5etEf9KCYfizlmsaId;

	private AutoNexus _agaMD0M3QCPNv9ovQakoMaEEq5A;

	private _2JsGBNSkFue0Lbceua6NVMaZ7of _Yj6Ub8zlrxF6fOL3oEB73K0mFDg;

	private SafeWalk _HHeb9q7rrHLt7HwtYTuHlRRDlMT;

	private TeleportHelper _bitlLp8JKl1PbTlHWIEIOAJDyuO;

	private _sXxBcxQJ5OZEM8d0AIMUAzcF8In _TuLDXgoWhZy8CPtlhPaAWviSNq3;

	private BazaarTimer _K8f4oiOwgZwEwnKUWcsX1cUgZK;

	private MapHack _X8Ko4JuJwLwDHPlTH06yuEvAEUl;

	private OryxHelper _kdpxlwPITosuhIOBZ8xOg33CYft;

	private LostHallsHelper _m3wMOEouSwmahwc13fW7jfLDEhz;

	private DateTime _fCbZ25vjNOZzyN3OaCFeNgXdg4d = DateTime.Now;

	public bool _hTsir1YKLqh6ix2IjcIYsrZSQJF;

	public int _itBzbWMkvo0AuQGuR19us26p4TP;

	public int _mVrHB9iWE8fKC1cy09EH2Tg38G;

	public int _29Cygi7ILPhL4sLWfXR3KEYpYle;

	public int[] _zGfl045ehROhk6jo6nvkc12rcvH = new int[0];

	public int[] _Pg28U1MUv2y9I7GawSrEglFuQNv = new int[0];

	public int[] _geK4oHsbAS9nZM9pjvAHYVUnwQs = new int[0];

	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51 => _MGoEUVg87yxb0wl81YAnJbDAulW + (Environment.TickCount - _R1V44R2NEdPZgmExAmhejgtVtQo);

	public int _ThXZKkD7eTKsvHaetPD5l7lo3ld => (int)(DateTime.Now - _fCbZ25vjNOZzyN3OaCFeNgXdg4d).TotalMilliseconds;

	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK => _PlayerData._fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public PlayerData _PlayerData
	{
		get;
		set;
	}

	public bool _vqEVLR4cyc2SGuohfuGXIfgjXjA => !_3OsEBBAlNlEDnoyP1h3yKjAqqfw;

	public Client(LocalProxy proxy, TcpClient client)
	{
		while (true)
		{
			int num = 994117924;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57E2571Bu) % 10u)
				{
				case 9u:
					break;
				default:
					return;
				case 2u:
					_1cGXpzEEbo0g0bvKgbK47uReXKB(0, 4, client: true);
					num = (int)(num2 * 1552699240) ^ -615384279;
					continue;
				case 1u:
					_5XbkslECWDrdUntKuoEYQFkXVlX = client;
					_IBGB2gFxmPDXBY3vtWT4jbTfDiQ = _5XbkslECWDrdUntKuoEYQFkXVlX.GetStream();
					_5XbkslECWDrdUntKuoEYQFkXVlX.NoDelay = true;
					_qEzzfhETXrgbZF6Y037bCMj1ZiW = new _NXJzFJyDncpkTIZ6UBdQLlK9DDb(this);
					_MQGiUwYJADYUvtWZEyKaTTnHwhG = new AntiDebuff(this);
					num = ((int)num2 * -695737541) ^ 0xDBA08CA;
					continue;
				case 5u:
					_agaMD0M3QCPNv9ovQakoMaEEq5A = new AutoNexus(this);
					num = ((int)num2 * -447401081) ^ 0x2AC302A8;
					continue;
				case 4u:
					_Yj6Ub8zlrxF6fOL3oEB73K0mFDg = new _2JsGBNSkFue0Lbceua6NVMaZ7of(this);
					_HHeb9q7rrHLt7HwtYTuHlRRDlMT = new SafeWalk(this);
					_bitlLp8JKl1PbTlHWIEIOAJDyuO = new TeleportHelper(this);
					_oSzQCZbBOYIozX7RJv3aqVCVMPx = new _5gQBYpWvIJQibBR6ggclQe9CpXV();
					_TuLDXgoWhZy8CPtlhPaAWviSNq3 = new _sXxBcxQJ5OZEM8d0AIMUAzcF8In(this);
					num = (int)((num2 * 298553203) ^ 0x4ADEF542);
					continue;
				case 6u:
					_UEbvS70nnmTDsOCF6FzGLVDj3Aj = new _l5Dg0EkouGJVudiZMWNbSgNri8O(this);
					_70M5lCy13kd2dviat1I49qoS0zm = new _j6xsOu5VJyl0WxN7qnrwKDDPB3e(this);
					_3EfuLHlaaGhnIb3GCSaEEyNuJL2A = new AutoAbility(this);
					_lUGiNuRFo5etEf9KCYfizlmsaId = new _I5hBdMHPSeVO0cbuEcAkM9I29MW(this);
					num = (int)(num2 * 927648028) ^ -1373600850;
					continue;
				case 7u:
					_K8f4oiOwgZwEwnKUWcsX1cUgZK = new BazaarTimer(this);
					_X8Ko4JuJwLwDHPlTH06yuEvAEUl = new MapHack(this);
					_kdpxlwPITosuhIOBZ8xOg33CYft = new OryxHelper(this);
					num = ((int)num2 * -1773485249) ^ -1662571904;
					continue;
				case 8u:
					_m3wMOEouSwmahwc13fW7jfLDEhz = new LostHallsHelper();
					num = ((int)num2 * -2097827533) ^ -891404459;
					continue;
				case 3u:
					_DumVMPhENnNVyQvhZaHdKZdaaMD = proxy;
					num = (int)((num2 * 1748373890) ^ 0x693F094A);
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	static Client()
	{
		IncomingKey = "5a4d2016bc16dc64883194ffd9";
		ushort[] source = default(ushort[]);
		List<int> list = default(List<int>);
		ParseXML current = default(ParseXML);
		while (true)
		{
			int num = 1118648297;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x315EA818u) % 4u)
				{
				case 2u:
					break;
				case 1u:
					OutgoingKey = "c91d9eec420160730d825604e0";
					num = ((int)num2 * -878100288) ^ -1228304009;
					continue;
				case 3u:
					source = new ushort[7]
					{
						8779,
						8798,
						8795,
						8780,
						8764,
						8765,
						2736
					};
					list = new List<int>();
					num = (int)(num2 * 1604270625) ^ -464428257;
					continue;
				default:
				{
					using (Dictionary<ushort, ParseXML>.ValueCollection.Enumerator enumerator = ResourceDownloader._3ndzvDGHhvqls1BD8vzizSQBDdI._oQlNWqxOoe5LqobGdGJlgo4YIsh.Values.GetEnumerator())
					{
						while (true)
						{
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 427928606;
								num4 = num3;
							}
							else
							{
								num3 = 815660735;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x315EA818u) % 8u)
								{
								case 5u:
									num3 = 427928606;
									continue;
								default:
									goto end_IL_0088;
								case 6u:
									current = enumerator.Current;
									num3 = 924447898;
									continue;
								case 1u:
									break;
								case 0u:
									list.Add(current._ItemId);
									num3 = ((int)num2 * -304591697) ^ 0x5C1B1791;
									continue;
								case 2u:
								{
									int num7;
									int num8;
									if (!current._IsConsumable)
									{
										num7 = 978876519;
										num8 = num7;
									}
									else
									{
										num7 = 191469610;
										num8 = num7;
									}
									num3 = num7 ^ ((int)num2 * -1514898157);
									continue;
								}
								case 3u:
								{
									int num9;
									int num10;
									if (current._jCpZRWOsJvipfVcsNeGLqx7e6rd.Any(delegate(_jsZwrE9lzYULBcuBQfPr4S2Du8c activate)
									{
										if (activate._WL2DOBxBuX9DARzf2KPoaJbgZiCb != ActivationTypeEnum.Heal)
										{
											while (true)
											{
												int num11 = 66756073;
												while (true)
												{
													uint num12;
													switch ((num12 = (uint)num11 ^ 0x74521AC8u) % 4u)
													{
													case 3u:
														break;
													case 1u:
													{
														int num13;
														int num14;
														if (activate._WL2DOBxBuX9DARzf2KPoaJbgZiCb != ActivationTypeEnum.HealNova)
														{
															num13 = 105671135;
															num14 = num13;
														}
														else
														{
															num13 = 1357865865;
															num14 = num13;
														}
														num11 = num13 ^ ((int)num12 * -1743662167);
														continue;
													}
													case 0u:
														goto IL_0053;
													default:
														return false;
													}
													break;
												}
											}
										}
										goto IL_0053;
										IL_0053:
										return activate._Qh0BQXXjPEcRT8iSpFFQRoYAmun > 0;
									}))
									{
										num9 = -1821730163;
										num10 = num9;
									}
									else
									{
										num9 = -641491484;
										num10 = num9;
									}
									num3 = num9 ^ (int)(num2 * 747384183);
									continue;
								}
								case 4u:
								{
									int num5;
									int num6;
									if (!source.Contains(current._ItemId))
									{
										num5 = -1072421125;
										num6 = num5;
									}
									else
									{
										num5 = -1629932191;
										num6 = num5;
									}
									num3 = num5 ^ (int)(num2 * 1025663368);
									continue;
								}
								case 7u:
									goto end_IL_0088;
								}
								break;
							}
						}
						end_IL_0088:;
					}
					_RMiC0QFzlD1C8rYuIDkiDIy5r1H = list.ToArray();
					return;
				}
				}
				break;
			}
		}
	}

	private void _5uZ25pP9Y4fbygV3rQnxXGU1Syd(IAsyncResult ar)
	{
		try
		{
			_QyFBNLtlxoQc1TJPzmx0QAJh70w.EndConnect(ar);
			string text = default(string);
			while (true)
			{
				int num = 723529378;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7FEB06CEu) % 7u)
					{
					case 3u:
						break;
					default:
						return;
					case 2u:
						_l6WDeCVHHMrhbTcgVYNTZajxMYy = _QyFBNLtlxoQc1TJPzmx0QAJh70w.GetStream();
						num = ((int)num2 * -918115937) ^ -780418676;
						continue;
					case 0u:
						_TuLDXgoWhZy8CPtlhPaAWviSNq3.GetServerIP(text);
						SendToServer(ar.AsyncState as Packet);
						num = ((int)num2 * -120033699) ^ -616704011;
						continue;
					case 5u:
						_1cGXpzEEbo0g0bvKgbK47uReXKB(0, 4, client: false);
						_DumVMPhENnNVyQvhZaHdKZdaaMD._brocD93D6xr1tNwKL9dn3DKnZ58(this);
						num = (int)(num2 * 1113781021) ^ -1136838334;
						continue;
					case 6u:
						text = (_QyFBNLtlxoQc1TJPzmx0QAJh70w.Client.RemoteEndPoint as IPEndPoint).Address.ToString();
						num = ((int)num2 * -975297696) ^ -955681938;
						continue;
					case 4u:
						Program.LogInfoMessage("client", "Connected to remote host " + text);
						num = (int)((num2 * 13858067) ^ 0x6F0D0B65);
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}
		catch (Exception reason)
		{
			_8H2QqjADGkx30Hq77Uf9ZGuRzFD(reason);
		}
	}

	public void _8H2QqjADGkx30Hq77Uf9ZGuRzFD(Exception reason = null)
	{
		if (_3OsEBBAlNlEDnoyP1h3yKjAqqfw)
		{
			return;
		}
		while (true)
		{
			int num = -352745154;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB268E975u) % 15u)
				{
				case 4u:
					break;
				default:
					return;
				case 2u:
					Program.LogInfoMessage("client", $"Disposed\n{reason}");
					return;
				case 11u:
				{
					NetworkStream l6WDeCVHHMrhbTcgVYNTZajxMYy = _l6WDeCVHHMrhbTcgVYNTZajxMYy;
					if (l6WDeCVHHMrhbTcgVYNTZajxMYy == null)
					{
						goto case 5u;
					}
					l6WDeCVHHMrhbTcgVYNTZajxMYy.Close();
					num = -770528656;
					continue;
				}
				case 9u:
				{
					NetworkBuffer yH4gIV1xNd6pYzPqVxTzOxg6BU = _YH4gIV1xNd6pYzPqVxTzOxg6BU;
					if (yH4gIV1xNd6pYzPqVxTzOxg6BU == null)
					{
						goto case 7u;
					}
					yH4gIV1xNd6pYzPqVxTzOxg6BU.Destroy();
					num = -400238492;
					continue;
				}
				case 1u:
				{
					NetworkBuffer networkBuffer = _7MlbEvLKjcNDHlwkDf6KZ4IEMcc;
					if (networkBuffer == null)
					{
						goto case 9u;
					}
					networkBuffer.Destroy();
					num = -2714104;
					continue;
				}
				case 7u:
				{
					int num7;
					if (reason == null)
					{
						num = -572652326;
						num7 = num;
					}
					else
					{
						num = -550280078;
						num7 = num;
					}
					continue;
				}
				case 0u:
					Program.LogInfoMessage("client", "Disconnected");
					num = -1413980540;
					continue;
				case 10u:
				{
					NetworkStream iBGB2gFxmPDXBY3vtWT4jbTfDiQ = _IBGB2gFxmPDXBY3vtWT4jbTfDiQ;
					if (iBGB2gFxmPDXBY3vtWT4jbTfDiQ == null)
					{
						goto case 11u;
					}
					iBGB2gFxmPDXBY3vtWT4jbTfDiQ.Close();
					num = -1318017203;
					continue;
				}
				case 13u:
				{
					int num5;
					int num6;
					if (!(reason is IOException))
					{
						num5 = -304694200;
						num6 = num5;
					}
					else
					{
						num5 = -57433646;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -843759832);
					continue;
				}
				case 8u:
				{
					TcpClient qyFBNLtlxoQc1TJPzmx0QAJh70w = _QyFBNLtlxoQc1TJPzmx0QAJh70w;
					if (qyFBNLtlxoQc1TJPzmx0QAJh70w == null)
					{
						goto case 1u;
					}
					qyFBNLtlxoQc1TJPzmx0QAJh70w.Close();
					num = -1689709270;
					continue;
				}
				case 6u:
					_DumVMPhENnNVyQvhZaHdKZdaaMD._ggyYCUsqC4xC7xRoNrdJgcMMFWy(this);
					num = (int)(num2 * 123197175) ^ -1432089101;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (!(reason is SocketException))
					{
						num3 = -2016715449;
						num4 = num3;
					}
					else
					{
						num3 = -80075035;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -551277815);
					continue;
				}
				case 14u:
					_3OsEBBAlNlEDnoyP1h3yKjAqqfw = true;
					num = ((int)num2 * -1880488430) ^ 0x6DD09E6;
					continue;
				case 5u:
				{
					TcpClient tcpClient = _5XbkslECWDrdUntKuoEYQFkXVlX;
					if (tcpClient == null)
					{
						goto case 8u;
					}
					tcpClient.Close();
					num = -364658887;
					continue;
				}
				case 12u:
					return;
				}
				break;
			}
		}
	}

	public void SendToClient(Packet packet)
	{
		SendPacket(packet, client: true);
	}

	public void SendToServer(Packet packet)
	{
		SendPacket(packet, client: false);
	}

	public void _3clAjv67qIg47z8c20OGJcdyjMtA(int slot, int type)
	{
		PotionInfo potionInfo = PotionSlots.ElementAt(slot);
		while (true)
		{
			int num = -1240131417;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8EB2665Eu) % 6u)
				{
				case 4u:
					break;
				default:
					return;
				case 5u:
					potionInfo.Quantity++;
					_QtBizqH8aHz2ixkvUsA6VqqwHGF = Environment.TickCount;
					num = (int)(num2 * 1906965568) ^ -263985042;
					continue;
				case 3u:
				{
					int num5;
					if (potionInfo.Quantity >= 6)
					{
						num = -6900690;
						num5 = num;
					}
					else
					{
						num = -1642109985;
						num5 = num;
					}
					continue;
				}
				case 2u:
					potionInfo.Type = type;
					num = ((int)num2 * -1245899587) ^ -1353402013;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (potionInfo.Quantity == 0)
					{
						num3 = 411732400;
						num4 = num3;
					}
					else
					{
						num3 = 703727597;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1298724858);
					continue;
				}
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void _xlRUy72uPQ98Hy5AvYCNwBvoQ4K(int slot)
	{
		PotionInfo potionInfo = PotionSlots.ElementAt(slot);
		if (potionInfo.Quantity <= 0)
		{
			return;
		}
		byte b = default(byte);
		while (true)
		{
			int num = 286836523;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x48C63BEBu) % 7u)
				{
				case 5u:
					break;
				default:
					return;
				case 2u:
					_QtBizqH8aHz2ixkvUsA6VqqwHGF = Environment.TickCount;
					num = 928778973;
					continue;
				case 1u:
				{
					int num3;
					int num4;
					if (b == 0)
					{
						num3 = -1902293381;
						num4 = num3;
					}
					else
					{
						num3 = -1860576310;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1515623992);
					continue;
				}
				case 4u:
					b = --potionInfo.Quantity;
					num = ((int)num2 * -1721921176) ^ 0x7C24E42F;
					continue;
				case 6u:
					Console.WriteLine($"Subtracting {slot}");
					num = (int)((num2 * 962442252) ^ 0x69F85DAD);
					continue;
				case 3u:
					potionInfo.Type = -1;
					num = (int)((num2 * 2012391830) ^ 0x5F041A8A);
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void SendWithDelay(Packet packet, int ms, bool log = false)
	{
		Task.Run(delegate
		{
			Task.Delay(ms).Wait();
			SendPacket(packet, client: false);
			if (log)
			{
				Console.WriteLine($"Sent packet after {ms}ms {packet}");
			}
		});
	}

	private void SendPacket(Packet packet, bool client)
	{
		lock (client ? _AdmkvARnFctcdXLciZNvHDJInwT : _Gwx0kZiSAw3quYoIxjEIop3DixH)
		{
			try
			{
				using MemoryStream memoryStream = new MemoryStream();
				using (PacketWriter packetWriter = new PacketWriter(memoryStream))
				{
					packetWriter.Write(0);
					packetWriter.Write(packet.ID);
					packet.writePacketData(packetWriter);
					if (packet._p6Ga5HaW6HbwlLT3tvYuJi2GRQN.Length != 0)
					{
						packetWriter.Write(packet._p6Ga5HaW6HbwlLT3tvYuJi2GRQN);
					}
				}
				byte[] array = memoryStream.ToArray();
				PacketWriter._XIRKdXnWUNtF0ipzDYlXXjcMYic(array, array.Length);
				if (client)
				{
					_ntAEc5DBjY43rTpB2x5NeHQac3K._zAcJWalBH8qNGGEljyZyZCOwX2m(array);
					_l6WDeCVHHMrhbTcgVYNTZajxMYy.Write(array, 0, array.Length);
				}
				else
				{
					_IBGB2gFxmPDXBY3vtWT4jbTfDiQ.Write(array, 0, array.Length);
					_7nagdRNfwEzsojGhddpNUNMOyTN._zAcJWalBH8qNGGEljyZyZCOwX2m(array);
				}
			}
			catch (Exception reason)
			{
				_8H2QqjADGkx30Hq77Uf9ZGuRzFD(reason);
			}
		}
	}

	private void _1cGXpzEEbo0g0bvKgbK47uReXKB(int offset, int amount, bool client)
	{
		if (!client)
		{
			goto IL_0003;
		}
		NetworkBuffer yH4gIV1xNd6pYzPqVxTzOxg6BU = _7MlbEvLKjcNDHlwkDf6KZ4IEMcc;
		goto IL_0033;
		IL_0003:
		int num = 1026122578;
		goto IL_0008;
		IL_0033:
		NetworkBuffer networkBuffer = yH4gIV1xNd6pYzPqVxTzOxg6BU;
		if (!client)
		{
			num = 1539807757;
			goto IL_0008;
		}
		NetworkStream networkStream = _IBGB2gFxmPDXBY3vtWT4jbTfDiQ;
		goto IL_004c;
		IL_004c:
		NetworkStream networkStream2 = networkStream;
		try
		{
			networkStream2.BeginRead(networkBuffer.Bytes, offset, amount, _Iu80ZEQ9Hb8rfQHXUwH2ncKxH0C, client);
		}
		catch (Exception reason)
		{
			_8H2QqjADGkx30Hq77Uf9ZGuRzFD(reason);
		}
		return;
		IL_0008:
		uint num2;
		switch ((num2 = (uint)num ^ 0x1F8E7BC3u) % 3u)
		{
		case 0u:
			break;
		case 1u:
			goto IL_0025;
		default:
			goto IL_003e;
		}
		goto IL_0003;
		IL_003e:
		networkStream = _l6WDeCVHHMrhbTcgVYNTZajxMYy;
		goto IL_004c;
		IL_0025:
		yH4gIV1xNd6pYzPqVxTzOxg6BU = _YH4gIV1xNd6pYzPqVxTzOxg6BU;
		goto IL_0033;
	}

	private void _Iu80ZEQ9Hb8rfQHXUwH2ncKxH0C(IAsyncResult ar)
	{
		bool num = (bool)ar.AsyncState;
		NetworkBuffer networkBuffer = (num ? _7MlbEvLKjcNDHlwkDf6KZ4IEMcc : _YH4gIV1xNd6pYzPqVxTzOxg6BU);
		if (!num)
		{
			goto IL_001f;
		}
		NetworkStream networkStream = _IBGB2gFxmPDXBY3vtWT4jbTfDiQ;
		goto IL_0050;
		IL_0042:
		networkStream = _l6WDeCVHHMrhbTcgVYNTZajxMYy;
		goto IL_0050;
		IL_0065:
		RC4Cipher rc4Cipher = _nsrrBFBfjlQbceN4gTlrLH5tZwr;
		goto IL_0073;
		IL_0024:
		int num2;
		uint num3;
		switch ((num3 = (uint)num2 ^ 0xF1092A07u) % 3u)
		{
		case 0u:
			break;
		case 2u:
			goto IL_0042;
		default:
			goto IL_0065;
		}
		goto IL_001f;
		IL_001f:
		num2 = -892032136;
		goto IL_0024;
		IL_0050:
		NetworkStream networkStream2 = networkStream;
		bool flag = networkStream2 == _IBGB2gFxmPDXBY3vtWT4jbTfDiQ;
		if (!flag)
		{
			num2 = -477539417;
			goto IL_0024;
		}
		rc4Cipher = _uGtu9YeFC4OzTYFKlj7bn66i1mP;
		goto IL_0073;
		IL_0073:
		RC4Cipher _2ps8kFLJTvG4bg5idZlm5pGiQry2 = rc4Cipher;
		try
		{
			if (!networkStream2.CanRead)
			{
				goto IL_007f;
			}
			goto IL_018a;
			IL_018a:
			int num4 = networkStream2.EndRead(ar);
			int num5 = -1354021147;
			goto IL_0084;
			IL_0084:
			Packet rI3eJ3XrDMu6I9id6v1cRdIj9o = default(Packet);
			object yd565Ezy4z3WaHBiQxBvko6QJTC = default(object);
			while (true)
			{
				int num8;
				switch ((num3 = (uint)num5 ^ 0xF1092A07u) % 14u)
				{
				case 6u:
					break;
				case 10u:
					_1cGXpzEEbo0g0bvKgbK47uReXKB(networkBuffer.Position, networkBuffer.BytesRemaining(), flag);
					num5 = ((int)num3 * -1621693088) ^ 0x250E281;
					continue;
				case 0u:
					_2ps8kFLJTvG4bg5idZlm5pGiQry2._zAcJWalBH8qNGGEljyZyZCOwX2m(networkBuffer.Bytes);
					rI3eJ3XrDMu6I9id6v1cRdIj9o = Packet.CreatePacketFromType(networkBuffer.Bytes);
					num5 = -837078096;
					continue;
				case 3u:
					return;
				case 5u:
					return;
				case 9u:
					networkBuffer.Initialize(IPAddress.NetworkToHostOrder(BitConverter.ToInt32(networkBuffer.Bytes, 0)));
					_1cGXpzEEbo0g0bvKgbK47uReXKB(networkBuffer.Position, networkBuffer.BytesRemaining(), flag);
					return;
				case 7u:
					goto IL_018a;
				case 12u:
					goto IL_019d;
				case 11u:
					yd565Ezy4z3WaHBiQxBvko6QJTC = _yd565Ezy4z3WaHBiQxBvko6QJTC;
					num5 = ((int)num3 * -1909820269) ^ -84908182;
					continue;
				case 2u:
				{
					networkBuffer.MovePosition(num4);
					int num9;
					int num10;
					if (num4 != 0)
					{
						num9 = -480900273;
						num10 = num9;
					}
					else
					{
						num9 = -1967084652;
						num10 = num9;
					}
					num5 = num9 ^ (int)(num3 * 1312577028);
					continue;
				}
				case 1u:
					goto IL_01fe;
				case 13u:
					_8H2QqjADGkx30Hq77Uf9ZGuRzFD();
					num5 = (int)((num3 * 241854701) ^ 0x74C723B9);
					continue;
				case 8u:
					return;
				default:
					{
						bool lockTaken = false;
						try
						{
							Monitor.Enter(yd565Ezy4z3WaHBiQxBvko6QJTC, ref lockTaken);
							while (true)
							{
								int num6 = -1506673865;
								while (true)
								{
									switch ((num3 = (uint)num6 ^ 0xF1092A07u) % 3u)
									{
									case 0u:
										break;
									default:
										goto end_IL_0250;
									case 1u:
										goto IL_027c;
									case 2u:
										goto end_IL_0250;
									}
									break;
									IL_027c:
									_Ct72oRVCRMLOioe09flAdZ8ec4f(rI3eJ3XrDMu6I9id6v1cRdIj9o);
									num6 = ((int)num3 * -2135847481) ^ 0x134896E9;
								}
							}
							end_IL_0250:;
						}
						finally
						{
							if (lockTaken)
							{
								while (true)
								{
									int num7 = -1441502927;
									while (true)
									{
										switch ((num3 = (uint)num7 ^ 0xF1092A07u) % 3u)
										{
										case 0u:
											break;
										default:
											goto end_IL_0296;
										case 1u:
											goto IL_02bd;
										case 2u:
											goto end_IL_0296;
										}
										break;
										IL_02bd:
										Monitor.Exit(yd565Ezy4z3WaHBiQxBvko6QJTC);
										num7 = (int)(num3 * 1448797197) ^ -737052276;
									}
								}
							}
							end_IL_0296:;
						}
						if (rI3eJ3XrDMu6I9id6v1cRdIj9o._Send)
						{
							goto IL_02de;
						}
						goto IL_0321;
					}
					IL_0321:
					networkBuffer.Reset();
					_1cGXpzEEbo0g0bvKgbK47uReXKB(0, 4, flag);
					num8 = -168076955;
					goto IL_02e3;
					IL_02e3:
					while (true)
					{
						switch ((num3 = (uint)num8 ^ 0xF1092A07u) % 4u)
						{
						case 3u:
							break;
						default:
							return;
						case 1u:
							SendPacket(rI3eJ3XrDMu6I9id6v1cRdIj9o, !flag);
							num8 = ((int)num3 * -1685171567) ^ 0x5FBC8672;
							continue;
						case 0u:
							goto IL_0321;
						case 2u:
							return;
						}
						break;
					}
					goto IL_02de;
					IL_02de:
					num8 = -928290502;
					goto IL_02e3;
				}
				break;
				IL_01fe:
				int num11;
				if (networkBuffer.BytesRemaining() <= 0)
				{
					num5 = -473459855;
					num11 = num5;
				}
				else
				{
					num5 = -308044951;
					num11 = num5;
				}
				continue;
				IL_019d:
				int num12;
				if (networkBuffer.Position != 4)
				{
					num5 = -1827496564;
					num12 = num5;
				}
				else
				{
					num5 = -107863312;
					num12 = num5;
				}
			}
			goto IL_007f;
			IL_007f:
			num5 = -1303012472;
			goto IL_0084;
		}
		catch (Exception reason)
		{
			while (true)
			{
				int num13 = -341154340;
				while (true)
				{
					switch ((num3 = (uint)num13 ^ 0xF1092A07u) % 3u)
					{
					case 2u:
						break;
					default:
						return;
					case 1u:
						goto IL_035e;
					case 0u:
						return;
					}
					break;
					IL_035e:
					_8H2QqjADGkx30Hq77Uf9ZGuRzFD(reason);
					num13 = (int)(num3 * 1088661232) ^ -58080079;
				}
			}
		}
	}

	private void _Ct72oRVCRMLOioe09flAdZ8ec4f(Packet packet)
	{
		UpdatePacket updatePacket = packet as UpdatePacket;
		if (updatePacket == null)
		{
			goto IL_000d;
		}
		goto IL_0ee0;
		IL_0ee0:
		_agaMD0M3QCPNv9ovQakoMaEEq5A.OnUpdate(updatePacket);
		int num = 861868773;
		goto IL_0012;
		IL_0012:
		MovePacket movePacket = default(MovePacket);
		ShowEffectPacket showEffectPacket = default(ShowEffectPacket);
		VaultUpdatePacket vaultUpdatePacket = default(VaultUpdatePacket);
		EnemyHitPacket enemyHitPacket = default(EnemyHitPacket);
		InvResultPacket invResultPacket = default(InvResultPacket);
		NotificationPacket notificationPacket = default(NotificationPacket);
		PlayerShootPacket playerShootPacket = default(PlayerShootPacket);
		TextPacket textPacket = default(TextPacket);
		MapInfoPacket mapInfoPacket = default(MapInfoPacket);
		ReconnectPacket reconnectPacket = default(ReconnectPacket);
		InvDropPacket invDropPacket = default(InvDropPacket);
		AoEAckPacket aoEAckPacket = default(AoEAckPacket);
		PlayerTextPacket playerTextPacket = default(PlayerTextPacket);
		HelloPacket helloPacket = default(HelloPacket);
		AoEPacket aoEPacket = default(AoEPacket);
		UseItemPacket useItemPacket = default(UseItemPacket);
		GuildInviteRequestPacket guildInviteRequestPacket = default(GuildInviteRequestPacket);
		NewTickPacket newTickPacket = default(NewTickPacket);
		QuestObjectPacket questObjectPacket = default(QuestObjectPacket);
		CreateSuccessPacket createSuccessPacket = default(CreateSuccessPacket);
		DamagePacket damagePacket = default(DamagePacket);
		InvSwapPacket invSwapPacket = default(InvSwapPacket);
		GroundDamagePacket groundDamagePacket = default(GroundDamagePacket);
		EnemyShootPacket enemyShootPacket = default(EnemyShootPacket);
		EscapePacket escapePacket = default(EscapePacket);
		PongPacket pongPacket = default(PongPacket);
		PlayerHitPacket playerHitPacket = default(PlayerHitPacket);
		FailurePacket failurePacket = default(FailurePacket);
		DeathPacket deathPacket = default(DeathPacket);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x574E6206u) % 135u)
			{
			case 3u:
				break;
			case 24u:
				_MQGiUwYJADYUvtWZEyKaTTnHwhG.OnMove(movePacket);
				_lUGiNuRFo5etEf9KCYfizlmsaId._tX4Fl2mBYL4XNqNEIW0OPnopM9i(movePacket);
				num = (int)(num2 * 1807524607) ^ -359919282;
				continue;
			case 59u:
				_UEbvS70nnmTDsOCF6FzGLVDj3Aj._YmUsIMJpOnkALS3b15SlCrNHpDCA(showEffectPacket);
				num = 719250070;
				continue;
			case 20u:
				_29Cygi7ILPhL4sLWfXR3KEYpYle = vaultUpdatePacket._29Cygi7ILPhL4sLWfXR3KEYpYle;
				num = (int)(num2 * 907941426) ^ -307747736;
				continue;
			case 49u:
			{
				enemyHitPacket = packet as EnemyHitPacket;
				int num55;
				int num56;
				if (enemyHitPacket == null)
				{
					num55 = 455171910;
					num56 = num55;
				}
				else
				{
					num55 = 802639720;
					num56 = num55;
				}
				num = num55 ^ (int)(num2 * 407318000);
				continue;
			}
			case 95u:
			{
				int num31;
				int num32;
				if (invResultPacket == null)
				{
					num31 = -604968074;
					num32 = num31;
				}
				else
				{
					num31 = -1331317213;
					num32 = num31;
				}
				num = num31 ^ (int)(num2 * 1841139665);
				continue;
			}
			case 62u:
				_geK4oHsbAS9nZM9pjvAHYVUnwQs = vaultUpdatePacket._geK4oHsbAS9nZM9pjvAHYVUnwQs;
				num = ((int)num2 * -920241616) ^ 0x6B325D3A;
				continue;
			case 37u:
			{
				notificationPacket = packet as NotificationPacket;
				int num47;
				int num48;
				if (notificationPacket != null)
				{
					num47 = -2136527181;
					num48 = num47;
				}
				else
				{
					num47 = -1149688253;
					num48 = num47;
				}
				num = num47 ^ ((int)num2 * -1239470972);
				continue;
			}
			case 39u:
				_3EfuLHlaaGhnIb3GCSaEEyNuJL2A.OnPlayerShoot(playerShootPacket);
				num = 1540290832;
				continue;
			case 33u:
				_70M5lCy13kd2dviat1I49qoS0zm._N9zjozggCA9FymbKtC3I9dZkIib(textPacket);
				num = 2024420867;
				continue;
			case 56u:
				_lUGiNuRFo5etEf9KCYfizlmsaId._DT5vfLbxw23gMixKpQ7yxEiQkEe(mapInfoPacket);
				num = ((int)num2 * -531176385) ^ 0x722B4E7F;
				continue;
			case 23u:
				OnReconnect(reconnectPacket);
				num = 2044539358;
				continue;
			case 51u:
			{
				int num35;
				int num36;
				if (movePacket != null)
				{
					num35 = 1529349919;
					num36 = num35;
				}
				else
				{
					num35 = 15364822;
					num36 = num35;
				}
				num = num35 ^ ((int)num2 * -568533298);
				continue;
			}
			case 124u:
				_lUGiNuRFo5etEf9KCYfizlmsaId._n0JAIElTXMoPeH6KBaRBdWaaWov(invResultPacket);
				num = (int)((num2 * 201538366) ^ 0x3B382B9E);
				continue;
			case 130u:
				_m3wMOEouSwmahwc13fW7jfLDEhz.OnMapInfo(mapInfoPacket);
				num = ((int)num2 * -911087682) ^ 0x48860102;
				continue;
			case 16u:
				_kdpxlwPITosuhIOBZ8xOg33CYft.OnShowEffect(showEffectPacket);
				num = (int)((num2 * 780452967) ^ 0x2F3CD7B4);
				continue;
			case 101u:
				return;
			case 114u:
				invDropPacket = packet as InvDropPacket;
				num = (int)((num2 * 754471344) ^ 0x37C07CDC);
				continue;
			case 115u:
				_3EfuLHlaaGhnIb3GCSaEEyNuJL2A.OnAoEPacket(aoEAckPacket);
				num = (int)((num2 * 1134175212) ^ 0x2D8E14F2);
				continue;
			case 60u:
				_TuLDXgoWhZy8CPtlhPaAWviSNq3.HandlePlayerCommand(playerTextPacket);
				num = (int)((num2 * 1996127880) ^ 0x766A8683);
				continue;
			case 129u:
				_Yj6Ub8zlrxF6fOL3oEB73K0mFDg.StartConnectNotificationTask();
				_K8f4oiOwgZwEwnKUWcsX1cUgZK.SetDefaultTimer();
				num = ((int)num2 * -480529224) ^ 0x7129C0DB;
				continue;
			case 96u:
				_UEbvS70nnmTDsOCF6FzGLVDj3Aj._DT5vfLbxw23gMixKpQ7yxEiQkEe(mapInfoPacket);
				num = ((int)num2 * -1310608981) ^ 0xE485CF6;
				continue;
			case 75u:
				OnHello(helloPacket);
				return;
			case 28u:
				_agaMD0M3QCPNv9ovQakoMaEEq5A._G32brJa4jmWaZroFncLDOsAha5VA(aoEPacket);
				num = 1463859890;
				continue;
			case 72u:
				_Yj6Ub8zlrxF6fOL3oEB73K0mFDg.OnUseItem(useItemPacket);
				num = (int)(num2 * 198270688) ^ -512556363;
				continue;
			case 5u:
				_oSzQCZbBOYIozX7RJv3aqVCVMPx._RaJfLbqtDAWcw1IcTvMZKk5jtcu(guildInviteRequestPacket);
				return;
			case 78u:
				aoEAckPacket = packet as AoEAckPacket;
				num = (int)((num2 * 760188494) ^ 0x371A3140);
				continue;
			case 14u:
				_bitlLp8JKl1PbTlHWIEIOAJDyuO._CgwO1K8tgdyKPdKvCtJupNhapLD(playerTextPacket);
				num = ((int)num2 * -1046655705) ^ -491696114;
				continue;
			case 67u:
				return;
			case 93u:
				_3EfuLHlaaGhnIb3GCSaEEyNuJL2A._kcBjTzBYfTPCpKNctSQjw45y1mb();
				num = (int)((num2 * 384103150) ^ 0x43B3F593);
				continue;
			case 43u:
				_lUGiNuRFo5etEf9KCYfizlmsaId._kcBjTzBYfTPCpKNctSQjw45y1mb(newTickPacket);
				return;
			case 112u:
				return;
			case 22u:
				_bitlLp8JKl1PbTlHWIEIOAJDyuO._73wAP4ozRO5hPRsKKuqzMgWaCqD(questObjectPacket);
				return;
			case 122u:
				_3EfuLHlaaGhnIb3GCSaEEyNuJL2A.OnUseItem(useItemPacket);
				num = 1610454741;
				continue;
			case 21u:
				_Yj6Ub8zlrxF6fOL3oEB73K0mFDg.OnUpdate(updatePacket);
				_agaMD0M3QCPNv9ovQakoMaEEq5A._emTnZmGyChlXH4IDm60126G1Snf(updatePacket);
				num = ((int)num2 * -145660199) ^ -1465992442;
				continue;
			case 65u:
			{
				createSuccessPacket = packet as CreateSuccessPacket;
				int num53;
				int num54;
				if (createSuccessPacket != null)
				{
					num53 = 1907412955;
					num54 = num53;
				}
				else
				{
					num53 = 1307226986;
					num54 = num53;
				}
				num = num53 ^ ((int)num2 * -1580095658);
				continue;
			}
			case 55u:
			{
				int num49;
				int num50;
				if (useItemPacket == null)
				{
					num49 = 541223421;
					num50 = num49;
				}
				else
				{
					num49 = 2092803321;
					num50 = num49;
				}
				num = num49 ^ ((int)num2 * -252219849);
				continue;
			}
			case 26u:
				_MQGiUwYJADYUvtWZEyKaTTnHwhG.OnNewTick(newTickPacket);
				num = (int)((num2 * 548398357) ^ 0x7910B16E);
				continue;
			case 35u:
				_MQGiUwYJADYUvtWZEyKaTTnHwhG.OnAoE(aoEPacket);
				num = ((int)num2 * -1405731942) ^ 0x1B8F0856;
				continue;
			case 110u:
				return;
			case 79u:
				aoEPacket = packet as AoEPacket;
				num = ((int)num2 * -1237676274) ^ -564947312;
				continue;
			case 32u:
				_Pg28U1MUv2y9I7GawSrEglFuQNv = vaultUpdatePacket._Pg28U1MUv2y9I7GawSrEglFuQNv;
				num = (int)(num2 * 652854095) ^ -2026150670;
				continue;
			case 107u:
			{
				int num39;
				int num40;
				if (aoEPacket != null)
				{
					num39 = 1753034515;
					num40 = num39;
				}
				else
				{
					num39 = 502102928;
					num40 = num39;
				}
				num = num39 ^ ((int)num2 * -1006841315);
				continue;
			}
			case 134u:
				reconnectPacket = packet as ReconnectPacket;
				num = (int)(num2 * 2033962370) ^ -1451303226;
				continue;
			case 0u:
				_kdpxlwPITosuhIOBZ8xOg33CYft.OnTextPacket(textPacket);
				num = (int)((num2 * 1379010485) ^ 0x52F51B06);
				continue;
			case 45u:
			{
				int num29;
				int num30;
				if (playerShootPacket != null)
				{
					num29 = -949956551;
					num30 = num29;
				}
				else
				{
					num29 = -2106601450;
					num30 = num29;
				}
				num = num29 ^ ((int)num2 * -444262359);
				continue;
			}
			case 97u:
				_agaMD0M3QCPNv9ovQakoMaEEq5A.OnMove(movePacket);
				return;
			case 54u:
				damagePacket = packet as DamagePacket;
				num = (int)(num2 * 1933491637) ^ -1658788360;
				continue;
			case 4u:
				_UEbvS70nnmTDsOCF6FzGLVDj3Aj._N9zjozggCA9FymbKtC3I9dZkIib(textPacket);
				num = (int)((num2 * 694930973) ^ 0x4AF55257);
				continue;
			case 44u:
			{
				helloPacket = packet as HelloPacket;
				int num23;
				int num24;
				if (helloPacket != null)
				{
					num23 = 1815855043;
					num24 = num23;
				}
				else
				{
					num23 = 541047901;
					num24 = num23;
				}
				num = num23 ^ (int)(num2 * 1465532023);
				continue;
			}
			case 15u:
				showEffectPacket = packet as ShowEffectPacket;
				num = (int)((num2 * 1208642284) ^ 0xDE777C6);
				continue;
			case 69u:
				_3EfuLHlaaGhnIb3GCSaEEyNuJL2A._YZBUA9d1NRteoNEIGwJjUbTmHLC();
				num = (int)(num2 * 1507881050) ^ -303608477;
				continue;
			case 10u:
				_UqAoky1lauc0gYPMEYUcYfMlJkC = createSuccessPacket._ObjectId;
				num = 1675673508;
				continue;
			case 119u:
			{
				invSwapPacket = packet as InvSwapPacket;
				int num15;
				int num16;
				if (invSwapPacket != null)
				{
					num15 = 217761286;
					num16 = num15;
				}
				else
				{
					num15 = 1694729806;
					num16 = num15;
				}
				num = num15 ^ ((int)num2 * -1132932338);
				continue;
			}
			case 92u:
				return;
			case 42u:
			{
				groundDamagePacket = packet as GroundDamagePacket;
				int num11;
				int num12;
				if (groundDamagePacket == null)
				{
					num11 = 1853663750;
					num12 = num11;
				}
				else
				{
					num11 = 1477382187;
					num12 = num11;
				}
				num = num11 ^ ((int)num2 * -180574205);
				continue;
			}
			case 121u:
				return;
			case 118u:
			{
				vaultUpdatePacket = packet as VaultUpdatePacket;
				int num7;
				int num8;
				if (vaultUpdatePacket != null)
				{
					num7 = -1834491856;
					num8 = num7;
				}
				else
				{
					num7 = -1795922576;
					num8 = num7;
				}
				num = num7 ^ (int)(num2 * 481254008);
				continue;
			}
			case 111u:
				_agaMD0M3QCPNv9ovQakoMaEEq5A.OnNewTick(newTickPacket);
				_Yj6Ub8zlrxF6fOL3oEB73K0mFDg.OnNewTick(newTickPacket);
				_agaMD0M3QCPNv9ovQakoMaEEq5A._kcBjTzBYfTPCpKNctSQjw45y1mb(newTickPacket);
				num = 1678955939;
				continue;
			case 128u:
				_X8Ko4JuJwLwDHPlTH06yuEvAEUl._CgwO1K8tgdyKPdKvCtJupNhapLD(playerTextPacket);
				num = (int)((num2 * 1981112461) ^ 0x5FA6A83B);
				continue;
			case 98u:
			{
				guildInviteRequestPacket = packet as GuildInviteRequestPacket;
				int num61;
				int num62;
				if (guildInviteRequestPacket == null)
				{
					num61 = 263568524;
					num62 = num61;
				}
				else
				{
					num61 = 1987842927;
					num62 = num61;
				}
				num = num61 ^ ((int)num2 * -371450266);
				continue;
			}
			case 89u:
				_lUGiNuRFo5etEf9KCYfizlmsaId._1UIxXEL495RF9327ls9jIZFBwaA(invSwapPacket);
				_3EfuLHlaaGhnIb3GCSaEEyNuJL2A.OnInvSwap(invSwapPacket);
				return;
			case 83u:
				_agaMD0M3QCPNv9ovQakoMaEEq5A._W4ULDsCzGjGES6SCKBD4lp5hvRd(groundDamagePacket);
				return;
			case 19u:
				_Yj6Ub8zlrxF6fOL3oEB73K0mFDg.OnPlayerText(playerTextPacket);
				num = 1689494784;
				continue;
			case 80u:
				_kdpxlwPITosuhIOBZ8xOg33CYft.OnMapInfo(mapInfoPacket);
				num = ((int)num2 * -429447844) ^ 0x3B85866F;
				continue;
			case 34u:
				_3EfuLHlaaGhnIb3GCSaEEyNuJL2A._CgwO1K8tgdyKPdKvCtJupNhapLD(playerTextPacket);
				return;
			case 40u:
				_oSzQCZbBOYIozX7RJv3aqVCVMPx._kcBjTzBYfTPCpKNctSQjw45y1mb();
				_UEbvS70nnmTDsOCF6FzGLVDj3Aj._kcBjTzBYfTPCpKNctSQjw45y1mb(newTickPacket);
				num = (int)(num2 * 823676646) ^ -914357576;
				continue;
			case 11u:
			{
				int num59;
				int num60;
				if (invDropPacket == null)
				{
					num59 = 454872422;
					num60 = num59;
				}
				else
				{
					num59 = 1423895098;
					num60 = num59;
				}
				num = num59 ^ ((int)num2 * -1013398642);
				continue;
			}
			case 86u:
				enemyShootPacket = packet as EnemyShootPacket;
				num = ((int)num2 * -965197653) ^ 0x70ACEA21;
				continue;
			case 1u:
				playerShootPacket = packet as PlayerShootPacket;
				num = ((int)num2 * -1539930403) ^ 0x7441E8DF;
				continue;
			case 50u:
				_Yj6Ub8zlrxF6fOL3oEB73K0mFDg.OnInvDrop(invDropPacket);
				num = 1521393926;
				continue;
			case 70u:
				_Yj6Ub8zlrxF6fOL3oEB73K0mFDg.OnEnemyShoot(enemyShootPacket);
				num = 1717453573;
				continue;
			case 127u:
				_kdpxlwPITosuhIOBZ8xOg33CYft.OnEnemyHit(enemyHitPacket);
				return;
			case 116u:
				return;
			case 84u:
				escapePacket = packet as EscapePacket;
				num = (int)((num2 * 1935711568) ^ 0x1887B77C);
				continue;
			case 113u:
			{
				textPacket = packet as TextPacket;
				int num57;
				int num58;
				if (textPacket != null)
				{
					num57 = -2028473392;
					num58 = num57;
				}
				else
				{
					num57 = -1987910501;
					num58 = num57;
				}
				num = num57 ^ (int)(num2 * 1433402822);
				continue;
			}
			case 104u:
				return;
			case 100u:
				useItemPacket = packet as UseItemPacket;
				num = ((int)num2 * -453749204) ^ -1040641439;
				continue;
			case 73u:
				_Yj6Ub8zlrxF6fOL3oEB73K0mFDg.OnMove(movePacket);
				num = ((int)num2 * -871642949) ^ 0x45CC585C;
				continue;
			case 109u:
				pongPacket = packet as PongPacket;
				num = ((int)num2 * -596973348) ^ 0x62C371C9;
				continue;
			case 106u:
			{
				int num51;
				int num52;
				if (reconnectPacket == null)
				{
					num51 = -479616118;
					num52 = num51;
				}
				else
				{
					num51 = -613360694;
					num52 = num51;
				}
				num = num51 ^ (int)(num2 * 996055868);
				continue;
			}
			case 71u:
				_itBzbWMkvo0AuQGuR19us26p4TP = vaultUpdatePacket._itBzbWMkvo0AuQGuR19us26p4TP;
				num = 2015711820;
				continue;
			case 58u:
				_agaMD0M3QCPNv9ovQakoMaEEq5A._gHqtNcWyCVVFxHdmeuer3tJSw4p(playerHitPacket);
				_MQGiUwYJADYUvtWZEyKaTTnHwhG.OnPlayerHit(playerHitPacket);
				num = 2136890299;
				continue;
			case 25u:
			{
				int num45;
				int num46;
				if (newTickPacket != null)
				{
					num45 = 119501286;
					num46 = num45;
				}
				else
				{
					num45 = 1225349672;
					num46 = num45;
				}
				num = num45 ^ ((int)num2 * -332427900);
				continue;
			}
			case 31u:
				_qEzzfhETXrgbZF6Y037bCMj1ZiW._tX4Fl2mBYL4XNqNEIW0OPnopM9i(movePacket);
				num = (int)((num2 * 230231302) ^ 0x41593C36);
				continue;
			case 125u:
				_X8Ko4JuJwLwDHPlTH06yuEvAEUl._DT5vfLbxw23gMixKpQ7yxEiQkEe(mapInfoPacket);
				num = (int)(num2 * 1127798770) ^ -418668786;
				continue;
			case 117u:
			{
				playerTextPacket = packet as PlayerTextPacket;
				int num43;
				int num44;
				if (playerTextPacket != null)
				{
					num43 = -394106911;
					num44 = num43;
				}
				else
				{
					num43 = -98127276;
					num44 = num43;
				}
				num = num43 ^ (int)(num2 * 110296144);
				continue;
			}
			case 76u:
				invResultPacket = packet as InvResultPacket;
				num = (int)((num2 * 714590069) ^ 0x10A5F191);
				continue;
			case 90u:
				_zGfl045ehROhk6jo6nvkc12rcvH = vaultUpdatePacket._zGfl045ehROhk6jo6nvkc12rcvH;
				num = (int)(num2 * 982120159) ^ -1293017288;
				continue;
			case 108u:
			{
				int num41;
				int num42;
				if (escapePacket == null)
				{
					num41 = -1486200912;
					num42 = num41;
				}
				else
				{
					num41 = -794665109;
					num42 = num41;
				}
				num = num41 ^ ((int)num2 * -283602362);
				continue;
			}
			case 87u:
				_agaMD0M3QCPNv9ovQakoMaEEq5A._f8Cv4bMnfjjwRWfQwllvwFZDPuI(aoEAckPacket);
				num = 1573515776;
				continue;
			case 6u:
			{
				int num37;
				int num38;
				if (aoEAckPacket == null)
				{
					num37 = 715471755;
					num38 = num37;
				}
				else
				{
					num37 = 95052233;
					num38 = num37;
				}
				num = num37 ^ (int)(num2 * 1301286691);
				continue;
			}
			case 53u:
				_HHeb9q7rrHLt7HwtYTuHlRRDlMT.OnMapInfo(mapInfoPacket);
				_agaMD0M3QCPNv9ovQakoMaEEq5A.OnMapInfo(mapInfoPacket);
				num = ((int)num2 * -303737791) ^ -1541728745;
				continue;
			case 99u:
				return;
			case 88u:
				_HHeb9q7rrHLt7HwtYTuHlRRDlMT.OnUpdate(updatePacket);
				_UEbvS70nnmTDsOCF6FzGLVDj3Aj._emTnZmGyChlXH4IDm60126G1Snf(updatePacket);
				num = (int)((num2 * 555725824) ^ 0x142A0779);
				continue;
			case 57u:
				return;
			case 126u:
			{
				int num33;
				int num34;
				if (damagePacket != null)
				{
					num33 = -1266524947;
					num34 = num33;
				}
				else
				{
					num33 = -1945384391;
					num34 = num33;
				}
				num = num33 ^ ((int)num2 * -1614476238);
				continue;
			}
			case 82u:
				Program.LogInfoMessage("client", $"Got failure {failurePacket._Id}, {failurePacket._Description} ({failurePacket._Place})");
				return;
			case 66u:
				_3EfuLHlaaGhnIb3GCSaEEyNuJL2A.OnMapInfo(mapInfoPacket);
				num = (int)(num2 * 1496453995) ^ -926698861;
				continue;
			case 2u:
				return;
			case 120u:
				return;
			case 102u:
				return;
			case 94u:
				_kdpxlwPITosuhIOBZ8xOg33CYft.OnNewTick(newTickPacket);
				num = ((int)num2 * -1948027478) ^ -605382549;
				continue;
			case 85u:
				return;
			case 27u:
				return;
			case 103u:
			{
				deathPacket = packet as DeathPacket;
				int num27;
				int num28;
				if (deathPacket != null)
				{
					num27 = -685199391;
					num28 = num27;
				}
				else
				{
					num27 = -1186237444;
					num28 = num27;
				}
				num = num27 ^ (int)(num2 * 22218023);
				continue;
			}
			case 13u:
			{
				questObjectPacket = packet as QuestObjectPacket;
				int num25;
				int num26;
				if (questObjectPacket == null)
				{
					num25 = -944197431;
					num26 = num25;
				}
				else
				{
					num25 = -898785608;
					num26 = num25;
				}
				num = num25 ^ ((int)num2 * -2028152594);
				continue;
			}
			case 7u:
				goto IL_0ee0;
			case 74u:
				_K8f4oiOwgZwEwnKUWcsX1cUgZK._LYllxX1tdQbcE7Ay0idETQ7uwOS();
				num = 512035895;
				continue;
			case 52u:
				_UEbvS70nnmTDsOCF6FzGLVDj3Aj._C3mvDTxTLKOCwcaeO4BKeVV1ydo(damagePacket);
				return;
			case 105u:
				return;
			case 18u:
				newTickPacket = packet as NewTickPacket;
				num = (int)(num2 * 1318750141) ^ -306065650;
				continue;
			case 63u:
			{
				int num21;
				int num22;
				if (playerHitPacket != null)
				{
					num21 = 1104953974;
					num22 = num21;
				}
				else
				{
					num21 = 159784724;
					num22 = num21;
				}
				num = num21 ^ (int)(num2 * 1857479598);
				continue;
			}
			case 8u:
				OnEscape(escapePacket);
				return;
			case 17u:
			{
				int num19;
				int num20;
				if (enemyShootPacket == null)
				{
					num19 = -2059088464;
					num20 = num19;
				}
				else
				{
					num19 = -96563127;
					num20 = num19;
				}
				num = num19 ^ ((int)num2 * -1293493362);
				continue;
			}
			case 132u:
				movePacket = packet as MovePacket;
				num = ((int)num2 * -1062314101) ^ -1939299991;
				continue;
			case 46u:
				Console.WriteLine(invSwapPacket.ToString());
				num = 1447781103;
				continue;
			case 9u:
				_lUGiNuRFo5etEf9KCYfizlmsaId._emTnZmGyChlXH4IDm60126G1Snf(updatePacket);
				_X8Ko4JuJwLwDHPlTH06yuEvAEUl._emTnZmGyChlXH4IDm60126G1Snf(updatePacket);
				_kdpxlwPITosuhIOBZ8xOg33CYft.OnUpdate(updatePacket);
				num = ((int)num2 * -1198978089) ^ -812561677;
				continue;
			case 30u:
				_Yj6Ub8zlrxF6fOL3oEB73K0mFDg.OnInvResult(invResultPacket);
				num = 1106473787;
				continue;
			case 12u:
				Program.LogInfoMessage("client", "Map is " + mapInfoPacket._MapName);
				_Yj6Ub8zlrxF6fOL3oEB73K0mFDg.OnMapInfo(mapInfoPacket);
				num = 657137453;
				continue;
			case 29u:
			{
				int num17;
				int num18;
				if (pongPacket == null)
				{
					num17 = 1945487541;
					num18 = num17;
				}
				else
				{
					num17 = 1121759798;
					num18 = num17;
				}
				num = num17 ^ ((int)num2 * -2074714266);
				continue;
			}
			case 91u:
				return;
			case 133u:
			{
				int num13;
				int num14;
				if (packet is PingPacket)
				{
					num13 = 1356791999;
					num14 = num13;
				}
				else
				{
					num13 = 823302140;
					num14 = num13;
				}
				num = num13 ^ (int)(num2 * 2108363258);
				continue;
			}
			case 77u:
				_agaMD0M3QCPNv9ovQakoMaEEq5A.OnDeath(deathPacket);
				num = 831932179;
				continue;
			case 64u:
				playerHitPacket = packet as PlayerHitPacket;
				num = ((int)num2 * -14768397) ^ -709839329;
				continue;
			case 131u:
				_m3wMOEouSwmahwc13fW7jfLDEhz._emTnZmGyChlXH4IDm60126G1Snf(updatePacket);
				num = (int)((num2 * 436222554) ^ 0x5F0A81D9);
				continue;
			case 41u:
				_agaMD0M3QCPNv9ovQakoMaEEq5A._clpx4Sn1ScoFsLzGLg7gEAbKG8(notificationPacket);
				return;
			case 61u:
				_3EfuLHlaaGhnIb3GCSaEEyNuJL2A._w523XOeezIrQZ8eMr8WGCIMyQ8N(pongPacket);
				return;
			case 68u:
				_agaMD0M3QCPNv9ovQakoMaEEq5A.OnPlayerText(playerTextPacket);
				num = (int)(num2 * 624219672) ^ -2062523474;
				continue;
			case 81u:
				_mVrHB9iWE8fKC1cy09EH2Tg38G = vaultUpdatePacket._mVrHB9iWE8fKC1cy09EH2Tg38G;
				num = ((int)num2 * -604262114) ^ 0x68446476;
				continue;
			case 38u:
			{
				int num9;
				int num10;
				if (showEffectPacket != null)
				{
					num9 = 2031698309;
					num10 = num9;
				}
				else
				{
					num9 = 1870623480;
					num10 = num9;
				}
				num = num9 ^ ((int)num2 * -912617998);
				continue;
			}
			case 123u:
			{
				mapInfoPacket = packet as MapInfoPacket;
				int num5;
				int num6;
				if (mapInfoPacket != null)
				{
					num5 = 1168635493;
					num6 = num5;
				}
				else
				{
					num5 = 1730162070;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1965275968);
				continue;
			}
			case 36u:
				_MGoEUVg87yxb0wl81YAnJbDAulW = movePacket._Time;
				num = 1524823534;
				continue;
			case 47u:
			{
				failurePacket = packet as FailurePacket;
				int num3;
				int num4;
				if (failurePacket == null)
				{
					num3 = 1319685500;
					num4 = num3;
				}
				else
				{
					num3 = 1663029819;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -180106590);
				continue;
			}
			default:
				_hTsir1YKLqh6ix2IjcIYsrZSQJF = true;
				return;
			}
			break;
		}
		goto IL_000d;
		IL_000d:
		num = 1100234201;
		goto IL_0012;
	}

	private void OnHello(HelloPacket hello)
	{
		_QyFBNLtlxoQc1TJPzmx0QAJh70w = new TcpClient {NoDelay = true};
		ReconnectPacket reconnectPacket = default(ReconnectPacket);
		string key = default(string);
		string host = default(string);
		while (true)
		{
			int num = -1393959334;
			while (true)
			{
				uint num2;
				string text;
				switch ((num2 = (uint)num ^ 0xA75DE50Du) % 14u)
				{
				case 12u:
					break;
				case 6u:
					Program.LogInfoMessage("client", "Restored reconnect info.");
					num = (int)((num2 * 646613941) ^ 0x1D9D4830);
					continue;
				case 0u:
					hello._GameId = reconnectPacket._GameId;
					num = (int)(num2 * 707237511) ^ -1845464049;
					continue;
				case 9u:
					if (ServerList._ServerList.ContainsKey(Settings.Default.CurrentServer))
					{
						num = -1967751933;
						continue;
					}
					text = ServerList._ServerList.First().Value;
					goto IL_01cb;
				case 7u:
				{
					int num5;
					int num6;
					if (_DumVMPhENnNVyQvhZaHdKZdaaMD._JlhuftEwIx9QqEcmrh5juOLuNhE.ContainsKey(key))
					{
						num5 = 95926249;
						num6 = num5;
					}
					else
					{
						num5 = 1314550744;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -921043328);
					continue;
				}
				case 5u:
					_QyFBNLtlxoQc1TJPzmx0QAJh70w.BeginConnect(reconnectPacket._Hostname, reconnectPacket._Port, _5uZ25pP9Y4fbygV3rQnxXGU1Syd, hello);
					num = ((int)num2 * -728837069) ^ -1135281198;
					continue;
				case 8u:
					hello._Key = reconnectPacket._Key;
					num = (int)(num2 * 1031461585) ^ -1554569758;
					continue;
				case 1u:
				{
					key = _fvjeDdCWCcAa9Yq1lOCAy0ktNXt(hello._Key);
					int num3;
					int num4;
					if (hello._Key.Length == 0)
					{
						num3 = 400408047;
						num4 = num3;
					}
					else
					{
						num3 = 1001824545;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1536047265);
					continue;
				}
				case 3u:
					hello._KeyTime = reconnectPacket._KeyTime;
					num = ((int)num2 * -739493139) ^ -2065669393;
					continue;
				case 10u:
					text = ServerList._ServerList[Settings.Default.CurrentServer];
					goto IL_01cb;
				case 4u:
					reconnectPacket = _DumVMPhENnNVyQvhZaHdKZdaaMD._JlhuftEwIx9QqEcmrh5juOLuNhE[key];
					num = ((int)num2 * -266103995) ^ -1853748709;
					continue;
				case 2u:
					Program.LogInfoMessage("client", "Used default connect info.");
					num = ((int)num2 * -1690499730) ^ -2074540180;
					continue;
				case 13u:
					_QyFBNLtlxoQc1TJPzmx0QAJh70w.BeginConnect(host, 2050, _5uZ25pP9Y4fbygV3rQnxXGU1Syd, hello);
					num = (int)((num2 * 954312666) ^ 0x3BB5FD55);
					continue;
				default:
					{
						hello._Send = false;
						return;
					}
					IL_01cb:
					host = text;
					num = -863368884;
					continue;
				}
				break;
			}
		}
	}

	private void OnReconnect(ReconnectPacket reconnect)
	{
		if (reconnect._Key.Length == 0)
		{
			return;
		}
		ReconnectPacket reconnectPacket = default(ReconnectPacket);
		string key = default(string);
		while (true)
		{
			int num = -301422660;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE31F799Du) % 13u)
				{
				case 12u:
					break;
				default:
					return;
				case 11u:
					reconnectPacket._Port = ((reconnect._Port == -1) ? (_QyFBNLtlxoQc1TJPzmx0QAJh70w.Client.RemoteEndPoint as IPEndPoint).Port : reconnect._Port);
					reconnectPacket._IsFromArena = reconnect._IsFromArena;
					reconnectPacket._Key = reconnect._Key;
					num = -124069949;
					continue;
				case 8u:
				{
					key = _fvjeDdCWCcAa9Yq1lOCAy0ktNXt(reconnect._Key);
					int num3;
					int num4;
					if (!_DumVMPhENnNVyQvhZaHdKZdaaMD._JlhuftEwIx9QqEcmrh5juOLuNhE.ContainsKey(key))
					{
						num3 = -185536008;
						num4 = num3;
					}
					else
					{
						num3 = -506346412;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 695695818);
					continue;
				}
				case 7u:
				{
					int num5;
					int num6;
					if (!reconnect._Hostname.Contains(".com"))
					{
						num5 = -1194704443;
						num6 = num5;
					}
					else
					{
						num5 = -1002255953;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1201951984);
					continue;
				}
				case 0u:
					reconnectPacket._MapName = reconnect._MapName;
					num = (int)((num2 * 719888838) ^ 0x6A0CF13);
					continue;
				case 6u:
					reconnectPacket._KeyTime = reconnect._KeyTime;
					num = ((int)num2 * -1205335213) ^ -2000762410;
					continue;
				case 3u:
					reconnectPacket._Hostname = (string.IsNullOrWhiteSpace(reconnect._Hostname) ? (_QyFBNLtlxoQc1TJPzmx0QAJh70w.Client.RemoteEndPoint as IPEndPoint).Address.ToString() : reconnect._Hostname);
					num = -1659702820;
					continue;
				case 1u:
					reconnectPacket = (ReconnectPacket)Packet.CreatePacketFromType(PacketType.RECONNECT);
					num = -500296348;
					continue;
				case 4u:
					reconnectPacket._GameId = reconnect._GameId;
					num = (int)(num2 * 137909131) ^ -493106098;
					continue;
				case 2u:
					reconnect._Hostname = Dns.GetHostEntry(reconnect._Hostname).AddressList[0].ToString();
					num = ((int)num2 * -22033570) ^ -373128023;
					continue;
				case 10u:
				{
					_DumVMPhENnNVyQvhZaHdKZdaaMD._JlhuftEwIx9QqEcmrh5juOLuNhE.TryRemove(key, out var _);
					num = ((int)num2 * -1426821600) ^ 0xB2DCAC8;
					continue;
				}
				case 5u:
					_DumVMPhENnNVyQvhZaHdKZdaaMD._JlhuftEwIx9QqEcmrh5juOLuNhE.TryAdd(key, reconnectPacket);
					reconnect._Hostname = "127.0.0.1";
					reconnect._Port = 2050;
					Program.LogInfoMessage("client", "Stored reconnect info.");
					num = -123412716;
					continue;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	private void OnEscape(EscapePacket escape)
	{
		ReconnectPacket reconnectPacket = (ReconnectPacket)Packet.CreatePacketFromType(PacketType.RECONNECT);
		reconnectPacket._GameId = -2;
		reconnectPacket._Hostname = string.Empty;
		reconnectPacket._Port = -1;
		reconnectPacket._IsFromArena = false;
		reconnectPacket._Key = new byte[0];
		reconnectPacket._KeyTime = -1;
		reconnectPacket._MapName = "Nexus";
		
		SendToClient(reconnectPacket);
		Program.LogInfoMessage("client", "Sent nexus reconnect.");
	}

	public static string _fvjeDdCWCcAa9Yq1lOCAy0ktNXt(byte[] ba)
	{
		StringBuilder stringBuilder = new StringBuilder(ba.Length * 2);
		int num3 = default(int);
		while (true)
		{
			int num = -1562008480;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFE059F4Bu) % 6u)
				{
				case 3u:
					break;
				case 4u:
					num3++;
					num = (int)((num2 * 917452131) ^ 0x2A38698F);
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= ba.Length)
					{
						num = -2027821840;
						num4 = num;
					}
					else
					{
						num = -1220103867;
						num4 = num;
					}
					continue;
				}
				case 1u:
					num3 = 0;
					num = ((int)num2 * -217504399) ^ -1725369792;
					continue;
				case 2u:
				{
					byte b = ba[num3];
					stringBuilder.AppendFormat("{0:x2}", b);
					num = -1737368713;
					continue;
				}
				default:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	public byte _5F11zlatiaeKtzrzg30JrtdXmjH()
	{
		byte bljpqzndse2l5Ssytdk5w8SDvkC = _bljpqzndse2l5Ssytdk5w8SDvkC;
		_bljpqzndse2l5Ssytdk5w8SDvkC = (byte)((_bljpqzndse2l5Ssytdk5w8SDvkC + 1) % 128);
		return bljpqzndse2l5Ssytdk5w8SDvkC;
	}

	public MapStructure _psKBaUvFAGf2xFOCwHRyUMbhDXG(WorldPosData loc)
	{
		return _psKBaUvFAGf2xFOCwHRyUMbhDXG((int)loc._PositionX, (int)loc._PositionY);
	}

	public MapStructure _psKBaUvFAGf2xFOCwHRyUMbhDXG(int x, int y)
	{
		int num = x * _PositionX + y;
		return _2CIHnoEa49dfPXyqt9nkkBlUcQf[num];
	}

	public void SendChatNotification(string name, string message)
	{
		SendToClient(TextPacket.SendToPlayer(name, message));
	}

	public void _TVcgSr7bcouFhNfw8PyT9bbBIM0(string message)
	{
		if (Settings.Default.DisableSystemMessages) {
			return;
		}
		SendToClient(TextPacket.SendSystemMessage(message));
	}
}
