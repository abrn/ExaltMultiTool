using ExaltMultiTool.Proxy.Networking.Packets;

internal class _2N1xBR044hjFvSdWQy3V7k3jwmC : Packet
{
	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public WorldPosData _hZZqGJ97TiaLFTbiTFhvTTSGkIb;

	public override PacketType pType => PacketType.GOTO;

	public override void readPacketData(PacketReader r)
	{
		_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
		_hZZqGJ97TiaLFTbiTFhvTTSGkIb = new WorldPosData(r);
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
		while (true)
		{
			int num = 1260222660;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3FBE3A9Fu) % 3u)
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
				_hZZqGJ97TiaLFTbiTFhvTTSGkIb.Write(w);
				num = (int)((num2 * 726652732) ^ 0x25C575DE);
			}
		}
	}
}
