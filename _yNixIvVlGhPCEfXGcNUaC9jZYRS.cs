using System.Drawing;
using System.IO;

internal struct _yNixIvVlGhPCEfXGcNUaC9jZYRS
{
	public byte _e83B5VoPYGBwUAJrm6D3QiZAjKN;

	public byte _h27dzUIWOz6YD4vVCMWISV9HD6E;

	public byte _FceRcYJFuOsQJwJEoG7HX1TihKF;

	public byte _iY21vLRI7ndcaxztdbqOkfd6QbK;

	public _yNixIvVlGhPCEfXGcNUaC9jZYRS(uint argb)
	{
		_e83B5VoPYGBwUAJrm6D3QiZAjKN = (byte)((argb & 0xFF000000u) >> 24);
		_iY21vLRI7ndcaxztdbqOkfd6QbK = (byte)((argb & 0xFF0000) >> 16);
		_FceRcYJFuOsQJwJEoG7HX1TihKF = (byte)((argb & 0xFF00) >> 8);
		_h27dzUIWOz6YD4vVCMWISV9HD6E = (byte)(argb & 0xFFu);
	}

	public _yNixIvVlGhPCEfXGcNUaC9jZYRS(byte a, byte r, byte g, byte b)
	{
		_e83B5VoPYGBwUAJrm6D3QiZAjKN = a;
		_iY21vLRI7ndcaxztdbqOkfd6QbK = r;
		_FceRcYJFuOsQJwJEoG7HX1TihKF = g;
		_h27dzUIWOz6YD4vVCMWISV9HD6E = b;
	}

	public static _yNixIvVlGhPCEfXGcNUaC9jZYRS _kCo2RCMYpYNoTPdfGQVnKgPh7Fc(PacketReader r)
	{
		_yNixIvVlGhPCEfXGcNUaC9jZYRS result = default(_yNixIvVlGhPCEfXGcNUaC9jZYRS);
		while (true)
		{
			int num = 1828693633;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x285F69F8u) % 5u)
				{
				case 2u:
					break;
				case 1u:
					result._e83B5VoPYGBwUAJrm6D3QiZAjKN = r.ReadByte();
					num = (int)(num2 * 139592834) ^ -1938703078;
					continue;
				case 3u:
					result._FceRcYJFuOsQJwJEoG7HX1TihKF = r.ReadByte();
					num = ((int)num2 * -2070614891) ^ -1332039611;
					continue;
				case 0u:
					result._iY21vLRI7ndcaxztdbqOkfd6QbK = r.ReadByte();
					num = ((int)num2 * -681042691) ^ 0x22A4564C;
					continue;
				default:
					result._h27dzUIWOz6YD4vVCMWISV9HD6E = r.ReadByte();
					return result;
				}
				break;
			}
		}
	}

	public void _3Wc8kZJjhbRt6nttAKwD2698imm(PacketWriter w)
	{
		w.Write(_e83B5VoPYGBwUAJrm6D3QiZAjKN);
		w.Write(_iY21vLRI7ndcaxztdbqOkfd6QbK);
		while (true)
		{
			int num = -1590137385;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF86EF731u) % 3u)
				{
				case 0u:
					break;
				case 1u:
					goto IL_003a;
				default:
					w.Write(_h27dzUIWOz6YD4vVCMWISV9HD6E);
					return;
				}
				break;
				IL_003a:
				w.Write(_FceRcYJFuOsQJwJEoG7HX1TihKF);
				num = (int)(num2 * 574328314) ^ -2116633049;
			}
		}
	}

	public void _3Wc8kZJjhbRt6nttAKwD2698imm(BinaryWriter w)
	{
		w.Write(_e83B5VoPYGBwUAJrm6D3QiZAjKN);
		while (true)
		{
			int num = -2075117892;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x91C43032u) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					w.Write(_iY21vLRI7ndcaxztdbqOkfd6QbK);
					w.Write(_FceRcYJFuOsQJwJEoG7HX1TihKF);
					num = ((int)num2 * -50212183) ^ -1355503641;
					continue;
				case 3u:
					w.Write(_h27dzUIWOz6YD4vVCMWISV9HD6E);
					num = (int)((num2 * 375562998) ^ 0x5287785);
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override string _SflzbyPcrkdh9uZXinsV7KrbBMw()
	{
		return Color.FromArgb(_e83B5VoPYGBwUAJrm6D3QiZAjKN, _iY21vLRI7ndcaxztdbqOkfd6QbK, _FceRcYJFuOsQJwJEoG7HX1TihKF, _h27dzUIWOz6YD4vVCMWISV9HD6E).Name;
	}
}
