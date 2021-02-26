using System;
using System.Collections.Generic;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.Mods;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class AntiDebuff
{
	private Client _Client;

	private bool _vFzBaWeCkk5hgjdL49TmYLedeuRB;

	private bool _yBlclxXVrFdHr9Rj4By8io5M4Bg;

	private int _LastUpdate;

	private object _EQz1nzyL5YvZsDraKsHSPRSNTvE = new object();

	private int _SfV4XqXIATPdqQQB5fsHnSDPz2z;

	public AntiDebuff(Client client)
	{
		_Client = client;
	}

	public void OnNewTick(NewTickPacket newTick)
	{
		if (!Settings.Default.EnableAntiDebuffs)
		{
			goto IL_000c;
		}
		goto IL_0042;
		IL_0042:
		Status status = null;
		int num = 1134552683;
		goto IL_0011;
		IL_0011:
		int num7;
		uint num2;
		switch ((num2 = (uint)num ^ 0x2950433Cu) % 4u)
		{
		case 0u:
			break;
		case 2u:
			return;
		case 1u:
			goto IL_0042;
		default:
			{
				using (List<Status>.Enumerator enumerator = newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.GetEnumerator())
				{
					Status current = default(Status);
					while (true)
					{
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = 912685564;
							num4 = num3;
						}
						else
						{
							num3 = 90546876;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x2950433Cu) % 7u)
							{
							case 5u:
								num3 = 90546876;
								continue;
							default:
								goto end_IL_0057;
							case 2u:
								current = enumerator.Current;
								num3 = 1087249856;
								continue;
							case 6u:
							{
								int num5;
								int num6;
								if (current._ObjectId == _Client._PlayerData._fn2CRnBpjyTWHR9K8SU4iOwhDtK)
								{
									num5 = 2001633365;
									num6 = num5;
								}
								else
								{
									num5 = 609834296;
									num6 = num5;
								}
								num3 = num5 ^ (int)(num2 * 1394883385);
								continue;
							}
							case 4u:
								goto end_IL_0057;
							case 0u:
								break;
							case 1u:
								status = current;
								num3 = (int)(num2 * 1285772935) ^ -1442473525;
								continue;
							case 3u:
								goto end_IL_0057;
							}
							break;
						}
					}
					end_IL_0057:;
				}
				if (status == null)
				{
					goto IL_012c;
				}
				goto IL_01c5;
			}
			IL_012c:
			num7 = 1929605748;
			goto IL_0131;
			IL_01c5:
			_D4aGbwZhQI3jcXQuKP8atcOh4zj(status._Stats);
			num7 = 1685307734;
			goto IL_0131;
			IL_0131:
			while (true)
			{
				switch ((num2 = (uint)num7 ^ 0x2950433Cu) % 5u)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
					status = new Status
					{
						_Stats = new List<StatData>(),
						_ObjectId = _Client._UqAoky1lauc0gYPMEYUcYfMlJkC,
						_Position = _Client._PlayerData._IlcbhoOIM3MRszn9mfn3IKjnXc0
					};
					status._Stats.Add(_JsbF2wqg1gNSAs8RRpe2kAMA0wC());
					status._Stats.Add(_UMNfca321ZYkNk2tClEN6C4ahol());
					num7 = (int)(num2 * 1623525434) ^ -489251987;
					continue;
				case 2u:
					goto IL_01c5;
				case 1u:
					newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.Add(status);
					num7 = (int)(num2 * 1302028564) ^ -283863942;
					continue;
				case 3u:
					return;
				}
				break;
			}
			goto IL_012c;
		}
		goto IL_000c;
		IL_000c:
		num = 128786306;
		goto IL_0011;
	}

	private StatData _JsbF2wqg1gNSAs8RRpe2kAMA0wC()
	{
		return new StatData
		{
			_StatType = StatType._kvTyEminxJMM6fREzgqsVjHaInC,
			_StatValue = _Client._PlayerData._ITMdkMmK3E7TJrGaRGy1ivI4A9U,
			_StringStatValue = string.Empty
		};
	}

	private StatData _UMNfca321ZYkNk2tClEN6C4ahol()
	{
		return new StatData
		{
			_StatType = StatType._HmqFDGwB69awhIJ5Ik12W8iBBYW,
			_StatValue = _Client._PlayerData._HmqFDGwB69awhIJ5Ik12W8iBBYW,
			_StringStatValue = string.Empty
		};
	}

	public void OnMove(MovePacket move)
	{
		_LastUpdate = Environment.TickCount;
	}

	public void OnAoE(AoEPacket aoe)
	{
		if (!(_Client._PlayerData._Position.GetDistance(aoe._Position) <= (double)(aoe._Radius * aoe._Radius)))
		{
			return;
		}
		_vFzBaWeCkk5hgjdL49TmYLedeuRB = true;
	}

	public void OnPlayerHit(PlayerHitPacket playerHit)
	{
		_yBlclxXVrFdHr9Rj4By8io5M4Bg = true;
		Dictionary<string, float> statusEffects = default(Dictionary<string, float>);
		Dictionary<int, Projectile> dictionary = default(Dictionary<int, Projectile>);
		while (true)
		{
			int num = 178618269;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7545D6CBu) % 50u)
				{
				case 45u:
					break;
				default:
					return;
				case 28u:
					return;
				case 48u:
				{
					int num19;
					int num20;
					if (statusEffects.ContainsKey("Slowed"))
					{
						num19 = -536533992;
						num20 = num19;
					}
					else
					{
						num19 = -840693601;
						num20 = num19;
					}
					num = num19 ^ (int)(num2 * 1613438127);
					continue;
				}
				case 15u:
					playerHit._Send = false;
					num = (int)(num2 * 1435950337) ^ -563054058;
					continue;
				case 8u:
					playerHit._Send = false;
					num = (int)(num2 * 910361741) ^ -37882546;
					continue;
				case 44u:
				{
					int num42;
					if (Settings.Default.IgnoreSick)
					{
						num = 2106647208;
						num42 = num;
					}
					else
					{
						num = 957088191;
						num42 = num;
					}
					continue;
				}
				case 18u:
					playerHit._Send = false;
					num = (int)(num2 * 728824667) ^ -1034920825;
					continue;
				case 34u:
				{
					int num26;
					int num27;
					if (!statusEffects.ContainsKey("Stunned"))
					{
						num26 = -32402038;
						num27 = num26;
					}
					else
					{
						num26 = -2024691568;
						num27 = num26;
					}
					num = num26 ^ ((int)num2 * -780542786);
					continue;
				}
				case 29u:
					playerHit._Send = false;
					return;
				case 32u:
				{
					int num34;
					int num35;
					if (!statusEffects.ContainsKey("Dazed"))
					{
						num34 = 1183921522;
						num35 = num34;
					}
					else
					{
						num34 = 1140030944;
						num35 = num34;
					}
					num = num34 ^ ((int)num2 * -1979509890);
					continue;
				}
				case 1u:
				{
					int num12;
					int num13;
					if (statusEffects.ContainsKey("Silence"))
					{
						num12 = -1874338261;
						num13 = num12;
					}
					else
					{
						num12 = -2041833174;
						num13 = num12;
					}
					num = num12 ^ (int)(num2 * 513740964);
					continue;
				}
				case 22u:
					return;
				case 16u:
					playerHit._Send = false;
					num = (int)((num2 * 1466439902) ^ 0x7220EEDB);
					continue;
				case 3u:
				{
					int num43;
					if (Settings.Default.IgnoreBleeding)
					{
						num = 677260790;
						num43 = num;
					}
					else
					{
						num = 1981133064;
						num43 = num;
					}
					continue;
				}
				case 38u:
				{
					int num37;
					if (Settings.Default.IgnorePetrified)
					{
						num = 1690612341;
						num37 = num;
					}
					else
					{
						num = 1285727614;
						num37 = num;
					}
					continue;
				}
				case 42u:
				{
					int num30;
					int num31;
					if (statusEffects.ContainsKey("Quiet"))
					{
						num30 = -2019094583;
						num31 = num30;
					}
					else
					{
						num30 = -812040217;
						num31 = num30;
					}
					num = num30 ^ (int)(num2 * 1289292813);
					continue;
				}
				case 6u:
				{
					int num10;
					int num11;
					if (statusEffects.ContainsKey("Petrified"))
					{
						num10 = -1488663714;
						num11 = num10;
					}
					else
					{
						num10 = -1074694940;
						num11 = num10;
					}
					num = num10 ^ (int)(num2 * 235957331);
					continue;
				}
				case 41u:
				{
					int num7;
					if (Settings.Default.IgnoreArmorBreak)
					{
						num = 251207655;
						num7 = num;
					}
					else
					{
						num = 968306862;
						num7 = num;
					}
					continue;
				}
				case 4u:
				{
					dictionary = _Client._N5GofMpQbwbVNiYLmSHHRmpmKhg[playerHit._fn2CRnBpjyTWHR9K8SU4iOwhDtK];
					int num4;
					if (dictionary.ContainsKey(playerHit._isVjytSCPjaQXfnhSgmbShfAEYC))
					{
						num = 22192380;
						num4 = num;
					}
					else
					{
						num = 152882790;
						num4 = num;
					}
					continue;
				}
				case 39u:
					playerHit._Send = false;
					return;
				case 21u:
					playerHit._Send = false;
					return;
				case 46u:
				{
					int num32;
					int num33;
					if (!Settings.Default.EnableAntiDebuffs)
					{
						num32 = -488833328;
						num33 = num32;
					}
					else
					{
						num32 = -947219238;
						num33 = num32;
					}
					num = num32 ^ ((int)num2 * -813900163);
					continue;
				}
				case 31u:
				{
					int num24;
					int num25;
					if (!statusEffects.ContainsKey("PetStasis"))
					{
						num24 = 1821048113;
						num25 = num24;
					}
					else
					{
						num24 = 675962239;
						num25 = num24;
					}
					num = num24 ^ ((int)num2 * -1922540696);
					continue;
				}
				case 20u:
					playerHit._Send = false;
					return;
				case 14u:
					playerHit._Send = false;
					return;
				case 26u:
					playerHit._Send = false;
					return;
				case 11u:
				{
					int num18;
					if (!Settings.Default.IgnoreParalyzed)
					{
						num = 775882744;
						num18 = num;
					}
					else
					{
						num = 330889578;
						num18 = num;
					}
					continue;
				}
				case 7u:
				{
					int num14;
					int num15;
					if (!statusEffects.ContainsKey("Sick"))
					{
						num14 = -1877920187;
						num15 = num14;
					}
					else
					{
						num14 = -1681314825;
						num15 = num14;
					}
					num = num14 ^ ((int)num2 * -87173058);
					continue;
				}
				case 0u:
				{
					int num5;
					if (!Settings.Default.IgnoreDazed)
					{
						num = 116001142;
						num5 = num;
					}
					else
					{
						num = 1952544949;
						num5 = num;
					}
					continue;
				}
				case 40u:
					return;
				case 43u:
				{
					int num40;
					int num41;
					if (statusEffects.ContainsKey("Weak"))
					{
						num40 = 170134605;
						num41 = num40;
					}
					else
					{
						num40 = 762427719;
						num41 = num40;
					}
					num = num40 ^ ((int)num2 * -1944334100);
					continue;
				}
				case 23u:
					return;
				case 35u:
					playerHit._Send = false;
					return;
				case 36u:
				{
					int num38;
					int num39;
					if (statusEffects.ContainsKey("ArmorBreak"))
					{
						num38 = 362360682;
						num39 = num38;
					}
					else
					{
						num38 = 1438316782;
						num39 = num38;
					}
					num = num38 ^ (int)(num2 * 1515949104);
					continue;
				}
				case 10u:
				{
					int num36;
					if (!Settings.Default.IgnoreSlowed)
					{
						num = 1076644565;
						num36 = num;
					}
					else
					{
						num = 2135813661;
						num36 = num;
					}
					continue;
				}
				case 5u:
					return;
				case 24u:
					return;
				case 33u:
				{
					int num28;
					int num29;
					if (statusEffects.ContainsKey("Paralyzed"))
					{
						num28 = 216664198;
						num29 = num28;
					}
					else
					{
						num28 = 208138325;
						num29 = num28;
					}
					num = num28 ^ ((int)num2 * -398705523);
					continue;
				}
				case 19u:
					playerHit._Send = false;
					num = (int)((num2 * 518774543) ^ 0x75DC736A);
					continue;
				case 25u:
					return;
				case 13u:
				{
					int num23;
					if (!_Client._N5GofMpQbwbVNiYLmSHHRmpmKhg.ContainsKey(playerHit._fn2CRnBpjyTWHR9K8SU4iOwhDtK))
					{
						num = 745400093;
						num23 = num;
					}
					else
					{
						num = 1432137581;
						num23 = num;
					}
					continue;
				}
				case 17u:
				{
					int num22;
					if (!Settings.Default.IgnoreStunned)
					{
						num = 1288488470;
						num22 = num;
					}
					else
					{
						num = 268892729;
						num22 = num;
					}
					continue;
				}
				case 49u:
				{
					int num21;
					if (Settings.Default.IgnoreSilence)
					{
						num = 1126125980;
						num21 = num;
					}
					else
					{
						num = 1026636438;
						num21 = num;
					}
					continue;
				}
				case 47u:
					statusEffects = dictionary[playerHit._isVjytSCPjaQXfnhSgmbShfAEYC].Structure.StatusEffects;
					num = 109250331;
					continue;
				case 27u:
				{
					int num16;
					int num17;
					if (statusEffects.ContainsKey("Bleeding"))
					{
						num16 = -2130608256;
						num17 = num16;
					}
					else
					{
						num16 = -931042670;
						num17 = num16;
					}
					num = num16 ^ (int)(num2 * 698960802);
					continue;
				}
				case 30u:
				{
					int num8;
					int num9;
					if (Settings.Default.IgnoreQuiet)
					{
						num8 = -1880960895;
						num9 = num8;
					}
					else
					{
						num8 = -535230747;
						num9 = num8;
					}
					num = num8 ^ ((int)num2 * -1291932167);
					continue;
				}
				case 2u:
				{
					int num6;
					if (Settings.Default.IgnoreWeak)
					{
						num = 1614051092;
						num6 = num;
					}
					else
					{
						num = 867881171;
						num6 = num;
					}
					continue;
				}
				case 12u:
					return;
				case 9u:
				{
					int num3;
					if (!Settings.Default.IgnorePetStasis)
					{
						num = 1868645273;
						num3 = num;
					}
					else
					{
						num = 878797762;
						num3 = num;
					}
					continue;
				}
				case 37u:
					return;
				}
				break;
			}
		}
	}

	private void _D4aGbwZhQI3jcXQuKP8atcOh4zj(List<StatData> statData)
	{
		StatData _9jGN6HTdhe4I1rr5gcjTIWSluy = null;
		StatData _9jGN6HTdhe4I1rr5gcjTIWSluy2 = null;
		using (List<StatData>.Enumerator enumerator = statData.GetEnumerator())
		{
			StatData current = default(StatData);
			while (true)
			{
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 411236859;
					num2 = num;
				}
				else
				{
					num = 923890825;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x7C4689Du) % 11u)
					{
					case 10u:
						num = 411236859;
						continue;
					default:
						goto end_IL_000c;
					case 4u:
						break;
					case 0u:
					{
						int num7;
						if (_9jGN6HTdhe4I1rr5gcjTIWSluy != null)
						{
							num = 1367539475;
							num7 = num;
						}
						else
						{
							num = 480492341;
							num7 = num;
						}
						continue;
					}
					case 1u:
					{
						int num6;
						if (!StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType._HmqFDGwB69awhIJ5Ik12W8iBBYW))
						{
							num = 1935173681;
							num6 = num;
						}
						else
						{
							num = 849917094;
							num6 = num;
						}
						continue;
					}
					case 5u:
					{
						int num8;
						int num9;
						if (_9jGN6HTdhe4I1rr5gcjTIWSluy2 != null)
						{
							num8 = -64113942;
							num9 = num8;
						}
						else
						{
							num8 = -1068534101;
							num9 = num8;
						}
						num = num8 ^ ((int)num3 * -834782023);
						continue;
					}
					case 8u:
					{
						int num4;
						int num5;
						if (!StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType._kvTyEminxJMM6fREzgqsVjHaInC))
						{
							num4 = -1250656588;
							num5 = num4;
						}
						else
						{
							num4 = -1093458636;
							num5 = num4;
						}
						num = num4 ^ ((int)num3 * -853222119);
						continue;
					}
					case 9u:
						_9jGN6HTdhe4I1rr5gcjTIWSluy2 = current;
						num = (int)((num3 * 936412192) ^ 0x1F419B51);
						continue;
					case 7u:
						_9jGN6HTdhe4I1rr5gcjTIWSluy = current;
						num = (int)(num3 * 1723910572) ^ -1241783059;
						continue;
					case 3u:
						goto end_IL_000c;
					case 2u:
						current = enumerator.Current;
						num = 1628924977;
						continue;
					case 6u:
						goto end_IL_000c;
					}
					break;
				}
			}
			end_IL_000c:;
		}
		if (_9jGN6HTdhe4I1rr5gcjTIWSluy == null)
		{
			goto IL_0164;
		}
		goto IL_0552;
		IL_0164:
		int num10 = 1164665601;
		goto IL_0169;
		IL_0552:
		int num11;
		if (_9jGN6HTdhe4I1rr5gcjTIWSluy2 == null)
		{
			num10 = 616941655;
			num11 = num10;
		}
		else
		{
			num10 = 1018858517;
			num11 = num10;
		}
		goto IL_0169;
		IL_0169:
		int num12 = default(int);
		int num14 = default(int);
		int num13 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num10 ^ 0x7C4689Du) % 54u)
			{
			case 42u:
				break;
			default:
				return;
			case 5u:
				goto IL_0257;
			case 19u:
				num10 = (int)((num3 * 1618411462) ^ 0x3396BF52);
				continue;
			case 11u:
				num12 |= 0x20;
				num10 = ((int)num3 * -1476184458) ^ -53051431;
				continue;
			case 6u:
				num14 |= 0x400;
				num10 = (int)((num3 * 710160760) ^ 0x6A8F399A);
				continue;
			case 29u:
				_vFzBaWeCkk5hgjdL49TmYLedeuRB = false;
				num10 = (int)((num3 * 606365854) ^ 0x23B61D41);
				continue;
			case 13u:
				statData.Add(_9jGN6HTdhe4I1rr5gcjTIWSluy2);
				num10 = (int)((num3 * 1669604933) ^ 0x5F20F74A);
				continue;
			case 22u:
				num12 |= 0x10;
				num10 = (int)(num3 * 922795986) ^ -539741230;
				continue;
			case 53u:
				goto IL_030b;
			case 43u:
				_9jGN6HTdhe4I1rr5gcjTIWSluy._StatValue &= ~num12;
				num10 = (int)(num3 * 1599055583) ^ -438426091;
				continue;
			case 25u:
				num12 |= 8;
				num10 = (int)((num3 * 2030346475) ^ 0x3E558F92);
				continue;
			case 46u:
				num12 |= 0x200000;
				num10 = ((int)num3 * -966951106) ^ 0x6EA4CEB4;
				continue;
			case 41u:
				goto IL_037f;
			case 24u:
				_9jGN6HTdhe4I1rr5gcjTIWSluy = _JsbF2wqg1gNSAs8RRpe2kAMA0wC();
				statData.Add(_9jGN6HTdhe4I1rr5gcjTIWSluy);
				num10 = ((int)num3 * -2067400174) ^ 0x125D5908;
				continue;
			case 0u:
				goto IL_03bc;
			case 20u:
				_9jGN6HTdhe4I1rr5gcjTIWSluy2 = _UMNfca321ZYkNk2tClEN6C4ahol();
				num10 = ((int)num3 * -1417439317) ^ -1357409504;
				continue;
			case 30u:
				goto IL_03f6;
			case 23u:
			{
				int num17;
				int num18;
				if (!_vFzBaWeCkk5hgjdL49TmYLedeuRB)
				{
					num17 = -273092899;
					num18 = num17;
				}
				else
				{
					num17 = -2067979845;
					num18 = num17;
				}
				num10 = num17 ^ ((int)num3 * -1695773149);
				continue;
			}
			case 44u:
				num12 |= 0x4000000;
				num10 = ((int)num3 * -1989970517) ^ -1802941566;
				continue;
			case 7u:
				num14 |= 0x80;
				num10 = ((int)num3 * -2140903837) ^ 0x63329095;
				continue;
			case 39u:
				_9jGN6HTdhe4I1rr5gcjTIWSluy._StatValue &= ~num14;
				num10 = 149697992;
				continue;
			case 47u:
				goto IL_048d;
			case 17u:
				_vFzBaWeCkk5hgjdL49TmYLedeuRB = false;
				num10 = (int)(num3 * 231927347) ^ -618884559;
				continue;
			case 45u:
				num13 |= 0x10000;
				num10 = ((int)num3 * -1498542096) ^ -1756606826;
				continue;
			case 49u:
				num12 |= 0x40;
				num10 = (int)((num3 * 755039774) ^ 0x5293745F);
				continue;
			case 40u:
				goto IL_04fa;
			case 2u:
				num12 |= 0x8000;
				num10 = (int)((num3 * 1562791488) ^ 0x30AD4D8F);
				continue;
			case 34u:
				num14 |= 0x40000000;
				num10 = (int)(num3 * 28324227) ^ -1918863961;
				continue;
			case 33u:
				goto IL_0552;
			case 15u:
				goto IL_0569;
			case 50u:
				num13 |= 8;
				num10 = (int)(num3 * 833218869) ^ -909186356;
				continue;
			case 26u:
				num14 |= 0x200;
				num10 = (int)(num3 * 831200210) ^ -2030935706;
				continue;
			case 51u:
				goto IL_05bd;
			case 8u:
				goto IL_05d9;
			case 16u:
				goto IL_05f9;
			case 3u:
				goto IL_0619;
			case 10u:
				_9jGN6HTdhe4I1rr5gcjTIWSluy2._StatValue &= ~num13;
				num10 = ((int)num3 * -1499329018) ^ -734948283;
				continue;
			case 35u:
				goto IL_065b;
			case 32u:
				num12 |= 2;
				num10 = ((int)num3 * -1849671903) ^ 0x1BE2FE15;
				continue;
			case 31u:
				goto IL_0692;
			case 48u:
				goto IL_06b2;
			case 21u:
				goto IL_06d2;
			case 28u:
				num12 |= 4;
				num10 = ((int)num3 * -386675317) ^ -1023253208;
				continue;
			case 27u:
				goto IL_0705;
			case 1u:
				num12 |= 0x2000;
				num10 = ((int)num3 * -1130674910) ^ -1582417222;
				continue;
			case 37u:
				goto IL_0740;
			case 9u:
				goto IL_0760;
			case 38u:
				goto IL_0780;
			case 18u:
				return;
			case 12u:
				num14 |= 0x20000000;
				num10 = (int)((num3 * 1249346480) ^ 0x75435A8C);
				continue;
			case 4u:
				num14 |= 0x100;
				num10 = (int)((num3 * 959162447) ^ 0x71B35B2F);
				continue;
			case 52u:
			{
				num13 = 0;
				num14 = 0;
				int num15;
				int num16;
				if (Settings.Default.IgnoreQuiet)
				{
					num15 = -482271691;
					num16 = num15;
				}
				else
				{
					num15 = -1126269251;
					num16 = num15;
				}
				num10 = num15 ^ (int)(num3 * 65076238);
				continue;
			}
			case 36u:
				num12 = 0;
				num10 = 1040176073;
				continue;
			case 14u:
				return;
			}
			break;
			IL_0780:
			int num19;
			if (Settings.Default.IgnoreStunned)
			{
				num10 = 287397098;
				num19 = num10;
			}
			else
			{
				num10 = 1497912237;
				num19 = num10;
			}
			continue;
			IL_05bd:
			int num20;
			if (!_yBlclxXVrFdHr9Rj4By8io5M4Bg)
			{
				num10 = 826753112;
				num20 = num10;
			}
			else
			{
				num10 = 922442958;
				num20 = num10;
			}
			continue;
			IL_065b:
			int num21;
			if (!Settings.Default.IgnoreDazed)
			{
				num10 = 1538522583;
				num21 = num10;
			}
			else
			{
				num10 = 576566328;
				num21 = num10;
			}
			continue;
			IL_0760:
			int num22;
			if (!Settings.Default.IgnoreDarkness)
			{
				num10 = 713426361;
				num22 = num10;
			}
			else
			{
				num10 = 1050854295;
				num22 = num10;
			}
			continue;
			IL_048d:
			int num23;
			if (Settings.Default.IgnoreConfused)
			{
				num10 = 791394359;
				num23 = num10;
			}
			else
			{
				num10 = 430792746;
				num23 = num10;
			}
			continue;
			IL_03bc:
			int num24;
			if (!Settings.Default.IgnoreWeak)
			{
				num10 = 916456928;
				num24 = num10;
			}
			else
			{
				num10 = 1854940101;
				num24 = num10;
			}
			continue;
			IL_0740:
			int num25;
			if (!Settings.Default.IgnoreSilence)
			{
				num10 = 1803957734;
				num25 = num10;
			}
			else
			{
				num10 = 1976232404;
				num25 = num10;
			}
			continue;
			IL_0619:
			int num26;
			if (!Settings.Default.IgnoreBlind)
			{
				num10 = 389530202;
				num26 = num10;
			}
			else
			{
				num10 = 14716728;
				num26 = num10;
			}
			continue;
			IL_0569:
			int num27;
			if (Settings.Default.IgnoreBleeding)
			{
				num10 = 1859103479;
				num27 = num10;
			}
			else
			{
				num10 = 88451855;
				num27 = num10;
			}
			continue;
			IL_0705:
			int num28;
			if (!Settings.Default.IgnorePetStasis)
			{
				num10 = 1540871904;
				num28 = num10;
			}
			else
			{
				num10 = 1232401163;
				num28 = num10;
			}
			continue;
			IL_030b:
			int num29;
			if (Settings.Default.IgnoreUnstable)
			{
				num10 = 1896611085;
				num29 = num10;
			}
			else
			{
				num10 = 2070731148;
				num29 = num10;
			}
			continue;
			IL_05f9:
			int num30;
			if (Settings.Default.IgnorePetrified)
			{
				num10 = 417501077;
				num30 = num10;
			}
			else
			{
				num10 = 777188964;
				num30 = num10;
			}
			continue;
			IL_06d2:
			int num31;
			if (_yBlclxXVrFdHr9Rj4By8io5M4Bg)
			{
				num10 = 1725646917;
				num31 = num10;
			}
			else
			{
				num10 = 117899605;
				num31 = num10;
			}
			continue;
			IL_03f6:
			int num32;
			if (!Settings.Default.IgnoreDrunk)
			{
				num10 = 1349862354;
				num32 = num10;
			}
			else
			{
				num10 = 2039792855;
				num32 = num10;
			}
			continue;
			IL_04fa:
			int num33;
			if (!Settings.Default.IgnoreArmorBreak)
			{
				num10 = 1505649400;
				num33 = num10;
			}
			else
			{
				num10 = 1973790451;
				num33 = num10;
			}
			continue;
			IL_06b2:
			int num34;
			if (Settings.Default.IgnoreSick)
			{
				num10 = 1483190869;
				num34 = num10;
			}
			else
			{
				num10 = 1936753602;
				num34 = num10;
			}
			continue;
			IL_05d9:
			int num35;
			if (!Settings.Default.IgnoreParalyzed)
			{
				num10 = 1463249576;
				num35 = num10;
			}
			else
			{
				num10 = 1132925284;
				num35 = num10;
			}
			continue;
			IL_0257:
			int num36;
			if (!Settings.Default.IgnoreSlowed)
			{
				num10 = 1461696565;
				num36 = num10;
			}
			else
			{
				num10 = 356031912;
				num36 = num10;
			}
			continue;
			IL_0692:
			int num37;
			if (Settings.Default.IgnoreHallucinating)
			{
				num10 = 359558231;
				num37 = num10;
			}
			else
			{
				num10 = 1815695737;
				num37 = num10;
			}
			continue;
			IL_037f:
			int num38;
			if (!_vFzBaWeCkk5hgjdL49TmYLedeuRB)
			{
				num10 = 12498752;
				num38 = num10;
			}
			else
			{
				num10 = 603173254;
				num38 = num10;
			}
		}
		goto IL_0164;
	}
}
