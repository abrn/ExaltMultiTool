using System.Collections.Generic;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class _6pKdmCCsY94cj5aeuO02vIF8pTF : Packet
{
	public bool _PJSppIZJztu4HXLKvqK1ZeiDLym;

	public List<SlotObjectData> _kVjmDjO0EsOA1E453qMDXEPexOp;

	public override PacketType pType => PacketType.FORGEDISMANTLERESPONSE;

	public override void readPacketData(PacketReader r)
	{
		_PJSppIZJztu4HXLKvqK1ZeiDLym = r.ReadBoolean();
		int num3 = default(int);
		byte b = default(byte);
		while (true)
		{
			int num = 1706411695;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7EEC5DD8u) % 7u)
				{
				case 3u:
					break;
				default:
					return;
				case 4u:
				{
					int num4;
					if (num3 < b)
					{
						num = 248404849;
						num4 = num;
					}
					else
					{
						num = 473618222;
						num4 = num;
					}
					continue;
				}
				case 0u:
					num3 = 0;
					num = (int)(num2 * 2084483621) ^ -2048105;
					continue;
				case 2u:
					_kVjmDjO0EsOA1E453qMDXEPexOp.Add(new SlotObjectData(r));
					num = 253049314;
					continue;
				case 6u:
					b = r.ReadByte();
					_kVjmDjO0EsOA1E453qMDXEPexOp = new List<SlotObjectData>();
					num = (int)(num2 * 1806425782) ^ -155983284;
					continue;
				case 5u:
					num3++;
					num = ((int)num2 * -579627091) ^ 0x75E98FA3;
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
		w.Write(_PJSppIZJztu4HXLKvqK1ZeiDLym);
		w.Write((byte)_kVjmDjO0EsOA1E453qMDXEPexOp.Count);
		using List<SlotObjectData>.Enumerator enumerator = _kVjmDjO0EsOA1E453qMDXEPexOp.GetEnumerator();
		while (true)
		{
			int num;
			int num2;
			if (!enumerator.MoveNext())
			{
				num = 756898476;
				num2 = num;
			}
			else
			{
				num = 1465539939;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x38EF5E52u) % 4u)
				{
				case 0u:
					num = 1465539939;
					continue;
				default:
					return;
				case 1u:
					enumerator.Current.WriteSlotObjectData(w);
					num = 1349281385;
					continue;
				case 3u:
					break;
				case 2u:
					return;
				}
				break;
			}
		}
	}
}
