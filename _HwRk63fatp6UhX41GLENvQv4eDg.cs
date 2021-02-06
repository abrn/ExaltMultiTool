using ExaltMultiTool.Proxy.Networking.Packets;

internal class _HwRk63fatp6UhX41GLENvQv4eDg : Packet
{
	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public int _IviHfWXXb2hAeeAcf2nbh2a7Zo;

	public string _M5JWfqz5mAzF5l7Bqm9i9bP3XCh;

	public override PacketType pType => PacketType.CREATESUCCESS;

	public override void readPacketData(PacketReader r)
	{
		_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
		_IviHfWXXb2hAeeAcf2nbh2a7Zo = r.ReadInt32();
		while (true)
		{
			int num = -459236451;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x90E3A8C3u) % 3u)
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
				_M5JWfqz5mAzF5l7Bqm9i9bP3XCh = r.ReadString();
				num = (int)((num2 * 1429809871) ^ 0x2E2393A);
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
		w.Write(_IviHfWXXb2hAeeAcf2nbh2a7Zo);
		while (true)
		{
			int num = 2076434401;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x73F3F7E4u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_003a;
				case 1u:
					return;
				}
				break;
				IL_003a:
				w.Write(_M5JWfqz5mAzF5l7Bqm9i9bP3XCh);
				num = (int)((num2 * 535921202) ^ 0x56A66F55);
			}
		}
	}
}
