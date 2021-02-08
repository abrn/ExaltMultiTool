using ExaltMultiTool.Proxy.Networking.Packets;

internal class TradeChangedPacket : Packet
{
	public bool[] _0h8At9YDPK5LLRJcvXdH3I0Hmpe;

	public override PacketType pType => PacketType.TRADECHANGED;

	public override void readPacketData(PacketReader r)
	{
		_0h8At9YDPK5LLRJcvXdH3I0Hmpe = new bool[r.ReadInt16()];
		int num3 = default(int);
		while (true)
		{
			int num = 285783924;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3AA91770u) % 5u)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
					num3 = 0;
					num = (int)(num2 * 1989423322) ^ -1148646898;
					continue;
				case 0u:
					_0h8At9YDPK5LLRJcvXdH3I0Hmpe[num3] = r.ReadBoolean();
					num3++;
					num = 1954154854;
					continue;
				case 1u:
				{
					int num4;
					if (num3 >= _0h8At9YDPK5LLRJcvXdH3I0Hmpe.Length)
					{
						num = 1287141689;
						num4 = num;
					}
					else
					{
						num = 2102554408;
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
		w.Write((ushort)_0h8At9YDPK5LLRJcvXdH3I0Hmpe.Length);
		int num3 = default(int);
		bool value = default(bool);
		bool[] array = default(bool[]);
		while (true)
		{
			int num = 150608936;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x59C65E31u) % 8u)
				{
				case 3u:
					break;
				default:
					return;
				case 7u:
					num3++;
					num = ((int)num2 * -273925621) ^ -1766545903;
					continue;
				case 4u:
					num3 = 0;
					num = ((int)num2 * -888515633) ^ -252417968;
					continue;
				case 2u:
					value = array[num3];
					num = 494092289;
					continue;
				case 5u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = 129673063;
						num4 = num;
					}
					else
					{
						num = 831050971;
						num4 = num;
					}
					continue;
				}
				case 0u:
					w.Write(value);
					num = (int)(num2 * 31070778) ^ -356414594;
					continue;
				case 1u:
					array = _0h8At9YDPK5LLRJcvXdH3I0Hmpe;
					num = ((int)num2 * -470415463) ^ -1023738308;
					continue;
				case 6u:
					return;
				}
				break;
			}
		}
	}
}
