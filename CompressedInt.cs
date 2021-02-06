using System.IO;

internal class CompressedInt
{
	public static int Read(BinaryReader r)
	{
		byte b = r.ReadByte();
		bool flag = (b & 0x40) != 0;
		int num3 = default(int);
		byte b2 = default(byte);
		while (true)
		{
			int num = -669523079;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91F1D108u) % 10u)
				{
				case 6u:
					break;
				case 8u:
				{
					int num6;
					if ((b & 0x80) == 0)
					{
						num = -37669621;
						num6 = num;
					}
					else
					{
						num = -1790041223;
						num6 = num;
					}
					continue;
				}
				case 5u:
					b = r.ReadByte();
					num3 |= (b & 0x7F) << (int)b2;
					num = -1303176402;
					continue;
				case 4u:
					num3 = b & 0x3F;
					num = (int)((num2 * 2096172411) ^ 0x63F77190);
					continue;
				case 9u:
					num3 = -num3;
					num = ((int)num2 * -1745363288) ^ 0x4FA68B85;
					continue;
				case 1u:
					b2 = 6;
					num = (int)(num2 * 1373570761) ^ -700314545;
					continue;
				case 7u:
				{
					int num4;
					int num5;
					if (!flag)
					{
						num4 = -1194129754;
						num5 = num4;
					}
					else
					{
						num4 = -428829480;
						num5 = num4;
					}
					num = num4 ^ (int)(num2 * 2135073289);
					continue;
				}
				case 2u:
					b2 = (byte)(b2 + 7);
					num = (int)(num2 * 304357050) ^ -381829258;
					continue;
				case 0u:
					num = (int)((num2 * 885571758) ^ 0x7A85B9D6);
					continue;
				default:
					return num3;
				}
				break;
			}
		}
	}

	public static void write(BinaryWriter w, int value)
	{
		bool num = value < 0;
		uint num2 = (uint)(num ? (-value) : value);
		byte b = (byte)(num2 & 0x3Fu);
		if (num)
		{
			goto IL_0018;
		}
		goto IL_00dd;
		IL_001d:
		int num3;
		bool flag = default(bool);
		while (true)
		{
			uint num4;
			switch ((num4 = (uint)num3 ^ 0xA6922C20u) % 14u)
			{
			case 12u:
				break;
			default:
				return;
			case 1u:
				b = (byte)(b | 0x40u);
				num3 = ((int)num4 * -2026352417) ^ -492387462;
				continue;
			case 11u:
				flag = num2 != 0;
				num3 = (int)(num4 * 2004575782) ^ -1876036982;
				continue;
			case 13u:
				b = (byte)(num2 & 0x7Fu);
				num3 = -835364367;
				continue;
			case 9u:
				num2 >>= 7;
				num3 = ((int)num4 * -517822387) ^ 0xB681355;
				continue;
			case 4u:
			{
				flag = num2 != 0;
				int num7;
				int num8;
				if (flag)
				{
					num7 = 1784418546;
					num8 = num7;
				}
				else
				{
					num7 = 1607897544;
					num8 = num7;
				}
				num3 = num7 ^ ((int)num4 * -1685987627);
				continue;
			}
			case 3u:
				goto IL_00dd;
			case 8u:
				goto IL_00eb;
			case 0u:
				b = (byte)(b | 0x80u);
				num3 = (int)((num4 * 1553222280) ^ 0x30B49BD0);
				continue;
			case 2u:
			{
				int num5;
				int num6;
				if (flag)
				{
					num5 = 8112247;
					num6 = num5;
				}
				else
				{
					num5 = 139491927;
					num6 = num5;
				}
				num3 = num5 ^ (int)(num4 * 426145393);
				continue;
			}
			case 10u:
				w.Write(b);
				num3 = -2071375380;
				continue;
			case 7u:
				b = (byte)(b | 0x80u);
				num3 = ((int)num4 * -157612073) ^ 0x547A06E6;
				continue;
			case 5u:
				w.Write(b);
				num3 = -2071375380;
				continue;
			case 6u:
				return;
			}
			break;
			IL_00eb:
			int num9;
			if (!flag)
			{
				num3 = -1887521864;
				num9 = num3;
			}
			else
			{
				num3 = -2140420195;
				num9 = num3;
			}
		}
		goto IL_0018;
		IL_0018:
		num3 = -620070475;
		goto IL_001d;
		IL_00dd:
		num2 >>= 6;
		num3 = -380097459;
		goto IL_001d;
	}
}
