using ExaltMultiTool.Proxy.Networking.Packets;

internal class _YP0dYf5sleBQNEpTWbuTXU3cgl0 : Packet
{
	public int _NCFoCgVlw4f1I6p7NaxlcKmqRZD;

	public bool _UhmQhgJbHmzkOAp7eqNlTZqWAY1;

	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public override PacketType pType => PacketType.EDITACCOUNTLIST;

	public override void readPacketData(PacketReader r)
	{
		_NCFoCgVlw4f1I6p7NaxlcKmqRZD = r.ReadInt32();
		_UhmQhgJbHmzkOAp7eqNlTZqWAY1 = r.ReadBoolean();
		_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_NCFoCgVlw4f1I6p7NaxlcKmqRZD);
		while (true)
		{
			int num = -692581853;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC25B6B1Du) % 3u)
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
				w.Write(_UhmQhgJbHmzkOAp7eqNlTZqWAY1);
				w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
				num = (int)(num2 * 843858073) ^ -1779827200;
			}
		}
	}
}
