using ExaltMultiTool.Proxy.Networking.Packets;

internal class _nWdvhR8UBSRRcwtgVQdwdH5TTEj : Packet
{
	public _0e95pRmOma7jMYcnTtJbSNEfZnr[] _md574KakEwdeK8VyFjDGu2o4g1D;

	public string _I6ghzagbfWQACBjpHyBbVsaZAqwb;

	public _0e95pRmOma7jMYcnTtJbSNEfZnr[] _8rqZ24IVjbUHpgqSlWFNuF2sT3E;

	public int _M1cHg3qnMRHoafox7e6AU5bZjJm;

	public override PacketType pType => PacketType.TRADESTART;

	public override void readPacketData(PacketReader r)
	{
		_md574KakEwdeK8VyFjDGu2o4g1D = new _0e95pRmOma7jMYcnTtJbSNEfZnr[r.ReadInt16()];
		int num5 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1043250015;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC96F1D78u) % 14u)
				{
				case 6u:
					break;
				default:
					return;
				case 9u:
					num5 = 0;
					num = (int)(num2 * 1601485367) ^ -1669397321;
					continue;
				case 2u:
					_I6ghzagbfWQACBjpHyBbVsaZAqwb = r.ReadString();
					num = (int)((num2 * 1802042970) ^ 0x1E987E89);
					continue;
				case 0u:
					num5++;
					num = (int)(num2 * 1729192900) ^ -1914123549;
					continue;
				case 3u:
					_md574KakEwdeK8VyFjDGu2o4g1D[num5] = new _0e95pRmOma7jMYcnTtJbSNEfZnr(r);
					num = -269174898;
					continue;
				case 13u:
					_M1cHg3qnMRHoafox7e6AU5bZjJm = r.ReadInt32();
					num = (int)(num2 * 1816175595) ^ -1700861345;
					continue;
				case 10u:
					num = (int)((num2 * 1078887131) ^ 0x202AB2CB);
					continue;
				case 7u:
					_8rqZ24IVjbUHpgqSlWFNuF2sT3E = new _0e95pRmOma7jMYcnTtJbSNEfZnr[r.ReadInt16()];
					num = ((int)num2 * -1086104957) ^ -1972135118;
					continue;
				case 1u:
					_8rqZ24IVjbUHpgqSlWFNuF2sT3E[num3] = new _0e95pRmOma7jMYcnTtJbSNEfZnr(r);
					num = -1724143246;
					continue;
				case 12u:
					num3++;
					num = (int)((num2 * 1396592335) ^ 0xDCED0FC);
					continue;
				case 11u:
				{
					int num6;
					if (num5 < _md574KakEwdeK8VyFjDGu2o4g1D.Length)
					{
						num = -977680443;
						num6 = num;
					}
					else
					{
						num = -654772974;
						num6 = num;
					}
					continue;
				}
				case 4u:
				{
					int num4;
					if (num3 < _8rqZ24IVjbUHpgqSlWFNuF2sT3E.Length)
					{
						num = -1564042703;
						num4 = num;
					}
					else
					{
						num = -1534626079;
						num4 = num;
					}
					continue;
				}
				case 5u:
					num3 = 0;
					num = ((int)num2 * -702506341) ^ 0x5AEDA81D;
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
		w.Write((ushort)_md574KakEwdeK8VyFjDGu2o4g1D.Length);
		int num3 = default(int);
		_0e95pRmOma7jMYcnTtJbSNEfZnr[] md574KakEwdeK8VyFjDGu2o4g1D = default(_0e95pRmOma7jMYcnTtJbSNEfZnr[]);
		while (true)
		{
			int num = 597197271;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x4103B8CFu) % 13u)
				{
				case 5u:
					break;
				case 9u:
				{
					int num5;
					if (num3 >= md574KakEwdeK8VyFjDGu2o4g1D.Length)
					{
						num = 1938344694;
						num5 = num;
					}
					else
					{
						num = 1719268987;
						num5 = num;
					}
					continue;
				}
				case 0u:
					md574KakEwdeK8VyFjDGu2o4g1D[num3]._3Wc8kZJjhbRt6nttAKwD2698imm(w);
					num = 616559938;
					continue;
				case 10u:
				{
					int num4;
					if (num3 < md574KakEwdeK8VyFjDGu2o4g1D.Length)
					{
						num = 518561356;
						num4 = num;
					}
					else
					{
						num = 684873271;
						num4 = num;
					}
					continue;
				}
				case 1u:
					num = ((int)num2 * -1650936737) ^ -1611871742;
					continue;
				case 8u:
					md574KakEwdeK8VyFjDGu2o4g1D = _md574KakEwdeK8VyFjDGu2o4g1D;
					num = (int)((num2 * 315024839) ^ 0x56AFF4E4);
					continue;
				case 12u:
					md574KakEwdeK8VyFjDGu2o4g1D[num3]._3Wc8kZJjhbRt6nttAKwD2698imm(w);
					num = 613638088;
					continue;
				case 3u:
					w.Write(_I6ghzagbfWQACBjpHyBbVsaZAqwb);
					w.Write((ushort)_8rqZ24IVjbUHpgqSlWFNuF2sT3E.Length);
					md574KakEwdeK8VyFjDGu2o4g1D = _8rqZ24IVjbUHpgqSlWFNuF2sT3E;
					num3 = 0;
					num = (int)((num2 * 862602424) ^ 0x67F0FDC6);
					continue;
				case 11u:
					num = (int)(num2 * 713095700) ^ -1625801591;
					continue;
				case 4u:
					num3++;
					num = ((int)num2 * -1861515973) ^ 0x63F5591D;
					continue;
				case 7u:
					num3 = 0;
					num = (int)(num2 * 690410229) ^ -1997063120;
					continue;
				case 6u:
					num3++;
					num = ((int)num2 * -1531419825) ^ -1015948172;
					continue;
				default:
					w.Write(_M1cHg3qnMRHoafox7e6AU5bZjJm);
					return;
				}
				break;
			}
		}
	}
}
