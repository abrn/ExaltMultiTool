using ExaltMultiTool.Proxy.Networking.Packets;

internal class _SroO6BArjwxjDOjHnWzqCAeNSvF : Packet
{
	public bool _PJSppIZJztu4HXLKvqK1ZeiDLym;

	public string _1xJnApWExAEbirK3iXPXNZCyR4n;

	public override PacketType pType => PacketType.QUESTREDEEMRESPONSE;

	public override void readPacketData(PacketReader r)
	{
		_PJSppIZJztu4HXLKvqK1ZeiDLym = r.ReadBoolean();
		while (true)
		{
			int num = 1238542463;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37AEDC12u) % 3u)
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
				_1xJnApWExAEbirK3iXPXNZCyR4n = r.ReadString();
				num = (int)((num2 * 1070509493) ^ 0x4D5199EC);
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_PJSppIZJztu4HXLKvqK1ZeiDLym);
		while (true)
		{
			int num = -1117792727;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3DCDABCu) % 3u)
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
				w.Write(_1xJnApWExAEbirK3iXPXNZCyR4n);
				num = (int)((num2 * 42434458) ^ 0x78CD7FFE);
			}
		}
	}
}
