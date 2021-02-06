using ExaltMultiTool.Proxy.Networking.Packets;

internal class _xSbKxKAB2NUAInioqMLBjQdhNTY : Packet
{
	public const int _cXSC2EsfzhQPjgY4MWjDi8cTlBq = 1;

	public const int _rq7YPSf609pmQcltnO0CdIDSXGI = 2;

	public const int _hLLcN1nV3t4adCBmgYOtxEnOkIcA = 3;

	public byte _Mg3vcvTcJXOKNfcbJ0o921kDxTx;

	public int _JXVEgjABfdDgHgsprl4mkYpIUNp;

	public int _x1in1q2qcIdSR1TLWnnpGCKzAXD;

	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public byte _LWCRtqgUMlKocxQy7x8OnCzLjeE;

	public SlotObjectData[] _VLQQenl3qs0VejqodamYwytuvdh;

	public override PacketType pType => PacketType.PETUPGRADEREQUEST;

	public override void readPacketData(PacketReader r)
	{
		_Mg3vcvTcJXOKNfcbJ0o921kDxTx = r.ReadByte();
		int num3 = default(int);
		while (true)
		{
			int num = -718118377;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE1C7CFB6u) % 7u)
				{
				case 4u:
					break;
				default:
					return;
				case 0u:
				{
					int num4;
					if (num3 >= _VLQQenl3qs0VejqodamYwytuvdh.Length)
					{
						num = -1138525871;
						num4 = num;
					}
					else
					{
						num = -2049529694;
						num4 = num;
					}
					continue;
				}
				case 5u:
					_LWCRtqgUMlKocxQy7x8OnCzLjeE = r.ReadByte();
					_VLQQenl3qs0VejqodamYwytuvdh = new SlotObjectData[r.ReadInt16()];
					num3 = 0;
					num = (int)(num2 * 1878823349) ^ -1029713157;
					continue;
				case 6u:
					_VLQQenl3qs0VejqodamYwytuvdh[num3] = new SlotObjectData(r);
					num3++;
					num = -383242753;
					continue;
				case 1u:
					_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
					num = ((int)num2 * -1866613594) ^ -1680542588;
					continue;
				case 2u:
					_JXVEgjABfdDgHgsprl4mkYpIUNp = r.ReadInt32();
					_x1in1q2qcIdSR1TLWnnpGCKzAXD = r.ReadInt32();
					num = (int)(num2 * 1786464982) ^ -1799890735;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Mg3vcvTcJXOKNfcbJ0o921kDxTx);
		SlotObjectData[] vLQQenl3qs0VejqodamYwytuvdh = default(SlotObjectData[]);
		int num3 = default(int);
		while (true)
		{
			int num = 1913099413;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D65C638u) % 8u)
				{
				case 6u:
					break;
				default:
					return;
				case 5u:
					w.Write(_JXVEgjABfdDgHgsprl4mkYpIUNp);
					w.Write(_x1in1q2qcIdSR1TLWnnpGCKzAXD);
					num = (int)((num2 * 1655634129) ^ 0x7EB9640D);
					continue;
				case 3u:
					vLQQenl3qs0VejqodamYwytuvdh[num3].WriteSlotObjectData(w);
					num3++;
					num = 1467220618;
					continue;
				case 0u:
					w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
					w.Write(_LWCRtqgUMlKocxQy7x8OnCzLjeE);
					w.Write((short)_VLQQenl3qs0VejqodamYwytuvdh.Length);
					vLQQenl3qs0VejqodamYwytuvdh = _VLQQenl3qs0VejqodamYwytuvdh;
					num = (int)(num2 * 1569797627) ^ -1342800513;
					continue;
				case 7u:
					num3 = 0;
					num = ((int)num2 * -2066887946) ^ 0x58CF2B7E;
					continue;
				case 4u:
					num = (int)(num2 * 933837148) ^ -2311974;
					continue;
				case 2u:
				{
					int num4;
					if (num3 >= vLQQenl3qs0VejqodamYwytuvdh.Length)
					{
						num = 1982710905;
						num4 = num;
					}
					else
					{
						num = 903480275;
						num4 = num;
					}
					continue;
				}
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
