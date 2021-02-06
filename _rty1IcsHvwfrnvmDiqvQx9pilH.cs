using System;
using System.Collections.Generic;
using System.Linq;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.DataStructures;
using ExaltMultiTool.Proxy.Mods;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class _rty1IcsHvwfrnvmDiqvQx9pilH
{
	private const bool _VxECAYpjHcErYFwPo21VPyCqo1Db = false;

	private _PlferqYaObizDfc28C5jdKSLGq5 _50w8wVuv8bL5nhKaR2EHxjrTamB;

	public bool _VczQDeMDvlxm06HSYLiD8FbT7qj;

	private int _wpv3L2x9SVwVG8oTXkB9xlrWfYf;

	private int _8bQcVNrY4sOsCzDreFoeakMtpBK;

	private int _fEgmKLJBX4eDyOg6a5xshzKbnJN = 100;

	private int _bW2bcXGC7ddy4Byg043DK6aTDBaA = 100;

	private double _nZ4umDhXWmp8bGVywQUwURRhqK;

	private int _tnzATORRz69PD9QNslfqhszFO2M;

	private int _uLq0XCL0AeTDi3FS849oUHVJt0h;

	private bool _oV73NEwk247WZa6wM3sxIJwPEei;

	private bool _GwYvhv88QJIDA9V6ds6bsTq5fCC;

	private List<_Jb0feCILTkEl6pcg2T1V15k3pU9> _Rjfm4PW3aMRNwsporG8wkl5wG5G = new List<_Jb0feCILTkEl6pcg2T1V15k3pU9>();

	private WorldPosData _rZfAtVaDv7a30Cx46re9BwDcDp3 = WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R;

	private bool _nSbn5BiGHvwfVPOliLfIaQJ4jcb;

	private int _YoiVXw2d31gsIFtzKgnWKslGU6D;

	private readonly List<string> _R6F8IoYb9DitnbDrGVDuvkGs87c = new List<string>
	{
		"Nexus",
		"Vault",
		"Guild Hall",
		"Guild Hall 2",
		"Guild Hall 3",
		"Guild Hall 4",
		"Guild Hall 5",
		"Cloth Bazaar",
		"Nexus Explanation",
		"Vault Explanation",
		"Guild Explanation",
		"Daily Quest Room",
		"Daily Login Room",
		"Pet Yard",
		"Pet Yard 2",
		"Pet Yard 3",
		"Pet Yard 4",
		"Pet Yard 5"
	};

	private Dictionary<int, ushort> _upSS8MT1MDBXesl0chZtogspZ0B = new Dictionary<int, ushort>();

	public _rty1IcsHvwfrnvmDiqvQx9pilH(_PlferqYaObizDfc28C5jdKSLGq5 client)
	{
		_50w8wVuv8bL5nhKaR2EHxjrTamB = client;
		_VczQDeMDvlxm06HSYLiD8FbT7qj = false;
	}

	private void _MSYZNy9RqGhVTWQzakLfwAAmToG(int damage, string source = "Unknown")
	{
		_VczQDeMDvlxm06HSYLiD8FbT7qj = true;
		if (Settings.Default.AutoNexusShowInformation)
		{
			goto IL_0013;
		}
		goto IL_0092;
		IL_0092:
		Program._et8c2Heqb7KWtXL1gFN1nBBGIVP("client", $"Autonexusing from {source}, {damage}");
		int num = -1787223940;
		goto IL_0018;
		IL_0018:
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xF4DB45ECu) % 7u)
			{
			case 2u:
				break;
			default:
				return;
			case 6u:
				num3 = _fEgmKLJBX4eDyOg6a5xshzKbnJN * 100 / _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT;
				num = (int)(num2 * 1235508773) ^ -233770313;
				continue;
			case 3u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB._xRCQ3Y8enVTevEwMAZe8WUmANbE(_9FdBRxYlILRHkGBLs3x2MgRM6());
				num = ((int)num2 * -1259991153) ^ 0x65D59ADB;
				continue;
			case 1u:
				goto IL_0092;
			case 0u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB.sendChatNotification("AutoNexus", $"AutoNexused at {num3}% HP\nSource: {damage} {source}");
				num = ((int)num2 * -1230663376) ^ -2096333964;
				continue;
			case 5u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB._WEI99xvr4YqzD1PAnL2WmiBhWKJ((_7ajM1beVeTpzgibjLSn3it6YeYb)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.ESCAPE));
				num = (int)(num2 * 1100234449) ^ -370973563;
				continue;
			case 4u:
				return;
			}
			break;
		}
		goto IL_0013;
		IL_0013:
		num = -651184564;
		goto IL_0018;
	}

	private ReconnectPacket _9FdBRxYlILRHkGBLs3x2MgRM6()
	{
		ReconnectPacket reconnectPacket = (ReconnectPacket)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.RECONNECT);
		while (true)
		{
			int num = 547239233;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B31C270u) % 6u)
				{
				case 4u:
					break;
				case 3u:
					reconnectPacket._Hostname = "";
					num = (int)(num2 * 1822887361) ^ -274095309;
					continue;
				case 0u:
					reconnectPacket._Port = 2050;
					num = (int)((num2 * 655763433) ^ 0xA1A2183);
					continue;
				case 1u:
					reconnectPacket._WL2DOBxBuX9DARzf2KPoaJbgZiCb = "Nexus";
					num = (int)(num2 * 1254907141) ^ -815976612;
					continue;
				case 5u:
					reconnectPacket._Key = new byte[0];
					reconnectPacket._KeyTime = 0;
					num = (int)(num2 * 346497635) ^ -154901215;
					continue;
				default:
					reconnectPacket._GameId = -2;
					reconnectPacket._IsFromArena = false;
					return reconnectPacket;
				}
				break;
			}
		}
	}

	public void _DT5vfLbxw23gMixKpQ7yxEiQkEe(MapInfoPacket mapInfo)
	{
		_oV73NEwk247WZa6wM3sxIJwPEei = _R6F8IoYb9DitnbDrGVDuvkGs87c.Contains(mapInfo._MapName);
		while (true)
		{
			int num = 864686165;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x38C61DBFu) % 6u)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
					_Rjfm4PW3aMRNwsporG8wkl5wG5G.Clear();
					num = (int)(num2 * 596091586) ^ -1364415193;
					continue;
				case 0u:
					_fEgmKLJBX4eDyOg6a5xshzKbnJN = 100;
					num = ((int)num2 * -1413567605) ^ -1203043938;
					continue;
				case 5u:
					_bW2bcXGC7ddy4Byg043DK6aTDBaA = 100;
					_upSS8MT1MDBXesl0chZtogspZ0B.Clear();
					num = ((int)num2 * -1321965870) ^ 0x329C1D34;
					continue;
				case 4u:
					_GwYvhv88QJIDA9V6ds6bsTq5fCC = mapInfo._MapName == "Ocean Trench";
					num = ((int)num2 * -1665428974) ^ -1474218795;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void _cF9xoeWl31WrMWsesvaCUCXzbjb(_bmL6TDB9IBBbgxmfDQA1E9PL1ZM death)
	{
		Program.LogNetworkError("client", $"We died at {_fEgmKLJBX4eDyOg6a5xshzKbnJN} health, when nexusing at {Settings.Default.AutoNexusPercentageThreshold}% ({_wpv3L2x9SVwVG8oTXkB9xlrWfYf} hp)! {death}");
	}

	public void _BDXhTDiNPztbD7xb5Gi0tEvg8yG(UpdatePacket update)
	{
		//Discarded unreachable code: IL_0043
		_kWgc6McpJEKeBQJy34XFIJ43khcA[] lakUpSXZB1zdJcCECL20tl6SVrT = update._lakUpSXZB1zdJcCECL20tl6SVrT;
		int num = 0;
		_kWgc6McpJEKeBQJy34XFIJ43khcA kWgc6McpJEKeBQJy34XFIJ43khcA = default(_kWgc6McpJEKeBQJy34XFIJ43khcA);
		while (true)
		{
			int num2 = -945457398;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0xE3095B4Bu) % 8u)
				{
				case 2u:
					break;
				default:
					return;
				case 6u:
					return;
				case 7u:
				{
					kWgc6McpJEKeBQJy34XFIJ43khcA = lakUpSXZB1zdJcCECL20tl6SVrT[num];
					int num5;
					if (kWgc6McpJEKeBQJy34XFIJ43khcA._gVz37u8P9es5e8QAguAJW13BAYh._fn2CRnBpjyTWHR9K8SU4iOwhDtK != _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC)
					{
						num2 = -820964269;
						num5 = num2;
					}
					else
					{
						num2 = -840404617;
						num5 = num2;
					}
					continue;
				}
				case 0u:
					num++;
					num2 = -1325262464;
					continue;
				case 4u:
					_svydDteItTikqFWEdfihYLPjcdD(kWgc6McpJEKeBQJy34XFIJ43khcA._gVz37u8P9es5e8QAguAJW13BAYh, fromUpdate: true);
					num2 = (int)((num3 * 816166144) ^ 0x7D17649D);
					continue;
				case 3u:
				{
					int num4;
					if (num >= lakUpSXZB1zdJcCECL20tl6SVrT.Length)
					{
						num2 = -1512276074;
						num4 = num2;
					}
					else
					{
						num2 = -1099487028;
						num4 = num2;
					}
					continue;
				}
				case 1u:
					num2 = (int)((num3 * 1320661384) ^ 0x47856A08);
					continue;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void _emTnZmGyChlXH4IDm60126G1Snf(UpdatePacket update)
	{
		_kWgc6McpJEKeBQJy34XFIJ43khcA[] lakUpSXZB1zdJcCECL20tl6SVrT = update._lakUpSXZB1zdJcCECL20tl6SVrT;
		int num3 = default(int);
		_kWgc6McpJEKeBQJy34XFIJ43khcA kWgc6McpJEKeBQJy34XFIJ43khcA = default(_kWgc6McpJEKeBQJy34XFIJ43khcA);
		while (true)
		{
			int num = 361955118;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4C4C7906u) % 11u)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -1875450065) ^ 0x1EB22BCB;
					continue;
				case 4u:
				{
					int num7;
					if (!_upSS8MT1MDBXesl0chZtogspZ0B.ContainsKey(kWgc6McpJEKeBQJy34XFIJ43khcA._gVz37u8P9es5e8QAguAJW13BAYh._fn2CRnBpjyTWHR9K8SU4iOwhDtK))
					{
						num = 4652208;
						num7 = num;
					}
					else
					{
						num = 1958660664;
						num7 = num;
					}
					continue;
				}
				case 9u:
					num = ((int)num2 * -2035521373) ^ 0x31402DBA;
					continue;
				case 6u:
					_upSS8MT1MDBXesl0chZtogspZ0B.Add(kWgc6McpJEKeBQJy34XFIJ43khcA._gVz37u8P9es5e8QAguAJW13BAYh._fn2CRnBpjyTWHR9K8SU4iOwhDtK, kWgc6McpJEKeBQJy34XFIJ43khcA._y2nCjecGeYsmqDEzaplcuBvYtN7);
					num = ((int)num2 * -351150587) ^ -75449674;
					continue;
				case 1u:
				{
					int num6;
					if (num3 < lakUpSXZB1zdJcCECL20tl6SVrT.Length)
					{
						num = 2020393305;
						num6 = num;
					}
					else
					{
						num = 1932475294;
						num6 = num;
					}
					continue;
				}
				case 2u:
					_KQrCDNrUysA4qKaWspdpLvKfrZf(kWgc6McpJEKeBQJy34XFIJ43khcA._gVz37u8P9es5e8QAguAJW13BAYh, fromUpdate: true);
					num = ((int)num2 * -806065401) ^ -2062763528;
					continue;
				case 7u:
					kWgc6McpJEKeBQJy34XFIJ43khcA = lakUpSXZB1zdJcCECL20tl6SVrT[num3];
					num = 1167391357;
					continue;
				case 8u:
				{
					int num4;
					int num5;
					if (kWgc6McpJEKeBQJy34XFIJ43khcA._gVz37u8P9es5e8QAguAJW13BAYh._fn2CRnBpjyTWHR9K8SU4iOwhDtK == _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC)
					{
						num4 = -168142646;
						num5 = num4;
					}
					else
					{
						num4 = -396829012;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 1129164512);
					continue;
				}
				case 10u:
					num3++;
					num = 1582869093;
					continue;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public void _MFLBEFZIoAzGuS9ckjivIcS84uOA(NewTickPacket newTick)
	{
		//Discarded unreachable code: IL_009e
		using List<_AunOm2zlKr0KANkRBzogPcg538K>.Enumerator enumerator = newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.GetEnumerator();
		_AunOm2zlKr0KANkRBzogPcg538K current = default(_AunOm2zlKr0KANkRBzogPcg538K);
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = -1664739202;
				num2 = num;
			}
			else
			{
				num = -1473411137;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xEE4AD3F6u) % 6u)
				{
				case 5u:
					num = -1473411137;
					continue;
				default:
					return;
				case 3u:
				{
					current = enumerator.Current;
					int num4;
					if (current._fn2CRnBpjyTWHR9K8SU4iOwhDtK != _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC)
					{
						num = -604683750;
						num4 = num;
					}
					else
					{
						num = -921822070;
						num4 = num;
					}
					continue;
				}
				case 0u:
					_svydDteItTikqFWEdfihYLPjcdD(current);
					num = ((int)num3 * -5834184) ^ 0x39220FEB;
					continue;
				case 4u:
					break;
				case 1u:
					return;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void _kcBjTzBYfTPCpKNctSQjw45y1mb(NewTickPacket newTick)
	{
		//Discarded unreachable code: IL_0052
		bool flag = false;
		using (List<_AunOm2zlKr0KANkRBzogPcg538K>.Enumerator enumerator = newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.GetEnumerator())
		{
			_AunOm2zlKr0KANkRBzogPcg538K current = default(_AunOm2zlKr0KANkRBzogPcg538K);
			while (true)
			{
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = -1033568543;
					num2 = num;
				}
				else
				{
					num = -122538577;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xD2684510u) % 8u)
					{
					case 4u:
						num = -1033568543;
						continue;
					default:
						goto end_IL_000e;
					case 2u:
						goto end_IL_000e;
					case 0u:
						_KQrCDNrUysA4qKaWspdpLvKfrZf(current);
						num = ((int)num3 * -1342377299) ^ 0x3C272623;
						continue;
					case 5u:
					{
						int num4;
						int num5;
						if (current._fn2CRnBpjyTWHR9K8SU4iOwhDtK != _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC)
						{
							num4 = -28756743;
							num5 = num4;
						}
						else
						{
							num4 = -1431498921;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -754315789);
						continue;
					}
					case 6u:
						break;
					case 3u:
						flag = true;
						num = ((int)num3 * -161482842) ^ -389339408;
						continue;
					case 1u:
						current = enumerator.Current;
						num = -733990307;
						continue;
					case 7u:
						goto end_IL_000e;
					}
					break;
				}
			}
			end_IL_000e:;
		}
		if (!flag)
		{
			goto IL_0104;
		}
		goto IL_0266;
		IL_0104:
		int num6 = -1713243432;
		goto IL_0109;
		IL_0266:
		int num7;
		if (_YoiVXw2d31gsIFtzKgnWKslGU6D != 0)
		{
			num6 = -530599204;
			num7 = num6;
		}
		else
		{
			num6 = -541597202;
			num7 = num6;
		}
		goto IL_0109;
		IL_0109:
		_AunOm2zlKr0KANkRBzogPcg538K aunOm2zlKr0KANkRBzogPcg538K = default(_AunOm2zlKr0KANkRBzogPcg538K);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num6 ^ 0xD2684510u) % 15u)
			{
			case 10u:
				break;
			default:
				return;
			case 3u:
			{
				int num12;
				int num13;
				if (!Settings.Default.DisableSystemMessages)
				{
					num12 = -301962137;
					num13 = num12;
				}
				else
				{
					num12 = -1444280877;
					num13 = num12;
				}
				num6 = num12 ^ ((int)num3 * -1721737697);
				continue;
			}
			case 2u:
				_fEgmKLJBX4eDyOg6a5xshzKbnJN = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT;
				num6 = (int)(num3 * 1174859430) ^ -683063185;
				continue;
			case 0u:
				_YoiVXw2d31gsIFtzKgnWKslGU6D = 0;
				num6 = -541597202;
				continue;
			case 11u:
				aunOm2zlKr0KANkRBzogPcg538K._Stats = new List<StatData>();
				num6 = (int)((num3 * 1077544489) ^ 0x74CF5B56);
				continue;
			case 13u:
				aunOm2zlKr0KANkRBzogPcg538K = new _AunOm2zlKr0KANkRBzogPcg538K();
				aunOm2zlKr0KANkRBzogPcg538K._ObXrbtVZcdprxclR2Ggz9jKwlp = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._IlcbhoOIM3MRszn9mfn3IKjnXc0;
				num6 = ((int)num3 * -1708476795) ^ 0x67B651F5;
				continue;
			case 7u:
			{
				int num10;
				int num11;
				if (Settings.Default.AutoNexusReplaceFameWithHealth)
				{
					num10 = -864446738;
					num11 = num10;
				}
				else
				{
					num10 = -1670859900;
					num11 = num10;
				}
				num6 = num10 ^ (int)(num3 * 508593889);
				continue;
			}
			case 4u:
			{
				int num8;
				int num9;
				if (_fEgmKLJBX4eDyOg6a5xshzKbnJN > _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT)
				{
					num8 = -1566041661;
					num9 = num8;
				}
				else
				{
					num8 = -222612003;
					num9 = num8;
				}
				num6 = num8 ^ ((int)num3 * -1682168800);
				continue;
			}
			case 5u:
				goto IL_0266;
			case 1u:
				_fEgmKLJBX4eDyOg6a5xshzKbnJN += _YoiVXw2d31gsIFtzKgnWKslGU6D;
				num6 = (int)((num3 * 229356041) ^ 0x10EEFC6D);
				continue;
			case 14u:
				newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.Add(aunOm2zlKr0KANkRBzogPcg538K);
				num6 = (int)(num3 * 388627580) ^ -2131692329;
				continue;
			case 8u:
				_CN0aFF2oVUmBjLQeRGfPCrCKo42(aunOm2zlKr0KANkRBzogPcg538K._Stats);
				num6 = (int)((num3 * 1157689800) ^ 0x27BF26E9);
				continue;
			case 9u:
				_FX4vSy5JMHovi3Px83YbL5RUCVO();
				num6 = -906307187;
				continue;
			case 12u:
				aunOm2zlKr0KANkRBzogPcg538K._fn2CRnBpjyTWHR9K8SU4iOwhDtK = _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC;
				num6 = ((int)num3 * -748124581) ^ -1044902389;
				continue;
			case 6u:
				return;
			}
			break;
		}
		goto IL_0104;
	}

	private void _svydDteItTikqFWEdfihYLPjcdD(_AunOm2zlKr0KANkRBzogPcg538K status, bool fromUpdate = false)
	{
		//Discarded unreachable code: IL_0030
		if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC == null)
		{
			while (true)
			{
				uint num;
				switch ((num = 0x233494B3u ^ 0x7AA782B4u) % 3u)
				{
				case 0u:
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
		using List<StatData>.Enumerator enumerator = status._Stats.GetEnumerator();
		StatData current = default(StatData);
		while (true)
		{
			int num2;
			int num3;
			if (!enumerator.MoveNext())
			{
				num2 = 177736105;
				num3 = num2;
			}
			else
			{
				num2 = 1378888688;
				num3 = num2;
			}
			while (true)
			{
				uint num;
				switch ((num = (uint)num2 ^ 0x7AA782B4u) % 10u)
				{
				case 9u:
					num2 = 1378888688;
					continue;
				default:
					return;
				case 5u:
					_NFR83kf0QjqRt7cv1oeTT9iTqOB(current._StatValue);
					num2 = (int)(num * 1742484044) ^ -1936843506;
					continue;
				case 0u:
					_fEgmKLJBX4eDyOg6a5xshzKbnJN = current._StatValue;
					num2 = ((int)num * -723674994) ^ -169432259;
					continue;
				case 1u:
				{
					int num6;
					if (!StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType._3KsT0A9qDhV27lSaeWcw20rCLQr))
					{
						num2 = 1984618130;
						num6 = num2;
					}
					else
					{
						num2 = 1490786936;
						num6 = num2;
					}
					continue;
				}
				case 6u:
				{
					int num7;
					int num8;
					if (fromUpdate)
					{
						num7 = -1941030450;
						num8 = num7;
					}
					else
					{
						num7 = -204969490;
						num8 = num7;
					}
					num2 = num7 ^ ((int)num * -928868955);
					continue;
				}
				case 7u:
				{
					int num4;
					int num5;
					if (!StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType._JU2ga8NkSWxydVNRYruOZMxgSWP))
					{
						num4 = 443541502;
						num5 = num4;
					}
					else
					{
						num4 = 1412319395;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num * -1828626745);
					continue;
				}
				case 2u:
					_NFR83kf0QjqRt7cv1oeTT9iTqOB(current._StatValue);
					num2 = ((int)num * -1191793182) ^ -664455010;
					continue;
				case 8u:
					current = enumerator.Current;
					num2 = 1894723763;
					continue;
				case 4u:
					break;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void _KQrCDNrUysA4qKaWspdpLvKfrZf(_AunOm2zlKr0KANkRBzogPcg538K status, bool fromUpdate = false)
	{
		using (List<StatData>.Enumerator enumerator = status._Stats.GetEnumerator())
		{
			StatData current = default(StatData);
			while (true)
			{
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -153918451;
					num2 = num;
				}
				else
				{
					num = -1516797533;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xC1645696u) % 13u)
					{
					case 3u:
						num = -1516797533;
						continue;
					default:
						goto end_IL_000c;
					case 9u:
						current = enumerator.Current;
						num = -1821860784;
						continue;
					case 2u:
					{
						int num8;
						int num9;
						if (!StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType._JU2ga8NkSWxydVNRYruOZMxgSWP))
						{
							num8 = -1861300112;
							num9 = num8;
						}
						else
						{
							num8 = -1597780874;
							num9 = num8;
						}
						num = num8 ^ ((int)num3 * -1365408123);
						continue;
					}
					case 4u:
						_NFR83kf0QjqRt7cv1oeTT9iTqOB(current._StatValue);
						num = (int)(num3 * 574420723) ^ -1139144205;
						continue;
					case 1u:
					{
						int num6;
						if (StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType._HmqFDGwB69awhIJ5Ik12W8iBBYW))
						{
							num = -734862176;
							num6 = num;
						}
						else
						{
							num = -1207858461;
							num6 = num;
						}
						continue;
					}
					case 8u:
						_bW2bcXGC7ddy4Byg043DK6aTDBaA = current._StatValue;
						num = -1207858461;
						continue;
					case 12u:
						break;
					case 7u:
						_FX4vSy5JMHovi3Px83YbL5RUCVO();
						num = (int)((num3 * 497897257) ^ 0x7D84AD40);
						continue;
					case 5u:
					{
						int num7;
						if (StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType._3KsT0A9qDhV27lSaeWcw20rCLQr))
						{
							num = -389300300;
							num7 = num;
						}
						else
						{
							num = -997597554;
							num7 = num;
						}
						continue;
					}
					case 6u:
					{
						int num4;
						int num5;
						if (fromUpdate)
						{
							num4 = -1538984326;
							num5 = num4;
						}
						else
						{
							num4 = -1816921789;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1993967354);
						continue;
					}
					case 10u:
						_fEgmKLJBX4eDyOg6a5xshzKbnJN = current._StatValue;
						num = ((int)num3 * -1545890364) ^ 0x4B012C9A;
						continue;
					case 11u:
						_nSbn5BiGHvwfVPOliLfIaQJ4jcb = (current._StatValue & 0x20000000) == 536870912;
						num = ((int)num3 * -314902170) ^ -1977873049;
						continue;
					case 0u:
						goto end_IL_000c;
					}
					break;
				}
			}
			end_IL_000c:;
		}
		if (Settings.Default.DisableSystemMessages)
		{
			return;
		}
		while (true)
		{
			int num10 = -978580839;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num10 ^ 0xC1645696u) % 5u)
				{
				case 4u:
					break;
				default:
					return;
				case 1u:
				{
					int num13;
					int num14;
					if (Settings.Default.AutoNexusReplaceFameWithHealth)
					{
						num13 = -476986844;
						num14 = num13;
					}
					else
					{
						num13 = -1428481246;
						num14 = num13;
					}
					num10 = num13 ^ ((int)num3 * -1961057665);
					continue;
				}
				case 3u:
					_CN0aFF2oVUmBjLQeRGfPCrCKo42(status._Stats);
					num10 = ((int)num3 * -16985967) ^ -1888853496;
					continue;
				case 0u:
				{
					int num11;
					int num12;
					if (fromUpdate)
					{
						num11 = 1245416227;
						num12 = num11;
					}
					else
					{
						num11 = 1874667469;
						num12 = num11;
					}
					num10 = num11 ^ ((int)num3 * -736585264);
					continue;
				}
				case 2u:
					return;
				}
				break;
			}
		}
	}

	private void _CN0aFF2oVUmBjLQeRGfPCrCKo42(List<StatData> data)
	{
		data.Add(new StatData
		{
			_StatType = StatType._muvPbV4fjAmqZSu0AmebD3eGFTl,
			_StatValue = _fEgmKLJBX4eDyOg6a5xshzKbnJN,
			_StringStatValue = string.Empty
		});
		while (true)
		{
			int num = 396365404;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x557D1069u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_004f;
				case 2u:
					return;
				}
				break;
				IL_004f:
				data.Add(new StatData
				{
					_StatType = StatType._4J5y5YxISDbB6r3IyRI7Y4jQt0K,
					_StatValue = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT,
					_StringStatValue = string.Empty
				});
				num = ((int)num2 * -175301170) ^ 0x4B81D99E;
			}
		}
	}

	public void _tX4Fl2mBYL4XNqNEIW0OPnopM9i(_WCTbeWogZHoPyDnxles484v2oK move)
	{
		int num = _50w8wVuv8bL5nhKaR2EHxjrTamB._ThXZKkD7eTKsvHaetPD5l7lo3ld;
		while (true)
		{
			int num2 = 477826601;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x7404F8D8u) % 7u)
				{
				case 6u:
					break;
				case 2u:
					_NVu1TmQ2nvgEoFJidtvcpeWuIxP(move._IBSqBdwNTiXSzhZbDhEFMC0Gc51, num, 0, move._r0866iEhjgniNmmLz9ygFmfaWPA);
					num2 = (int)((num3 * 1146511994) ^ 0x7C5B9F14);
					continue;
				case 4u:
					_tnzATORRz69PD9QNslfqhszFO2M = num;
					num2 = ((int)num3 * -1648279605) ^ -1829587954;
					continue;
				case 0u:
					_tnzATORRz69PD9QNslfqhszFO2M = num;
					num2 = (int)((num3 * 1871012961) ^ 0x47C05A28);
					continue;
				case 3u:
					_NVu1TmQ2nvgEoFJidtvcpeWuIxP(move._IBSqBdwNTiXSzhZbDhEFMC0Gc51, num, num - _tnzATORRz69PD9QNslfqhszFO2M, move._r0866iEhjgniNmmLz9ygFmfaWPA);
					num2 = 777135326;
					continue;
				case 1u:
				{
					int num4;
					int num5;
					if (move._D4Xpe2utS1cwv8fGTeXUOkTlvMi != 0)
					{
						num4 = -1691554578;
						num5 = num4;
					}
					else
					{
						num4 = -287412812;
						num5 = num4;
					}
					num2 = num4 ^ (int)(num3 * 974849497);
					continue;
				}
				default:
					_rZfAtVaDv7a30Cx46re9BwDcDp3 = move._r0866iEhjgniNmmLz9ygFmfaWPA;
					return;
				}
				break;
			}
		}
	}

	public void _clpx4Sn1ScoFsLzGLg7gEAbKG8(_ax4JtQ0EqqnZh9Ml8sG7hZIwpN notification)
	{
		//Discarded unreachable code: IL_0093, IL_00e2, IL_0141, IL_01a3, IL_01f2
		if (notification._fn2CRnBpjyTWHR9K8SU4iOwhDtK != _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC)
		{
			goto IL_0016;
		}
		goto IL_01cb;
		IL_01cb:
		int num;
		int num2;
		if (notification._1xJnApWExAEbirK3iXPXNZCyR4n.Contains("server.plus_symbol"))
		{
			num = 530477713;
			num2 = num;
		}
		else
		{
			num = 1885591454;
			num2 = num;
		}
		goto IL_001b;
		IL_001b:
		string[] array2 = default(string[]);
		string[] array = default(string[]);
		int result = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x14AFF11Cu) % 18u)
			{
			case 6u:
				break;
			default:
				return;
			case 7u:
				Program._et8c2Heqb7KWtXL1gFN1nBBGIVP("client", "Malformed notification message: " + notification._1xJnApWExAEbirK3iXPXNZCyR4n);
				return;
			case 15u:
				array2 = array[1].Split(new string[1]
				{
					"\"}}"
				}, StringSplitOptions.RemoveEmptyEntries);
				num = 1829585538;
				continue;
			case 13u:
				Program._et8c2Heqb7KWtXL1gFN1nBBGIVP("client", "Malformed notification message: " + notification._1xJnApWExAEbirK3iXPXNZCyR4n);
				return;
			case 12u:
				goto IL_00f4;
			case 3u:
				Program._et8c2Heqb7KWtXL1gFN1nBBGIVP("client", "Malformed notification message: " + notification._1xJnApWExAEbirK3iXPXNZCyR4n);
				num = (int)(num3 * 1622327762) ^ -882269683;
				continue;
			case 9u:
				return;
			case 5u:
				array = notification._1xJnApWExAEbirK3iXPXNZCyR4n.Split(new string[1]
				{
					"\"amount\":\""
				}, StringSplitOptions.RemoveEmptyEntries);
				num = ((int)num3 * -1381650576) ^ -2125343176;
				continue;
			case 14u:
			{
				int num6;
				int num7;
				if (array2.Length != 1)
				{
					num6 = 684825189;
					num7 = num6;
				}
				else
				{
					num6 = 1887280022;
					num7 = num6;
				}
				num = num6 ^ (int)(num3 * 9536408);
				continue;
			}
			case 17u:
				return;
			case 0u:
				_KhWciVZacyPe2Oeb7ecrgum6Nn0A(result, "Notif Heal");
				num = 1885591454;
				continue;
			case 1u:
				goto IL_01cb;
			case 2u:
				return;
			case 11u:
			{
				int num8;
				int num9;
				if (notification._JEsT6uIdK1eySUKAfntb2FPG6xS == 65280)
				{
					num8 = -755049544;
					num9 = num8;
				}
				else
				{
					num8 = -592367369;
					num9 = num8;
				}
				num = num8 ^ (int)(num3 * 1043803725);
				continue;
			}
			case 4u:
				_co7DtC49zFOcncuiHywaZTrYDCK(result);
				num = ((int)num3 * -145903614) ^ 0x5482D7C2;
				continue;
			case 8u:
			{
				int num4;
				int num5;
				if (array.Length == 2)
				{
					num4 = -286650159;
					num5 = num4;
				}
				else
				{
					num4 = -300350681;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -1173947350);
				continue;
			}
			case 16u:
				goto IL_0268;
			case 10u:
				return;
			}
			break;
			IL_0268:
			int num10;
			if (result + _fEgmKLJBX4eDyOg6a5xshzKbnJN > _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT)
			{
				num = 530151988;
				num10 = num;
			}
			else
			{
				num = 979105308;
				num10 = num;
			}
			continue;
			IL_00f4:
			int num11;
			if (int.TryParse(array2[0], out result))
			{
				num = 1965054996;
				num11 = num;
			}
			else
			{
				num = 1558797237;
				num11 = num;
			}
		}
		goto IL_0016;
		IL_0016:
		num = 1270011247;
		goto IL_001b;
	}

	public void _G32brJa4jmWaZroFncLDOsAha5VA(_FJ4Ncdgp30LvdfcfBFMzemYCCeT aoe)
	{
		_Rjfm4PW3aMRNwsporG8wkl5wG5G.Add(new _Jb0feCILTkEl6pcg2T1V15k3pU9(aoe));
	}

	public void _f8Cv4bMnfjjwRWfQwllvwFZDPuI(_Gya6cTkZfLW7T3Mt937EMw3XUvC aoeAck)
	{
		if (_VczQDeMDvlxm06HSYLiD8FbT7qj)
		{
			while (true)
			{
				int num = -747567048;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC572F5B8u) % 3u)
					{
					case 2u:
						break;
					case 1u:
						aoeAck._Send = false;
						num = (int)(num2 * 910424067) ^ -813678603;
						continue;
					default:
						goto IL_0042;
					}
					break;
				}
			}
		}
		goto IL_0042;
		IL_0042:
		_rZfAtVaDv7a30Cx46re9BwDcDp3 = aoeAck._ObXrbtVZcdprxclR2Ggz9jKwlp;
		using (List<_Jb0feCILTkEl6pcg2T1V15k3pU9>.Enumerator enumerator = _Rjfm4PW3aMRNwsporG8wkl5wG5G.GetEnumerator())
		{
			ObjectStructure objectStructure = default(ObjectStructure);
			_Jb0feCILTkEl6pcg2T1V15k3pU9 current = default(_Jb0feCILTkEl6pcg2T1V15k3pU9);
			string text = default(string);
			while (true)
			{
				int num3;
				int num4;
				if (enumerator.MoveNext())
				{
					num3 = -300480859;
					num4 = num3;
				}
				else
				{
					num3 = -1471492492;
					num4 = num3;
				}
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num3 ^ 0xC572F5B8u) % 10u)
					{
					case 2u:
						num3 = -300480859;
						continue;
					default:
						goto end_IL_005a;
					case 0u:
						objectStructure = ResourceDownloader._VPArsrlUa0uEsW6OxAYV9WHJAMK._EOUVvVncv0meCCDQkGXOyUOLU5F(current._Rgo6h5q8HOGdwEcalhyNY8ouOAE);
						num3 = ((int)num2 * -1758931004) ^ -654394973;
						continue;
					case 4u:
						text = objectStructure.Name;
						num3 = (int)((num2 * 1187816427) ^ 0x3F324243);
						continue;
					case 7u:
					{
						int num7;
						int num8;
						if (objectStructure != null)
						{
							num7 = -650612356;
							num8 = num7;
						}
						else
						{
							num7 = -1791994605;
							num8 = num7;
						}
						num3 = num7 ^ (int)(num2 * 1454639790);
						continue;
					}
					case 6u:
						text = $"(Type: {current._Rgo6h5q8HOGdwEcalhyNY8ouOAE})";
						num3 = (int)(num2 * 1291712497) ^ -1495991196;
						continue;
					case 1u:
						current = enumerator.Current;
						num3 = -572494489;
						continue;
					case 3u:
						break;
					case 5u:
					{
						int num5;
						int num6;
						if (_rZfAtVaDv7a30Cx46re9BwDcDp3._zFtZUeGjkS0Ei8GwlFzZbAokBAQ(current._hZZqGJ97TiaLFTbiTFhvTTSGkIb) >= (double)current._I9LOulXQ6dWoDQOn1L5GkchnJUC)
						{
							num5 = -169044016;
							num6 = num5;
						}
						else
						{
							num5 = -1743574789;
							num6 = num5;
						}
						num3 = num5 ^ (int)(num2 * 267556609);
						continue;
					}
					case 9u:
						_CLRtscLVGwgyeHHILRfayjUB8iu(_EKcpayCwlxsQrEGbJ0bBOTfv5bJ(current._C3mvDTxTLKOCwcaeO4BKeVV1ydo, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._DKXdZpvHo34S5ZnQVXvzkRCVbXr, current._l0mdLwT0Lqvn0oV26TZ8wa7mjTf), "AoE damage (" + text + ")");
						num3 = -782191089;
						continue;
					case 8u:
						goto end_IL_005a;
					}
					break;
				}
			}
			end_IL_005a:;
		}
		_Rjfm4PW3aMRNwsporG8wkl5wG5G.Clear();
	}

	public void _W4ULDsCzGjGES6SCKBD4lp5hvRd(_VhiC6MRkf9RQ9nQp4K78vup3R4n groundDamage)
	{
		//Discarded unreachable code: IL_00c4
		if (_VczQDeMDvlxm06HSYLiD8FbT7qj)
		{
			goto IL_000b;
		}
		goto IL_0102;
		IL_0102:
		_TmFas5PEXYMVmPQTpu3tg3XuoTo tmFas5PEXYMVmPQTpu3tg3XuoTo = _50w8wVuv8bL5nhKaR2EHxjrTamB._psKBaUvFAGf2xFOCwHRyUMbhDXG(groundDamage._ObXrbtVZcdprxclR2Ggz9jKwlp);
		int num = 496896558;
		goto IL_0010;
		IL_0010:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x72423B7Au) % 8u)
			{
			case 3u:
				break;
			default:
				return;
			case 4u:
			{
				int num3;
				int num4;
				if (tmFas5PEXYMVmPQTpu3tg3XuoTo != null)
				{
					num3 = -560179821;
					num4 = num3;
				}
				else
				{
					num3 = -1719117158;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1743195706);
				continue;
			}
			case 1u:
				_CLRtscLVGwgyeHHILRfayjUB8iu(tmFas5PEXYMVmPQTpu3tg3XuoTo._DhTaSoVobkg7U0jZ45RnYd4BIfr.MaxDamage, "Ground damage (" + tmFas5PEXYMVmPQTpu3tg3XuoTo._DhTaSoVobkg7U0jZ45RnYd4BIfr.Name + ")");
				num = 616983127;
				continue;
			case 6u:
				groundDamage._Send = false;
				num = ((int)num2 * -135761828) ^ 0x97C669D;
				continue;
			case 2u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB.sendChatNotification("AutoNexus", "Took ground damage from an unknown source, autonexus may not be fully functional!");
				return;
			case 0u:
				Program._et8c2Heqb7KWtXL1gFN1nBBGIVP("client", $"Null tile at {groundDamage._ObXrbtVZcdprxclR2Ggz9jKwlp} when taking GroundDamage");
				num = ((int)num2 * -638397555) ^ -694679016;
				continue;
			case 7u:
				goto IL_0102;
			case 5u:
				return;
			}
			break;
		}
		goto IL_000b;
		IL_000b:
		num = 816422668;
		goto IL_0010;
	}

	public void _gHqtNcWyCVVFxHdmeuer3tJSw4p(_gPMJGxrLGVpRbk6vQWa2ycqHSqh playerHit)
	{
		//Discarded unreachable code: IL_025f
		if (_VczQDeMDvlxm06HSYLiD8FbT7qj)
		{
			goto IL_000b;
		}
		goto IL_00b6;
		IL_00b6:
		string text = playerHit._fn2CRnBpjyTWHR9K8SU4iOwhDtK.ToString();
		int num = -2090713519;
		goto IL_0010;
		IL_0010:
		int amount = default(int);
		bool armorPierce = default(bool);
		Projectile projectile = default(Projectile);
		Dictionary<int, Projectile> dictionary = default(Dictionary<int, Projectile>);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xBF372AB1u) % 16u)
			{
			case 2u:
				break;
			default:
				return;
			case 15u:
				_CLRtscLVGwgyeHHILRfayjUB8iu(amount, "Projectile damage (" + text + ")");
				num = (int)(num2 * 1660246026) ^ -1923033569;
				continue;
			case 12u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB.sendChatNotification("AutoNexus", "Took projectile damage from an unknown source, autonexus may not be fully functional!");
				num = (int)((num2 * 142707396) ^ 0x367BC840);
				continue;
			case 3u:
				goto IL_00b6;
			case 13u:
				text = ResourceDownloader._VPArsrlUa0uEsW6OxAYV9WHJAMK._EOUVvVncv0meCCDQkGXOyUOLU5F(_upSS8MT1MDBXesl0chZtogspZ0B[playerHit._fn2CRnBpjyTWHR9K8SU4iOwhDtK]).Name;
				num = (int)(num2 * 1724429531) ^ -248865415;
				continue;
			case 9u:
				armorPierce = Projectile.IsPiercing(_upSS8MT1MDBXesl0chZtogspZ0B[projectile.OwnerId], projectile.ProjectileType);
				num = (int)(num2 * 1524061988) ^ -682002978;
				continue;
			case 11u:
				amount = _EKcpayCwlxsQrEGbJ0bBOTfv5bJ((ushort)projectile.Damage, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._DKXdZpvHo34S5ZnQVXvzkRCVbXr, armorPierce);
				num = ((int)num2 * -23095189) ^ 0x5CC839F7;
				continue;
			case 4u:
				dictionary = _50w8wVuv8bL5nhKaR2EHxjrTamB._N5GofMpQbwbVNiYLmSHHRmpmKhg[playerHit._fn2CRnBpjyTWHR9K8SU4iOwhDtK];
				num = -884226745;
				continue;
			case 6u:
			{
				int num5;
				int num6;
				if (dictionary.ContainsKey(playerHit._isVjytSCPjaQXfnhSgmbShfAEYC))
				{
					num5 = -1493692667;
					num6 = num5;
				}
				else
				{
					num5 = -1524077725;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -1671464257);
				continue;
			}
			case 0u:
			{
				int num3;
				int num4;
				if (_upSS8MT1MDBXesl0chZtogspZ0B.ContainsKey(playerHit._fn2CRnBpjyTWHR9K8SU4iOwhDtK))
				{
					num3 = -112583380;
					num4 = num3;
				}
				else
				{
					num3 = -2072134346;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1898771242);
				continue;
			}
			case 14u:
				projectile = dictionary[playerHit._isVjytSCPjaQXfnhSgmbShfAEYC];
				num = ((int)num2 * -1174923050) ^ -327433572;
				continue;
			case 7u:
				goto IL_01ff;
			case 10u:
				Program._et8c2Heqb7KWtXL1gFN1nBBGIVP("client", $"We got hit by a shot that is not logged, owner: {text}, bid: {playerHit._isVjytSCPjaQXfnhSgmbShfAEYC}");
				num = (int)((num2 * 1188752503) ^ 0x49677A7B);
				continue;
			case 1u:
				return;
			case 5u:
				playerHit._Send = false;
				num = (int)(num2 * 1123084807) ^ -759794991;
				continue;
			case 8u:
				return;
			}
			break;
			IL_01ff:
			int num7;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._N5GofMpQbwbVNiYLmSHHRmpmKhg.ContainsKey(playerHit._fn2CRnBpjyTWHR9K8SU4iOwhDtK))
			{
				num = -782701077;
				num7 = num;
			}
			else
			{
				num = -1631829915;
				num7 = num;
			}
		}
		goto IL_000b;
		IL_000b:
		num = -1153561052;
		goto IL_0010;
	}

	private int _EKcpayCwlxsQrEGbJ0bBOTfv5bJ(ushort originalDamage, int playerDefense, bool armorPierce)
	{
		int num = playerDefense;
		if (!armorPierce)
		{
			goto IL_0008;
		}
		goto IL_021c;
		IL_021c:
		num = 0;
		int num2 = -1406930131;
		goto IL_000d;
		IL_000d:
		double num4 = default(double);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x9BB964FBu) % 16u)
			{
			case 0u:
				break;
			case 5u:
			{
				int num7;
				int num8;
				if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._aSSHSWAWCnEmRnN8M0J6kmLwnIn())
				{
					num7 = 1172720174;
					num8 = num7;
				}
				else
				{
					num7 = 1435213639;
					num8 = num7;
				}
				num2 = num7 ^ (int)(num3 * 698628219);
				continue;
			}
			case 10u:
				num4 = (int)(num4 * 0.9);
				num2 = (int)(num3 * 380538691) ^ -745310421;
				continue;
			case 1u:
			{
				double val = (double)(int)originalDamage * 0.1;
				double val2 = originalDamage - num;
				num4 = (int)Math.Max(val, val2);
				num2 = -1994226625;
				continue;
			}
			case 14u:
				goto IL_00d1;
			case 9u:
				num4 = (int)(num4 * 1.25);
				num2 = ((int)num3 * -281845326) ^ -1111820918;
				continue;
			case 13u:
				num4 = 0.0;
				num2 = ((int)num3 * -465369558) ^ 0x38F8D8DE;
				continue;
			case 12u:
				goto IL_0133;
			case 7u:
				goto IL_0159;
			case 6u:
				num2 = (int)((num3 * 23849670) ^ 0x1367DD63);
				continue;
			case 4u:
			{
				int num5;
				int num6;
				if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._9zLynim4HlmFvQv3AqAl2vIblhc())
				{
					num5 = 2129642284;
					num6 = num5;
				}
				else
				{
					num5 = 1853817062;
					num6 = num5;
				}
				num2 = num5 ^ ((int)num3 * -1192472812);
				continue;
			}
			case 8u:
				num -= 20;
				num2 = (int)((num3 * 200403157) ^ 0x4821B822);
				continue;
			case 15u:
				num = (int)((double)num * 1.5);
				num2 = ((int)num3 * -2146487223) ^ 0x18FF49A0;
				continue;
			case 11u:
				goto IL_01f6;
			case 2u:
				goto IL_021c;
			default:
				return (int)num4;
			}
			break;
			IL_01f6:
			int num9;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._tkfj3gYuI6ubFC5MTh0aCabHAgTA())
			{
				num2 = -276925452;
				num9 = num2;
			}
			else
			{
				num2 = -1884629273;
				num9 = num2;
			}
			continue;
			IL_0133:
			int num10;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._uRofpGAWTai1pFW78nU1atwjVxo())
			{
				num2 = -1346622045;
				num10 = num2;
			}
			else
			{
				num2 = -1366000102;
				num10 = num2;
			}
			continue;
			IL_00d1:
			int num11;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FtmAQausrRLeBhCy0y3hoFCWisb())
			{
				num2 = -315423902;
				num11 = num2;
			}
			else
			{
				num2 = -364710680;
				num11 = num2;
			}
			continue;
			IL_0159:
			int num12;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._quNJ1T7LQlmCLS88KJxY2t10VQA())
			{
				num2 = -245267439;
				num12 = num2;
			}
			else
			{
				num2 = -991763435;
				num12 = num2;
			}
		}
		goto IL_0008;
		IL_0008:
		num2 = -975253154;
		goto IL_000d;
	}

	private void _NVu1TmQ2nvgEoFJidtvcpeWuIxP(int moveTime, int time, int diff, WorldPosData whereabouts)
	{
		//Discarded unreachable code: IL_007c
		int fEgmKLJBX4eDyOg6a5xshzKbnJN = _fEgmKLJBX4eDyOg6a5xshzKbnJN;
		while (true)
		{
			int num = -589665214;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFA444B02u) % 5u)
				{
				case 0u:
					break;
				case 4u:
				{
					_MZEpjczfvKiLuBC5dtTeu4eiUrI(diff);
					int num3;
					int num4;
					if (!_zPOUViNkt7ARkkvn46oJQqXIDxd())
					{
						num3 = 1206071113;
						num4 = num3;
					}
					else
					{
						num3 = 1065657158;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 229024569);
					continue;
				}
				case 2u:
					_MSYZNy9RqGhVTWQzakLfwAAmToG(fEgmKLJBX4eDyOg6a5xshzKbnJN - _fEgmKLJBX4eDyOg6a5xshzKbnJN, "(Health drain)");
					num = ((int)num2 * -2059510671) ^ 0x605BC353;
					continue;
				case 3u:
					return;
				default:
					_AuJ9LotJSsltyge55rNhCJwiERG(moveTime, time, whereabouts);
					return;
				}
				break;
			}
		}
	}

	private void _AuJ9LotJSsltyge55rNhCJwiERG(int moveTime, int time, WorldPosData whereabouts)
	{
		//Discarded unreachable code: IL_0125, IL_0153, IL_0166, IL_0199
		if (_oV73NEwk247WZa6wM3sxIJwPEei)
		{
			goto IL_000b;
		}
		goto IL_0178;
		IL_0178:
		int num;
		int num2;
		if (Settings.Default.EnableAutoNexus)
		{
			num = -408386264;
			num2 = num;
		}
		else
		{
			num = -1647096142;
			num2 = num;
		}
		goto IL_0010;
		IL_0010:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xC7C1B1C8u) % 13u)
			{
			case 6u:
				break;
			default:
				return;
			case 12u:
				goto IL_0059;
			case 9u:
			{
				int num6;
				int num7;
				if (_bW2bcXGC7ddy4Byg043DK6aTDBaA <= _8bQcVNrY4sOsCzDreFoeakMtpBK)
				{
					num6 = -2109720915;
					num7 = num6;
				}
				else
				{
					num6 = -788090712;
					num7 = num6;
				}
				num = num6 ^ (int)(num3 * 794552641);
				continue;
			}
			case 4u:
			{
				int num4;
				int num5;
				if (_fEgmKLJBX4eDyOg6a5xshzKbnJN > _8bQcVNrY4sOsCzDreFoeakMtpBK)
				{
					num4 = -24542197;
					num5 = num4;
				}
				else
				{
					num4 = -783355605;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -509774079);
				continue;
			}
			case 11u:
				goto IL_00d0;
			case 1u:
				goto IL_00fc;
			case 5u:
				return;
			case 7u:
				_pIlHR6kgApWjvk6bGolKBhBvmiDb(moveTime, time, whereabouts);
				num = (int)(num3 * 262313427) ^ -486266825;
				continue;
			case 10u:
				return;
			case 0u:
				return;
			case 2u:
				goto IL_0178;
			case 3u:
				return;
			case 8u:
				return;
			}
			break;
			IL_00fc:
			int num8;
			if (time - _uLq0XCL0AeTDi3FS849oUHVJt0h > Settings.Default.AutoNexusHpPotDelay)
			{
				num = -1115591263;
				num8 = num;
			}
			else
			{
				num = -969609284;
				num8 = num;
			}
			continue;
			IL_00d0:
			int num9;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._v6scruPI8GbKsVXu2rpqDMycX0Q > _8bQcVNrY4sOsCzDreFoeakMtpBK)
			{
				num = -596320299;
				num9 = num;
			}
			else
			{
				num = -358574058;
				num9 = num;
			}
			continue;
			IL_0059:
			int num10;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._YLm5uWwBjPzhLKwhlH4ENYMtq8u())
			{
				num = -537900654;
				num10 = num;
			}
			else
			{
				num = -1555786379;
				num10 = num;
			}
		}
		goto IL_000b;
		IL_000b:
		num = -1294503628;
		goto IL_0010;
	}

	private void _pIlHR6kgApWjvk6bGolKBhBvmiDb(int moveTime, int time, WorldPosData whereabouts)
	{
		SlotObjectData slotObjectData = null;
		int num10 = default(int);
		int num6 = default(int);
		PotionInfo potionInfo = default(PotionInfo);
		while (true)
		{
			int num = 310214258;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x33C07E69u) % 22u)
				{
				case 16u:
					break;
				default:
					return;
				case 14u:
					num10++;
					num = 1480260049;
					continue;
				case 4u:
					_50w8wVuv8bL5nhKaR2EHxjrTamB._xlRUy72uPQ98Hy5AvYCNwBvoQ4K(num10);
					num = ((int)num2 * -822449732) ^ 0x2EC2EF47;
					continue;
				case 2u:
					num6++;
					num = 1273149486;
					continue;
				case 12u:
					_20ZlLRRKR3DBHjWNv9JH1t5WaLt(moveTime, slotObjectData, whereabouts);
					_uLq0XCL0AeTDi3FS849oUHVJt0h = time;
					num = ((int)num2 * -1383493642) ^ 0x1EF46BA1;
					continue;
				case 8u:
				{
					int num13;
					if (num10 < _50w8wVuv8bL5nhKaR2EHxjrTamB._nhFLD7A5r9NSgescGUZ6OSUXLbm.Length)
					{
						num = 1198436290;
						num13 = num;
					}
					else
					{
						num = 977045534;
						num13 = num;
					}
					continue;
				}
				case 21u:
					num6 = 0;
					num = ((int)num2 * -281312098) ^ -637444714;
					continue;
				case 13u:
				{
					int num15;
					if (slotObjectData == null)
					{
						num = 582866265;
						num15 = num;
					}
					else
					{
						num = 719726557;
						num15 = num;
					}
					continue;
				}
				case 20u:
				{
					int num8;
					int num9;
					if (potionInfo.Quantity > 0)
					{
						num8 = 84745088;
						num9 = num8;
					}
					else
					{
						num8 = 1359594453;
						num9 = num8;
					}
					num = num8 ^ ((int)num2 * -767532833);
					continue;
				}
				case 18u:
				{
					int num5;
					if (slotObjectData == null)
					{
						num = 600950768;
						num5 = num;
					}
					else
					{
						num = 977045534;
						num5 = num;
					}
					continue;
				}
				case 19u:
				{
					int num14;
					if (!_QmbevUGazxQlRU192yU0HKSVJsf(_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[num6]))
					{
						num = 1545852683;
						num14 = num;
					}
					else
					{
						num = 2097157869;
						num14 = num;
					}
					continue;
				}
				case 17u:
					num10 = 0;
					num = (int)(num2 * 1139373438) ^ -1577599073;
					continue;
				case 11u:
				{
					int num11;
					int num12;
					if (_QmbevUGazxQlRU192yU0HKSVJsf(potionInfo.Type))
					{
						num11 = -639280571;
						num12 = num11;
					}
					else
					{
						num11 = -1609082556;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -1495688615);
					continue;
				}
				case 5u:
					slotObjectData = new SlotObjectData(_50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC, 1000000 + num10, potionInfo.Type);
					num = (int)(num2 * 120484148) ^ -1905926061;
					continue;
				case 10u:
					slotObjectData = new SlotObjectData(_50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC, num6, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[num6]);
					num = (int)(num2 * 2026954862) ^ -1196184572;
					continue;
				case 7u:
					potionInfo = _50w8wVuv8bL5nhKaR2EHxjrTamB._nhFLD7A5r9NSgescGUZ6OSUXLbm[num10];
					num = 79909149;
					continue;
				case 3u:
					num = (int)((num2 * 1347493908) ^ 0x34A94081);
					continue;
				case 9u:
				{
					int num7;
					if (num6 < _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory.Length)
					{
						num = 86852384;
						num7 = num;
					}
					else
					{
						num = 1793292325;
						num7 = num;
					}
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!Settings.Default.AutoNexusDrinkFromInventory)
					{
						num3 = -230328174;
						num4 = num3;
					}
					else
					{
						num3 = -1273427433;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 376955797);
					continue;
				}
				case 15u:
					num = ((int)num2 * -1216884233) ^ 0x1B28EA9;
					continue;
				case 6u:
					num = ((int)num2 * -426032166) ^ -1516721982;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private bool _QmbevUGazxQlRU192yU0HKSVJsf(int id)
	{
		//Discarded unreachable code: IL_0034, IL_0088
		if (id == -1)
		{
			goto IL_0004;
		}
		goto IL_0069;
		IL_0069:
		int num;
		int num2;
		if (Settings.Default.AutoNexusUseAnyHealingItem)
		{
			num = -1137961640;
			num2 = num;
		}
		else
		{
			num = -216214930;
			num2 = num;
		}
		goto IL_0009;
		IL_0009:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xA4536FDCu) % 6u)
			{
			case 5u:
				break;
			case 1u:
				return false;
			case 0u:
			{
				int num4;
				int num5;
				if (_PlferqYaObizDfc28C5jdKSLGq5._RMiC0QFzlD1C8rYuIDkiDIy5r1H.Contains(id))
				{
					num4 = 1812783460;
					num5 = num4;
				}
				else
				{
					num4 = 1331334514;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 1014621543);
				continue;
			}
			case 3u:
				goto IL_0069;
			case 4u:
				return true;
			default:
				return id == 2594;
			}
			break;
		}
		goto IL_0004;
		IL_0004:
		num = -562341577;
		goto IL_0009;
	}

	private void _20ZlLRRKR3DBHjWNv9JH1t5WaLt(int time, SlotObjectData slot, WorldPosData location)
	{
		_nV9aomeHIThwTmnJfuHyMX6d9RG nV9aomeHIThwTmnJfuHyMX6d9RG = (_nV9aomeHIThwTmnJfuHyMX6d9RG)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.USEITEM);
		nV9aomeHIThwTmnJfuHyMX6d9RG._obJo3i4uC8yf7c2aS8NBvEttXTO = slot;
		while (true)
		{
			int num = 2116146147;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CAECAF6u) % 4u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					nV9aomeHIThwTmnJfuHyMX6d9RG._IBSqBdwNTiXSzhZbDhEFMC0Gc51 = time;
					nV9aomeHIThwTmnJfuHyMX6d9RG._hik7MnmCWLUNupBgHpKPyvAspMh = location;
					num = (int)((num2 * 53575751) ^ 0x7B3B4F8A);
					continue;
				case 3u:
					nV9aomeHIThwTmnJfuHyMX6d9RG._if0d81H88w2JolCC4orFfcsIICeA = (byte)((slot._SlotId < 1000000) ? 1u : 0u);
					_50w8wVuv8bL5nhKaR2EHxjrTamB._WEI99xvr4YqzD1PAnL2WmiBhWKJ(nV9aomeHIThwTmnJfuHyMX6d9RG);
					num = 719896622;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	private void _MZEpjczfvKiLuBC5dtTeu4eiUrI(int diff)
	{
		double num = (double)diff * 0.001;
		double num2 = 2.0 * (1.0 + 0.12 * (double)_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._P6tDEyGoXHV3WltSPRoAkw3XvUe);
		int num8 = default(int);
		double nZ4umDhXWmp8bGVywQUwURRhqK = default(double);
		while (true)
		{
			int num3 = -324661138;
			while (true)
			{
				uint num4;
				int num7;
				switch ((num4 = (uint)num3 ^ 0xDD752EB0u) % 12u)
				{
				case 0u:
					break;
				default:
					return;
				case 11u:
					num7 = ((_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._3TdWQMIfFRLyOCb0Tb6TO3SonPc == 0) ? 1 : 0);
					goto IL_009e;
				case 9u:
					num8 = (int)_nZ4umDhXWmp8bGVywQUwURRhqK;
					nZ4umDhXWmp8bGVywQUwURRhqK = _nZ4umDhXWmp8bGVywQUwURRhqK - (double)num8;
					num3 = -1079337428;
					continue;
				case 2u:
					num2 /= 2.0;
					num3 = (int)(num4 * 1778322794) ^ -1817805804;
					continue;
				case 3u:
					_fEgmKLJBX4eDyOg6a5xshzKbnJN = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT;
					num3 = (int)((num4 * 354143618) ^ 0x35A8051C);
					continue;
				case 4u:
					if (!_GwYvhv88QJIDA9V6ds6bsTq5fCC)
					{
						num7 = 0;
						goto IL_009e;
					}
					num3 = -986750565;
					continue;
				case 1u:
				{
					int num9;
					int num10;
					if (_fEgmKLJBX4eDyOg6a5xshzKbnJN > _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT)
					{
						num9 = -1674545055;
						num10 = num9;
					}
					else
					{
						num9 = -282971864;
						num10 = num9;
					}
					num3 = num9 ^ ((int)num4 * -416618078);
					continue;
				}
				case 5u:
					_nZ4umDhXWmp8bGVywQUwURRhqK -= 94.0 * num;
					num3 = ((int)num4 * -1992889325) ^ 0x14785156;
					continue;
				case 8u:
					_nZ4umDhXWmp8bGVywQUwURRhqK = nZ4umDhXWmp8bGVywQUwURRhqK;
					num3 = ((int)num4 * -1523310341) ^ -127599573;
					continue;
				case 7u:
					_fEgmKLJBX4eDyOg6a5xshzKbnJN += num8;
					num3 = (int)((num4 * 213810596) ^ 0x5D472F85);
					continue;
				case 10u:
				{
					int num5;
					int num6;
					if (_nSbn5BiGHvwfVPOliLfIaQJ4jcb)
					{
						num5 = 1141233984;
						num6 = num5;
					}
					else
					{
						num5 = 2132241018;
						num6 = num5;
					}
					num3 = num5 ^ ((int)num4 * -622948165);
					continue;
				}
				case 6u:
					return;
					IL_009e:
					if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._YLm5uWwBjPzhLKwhlH4ENYMtq8u() && !_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._318BaWhp3KqQPFQI19qagassWIP())
					{
						_nZ4umDhXWmp8bGVywQUwURRhqK += num2 * num;
						if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._Z9kQZ9yr8r0HU8Vt3nIBcujjeHP())
						{
							_nZ4umDhXWmp8bGVywQUwURRhqK += 20.0 * num;
						}
					}
					else if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._318BaWhp3KqQPFQI19qagassWIP())
					{
						_nZ4umDhXWmp8bGVywQUwURRhqK -= 20.0 * num;
					}
					if (num7 != 0)
					{
						num3 = -831682571;
						continue;
					}
					goto case 9u;
				}
				break;
			}
		}
	}

	private void _FX4vSy5JMHovi3Px83YbL5RUCVO()
	{
		_ = _wpv3L2x9SVwVG8oTXkB9xlrWfYf;
		while (true)
		{
			int num = 241739885;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x14FFB952u) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					_wpv3L2x9SVwVG8oTXkB9xlrWfYf = (int)((double)Settings.Default.AutoNexusPercentageThreshold * 0.01 * (double)_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT);
					num = ((int)num2 * -2123389298) ^ -767587602;
					continue;
				case 2u:
					_8bQcVNrY4sOsCzDreFoeakMtpBK = (int)((double)Settings.Default.AutoNexusDrinkThreshold * 0.01 * (double)_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT);
					num = ((int)num2 * -1800926813) ^ 0x2C782669;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private bool _zPOUViNkt7ARkkvn46oJQqXIDxd()
	{
		//Discarded unreachable code: IL_004b, IL_0083, IL_008c
		if (_oV73NEwk247WZa6wM3sxIJwPEei)
		{
			goto IL_000b;
		}
		goto IL_009e;
		IL_009e:
		int num;
		int num2;
		if (!Settings.Default.EnableAutoNexus)
		{
			num = -1848967726;
			num2 = num;
		}
		else
		{
			num = -1518289000;
			num2 = num;
		}
		goto IL_0010;
		IL_0010:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xF1042560u) % 9u)
			{
			case 3u:
				break;
			case 6u:
				return false;
			case 5u:
			{
				int num6;
				int num7;
				if (_fEgmKLJBX4eDyOg6a5xshzKbnJN >= _wpv3L2x9SVwVG8oTXkB9xlrWfYf)
				{
					num6 = 623911157;
					num7 = num6;
				}
				else
				{
					num6 = 1039058007;
					num7 = num6;
				}
				num = num6 ^ ((int)num3 * -651170963);
				continue;
			}
			case 2u:
				return true;
			case 8u:
				return false;
			case 7u:
				goto IL_009e;
			case 4u:
			{
				int num4;
				int num5;
				if (_bW2bcXGC7ddy4Byg043DK6aTDBaA < _wpv3L2x9SVwVG8oTXkB9xlrWfYf)
				{
					num4 = 1183119226;
					num5 = num4;
				}
				else
				{
					num4 = 50004929;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 318278526);
				continue;
			}
			case 0u:
				goto IL_00e8;
			default:
				return false;
			}
			break;
			IL_00e8:
			int num8;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._v6scruPI8GbKsVXu2rpqDMycX0Q < _wpv3L2x9SVwVG8oTXkB9xlrWfYf)
			{
				num = -519666422;
				num8 = num;
			}
			else
			{
				num = -249257263;
				num8 = num;
			}
		}
		goto IL_000b;
		IL_000b:
		num = -233001250;
		goto IL_0010;
	}

	private void _NFR83kf0QjqRt7cv1oeTT9iTqOB(int newMax)
	{
		if (_fEgmKLJBX4eDyOg6a5xshzKbnJN > newMax)
		{
			while (true)
			{
				int num = 435659545;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x48F1CD85u) % 3u)
					{
					case 0u:
						break;
					case 2u:
						_fEgmKLJBX4eDyOg6a5xshzKbnJN = newMax;
						num = (int)(num2 * 1169325659) ^ -1861201337;
						continue;
					default:
						goto IL_0041;
					}
					break;
				}
			}
		}
		goto IL_0041;
		IL_0041:
		_FX4vSy5JMHovi3Px83YbL5RUCVO();
	}

	private void _co7DtC49zFOcncuiHywaZTrYDCK(int healAmount)
	{
		_YoiVXw2d31gsIFtzKgnWKslGU6D = healAmount;
	}

	private void _KhWciVZacyPe2Oeb7ecrgum6Nn0A(int amount, string source)
	{
		_fEgmKLJBX4eDyOg6a5xshzKbnJN += amount;
		if (_fEgmKLJBX4eDyOg6a5xshzKbnJN <= _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT)
		{
			return;
		}
		while (true)
		{
			int num = 1152507898;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x99888A7u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0048;
				case 2u:
					return;
				}
				break;
				IL_0048:
				_fEgmKLJBX4eDyOg6a5xshzKbnJN = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT;
				num = ((int)num2 * -785893452) ^ -687434675;
			}
		}
	}

	private void _CLRtscLVGwgyeHHILRfayjUB8iu(int amount, string source)
	{
		_fEgmKLJBX4eDyOg6a5xshzKbnJN -= amount;
		while (true)
		{
			int num = 441875308;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3CD241E9u) % 5u)
				{
				case 4u:
					break;
				default:
					return;
				case 3u:
					_MSYZNy9RqGhVTWQzakLfwAAmToG(amount, source);
					num = ((int)num2 * -1023300438) ^ 0x562444F5;
					continue;
				case 0u:
				{
					int num3;
					int num4;
					if (_zPOUViNkt7ARkkvn46oJQqXIDxd())
					{
						num3 = -27293466;
						num4 = num3;
					}
					else
					{
						num3 = -1366755459;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 997477019);
					continue;
				}
				case 1u:
					_bW2bcXGC7ddy4Byg043DK6aTDBaA -= amount;
					num = (int)(num2 * 1021575019) ^ -1774634832;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public void _CgwO1K8tgdyKPdKvCtJupNhapLD(PlayerTextPacket playerText)
	{
		//Discarded unreachable code: IL_00d5, IL_00fe, IL_0111
		if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC != null)
		{
			goto IL_0010;
		}
		goto IL_01a5;
		IL_01a5:
		int num;
		int num2;
		if (playerText._Message.StartsWith("/an "))
		{
			num = 1401997673;
			num2 = num;
		}
		else
		{
			num = 15739210;
			num2 = num;
		}
		goto IL_0015;
		IL_0015:
		int result = default(int);
		string text = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xBC88F9Cu) % 13u)
			{
			case 11u:
				break;
			default:
				return;
			case 10u:
				Settings.Default.AutoNexusPercentageThreshold = _r81eyljcpx9fMtE3XUSUstNFtOI._JCqNIvBZ7PIQMspflSZ7jsNNzJb(5, 100, result);
				Settings.Default.Change();
				num = 1300945284;
				continue;
			case 8u:
			{
				int num6;
				int num7;
				if (!string.IsNullOrEmpty(text))
				{
					num6 = 1880802578;
					num7 = num6;
				}
				else
				{
					num6 = 904823873;
					num7 = num6;
				}
				num = num6 ^ (int)(num3 * 17171491);
				continue;
			}
			case 4u:
			{
				int num4;
				int num5;
				if (!(playerText._Message == "/reset"))
				{
					num4 = 636132408;
					num5 = num4;
				}
				else
				{
					num4 = 90856152;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 2118444671);
				continue;
			}
			case 6u:
				return;
			case 1u:
				_fEgmKLJBX4eDyOg6a5xshzKbnJN = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._v6scruPI8GbKsVXu2rpqDMycX0Q;
				return;
			case 3u:
				return;
			case 5u:
				playerText._Send = false;
				text = playerText._Message.Substring(4);
				num = (int)((num3 * 1180644349) ^ 0x38E78108);
				continue;
			case 9u:
				goto IL_0149;
			case 0u:
				_FX4vSy5JMHovi3Px83YbL5RUCVO();
				_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0($"Set autonexus health threshold to {result}% (at {_wpv3L2x9SVwVG8oTXkB9xlrWfYf} health)");
				num = (int)((num3 * 255506515) ^ 0x5E230082);
				continue;
			case 7u:
				goto IL_01a5;
			case 12u:
				playerText._Send = false;
				num = ((int)num3 * -588596468) ^ 0x548FC119;
				continue;
			case 2u:
				return;
			}
			break;
			IL_0149:
			int num8;
			if (!int.TryParse(text, out result))
			{
				num = 599386350;
				num8 = num;
			}
			else
			{
				num = 1441969786;
				num8 = num;
			}
		}
		goto IL_0010;
		IL_0010:
		num = 16261493;
		goto IL_0015;
	}
}
