using ExaltMultiTool.Proxy.Networking.Packets;

internal class _3OZHAhKHKj0OoPCRW4X7EdepzNS : Packet
{
	public int _NCFoCgVlw4f1I6p7NaxlcKmqRZD;

	public string[] _NLgL2aTAN1c0wG5kCG4vtWPN2DG;

	public int _2RkIvtf3HFU4n8kAYtqsjvnDe2w;

	public override PacketType pType => PacketType.ACCOUNTLIST;

	public override void readPacketData(PacketReader r)
	{
		_NCFoCgVlw4f1I6p7NaxlcKmqRZD = r.ReadInt32();
		int num3 = default(int);
		while (true)
		{
			int num = -1159246927;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9F76370Eu) % 6u)
				{
				case 0u:
					break;
				default:
					return;
				case 5u:
					_NLgL2aTAN1c0wG5kCG4vtWPN2DG = new string[r.ReadInt16()];
					num3 = 0;
					num = ((int)num2 * -2134429576) ^ -1812439097;
					continue;
				case 2u:
					_NLgL2aTAN1c0wG5kCG4vtWPN2DG[num3] = r.ReadString();
					num3++;
					num = -805890481;
					continue;
				case 3u:
					_2RkIvtf3HFU4n8kAYtqsjvnDe2w = r.ReadInt32();
					num = ((int)num2 * -1834091826) ^ 0x60A59EDA;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= _NLgL2aTAN1c0wG5kCG4vtWPN2DG.Length)
					{
						num = -363052413;
						num4 = num;
					}
					else
					{
						num = -433585116;
						num4 = num;
					}
					continue;
				}
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_NCFoCgVlw4f1I6p7NaxlcKmqRZD);
		w.Write((short)_NLgL2aTAN1c0wG5kCG4vtWPN2DG.Length);
		string value = default(string);
		int num3 = default(int);
		string[] nLgL2aTAN1c0wG5kCG4vtWPN2DG = default(string[]);
		while (true)
		{
			int num = -1849307965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCEA9DE04u) % 9u)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
					w.Write(value);
					num = ((int)num2 * -281977857) ^ -509137271;
					continue;
				case 4u:
					num = (int)(num2 * 590186294) ^ -1903824436;
					continue;
				case 1u:
					num3++;
					num = (int)((num2 * 1911442759) ^ 0x71099852);
					continue;
				case 6u:
					nLgL2aTAN1c0wG5kCG4vtWPN2DG = _NLgL2aTAN1c0wG5kCG4vtWPN2DG;
					num3 = 0;
					num = ((int)num2 * -690913689) ^ -1293605584;
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= nLgL2aTAN1c0wG5kCG4vtWPN2DG.Length)
					{
						num = -99821123;
						num4 = num;
					}
					else
					{
						num = -537064171;
						num4 = num;
					}
					continue;
				}
				case 7u:
					w.Write(_2RkIvtf3HFU4n8kAYtqsjvnDe2w);
					num = (int)(num2 * 1756476371) ^ -491665846;
					continue;
				case 8u:
					value = nLgL2aTAN1c0wG5kCG4vtWPN2DG[num3];
					num = -1351654073;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}
}
