using ExaltMultiTool.Proxy.Networking.Packets;

internal class TradeDonePacket : Packet
{
	public int _7bgQ9tATPTEeDmObXreEdLoiHz6;

	public string _1xJnApWExAEbirK3iXPXNZCyR4n;

	public override PacketType pType => PacketType.TRADEDONE;

	public override void readPacketData(PacketReader r)
	{
		_7bgQ9tATPTEeDmObXreEdLoiHz6 = r.ReadInt32();
		while (true)
		{
			int num = 1772974006;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6A1DBE9u) % 3u)
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
				_1xJnApWExAEbirK3iXPXNZCyR4n = r.ReadString();
				num = ((int)num2 * -1130453305) ^ -1926248316;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_7bgQ9tATPTEeDmObXreEdLoiHz6);
		w.Write(_1xJnApWExAEbirK3iXPXNZCyR4n);
	}
}
