using ExaltMultiTool.Proxy.Networking.Packets;

internal class OtherHitPacket : Packet
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public byte _isVjytSCPjaQXfnhSgmbShfAEYC;

	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public int _91Zhx0OBsUhlR5optw0cihxmls4;

	public override PacketType pType => PacketType.OTHERHIT;

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		while (true)
		{
			int num = -637923546;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x94AA6162u) % 3u)
				{
				case 0u:
					break;
				case 2u:
					goto IL_002e;
				default:
					_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
					_91Zhx0OBsUhlR5optw0cihxmls4 = r.ReadInt32();
					return;
				}
				break;
				IL_002e:
				_isVjytSCPjaQXfnhSgmbShfAEYC = r.ReadByte();
				num = (int)((num2 * 828066467) ^ 0x69D85C8B);
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		while (true)
		{
			int num = 1303350953;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6298EA09u) % 3u)
				{
				case 0u:
					break;
				case 2u:
					goto IL_002e;
				default:
					w.Write(_91Zhx0OBsUhlR5optw0cihxmls4);
					return;
				}
				break;
				IL_002e:
				w.Write(_isVjytSCPjaQXfnhSgmbShfAEYC);
				w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
				num = ((int)num2 * -433579151) ^ 0x5D5AE953;
			}
		}
	}
}
