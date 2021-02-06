using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class _MfxNQEqzrhh7UG8JHpjpW36tvJ
{
	private Client _50w8wVuv8bL5nhKaR2EHxjrTamB;

	private int _EeeRzHBDOL9AqYJ8CIuFvkR3Qlz = -1;

	public _MfxNQEqzrhh7UG8JHpjpW36tvJ(Client client)
	{
		_50w8wVuv8bL5nhKaR2EHxjrTamB = client;
	}

	public void _73wAP4ozRO5hPRsKKuqzMgWaCqD(QuestObjectPacket questObjId)
	{
		_EeeRzHBDOL9AqYJ8CIuFvkR3Qlz = questObjId._fn2CRnBpjyTWHR9K8SU4iOwhDtK;
	}

	public void _CgwO1K8tgdyKPdKvCtJupNhapLD(PlayerTextPacket playerText)
	{
		//Discarded unreachable code: IL_00c6, IL_00f6, IL_012d, IL_0184, IL_038d, IL_0446, IL_04e2, IL_07c9, IL_07fc, IL_0917, IL_0ac1, IL_0b23, IL_0b2e, IL_0b42
		if (string.IsNullOrEmpty(playerText._Message))
		{
			return;
		}
		string[] array = default(string[]);
		PlayerData jI4Bueou7dItYp5S7QML5vyC6Rc = default(PlayerData);
		IEnumerable<PlayerData> source = default(IEnumerable<PlayerData>);
		PlayerData jI4Bueou7dItYp5S7QML5vyC6Rc2 = default(PlayerData);
		double num14 = default(double);
		PlayerData current2 = default(PlayerData);
		_gXkgDctfNPN0Xyz8qvjQDIS73of gXkgDctfNPN0Xyz8qvjQDIS73of2 = default(_gXkgDctfNPN0Xyz8qvjQDIS73of);
		ReconnectPacket reconnectPacket = default(ReconnectPacket);
		string value = default(string);
		string text = default(string);
		PlayerData current = default(PlayerData);
		while (true)
		{
			int num = -1750270187;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA67D4B79u) % 17u)
				{
				case 7u:
					break;
				case 2u:
				{
					int num9;
					int num10;
					if (playerText._Message[0] != '/')
					{
						num9 = 806781121;
						num10 = num9;
					}
					else
					{
						num9 = 532765268;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 1164389951);
					continue;
				}
				case 15u:
				{
					int num41;
					int num42;
					if (Settings.Default.EnableTeleportToSelf)
					{
						num41 = -264259780;
						num42 = num41;
					}
					else
					{
						num41 = -2010866462;
						num42 = num41;
					}
					num = num41 ^ (int)(num2 * 1334473406);
					continue;
				}
				case 14u:
					return;
				case 1u:
					if (array[0] == "/tp")
					{
						num = ((int)num2 * -919367479) ^ -648364078;
						continue;
					}
					while (true)
					{
						if (array[0] == "/tpq")
						{
							int num11 = -788484004;
							while (true)
							{
								switch ((num2 = (uint)num11 ^ 0xA67D4B79u) % 11u)
								{
								case 10u:
									num11 = -1591089261;
									continue;
								case 1u:
									break;
								case 8u:
									jI4Bueou7dItYp5S7QML5vyC6Rc = source.First();
									num11 = ((int)num2 * -185312111) ^ 0x5721D1B0;
									continue;
								case 3u:
									return;
								case 6u:
									playerText._Send = false;
									num11 = -773015358;
									continue;
								case 4u:
								{
									int num15;
									int num16;
									if (!source.Any())
									{
										num15 = 1964101611;
										num16 = num15;
									}
									else
									{
										num15 = 351924091;
										num16 = num15;
									}
									num11 = num15 ^ ((int)num2 * -907251790);
									continue;
								}
								case 5u:
									jI4Bueou7dItYp5S7QML5vyC6Rc2 = null;
									num14 = 0.0;
									num11 = -896664423;
									continue;
								case 2u:
								{
									int num12;
									int num13;
									if (Settings.Default.EnableTeleportToPlayerClosestToQuestCommand)
									{
										num12 = -1733244460;
										num13 = num12;
									}
									else
									{
										num12 = -1906903748;
										num13 = num12;
									}
									num11 = num12 ^ (int)(num2 * 1657868672);
									continue;
								}
								case 9u:
									_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Quest not found!");
									return;
								case 0u:
									source = _50w8wVuv8bL5nhKaR2EHxjrTamB._Aq9hW2NyDqEkITmxzYm6OCQLaDB.Values.Where((PlayerData enemy) => enemy._fn2CRnBpjyTWHR9K8SU4iOwhDtK == _EeeRzHBDOL9AqYJ8CIuFvkR3Qlz);
									num11 = (int)(num2 * 23163576) ^ -1930811091;
									continue;
								default:
									goto IL_052b;
								}
								break;
							}
							continue;
						}
						goto IL_0a15;
						IL_0a6b:
						_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Teleporting to " + jI4Bueou7dItYp5S7QML5vyC6Rc2._WL2DOBxBuX9DARzf2KPoaJbgZiCb + "!");
						int num17 = -770781531;
						goto IL_0695;
						IL_0690:
						num17 = -1589234120;
						goto IL_0695;
						IL_052b:
						using (Dictionary<int, PlayerData>.ValueCollection.Enumerator enumerator = _50w8wVuv8bL5nhKaR2EHxjrTamB._naDcMlPfaanTh6qrJ3cOuO4HNwz.Values.GetEnumerator())
						{
							while (true)
							{
								int num18;
								int num19;
								if (!enumerator.MoveNext())
								{
									num18 = -193042290;
									num19 = num18;
								}
								else
								{
									num18 = -1985374203;
									num19 = num18;
								}
								while (true)
								{
									switch ((num2 = (uint)num18 ^ 0xA67D4B79u) % 9u)
									{
									case 3u:
										num18 = -1985374203;
										continue;
									default:
										goto end_IL_0541;
									case 6u:
										current2 = enumerator.Current;
										num18 = -125787301;
										continue;
									case 5u:
										jI4Bueou7dItYp5S7QML5vyC6Rc2 = current2;
										num14 = current2._FLMczMOk4gNIJMbSsAnIDIvYlDP.GetDistance(jI4Bueou7dItYp5S7QML5vyC6Rc._FLMczMOk4gNIJMbSsAnIDIvYlDP);
										num18 = -2029029138;
										continue;
									case 8u:
									{
										int num26;
										int num27;
										if (!current2._NNgacHsIcOUlk6tnbwwxK7FDsff())
										{
											num26 = 1621638204;
											num27 = num26;
										}
										else
										{
											num26 = 1013029468;
											num27 = num26;
										}
										num18 = num26 ^ ((int)num2 * -99043881);
										continue;
									}
									case 2u:
									{
										int num22;
										int num23;
										if (current2._FLMczMOk4gNIJMbSsAnIDIvYlDP.GetDistance(jI4Bueou7dItYp5S7QML5vyC6Rc._FLMczMOk4gNIJMbSsAnIDIvYlDP) >= num14)
										{
											num22 = -2076566562;
											num23 = num22;
										}
										else
										{
											num22 = -799362313;
											num23 = num22;
										}
										num18 = num22 ^ ((int)num2 * -1129373452);
										continue;
									}
									case 7u:
										break;
									case 0u:
									{
										int num24;
										int num25;
										if (jI4Bueou7dItYp5S7QML5vyC6Rc2 != null)
										{
											num24 = -1864538543;
											num25 = num24;
										}
										else
										{
											num24 = -1042825133;
											num25 = num24;
										}
										num18 = num24 ^ ((int)num2 * -342833652);
										continue;
									}
									case 1u:
									{
										int num20;
										int num21;
										if (current2 == _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC)
										{
											num20 = -1385695744;
											num21 = num20;
										}
										else
										{
											num20 = -457941751;
											num21 = num20;
										}
										num18 = num20 ^ ((int)num2 * -1011815673);
										continue;
									}
									case 4u:
										goto end_IL_0541;
									}
									break;
								}
							}
							end_IL_0541:;
						}
						if (jI4Bueou7dItYp5S7QML5vyC6Rc2 == null)
						{
							goto IL_0690;
						}
						goto IL_0a6b;
						IL_0695:
						while (true)
						{
							switch ((num2 = (uint)num17 ^ 0xA67D4B79u) % 34u)
							{
							case 21u:
								break;
							default:
								return;
							case 28u:
								goto IL_0733;
							case 26u:
								goto IL_0753;
							case 10u:
								_50w8wVuv8bL5nhKaR2EHxjrTamB._WEI99xvr4YqzD1PAnL2WmiBhWKJ(gXkgDctfNPN0Xyz8qvjQDIS73of2);
								num17 = (int)(num2 * 1686821117) ^ -2054065793;
								continue;
							case 32u:
								reconnectPacket = (ReconnectPacket)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.RECONNECT);
								num17 = ((int)num2 * -1436860093) ^ -1342146281;
								continue;
							case 22u:
								playerText._Send = false;
								num17 = -13505546;
								continue;
							case 8u:
								return;
							case 7u:
								Settings.Default.CurrentServer = value;
								num17 = (int)((num2 * 1561157505) ^ 0x25CB793E);
								continue;
							case 2u:
								return;
							case 1u:
								_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("No players found to teleport to!");
								num17 = (int)(num2 * 2096922046) ^ -125483602;
								continue;
							case 30u:
							{
								int num32;
								int num33;
								if (array[0] == "/loc")
								{
									num32 = -712487546;
									num33 = num32;
								}
								else
								{
									num32 = -1310431336;
									num33 = num32;
								}
								num17 = num32 ^ ((int)num2 * -292526049);
								continue;
							}
							case 24u:
								_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Usage: /connect [server name]");
								num17 = -2142874341;
								continue;
							case 6u:
								gXkgDctfNPN0Xyz8qvjQDIS73of2 = (_gXkgDctfNPN0Xyz8qvjQDIS73of)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.TELEPORT);
								gXkgDctfNPN0Xyz8qvjQDIS73of2._fn2CRnBpjyTWHR9K8SU4iOwhDtK = jI4Bueou7dItYp5S7QML5vyC6Rc2._fn2CRnBpjyTWHR9K8SU4iOwhDtK;
								num17 = (int)(num2 * 931766000) ^ -1673800875;
								continue;
							case 27u:
								reconnectPacket._IsFromArena = false;
								reconnectPacket._Key = new byte[0];
								num17 = ((int)num2 * -96955804) ^ -1988870985;
								continue;
							case 31u:
							{
								int num34;
								int num35;
								if (!(array[0] == "/connect"))
								{
									num34 = 684173617;
									num35 = num34;
								}
								else
								{
									num34 = 719580645;
									num35 = num34;
								}
								num17 = num34 ^ (int)(num2 * 696526382);
								continue;
							}
							case 12u:
								reconnectPacket._KeyTime = -1;
								num17 = (int)((num2 * 62081320) ^ 0x76031676);
								continue;
							case 4u:
								return;
							case 33u:
								reconnectPacket._MapName = value + " Nexus";
								num17 = (int)((num2 * 2115272512) ^ 0x344C60BE);
								continue;
							case 16u:
								reconnectPacket._GameId = -2;
								num17 = (int)(num2 * 948123561) ^ -2127748574;
								continue;
							case 9u:
							{
								int num30;
								int num31;
								if (array.Length != 2)
								{
									num30 = 534559486;
									num31 = num30;
								}
								else
								{
									num30 = 516844265;
									num31 = num30;
								}
								num17 = num30 ^ ((int)num2 * -157206137);
								continue;
							}
							case 19u:
								goto IL_098f;
							case 5u:
								playerText._Send = false;
								_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0($"Current location: {Math.Round(_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP._PositionX, 1)}, {Math.Round(_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP._PositionY, 1)}");
								num17 = -1483513078;
								continue;
							case 23u:
								goto IL_0a15;
							case 15u:
							{
								int num28;
								int num29;
								if (_I7fsSHtlIjceZxLjj9RuBsOo13q._aCrqUtEobC4JELAJ9SKdNpyMHvF.TryGetValue(array[1].ToLower(), out value))
								{
									num28 = -229036871;
									num29 = num28;
								}
								else
								{
									num28 = -182536418;
									num29 = num28;
								}
								num17 = num28 ^ (int)(num2 * 1156014646);
								continue;
							}
							case 25u:
								goto IL_0a6b;
							case 20u:
								Settings.Default.Change();
								num17 = ((int)num2 * -1527675920) ^ 0x3050A16A;
								continue;
							case 14u:
								_50w8wVuv8bL5nhKaR2EHxjrTamB._xRCQ3Y8enVTevEwMAZe8WUmANbE(reconnectPacket);
								return;
							case 0u:
								reconnectPacket._Port = 2050;
								num17 = (int)(num2 * 916855739) ^ -357830690;
								continue;
							case 13u:
								reconnectPacket._Hostname = "127.0.0.1";
								num17 = (int)(num2 * 611952939) ^ -184346516;
								continue;
							case 17u:
								_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Unknown server!");
								return;
							case 29u:
								return;
							case 18u:
								return;
							case 11u:
								_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Connecting to: " + value);
								num17 = (int)(num2 * 1732984103) ^ -347248346;
								continue;
							case 3u:
								return;
							}
							break;
							IL_098f:
							int num36;
							if (Settings.Default.EnableLocCommand)
							{
								num17 = -1503005708;
								num36 = num17;
							}
							else
							{
								num17 = -154957677;
								num36 = num17;
							}
							continue;
							IL_0753:
							int num37;
							if (!(array[0] == "/l"))
							{
								num17 = -564094377;
								num37 = num17;
							}
							else
							{
								num17 = -1006679788;
								num37 = num17;
							}
							continue;
							IL_0733:
							int num38;
							if (!Settings.Default.EnableConnectCommand)
							{
								num17 = -1712388317;
								num38 = num17;
							}
							else
							{
								num17 = -351010149;
								num38 = num17;
							}
						}
						goto IL_0690;
						IL_0a15:
						int num39;
						if (!(array[0] == "/con"))
						{
							num17 = -1361958442;
							num39 = num17;
						}
						else
						{
							num17 = -1417258857;
							num39 = num17;
						}
						goto IL_0695;
					}
				case 0u:
					return;
				case 5u:
				{
					int num43;
					int num44;
					if (array.Length == 1)
					{
						num43 = -636101856;
						num44 = num43;
					}
					else
					{
						num43 = -1018051115;
						num44 = num43;
					}
					num = num43 ^ (int)(num2 * 1919184901);
					continue;
				}
				case 9u:
					return;
				case 4u:
				{
					int num45;
					int num46;
					if (Settings.Default.EnableTeleportToPlayerCommand)
					{
						num45 = 808092347;
						num46 = num45;
					}
					else
					{
						num45 = 767592542;
						num46 = num45;
					}
					num = num45 ^ (int)(num2 * 998309261);
					continue;
				}
				case 12u:
				{
					int num40;
					if (array.Length != 2)
					{
						num = -1265570669;
						num40 = num;
					}
					else
					{
						num = -672276365;
						num40 = num;
					}
					continue;
				}
				case 11u:
					return;
				case 13u:
					text = array[1].ToLower();
					num = -1164419516;
					continue;
				case 8u:
				{
					_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Teleporting to self!");
					_gXkgDctfNPN0Xyz8qvjQDIS73of gXkgDctfNPN0Xyz8qvjQDIS73of3 = (_gXkgDctfNPN0Xyz8qvjQDIS73of)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.TELEPORT);
					gXkgDctfNPN0Xyz8qvjQDIS73of3._fn2CRnBpjyTWHR9K8SU4iOwhDtK = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fn2CRnBpjyTWHR9K8SU4iOwhDtK;
					_50w8wVuv8bL5nhKaR2EHxjrTamB._WEI99xvr4YqzD1PAnL2WmiBhWKJ(gXkgDctfNPN0Xyz8qvjQDIS73of3);
					num = ((int)num2 * -247600723) ^ -171822290;
					continue;
				}
				case 3u:
					playerText._Send = false;
					num = -852138602;
					continue;
				case 6u:
					array = playerText._Message.Split(' ');
					if (array.Length != 0)
					{
						num = -225100984;
						continue;
					}
					return;
				case 10u:
					_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Usage: /tp [partial or full player name]");
					num = (int)(num2 * 215014787) ^ -718363310;
					continue;
				default:
				{
					using (Dictionary<int, PlayerData>.ValueCollection.Enumerator enumerator = _50w8wVuv8bL5nhKaR2EHxjrTamB._naDcMlPfaanTh6qrJ3cOuO4HNwz.Values.GetEnumerator())
					{
						while (true)
						{
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = -383970670;
								num4 = num3;
							}
							else
							{
								num3 = -74179290;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xA67D4B79u) % 8u)
								{
								case 6u:
									num3 = -383970670;
									continue;
								default:
									goto end_IL_026e;
								case 3u:
									current = enumerator.Current;
									num3 = -222315011;
									continue;
								case 0u:
									break;
								case 5u:
								{
									int num7;
									int num8;
									if (!current._WL2DOBxBuX9DARzf2KPoaJbgZiCb.ToLower().Contains(text))
									{
										num7 = -1300799904;
										num8 = num7;
									}
									else
									{
										num7 = -1187543807;
										num8 = num7;
									}
									num3 = num7 ^ ((int)num2 * -127224387);
									continue;
								}
								case 4u:
								{
									int num5;
									int num6;
									if (current._NNgacHsIcOUlk6tnbwwxK7FDsff())
									{
										num5 = -2025665199;
										num6 = num5;
									}
									else
									{
										num5 = -1298686500;
										num6 = num5;
									}
									num3 = num5 ^ (int)(num2 * 1212507724);
									continue;
								}
								case 1u:
								{
									_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Teleporting to " + current._WL2DOBxBuX9DARzf2KPoaJbgZiCb + "!");
									_gXkgDctfNPN0Xyz8qvjQDIS73of gXkgDctfNPN0Xyz8qvjQDIS73of = (_gXkgDctfNPN0Xyz8qvjQDIS73of)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.TELEPORT);
									gXkgDctfNPN0Xyz8qvjQDIS73of._fn2CRnBpjyTWHR9K8SU4iOwhDtK = current._fn2CRnBpjyTWHR9K8SU4iOwhDtK;
									_50w8wVuv8bL5nhKaR2EHxjrTamB._WEI99xvr4YqzD1PAnL2WmiBhWKJ(gXkgDctfNPN0Xyz8qvjQDIS73of);
									num3 = (int)((num2 * 2016917650) ^ 0x3A7C32A1);
									continue;
								}
								case 2u:
									return;
								case 7u:
									goto end_IL_026e;
								}
								break;
							}
						}
						end_IL_026e:;
					}
					_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Player with the name similar to " + text + " not found!");
					return;
				}
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private bool _aV6zgeYmJmZmnw6Lm4M4mqLtqlg(PlayerData enemy)
	{
		return enemy._fn2CRnBpjyTWHR9K8SU4iOwhDtK == _EeeRzHBDOL9AqYJ8CIuFvkR3Qlz;
	}
}
