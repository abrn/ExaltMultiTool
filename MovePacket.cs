using ExaltMultiTool.Proxy.Networking.Packets;

internal class MovePacket : Packet
{
	public int _D4Xpe2utS1cwv8fGTeXUOkTlvMi;

	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public uint _lpUCyd62A6vzfr6V4LP6WYZtCgh;

	public WorldPosData _r0866iEhjgniNmmLz9ygFmfaWPA;

	public _X6f9REQnd8GedncwYfuKQX9BeNq[] _L7h4VBBMc07P3vNnM356szhuAGD;

	public override PacketType pType => PacketType.MOVE;

	public override void readPacketData(PacketReader r)
	{
		_D4Xpe2utS1cwv8fGTeXUOkTlvMi = r.ReadInt32();
		int num3 = default(int);
		while (true)
		{
			int num = 1573101250;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31E9FBADu) % 8u)
				{
				case 6u:
					break;
				default:
					return;
				case 2u:
					num3++;
					num = ((int)num2 * -1165209602) ^ -1487922702;
					continue;
				case 1u:
					_L7h4VBBMc07P3vNnM356szhuAGD[num3] = new _X6f9REQnd8GedncwYfuKQX9BeNq(r);
					num = 1038168151;
					continue;
				case 5u:
					num = ((int)num2 * -1007057562) ^ -453606416;
					continue;
				case 0u:
					num3 = 0;
					num = ((int)num2 * -961504655) ^ 0x508815B0;
					continue;
				case 3u:
				{
					int num4;
					if (num3 >= _L7h4VBBMc07P3vNnM356szhuAGD.Length)
					{
						num = 2081799393;
						num4 = num;
					}
					else
					{
						num = 390627868;
						num4 = num;
					}
					continue;
				}
				case 7u:
					_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
					_lpUCyd62A6vzfr6V4LP6WYZtCgh = r.ReadUInt32();
					_r0866iEhjgniNmmLz9ygFmfaWPA = new WorldPosData(r);
					_L7h4VBBMc07P3vNnM356szhuAGD = new _X6f9REQnd8GedncwYfuKQX9BeNq[r.ReadInt16()];
					num = ((int)num2 * -906824587) ^ -2097241002;
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_D4Xpe2utS1cwv8fGTeXUOkTlvMi);
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		_X6f9REQnd8GedncwYfuKQX9BeNq[] l7h4VBBMc07P3vNnM356szhuAGD = default(_X6f9REQnd8GedncwYfuKQX9BeNq[]);
		int num3 = default(int);
		while (true)
		{
			int num = 2026381459;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x738B0572u) % 10u)
				{
				case 6u:
					break;
				default:
					return;
				case 5u:
					w.Write(_lpUCyd62A6vzfr6V4LP6WYZtCgh);
					num = ((int)num2 * -1706295201) ^ -70872812;
					continue;
				case 4u:
					l7h4VBBMc07P3vNnM356szhuAGD[num3].Write(w);
					num = 479083884;
					continue;
				case 2u:
					num3++;
					num = (int)((num2 * 1726443881) ^ 0x7F9186CC);
					continue;
				case 8u:
					num3 = 0;
					num = (int)(num2 * 1319699151) ^ -1742864315;
					continue;
				case 7u:
					_r0866iEhjgniNmmLz9ygFmfaWPA.Write(w);
					num = ((int)num2 * -1995520852) ^ -647707083;
					continue;
				case 1u:
					num = ((int)num2 * -45702756) ^ -433422434;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < l7h4VBBMc07P3vNnM356szhuAGD.Length)
					{
						num = 1158436478;
						num4 = num;
					}
					else
					{
						num = 1001625375;
						num4 = num;
					}
					continue;
				}
				case 9u:
					w.Write((short)_L7h4VBBMc07P3vNnM356szhuAGD.Length);
					l7h4VBBMc07P3vNnM356szhuAGD = _L7h4VBBMc07P3vNnM356szhuAGD;
					num = (int)((num2 * 858521765) ^ 0x1EEA156F);
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}
}
