using ExaltMultiTool.Proxy.Networking.Packets;

internal class _dzwN9CIamZnvbdL3z641RrSFHqS : Packet
{
	public _B2gBzVDzeVEP19C56oq34otnH9L[] _fqc0YMynpKv9AAhQ9xkHabhJXze;

	public short _hNs5zYuRv2D6NOZJlJLTfmjXkqG;

	public override PacketType pType => PacketType.QUESTFETCHRESPONSE;

	public override void readPacketData(PacketReader r)
	{
		_fqc0YMynpKv9AAhQ9xkHabhJXze = new _B2gBzVDzeVEP19C56oq34otnH9L[r.ReadInt16()];
		int num3 = default(int);
		while (true)
		{
			int num = -1829995685;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF85713DBu) % 7u)
				{
				case 5u:
					break;
				default:
					return;
				case 2u:
					num3 = 0;
					num = (int)((num2 * 776553185) ^ 0x32C3F0E4);
					continue;
				case 4u:
				{
					int num4;
					if (num3 < _fqc0YMynpKv9AAhQ9xkHabhJXze.Length)
					{
						num = -1602311804;
						num4 = num;
					}
					else
					{
						num = -416170669;
						num4 = num;
					}
					continue;
				}
				case 6u:
					num3++;
					num = ((int)num2 * -1215169998) ^ 0x588E85EC;
					continue;
				case 3u:
					_hNs5zYuRv2D6NOZJlJLTfmjXkqG = r.ReadInt16();
					num = ((int)num2 * -40686268) ^ -1687274657;
					continue;
				case 1u:
					_fqc0YMynpKv9AAhQ9xkHabhJXze[num3] = new _B2gBzVDzeVEP19C56oq34otnH9L(r);
					num = -1392807233;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write((short)_fqc0YMynpKv9AAhQ9xkHabhJXze.Length);
		_B2gBzVDzeVEP19C56oq34otnH9L[] fqc0YMynpKv9AAhQ9xkHabhJXze = default(_B2gBzVDzeVEP19C56oq34otnH9L[]);
		int num3 = default(int);
		while (true)
		{
			int num = 1849069705;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B6182AAu) % 8u)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
					w.Write(_hNs5zYuRv2D6NOZJlJLTfmjXkqG);
					num = ((int)num2 * -1485939649) ^ 0x48EA73BF;
					continue;
				case 5u:
					num = (int)(num2 * 899147401) ^ -2104542511;
					continue;
				case 7u:
					fqc0YMynpKv9AAhQ9xkHabhJXze[num3]._3Wc8kZJjhbRt6nttAKwD2698imm(w);
					num = 1665785936;
					continue;
				case 6u:
				{
					int num4;
					if (num3 >= fqc0YMynpKv9AAhQ9xkHabhJXze.Length)
					{
						num = 867184654;
						num4 = num;
					}
					else
					{
						num = 1544116181;
						num4 = num;
					}
					continue;
				}
				case 3u:
					fqc0YMynpKv9AAhQ9xkHabhJXze = _fqc0YMynpKv9AAhQ9xkHabhJXze;
					num3 = 0;
					num = (int)(num2 * 1113805296) ^ -715510817;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -266804560) ^ -1355242116;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
