using ExaltMultiTool.Proxy.Networking.Packets;

internal class EnemyHitPacket : Packet
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public byte _isVjytSCPjaQXfnhSgmbShfAEYC;

	public int _91Zhx0OBsUhlR5optw0cihxmls4;

	public bool _k5GCrZ5S2sEEct1r881EYiKCcKt;

	public override PacketType pType => PacketType.ENEMYHIT;

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		while (true)
		{
			int num = 1951508184;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0F7163u) % 4u)
				{
				case 0u:
					break;
				case 3u:
					_isVjytSCPjaQXfnhSgmbShfAEYC = r.ReadByte();
					num = (int)(num2 * 462547061) ^ -1180897758;
					continue;
				case 2u:
					_91Zhx0OBsUhlR5optw0cihxmls4 = r.ReadInt32();
					num = (int)(num2 * 422547669) ^ -1136453156;
					continue;
				default:
					_k5GCrZ5S2sEEct1r881EYiKCcKt = r.ReadBoolean();
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		w.Write(_isVjytSCPjaQXfnhSgmbShfAEYC);
		while (true)
		{
			int num = -1478300883;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x93AD9DECu) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_003a;
				case 2u:
					return;
				}
				break;
				IL_003a:
				w.Write(_91Zhx0OBsUhlR5optw0cihxmls4);
				w.Write(_k5GCrZ5S2sEEct1r881EYiKCcKt);
				num = (int)((num2 * 1687478993) ^ 0x396180C6);
			}
		}
	}
}
