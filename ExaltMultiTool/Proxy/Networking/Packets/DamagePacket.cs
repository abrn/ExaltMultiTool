using ExaltMultiTool.Proxy.Networking.Packets;

internal class DamagePacket : Packet
{
	private const int _0RGCnOPAnETktP4HQK3tzM4aEqS = 1;

	private const int _bPzZBh0Z71myfvA4f5ObbcWoxUx = 2;

	private const int _3FF8faD4zLlfkDUhCXo7FpqmAnj = 4;

	public int _91Zhx0OBsUhlR5optw0cihxmls4;

	public byte[] _kvTyEminxJMM6fREzgqsVjHaInC;

	public ushort _C3mvDTxTLKOCwcaeO4BKeVV1ydo;

	public byte _G12PrLHcGlE3EkvahRVEKj2tR4Q;

	public bool _k5GCrZ5S2sEEct1r881EYiKCcKt;

	public bool _l0mdLwT0Lqvn0oV26TZ8wa7mjTf;

	public bool _yqZ3QDNMGmU0DwKcYqI5cLLIG8g;

	public byte _isVjytSCPjaQXfnhSgmbShfAEYC;

	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public override PacketType pType => PacketType.DAMAGE;

	public override void readPacketData(PacketReader r)
	{
		_91Zhx0OBsUhlR5optw0cihxmls4 = r.ReadInt32();
		int num3 = default(int);
		while (true)
		{
			int num = 1773745220;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D3D762Du) % 10u)
				{
				case 2u:
					break;
				default:
					return;
				case 9u:
					_l0mdLwT0Lqvn0oV26TZ8wa7mjTf = (_G12PrLHcGlE3EkvahRVEKj2tR4Q & 2) != 0;
					_yqZ3QDNMGmU0DwKcYqI5cLLIG8g = (_G12PrLHcGlE3EkvahRVEKj2tR4Q & 4) != 0;
					num = ((int)num2 * -769068070) ^ -1967628722;
					continue;
				case 4u:
					num = (int)(num2 * 1782623450) ^ -603843007;
					continue;
				case 1u:
					_isVjytSCPjaQXfnhSgmbShfAEYC = r.ReadByte();
					_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
					num = ((int)num2 * -218623488) ^ 0x3AAD8FAF;
					continue;
				case 7u:
					_kvTyEminxJMM6fREzgqsVjHaInC = new byte[r.ReadByte()];
					num3 = 0;
					num = ((int)num2 * -551495207) ^ -1558148830;
					continue;
				case 6u:
					_C3mvDTxTLKOCwcaeO4BKeVV1ydo = r.ReadUInt16();
					num = (int)(num2 * 655023792) ^ -1135543854;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < _kvTyEminxJMM6fREzgqsVjHaInC.Length)
					{
						num = 87857044;
						num4 = num;
					}
					else
					{
						num = 67597573;
						num4 = num;
					}
					continue;
				}
				case 5u:
					_kvTyEminxJMM6fREzgqsVjHaInC[num3] = r.ReadByte();
					num3++;
					num = 999028653;
					continue;
				case 3u:
					_G12PrLHcGlE3EkvahRVEKj2tR4Q = r.ReadByte();
					_k5GCrZ5S2sEEct1r881EYiKCcKt = (_G12PrLHcGlE3EkvahRVEKj2tR4Q & 1) != 0;
					num = (int)((num2 * 59845417) ^ 0x72659B19);
					continue;
				case 8u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_91Zhx0OBsUhlR5optw0cihxmls4);
		w.Write((byte)_kvTyEminxJMM6fREzgqsVjHaInC.Length);
		byte[] kvTyEminxJMM6fREzgqsVjHaInC = default(byte[]);
		byte value = default(byte);
		int num3 = default(int);
		while (true)
		{
			int num = 1825566241;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x31DC2B6Cu) % 10u)
				{
				case 7u:
					break;
				case 1u:
					kvTyEminxJMM6fREzgqsVjHaInC = _kvTyEminxJMM6fREzgqsVjHaInC;
					num = (int)(num2 * 696050328) ^ -229751267;
					continue;
				case 2u:
					value = kvTyEminxJMM6fREzgqsVjHaInC[num3];
					num = 526671774;
					continue;
				case 5u:
					num = ((int)num2 * -447255083) ^ -1693214515;
					continue;
				case 0u:
				{
					int num4;
					if (num3 < kvTyEminxJMM6fREzgqsVjHaInC.Length)
					{
						num = 867236672;
						num4 = num;
					}
					else
					{
						num = 1207878733;
						num4 = num;
					}
					continue;
				}
				case 9u:
					w.Write(_C3mvDTxTLKOCwcaeO4BKeVV1ydo);
					w.Write(_G12PrLHcGlE3EkvahRVEKj2tR4Q);
					num = ((int)num2 * -1547019652) ^ 0x12F38CDA;
					continue;
				case 3u:
					num3 = 0;
					num = ((int)num2 * -426356830) ^ 0x11C1A66F;
					continue;
				case 4u:
					w.Write(_isVjytSCPjaQXfnhSgmbShfAEYC);
					num = (int)((num2 * 1772985691) ^ 0x4EB426B0);
					continue;
				case 8u:
					w.Write(value);
					num3++;
					num = (int)(num2 * 1220779897) ^ -493849494;
					continue;
				default:
					w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
					return;
				}
				break;
			}
		}
	}
}
