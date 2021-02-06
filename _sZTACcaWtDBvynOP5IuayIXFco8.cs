using ExaltMultiTool.Proxy.Networking.Packets;

internal class _sZTACcaWtDBvynOP5IuayIXFco8 : Packet
{
	public bool[] _LHbaAVjSQXAgKyzFZayI0skw5HM;

	public bool[] _PE8lg9yzWD4WzuCZzjQgHBr9HzE;

	public override PacketType pType => PacketType.TRADEACCEPTED;

	public override void readPacketData(PacketReader r)
	{
		_LHbaAVjSQXAgKyzFZayI0skw5HM = new bool[r.ReadInt16()];
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num = 80934229;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x248153F9u) % 13u)
				{
				case 9u:
					break;
				default:
					return;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -207806299) ^ -2116041703;
					continue;
				case 6u:
					num5++;
					num = (int)(num2 * 1271062854) ^ -1676695078;
					continue;
				case 3u:
					_LHbaAVjSQXAgKyzFZayI0skw5HM[num5] = r.ReadBoolean();
					num = 1262297476;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1188655478) ^ 0x1861A7C9;
					continue;
				case 4u:
					_PE8lg9yzWD4WzuCZzjQgHBr9HzE = new bool[r.ReadInt16()];
					num = (int)(num2 * 1693750536) ^ -1156339095;
					continue;
				case 11u:
					_PE8lg9yzWD4WzuCZzjQgHBr9HzE[num3] = r.ReadBoolean();
					num = 1140852701;
					continue;
				case 7u:
				{
					int num6;
					if (num5 >= _LHbaAVjSQXAgKyzFZayI0skw5HM.Length)
					{
						num = 41992821;
						num6 = num;
					}
					else
					{
						num = 752354836;
						num6 = num;
					}
					continue;
				}
				case 10u:
					num5 = 0;
					num = (int)((num2 * 1405483951) ^ 0x6E26898E);
					continue;
				case 12u:
					num = (int)(num2 * 197617135) ^ -1638066671;
					continue;
				case 2u:
				{
					int num4;
					if (num3 >= _PE8lg9yzWD4WzuCZzjQgHBr9HzE.Length)
					{
						num = 1044041410;
						num4 = num;
					}
					else
					{
						num = 81663142;
						num4 = num;
					}
					continue;
				}
				case 0u:
					num = (int)(num2 * 173985490) ^ -1885223742;
					continue;
				case 5u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write((ushort)_LHbaAVjSQXAgKyzFZayI0skw5HM.Length);
		bool value2 = default(bool);
		bool[] array = default(bool[]);
		int num3 = default(int);
		while (true)
		{
			int num = 141751681;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x45E4A657u) % 14u)
				{
				case 2u:
					break;
				default:
					return;
				case 9u:
					w.Write(value2);
					num = (int)(num2 * 2035531804) ^ -1573604666;
					continue;
				case 4u:
					value2 = array[num3];
					num = 723965788;
					continue;
				case 7u:
					w.Write((ushort)_PE8lg9yzWD4WzuCZzjQgHBr9HzE.Length);
					num = (int)((num2 * 292175150) ^ 0x70267CFB);
					continue;
				case 5u:
				{
					int num5;
					if (num3 >= array.Length)
					{
						num = 821765066;
						num5 = num;
					}
					else
					{
						num = 973366355;
						num5 = num;
					}
					continue;
				}
				case 0u:
					array = _PE8lg9yzWD4WzuCZzjQgHBr9HzE;
					num = ((int)num2 * -947833880) ^ -133432846;
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = 451057511;
						num4 = num;
					}
					else
					{
						num = 2062702188;
						num4 = num;
					}
					continue;
				}
				case 1u:
					num3++;
					num = (int)(num2 * 1735401503) ^ -635824471;
					continue;
				case 12u:
					num = ((int)num2 * -841948076) ^ -1058414702;
					continue;
				case 6u:
					array = _LHbaAVjSQXAgKyzFZayI0skw5HM;
					num = (int)((num2 * 1706310721) ^ 0x719CB0D3);
					continue;
				case 11u:
					num3 = 0;
					num = ((int)num2 * -1357621267) ^ 0x65442509;
					continue;
				case 13u:
				{
					bool value = array[num3];
					w.Write(value);
					num3++;
					num = 2108587800;
					continue;
				}
				case 10u:
					num3 = 0;
					num = (int)(num2 * 1169106812) ^ -887269153;
					continue;
				case 8u:
					return;
				}
				break;
			}
		}
	}
}
