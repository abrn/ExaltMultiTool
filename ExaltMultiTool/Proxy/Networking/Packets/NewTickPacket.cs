using System.Collections.Generic;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class NewTickPacket : Packet
{
	public int _D4Xpe2utS1cwv8fGTeXUOkTlvMi;

	public int _MzlKH2guiz5FZ1cN2sOqdMa185b;

	public uint _1CxThJhmcaqsYpDnyOfRsdJji0f;

	public ushort _sByBjT9fPBLIdH9MbsxJMUIPK0d;

	public List<Status> _UEmErv2L2MQXrwsVtG0rtsVhAnB;

	public override PacketType pType => PacketType.NEWTICK;

	public override void readPacketData(PacketReader r)
	{
		_D4Xpe2utS1cwv8fGTeXUOkTlvMi = r.ReadInt32();
		int num3 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num = 76483513;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41BD57ECu) % 10u)
				{
				case 9u:
					break;
				default:
					return;
				case 4u:
					_sByBjT9fPBLIdH9MbsxJMUIPK0d = r.ReadUInt16();
					num = (int)(num2 * 296941492) ^ -1972329557;
					continue;
				case 0u:
				{
					int num5;
					if (num3 < num4)
					{
						num = 341314106;
						num5 = num;
					}
					else
					{
						num = 2145125685;
						num5 = num;
					}
					continue;
				}
				case 7u:
					num4 = r.ReadInt16();
					num = (int)(num2 * 1020849192) ^ -769598871;
					continue;
				case 1u:
					_MzlKH2guiz5FZ1cN2sOqdMa185b = r.ReadInt32();
					num = ((int)num2 * -1288944800) ^ 0x1079F364;
					continue;
				case 6u:
					_UEmErv2L2MQXrwsVtG0rtsVhAnB.Add((Status)new Status()._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r));
					num3++;
					num = 1469270968;
					continue;
				case 5u:
					_UEmErv2L2MQXrwsVtG0rtsVhAnB = new List<Status>();
					num = ((int)num2 * -1543659535) ^ -1454138393;
					continue;
				case 2u:
					_1CxThJhmcaqsYpDnyOfRsdJji0f = r.ReadUInt32();
					num = (int)(num2 * 341290832) ^ -812039524;
					continue;
				case 8u:
					num3 = 0;
					num = ((int)num2 * -773838211) ^ -296087274;
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
		w.Write(_D4Xpe2utS1cwv8fGTeXUOkTlvMi);
		w.Write(_MzlKH2guiz5FZ1cN2sOqdMa185b);
		while (true)
		{
			int num = -1177493796;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80E70645u) % 5u)
				{
				case 0u:
					break;
				case 1u:
					w.Write(_1CxThJhmcaqsYpDnyOfRsdJji0f);
					num = (int)((num2 * 1035035620) ^ 0x1E6A7FAF);
					continue;
				case 2u:
					w.Write(_sByBjT9fPBLIdH9MbsxJMUIPK0d);
					num = ((int)num2 * -638269191) ^ 0x53C91CE2;
					continue;
				case 3u:
					w.Write((short)_UEmErv2L2MQXrwsVtG0rtsVhAnB.Count);
					num = (int)((num2 * 1712390025) ^ 0x75A8D14D);
					continue;
				default:
				{
					using List<Status>.Enumerator enumerator = _UEmErv2L2MQXrwsVtG0rtsVhAnB.GetEnumerator();
					while (true)
					{
						int num3;
						int num4;
						if (!enumerator.MoveNext())
						{
							num3 = -987254074;
							num4 = num3;
						}
						else
						{
							num3 = -964310112;
							num4 = num3;
						}
						while (true)
						{
							switch ((num2 = (uint)num3 ^ 0x80E70645u) % 4u)
							{
							case 0u:
								num3 = -964310112;
								continue;
							default:
								return;
							case 1u:
								enumerator.Current._3Wc8kZJjhbRt6nttAKwD2698imm(w);
								num3 = -1733873953;
								continue;
							case 2u:
								break;
							case 3u:
								return;
							}
							break;
						}
					}
				}
				}
				break;
			}
		}
	}
}
