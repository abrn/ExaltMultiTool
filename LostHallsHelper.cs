using System.Collections.Generic;
using ExaltMultiTool;

internal class LostHallsHelper
{
	private bool _InLostHalls;

	private const int _RgjGsT3X2SuduoqBsF2FKpFbcnD = 45239;

	private const int _f3ybM4yNmpSNGUhiusVkVdI7lin = 45243;

	public void OnMapInfo(MapInfoPacket mapInfo)
	{
		_InLostHalls = mapInfo._MapName == "Lost Halls";
	}

	public void _emTnZmGyChlXH4IDm60126G1Snf(UpdatePacket update)
	{
		//Discarded unreachable code: IL_0088, IL_00c4
		if (!_InLostHalls)
		{
			goto IL_000b;
		}
		goto IL_0113;
		IL_0113:
		int num;
		int num2;
		if (!Settings.Default.ShowRealLHPot)
		{
			num = -811395288;
			num2 = num;
		}
		else
		{
			num = -637109816;
			num2 = num;
		}
		goto IL_0010;
		IL_0010:
		GameObject gameObject = default(GameObject);
		int num4 = default(int);
		GameObject[] lakUpSXZB1zdJcCECL20tl6SVrT = default(GameObject[]);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x84FFC1E6u) % 14u)
			{
			case 10u:
				break;
			default:
				return;
			case 0u:
				_ivabn6yjLrc2oPnFNSOdlTDl0LFb(gameObject._Status);
				num = (int)(num3 * 1483856324) ^ -2142246349;
				continue;
			case 1u:
				num = ((int)num3 * -2060266849) ^ -1660575274;
				continue;
			case 12u:
				return;
			case 6u:
			{
				int num7;
				int num8;
				if (gameObject._ObjectType >= 45239)
				{
					num7 = -1108408877;
					num8 = num7;
				}
				else
				{
					num7 = -79855753;
					num8 = num7;
				}
				num = num7 ^ ((int)num3 * -769115086);
				continue;
			}
			case 8u:
				return;
			case 5u:
			{
				int num5;
				int num6;
				if (gameObject._ObjectType <= 45243)
				{
					num5 = 1594249089;
					num6 = num5;
				}
				else
				{
					num5 = 1618643186;
					num6 = num5;
				}
				num = num5 ^ ((int)num3 * -1331662543);
				continue;
			}
			case 4u:
				num4 = 0;
				num = (int)((num3 * 858403627) ^ 0x5967C391);
				continue;
			case 7u:
				goto IL_0113;
			case 2u:
				lakUpSXZB1zdJcCECL20tl6SVrT = update._NewObjects;
				num = -1649087372;
				continue;
			case 9u:
				gameObject = lakUpSXZB1zdJcCECL20tl6SVrT[num4];
				num = -692031256;
				continue;
			case 11u:
				num4++;
				num = -1530312327;
				continue;
			case 3u:
				goto IL_0160;
			case 13u:
				return;
			}
			break;
			IL_0160:
			int num9;
			if (num4 < lakUpSXZB1zdJcCECL20tl6SVrT.Length)
			{
				num = -288160327;
				num9 = num;
			}
			else
			{
				num = -307916511;
				num9 = num;
			}
		}
		goto IL_000b;
		IL_000b:
		num = -468291586;
		goto IL_0010;
	}

	private void _ivabn6yjLrc2oPnFNSOdlTDl0LFb(Status status)
	{
		//Discarded unreachable code: IL_00a7
		using (List<StatData>.Enumerator enumerator = status._Stats.GetEnumerator())
		{
			StatData current = default(StatData);
			while (true)
			{
				int num;
				int num2;
				if (enumerator.MoveNext())
				{
					num = 1875557150;
					num2 = num;
				}
				else
				{
					num = 237358371;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0x1B1E3BD8u) % 7u)
					{
					case 0u:
						num = 1875557150;
						continue;
					default:
						goto end_IL_000c;
					case 3u:
						break;
					case 5u:
					{
						int num4;
						int num5;
						if (StatType._agQ5CSGcaJRx3TN8BU6OBzWi5yT(current._StatType, StatType._zMlSnmW3LLSxr4x3sZAbRbWfh8Y))
						{
							num4 = -1730027036;
							num5 = num4;
						}
						else
						{
							num4 = -941900768;
							num5 = num4;
						}
						num = num4 ^ (int)(num3 * 1573919477);
						continue;
					}
					case 6u:
						current._StatValue = 200;
						num = ((int)num3 * -1401795760) ^ -623442233;
						continue;
					case 1u:
						return;
					case 4u:
						current = enumerator.Current;
						num = 1653303087;
						continue;
					case 2u:
						goto end_IL_000c;
					}
					break;
				}
			}
			end_IL_000c:;
		}
		status._Stats.Add(new StatData
		{
			_StatValue = 200,
			_StringStatValue = string.Empty,
			_MagicByte = 0
		});
	}
}
