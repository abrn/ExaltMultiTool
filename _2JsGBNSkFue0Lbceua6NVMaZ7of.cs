using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.DataStructures;
using ExaltMultiTool.Proxy.Mods;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class _2JsGBNSkFue0Lbceua6NVMaZ7of
{
	private Client _Client;

	private int _CurrentTime = -1;

	private int _MapWidth;

	public _2JsGBNSkFue0Lbceua6NVMaZ7of(Client client)
	{
		_Client = client;
		Projectile.Initialize();
	}

	public void OnMapInfo(MapInfoPacket mapInfo)
	{
		_MapWidth = mapInfo._Width;
		KeyValuePair<int, Dictionary<int, Projectile>> current = default(KeyValuePair<int, Dictionary<int, Projectile>>);
		while (true)
		{
			int num = 1293293234;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x16BF6601u) % 7u)
				{
				case 4u:
					break;
				case 1u:
					_Client.CurrentMapName = mapInfo._MapName;
					_Client._2CIHnoEa49dfPXyqt9nkkBlUcQf = new MapStructure[mapInfo._Width * mapInfo._Height];
					num = ((int)num2 * -65262235) ^ -1695567190;
					continue;
				case 3u:
					_Client._wfbcaMLbXqoFK8XA49K6agBsnJ2 = mapInfo._Height;
					num = ((int)num2 * -64165182) ^ 0x605D2948;
					continue;
				case 0u:
					_Client._naDcMlPfaanTh6qrJ3cOuO4HNwz.Clear();
					_Client._Aq9hW2NyDqEkITmxzYm6OCQLaDB.Clear();
					num = (int)(num2 * 2096364102) ^ -741491552;
					continue;
				case 6u:
					_Client._PositionX = mapInfo._Width;
					num = ((int)num2 * -790648029) ^ 0x1DBFBC51;
					continue;
				case 5u:
					_Client._VPArsrlUa0uEsW6OxAYV9WHJAMK.Clear();
					num = (int)((num2 * 1554937275) ^ 0x34B292F1);
					continue;
				default:
				{
					using (Dictionary<int, Dictionary<int, Projectile>>.Enumerator enumerator = _Client._N5GofMpQbwbVNiYLmSHHRmpmKhg.GetEnumerator())
					{
						while (true)
						{
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 924126457;
								num4 = num3;
							}
							else
							{
								num3 = 819424413;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x16BF6601u) % 5u)
								{
								case 0u:
									num3 = 819424413;
									continue;
								default:
									goto end_IL_0129;
								case 4u:
									break;
								case 1u:
									current.Value.Clear();
									num3 = (int)((num2 * 588383670) ^ 0x7E1D8525);
									continue;
								case 3u:
									current = enumerator.Current;
									num3 = 1494674987;
									continue;
								case 2u:
									goto end_IL_0129;
								}
								break;
							}
						}
						end_IL_0129:;
					}
					_Client._N5GofMpQbwbVNiYLmSHHRmpmKhg.Clear();
					return;
				}
				}
				break;
			}
		}
	}

	public void StartConnectNotificationTask()
	{
		if (Settings.Default.DisableSystemMessages)
		{
			return;
		}
		Task.Run((Action)ShowConnectedNotification);
	}

	private void ShowConnectedNotification()
	{
		Thread.Sleep(500);
		_Client.SendChatNotification("RealmStock", "Connected to MultiTool Proxy!");
	}

	public void OnUpdate(UpdatePacket update)
	{
		TileObject[] _2CIHnoEa49dfPXyqt9nkkBlUcQf = update._Tiles;
		int num = 0;
		GameObject gameObject = default(GameObject);
		PlayerData jI4Bueou7dItYp5S7QML5vyC6Rc = default(PlayerData);
		TileObject tileObject = default(TileObject);
		GameObject[] lakUpSXZB1zdJcCECL20tl6SVrT = default(GameObject[]);
		StatData current = default(StatData);
		int key = default(int);
		int[] lRLF1OvIoGLzzq1APVMdrraeXfZ = default(int[]);
		while (true)
		{
			int num2;
			int num3;
			if (num < _2CIHnoEa49dfPXyqt9nkkBlUcQf.Length)
			{
				num2 = 413459782;
				num3 = num2;
			}
			else
			{
				num2 = 1898177367;
				num3 = num2;
			}
			while (true)
			{
				int num9;
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x164A3065u) % 21u)
				{
				case 16u:
					num2 = 413459782;
					continue;
				case 9u:
					_Client._naDcMlPfaanTh6qrJ3cOuO4HNwz.Add(gameObject._Status._ObjectId, jI4Bueou7dItYp5S7QML5vyC6Rc);
					num2 = 366657872;
					continue;
				case 11u:
					if (Settings.Default.EnableGlow)
					{
						num2 = 1124155001;
						continue;
					}
					goto case 1u;
				case 8u:
				{
					int num18;
					int num19;
					if (!_Client._naDcMlPfaanTh6qrJ3cOuO4HNwz.ContainsKey(gameObject._Status._ObjectId))
					{
						num18 = -859132222;
						num19 = num18;
					}
					else
					{
						num18 = -1496119689;
						num19 = num18;
					}
					num2 = num18 ^ ((int)num4 * -128159457);
					continue;
				}
				case 13u:
					_Client._2CIHnoEa49dfPXyqt9nkkBlUcQf[tileObject._PositionX * _MapWidth + tileObject._PositionY] = new MapStructure(ResourceDownloader.GetTile.ById(tileObject._TileType), tileObject._PositionX, tileObject._PositionY, tileObject._TileType);
					num2 = (int)(num4 * 2016845451) ^ -1538371851;
					continue;
				case 12u:
				{
					int num12;
					int num13;
					if (gameObject._Status._ObjectId != _Client._UqAoky1lauc0gYPMEYUcYfMlJkC)
					{
						num12 = -815935218;
						num13 = num12;
					}
					else
					{
						num12 = -886882349;
						num13 = num12;
					}
					num2 = num12 ^ (int)(num4 * 2147063023);
					continue;
				}
				case 20u:
					num++;
					num2 = ((int)num4 * -196988770) ^ 0x52C2B4E1;
					continue;
				case 18u:
					_Client._PlayerData = jI4Bueou7dItYp5S7QML5vyC6Rc;
					num2 = (int)(num4 * 1312364546) ^ -1615361244;
					continue;
				case 14u:
					_Client.PotionSlots = GetPotionInfo(gameObject._Status._Stats);
					num2 = (int)((num4 * 540449009) ^ 0x5AB61F31);
					continue;
				case 2u:
				{
					gameObject = lakUpSXZB1zdJcCECL20tl6SVrT[num];
					jI4Bueou7dItYp5S7QML5vyC6Rc = new PlayerData(gameObject);
					int num20;
					if (jI4Bueou7dItYp5S7QML5vyC6Rc._LePIFyFWrqLo6WMlJ4cV5MZBUqq)
					{
						num2 = 1568978938;
						num20 = num2;
					}
					else
					{
						num2 = 185815771;
						num20 = num2;
					}
					continue;
				}
				case 7u:
					_Client._Aq9hW2NyDqEkITmxzYm6OCQLaDB.Remove(gameObject._Status._ObjectId);
					num2 = (int)((num4 * 1193905894) ^ 0x552F2346);
					continue;
				case 15u:
					_Client._naDcMlPfaanTh6qrJ3cOuO4HNwz.Remove(gameObject._Status._ObjectId);
					num2 = ((int)num4 * -140232547) ^ 0x4B83C3E0;
					continue;
				case 17u:
				{
					int num10;
					int num11;
					if (!_Client._Aq9hW2NyDqEkITmxzYm6OCQLaDB.ContainsKey(gameObject._Status._ObjectId))
					{
						num10 = -1320613151;
						num11 = num10;
					}
					else
					{
						num10 = -2011536792;
						num11 = num10;
					}
					num2 = num10 ^ (int)(num4 * 1185818701);
					continue;
				}
				case 19u:
					if (jI4Bueou7dItYp5S7QML5vyC6Rc._W6bpBrAw6dPSILcVRK394JGD7tC)
					{
						num2 = 667971631;
						continue;
					}
					goto case 1u;
				case 6u:
					if (jI4Bueou7dItYp5S7QML5vyC6Rc._fn2CRnBpjyTWHR9K8SU4iOwhDtK == _Client._UqAoky1lauc0gYPMEYUcYfMlJkC)
					{
						num2 = (int)(num4 * 1365050391) ^ -989316540;
						continue;
					}
					goto case 1u;
				case 5u:
					tileObject = _2CIHnoEa49dfPXyqt9nkkBlUcQf[num];
					num2 = 76370995;
					continue;
				case 10u:
					lakUpSXZB1zdJcCECL20tl6SVrT = update._NewObjects;
					num = 0;
					goto IL_05c6;
				case 0u:
					break;
				case 3u:
					_Client._Aq9hW2NyDqEkITmxzYm6OCQLaDB.Add(gameObject._Status._ObjectId, jI4Bueou7dItYp5S7QML5vyC6Rc);
					num2 = 1531324731;
					continue;
				default:
				{
					using (List<StatData>.Enumerator enumerator = gameObject._Status._Stats.GetEnumerator())
					{
						while (true)
						{
							int num5;
							int num6;
							if (!enumerator.MoveNext())
							{
								num5 = 1484150305;
								num6 = num5;
							}
							else
							{
								num5 = 374981465;
								num6 = num5;
							}
							while (true)
							{
								switch ((num4 = (uint)num5 ^ 0x164A3065u) % 6u)
								{
								case 0u:
									num5 = 374981465;
									continue;
								default:
									goto end_IL_0392;
								case 4u:
									current = enumerator.Current;
									num5 = 891462600;
									continue;
								case 1u:
									break;
								case 3u:
								{
									int num7;
									int num8;
									if (StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType._xVocavI0hcsRzgIG8GBJzzzmpdi))
									{
										num7 = -1123352762;
										num8 = num7;
									}
									else
									{
										num7 = -701453396;
										num8 = num7;
									}
									num5 = num7 ^ ((int)num4 * -483684998);
									continue;
								}
								case 5u:
									current._StatValue = 100;
									goto end_IL_0392;
								case 2u:
									goto end_IL_0392;
								}
								break;
							}
						}
						end_IL_0392:;
					}
					goto case 1u;
				}
				case 1u:
					{
						if (_Client._VPArsrlUa0uEsW6OxAYV9WHJAMK.ContainsKey(gameObject._Status._ObjectId))
						{
							goto IL_046c;
						}
						goto IL_04f5;
					}
					IL_046c:
					num9 = 1184301246;
					goto IL_0471;
					IL_0471:
					while (true)
					{
						switch ((num4 = (uint)num9 ^ 0x164A3065u) % 16u)
						{
						case 8u:
							break;
						default:
							return;
						case 14u:
							goto IL_04c7;
						case 12u:
							goto IL_04f5;
						case 10u:
							num9 = ((int)num4 * -229809024) ^ 0x66838840;
							continue;
						case 15u:
							num++;
							num9 = 1630524736;
							continue;
						case 11u:
							_Client._VPArsrlUa0uEsW6OxAYV9WHJAMK.Remove(gameObject._Status._ObjectId);
							num9 = (int)((num4 * 1327539164) ^ 0x58236D8D);
							continue;
						case 5u:
							goto IL_056e;
						case 13u:
							_Client._VPArsrlUa0uEsW6OxAYV9WHJAMK.Remove(key);
							num9 = ((int)num4 * -1993966505) ^ 0x5A092FB1;
							continue;
						case 2u:
							num++;
							num9 = (int)((num4 * 146485667) ^ 0x6338A66A);
							continue;
						case 9u:
							goto IL_05c6;
						case 3u:
							goto IL_05d9;
						case 7u:
							_Client._Aq9hW2NyDqEkITmxzYm6OCQLaDB.Remove(key);
							num9 = (int)(num4 * 237371730) ^ -1890602360;
							continue;
						case 4u:
							lRLF1OvIoGLzzq1APVMdrraeXfZ = update._Drops;
							num = 0;
							num9 = (int)((num4 * 2019051782) ^ 0x56F6FCF7);
							continue;
						case 1u:
							goto IL_0644;
						case 6u:
							_Client._naDcMlPfaanTh6qrJ3cOuO4HNwz.Remove(key);
							num9 = ((int)num4 * -1728596732) ^ -123728372;
							continue;
						case 0u:
							return;
						}
						break;
						IL_0644:
						int num14;
						if (_Client._VPArsrlUa0uEsW6OxAYV9WHJAMK.ContainsKey(key))
						{
							num9 = 453787784;
							num14 = num9;
						}
						else
						{
							num9 = 1675100986;
							num14 = num9;
						}
						continue;
						IL_056e:
						int num15;
						if (num < lRLF1OvIoGLzzq1APVMdrraeXfZ.Length)
						{
							num9 = 861180059;
							num15 = num9;
						}
						else
						{
							num9 = 2032244805;
							num15 = num9;
						}
						continue;
						IL_04c7:
						key = lRLF1OvIoGLzzq1APVMdrraeXfZ[num];
						int num16;
						if (_Client._Aq9hW2NyDqEkITmxzYm6OCQLaDB.ContainsKey(key))
						{
							num9 = 1378625138;
							num16 = num9;
						}
						else
						{
							num9 = 1467783382;
							num16 = num9;
						}
						continue;
						IL_05d9:
						int num17;
						if (_Client._naDcMlPfaanTh6qrJ3cOuO4HNwz.ContainsKey(key))
						{
							num9 = 1286034947;
							num17 = num9;
						}
						else
						{
							num9 = 1495644564;
							num17 = num9;
						}
					}
					goto IL_046c;
					IL_05c6:
					if (num < lakUpSXZB1zdJcCECL20tl6SVrT.Length)
					{
						goto case 2u;
					}
					num9 = 1918360561;
					goto IL_0471;
					IL_04f5:
					_Client._VPArsrlUa0uEsW6OxAYV9WHJAMK.Add(gameObject._Status._ObjectId, jI4Bueou7dItYp5S7QML5vyC6Rc);
					num9 = 151437575;
					goto IL_0471;
				}
				break;
			}
		}
	}

	private void ParsePotionSlots(List<StatData> data)
	{
		PotionInfo potionInfo = _Client.PotionSlots.ElementAt(0);
		data.Add(new StatData
		{
			_StatType = StatType.QuickslotOne,
			_StatValue = potionInfo.Type,
			_MagicByte = potionInfo.Quantity,
			_StringStatValue = string.Empty
		});
		potionInfo = _Client.PotionSlots.ElementAt(1);
		data.Add(new StatData
		{
			_StatType = StatType.QuickslotTwo,
			_StatValue = potionInfo.Type,
			_MagicByte = potionInfo.Quantity,
			_StringStatValue = string.Empty
		});
		potionInfo = _Client.PotionSlots.ElementAt(2);
		data.Add(new StatData
		{
			_StatType = StatType.QuickslotThree,
			_StatValue = potionInfo.Type,
			_MagicByte = potionInfo.Quantity,
			_StringStatValue = string.Empty
		});
	}

	private PotionInfo[] GetPotionInfo(IEnumerable<StatData> statusData)
	{
		PotionInfo[] array = new PotionInfo[3];
		IEnumerator<StatData> enumerator = statusData.GetEnumerator();
		try
		{
			StatData current = default(StatData);
			while (true)
			{
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -1856421621;
					num2 = num;
				}
				else
				{
					num = -1276220744;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xF991FE40u) % 10u)
					{
					case 4u:
						num = -1276220744;
						continue;
					case 9u:
						array[2] = new PotionInfo(current._StatValue, current._MagicByte);
						num = (int)((num3 * 1272431207) ^ 0x65E00993);
						continue;
					case 1u:
						array[0] = new PotionInfo(current._StatValue, current._MagicByte);
						num = ((int)num3 * -1506524567) ^ -840567130;
						continue;
					case 0u:
						break;
					case 8u:
					{
						int num5;
						if (StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType.QuickslotTwo))
						{
							num = -170153674;
							num5 = num;
						}
						else
						{
							num = -1035999063;
							num5 = num;
						}
						continue;
					}
					case 3u:
					{
						int num6;
						if (StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType.QuickslotThree))
						{
							num = -28454293;
							num6 = num;
						}
						else
						{
							num = -775204130;
							num6 = num;
						}
						continue;
					}
					case 7u:
						num = ((int)num3 * -2066579404) ^ -917573550;
						continue;
					case 6u:
						array[1] = new PotionInfo(current._StatValue, current._MagicByte);
						num = ((int)num3 * -588166001) ^ 0x7C58B034;
						continue;
					case 2u:
					{
						current = enumerator.Current;
						int num4;
						if (!StatType._BEkCFGP4TWapPej8J0mAjEGM8LD(current._StatType, StatType.QuickslotOne))
						{
							num = -2099395234;
							num4 = num;
						}
						else
						{
							num = -1325988255;
							num4 = num;
						}
						continue;
					}
					default:
						return array;
					case 5u:
						return array;
					}
					break;
				}
			}
		}
		finally
		{
			while (true)
			{
				int num7 = -1508319190;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num7 ^ 0xF991FE40u) % 3u)
					{
						case 0u:
							break;
						default:
							goto end_IL_016d;
						case 2u:
							goto IL_0192;
						case 1u:
							goto end_IL_016d;
					}
					break;
					IL_0192:
					enumerator.Dispose();
					num7 = (int)((num3 * 504510617) ^ 0xBBC7DC9);
				}
			}
			end_IL_016d:;
		}
	}

	public void OnNewTick(NewTickPacket newTick)
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
					num = 1017578307;
					num2 = num;
				}
				else
				{
					num = 901204772;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x834E68Fu) % 6u)
					{
					case 4u:
						num = 901204772;
						continue;
					default:
						goto end_IL_000c;
					case 5u:
						current = enumerator.Current;
						num = 1491846690;
						continue;
					case 1u:
					{
						int num4;
						int num5;
						if (!_Client._VPArsrlUa0uEsW6OxAYV9WHJAMK.ContainsKey(current._ObjectId))
						{
							num4 = 575354944;
							num5 = num4;
						}
						else
						{
							num4 = 1305055991;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 352317452);
						continue;
					}
					case 3u:
						break;
					case 0u:
						_Client._VPArsrlUa0uEsW6OxAYV9WHJAMK[current._ObjectId]._JV6zl0lA6JLQZNtpbYVFdWCNsay(current, newTick._MzlKH2guiz5FZ1cN2sOqdMa185b, newTick._D4Xpe2utS1cwv8fGTeXUOkTlvMi, newTick._D4Xpe2utS1cwv8fGTeXUOkTlvMi, _CurrentTime);
						num = (int)(num3 * 562612159) ^ -1251820864;
						continue;
					case 2u:
						goto end_IL_000c;
					}
					break;
				}
			}
			end_IL_000c:;
		}
		if (_Client._QtBizqH8aHz2ixkvUsA6VqqwHGF == -1)
		{
			return;
		}
		Status current2 = default(Status);
		while (true)
		{
			int num6 = 1885003006;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num6 ^ 0x834E68Fu) % 4u)
				{
				case 0u:
					break;
				case 1u:
				{
					int num12;
					int num13;
					if (Environment.TickCount - _Client._QtBizqH8aHz2ixkvUsA6VqqwHGF <= 1000)
					{
						num12 = -2097939861;
						num13 = num12;
					}
					else
					{
						num12 = -1298941642;
						num13 = num12;
					}
					num6 = num12 ^ ((int)num3 * -613920154);
					continue;
				}
				case 3u:
					_Client._QtBizqH8aHz2ixkvUsA6VqqwHGF = -1;
					num6 = (int)(num3 * 1972568487) ^ -1109051660;
					continue;
				default:
				{
					using (List<Status>.Enumerator enumerator = newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.GetEnumerator())
					{
						while (true)
						{
							int num7;
							int num8;
							if (!enumerator.MoveNext())
							{
								num7 = 446680987;
								num8 = num7;
							}
							else
							{
								num7 = 20301408;
								num8 = num7;
							}
							while (true)
							{
								switch ((num3 = (uint)num7 ^ 0x834E68Fu) % 6u)
								{
								case 2u:
									num7 = 20301408;
									continue;
								default:
									goto end_IL_0189;
								case 1u:
									ParsePotionSlots(current2._Stats);
									return;
								case 0u:
								{
									int num9;
									int num10;
									if (_Client._UqAoky1lauc0gYPMEYUcYfMlJkC == current2._ObjectId)
									{
										num9 = -1819150616;
										num10 = num9;
									}
									else
									{
										num9 = -1324024856;
										num10 = num9;
									}
									num7 = num9 ^ (int)(num3 * 1930279734);
									continue;
								}
								case 3u:
									break;
								case 5u:
									current2 = enumerator.Current;
									num7 = 2007057579;
									continue;
								case 4u:
									goto end_IL_0189;
								}
								break;
							}
						}
						end_IL_0189:;
					}
					Status status = new Status();
					status._Position = _Client._PlayerData._IlcbhoOIM3MRszn9mfn3IKjnXc0;
					while (true)
					{
						int num11 = 1310959337;
						while (true)
						{
							switch ((num3 = (uint)num11 ^ 0x834E68Fu) % 5u)
							{
							case 3u:
								break;
							default:
								return;
							case 4u:
								status._ObjectId = _Client._UqAoky1lauc0gYPMEYUcYfMlJkC;
								num11 = (int)((num3 * 1776382028) ^ 0x535B08D0);
								continue;
							case 0u:
								newTick._UEmErv2L2MQXrwsVtG0rtsVhAnB.Add(status);
								num11 = ((int)num3 * -726773312) ^ -542037797;
								continue;
							case 1u:
								status._Stats = new List<StatData>();
								ParsePotionSlots(status._Stats);
								num11 = ((int)num3 * -1244988189) ^ -1032351179;
								continue;
							case 2u:
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
	}

	public void OnMove(MovePacket move)
	{
		_CurrentTime = Environment.TickCount;
		if (_Client._PlayerData == null)
		{
			return;
		}
		_Client._PlayerData._Position = move._NewPosition;
	}

	public void OnEnemyShoot(EnemyShootPacket enemyShoot)
	{
		if (!_Client._VPArsrlUa0uEsW6OxAYV9WHJAMK.ContainsKey(enemyShoot._OwnerId))
		{
			goto IL_001b;
		}
		goto IL_031c;
		IL_031c:
		PlayerData jI4Bueou7dItYp5S7QML5vyC6Rc = _Client._VPArsrlUa0uEsW6OxAYV9WHJAMK[enemyShoot._OwnerId];
		int num = 1348272505;
		goto IL_0020;
		IL_0020:
		Dictionary<int, Projectile> dictionary = default(Dictionary<int, Projectile>);
		byte b = default(byte);
		int num9 = default(int);
		ProjectileStructure structure = default(ProjectileStructure);
		Dictionary<byte, ProjectileStructure> dictionary2 = default(Dictionary<byte, ProjectileStructure>);
		Projectile value = default(Projectile);
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x27E9A967u) % 28u)
			{
			case 22u:
				break;
			default:
				return;
			case 5u:
				num = ((int)num2 * -1038823240) ^ 0x6B108AE4;
				continue;
			case 2u:
				goto IL_00b9;
			case 8u:
				return;
			case 21u:
			{
				int num7;
				int num8;
				if (!dictionary.ContainsKey(b))
				{
					num7 = 1466581359;
					num8 = num7;
				}
				else
				{
					num7 = 332275612;
					num8 = num7;
				}
				num = num7 ^ ((int)num2 * -1356221840);
				continue;
			}
			case 14u:
				num9 = 0;
				num = (int)((num2 * 1097253139) ^ 0x22FE1DA3);
				continue;
			case 17u:
				structure = dictionary2[enemyShoot._BulletType];
				num = 1907331609;
				continue;
			case 9u:
				Program.LogNetworkInfo("client", $"Unable to find enemy type in map, enemytype: {jI4Bueou7dItYp5S7QML5vyC6Rc._y2nCjecGeYsmqDEzaplcuBvYtN7} ({jI4Bueou7dItYp5S7QML5vyC6Rc._dzjzSFbtOGDAQRisUTP7vokTlVD})");
				num = (int)((num2 * 1353711768) ^ 0x42288EDB);
				continue;
			case 15u:
				value.OwnerId = enemyShoot._OwnerId;
				value.Damage = enemyShoot._Damage;
				value.ProjectileType = enemyShoot._BulletType;
				value.Structure = structure;
				num = (int)((num2 * 506595646) ^ 0xBBD10D4);
				continue;
			case 10u:
				dictionary = new Dictionary<int, Projectile>();
				num = (int)(num2 * 284884012) ^ -1118789;
				continue;
			case 23u:
				num9++;
				num = 783971833;
				continue;
			case 25u:
				value.Id = b;
				num = ((int)num2 * -744563834) ^ -1337826114;
				continue;
			case 0u:
				dictionary.Add(b, value);
				num = 678638908;
				continue;
			case 6u:
				return;
			case 19u:
				dictionary[b] = value;
				num = ((int)num2 * -1846369668) ^ 0x3C925F8E;
				continue;
			case 27u:
				b = (byte)((enemyShoot._BulletId + num9) % 256);
				num = 1965628637;
				continue;
			case 13u:
			{
				int num5;
				int num6;
				if (dictionary2.ContainsKey(enemyShoot._BulletType))
				{
					num5 = 607588613;
					num6 = num5;
				}
				else
				{
					num5 = 1576540454;
					num6 = num5;
				}
				num = num5 ^ ((int)num2 * -2113775690);
				continue;
			}
			case 18u:
				value = default(Projectile);
				num = ((int)num2 * -1268128171) ^ -159083244;
				continue;
			case 16u:
				return;
			case 26u:
			{
				int num3;
				int num4;
				if (!Projectile.ObjectTypeToProjectileIdStructureMap.ContainsKey(jI4Bueou7dItYp5S7QML5vyC6Rc._y2nCjecGeYsmqDEzaplcuBvYtN7))
				{
					num3 = 1960275938;
					num4 = num3;
				}
				else
				{
					num3 = 178584300;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -457334212);
				continue;
			}
			case 24u:
				num = (int)((num2 * 1345778462) ^ 0x1D365432);
				continue;
			case 1u:
				dictionary = _Client._N5GofMpQbwbVNiYLmSHHRmpmKhg[enemyShoot._OwnerId];
				num = 443892866;
				continue;
			case 20u:
				goto IL_031c;
			case 3u:
				dictionary2 = Projectile.ObjectTypeToProjectileIdStructureMap[jI4Bueou7dItYp5S7QML5vyC6Rc._y2nCjecGeYsmqDEzaplcuBvYtN7];
				num = 1219414074;
				continue;
			case 7u:
				Program.LogNetworkInfo("client", $"Unable to find enemy projectile type in map, enemytype: {jI4Bueou7dItYp5S7QML5vyC6Rc._y2nCjecGeYsmqDEzaplcuBvYtN7} ({jI4Bueou7dItYp5S7QML5vyC6Rc._dzjzSFbtOGDAQRisUTP7vokTlVD})");
				num = (int)((num2 * 1698108007) ^ 0x13762240);
				continue;
			case 4u:
				goto IL_0390;
			case 12u:
				_Client._N5GofMpQbwbVNiYLmSHHRmpmKhg.Add(enemyShoot._OwnerId, dictionary);
				num = (int)(num2 * 1095089301) ^ -81806693;
				continue;
			case 11u:
				return;
			}
			break;
			IL_0390:
			int num10;
			if (!_Client._N5GofMpQbwbVNiYLmSHHRmpmKhg.ContainsKey(enemyShoot._OwnerId))
			{
				num = 342794149;
				num10 = num;
			}
			else
			{
				num = 260193274;
				num10 = num;
			}
			continue;
			IL_00b9:
			int num11;
			if (num9 >= enemyShoot._wQ07ok3AId78vEC0Lsubhb1cWYS)
			{
				num = 1259485848;
				num11 = num;
			}
			else
			{
				num = 2044969068;
				num11 = num;
			}
		}
		goto IL_001b;
		IL_001b:
		num = 435666867;
		goto IL_0020;
	}

	public void OnInvResult(InvResultPacket invResult)
	{
		//Discarded unreachable code: IL_0122, IL_02ae, IL_03fb
		_h01g85taqEzEcEAUdKYKgvZNupF(invResult._SlotOne);
		byte b = default(byte);
		while (true)
		{
			int num = -1904121511;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x860E028Eu) % 21u)
				{
				case 7u:
					break;
				default:
					return;
				case 1u:
				{
					int num13;
					if (invResult._SlotOne._SlotId >= 1000000)
					{
						num = -420565490;
						num13 = num;
					}
					else
					{
						num = -1332722843;
						num13 = num;
					}
					continue;
				}
				case 12u:
					_Client.PotionSlots[invResult._SlotOne._SlotId - 1000000].Quantity = 0;
					num = (int)(num2 * 1743529491) ^ -1692260871;
					continue;
				case 17u:
					_Client.PotionSlots[invResult._SlotOne._SlotId - 1000000].Quantity ^= _Client.PotionSlots[invResult._SlotTwo._SlotId - 1000000].Quantity;
					return;
				case 10u:
				{
					int num18;
					int num19;
					if (invResult._SlotTwo._SlotId >= 1000000)
					{
						num18 = 1230568533;
						num19 = num18;
					}
					else
					{
						num18 = 787767362;
						num19 = num18;
					}
					num = num18 ^ (int)(num2 * 995467039);
					continue;
				}
				case 3u:
					b = --_Client.PotionSlots[invResult._SlotOne._SlotId - 1000000].Quantity;
					num = ((int)num2 * -357200076) ^ 0x440AD662;
					continue;
				case 5u:
				{
					int num9;
					if (invResult._SlotOne._SlotId >= 1000000)
					{
						num = -1059988965;
						num9 = num;
					}
					else
					{
						num = -202594999;
						num9 = num;
					}
					continue;
				}
				case 15u:
				{
					b = ++_Client.PotionSlots[invResult._SlotTwo._SlotId - 1000000].Quantity;
					int num16;
					int num17;
					if (b > 6)
					{
						num16 = 43518742;
						num17 = num16;
					}
					else
					{
						num16 = 139963125;
						num17 = num16;
					}
					num = num16 ^ ((int)num2 * -274378169);
					continue;
				}
				case 11u:
				{
					int num12;
					if (invResult._SlotOne._SlotId >= 1000000)
					{
						num = -1156539720;
						num12 = num;
					}
					else
					{
						num = -1952133098;
						num12 = num;
					}
					continue;
				}
				case 20u:
					_h01g85taqEzEcEAUdKYKgvZNupF(invResult._SlotTwo);
					num = ((int)num2 * -634137604) ^ -216968104;
					continue;
				case 0u:
				{
					int num5;
					int num6;
					if (b <= 0)
					{
						num5 = 1121104900;
						num6 = num5;
					}
					else
					{
						num5 = 1607222164;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1512040495);
					continue;
				}
				case 18u:
					_Client.PotionSlots[invResult._SlotTwo._SlotId - 1000000].Quantity = 6;
					num = ((int)num2 * -910842810) ^ -674505082;
					continue;
				case 16u:
					return;
				case 13u:
					_Client.PotionSlots[invResult._SlotOne._SlotId - 1000000].Quantity ^= _Client.PotionSlots[invResult._SlotTwo._SlotId - 1000000].Quantity;
					_Client.PotionSlots[invResult._SlotTwo._SlotId - 1000000].Quantity ^= _Client.PotionSlots[invResult._SlotOne._SlotId - 1000000].Quantity;
					num = ((int)num2 * -1151225643) ^ -1817340885;
					continue;
				case 9u:
				{
					int num14;
					int num15;
					if (_Client.PotionSlots[invResult._SlotOne._SlotId - 1000000].Quantity != _Client.PotionSlots[invResult._SlotTwo._SlotId - 1000000].Quantity)
					{
						num14 = 178420240;
						num15 = num14;
					}
					else
					{
						num14 = 1390800072;
						num15 = num14;
					}
					num = num14 ^ (int)(num2 * 1702168563);
					continue;
				}
				case 2u:
				{
					int num10;
					int num11;
					if (invResult._SlotTwo._SlotId >= 1000000)
					{
						num10 = -488132251;
						num11 = num10;
					}
					else
					{
						num10 = -1081832808;
						num11 = num10;
					}
					num = num10 ^ ((int)num2 * -959353212);
					continue;
				}
				case 14u:
					return;
				case 19u:
				{
					int num7;
					int num8;
					if (invResult._Success)
					{
						num7 = -373211092;
						num8 = num7;
					}
					else
					{
						num7 = -663406066;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 1066626583);
					continue;
				}
				case 4u:
					_Client.PotionSlots[invResult._SlotOne._SlotId - 1000000].Type = -1;
					num = ((int)num2 * -1525215761) ^ 0x73BA1D59;
					continue;
				case 8u:
				{
					int num3;
					int num4;
					if (invResult._SlotTwo._SlotId >= 1000000)
					{
						num3 = 1254135837;
						num4 = num3;
					}
					else
					{
						num3 = 34504416;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 941219305);
					continue;
				}
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void _h01g85taqEzEcEAUdKYKgvZNupF(SlotObjectData slot)
	{
		if (slot._SlotId >= 1000000)
		{
			goto IL_0010;
		}
		goto IL_0228;
		IL_0228:
		bool flag = _Client.CurrentMapName == "Vault";
		int num;
		int num2;
		if (!(slot._ObjectId == _Client._itBzbWMkvo0AuQGuR19us26p4TP && flag))
		{
			num = 1140993665;
			num2 = num;
		}
		else
		{
			num = 1793424066;
			num2 = num;
		}
		goto IL_0015;
		IL_0015:
		PlayerData playerData = default(PlayerData);
		int num4 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x2C78A06Cu) % 27u)
			{
			case 18u:
				break;
			default:
				return;
			case 22u:
				playerData = _Client._VPArsrlUa0uEsW6OxAYV9WHJAMK[slot._ObjectId];
				num = 659699202;
				continue;
			case 17u:
				return;
			case 5u:
				goto IL_00ca;
			case 1u:
				_Client._zGfl045ehROhk6jo6nvkc12rcvH[slot._SlotId] = slot._ObjectType;
				num = (int)(num3 * 1685156370) ^ -701094280;
				continue;
			case 9u:
				goto IL_0111;
			case 13u:
				Array.Resize(ref playerData.Inventory, slot._SlotId + 1);
				num = ((int)num3 * -738481746) ^ -407514011;
				continue;
			case 16u:
				goto IL_0155;
			case 6u:
				return;
			case 15u:
				_Client._Pg28U1MUv2y9I7GawSrEglFuQNv[slot._SlotId] = slot._ObjectType;
				num = ((int)num3 * -737819356) ^ -702956381;
				continue;
			case 11u:
				_Client._geK4oHsbAS9nZM9pjvAHYVUnwQs[slot._SlotId] = slot._ObjectType;
				num = ((int)num3 * -1472455225) ^ -1746078240;
				continue;
			case 8u:
				goto IL_01e0;
			case 23u:
				playerData.Inventory[slot._SlotId] = slot._ObjectType;
				num = 1987680929;
				continue;
			case 2u:
				goto IL_0228;
			case 21u:
				_Client.PotionSlots[slot._SlotId - 1000000].Type = slot._ObjectType;
				num = (int)((num3 * 2060382297) ^ 0x30164861);
				continue;
			case 19u:
				goto IL_029e;
			case 0u:
				return;
			case 20u:
				num4++;
				num = ((int)num3 * -1457418073) ^ -1592738860;
				continue;
			case 26u:
				return;
			case 4u:
				Program.LogNetworkInfo("client", $"Bad InvResult slot {slot}");
				num = (int)(num3 * 1105700412) ^ -1046164995;
				continue;
			case 7u:
			{
				int num5;
				int num6;
				if (playerData == null)
				{
					num5 = 1497299455;
					num6 = num5;
				}
				else
				{
					num5 = 779745565;
					num6 = num5;
				}
				num = num5 ^ ((int)num3 * -1999150065);
				continue;
			}
			case 10u:
				return;
			case 24u:
				num4 = playerData.Inventory.Length;
				num = ((int)num3 * -1260564607) ^ 0x152D7ECE;
				continue;
			case 14u:
				goto IL_037a;
			case 12u:
				playerData.Inventory[num4] = -1;
				num = 1053751199;
				continue;
			case 25u:
				return;
			case 3u:
				return;
			}
			break;
			IL_037a:
			int num7;
			if (!(slot._ObjectId == _Client._29Cygi7ILPhL4sLWfXR3KEYpYle && flag))
			{
				num = 1990809147;
				num7 = num;
			}
			else
			{
				num = 839737413;
				num7 = num;
			}
			continue;
			IL_01e0:
			int num8;
			if (!(slot._ObjectId == _Client._mVrHB9iWE8fKC1cy09EH2Tg38G && flag))
			{
				num = 1740231496;
				num8 = num;
			}
			else
			{
				num = 1184874142;
				num8 = num;
			}
			continue;
			IL_0111:
			int num9;
			if (num4 < playerData.Inventory.Length)
			{
				num = 749904379;
				num9 = num;
			}
			else
			{
				num = 1826168326;
				num9 = num;
			}
			continue;
			IL_029e:
			int num10;
			if (!_Client._VPArsrlUa0uEsW6OxAYV9WHJAMK.ContainsKey(slot._ObjectId))
			{
				num = 308705332;
				num10 = num;
			}
			else
			{
				num = 2122152651;
				num10 = num;
			}
			continue;
			IL_00ca:
			int num11;
			if (slot._SlotId != -1)
			{
				num = 666978975;
				num11 = num;
			}
			else
			{
				num = 895731051;
				num11 = num;
			}
			continue;
			IL_0155:
			int num12;
			if (slot._SlotId >= playerData.Inventory.Length)
			{
				num = 531855288;
				num12 = num;
			}
			else
			{
				num = 1826168326;
				num12 = num;
			}
		}
		goto IL_0010;
		IL_0010:
		num = 1618847397;
		goto IL_0015;
	}

	public void OnUseItem(UseItemPacket useItem)
	{
		if (!useItem._Send)
		{
			return;
		}
		while (true)
		{
			int num = -150872223;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90947E50u) % 5u)
				{
				case 4u:
					break;
				default:
					return;
				case 0u:
					_Client.PotionSlots[useItem._obJo3i4uC8yf7c2aS8NBvEttXTO._SlotId - 1000000].Quantity--;
					num = ((int)num2 * -64439244) ^ 0x5FB16879;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (useItem._obJo3i4uC8yf7c2aS8NBvEttXTO._SlotId >= 1000000)
					{
						num5 = 175814765;
						num6 = num5;
					}
					else
					{
						num5 = 160978094;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 1771852969);
					continue;
				}
				case 2u:
				{
					int num3;
					int num4;
					if (useItem._obJo3i4uC8yf7c2aS8NBvEttXTO._ObjectId != _Client._UqAoky1lauc0gYPMEYUcYfMlJkC)
					{
						num3 = 883066495;
						num4 = num3;
					}
					else
					{
						num3 = 2098733849;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -423569458);
					continue;
				}
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void OnInvDrop(InvDropPacket invDrop)
	{
		if (invDrop._SlotObject._ObjectId != _Client._UqAoky1lauc0gYPMEYUcYfMlJkC)
		{
			return;
		}
		while (true)
		{
			int num = 1810483787;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5B792954u) % 4u)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
				{
					int num3;
					int num4;
					if (invDrop._SlotObject._SlotId >= 1000000)
					{
						num3 = 571265783;
						num4 = num3;
					}
					else
					{
						num3 = 470786438;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -498605499);
					continue;
				}
				case 0u:
					_Client.PotionSlots[invDrop._SlotObject._SlotId - 1000000].Quantity--;
					num = ((int)num2 * -65986427) ^ -436039163;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public void OnPlayerText(PlayerTextPacket playerText)
	{
		if (string.IsNullOrEmpty(playerText._Message))
		{
			return;
		}
		StringBuilder stringBuilder = default(StringBuilder);
		ClassStats classStats = default(ClassStats);
		PlayerData jI4Bueou7dItYp5S7QML5vyC6Rc = default(PlayerData);
		while (true)
		{
			int num = 1482039755;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6710DCB8u) % 20u)
				{
				case 12u:
					break;
				case 6u:
					stringBuilder.Append("\nVitality remaining: ");
					num = (int)(num2 * 756460497) ^ -345858134;
					continue;
				case 1u:
				{
					int num5;
					int num6;
					if (!ClassStats.Map.ContainsKey(_Client._PlayerData._y2nCjecGeYsmqDEzaplcuBvYtN7))
					{
						num5 = -522150621;
						num6 = num5;
					}
					else
					{
						num5 = -710367303;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -45704040);
					continue;
				}
				case 19u:
					stringBuilder.Append(classStats.AttackMax - (jI4Bueou7dItYp5S7QML5vyC6Rc._bBJk4iACRRWH5nKpWQUkuEqm6gk - jI4Bueou7dItYp5S7QML5vyC6Rc._BKy1MLJhjlNiHFd9unDtgMtCiJA));
					num = ((int)num2 * -1526451493) ^ 0x271FFBE2;
					continue;
				case 4u:
					stringBuilder.Append("'s stats left to max:\nLife pots remaining: ");
					num = (int)(num2 * 1247859005) ^ -326434305;
					continue;
				case 10u:
					return;
				case 7u:
					return;
				case 15u:
					stringBuilder.Append("\nDefense remaining: ");
					num = ((int)num2 * -308949997) ^ -848964087;
					continue;
				case 18u:
					stringBuilder.Append("\nAttack remaining: ");
					num = (int)(num2 * 456892026) ^ -1321874097;
					continue;
				case 16u:
					classStats = ClassStats.Map[_Client._PlayerData._y2nCjecGeYsmqDEzaplcuBvYtN7];
					stringBuilder = new StringBuilder("Your ");
					num = (int)(num2 * 326514028) ^ -754457998;
					continue;
				case 5u:
					stringBuilder.Append((int)(Math.Ceiling((double)classStats.ManaMax - (double)(jI4Bueou7dItYp5S7QML5vyC6Rc._fF7gBqWhNS2rU2VVZ6MjwK2DhTU - jI4Bueou7dItYp5S7QML5vyC6Rc._wzpxa5RCfmp0pzIjBVfGYkOFlkN)) * 0.2));
					num = ((int)num2 * -535951929) ^ 0x8D0E669;
					continue;
				case 8u:
					stringBuilder.Append(classStats.DefenseMax - (jI4Bueou7dItYp5S7QML5vyC6Rc._DKXdZpvHo34S5ZnQVXvzkRCVbXr - jI4Bueou7dItYp5S7QML5vyC6Rc._VbytTKM013i24vIBkff4MQqjUuN));
					stringBuilder.Append("\nSpeed remaining: ");
					stringBuilder.Append(classStats.SpeedMax - (jI4Bueou7dItYp5S7QML5vyC6Rc._1gNAQ2EeHsvaPSMubCVoabAB8QJA - jI4Bueou7dItYp5S7QML5vyC6Rc._I5YLGnOu48Y76QWbA8kj1X5s6pi));
					stringBuilder.Append("\nDexterity remaining: ");
					stringBuilder.Append(classStats.DexterityMax - (jI4Bueou7dItYp5S7QML5vyC6Rc._mUATXmRqQEel23PBf8vt9RGb4Ui - jI4Bueou7dItYp5S7QML5vyC6Rc._89L9r21WafCFAQqgz4qsnAURmLX));
					num = (int)((num2 * 453123108) ^ 0xAB0F89E);
					continue;
				case 14u:
					stringBuilder.Append(jI4Bueou7dItYp5S7QML5vyC6Rc._Tzs80AG7yuyH3MdkwBtecxKKzlB.Name);
					num = ((int)num2 * -1905886843) ^ 0x7D0D9A4E;
					continue;
				case 9u:
					jI4Bueou7dItYp5S7QML5vyC6Rc = _Client._PlayerData;
					num = 1921869604;
					continue;
				case 11u:
				{
					int num3;
					int num4;
					if (playerText._Message != "/lefttomax")
					{
						num3 = -1498971150;
						num4 = num3;
					}
					else
					{
						num3 = -1907058170;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1958525944);
					continue;
				}
				case 0u:
					stringBuilder.Append(classStats.VitalityMax - (jI4Bueou7dItYp5S7QML5vyC6Rc._P6tDEyGoXHV3WltSPRoAkw3XvUe - jI4Bueou7dItYp5S7QML5vyC6Rc._Bc4AU4iMsMwUXTL3vMzsYA5LUZo));
					stringBuilder.Append("\nWisdom remaining: ");
					num = (int)(num2 * 1181323872) ^ -1500622523;
					continue;
				case 17u:
					stringBuilder.Append("\nMana pots remaining: ");
					num = ((int)num2 * -123999636) ^ -1394602507;
					continue;
				case 2u:
					playerText._Send = false;
					num = 1290996261;
					continue;
				case 3u:
					stringBuilder.Append((int)(Math.Ceiling((double)classStats.LifeMax - (double)(jI4Bueou7dItYp5S7QML5vyC6Rc._fBkfBLhhMp7FH6BVjSag96CvhnT - jI4Bueou7dItYp5S7QML5vyC6Rc._vJEfm6okr5n5F1bgW8F1ElWKRcg)) * 0.2));
					num = ((int)num2 * -1459701375) ^ 0x7F3416BE;
					continue;
				default:
					stringBuilder.Append(classStats.WisdomMax - (jI4Bueou7dItYp5S7QML5vyC6Rc._UAk24tBgtCOd5WPGvcakcNRuFBJ - jI4Bueou7dItYp5S7QML5vyC6Rc._VC5NFP7putpASAq5eGJDSVhAIF));
					_Client._TVcgSr7bcouFhNfw8PyT9bbBIM0(stringBuilder.ToString());
					return;
				}
				break;
			}
		}
	}
}
