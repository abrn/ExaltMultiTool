using ExaltMultiTool.Proxy.Networking.Packets;

internal class _ax4JtQ0EqqnZh9Ml8sG7hZIwpN : Packet
{
	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public string _1xJnApWExAEbirK3iXPXNZCyR4n;

	public int _JEsT6uIdK1eySUKAfntb2FPG6xS;

	public override PacketType pType => PacketType.NOTIFICATION;

	public override void readPacketData(PacketReader r)
	{
		_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
		_1xJnApWExAEbirK3iXPXNZCyR4n = r.ReadString();
		_JEsT6uIdK1eySUKAfntb2FPG6xS = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
		while (true)
		{
			int num = -1044692837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE31569D5u) % 4u)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
					w.Write(_1xJnApWExAEbirK3iXPXNZCyR4n);
					num = ((int)num2 * -636912113) ^ 0x4700156E;
					continue;
				case 1u:
					w.Write(_JEsT6uIdK1eySUKAfntb2FPG6xS);
					num = (int)((num2 * 1382302730) ^ 0x5D821DB7);
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public static _ax4JtQ0EqqnZh9Ml8sG7hZIwpN _KTHh5b7L93SKVJotURbrVApmxrd(int objectId, string message)
	{
		return _KTHh5b7L93SKVJotURbrVApmxrd(objectId, 65535, message);
	}

	public static _ax4JtQ0EqqnZh9Ml8sG7hZIwpN _KTHh5b7L93SKVJotURbrVApmxrd(int objectId, int color, string message)
	{
		_ax4JtQ0EqqnZh9Ml8sG7hZIwpN obj = (_ax4JtQ0EqqnZh9Ml8sG7hZIwpN)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.NOTIFICATION);
		obj._fn2CRnBpjyTWHR9K8SU4iOwhDtK = objectId;
		obj._1xJnApWExAEbirK3iXPXNZCyR4n = "{\"key\":\"server.plus_symbol\",\"tokens\":{\"amount\":\"" + message + "\"}}";
		obj._JEsT6uIdK1eySUKAfntb2FPG6xS = color;
		return obj;
	}
}
