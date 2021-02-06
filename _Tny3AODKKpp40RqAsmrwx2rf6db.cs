using ExaltMultiTool.Proxy.Networking.Packets;

internal class _Tny3AODKKpp40RqAsmrwx2rf6db : Packet
{
	public int _tjbHiRznBpNOVIqL5wnfaZ7vOZB;

	public int _j524zDqCUdRNQvDXzCfWQeIJSoP;

	public int _6ave9qA4L2ZKlEsYjdcw0DPbw5i;

	public override PacketType pType => PacketType.EVOLVEPET;

	public override void readPacketData(PacketReader r)
	{
		_tjbHiRznBpNOVIqL5wnfaZ7vOZB = r.ReadInt32();
		while (true)
		{
			int num = -170310094;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBAA55D14u) % 3u)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002e;
				default:
					_6ave9qA4L2ZKlEsYjdcw0DPbw5i = r.ReadInt32();
					return;
				}
				break;
				IL_002e:
				_j524zDqCUdRNQvDXzCfWQeIJSoP = r.ReadInt32();
				num = ((int)num2 * -1659119770) ^ -1454989732;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_tjbHiRznBpNOVIqL5wnfaZ7vOZB);
		w.Write(_j524zDqCUdRNQvDXzCfWQeIJSoP);
		w.Write(_6ave9qA4L2ZKlEsYjdcw0DPbw5i);
	}
}
