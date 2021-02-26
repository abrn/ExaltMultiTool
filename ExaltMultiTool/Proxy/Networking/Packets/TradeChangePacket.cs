using ExaltMultiTool.Proxy.Networking.Packets;

internal class TradeChangePacket : Packet
{
	public bool[] _0h8At9YDPK5LLRJcvXdH3I0Hmpe;

	public override PacketType pType => PacketType.CHANGETRADE;

	public override void readPacketData(PacketReader r)
	{
		_0h8At9YDPK5LLRJcvXdH3I0Hmpe = new bool[r.ReadInt16()];
		int num3 = default(int);
		while (true)
		{
			int num = -1715712722;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDA3DBFBCu) % 7u)
				{
				case 5u:
					break;
				default:
					return;
				case 4u:
					num3 = 0;
					num = (int)((num2 * 1593607961) ^ 0x524ED305);
					continue;
				case 2u:
					num = ((int)num2 * -703403781) ^ -1142055833;
					continue;
				case 3u:
					_0h8At9YDPK5LLRJcvXdH3I0Hmpe[num3] = r.ReadBoolean();
					num = -230532467;
					continue;
				case 0u:
				{
					int num4;
					if (num3 >= _0h8At9YDPK5LLRJcvXdH3I0Hmpe.Length)
					{
						num = -955735913;
						num4 = num;
					}
					else
					{
						num = -902541706;
						num4 = num;
					}
					continue;
				}
				case 6u:
					num3++;
					num = (int)((num2 * 48310974) ^ 0x41021C20);
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write((ushort)_0h8At9YDPK5LLRJcvXdH3I0Hmpe.Length);
		bool[] array = _0h8At9YDPK5LLRJcvXdH3I0Hmpe;
		int num3 = default(int);
		bool value = default(bool);
		while (true)
		{
			int num = -234738085;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBC3817A0u) % 7u)
				{
				case 3u:
					break;
				default:
					return;
				case 5u:
				{
					int num4;
					if (num3 >= array.Length)
					{
						num = -1779103466;
						num4 = num;
					}
					else
					{
						num = -1618979571;
						num4 = num;
					}
					continue;
				}
				case 6u:
					w.Write(value);
					num = (int)((num2 * 331478931) ^ 0x271A6BA2);
					continue;
				case 0u:
					value = array[num3];
					num = -303027466;
					continue;
				case 2u:
					num3++;
					num = ((int)num2 * -1124958782) ^ -1336621011;
					continue;
				case 1u:
					num3 = 0;
					num = ((int)num2 * -1575991058) ^ 0x13CEF3B7;
					continue;
				case 4u:
					return;
				}
				break;
			}
		}
	}
}
