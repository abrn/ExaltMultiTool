using ExaltMultiTool.Proxy.Networking.Packets;

internal class MapInfoPacket : Packet
{
	public int _Width;

	public int _Height;

	public string _MapName;

	public string _DisplayName;

	public string _RealmName;

	public int _Difficulty;

	public uint _uV5tlOqeszD4IoJi3t2CRjvcLIB;

	public int _bRVHFhdBcSJWan12L0XjvcvSoFJ;

	public bool _AllowTeleports;

	public bool _EaX49CukAVNKfIBBQdS5YMzPXsN;

	public short _ul3HClgRiLsu0fJNqiUygJqWIYC;

	public string _aAOuS4eZwwZbjBObruL1bo2vGGw;

	public uint _UcIacBkNQn7bM1Lf5WOTMsrHnPG;

	public string _ConnectionGuid;

	public string[] _985N0u7Jv9AaCXxFLrn6YWvcKJ7 = new string[0];

	public string[] _iWbYq2cyKx27pCItWhIxVaOyD4E = new string[0];

	public override PacketType pType => PacketType.MAPINFO;

	public override void readPacketData(PacketReader r)
	{
		_Width = r.ReadInt32();
		_Height = r.ReadInt32();
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -793590236;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8A67963Du) % 18u)
				{
				case 2u:
					break;
				case 17u:
					_iWbYq2cyKx27pCItWhIxVaOyD4E = new string[r.ReadInt16()];
					num = ((int)num2 * -1119241209) ^ -1643660649;
					continue;
				case 13u:
				{
					int num6;
					if (num4 >= _iWbYq2cyKx27pCItWhIxVaOyD4E.Length)
					{
						num = -305165884;
						num6 = num;
					}
					else
					{
						num = -1874432014;
						num6 = num;
					}
					continue;
				}
				case 1u:
					_985N0u7Jv9AaCXxFLrn6YWvcKJ7 = new string[r.ReadInt16()];
					num3 = 0;
					num = ((int)num2 * -716002193) ^ 0x8A03CEA;
					continue;
				case 0u:
					_DisplayName = r.ReadString();
					_RealmName = r.ReadString();
					num = (int)(num2 * 897228632) ^ -1672279116;
					continue;
				case 4u:
					_AllowTeleports = r.ReadBoolean();
					_EaX49CukAVNKfIBBQdS5YMzPXsN = r.ReadBoolean();
					_ul3HClgRiLsu0fJNqiUygJqWIYC = r.ReadInt16();
					num = (int)((num2 * 855409582) ^ 0x740BCE1F);
					continue;
				case 9u:
					_MapName = r.ReadString();
					num = (int)(num2 * 319319914) ^ -2000775603;
					continue;
				case 11u:
					_iWbYq2cyKx27pCItWhIxVaOyD4E[num4] = r.ReadUTF8String();
					num4++;
					num = -1589844756;
					continue;
				case 12u:
					_985N0u7Jv9AaCXxFLrn6YWvcKJ7[num3] = r.ReadUTF8String();
					num = -1006264721;
					continue;
				case 10u:
				{
					int num5;
					if (num3 >= _985N0u7Jv9AaCXxFLrn6YWvcKJ7.Length)
					{
						num = -1557877788;
						num5 = num;
					}
					else
					{
						num = -1212271759;
						num5 = num;
					}
					continue;
				}
				case 15u:
					num4 = 0;
					num = (int)(num2 * 1082377083) ^ -1932461234;
					continue;
				case 14u:
					num3++;
					num = ((int)num2 * -1606927019) ^ -504732729;
					continue;
				case 3u:
					_UcIacBkNQn7bM1Lf5WOTMsrHnPG = r.ReadUInt32();
					num = ((int)num2 * -1983799411) ^ -1212770031;
					continue;
				case 6u:
					num = (int)((num2 * 1476232342) ^ 0x10325BD4);
					continue;
				case 16u:
					_bRVHFhdBcSJWan12L0XjvcvSoFJ = r.ReadInt32();
					_Difficulty = r.ReadInt32();
					num = (int)(num2 * 1343964844) ^ -1305346855;
					continue;
				case 8u:
					_aAOuS4eZwwZbjBObruL1bo2vGGw = r.ReadString();
					num = ((int)num2 * -318444422) ^ -513298768;
					continue;
				case 7u:
					_uV5tlOqeszD4IoJi3t2CRjvcLIB = r.ReadUInt32();
					num = (int)(num2 * 1589705456) ^ -387418465;
					continue;
				default:
					_ConnectionGuid = r.ReadString();
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Width);
		w.Write(_Height);
		w.Write(_MapName);
		string value2 = default(string);
		string[] iWbYq2cyKx27pCItWhIxVaOyD4E = default(string[]);
		int num3 = default(int);
		string value = default(string);
		while (true)
		{
			int num = 1414985069;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23907983u) % 19u)
				{
				case 17u:
					break;
				case 4u:
					w.Write(_AllowTeleports);
					num = (int)((num2 * 57062996) ^ 0xC4D3AA);
					continue;
				case 0u:
					value2 = iWbYq2cyKx27pCItWhIxVaOyD4E[num3];
					num = 793328649;
					continue;
				case 11u:
					w.Write(_aAOuS4eZwwZbjBObruL1bo2vGGw);
					num = (int)((num2 * 1200095431) ^ 0x24F573F);
					continue;
				case 5u:
					num = (int)((num2 * 816987188) ^ 0x746DDBA0);
					continue;
				case 7u:
				{
					int num5;
					if (num3 >= iWbYq2cyKx27pCItWhIxVaOyD4E.Length)
					{
						num = 296516330;
						num5 = num;
					}
					else
					{
						num = 594001799;
						num5 = num;
					}
					continue;
				}
				case 6u:
					num = (int)((num2 * 1889692583) ^ 0x36F666CA);
					continue;
				case 9u:
					w._9UoQbcRa99e4xjcrtzdQLYTHK2N(value2);
					num3++;
					num = (int)(num2 * 509503245) ^ -1016971766;
					continue;
				case 13u:
					w.Write(_bRVHFhdBcSJWan12L0XjvcvSoFJ);
					num = (int)((num2 * 1343302640) ^ 0x2913CEF9);
					continue;
				case 18u:
					w.Write(_Difficulty);
					num = ((int)num2 * -1182796911) ^ 0x21D8BCD5;
					continue;
				case 3u:
					w.Write((short)_iWbYq2cyKx27pCItWhIxVaOyD4E.Length);
					iWbYq2cyKx27pCItWhIxVaOyD4E = _iWbYq2cyKx27pCItWhIxVaOyD4E;
					num3 = 0;
					num = (int)(num2 * 391160999) ^ -172844820;
					continue;
				case 10u:
				{
					int num4;
					if (num3 >= iWbYq2cyKx27pCItWhIxVaOyD4E.Length)
					{
						num = 1200739334;
						num4 = num;
					}
					else
					{
						num = 643216526;
						num4 = num;
					}
					continue;
				}
				case 12u:
					w._9UoQbcRa99e4xjcrtzdQLYTHK2N(value);
					num3++;
					num = ((int)num2 * -1617037846) ^ 0x19DFC98C;
					continue;
				case 14u:
					value = iWbYq2cyKx27pCItWhIxVaOyD4E[num3];
					num = 441238220;
					continue;
				case 15u:
					w.Write(_DisplayName);
					num = ((int)num2 * -1728815921) ^ -1764788491;
					continue;
				case 8u:
					w.Write(_RealmName);
					w.Write(_uV5tlOqeszD4IoJi3t2CRjvcLIB);
					num = (int)(num2 * 962594943) ^ -237560802;
					continue;
				case 16u:
					w.Write(_EaX49CukAVNKfIBBQdS5YMzPXsN);
					w.Write(_ul3HClgRiLsu0fJNqiUygJqWIYC);
					num = ((int)num2 * -1855784597) ^ -135375538;
					continue;
				case 2u:
					w.Write(_UcIacBkNQn7bM1Lf5WOTMsrHnPG);
					w.Write((short)_985N0u7Jv9AaCXxFLrn6YWvcKJ7.Length);
					iWbYq2cyKx27pCItWhIxVaOyD4E = _985N0u7Jv9AaCXxFLrn6YWvcKJ7;
					num3 = 0;
					num = ((int)num2 * -716197436) ^ -607097047;
					continue;
				default:
					w.Write(_ConnectionGuid);
					return;
				}
				break;
			}
		}
	}
}
