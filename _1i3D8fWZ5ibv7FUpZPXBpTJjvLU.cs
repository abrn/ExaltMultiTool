using ExaltMultiTool.Proxy.Networking.Packets;

internal class _1i3D8fWZ5ibv7FUpZPXBpTJjvLU : Packet
{
	public int _zixvLErVfFSOotGb0UyDKkfNvIu;

	public string _ZaKxnVNRWP2P7B6HMmkG6GPTmLC;

	public string _KOWNDNzUE5rabyhZldRZxfnZg6E;

	public string _1WeNs4yAo8xdNRaT8aJiJ81Srzi;

	public override PacketType pType => PacketType.FAILURE;

	public override void readPacketData(PacketReader r)
	{
		_zixvLErVfFSOotGb0UyDKkfNvIu = r.ReadInt32();
		_ZaKxnVNRWP2P7B6HMmkG6GPTmLC = r.ReadString();
		while (true)
		{
			int num = -341922627;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC36A15A5u) % 3u)
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
				_KOWNDNzUE5rabyhZldRZxfnZg6E = r.ReadString();
				_1WeNs4yAo8xdNRaT8aJiJ81Srzi = r.ReadString();
				num = ((int)num2 * -832543119) ^ -1264455995;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_zixvLErVfFSOotGb0UyDKkfNvIu);
		w.Write(_ZaKxnVNRWP2P7B6HMmkG6GPTmLC);
		w.Write(_KOWNDNzUE5rabyhZldRZxfnZg6E);
		w.Write(_1WeNs4yAo8xdNRaT8aJiJ81Srzi);
	}
}
