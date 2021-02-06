using System;
using System.Collections.Generic;
using System.Linq;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.DataStructures;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class _I5hBdMHPSeVO0cbuEcAkM9I29MW
{
	private _PlferqYaObizDfc28C5jdKSLGq5 _50w8wVuv8bL5nhKaR2EHxjrTamB;

	private int _42GPN9YDdixtPULe0BHbgMev6eG = -1;

	private bool _InVault;

	private int _MxPohOQBsrS7YWq61BQhRKSU0Qp = -1;

	private int _9Enr6MJLTc4k9eX6JGLbNLMoPXI = -1;

	private int _EeeRzHBDOL9AqYJ8CIuFvkR3Qlz = -1;

	private int _SQACGHTv1WEjcrxihqkj62R5YfQ = -1;

	private WorldPosData _LAY5qDOXeCwwE8WGSZkOMs9oNKh = WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R;

	private int _neZM1USbaZsslUXWTqLzRHjLKGB;

	private Dictionary<int, DateTime> _n0qimu2AfjwQPWpCgZS0Cw246jV = new Dictionary<int, DateTime>();

	private static readonly string[] _YklRoz0i3h76trZ31S7qcvcZ74C = new string[25]
	{
		"Mystery Stat Pot",
		"Potion of Life",
		"Potion of Mana",
		"Potion of Defense",
		"Potion of Speed",
		"Potion of Attack",
		"Potion of Dexterity",
		"Potion of Wisdom",
		"Potion of Vitality",
		"Potion of Life (SB)",
		"Potion of Mana (SB)",
		"Potion of Defense (SB)",
		"Potion of Speed (SB)",
		"Potion of Attack (SB)",
		"Potion of Dexterity (SB)",
		"Potion of Wisdom (SB)",
		"Potion of Vitality (SB)",
		"Greater Potion of Life",
		"Greater Potion of Mana",
		"Greater Potion of Defense",
		"Greater Potion of Speed",
		"Greater Potion of Attack",
		"Greater Potion of Dexterity",
		"Greater Potion of Wisdom",
		"Greater Potion of Vitality"
	};

	public _I5hBdMHPSeVO0cbuEcAkM9I29MW(_PlferqYaObizDfc28C5jdKSLGq5 client)
	{
		_50w8wVuv8bL5nhKaR2EHxjrTamB = client;
	}

	public void _DT5vfLbxw23gMixKpQ7yxEiQkEe(MapInfoPacket mapInfo)
	{
		_InVault = mapInfo._MapName.ToLower().Contains("vault");
	}

	public void _73wAP4ozRO5hPRsKKuqzMgWaCqD(QuestObjectPacket questObjId)
	{
		_EeeRzHBDOL9AqYJ8CIuFvkR3Qlz = questObjId._fn2CRnBpjyTWHR9K8SU4iOwhDtK;
	}

	public void _emTnZmGyChlXH4IDm60126G1Snf(UpdatePacket update)
	{
		//Discarded unreachable code: IL_0129
		if (_SQACGHTv1WEjcrxihqkj62R5YfQ != -1)
		{
			goto IL_000c;
		}
		goto IL_013c;
		IL_013c:
		GameObject[] lakUpSXZB1zdJcCECL20tl6SVrT = update._NewObjects;
		int num = -964214136;
		goto IL_0011;
		IL_0011:
		int num10 = default(int);
		GameObject gameObject = default(GameObject);
		StatData current = default(StatData);
		while (true)
		{
			int num9;
			uint num2;
			switch ((num2 = (uint)num ^ 0xF68A32C7u) % 11u)
			{
			case 4u:
				break;
			case 5u:
			{
				int num11;
				int num12;
				if (_EeeRzHBDOL9AqYJ8CIuFvkR3Qlz == -1)
				{
					num11 = 1472454504;
					num12 = num11;
				}
				else
				{
					num11 = 1460708249;
					num12 = num11;
				}
				num = num11 ^ ((int)num2 * -611274647);
				continue;
			}
			case 6u:
				if (Settings.Default.AutoLootBigBags)
				{
					num = (int)(num2 * 1818728435) ^ -759706023;
					continue;
				}
				goto IL_025d;
			case 2u:
				num10 = 0;
				num = ((int)num2 * -917450031) ^ -1912510840;
				continue;
			case 10u:
				_SQACGHTv1WEjcrxihqkj62R5YfQ = -1;
				num = ((int)num2 * -817820733) ^ -813859268;
				continue;
			case 0u:
				gameObject = lakUpSXZB1zdJcCECL20tl6SVrT[num10];
				if (Enum.IsDefined(typeof(_5097dNG31hfxaENwC9LeZFiVozC), gameObject._ObjectType))
				{
					num = -667193173;
					continue;
				}
				goto IL_02af;
			case 1u:
			{
				int num7;
				int num8;
				if (!update._Drops.Contains(_SQACGHTv1WEjcrxihqkj62R5YfQ))
				{
					num7 = -64151420;
					num8 = num7;
				}
				else
				{
					num7 = -1385558894;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -965406772);
				continue;
			}
			case 9u:
				goto IL_013c;
			case 7u:
			{
				QuestObjectPacket questObjectPacket = (QuestObjectPacket)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.QUESTOBJID);
				questObjectPacket._fn2CRnBpjyTWHR9K8SU4iOwhDtK = _EeeRzHBDOL9AqYJ8CIuFvkR3Qlz;
				questObjectPacket._0m8NlaV4OCNiAPRjFijgkuWdRKi = new int[0];
				_50w8wVuv8bL5nhKaR2EHxjrTamB._xRCQ3Y8enVTevEwMAZe8WUmANbE(questObjectPacket);
				num = ((int)num2 * -2086895828) ^ -1766803272;
				continue;
			}
			default:
			{
				using (List<StatData>.Enumerator enumerator = gameObject._gVz37u8P9es5e8QAguAJW13BAYh._Stats.GetEnumerator())
				{
					while (true)
					{
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = -1331695544;
							num4 = num3;
						}
						else
						{
							num3 = -1968330361;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0xF68A32C7u) % 6u)
							{
							case 3u:
								num3 = -1968330361;
								continue;
							default:
								goto end_IL_01a3;
							case 2u:
								break;
							case 1u:
							{
								int num5;
								int num6;
								if (!StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType._zMlSnmW3LLSxr4x3sZAbRbWfh8Y))
								{
									num5 = 1637602157;
									num6 = num5;
								}
								else
								{
									num5 = 1900896129;
									num6 = num5;
								}
								num3 = num5 ^ (int)(num2 * 1715270400);
								continue;
							}
							case 0u:
								current._StatValue = 175;
								num3 = ((int)num2 * -646438638) ^ -1480935807;
								continue;
							case 4u:
								current = enumerator.Current;
								num3 = -365262058;
								continue;
							case 5u:
								goto end_IL_01a3;
							}
							break;
						}
					}
					end_IL_01a3:;
				}
				goto IL_025d;
			}
			case 8u:
				goto IL_033f;
				IL_0279:
				num9 = -462018339;
				goto IL_027e;
				IL_033f:
				if (num10 < lakUpSXZB1zdJcCECL20tl6SVrT.Length)
				{
					goto case 0u;
				}
				num9 = -128843282;
				goto IL_027e;
				IL_025d:
				if (Enum.IsDefined(typeof(_f3qpQzCY0N0Jz5kd9DSZHQj0ZJG), gameObject._ObjectType))
				{
					goto IL_0279;
				}
				goto IL_02af;
				IL_02af:
				num10++;
				num9 = -574987748;
				goto IL_027e;
				IL_027e:
				while (true)
				{
					switch ((num2 = (uint)num9 ^ 0xF68A32C7u) % 7u)
					{
					case 2u:
						break;
					default:
						return;
					case 0u:
						goto IL_02af;
					case 3u:
						_n0qimu2AfjwQPWpCgZS0Cw246jV.Add(gameObject._gVz37u8P9es5e8QAguAJW13BAYh._ObjectId, DateTime.Now);
						num9 = -1236650401;
						continue;
					case 4u:
						_n0qimu2AfjwQPWpCgZS0Cw246jV[gameObject._gVz37u8P9es5e8QAguAJW13BAYh._ObjectId] = DateTime.Now;
						num9 = (int)(num2 * 1345194878) ^ -786679427;
						continue;
					case 1u:
					{
						int num13;
						int num14;
						if (!_n0qimu2AfjwQPWpCgZS0Cw246jV.ContainsKey(gameObject._gVz37u8P9es5e8QAguAJW13BAYh._ObjectId))
						{
							num13 = 755020099;
							num14 = num13;
						}
						else
						{
							num13 = 1384537790;
							num14 = num13;
						}
						num9 = num13 ^ ((int)num2 * -762417577);
						continue;
					}
					case 6u:
						goto IL_033f;
					case 5u:
						return;
					}
					break;
				}
				goto IL_0279;
			}
			break;
		}
		goto IL_000c;
		IL_000c:
		num = -2014815880;
		goto IL_0011;
	}

	public void _kcBjTzBYfTPCpKNctSQjw45y1mb(NewTickPacket newTick)
	{
		using List<Status>.Enumerator enumerator = newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.GetEnumerator();
		PlayerData value = default(PlayerData);
		Status current = default(Status);
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = -949578463;
				num2 = num;
			}
			else
			{
				num = -896104631;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x87FA89AAu) % 10u)
				{
				case 0u:
					num = -896104631;
					continue;
				default:
					return;
				case 8u:
				{
					int num6;
					int num7;
					if (_n0qimu2AfjwQPWpCgZS0Cw246jV.ContainsKey(value._fn2CRnBpjyTWHR9K8SU4iOwhDtK))
					{
						num6 = 1359238576;
						num7 = num6;
					}
					else
					{
						num6 = 785598518;
						num7 = num6;
					}
					num = num6 ^ ((int)num3 * -1027123060);
					continue;
				}
				case 2u:
					_n0qimu2AfjwQPWpCgZS0Cw246jV.Add(value._fn2CRnBpjyTWHR9K8SU4iOwhDtK, DateTime.Now);
					num = -663950877;
					continue;
				case 5u:
				{
					int num8;
					int num9;
					if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._VPArsrlUa0uEsW6OxAYV9WHJAMK.TryGetValue(current._ObjectId, out value))
					{
						num8 = -1211396880;
						num9 = num8;
					}
					else
					{
						num8 = -1985839972;
						num9 = num8;
					}
					num = num8 ^ (int)(num3 * 2039570447);
					continue;
				}
				case 4u:
					num = (int)(num3 * 1662030606) ^ -1862317609;
					continue;
				case 6u:
					_n0qimu2AfjwQPWpCgZS0Cw246jV[value._fn2CRnBpjyTWHR9K8SU4iOwhDtK] = DateTime.Now;
					num = ((int)num3 * -1642372414) ^ 0x67A2DE18;
					continue;
				case 9u:
					break;
				case 3u:
				{
					int num4;
					int num5;
					if (Enum.IsDefined(typeof(_f3qpQzCY0N0Jz5kd9DSZHQj0ZJG), value._y2nCjecGeYsmqDEzaplcuBvYtN7))
					{
						num4 = 1625238494;
						num5 = num4;
					}
					else
					{
						num4 = 634299473;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 193537866);
					continue;
				}
				case 1u:
					current = enumerator.Current;
					num = -1855951081;
					continue;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	public void _1UIxXEL495RF9327ls9jIZFBwaA(_QVbPZZRiBkqcm6oZy5pZrM4S8aD invSwap)
	{
		//Discarded unreachable code: IL_0309
		if (!Settings.Default.EnableAutoLoot)
		{
			goto IL_000f;
		}
		goto IL_00b7;
		IL_00b7:
		int num;
		int num2;
		if (invSwap._IBSqBdwNTiXSzhZbDhEFMC0Gc51 - _42GPN9YDdixtPULe0BHbgMev6eG < 500)
		{
			num = -1911039927;
			num2 = num;
		}
		else
		{
			num = -1381010118;
			num2 = num;
		}
		goto IL_0014;
		IL_0014:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x8C3DB18Fu) % 18u)
			{
			case 16u:
				break;
			default:
				return;
			case 15u:
				_MxPohOQBsrS7YWq61BQhRKSU0Qp = invSwap._YnPcTOJB6UrXk2tL1AzY4w0ohpAA._SlotId;
				num = (int)((num3 * 347054475) ^ 0x6E4A593A);
				continue;
			case 12u:
				goto IL_0091;
			case 1u:
				goto IL_00b7;
			case 10u:
				num = (int)(num3 * 1235423821) ^ -1532260034;
				continue;
			case 14u:
				invSwap._Send = false;
				num = (int)((num3 * 733352587) ^ 0x771AD9C8);
				continue;
			case 13u:
				goto IL_010a;
			case 6u:
			{
				int num10;
				int num11;
				if (invSwap._YnPcTOJB6UrXk2tL1AzY4w0ohpAA._SlotId < _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory.Length)
				{
					num10 = -478054642;
					num11 = num10;
				}
				else
				{
					num10 = -1993238406;
					num11 = num10;
				}
				num = num10 ^ (int)(num3 * 2115485219);
				continue;
			}
			case 3u:
				_MxPohOQBsrS7YWq61BQhRKSU0Qp = invSwap._sEYqjeelWD912mJ6sF5MhQRyISf._SlotId;
				_9Enr6MJLTc4k9eX6JGLbNLMoPXI = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[invSwap._sEYqjeelWD912mJ6sF5MhQRyISf._SlotId];
				num = (int)((num3 * 829741262) ^ 0x305C739C);
				continue;
			case 9u:
			{
				int num6;
				int num7;
				if (invSwap._sEYqjeelWD912mJ6sF5MhQRyISf._SlotId >= _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory.Length)
				{
					num6 = -2106374214;
					num7 = num6;
				}
				else
				{
					num6 = -225255701;
					num7 = num6;
				}
				num = num6 ^ (int)(num3 * 1308544851);
				continue;
			}
			case 5u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[invSwap._sEYqjeelWD912mJ6sF5MhQRyISf._SlotId] = invSwap._sEYqjeelWD912mJ6sF5MhQRyISf._ObjectType;
				num = (int)((num3 * 1908031069) ^ 0x5AFB37CB);
				continue;
			case 0u:
			{
				int num8;
				int num9;
				if (invSwap._sEYqjeelWD912mJ6sF5MhQRyISf._ObjectId != _50w8wVuv8bL5nhKaR2EHxjrTamB._fn2CRnBpjyTWHR9K8SU4iOwhDtK)
				{
					num8 = -858456223;
					num9 = num8;
				}
				else
				{
					num8 = -476484210;
					num9 = num8;
				}
				num = num8 ^ (int)(num3 * 1773945142);
				continue;
			}
			case 11u:
				Program._JWptdPwuTlZYlLpGrinhw8DeS3h("client", "Canceled invswap!");
				num = (int)(num3 * 667110378) ^ -877287859;
				continue;
			case 8u:
			{
				int num4;
				int num5;
				if (invSwap._YnPcTOJB6UrXk2tL1AzY4w0ohpAA._ObjectId != _50w8wVuv8bL5nhKaR2EHxjrTamB._fn2CRnBpjyTWHR9K8SU4iOwhDtK)
				{
					num4 = 1151232894;
					num5 = num4;
				}
				else
				{
					num4 = 703242563;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -1478705669);
				continue;
			}
			case 2u:
				_9Enr6MJLTc4k9eX6JGLbNLMoPXI = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[invSwap._YnPcTOJB6UrXk2tL1AzY4w0ohpAA._SlotId];
				_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[invSwap._YnPcTOJB6UrXk2tL1AzY4w0ohpAA._SlotId] = invSwap._YnPcTOJB6UrXk2tL1AzY4w0ohpAA._ObjectType;
				num = (int)((num3 * 737627624) ^ 0xE51C9FE);
				continue;
			case 4u:
				return;
			case 7u:
				_42GPN9YDdixtPULe0BHbgMev6eG = invSwap._IBSqBdwNTiXSzhZbDhEFMC0Gc51;
				num = -343738112;
				continue;
			case 17u:
				return;
			}
			break;
			IL_010a:
			int num12;
			if (invSwap._sEYqjeelWD912mJ6sF5MhQRyISf._SlotId < 1000000)
			{
				num = -283615335;
				num12 = num;
			}
			else
			{
				num = -1521536571;
				num12 = num;
			}
			continue;
			IL_0091:
			int num13;
			if (invSwap._YnPcTOJB6UrXk2tL1AzY4w0ohpAA._SlotId < 1000000)
			{
				num = -2027741953;
				num13 = num;
			}
			else
			{
				num = -306063442;
				num13 = num;
			}
		}
		goto IL_000f;
		IL_000f:
		num = -1349861559;
		goto IL_0014;
	}

	public void _n0JAIElTXMoPeH6KBaRBdWaaWov(_lRcj7b0Xq67vwsbjqopaQvHrEiC invResult)
	{
		if (!Settings.Default.EnableAutoLoot)
		{
			return;
		}
		while (true)
		{
			int num = -1876156791;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDAE41FF0u) % 5u)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
					_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[_MxPohOQBsrS7YWq61BQhRKSU0Qp] = _9Enr6MJLTc4k9eX6JGLbNLMoPXI;
					Program._JWptdPwuTlZYlLpGrinhw8DeS3h("client", "Swap failed");
					num = ((int)num2 * -951409652) ^ -462493339;
					continue;
				case 2u:
				{
					int num5;
					int num6;
					if (_MxPohOQBsrS7YWq61BQhRKSU0Qp > -1)
					{
						num5 = 2023204167;
						num6 = num5;
					}
					else
					{
						num5 = 1830165272;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -1713879221);
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (!invResult._7bgQ9tATPTEeDmObXreEdLoiHz6)
					{
						num3 = -419068835;
						num4 = num3;
					}
					else
					{
						num3 = -92690977;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1909809394);
					continue;
				}
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void _tX4Fl2mBYL4XNqNEIW0OPnopM9i(_WCTbeWogZHoPyDnxles484v2oK move)
	{
		//Discarded unreachable code: IL_0058, IL_007a, IL_0125, IL_031d, IL_05dc
		if (Settings.Default.AutoLootAutoDisable)
		{
			goto IL_000c;
		}
		goto IL_005f;
		IL_005f:
		_LAY5qDOXeCwwE8WGSZkOMs9oNKh = move._r0866iEhjgniNmmLz9ygFmfaWPA;
		_neZM1USbaZsslUXWTqLzRHjLKGB = 0;
		int num = 1942262006;
		goto IL_0011;
		IL_0011:
		int num36 = default(int);
		PotionInfo potionInfo = default(PotionInfo);
		int num7 = default(int);
		DateTime now = default(DateTime);
		DateTime value = default(DateTime);
		int num18 = default(int);
		QuestObjectPacket questObjectPacket = default(QuestObjectPacket);
		PlayerData current = default(PlayerData);
		byte b = default(byte);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x53EFC85Fu) % 12u)
			{
			case 6u:
				break;
			case 11u:
				return;
			case 3u:
				goto IL_005f;
			case 0u:
				return;
			case 8u:
			{
				int num41;
				int num42;
				if (num36 > 100)
				{
					num41 = 2101044883;
					num42 = num41;
				}
				else
				{
					num41 = 680715798;
					num42 = num41;
				}
				num = num41 ^ (int)(num2 * 598706255);
				continue;
			}
			case 9u:
			{
				int num39;
				int num40;
				if (_InVault)
				{
					num39 = 1410856973;
					num40 = num39;
				}
				else
				{
					num39 = 533921340;
					num40 = num39;
				}
				num = num39 ^ (int)(num2 * 2125096757);
				continue;
			}
			case 10u:
			{
				int num37;
				int num38;
				if (!move._r0866iEhjgniNmmLz9ygFmfaWPA.Equals(_LAY5qDOXeCwwE8WGSZkOMs9oNKh))
				{
					num37 = 577873184;
					num38 = num37;
				}
				else
				{
					num37 = 840778018;
					num38 = num37;
				}
				num = num37 ^ ((int)num2 * -1429474404);
				continue;
			}
			case 1u:
				num36 = _neZM1USbaZsslUXWTqLzRHjLKGB++;
				num = (int)((num2 * 1350593855) ^ 0x2A618AD4);
				continue;
			case 7u:
				return;
			case 2u:
				goto IL_0138;
			case 5u:
				goto IL_0160;
			default:
			{
				using List<PlayerData>.Enumerator enumerator = _50w8wVuv8bL5nhKaR2EHxjrTamB._VPArsrlUa0uEsW6OxAYV9WHJAMK.Values.ToList().GetEnumerator();
				while (true)
				{
					int num3;
					int num4;
					if (enumerator.MoveNext())
					{
						num3 = 1564155322;
						num4 = num3;
					}
					else
					{
						num3 = 1315190775;
						num4 = num3;
					}
					while (true)
					{
						object obj;
						string itemName;
						switch ((num2 = (uint)num3 ^ 0x53EFC85Fu) % 35u)
						{
						case 31u:
							num3 = 1564155322;
							continue;
						default:
							return;
						case 19u:
						{
							int num34;
							int num35;
							if (!Settings.Default.AutoLootQuests)
							{
								num34 = 352350719;
								num35 = num34;
							}
							else
							{
								num34 = 1467797966;
								num35 = num34;
							}
							num3 = num34 ^ (int)(num2 * 50561209);
							continue;
						}
						case 29u:
						{
							int num23;
							int num24;
							if (potionInfo.Type != num7)
							{
								num23 = 389793868;
								num24 = num23;
							}
							else
							{
								num23 = 1641071758;
								num24 = num23;
							}
							num3 = num23 ^ (int)(num2 * 2108559960);
							continue;
						}
						case 34u:
							if (potionInfo.Type != -1)
							{
								num3 = (int)((num2 * 1641091099) ^ 0x45E72BD3);
								continue;
							}
							obj = "Empty";
							goto IL_056a;
						case 22u:
						{
							int num21;
							int num22;
							if (num7 != 2595)
							{
								num21 = 1824600633;
								num22 = num21;
							}
							else
							{
								num21 = 171493883;
								num22 = num21;
							}
							num3 = num21 ^ (int)(num2 * 1548795794);
							continue;
						}
						case 33u:
						{
							int num28;
							int num29;
							if (now.Subtract(value) < TimeSpan.FromSeconds(2.0))
							{
								num28 = 765640364;
								num29 = num28;
							}
							else
							{
								num28 = 1447699839;
								num29 = num28;
							}
							num3 = num28 ^ (int)(num2 * 542219831);
							continue;
						}
						case 13u:
							return;
						case 32u:
							break;
						case 15u:
						{
							int num14;
							int num15;
							if (Settings.Default.AutoLootDelay)
							{
								num14 = 370192329;
								num15 = num14;
							}
							else
							{
								num14 = 1457891934;
								num15 = num14;
							}
							num3 = num14 ^ (int)(num2 * 1965727055);
							continue;
						}
						case 16u:
							num18 = 0;
							num3 = 1200158171;
							continue;
						case 20u:
							_50w8wVuv8bL5nhKaR2EHxjrTamB._xRCQ3Y8enVTevEwMAZe8WUmANbE(questObjectPacket);
							num3 = (int)(num2 * 1757360851) ^ -1149050066;
							continue;
						case 21u:
						{
							int num33;
							if (num18 < _50w8wVuv8bL5nhKaR2EHxjrTamB._nhFLD7A5r9NSgescGUZ6OSUXLbm.Length)
							{
								num3 = 826456472;
								num33 = num3;
							}
							else
							{
								num3 = 1384739745;
								num33 = num3;
							}
							continue;
						}
						case 1u:
							now = DateTime.Now;
							num3 = ((int)num2 * -1384887301) ^ 0x4FAD7D3E;
							continue;
						case 28u:
						{
							current = enumerator.Current;
							int num30;
							if (Enum.IsDefined(typeof(_5097dNG31hfxaENwC9LeZFiVozC), current._y2nCjecGeYsmqDEzaplcuBvYtN7))
							{
								num3 = 389754700;
								num30 = num3;
							}
							else
							{
								num3 = 747609682;
								num30 = num3;
							}
							continue;
						}
						case 6u:
							b = (byte)(b + 1);
							num3 = 1154773415;
							continue;
						case 26u:
							potionInfo = _50w8wVuv8bL5nhKaR2EHxjrTamB._nhFLD7A5r9NSgescGUZ6OSUXLbm[num18];
							num3 = 1737119123;
							continue;
						case 0u:
						{
							int num16;
							int num17;
							if (!(current._IlcbhoOIM3MRszn9mfn3IKjnXc0._l97JYrnBrV9Ws5bD3UnHa879cYh(move._r0866iEhjgniNmmLz9ygFmfaWPA) <= 1.0))
							{
								num16 = -934589859;
								num17 = num16;
							}
							else
							{
								num16 = -1954481643;
								num17 = num16;
							}
							num3 = num16 ^ (int)(num2 * 1029247637);
							continue;
						}
						case 30u:
						{
							int num11;
							if (b < current.Inventory.Length)
							{
								num3 = 248122269;
								num11 = num3;
							}
							else
							{
								num3 = 747609682;
								num11 = num3;
							}
							continue;
						}
						case 17u:
							_NMw4OIVxhTN9fUngXKgxLJ9AFdO(move._r0866iEhjgniNmmLz9ygFmfaWPA, move._IBSqBdwNTiXSzhZbDhEFMC0Gc51, current._fn2CRnBpjyTWHR9K8SU4iOwhDtK, num7, b);
							num3 = 1989783224;
							continue;
						case 24u:
						{
							int num8;
							if (!_MTkqZ37d4ONVGDoas85KliOhxXk((ushort)num7))
							{
								num3 = 1313727114;
								num8 = num3;
							}
							else
							{
								num3 = 1623812321;
								num8 = num3;
							}
							continue;
						}
						case 27u:
						{
							int num31;
							int num32;
							if (!Settings.Default.AutoLootHealingPotions)
							{
								num31 = 1727727545;
								num32 = num31;
							}
							else
							{
								num31 = 652513355;
								num32 = num31;
							}
							num3 = num31 ^ ((int)num2 * -488357420);
							continue;
						}
						case 7u:
							num18++;
							num3 = 1200158171;
							continue;
						case 8u:
						{
							int num26;
							int num27;
							if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._pbFyfQwvTw34WwXte62AuhPzJDi)
							{
								num26 = -949260334;
								num27 = num26;
							}
							else
							{
								num26 = -1309306478;
								num27 = num26;
							}
							num3 = num26 ^ (int)(num2 * 245646942);
							continue;
						}
						case 18u:
							obj = ResourceDownloader._3ndzvDGHhvqls1BD8vzizSQBDdI._EOUVvVncv0meCCDQkGXOyUOLU5F((ushort)potionInfo.Type)._WL2DOBxBuX9DARzf2KPoaJbgZiCb;
							goto IL_056a;
						case 3u:
						{
							int num25;
							if (num18 == 2)
							{
								num3 = 1042799726;
								num25 = num3;
							}
							else
							{
								num3 = 1695260716;
								num25 = num3;
							}
							continue;
						}
						case 23u:
							return;
						case 25u:
							questObjectPacket = (QuestObjectPacket)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.QUESTOBJID);
							questObjectPacket._fn2CRnBpjyTWHR9K8SU4iOwhDtK = current._fn2CRnBpjyTWHR9K8SU4iOwhDtK;
							questObjectPacket._0m8NlaV4OCNiAPRjFijgkuWdRKi = new int[0];
							num3 = ((int)num2 * -991640481) ^ -908211324;
							continue;
						case 5u:
						{
							int num19;
							int num20;
							if (_n0qimu2AfjwQPWpCgZS0Cw246jV.TryGetValue(current._fn2CRnBpjyTWHR9K8SU4iOwhDtK, out value))
							{
								num19 = -1278735017;
								num20 = num19;
							}
							else
							{
								num19 = -2054684424;
								num20 = num19;
							}
							num3 = num19 ^ (int)(num2 * 703618981);
							continue;
						}
						case 14u:
							num7 = current.Inventory[b];
							num3 = 1988520376;
							continue;
						case 10u:
							_SQACGHTv1WEjcrxihqkj62R5YfQ = current._fn2CRnBpjyTWHR9K8SU4iOwhDtK;
							num3 = ((int)num2 * -1873862693) ^ 0x3E6D5FE4;
							continue;
						case 2u:
							b = 0;
							num3 = 1154773415;
							continue;
						case 9u:
						{
							int num12;
							int num13;
							if (num7 == -1)
							{
								num12 = -998331381;
								num13 = num12;
							}
							else
							{
								num12 = -2094756112;
								num13 = num12;
							}
							num3 = num12 ^ (int)(num2 * 1980845911);
							continue;
						}
						case 12u:
						{
							int num9;
							int num10;
							if (num7 == 2594)
							{
								num9 = -2125611037;
								num10 = num9;
							}
							else
							{
								num9 = -1751447629;
								num10 = num9;
							}
							num3 = num9 ^ (int)(num2 * 2124162208);
							continue;
						}
						case 4u:
						{
							int num5;
							int num6;
							if (potionInfo.Quantity >= 6)
							{
								num5 = -1515358469;
								num6 = num5;
							}
							else
							{
								num5 = -1886692349;
								num6 = num5;
							}
							num3 = num5 ^ ((int)num2 * -1470911481);
							continue;
						}
						case 11u:
							return;
							IL_056a:
							itemName = (string)obj;
							_1UIxXEL495RF9327ls9jIZFBwaA(move._IBSqBdwNTiXSzhZbDhEFMC0Gc51, move._r0866iEhjgniNmmLz9ygFmfaWPA, current._fn2CRnBpjyTWHR9K8SU4iOwhDtK, num7, b, _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC, potionInfo.Type, 1000000 + num18, itemName);
							_50w8wVuv8bL5nhKaR2EHxjrTamB._QtBizqH8aHz2ixkvUsA6VqqwHGF = Environment.TickCount;
							num3 = 1986998801;
							continue;
						}
						break;
					}
				}
			}
			}
			break;
			IL_0160:
			int num43;
			if (!Settings.Default.EnableAutoLoot)
			{
				num = 182659420;
				num43 = num;
			}
			else
			{
				num = 631591282;
				num43 = num;
			}
			continue;
			IL_0138:
			int num44;
			if (move._IBSqBdwNTiXSzhZbDhEFMC0Gc51 - _42GPN9YDdixtPULe0BHbgMev6eG >= 600)
			{
				num = 1101153319;
				num44 = num;
			}
			else
			{
				num = 231972616;
				num44 = num;
			}
		}
		goto IL_000c;
		IL_000c:
		num = 1711897385;
		goto IL_0011;
	}

	private void _NMw4OIVxhTN9fUngXKgxLJ9AFdO(WorldPosData pos, int time, int bagObjectId, int targetType, byte slotId, int potionSlot = -1)
	{
		//Discarded unreachable code: IL_007e, IL_00e8
		if (potionSlot >= 1000000)
		{
			goto IL_000c;
		}
		goto IL_00fa;
		IL_00fa:
		int num;
		if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._w7Hkwdl5YCJEhcTaAQbT3b6hN8G)
		{
			num = -1721811892;
			goto IL_0011;
		}
		int num2 = 20;
		goto IL_012b;
		IL_0125:
		num2 = 12;
		goto IL_012b;
		IL_000c:
		num = -982766269;
		goto IL_0011;
		IL_012b:
		int num3 = num2;
		byte b = 4;
		num = -297837162;
		goto IL_0011;
		IL_0011:
		while (true)
		{
			uint num4;
			switch ((num4 = (uint)num ^ 0x85DED355u) % 9u)
			{
			case 7u:
				break;
			default:
				return;
			case 8u:
				_1UIxXEL495RF9327ls9jIZFBwaA(time, pos, bagObjectId, targetType, slotId, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fn2CRnBpjyTWHR9K8SU4iOwhDtK, targetType, potionSlot, ResourceDownloader._3ndzvDGHhvqls1BD8vzizSQBDdI._EOUVvVncv0meCCDQkGXOyUOLU5F((ushort)targetType)._WL2DOBxBuX9DARzf2KPoaJbgZiCb);
				return;
			case 0u:
				goto IL_008d;
			case 2u:
				_1UIxXEL495RF9327ls9jIZFBwaA(time, pos, bagObjectId, targetType, slotId, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fn2CRnBpjyTWHR9K8SU4iOwhDtK, -1, b, ResourceDownloader._3ndzvDGHhvqls1BD8vzizSQBDdI._EOUVvVncv0meCCDQkGXOyUOLU5F((ushort)targetType)._WL2DOBxBuX9DARzf2KPoaJbgZiCb);
				return;
			case 3u:
				goto IL_00fa;
			case 5u:
				b = (byte)(b + 1);
				num = -297837162;
				continue;
			case 4u:
				goto IL_0125;
			case 6u:
				goto IL_0138;
			case 1u:
				return;
			}
			break;
			IL_0138:
			int num5;
			if (b >= num3)
			{
				num = -696467234;
				num5 = num;
			}
			else
			{
				num = -80507404;
				num5 = num;
			}
			continue;
			IL_008d:
			int num6;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[b] != -1)
			{
				num = -903711151;
				num6 = num;
			}
			else
			{
				num = -638185177;
				num6 = num;
			}
		}
		goto IL_000c;
	}

	private void _1UIxXEL495RF9327ls9jIZFBwaA(int time, WorldPosData position, int objectId1, int itemType1, int slotId1, int objectId2, int itemType2, int slotId2, string itemName)
	{
		_QVbPZZRiBkqcm6oZy5pZrM4S8aD qVbPZZRiBkqcm6oZy5pZrM4S8aD = (_QVbPZZRiBkqcm6oZy5pZrM4S8aD)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.INVSWAP);
		SlotObjectData satIHTodVDCbi0PS6kYN9LHBYAE2 = default(SlotObjectData);
		SlotObjectData slotObjectData = default(SlotObjectData);
		while (true)
		{
			int num = -259765677;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7661A8Cu) % 12u)
				{
				case 6u:
					break;
				default:
					return;
				case 0u:
					num = ((int)num2 * -1248722594) ^ 0x6F8C140C;
					continue;
				case 3u:
					satIHTodVDCbi0PS6kYN9LHBYAE2 = new SlotObjectData
					{
						_ObjectId = objectId1,
						_ObjectType = itemType1,
						_SlotId = slotId1
					};
					slotObjectData = new SlotObjectData
					{
						_ObjectId = objectId2,
						_ObjectType = itemType2,
						_SlotId = slotId2
					};
					num = ((int)num2 * -277460214) ^ 0x6CC33A64;
					continue;
				case 8u:
					_42GPN9YDdixtPULe0BHbgMev6eG = time;
					_50w8wVuv8bL5nhKaR2EHxjrTamB._WEI99xvr4YqzD1PAnL2WmiBhWKJ(qVbPZZRiBkqcm6oZy5pZrM4S8aD);
					num = -997990793;
					continue;
				case 9u:
					qVbPZZRiBkqcm6oZy5pZrM4S8aD._sEYqjeelWD912mJ6sF5MhQRyISf = satIHTodVDCbi0PS6kYN9LHBYAE2;
					num = -20321210;
					continue;
				case 5u:
					qVbPZZRiBkqcm6oZy5pZrM4S8aD._ObXrbtVZcdprxclR2Ggz9jKwlp = position;
					num = ((int)num2 * -1886174151) ^ -1009503898;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (satIHTodVDCbi0PS6kYN9LHBYAE2._ObjectType != -1)
					{
						num3 = 188775891;
						num4 = num3;
					}
					else
					{
						num3 = 1267655530;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1229985689);
					continue;
				}
				case 7u:
					qVbPZZRiBkqcm6oZy5pZrM4S8aD._IBSqBdwNTiXSzhZbDhEFMC0Gc51 = time;
					num = ((int)num2 * -1702867057) ^ 0x8A32490;
					continue;
				case 11u:
					_50w8wVuv8bL5nhKaR2EHxjrTamB.sendChatNotification("AutoLoot", "Looting " + itemName);
					num = ((int)num2 * -651355170) ^ 0x7351B3B7;
					continue;
				case 4u:
					qVbPZZRiBkqcm6oZy5pZrM4S8aD._sEYqjeelWD912mJ6sF5MhQRyISf = slotObjectData;
					qVbPZZRiBkqcm6oZy5pZrM4S8aD._YnPcTOJB6UrXk2tL1AzY4w0ohpAA = satIHTodVDCbi0PS6kYN9LHBYAE2;
					num = (int)(num2 * 1596770087) ^ -448550908;
					continue;
				case 10u:
					qVbPZZRiBkqcm6oZy5pZrM4S8aD._YnPcTOJB6UrXk2tL1AzY4w0ohpAA = slotObjectData;
					num = (int)(num2 * 1419814212) ^ -2097462204;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private bool _MTkqZ37d4ONVGDoas85KliOhxXk(ushort itemId)
	{
		//Discarded unreachable code: IL_00ac, IL_00ee, IL_0155, IL_0161, IL_01e6, IL_01fa, IL_0288, IL_02f5, IL_0437, IL_048b, IL_04db
		_x0bFEWbxXdGdRfNpGQ1c34l1w5r x0bFEWbxXdGdRfNpGQ1c34l1w5r = ResourceDownloader._3ndzvDGHhvqls1BD8vzizSQBDdI._EOUVvVncv0meCCDQkGXOyUOLU5F(itemId);
		byte _8vNcgGDuWbW1NeAU33KZ6cm2n7i = default(byte);
		while (true)
		{
			int num = 914471026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5BE5D630u) % 33u)
				{
				case 20u:
					break;
				case 29u:
					return true;
				case 0u:
				{
					int num23;
					int num24;
					if (!x0bFEWbxXdGdRfNpGQ1c34l1w5r._WL2DOBxBuX9DARzf2KPoaJbgZiCb.Contains("Mark of "))
					{
						num23 = -1740737076;
						num24 = num23;
					}
					else
					{
						num23 = -1244849291;
						num24 = num23;
					}
					num = num23 ^ ((int)num2 * -1165143948);
					continue;
				}
				case 32u:
					return true;
				case 4u:
				{
					int num20;
					int num21;
					if (x0bFEWbxXdGdRfNpGQ1c34l1w5r != null)
					{
						num20 = -1931045532;
						num21 = num20;
					}
					else
					{
						num20 = -7382362;
						num21 = num20;
					}
					num = num20 ^ (int)(num2 * 872378550);
					continue;
				}
				case 19u:
				{
					int num16;
					if (Settings.Default.AutoLootHealingPotions)
					{
						num = 1796348510;
						num16 = num;
					}
					else
					{
						num = 814191474;
						num16 = num;
					}
					continue;
				}
				case 1u:
					return (int)x0bFEWbxXdGdRfNpGQ1c34l1w5r._NXYFTPTlBNIfValNYArFYakCddL >= Settings.Default.AutoLootAbilityTierThreshold;
				case 10u:
					return true;
				case 3u:
					num = (int)(num2 * 1089692056) ^ -146224292;
					continue;
				case 15u:
				{
					int num25;
					if (Settings.Default.AutoLootMarks)
					{
						num = 265635115;
						num25 = num;
					}
					else
					{
						num = 1877241328;
						num25 = num;
					}
					continue;
				}
				case 9u:
					_8vNcgGDuWbW1NeAU33KZ6cm2n7i = x0bFEWbxXdGdRfNpGQ1c34l1w5r._8vNcgGDuWbW1NeAU33KZ6cm2n7i;
					num = 277933057;
					continue;
				case 6u:
				{
					int num9;
					int num10;
					if (x0bFEWbxXdGdRfNpGQ1c34l1w5r._WL2DOBxBuX9DARzf2KPoaJbgZiCb == "Health Potion")
					{
						num9 = 1360833515;
						num10 = num9;
					}
					else
					{
						num9 = 1953918308;
						num10 = num9;
					}
					num = num9 ^ ((int)num2 * -1855388723);
					continue;
				}
				case 14u:
					return false;
				case 16u:
					return true;
				case 12u:
				{
					int num28;
					int num29;
					if (x0bFEWbxXdGdRfNpGQ1c34l1w5r._8vNcgGDuWbW1NeAU33KZ6cm2n7i != 10)
					{
						num28 = -622994281;
						num29 = num28;
					}
					else
					{
						num28 = -1352857178;
						num29 = num28;
					}
					num = num28 ^ (int)(num2 * 1718180163);
					continue;
				}
				case 11u:
				{
					int num18;
					int num19;
					if (!_YklRoz0i3h76trZ31S7qcvcZ74C.Contains(x0bFEWbxXdGdRfNpGQ1c34l1w5r._WL2DOBxBuX9DARzf2KPoaJbgZiCb))
					{
						num18 = 876100720;
						num19 = num18;
					}
					else
					{
						num18 = 961458417;
						num19 = num18;
					}
					num = num18 ^ ((int)num2 * -40791601);
					continue;
				}
				case 18u:
				{
					int num12;
					int num13;
					if (x0bFEWbxXdGdRfNpGQ1c34l1w5r._8vNcgGDuWbW1NeAU33KZ6cm2n7i != 26)
					{
						num12 = 1966535885;
						num13 = num12;
					}
					else
					{
						num12 = 1117294185;
						num13 = num12;
					}
					num = num12 ^ (int)(num2 * 207485949);
					continue;
				}
				case 24u:
					return true;
				case 2u:
				{
					int num5;
					int num6;
					if (x0bFEWbxXdGdRfNpGQ1c34l1w5r._NXYFTPTlBNIfValNYArFYakCddL != _WHXrbNN7BV3Ih4Lxu0Vu8UhFF8C.UT)
					{
						num5 = 759576517;
						num6 = num5;
					}
					else
					{
						num5 = 1973162577;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 245406842);
					continue;
				}
				case 7u:
				{
					int num30;
					if (!Settings.Default.AutoLootHealingPotions)
					{
						num = 1422754652;
						num30 = num;
					}
					else
					{
						num = 687300665;
						num30 = num;
					}
					continue;
				}
				case 31u:
					goto IL_02df;
				case 23u:
					switch (_8vNcgGDuWbW1NeAU33KZ6cm2n7i)
					{
					case 4:
					case 5:
					case 11:
					case 12:
					case 13:
					case 15:
					case 16:
					case 18:
					case 19:
					case 20:
					case 21:
					case 22:
					case 23:
					case 25:
					case 27:
						break;
					case 9:
						goto IL_02df;
					default:
						goto IL_0373;
					case 1:
					case 2:
					case 3:
					case 8:
					case 17:
					case 24:
						goto IL_0421;
					case 6:
					case 7:
					case 14:
						goto IL_04c5;
					case 10:
					case 26:
						goto IL_04e5;
					}
					goto case 1u;
				case 28u:
				{
					int num26;
					int num27;
					if (!x0bFEWbxXdGdRfNpGQ1c34l1w5r._WL2DOBxBuX9DARzf2KPoaJbgZiCb.EndsWith(" Egg"))
					{
						num26 = -254823292;
						num27 = num26;
					}
					else
					{
						num26 = -571122637;
						num27 = num26;
					}
					num = num26 ^ ((int)num2 * -1536117310);
					continue;
				}
				case 17u:
				{
					int num22;
					if (!Settings.Default.AutoLootStatPotions)
					{
						num = 605808879;
						num22 = num;
					}
					else
					{
						num = 1736737281;
						num22 = num;
					}
					continue;
				}
				case 30u:
				{
					int num17;
					if (!Settings.Default.AutoLootUTs)
					{
						num = 1530881595;
						num17 = num;
					}
					else
					{
						num = 1998681563;
						num17 = num;
					}
					continue;
				}
				case 27u:
				{
					int num14;
					int num15;
					if (x0bFEWbxXdGdRfNpGQ1c34l1w5r._WL2DOBxBuX9DARzf2KPoaJbgZiCb == "Magic Potion")
					{
						num14 = -1591779671;
						num15 = num14;
					}
					else
					{
						num14 = -213421737;
						num15 = num14;
					}
					num = num14 ^ (int)(num2 * 1232391283);
					continue;
				}
				case 25u:
					goto IL_0421;
				case 21u:
				{
					int num11;
					if (Settings.Default.AutoLootEggs)
					{
						num = 1823006051;
						num11 = num;
					}
					else
					{
						num = 1903949666;
						num11 = num;
					}
					continue;
				}
				case 26u:
				{
					int num7;
					int num8;
					if (!Settings.Default.AutoLootOverFillHP)
					{
						num7 = 164773399;
						num8 = num7;
					}
					else
					{
						num7 = 124782482;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 1142843385);
					continue;
				}
				case 22u:
					return true;
				case 5u:
				{
					int num3;
					int num4;
					if (!Settings.Default.AutoLootOverFillMP)
					{
						num3 = -1152641946;
						num4 = num3;
					}
					else
					{
						num3 = -1543652166;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 2141503413);
					continue;
				}
				case 13u:
					goto IL_04c5;
				default:
					goto IL_04e5;
					IL_04e5:
					return false;
					IL_04c5:
					return (int)x0bFEWbxXdGdRfNpGQ1c34l1w5r._NXYFTPTlBNIfValNYArFYakCddL >= Settings.Default.AutoLootArmorTierThreshold;
					IL_0421:
					return (int)x0bFEWbxXdGdRfNpGQ1c34l1w5r._NXYFTPTlBNIfValNYArFYakCddL >= Settings.Default.AutoLootWeaponTierThreshold;
					IL_0373:
					num = ((int)num2 * -1535610181) ^ -1909581404;
					continue;
					IL_02df:
					return (int)x0bFEWbxXdGdRfNpGQ1c34l1w5r._NXYFTPTlBNIfValNYArFYakCddL >= Settings.Default.AutoLootRingTierThreshold;
				}
				break;
			}
		}
	}
}
