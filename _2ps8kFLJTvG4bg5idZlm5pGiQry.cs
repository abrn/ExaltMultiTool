using System;
using System.Text;

internal class _2ps8kFLJTvG4bg5idZlm5pGiQry
{
	private static readonly int _t3YCW9mRKEsmxTAbB9ePgjGh3vO = 256;

	private byte[] _o0O3vwbrhWRjD7Rf8KFFYkBLpJw;

	private int _9M0M4FsgDZOfxwDc9Ew4YKgGimY;

	private int _6fpz4HWazbE78JNyAvFH5JVDQsF;

	private byte[] _uLxXB3Ohjz3q3tnikqTV4KM84Yc;

	public _2ps8kFLJTvG4bg5idZlm5pGiQry(byte[] key)
	{
		_uLxXB3Ohjz3q3tnikqTV4KM84Yc = key;
		_g0jwkGBqJwqQii6TVP2camNvrDJ(_uLxXB3Ohjz3q3tnikqTV4KM84Yc);
	}

	public _2ps8kFLJTvG4bg5idZlm5pGiQry(string hexString)
	{
		while (true)
		{
			int num = -77765667;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC92F4428u) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					_uLxXB3Ohjz3q3tnikqTV4KM84Yc = _heBGzcYICjJ66XC3tq6ybNspg3b(hexString);
					num = (int)((num2 * 962042260) ^ 0x4AA752C2);
					continue;
				case 2u:
					_g0jwkGBqJwqQii6TVP2camNvrDJ(_uLxXB3Ohjz3q3tnikqTV4KM84Yc);
					num = ((int)num2 * -1468932726) ^ 0x5C83086B;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public void _zAcJWalBH8qNGGEljyZyZCOwX2m(byte[] packet)
	{
		_uXn2h0RxYjivGai7YnPxhJYPMGG(packet, 5, packet.Length - 5, packet, 5);
	}

	public void _bNSgTzhOj4L5qA7BwtW8kYZek7f()
	{
		_g0jwkGBqJwqQii6TVP2camNvrDJ(_uLxXB3Ohjz3q3tnikqTV4KM84Yc);
	}

	private void _uXn2h0RxYjivGai7YnPxhJYPMGG(byte[] input, int inOff, int length, byte[] output, int outOff)
	{
		int num = 0;
		byte b = default(byte);
		while (true)
		{
			int num2;
			int num3;
			if (num >= length)
			{
				num2 = -397192919;
				num3 = num2;
			}
			else
			{
				num2 = -1800245037;
				num3 = num2;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0xED446670u) % 9u)
				{
				case 4u:
					num2 = -1800245037;
					continue;
				default:
					return;
				case 0u:
					break;
				case 3u:
					num++;
					num2 = ((int)num4 * -329349769) ^ -82723477;
					continue;
				case 1u:
					_o0O3vwbrhWRjD7Rf8KFFYkBLpJw[_9M0M4FsgDZOfxwDc9Ew4YKgGimY] = _o0O3vwbrhWRjD7Rf8KFFYkBLpJw[_6fpz4HWazbE78JNyAvFH5JVDQsF];
					num2 = ((int)num4 * -1126495955) ^ -665018238;
					continue;
				case 6u:
					_9M0M4FsgDZOfxwDc9Ew4YKgGimY = (_9M0M4FsgDZOfxwDc9Ew4YKgGimY + 1) & 0xFF;
					_6fpz4HWazbE78JNyAvFH5JVDQsF = (_o0O3vwbrhWRjD7Rf8KFFYkBLpJw[_9M0M4FsgDZOfxwDc9Ew4YKgGimY] + _6fpz4HWazbE78JNyAvFH5JVDQsF) & 0xFF;
					num2 = -197455258;
					continue;
				case 2u:
					_o0O3vwbrhWRjD7Rf8KFFYkBLpJw[_6fpz4HWazbE78JNyAvFH5JVDQsF] = b;
					num2 = ((int)num4 * -1339842602) ^ 0x1D9D358C;
					continue;
				case 5u:
					b = _o0O3vwbrhWRjD7Rf8KFFYkBLpJw[_9M0M4FsgDZOfxwDc9Ew4YKgGimY];
					num2 = ((int)num4 * -393376590) ^ -1110873180;
					continue;
				case 8u:
					output[num + outOff] = (byte)(input[num + inOff] ^ _o0O3vwbrhWRjD7Rf8KFFYkBLpJw[(_o0O3vwbrhWRjD7Rf8KFFYkBLpJw[_9M0M4FsgDZOfxwDc9Ew4YKgGimY] + _o0O3vwbrhWRjD7Rf8KFFYkBLpJw[_6fpz4HWazbE78JNyAvFH5JVDQsF]) & 0xFF]);
					num2 = ((int)num4 * -1598000906) ^ 0xCD6E784;
					continue;
				case 7u:
					return;
				}
				break;
			}
		}
	}

	private void _g0jwkGBqJwqQii6TVP2camNvrDJ(byte[] keyBytes)
	{
		_uLxXB3Ohjz3q3tnikqTV4KM84Yc = keyBytes;
		int num9 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		byte b = default(byte);
		int num3 = default(int);
		while (true)
		{
			int num = -1785165977;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA2E217BBu) % 20u)
				{
				case 13u:
					break;
				default:
					return;
				case 6u:
					_o0O3vwbrhWRjD7Rf8KFFYkBLpJw[num9] = _o0O3vwbrhWRjD7Rf8KFFYkBLpJw[num5];
					num = (int)((num2 * 215596464) ^ 0x504BB9A2);
					continue;
				case 10u:
					num = (int)((num2 * 299006604) ^ 0x56A7513F);
					continue;
				case 19u:
					num8 = (num8 + 1) % keyBytes.Length;
					num = (int)(num2 * 1857782336) ^ -496475974;
					continue;
				case 9u:
					_o0O3vwbrhWRjD7Rf8KFFYkBLpJw[num5] = b;
					num = ((int)num2 * -16327956) ^ -1901780428;
					continue;
				case 5u:
					num9++;
					num = (int)((num2 * 1822998890) ^ 0x2A020F76);
					continue;
				case 0u:
					_o0O3vwbrhWRjD7Rf8KFFYkBLpJw = new byte[_t3YCW9mRKEsmxTAbB9ePgjGh3vO];
					num = ((int)num2 * -1722101607) ^ -424909279;
					continue;
				case 18u:
					num3 = 0;
					num = -1678601027;
					continue;
				case 14u:
					num8 = 0;
					num = ((int)num2 * -814893190) ^ -931923107;
					continue;
				case 12u:
					_o0O3vwbrhWRjD7Rf8KFFYkBLpJw[num3] = (byte)num3;
					num = -745206866;
					continue;
				case 3u:
				{
					int num10;
					if (num9 >= _t3YCW9mRKEsmxTAbB9ePgjGh3vO)
					{
						num = -644802792;
						num10 = num;
					}
					else
					{
						num = -110411158;
						num10 = num;
					}
					continue;
				}
				case 15u:
					b = _o0O3vwbrhWRjD7Rf8KFFYkBLpJw[num9];
					num = (int)((num2 * 70022456) ^ 0x53B8EC7D);
					continue;
				case 7u:
					num9 = 0;
					num = ((int)num2 * -1523387724) ^ 0x4352E08F;
					continue;
				case 17u:
					num5 = ((keyBytes[num8] & 0xFF) + _o0O3vwbrhWRjD7Rf8KFFYkBLpJw[num9] + num5) & 0xFF;
					num = -1234257332;
					continue;
				case 16u:
				{
					_9M0M4FsgDZOfxwDc9Ew4YKgGimY = (_6fpz4HWazbE78JNyAvFH5JVDQsF = 0);
					int num6;
					int num7;
					if (_o0O3vwbrhWRjD7Rf8KFFYkBLpJw != null)
					{
						num6 = -69982867;
						num7 = num6;
					}
					else
					{
						num6 = -661906409;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 2103756502);
					continue;
				}
				case 2u:
					num5 = 0;
					num = (int)(num2 * 465835011) ^ -1755171938;
					continue;
				case 1u:
					num3++;
					num = ((int)num2 * -1142794340) ^ 0x6269EDBB;
					continue;
				case 4u:
				{
					int num4;
					if (num3 >= _t3YCW9mRKEsmxTAbB9ePgjGh3vO)
					{
						num = -2064620967;
						num4 = num;
					}
					else
					{
						num = -1651308605;
						num4 = num;
					}
					continue;
				}
				case 8u:
					num = (int)(num2 * 910643014) ^ -527990804;
					continue;
				case 11u:
					return;
				}
				break;
			}
		}
	}

	public static byte[] _heBGzcYICjJ66XC3tq6ybNspg3b(string key)
	{
		//Discarded unreachable code: IL_004f
		if (key.Length % 2 != 0)
		{
			goto IL_000a;
		}
		goto IL_0086;
		IL_0086:
		byte[] array = new byte[key.Length / 2];
		char[] array2 = key.ToCharArray();
		int num = 0;
		int num2 = 365832892;
		goto IL_000f;
		IL_000f:
		int num4 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num2 ^ 0x38AF9571u) % 8u)
			{
			case 2u:
				break;
			case 6u:
				throw new ArgumentException("Invalid hex string!");
			case 5u:
				num2 = ((int)num3 * -115868249) ^ -815399637;
				continue;
			case 1u:
				goto IL_006f;
			case 3u:
				goto IL_0086;
			case 7u:
				array[num / 2] = (byte)num4;
				num += 2;
				num2 = (int)((num3 * 1181768981) ^ 0x266506CB);
				continue;
			case 0u:
				num4 = Convert.ToInt32(new StringBuilder(2).Append(array2[num]).Append(array2[num + 1]).ToString(), 16);
				num2 = 431827678;
				continue;
			default:
				return array;
			}
			break;
			IL_006f:
			int num5;
			if (num < array2.Length)
			{
				num2 = 213395937;
				num5 = num2;
			}
			else
			{
				num2 = 586490805;
				num5 = num2;
			}
		}
		goto IL_000a;
		IL_000a:
		num2 = 191223319;
		goto IL_000f;
	}
}
