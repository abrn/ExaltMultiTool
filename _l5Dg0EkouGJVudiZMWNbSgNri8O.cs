using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.DataStructures;

internal class _l5Dg0EkouGJVudiZMWNbSgNri8O
{
	private static readonly Dictionary<ushort, byte> _bYrT3FzsIklanR8e2vZ9RBuSZOL;

	private bool _t4KMngpne0NUuJ6bUZ4OoBMeFV;

	private Client _50w8wVuv8bL5nhKaR2EHxjrTamB;

	private readonly Dictionary<int, int> _kGGu3Lri5FWVdDmWIhivvRjNI8C = new Dictionary<int, int>();

	private int _fW3NxZHaXrWNIUh5t12nVR2KoIq = 100;

	private bool _74KKKuVtZqkVRDxOFUQeDoXCmfJ;

	private bool _d76hGBxQunsKFl48nZmbHBS39di = Settings.Default.AntiLagApplyToGuildMates;

	private bool _U7IojJcawvIQSeI4gQwqBIroEaV = Settings.Default.AntiLagHideAllyPets;

	private bool _bzWKi3O4BpntfsYKqrrA0hsxlMI;

	static _l5Dg0EkouGJVudiZMWNbSgNri8O()
	{
		_bYrT3FzsIklanR8e2vZ9RBuSZOL = new Dictionary<ushort, byte>();
		using Dictionary<ushort, ObjectStructure>.Enumerator enumerator = ResourceDownloader._VPArsrlUa0uEsW6OxAYV9WHJAMK._oQlNWqxOoe5LqobGdGJlgo4YIsh.GetEnumerator();
		KeyValuePair<ushort, ObjectStructure> current = default(KeyValuePair<ushort, ObjectStructure>);
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = 1430672874;
				num2 = num;
			}
			else
			{
				num = 1661451635;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x15F119EDu) % 6u)
				{
				case 5u:
					num = 1430672874;
					continue;
				default:
					return;
				case 3u:
				{
					current = enumerator.Current;
					int num6;
					if (!current.Value.Pet)
					{
						num = 691664610;
						num6 = num;
					}
					else
					{
						num = 1561527033;
						num6 = num;
					}
					continue;
				}
				case 1u:
					break;
				case 4u:
					_bYrT3FzsIklanR8e2vZ9RBuSZOL.Add(current.Key, 0);
					num = ((int)num3 * -422135498) ^ -326112026;
					continue;
				case 0u:
				{
					int num4;
					int num5;
					if (!_bYrT3FzsIklanR8e2vZ9RBuSZOL.ContainsKey(current.Key))
					{
						num4 = 367165323;
						num5 = num4;
					}
					else
					{
						num4 = 1102142114;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -385568816);
					continue;
				}
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public _l5Dg0EkouGJVudiZMWNbSgNri8O(Client client)
	{
		while (true)
		{
			int num = -1746872279;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFD6D8286u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_005b;
				case 1u:
					return;
				}
				break;
				IL_005b:
				_50w8wVuv8bL5nhKaR2EHxjrTamB = client;
				num = ((int)num2 * -302744539) ^ -639995522;
			}
		}
	}

	public void _DT5vfLbxw23gMixKpQ7yxEiQkEe(MapInfoPacket mapInfo)
	{
		if (!mapInfo._MapName.Contains("Pet Yard"))
		{
			return;
		}
		while (true)
		{
			int num = -460678157;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA21FB735u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0034;
				case 1u:
					return;
				}
				break;
				IL_0034:
				_t4KMngpne0NUuJ6bUZ4OoBMeFV = true;
				num = (int)((num2 * 1866495082) ^ 0x76C7BB24);
			}
		}
	}

	public void _C3mvDTxTLKOCwcaeO4BKeVV1ydo(DamagePacket damage)
	{
		//Discarded unreachable code: IL_003b
		if (!Settings.Default.BlockDamageNumbers)
		{
			goto IL_000c;
		}
		goto IL_0084;
		IL_0084:
		int num;
		int num2;
		if (damage._fn2CRnBpjyTWHR9K8SU4iOwhDtK != _50w8wVuv8bL5nhKaR2EHxjrTamB._fn2CRnBpjyTWHR9K8SU4iOwhDtK)
		{
			num = 1993409769;
			num2 = num;
		}
		else
		{
			num = 357073140;
			num2 = num;
		}
		goto IL_0011;
		IL_0011:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x5EE04A9Bu) % 6u)
			{
			case 0u:
				break;
			default:
				return;
			case 3u:
				return;
			case 2u:
			{
				int num4;
				int num5;
				if (damage._91Zhx0OBsUhlR5optw0cihxmls4 == _50w8wVuv8bL5nhKaR2EHxjrTamB._fn2CRnBpjyTWHR9K8SU4iOwhDtK)
				{
					num4 = 1761094958;
					num5 = num4;
				}
				else
				{
					num4 = 1358884701;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 246831445);
				continue;
			}
			case 1u:
				damage._Send = false;
				num = 760103559;
				continue;
			case 5u:
				goto IL_0084;
			case 4u:
				return;
			}
			break;
		}
		goto IL_000c;
		IL_000c:
		num = 382677166;
		goto IL_0011;
	}

	public void _YmUsIMJpOnkALS3b15SlCrNHpDCA(ShowEffectPacket showEffect)
	{
		
		if (!Settings.Default.AntiLagIgnoreEffects)
		{
			goto IL_000c;
		}
		goto IL_005e;
		IL_005e:
		string name = Enum.GetName(typeof(EffectDictionary), showEffect._EffectDict);
		int num = 364950784;
		goto IL_0011;
		IL_0011:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x1EB06423u) % 5u)
			{
			case 4u:
				break;
			default:
				return;
			case 2u:
				showEffect._Send = !Settings.Default.AntiLagIgnoredEffects.Contains(name);
				num = ((int)num2 * -665061224) ^ -426667547;
				continue;
			case 1u:
				goto IL_005e;
			case 3u:
				return;
			case 0u:
				return;
			}
			break;
		}
		goto IL_000c;
		IL_000c:
		num = 58739779;
		goto IL_0011;
	}

	public void _N9zjozggCA9FymbKtC3I9dZkIib(TextPacket text)
	{
		//Discarded unreachable code: IL_017f, IL_01af, IL_0214, IL_0268, IL_027c
		if (!_bzWKi3O4BpntfsYKqrrA0hsxlMI)
		{
			goto IL_000b;
		}
		goto IL_024a;
		IL_024a:
		int num;
		int num2;
		if (text._NumStars != -1)
		{
			num = -408988851;
			num2 = num;
		}
		else
		{
			num = -1031011249;
			num2 = num;
		}
		goto IL_0010;
		IL_0010:
		string[] array = default(string[]);
		string guild = default(string);
		string name = default(string);
		string name2 = default(string);
		string guild2 = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xA16E09C2u) % 22u)
			{
			case 0u:
				break;
			default:
				return;
			case 11u:
			{
				int num14;
				int num15;
				if (text._CleanMessage.StartsWith("{\"key\":\"server.guild_join\",\"tokens\":{\"name\":\""))
				{
					num14 = -1133620929;
					num15 = num14;
				}
				else
				{
					num14 = -1012534826;
					num15 = num14;
				}
				num = num14 ^ ((int)num3 * -1279869176);
				continue;
			}
			case 2u:
			{
				int num6;
				int num7;
				if (!text._CleanMessage.Contains(_50w8wVuv8bL5nhKaR2EHxjrTamB._PlayerData._ROI49ai7g89LZTXhpoAd3C7Qa4I))
				{
					num6 = 1998134989;
					num7 = num6;
				}
				else
				{
					num6 = 76790477;
					num7 = num6;
				}
				num = num6 ^ (int)(num3 * 296691920);
				continue;
			}
			case 20u:
				array = array[0].Split(new string[1]
				{
					"\",\"guild\":\""
				}, StringSplitOptions.RemoveEmptyEntries);
				num = -1986695598;
				continue;
			case 3u:
			{
				int num10;
				int num11;
				if (!(text._Recipient == "*Guild*"))
				{
					num10 = -1843857576;
					num11 = num10;
				}
				else
				{
					num10 = -777026577;
					num11 = num10;
				}
				num = num10 ^ ((int)num3 * -1516897623);
				continue;
			}
			case 5u:
				guild = array[1];
				num = ((int)num3 * -54645723) ^ -2067783904;
				continue;
			case 1u:
				array = text._CleanMessage.Split(new string[1]
				{
					"{\"key\":\"server.guild_join\",\"tokens\":{\"name\":\""
				}, StringSplitOptions.RemoveEmptyEntries);
				num = (int)(num3 * 643750232) ^ -1110301320;
				continue;
			case 6u:
				return;
			case 7u:
				_bXBAQSQDuRQKpJb0pK866XdaUHU(name, guild);
				num = (int)(num3 * 1740986651) ^ -657979560;
				continue;
			case 4u:
				return;
			case 18u:
			{
				int num12;
				int num13;
				if (array.Length != 1)
				{
					num12 = -983030530;
					num13 = num12;
				}
				else
				{
					num12 = -508403316;
					num13 = num12;
				}
				num = num12 ^ ((int)num3 * -482015272);
				continue;
			}
			case 12u:
				goto IL_01e5;
			case 13u:
				_bXBAQSQDuRQKpJb0pK866XdaUHU(name2, guild2);
				return;
			case 10u:
			{
				int num8;
				int num9;
				if (array.Length != 2)
				{
					num8 = -1980903902;
					num9 = num8;
				}
				else
				{
					num8 = -379766249;
					num9 = num8;
				}
				num = num8 ^ (int)(num3 * 306054656);
				continue;
			}
			case 16u:
				goto IL_024a;
			case 14u:
				return;
			case 21u:
				return;
			case 15u:
				array = text._CleanMessage.Split(new string[1]
				{
					" has left "
				}, StringSplitOptions.RemoveEmptyEntries);
				num = (int)(num3 * 1349718879) ^ -44342563;
				continue;
			case 19u:
				name = array[0].ToLower();
				num = -294907541;
				continue;
			case 9u:
				name2 = array[0].ToLower();
				guild2 = array[1].Substring(0, array[1].Length - 3);
				num = -39594927;
				continue;
			case 8u:
			{
				int num4;
				int num5;
				if (array.Length == 2)
				{
					num4 = -1714661409;
					num5 = num4;
				}
				else
				{
					num4 = -1312765642;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -1078885384);
				continue;
			}
			case 17u:
				return;
			}
			break;
			IL_01e5:
			int num16;
			if (text._CleanMessage.Contains(" has left "))
			{
				num = -1144297277;
				num16 = num;
			}
			else
			{
				num = -408988851;
				num16 = num;
			}
		}
		goto IL_000b;
		IL_000b:
		num = -1835991531;
		goto IL_0010;
	}

	public void _emTnZmGyChlXH4IDm60126G1Snf(UpdatePacket update)
	{
		GameObject[] lakUpSXZB1zdJcCECL20tl6SVrT = update._NewObjects;
		GameObject gameObject = default(GameObject);
		int num5 = default(int);
		int[] lRLF1OvIoGLzzq1APVMdrraeXfZ = default(int[]);
		int key = default(int);
		while (true)
		{
			int num = -328697545;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x943E6A0Au) % 19u)
				{
				case 17u:
					break;
				default:
					return;
				case 6u:
				{
					gameObject = lakUpSXZB1zdJcCECL20tl6SVrT[num5];
					int num10;
					if (_yM13KvXU9cLnZX3zNfsAEJ8e8UE(gameObject))
					{
						num = -1855353642;
						num10 = num;
					}
					else
					{
						num = -1291423863;
						num10 = num;
					}
					continue;
				}
				case 2u:
					num = (int)((num2 * 1725496247) ^ 0xB6CD73D);
					continue;
				case 11u:
					num = (int)((num2 * 1877393912) ^ 0x76EF5A44);
					continue;
				case 15u:
				{
					int num13;
					if (num5 >= lRLF1OvIoGLzzq1APVMdrraeXfZ.Length)
					{
						num = -25567170;
						num13 = num;
					}
					else
					{
						num = -1240569499;
						num13 = num;
					}
					continue;
				}
				case 4u:
				{
					int num9;
					if (num5 >= lakUpSXZB1zdJcCECL20tl6SVrT.Length)
					{
						num = -1708094105;
						num9 = num;
					}
					else
					{
						num = -1494954871;
						num9 = num;
					}
					continue;
				}
				case 13u:
					_kGGu3Lri5FWVdDmWIhivvRjNI8C.Add(gameObject._Status._ObjectId, 100);
					num = ((int)num2 * -1881621698) ^ 0x386E81D7;
					continue;
				case 10u:
					_KQrCDNrUysA4qKaWspdpLvKfrZf(gameObject._Status);
					num = -1703732882;
					continue;
				case 1u:
					num5 = 0;
					num = (int)(num2 * 1790886161) ^ -2117947077;
					continue;
				case 5u:
					num5++;
					num = -814518055;
					continue;
				case 3u:
					_74KKKuVtZqkVRDxOFUQeDoXCmfJ = true;
					num = (int)((num2 * 1309014192) ^ 0x495B816);
					continue;
				case 12u:
				{
					int num11;
					int num12;
					if (_kGGu3Lri5FWVdDmWIhivvRjNI8C.ContainsKey(gameObject._Status._ObjectId))
					{
						num11 = 328785446;
						num12 = num11;
					}
					else
					{
						num11 = 906874381;
						num12 = num11;
					}
					num = num11 ^ (int)(num2 * 191097559);
					continue;
				}
				case 18u:
					_kGGu3Lri5FWVdDmWIhivvRjNI8C.Remove(key);
					num = ((int)num2 * -50752239) ^ -771703677;
					continue;
				case 8u:
				{
					key = lRLF1OvIoGLzzq1APVMdrraeXfZ[num5];
					int num8;
					if (!_kGGu3Lri5FWVdDmWIhivvRjNI8C.ContainsKey(key))
					{
						num = -361769161;
						num8 = num;
					}
					else
					{
						num = -697857410;
						num8 = num;
					}
					continue;
				}
				case 7u:
				{
					int num6;
					int num7;
					if (gameObject._Status._ObjectId != _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC)
					{
						num6 = -640090087;
						num7 = num6;
					}
					else
					{
						num6 = -612884592;
						num7 = num6;
					}
					num = num6 ^ ((int)num2 * -940170558);
					continue;
				}
				case 9u:
					num5++;
					num = -1894437972;
					continue;
				case 0u:
					lRLF1OvIoGLzzq1APVMdrraeXfZ = update._Drops;
					num5 = 0;
					num = ((int)num2 * -15698712) ^ 0x6F98AE41;
					continue;
				case 14u:
				{
					int num3;
					int num4;
					if (!_Gh2VHcPTkEUMxCEVgHnOW695CDd(gameObject))
					{
						num3 = -1550332274;
						num4 = num3;
					}
					else
					{
						num3 = -2014176103;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2146031864);
					continue;
				}
				case 16u:
					return;
				}
				break;
			}
		}
	}

	private bool _ow9m5GAzgJSxf9M25gYtAqiJHYr(GameObject entity)
	{
		return _bYrT3FzsIklanR8e2vZ9RBuSZOL.ContainsKey(entity._ObjectType);
	}

	private bool _yM13KvXU9cLnZX3zNfsAEJ8e8UE(GameObject entity)
	{
		if (entity._Status._ObjectId - 1 != _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC)
		{
			while (true)
			{
				uint num;
				switch ((num = 0x39F48EC4u ^ 0x2B9A2097u) % 3u)
				{
				case 0u:
					continue;
				case 1u:
					return false;
				}
				break;
			}
		}
		return _ow9m5GAzgJSxf9M25gYtAqiJHYr(entity);
	}

	private bool _Gh2VHcPTkEUMxCEVgHnOW695CDd(GameObject entity)
	{
		if (_50w8wVuv8bL5nhKaR2EHxjrTamB._naDcMlPfaanTh6qrJ3cOuO4HNwz.ContainsKey(entity._Status._ObjectId))
		{
			while (true)
			{
				uint num;
				switch ((num = 0x8C8D61FFu ^ 0x9F8F07BCu) % 3u)
				{
				case 2u:
					continue;
				case 1u:
					return true;
				}
				break;
			}
		}
		return _ow9m5GAzgJSxf9M25gYtAqiJHYr(entity);
	}

	public void _kcBjTzBYfTPCpKNctSQjw45y1mb(NewTickPacket newTick)
	{
		using (List<Status>.Enumerator enumerator = newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.GetEnumerator())
		{
			Status current = default(Status);
			while (true)
			{
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1701819780;
					num2 = num;
				}
				else
				{
					num = -1993660075;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xAE23AF20u) % 5u)
					{
					case 0u:
						num = -1993660075;
						continue;
					default:
						goto end_IL_000c;
					case 1u:
						break;
					case 4u:
						_KQrCDNrUysA4qKaWspdpLvKfrZf(current);
						num = (int)(num3 * 1096344859) ^ -536971848;
						continue;
					case 3u:
						current = enumerator.Current;
						num = -1281498636;
						continue;
					case 2u:
						goto end_IL_000c;
					}
					break;
				}
			}
			end_IL_000c:;
		}
		_bzWKi3O4BpntfsYKqrrA0hsxlMI = !string.IsNullOrEmpty(_50w8wVuv8bL5nhKaR2EHxjrTamB._PlayerData._ROI49ai7g89LZTXhpoAd3C7Qa4I);
		if (!_74KKKuVtZqkVRDxOFUQeDoXCmfJ)
		{
			goto IL_00af;
		}
		goto IL_00fb;
		IL_02cf:
		_fW3NxZHaXrWNIUh5t12nVR2KoIq = Settings.Default.AntiLagAllyPlayerSize;
		_d76hGBxQunsKFl48nZmbHBS39di = Settings.Default.AntiLagApplyToGuildMates;
		_U7IojJcawvIQSeI4gQwqBIroEaV = Settings.Default.AntiLagHideAllyPets;
		while (true)
		{
			int num4 = -840598937;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num4 ^ 0xAE23AF20u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0322;
				case 1u:
					return;
				}
				break;
				IL_0322:
				_74KKKuVtZqkVRDxOFUQeDoXCmfJ = false;
				num4 = (int)(num3 * 1677046989) ^ -475473784;
			}
		}
		IL_00fb:
		int num5 = 1;
		goto IL_00fc;
		IL_00fc:
		int num6;
		if (num5 != 0)
		{
			num6 = -1689168572;
			goto IL_00b4;
		}
		goto IL_02cf;
		IL_00f8:
		num5 = 0;
		goto IL_00fc;
		IL_00b4:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num6 ^ 0xAE23AF20u) % 6u)
			{
			case 5u:
				break;
			case 0u:
				goto IL_00e1;
			case 2u:
				goto IL_0108;
			case 1u:
				goto IL_012a;
			case 3u:
				goto IL_014f;
			default:
				goto IL_0170;
			}
			break;
			IL_014f:
			if (Settings.Default.AntiLagAllyPlayerSize != 100)
			{
				num6 = ((int)num3 * -1335143239) ^ -1257307739;
				continue;
			}
			goto IL_00f8;
			IL_0108:
			if (_U7IojJcawvIQSeI4gQwqBIroEaV == Settings.Default.AntiLagHideAllyPets)
			{
				num6 = ((int)num3 * -1074441486) ^ 0x39D9660B;
				continue;
			}
			goto IL_00fb;
			IL_012a:
			if (_d76hGBxQunsKFl48nZmbHBS39di == Settings.Default.AntiLagApplyToGuildMates)
			{
				num6 = (int)(num3 * 637746414) ^ -842677698;
				continue;
			}
			goto IL_00fb;
		}
		goto IL_00af;
		IL_00af:
		num6 = -333444471;
		goto IL_00b4;
		IL_0170:
		using (Dictionary<int, int>.Enumerator enumerator2 = _kGGu3Lri5FWVdDmWIhivvRjNI8C.GetEnumerator())
		{
			PlayerData jI4Bueou7dItYp5S7QML5vyC6Rc = default(PlayerData);
			KeyValuePair<int, int> current2 = default(KeyValuePair<int, int>);
			int eyUdApagvMmdKBg1JViUYH4wMaH = default(int);
			while (true)
			{
				int num7;
				int num8;
				if (enumerator2.MoveNext())
				{
					num7 = -1295206609;
					num8 = num7;
				}
				else
				{
					num7 = -597284225;
					num8 = num7;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num7 ^ 0xAE23AF20u) % 7u)
					{
					case 5u:
						num7 = -1295206609;
						continue;
					default:
						goto end_IL_017c;
					case 2u:
						break;
					case 3u:
						jI4Bueou7dItYp5S7QML5vyC6Rc = _50w8wVuv8bL5nhKaR2EHxjrTamB._VPArsrlUa0uEsW6OxAYV9WHJAMK[current2.Key];
						num7 = ((int)num3 * -1887046945) ^ 0x1672BC0E;
						continue;
					case 6u:
						eyUdApagvMmdKBg1JViUYH4wMaH = _EVhCC0ekBrEVLjZ30fXud3hsfYm(current2.Key);
						num7 = (int)(num3 * 549052461) ^ -1684339724;
						continue;
					case 0u:
						newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.Add(new Status
						{
							_Position = jI4Bueou7dItYp5S7QML5vyC6Rc._IlcbhoOIM3MRszn9mfn3IKjnXc0,
							_ObjectId = current2.Key,
							_Stats = new List<StatData>
							{
								new StatData
								{
									_StatType = StatType._zMlSnmW3LLSxr4x3sZAbRbWfh8Y,
									_StatValue = eyUdApagvMmdKBg1JViUYH4wMaH,
									_StringStatValue = string.Empty
								}
							}
						});
						num7 = ((int)num3 * -474958846) ^ 0x3CCECB4D;
						continue;
					case 1u:
					{
						current2 = enumerator2.Current;
						int num9;
						if (_50w8wVuv8bL5nhKaR2EHxjrTamB._VPArsrlUa0uEsW6OxAYV9WHJAMK.ContainsKey(current2.Key))
						{
							num7 = -1524393605;
							num9 = num7;
						}
						else
						{
							num7 = -1246983301;
							num9 = num7;
						}
						continue;
					}
					case 4u:
						goto end_IL_017c;
					}
					break;
				}
			}
			end_IL_017c:;
		}
		goto IL_02cf;
		IL_00e1:
		num5 = ((Settings.Default.AntiLagAllyPlayerSize != _fW3NxZHaXrWNIUh5t12nVR2KoIq) ? 1 : 0);
		goto IL_00fc;
	}

	private int _EVhCC0ekBrEVLjZ30fXud3hsfYm(int objectId)
	{
		PlayerData jI4Bueou7dItYp5S7QML5vyC6Rc = _50w8wVuv8bL5nhKaR2EHxjrTamB._VPArsrlUa0uEsW6OxAYV9WHJAMK[objectId];
		if (jI4Bueou7dItYp5S7QML5vyC6Rc._W6bpBrAw6dPSILcVRK394JGD7tC)
		{
			goto IL_001d;
		}
		goto IL_01b0;
		IL_01b0:
		int num;
		int num2;
		if (!_bYrT3FzsIklanR8e2vZ9RBuSZOL.ContainsKey(jI4Bueou7dItYp5S7QML5vyC6Rc._y2nCjecGeYsmqDEzaplcuBvYtN7))
		{
			num = -1336918632;
			num2 = num;
		}
		else
		{
			num = -739532657;
			num2 = num;
		}
		goto IL_0022;
		IL_0022:
		int antiLagAllyPlayerSize = default(int);
		int num4 = default(int);
		bool antiLagApplyToGuildMates = default(bool);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xEF0BBC66u) % 14u)
			{
			case 9u:
				break;
			case 5u:
				return _kGGu3Lri5FWVdDmWIhivvRjNI8C[objectId];
			case 1u:
				return Settings.Default.AntiLagAllyPlayerSize;
			case 10u:
			{
				int num7;
				int num8;
				if (_t4KMngpne0NUuJ6bUZ4OoBMeFV)
				{
					num7 = 1330227591;
					num8 = num7;
				}
				else
				{
					num7 = 1308261897;
					num8 = num7;
				}
				num = num7 ^ (int)(num3 * 328910839);
				continue;
			}
			case 6u:
				goto IL_00c4;
			case 3u:
				return 0;
			case 8u:
				return (int)((double)antiLagAllyPlayerSize / 100.0 * (double)num4);
			case 4u:
				goto IL_0142;
			case 13u:
			{
				int num9;
				int num10;
				if (!Settings.Default.AntiLagHideAllyPets)
				{
					num9 = 1864644159;
					num10 = num9;
				}
				else
				{
					num9 = 436857234;
					num10 = num9;
				}
				num = num9 ^ ((int)num3 * -1082047094);
				continue;
			}
			case 2u:
				goto IL_018d;
			case 12u:
				goto IL_01b0;
			case 0u:
			{
				int num5;
				int num6;
				if (!antiLagApplyToGuildMates)
				{
					num5 = -1315098521;
					num6 = num5;
				}
				else
				{
					num5 = -52158516;
					num6 = num5;
				}
				num = num5 ^ ((int)num3 * -1848561305);
				continue;
			}
			case 11u:
				return num4;
			default:
				return _kGGu3Lri5FWVdDmWIhivvRjNI8C[objectId];
			}
			break;
			IL_018d:
			int num11;
			if (string.IsNullOrEmpty(jI4Bueou7dItYp5S7QML5vyC6Rc._ROI49ai7g89LZTXhpoAd3C7Qa4I))
			{
				num11 = 0;
				goto IL_00e2;
			}
			num = (int)(num3 * 505869908) ^ -1023120466;
			continue;
			IL_00c4:
			num11 = ((jI4Bueou7dItYp5S7QML5vyC6Rc._ROI49ai7g89LZTXhpoAd3C7Qa4I == _50w8wVuv8bL5nhKaR2EHxjrTamB._PlayerData._ROI49ai7g89LZTXhpoAd3C7Qa4I) ? 1 : 0);
			goto IL_00e2;
			IL_00e2:
			antiLagApplyToGuildMates = Settings.Default.AntiLagApplyToGuildMates;
			antiLagAllyPlayerSize = Settings.Default.AntiLagAllyPlayerSize;
			num4 = _kGGu3Lri5FWVdDmWIhivvRjNI8C[objectId];
			int num12;
			if (num11 != 0)
			{
				num = -2056164026;
				num12 = num;
			}
			else
			{
				num = -931832788;
				num12 = num;
			}
			continue;
			IL_0142:
			int num13;
			if (Settings.Default.AntiLagAllyPlayerSize == 100)
			{
				num = -2069248551;
				num13 = num;
			}
			else
			{
				num = -236123071;
				num13 = num;
			}
		}
		goto IL_001d;
		IL_001d:
		num = -758205690;
		goto IL_0022;
	}

	private void _KQrCDNrUysA4qKaWspdpLvKfrZf(Status status)
	{
		using List<StatData>.Enumerator enumerator = status._Stats.GetEnumerator();
		StatData current = default(StatData);
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = -944982043;
				num2 = num;
			}
			else
			{
				num = -1784025007;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0xB331DFFDu) % 9u)
				{
				case 2u:
					num = -944982043;
					continue;
				default:
					return;
				case 0u:
					break;
				case 5u:
				{
					int num6;
					int num7;
					if (_kGGu3Lri5FWVdDmWIhivvRjNI8C.ContainsKey(status._ObjectId))
					{
						num6 = 188110050;
						num7 = num6;
					}
					else
					{
						num6 = 1314723798;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -1354571639);
					continue;
				}
				case 1u:
					_kGGu3Lri5FWVdDmWIhivvRjNI8C[status._ObjectId] = current._StatValue;
					num = ((int)num3 * -124848994) ^ 0x5E5F7C04;
					continue;
				case 8u:
				{
					current = enumerator.Current;
					int num8;
					if (!StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType._zMlSnmW3LLSxr4x3sZAbRbWfh8Y))
					{
						num = -306783742;
						num8 = num;
					}
					else
					{
						num = -2052494855;
						num8 = num;
					}
					continue;
				}
				case 7u:
					current._StatValue = _EVhCC0ekBrEVLjZ30fXud3hsfYm(status._ObjectId);
					num = (int)(num3 * 137401864) ^ -1565657382;
					continue;
				case 3u:
				{
					int num4;
					int num5;
					if (Settings.Default.AntiLagAllyPlayerSize != 100)
					{
						num4 = -547961178;
						num5 = num4;
					}
					else
					{
						num4 = -1752154676;
						num5 = num4;
					}
					num = num4 ^ ((int)num3 * -371768438);
					continue;
				}
				case 6u:
					return;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _bXBAQSQDuRQKpJb0pK866XdaUHU(string name, string guild)
	{
		using Dictionary<int, PlayerData>.Enumerator enumerator = _50w8wVuv8bL5nhKaR2EHxjrTamB._naDcMlPfaanTh6qrJ3cOuO4HNwz.GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = -1775613228;
				num2 = num;
			}
			else
			{
				num = -1491293608;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x82C489BDu) % 5u)
				{
				case 4u:
					num = -1491293608;
					continue;
				default:
					return;
				case 2u:
				{
					int num4;
					if (!(enumerator.Current.Value._WL2DOBxBuX9DARzf2KPoaJbgZiCb.ToLower() != name))
					{
						num = -1710328473;
						num4 = num;
					}
					else
					{
						num = -1420393266;
						num4 = num;
					}
					continue;
				}
				case 0u:
					break;
				case 1u:
					_74KKKuVtZqkVRDxOFUQeDoXCmfJ = true;
					return;
				case 3u:
					return;
				}
				break;
			}
		}
	}
}
