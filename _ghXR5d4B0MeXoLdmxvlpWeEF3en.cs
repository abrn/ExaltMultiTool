using ExaltMultiTool.Proxy.Networking.Packets;

internal class _ghXR5d4B0MeXoLdmxvlpWeEF3en : Packet
{
	public int _Z7iWeS1W3Ht6ch6jgJJ8aFPGFTj;

	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public override PacketType pType => PacketType.PONG;

	public override void readPacketData(PacketReader r)
	{
		_Z7iWeS1W3Ht6ch6jgJJ8aFPGFTj = r.ReadInt32();
		while (true)
		{
			int num = 464419132;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x43DBB5CFu) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_002e;
				case 0u:
					return;
				}
				break;
				IL_002e:
				_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
				num = (int)((num2 * 820442683) ^ 0x5043637E);
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Z7iWeS1W3Ht6ch6jgJJ8aFPGFTj);
		while (true)
		{
			int num = -912798370;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCFCBE1A3u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_002e;
				case 1u:
					return;
				}
				break;
				IL_002e:
				w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
				num = ((int)num2 * -741703447) ^ 0x7B6AEEC;
			}
		}
	}
}
