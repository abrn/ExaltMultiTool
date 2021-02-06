using ExaltMultiTool.Proxy.Networking.Packets;

internal class _ZD5XGucA7QEeG0HdJJp9qh2Ai0c : Packet
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public byte _isVjytSCPjaQXfnhSgmbShfAEYC;

	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public override PacketType pType => PacketType.SQUAREHIT;

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		_isVjytSCPjaQXfnhSgmbShfAEYC = r.ReadByte();
		while (true)
		{
			int num = -2068298640;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84C5BD46u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_003a;
				case 1u:
					return;
				}
				break;
				IL_003a:
				_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
				num = (int)((num2 * 1434351781) ^ 0x6846C30C);
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		while (true)
		{
			int num = -824295969;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB12DB4F9u) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					w.Write(_isVjytSCPjaQXfnhSgmbShfAEYC);
					num = (int)((num2 * 1006633340) ^ 0x17252C36);
					continue;
				case 3u:
					w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
					num = (int)((num2 * 1701133214) ^ 0x61C58CC6);
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
