using ExaltMultiTool.Proxy.Networking.Packets;

internal class QuestRedeemPacket : Packet
{
	public string _f2jpvxcXPLcaExv7D8cBTW72Djq;

	public SlotObjectData[] _GEW209MB6xddgvJd4U6XHvhZbRN;

	public int _pPnXctzJayWPUUCyEk8VAuhuFpD;

	public override PacketType pType => PacketType.QUESTREDEEM;

	public override void readPacketData(PacketReader r)
	{
		_f2jpvxcXPLcaExv7D8cBTW72Djq = r.ReadString();
		_pPnXctzJayWPUUCyEk8VAuhuFpD = r.ReadInt32();
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = 1451368420;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B478D83u) % 8u)
				{
				case 4u:
					break;
				default:
					return;
				case 3u:
					_GEW209MB6xddgvJd4U6XHvhZbRN[num4] = new SlotObjectData(r);
					num = 1793144286;
					continue;
				case 1u:
				{
					int num5;
					if (num4 >= num3)
					{
						num = 2092484601;
						num5 = num;
					}
					else
					{
						num = 1466887872;
						num5 = num;
					}
					continue;
				}
				case 0u:
					num = (int)(num2 * 1326582879) ^ -579113270;
					continue;
				case 5u:
					num4++;
					num = (int)(num2 * 520405953) ^ -950268449;
					continue;
				case 7u:
					num3 = r.ReadInt16();
					num = (int)((num2 * 1390904232) ^ 0x11612A15);
					continue;
				case 6u:
					_GEW209MB6xddgvJd4U6XHvhZbRN = new SlotObjectData[num3];
					num4 = 0;
					num = (int)(num2 * 1044505656) ^ -230635413;
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
		w.Write(_f2jpvxcXPLcaExv7D8cBTW72Djq);
		SlotObjectData[] gEW209MB6xddgvJd4U6XHvhZbRN = default(SlotObjectData[]);
		int num3 = default(int);
		while (true)
		{
			int num = 108771543;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4112047Bu) % 8u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					gEW209MB6xddgvJd4U6XHvhZbRN[num3].WriteSlotObjectData(w);
					num = 1549886550;
					continue;
				case 6u:
					num3 = 0;
					num = (int)((num2 * 1096477810) ^ 0x2F4406BC);
					continue;
				case 5u:
					num3++;
					num = (int)(num2 * 1526397364) ^ -1880258386;
					continue;
				case 4u:
					w.Write(_pPnXctzJayWPUUCyEk8VAuhuFpD);
					w.Write((short)_GEW209MB6xddgvJd4U6XHvhZbRN.Length);
					gEW209MB6xddgvJd4U6XHvhZbRN = _GEW209MB6xddgvJd4U6XHvhZbRN;
					num = ((int)num2 * -1928461124) ^ 0x48554FB5;
					continue;
				case 3u:
					num = (int)((num2 * 417926980) ^ 0x26940A26);
					continue;
				case 1u:
				{
					int num4;
					if (num3 < gEW209MB6xddgvJd4U6XHvhZbRN.Length)
					{
						num = 1582007801;
						num4 = num;
					}
					else
					{
						num = 1251485804;
						num4 = num;
					}
					continue;
				}
				case 7u:
					return;
				}
				break;
			}
		}
	}
}
