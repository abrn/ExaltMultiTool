using ExaltMultiTool.Proxy.Networking.Packets;

internal class PetChangeResultPacket : Packet
{
	public int _tjbHiRznBpNOVIqL5wnfaZ7vOZB;

	public int _fs5BJYKFK8FXABMGk6bv85f0d9kA;

	public int _LWCRtqgUMlKocxQy7x8OnCzLjeE;

	public override PacketType pType => PacketType.PETCHANGESKINMSG;

	public override void readPacketData(PacketReader r)
	{
		_tjbHiRznBpNOVIqL5wnfaZ7vOZB = r.ReadInt32();
		while (true)
		{
			int num = -410250181;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF53FD3C1u) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					_fs5BJYKFK8FXABMGk6bv85f0d9kA = r.ReadInt32();
					num = (int)(num2 * 1615083604) ^ -18079950;
					continue;
				case 3u:
					_LWCRtqgUMlKocxQy7x8OnCzLjeE = r.ReadInt32();
					num = ((int)num2 * -756974836) ^ -1026937712;
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
		w.Write(_tjbHiRznBpNOVIqL5wnfaZ7vOZB);
		while (true)
		{
			int num = -284841259;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFFB79586u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002e;
				case 2u:
					return;
				}
				break;
				IL_002e:
				w.Write(_fs5BJYKFK8FXABMGk6bv85f0d9kA);
				w.Write(_LWCRtqgUMlKocxQy7x8OnCzLjeE);
				num = (int)(num2 * 1004014963) ^ -62110319;
			}
		}
	}
}
