using ExaltMultiTool.Proxy.Networking.Packets;

internal class BuyPacket : Packet
{
	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public int _JnhhrD6KN8GbKRpobDBqW7TZR0u;

	public override PacketType pType => PacketType.BUY;

	public override void readPacketData(PacketReader r)
	{
		_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
		while (true)
		{
			int num = 1751893371;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1CAC084u) % 3u)
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
				_JnhhrD6KN8GbKRpobDBqW7TZR0u = r.ReadInt32();
				num = (int)(num2 * 137572925) ^ -1639990477;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
		w.Write(_JnhhrD6KN8GbKRpobDBqW7TZR0u);
	}
}
