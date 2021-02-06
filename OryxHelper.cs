using System.Collections.Generic;
using ExaltMultiTool;

internal class OryxHelper
{
	private const int OryxThreeType = 45363;

	private const int _LBGbKWhBUxll3Xtt3pRjiExIE2O = 8701;

	private const int _RPZhafYf8fZwNkmJFT3mZE3w06V = 8702;

	private const int _CNOzBJyyZiTc9mpYACbk6Ce1Oxx = 8703;

	private const int DammahType = 9635;

	private readonly List<string> ShieldingPhases = new List<string>
	{
		"No more! A steep price is to be paid for this brazen insolence in the face of my own grandeur!",
		"Greetings, dogged peons! I am Dammah, and I shall be your unmaker!",
		"Your uprising ends here. Lay down your feeble weapons and accept death.",
		"Do NOT interrupt me, impatient ones!",
		"I SAID DO NOT INTERRUPT ME! For this I shall hasten your end!"
	};

	private readonly List<int> OryxIgnoreTextures = new List<int>
	{
		8,
		9,
		24,
		53,
		55,
		92,
		94
	};

	private Client CurrentClient;

	private bool _InSanctuary;

	private int _Iz1POFdHlMFrJHwbDsWXXhNWElj = -1;

	private int _r7ZdM6xdXiqvbZJtINNDT2dEpAS = -1;

	private int _477CT08hnzYliCGcgisOnOsuJrd = -1;

	private int _uVJ77yndSE01nQVrPjFse5CsyYE = -1;

	private bool _ZduGw3wt7ZfTqjLJaORYdo257HE;

	private int _St84Xd2QJfrycOmAcQiCvr92mAq = -1;

	private bool _2GIxvwUGGhXZDbsdJhlfFL7Aynq;

	private int _Qi8WHb2CLkop1GCwnhQRKKIWiiG = -1;

	public OryxHelper(Client client)
	{
		while (true)
		{
			int num = -1444855683;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF5D3C5D7u) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_00d6;
				case 0u:
					return;
				}
				break;
				IL_00d6:
				CurrentClient = client;
				num = (int)(num2 * 1916784330) ^ -1523435101;
			}
		}
	}

	public void OnMapInfo(MapInfoPacket mapInfo)
	{
		_InSanctuary = mapInfo._MapName == "Oryx's Sanctuary";
	}

	public void onEnemyHit(EnemyHitPacket enemyHit)
	{
		//Discarded unreachable code: IL_00ee, IL_0295
		if (!_InSanctuary)
		{
			goto IL_000b;
		}
		goto IL_02a7;
		IL_02a7:
		int num;
		int num2;
		if (!Settings.Default.EnableO3Helper)
		{
			num = -395440101;
			num2 = num;
		}
		else
		{
			num = -1738345673;
			num2 = num;
		}
		goto IL_0010;
		IL_0010:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xE4DEEDD1u) % 20u)
			{
			case 0u:
				break;
			default:
				return;
			case 5u:
			{
				int num18;
				int num19;
				if (enemyHit._91Zhx0OBsUhlR5optw0cihxmls4 != _uVJ77yndSE01nQVrPjFse5CsyYE)
				{
					num18 = -1555264406;
					num19 = num18;
				}
				else
				{
					num18 = -1381882019;
					num19 = num18;
				}
				num = num18 ^ (int)(num3 * 1004475200);
				continue;
			}
			case 19u:
			{
				int num12;
				int num13;
				if (!_ZduGw3wt7ZfTqjLJaORYdo257HE)
				{
					num12 = -749704523;
					num13 = num12;
				}
				else
				{
					num12 = -1255241896;
					num13 = num12;
				}
				num = num12 ^ ((int)num3 * -1345244540);
				continue;
			}
			case 6u:
			{
				int num20;
				int num21;
				if (enemyHit._91Zhx0OBsUhlR5optw0cihxmls4 != _r7ZdM6xdXiqvbZJtINNDT2dEpAS)
				{
					num20 = 792036648;
					num21 = num20;
				}
				else
				{
					num20 = 116617883;
					num21 = num20;
				}
				num = num20 ^ ((int)num3 * -151603725);
				continue;
			}
			case 18u:
				return;
			case 2u:
				goto IL_0100;
			case 14u:
			{
				int num14;
				int num15;
				if (enemyHit._91Zhx0OBsUhlR5optw0cihxmls4 == _St84Xd2QJfrycOmAcQiCvr92mAq)
				{
					num14 = 684389852;
					num15 = num14;
				}
				else
				{
					num14 = 1422496709;
					num15 = num14;
				}
				num = num14 ^ ((int)num3 * -1286224999);
				continue;
			}
			case 1u:
				enemyHit._Send = false;
				num = ((int)num3 * -1569792301) ^ -2130227804;
				continue;
			case 17u:
			{
				int num8;
				int num9;
				if (_St84Xd2QJfrycOmAcQiCvr92mAq == -1)
				{
					num8 = -1434498008;
					num9 = num8;
				}
				else
				{
					num8 = -1864114507;
					num9 = num8;
				}
				num = num8 ^ ((int)num3 * -1072164014);
				continue;
			}
			case 16u:
				goto IL_0188;
			case 12u:
				enemyHit._Send = false;
				num = -549063638;
				continue;
			case 15u:
				goto IL_01b9;
			case 3u:
			{
				int num6;
				int num7;
				if (enemyHit._91Zhx0OBsUhlR5optw0cihxmls4 == _477CT08hnzYliCGcgisOnOsuJrd)
				{
					num6 = -918164499;
					num7 = num6;
				}
				else
				{
					num6 = -2140925756;
					num7 = num6;
				}
				num = num6 ^ (int)(num3 * 1975919376);
				continue;
			}
			case 8u:
			{
				int num16;
				int num17;
				if (!_2GIxvwUGGhXZDbsdJhlfFL7Aynq)
				{
					num16 = -1026590777;
					num17 = num16;
				}
				else
				{
					num16 = -558562778;
					num17 = num16;
				}
				num = num16 ^ (int)(num3 * 767216884);
				continue;
			}
			case 13u:
				enemyHit._Send = false;
				num = ((int)num3 * -407900864) ^ -2082011831;
				continue;
			case 9u:
			{
				int num10;
				int num11;
				if (_Iz1POFdHlMFrJHwbDsWXXhNWElj != enemyHit._91Zhx0OBsUhlR5optw0cihxmls4)
				{
					num10 = -307074337;
					num11 = num10;
				}
				else
				{
					num10 = -1266314488;
					num11 = num10;
				}
				num = num10 ^ (int)(num3 * 1915853614);
				continue;
			}
			case 11u:
			{
				int num4;
				int num5;
				if (enemyHit._91Zhx0OBsUhlR5optw0cihxmls4 == _Qi8WHb2CLkop1GCwnhQRKKIWiiG)
				{
					num4 = -1143198530;
					num5 = num4;
				}
				else
				{
					num4 = -1750980583;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -1512454366);
				continue;
			}
			case 7u:
				return;
			case 4u:
				goto IL_02a7;
			case 10u:
				return;
			}
			break;
			IL_01b9:
			int num22;
			if (!Settings.Default.O3IgnoreDammah)
			{
				num = -92139913;
				num22 = num;
			}
			else
			{
				num = -953490675;
				num22 = num;
			}
			continue;
			IL_0188:
			int num23;
			if (!Settings.Default.O3IgnoreCoins)
			{
				num = -549063638;
				num23 = num;
			}
			else
			{
				num = -1070183608;
				num23 = num;
			}
			continue;
			IL_0100:
			int num24;
			if (Settings.Default.O3IgnoreShield)
			{
				num = -104199140;
				num24 = num;
			}
			else
			{
				num = -1928930551;
				num24 = num;
			}
		}
		goto IL_000b;
		IL_000b:
		num = -780787506;
		goto IL_0010;
	}

	public void onShowEffect(ShowEffectPacket showEffect)
	{
		//Discarded unreachable code: IL_00ab, IL_0106, IL_01cd, IL_0228, IL_027a, IL_0285, IL_02c1
		if (!_InSanctuary)
		{
			goto IL_000b;
		}
		goto IL_01ac;
		IL_01ac:
		int num;
		int num2;
		if (Settings.Default.EnableO3Helper)
		{
			num = -2088556946;
			num2 = num;
		}
		else
		{
			num = -418661464;
			num2 = num;
		}
		goto IL_0010;
		IL_0010:
		PlayerData jI4Bueou7dItYp5S7QML5vyC6Rc = default(PlayerData);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x90166CDAu) % 23u)
			{
			case 13u:
				break;
			default:
				return;
			case 4u:
			{
				int num14;
				int num15;
				if (showEffect._JEsT6uIdK1eySUKAfntb2FPG6xS._Alpha == 0)
				{
					num14 = 2103015895;
					num15 = num14;
				}
				else
				{
					num14 = 628257469;
					num15 = num14;
				}
				num = num14 ^ (int)(num3 * 1110930946);
				continue;
			}
			case 7u:
				return;
			case 21u:
				goto IL_00bd;
			case 2u:
				goto IL_00e7;
			case 1u:
				return;
			case 15u:
				jI4Bueou7dItYp5S7QML5vyC6Rc = CurrentClient._VPArsrlUa0uEsW6OxAYV9WHJAMK[showEffect._91Zhx0OBsUhlR5optw0cihxmls4];
				num = -1602953143;
				continue;
			case 11u:
			{
				int num16;
				int num17;
				if (jI4Bueou7dItYp5S7QML5vyC6Rc._y2nCjecGeYsmqDEzaplcuBvYtN7 == 8703)
				{
					num16 = 281729621;
					num17 = num16;
				}
				else
				{
					num16 = 428255203;
					num17 = num16;
				}
				num = num16 ^ ((int)num3 * -304063004);
				continue;
			}
			case 19u:
			{
				int num6;
				int num7;
				if (jI4Bueou7dItYp5S7QML5vyC6Rc._y2nCjecGeYsmqDEzaplcuBvYtN7 != 8702)
				{
					num6 = -1194934049;
					num7 = num6;
				}
				else
				{
					num6 = -620574065;
					num7 = num6;
				}
				num = num6 ^ (int)(num3 * 216513678);
				continue;
			}
			case 10u:
				goto IL_018b;
			case 22u:
				goto IL_01ac;
			case 17u:
				return;
			case 8u:
			{
				int num12;
				int num13;
				if (jI4Bueou7dItYp5S7QML5vyC6Rc == null)
				{
					num12 = -1084491816;
					num13 = num12;
				}
				else
				{
					num12 = -1938006694;
					num13 = num12;
				}
				num = num12 ^ ((int)num3 * -476119803);
				continue;
			}
			case 12u:
			{
				int num8;
				int num9;
				if (showEffect._JEsT6uIdK1eySUKAfntb2FPG6xS._Alpha == 0)
				{
					num8 = 584288852;
					num9 = num8;
				}
				else
				{
					num8 = 1631587029;
					num9 = num8;
				}
				num = num8 ^ ((int)num3 * -196726788);
				continue;
			}
			case 16u:
				return;
			case 6u:
				_St84Xd2QJfrycOmAcQiCvr92mAq = showEffect._91Zhx0OBsUhlR5optw0cihxmls4;
				num = -1169534473;
				continue;
			case 3u:
			{
				int num10;
				int num11;
				if (showEffect._JEsT6uIdK1eySUKAfntb2FPG6xS._Alpha != 0)
				{
					num10 = 1071001754;
					num11 = num10;
				}
				else
				{
					num10 = 1135180404;
					num11 = num10;
				}
				num = num10 ^ ((int)num3 * -1608560893);
				continue;
			}
			case 20u:
				return;
			case 0u:
				return;
			case 18u:
			{
				int num4;
				int num5;
				if (showEffect._JEsT6uIdK1eySUKAfntb2FPG6xS._Alpha == 0)
				{
					num4 = -704745204;
					num5 = num4;
				}
				else
				{
					num4 = -589798875;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 117086300);
				continue;
			}
			case 9u:
				return;
			case 14u:
				goto IL_02d3;
			case 5u:
				return;
			}
			break;
			IL_02d3:
			int num18;
			if (!CurrentClient._VPArsrlUa0uEsW6OxAYV9WHJAMK.ContainsKey(showEffect._91Zhx0OBsUhlR5optw0cihxmls4))
			{
				num = -1121230564;
				num18 = num;
			}
			else
			{
				num = -1430701267;
				num18 = num;
			}
			continue;
			IL_00e7:
			int num19;
			if (showEffect._EffectDict == EffectDictionary.Flash)
			{
				num = -1998800503;
				num19 = num;
			}
			else
			{
				num = -2146570441;
				num19 = num;
			}
			continue;
			IL_00bd:
			int num20;
			if (showEffect._PositionOne._PositionY == 5.0)
			{
				num = -549071701;
				num20 = num;
			}
			else
			{
				num = -2042414903;
				num20 = num;
			}
			continue;
			IL_018b:
			int num21;
			if (jI4Bueou7dItYp5S7QML5vyC6Rc._y2nCjecGeYsmqDEzaplcuBvYtN7 == 8701)
			{
				num = -1390578631;
				num21 = num;
			}
			else
			{
				num = -1294880617;
				num21 = num;
			}
		}
		goto IL_000b;
		IL_000b:
		num = -1387687235;
		goto IL_0010;
	}

	public void onUpdate(UpdatePacket update)
	{
		//Discarded unreachable code: IL_00db, IL_017f
		if (!_InSanctuary)
		{
			goto IL_000b;
		}
		goto IL_0272;
		IL_0272:
		GameObject[] lakUpSXZB1zdJcCECL20tl6SVrT = update._NewObjects;
		int num = 1478668764;
		goto IL_0010;
		IL_0010:
		GameObject gameObject = default(GameObject);
		int num3 = default(int);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x5EE01E69u) % 24u)
			{
			case 22u:
				break;
			default:
				return;
			case 19u:
				goto IL_0085;
			case 23u:
			{
				int num6;
				int num7;
				if (gameObject._ObjectType != 8701)
				{
					num6 = 999094473;
					num7 = num6;
				}
				else
				{
					num6 = 1887730581;
					num7 = num6;
				}
				num = num6 ^ (int)(num2 * 1503102618);
				continue;
			}
			case 12u:
				num = (int)((num2 * 660745986) ^ 0x108B2407);
				continue;
			case 17u:
				return;
			case 2u:
				_uVJ77yndSE01nQVrPjFse5CsyYE = gameObject._Status._ObjectId;
				num = ((int)num2 * -1744324475) ^ -1038323731;
				continue;
			case 6u:
				goto IL_0110;
			case 7u:
				goto IL_0131;
			case 11u:
				num = ((int)num2 * -38438754) ^ -305366763;
				continue;
			case 21u:
				ProcessStatData(gameObject._Status);
				num = ((int)num2 * -106810440) ^ -338325888;
				continue;
			case 20u:
				return;
			case 8u:
				_Qi8WHb2CLkop1GCwnhQRKKIWiiG = gameObject._Status._ObjectId;
				num = ((int)num2 * -1355130168) ^ 0x5EB52ABF;
				continue;
			case 14u:
				num3++;
				num = 2112293538;
				continue;
			case 1u:
				_Iz1POFdHlMFrJHwbDsWXXhNWElj = gameObject._Status._ObjectId;
				num = (int)(num2 * 1378612742) ^ -1920847158;
				continue;
			case 18u:
				_r7ZdM6xdXiqvbZJtINNDT2dEpAS = gameObject._Status._ObjectId;
				num = ((int)num2 * -1419229404) ^ -1181828291;
				continue;
			case 10u:
				num = ((int)num2 * -1428227740) ^ -107318422;
				continue;
			case 9u:
				gameObject = lakUpSXZB1zdJcCECL20tl6SVrT[num3];
				num = 563293405;
				continue;
			case 4u:
			{
				int num4;
				int num5;
				if (gameObject._ObjectType == 45363)
				{
					num4 = -1361773264;
					num5 = num4;
				}
				else
				{
					num4 = -612917274;
					num5 = num4;
				}
				num = num4 ^ (int)(num2 * 243044008);
				continue;
			}
			case 15u:
				goto IL_0251;
			case 0u:
				goto IL_0272;
			case 3u:
				_477CT08hnzYliCGcgisOnOsuJrd = gameObject._Status._ObjectId;
				num = ((int)num2 * -408297481) ^ 0x5A20968F;
				continue;
			case 5u:
				goto IL_02a6;
			case 13u:
				num3 = 0;
				num = (int)((num2 * 623170157) ^ 0xDC763BA);
				continue;
			case 16u:
				return;
			}
			break;
			IL_02a6:
			int num8;
			if (gameObject._ObjectType == 8703)
			{
				num = 1790976131;
				num8 = num;
			}
			else
			{
				num = 1009703182;
				num8 = num;
			}
			continue;
			IL_0085:
			int num9;
			if (num3 >= lakUpSXZB1zdJcCECL20tl6SVrT.Length)
			{
				num = 844560977;
				num9 = num;
			}
			else
			{
				num = 1533941336;
				num9 = num;
			}
			continue;
			IL_0131:
			int num10;
			if (_Iz1POFdHlMFrJHwbDsWXXhNWElj != -1)
			{
				num = 675459199;
				num10 = num;
			}
			else
			{
				num = 957368270;
				num10 = num;
			}
			continue;
			IL_0251:
			int num11;
			if (gameObject._ObjectType != 9635)
			{
				num = 675459199;
				num11 = num;
			}
			else
			{
				num = 723092849;
				num11 = num;
			}
			continue;
			IL_0110:
			int num12;
			if (gameObject._ObjectType != 8702)
			{
				num = 1695284284;
				num12 = num;
			}
			else
			{
				num = 1845809698;
				num12 = num;
			}
		}
		goto IL_000b;
		IL_000b:
		num = 1197157141;
		goto IL_0010;
	}

	public void OnNewTick(NewTickPacket newTick)
	{
		//Discarded unreachable code: IL_002b
		if (!_InSanctuary)
		{
			while (true)
			{
				uint num;
				switch ((num = 0x848923A3u ^ 0xD4C84076u) % 3u)
				{
				case 2u:
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
		using List<Status>.Enumerator enumerator = newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.GetEnumerator();
		Status current = default(Status);
		while (true)
		{
			int num2;
			int num3;
			if (enumerator.MoveNext())
			{
				num2 = -996763549;
				num3 = num2;
			}
			else
			{
				num2 = -712266353;
				num3 = num2;
			}
			while (true)
			{
				uint num;
				switch ((num = (uint)num2 ^ 0xD4C84076u) % 5u)
				{
				case 0u:
					num2 = -996763549;
					continue;
				default:
					return;
				case 2u:
				{
					current = enumerator.Current;
					int num4;
					if (current._ObjectId == _Iz1POFdHlMFrJHwbDsWXXhNWElj)
					{
						num2 = -1108682560;
						num4 = num2;
					}
					else
					{
						num2 = -1491000178;
						num4 = num2;
					}
					continue;
				}
				case 1u:
					break;
				case 3u:
					ProcessStatData(current);
					num2 = ((int)num * -1968250736) ^ -135789842;
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	private void ProcessStatData(Status status)
	{
		//Discarded unreachable code: IL_00e3
		using List<StatData>.Enumerator enumerator = status._Stats.GetEnumerator();
		StatData current = default(StatData);
		while (true)
		{
			int num;
			int num2;
			if (enumerator.MoveNext())
			{
				num = 1165437535;
				num2 = num;
			}
			else
			{
				num = 1716989641;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x2ABC4C38u) % 7u)
				{
				case 5u:
					num = 1165437535;
					continue;
				default:
					return;
				case 2u:
					_ZduGw3wt7ZfTqjLJaORYdo257HE = OryxIgnoreTextures.Contains(current._StatValue);
					num = ((int)num3 * -1594610543) ^ -885276513;
					continue;
				case 4u:
				{
					int num4;
					int num5;
					if (StatType._agQ5CSGcaJRx3TN8BU6OBzWi5yT(current._StatType, StatType._7frCjWtbnnkwXjFXUCU6PjsHmFQ))
					{
						num4 = 864721181;
						num5 = num4;
					}
					else
					{
						num4 = 1416978877;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 720221093);
					continue;
				}
				case 0u:
					break;
				case 1u:
					Program._JWptdPwuTlZYlLpGrinhw8DeS3h("client", $"Oryx shielding: {_ZduGw3wt7ZfTqjLJaORYdo257HE} (alt texture id {current._StatValue})");
					return;
				case 6u:
					current = enumerator.Current;
					num = 1713501198;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	internal void OnTextPacket(TextPacket text)
	{
		//Discarded unreachable code: IL_006d, IL_00b4, IL_00c7
		if (!_InSanctuary)
		{
			goto IL_000b;
		}
		goto IL_00fa;
		IL_00fa:
		int num;
		int num2;
		if (text._NumStars <= -1)
		{
			num = -2136029289;
			num2 = num;
		}
		else
		{
			num = -1828918187;
			num2 = num;
		}
		goto IL_0010;
		IL_0010:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xD771CBB5u) % 9u)
			{
			case 7u:
				break;
			default:
				return;
			case 2u:
				goto IL_0049;
			case 5u:
				return;
			case 8u:
				Program._JWptdPwuTlZYlLpGrinhw8DeS3h("client", $"Ignoring Dammah: {_2GIxvwUGGhXZDbsdJhlfFL7Aynq}, raw text: {text._CleanMessage}");
				num = (int)(num3 * 54915312) ^ -593345678;
				continue;
			case 3u:
				return;
			case 6u:
				return;
			case 4u:
				_2GIxvwUGGhXZDbsdJhlfFL7Aynq = ShieldingPhases.Contains(text._CleanMessage);
				num = -485222150;
				continue;
			case 1u:
				goto IL_00fa;
			case 0u:
				return;
			}
			break;
			IL_0049:
			int num4;
			if (!(text._Name != "#Chancellor Dammah"))
			{
				num = -1247957691;
				num4 = num;
			}
			else
			{
				num = -1068811744;
				num4 = num;
			}
		}
		goto IL_000b;
		IL_000b:
		num = -115169398;
		goto IL_0010;
	}
}
