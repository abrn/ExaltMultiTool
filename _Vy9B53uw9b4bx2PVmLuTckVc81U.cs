using ExaltMultiTool.Proxy.Networking.Packets;

internal class _Vy9B53uw9b4bx2PVmLuTckVc81U : Packet
{
	public bool[] _LHbaAVjSQXAgKyzFZayI0skw5HM;

	public bool[] _PE8lg9yzWD4WzuCZzjQgHBr9HzE;

	public override PacketType pType => PacketType.ACCEPTTRADE;

	public override void readPacketData(PacketReader r)
	{
		_LHbaAVjSQXAgKyzFZayI0skw5HM = new bool[r.ReadInt16()];
		int num = 0;
		int num5 = default(int);
		while (true)
		{
			int num2;
			int num3;
			if (num >= _LHbaAVjSQXAgKyzFZayI0skw5HM.Length)
			{
				num2 = 919735810;
				num3 = num2;
			}
			else
			{
				num2 = 2125444204;
				num3 = num2;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x291F9486u) % 9u)
				{
				case 4u:
					num2 = 2125444204;
					continue;
				default:
					return;
				case 8u:
					num5 = 0;
					num2 = ((int)num4 * -953036227) ^ 0x2E17D712;
					continue;
				case 3u:
					num++;
					num2 = ((int)num4 * -1308474546) ^ 0x17CF40ED;
					continue;
				case 5u:
					break;
				case 1u:
				{
					int num6;
					if (num5 < _PE8lg9yzWD4WzuCZzjQgHBr9HzE.Length)
					{
						num2 = 2083859202;
						num6 = num2;
					}
					else
					{
						num2 = 1831925495;
						num6 = num2;
					}
					continue;
				}
				case 7u:
					_LHbaAVjSQXAgKyzFZayI0skw5HM[num] = r.ReadBoolean();
					num2 = 1989097349;
					continue;
				case 0u:
					_PE8lg9yzWD4WzuCZzjQgHBr9HzE = new bool[r.ReadInt16()];
					num2 = (int)((num4 * 1260740270) ^ 0x3E71A68F);
					continue;
				case 6u:
					_PE8lg9yzWD4WzuCZzjQgHBr9HzE[num5] = r.ReadBoolean();
					num5++;
					num2 = 1827141695;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write((ushort)_LHbaAVjSQXAgKyzFZayI0skw5HM.Length);
		bool[] array = default(bool[]);
		int num3 = default(int);
		while (true)
		{
			int num = -1895188899;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE10052E6u) % 13u)
				{
				case 4u:
					break;
				default:
					return;
				case 9u:
					array = _PE8lg9yzWD4WzuCZzjQgHBr9HzE;
					num = ((int)num2 * -753866674) ^ 0x7C8A6337;
					continue;
				case 6u:
					num = (int)(num2 * 840228868) ^ -806070652;
					continue;
				case 10u:
					array = _LHbaAVjSQXAgKyzFZayI0skw5HM;
					num = (int)(num2 * 1622301258) ^ -766592939;
					continue;
				case 0u:
					num3 = 0;
					num = (int)((num2 * 2027718150) ^ 0x7A812540);
					continue;
				case 11u:
				{
					int num5;
					if (num3 >= array.Length)
					{
						num = -29925371;
						num5 = num;
					}
					else
					{
						num = -1018874213;
						num5 = num;
					}
					continue;
				}
				case 5u:
				{
					bool value2 = array[num3];
					w.Write(value2);
					num3++;
					num = -1751824601;
					continue;
				}
				case 7u:
					num3 = 0;
					num = (int)((num2 * 2065882158) ^ 0x2C8F6E6E);
					continue;
				case 12u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -1491140075;
						num4 = num;
					}
					else
					{
						num = -231591687;
						num4 = num;
					}
					continue;
				}
				case 3u:
				{
					bool value = array[num3];
					w.Write(value);
					num3++;
					num = -1138801796;
					continue;
				}
				case 2u:
					w.Write((ushort)_PE8lg9yzWD4WzuCZzjQgHBr9HzE.Length);
					num = (int)((num2 * 963647389) ^ 0xA2EDC8B);
					continue;
				case 1u:
					num = ((int)num2 * -327686051) ^ -2128518513;
					continue;
				case 8u:
					return;
				}
				break;
			}
		}
	}
}
