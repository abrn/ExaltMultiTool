using ExaltMultiTool.Proxy.Networking.Packets;

internal class UpdatePacket : Packet
{
	public TileObject[] _2CIHnoEa49dfPXyqt9nkkBlUcQf;

	public _kWgc6McpJEKeBQJy34XFIJ43khcA[] _lakUpSXZB1zdJcCECL20tl6SVrT;

	public int[] _Drops;

	public override PacketType pType => PacketType.UPDATE;

	public override void readPacketData(PacketReader r)
	{
		_2CIHnoEa49dfPXyqt9nkkBlUcQf = new TileObject[CompressedInt.Read(r)];
		int num = 0;
		int num7 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2;
			int num3;
			if (num >= _2CIHnoEa49dfPXyqt9nkkBlUcQf.Length)
			{
				num2 = -341948488;
				num3 = num2;
			}
			else
			{
				num2 = -1611533321;
				num3 = num2;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xC6EC3672u) % 12u)
				{
				case 3u:
					num2 = -1611533321;
					continue;
				default:
					return;
				case 2u:
					_Drops[num7] = CompressedInt.Read(r);
					num2 = -882987930;
					continue;
				case 6u:
					_lakUpSXZB1zdJcCECL20tl6SVrT = new _kWgc6McpJEKeBQJy34XFIJ43khcA[CompressedInt.Read(r)];
					num2 = (int)(num4 * 1139433977) ^ -1620797854;
					continue;
				case 8u:
					num7++;
					num2 = ((int)num4 * -634635073) ^ 0x6ECF3C5B;
					continue;
				case 1u:
					_2CIHnoEa49dfPXyqt9nkkBlUcQf[num] = (TileObject)new TileObject().readTileData(r);
					num++;
					num2 = -2040246126;
					continue;
				case 5u:
					_lakUpSXZB1zdJcCECL20tl6SVrT[num5] = (_kWgc6McpJEKeBQJy34XFIJ43khcA)new _kWgc6McpJEKeBQJy34XFIJ43khcA()._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r);
					num5++;
					num2 = -378581866;
					continue;
				case 4u:
					break;
				case 7u:
					_Drops = new int[CompressedInt.Read(r)];
					num7 = 0;
					num2 = (int)((num4 * 1082894650) ^ 0x20724939);
					continue;
				case 10u:
					num5 = 0;
					num2 = (int)((num4 * 1228863818) ^ 0x34CE9232);
					continue;
				case 9u:
				{
					int num8;
					if (num7 < _Drops.Length)
					{
						num2 = -260250956;
						num8 = num2;
					}
					else
					{
						num2 = -459433951;
						num8 = num2;
					}
					continue;
				}
				case 0u:
				{
					int num6;
					if (num5 >= _lakUpSXZB1zdJcCECL20tl6SVrT.Length)
					{
						num2 = -2067382847;
						num6 = num2;
					}
					else
					{
						num2 = -1331789281;
						num6 = num2;
					}
					continue;
				}
				case 11u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		CompressedInt.write(w, _2CIHnoEa49dfPXyqt9nkkBlUcQf.Length);
		TileObject[] array = _2CIHnoEa49dfPXyqt9nkkBlUcQf;
		int num3 = default(int);
		_kWgc6McpJEKeBQJy34XFIJ43khcA[] lakUpSXZB1zdJcCECL20tl6SVrT = default(_kWgc6McpJEKeBQJy34XFIJ43khcA[]);
		int[] lRLF1OvIoGLzzq1APVMdrraeXfZ = default(int[]);
		while (true)
		{
			int num = 1283967629;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x57D86A34u) % 17u)
				{
				case 11u:
					break;
				default:
					return;
				case 9u:
					num3 = 0;
					num = (int)(num2 * 1207221812) ^ -948700309;
					continue;
				case 16u:
					num = (int)(num2 * 431052748) ^ -111997910;
					continue;
				case 1u:
				{
					int num5;
					if (num3 >= array.Length)
					{
						num = 809091184;
						num5 = num;
					}
					else
					{
						num = 976612151;
						num5 = num;
					}
					continue;
				}
				case 6u:
				{
					int num6;
					if (num3 >= lakUpSXZB1zdJcCECL20tl6SVrT.Length)
					{
						num = 1096163677;
						num6 = num;
					}
					else
					{
						num = 737417172;
						num6 = num;
					}
					continue;
				}
				case 2u:
					array[num3].writeTileData(w);
					num3++;
					num = 910490735;
					continue;
				case 4u:
					CompressedInt.write(w, _Drops.Length);
					num = ((int)num2 * -1671459241) ^ -1917075944;
					continue;
				case 12u:
					lRLF1OvIoGLzzq1APVMdrraeXfZ = _Drops;
					num = ((int)num2 * -616608213) ^ 0x49DED4F3;
					continue;
				case 13u:
					num3++;
					num = (int)((num2 * 1221180465) ^ 0x9D0FCA0);
					continue;
				case 3u:
				{
					int num4;
					if (num3 < lRLF1OvIoGLzzq1APVMdrraeXfZ.Length)
					{
						num = 396887373;
						num4 = num;
					}
					else
					{
						num = 1727952501;
						num4 = num;
					}
					continue;
				}
				case 0u:
				{
					int value = lRLF1OvIoGLzzq1APVMdrraeXfZ[num3];
					CompressedInt.write(w, value);
					num = 895630794;
					continue;
				}
				case 8u:
					num3 = 0;
					num = (int)((num2 * 1870756879) ^ 0x16E9FAB8);
					continue;
				case 14u:
					lakUpSXZB1zdJcCECL20tl6SVrT = _lakUpSXZB1zdJcCECL20tl6SVrT;
					num = (int)((num2 * 1030521785) ^ 0x77E871CF);
					continue;
				case 5u:
					CompressedInt.write(w, _lakUpSXZB1zdJcCECL20tl6SVrT.Length);
					num = ((int)num2 * -1739802646) ^ 0x5DEADA2B;
					continue;
				case 15u:
					num3 = 0;
					num = (int)(num2 * 944929023) ^ -634026798;
					continue;
				case 7u:
					lakUpSXZB1zdJcCECL20tl6SVrT[num3]._3Wc8kZJjhbRt6nttAKwD2698imm(w);
					num3++;
					num = 1269282414;
					continue;
				case 10u:
					return;
				}
				break;
			}
		}
	}
}
