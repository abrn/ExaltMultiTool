using ExaltMultiTool.Proxy.Networking.Packets;

internal class _rAh5rrqlwXwT1pemuFWMDZJJxvD : Packet
{
	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public string _w1TqG1hi8zKpLFbdlocr31ecHCC;

	public override PacketType pType => PacketType.INVITEDTOGUILD;

	public override void readPacketData(PacketReader r)
	{
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
		_w1TqG1hi8zKpLFbdlocr31ecHCC = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
		while (true)
		{
			int num = -326696894;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6D76E4Cu) % 3u)
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
				w.Write(_w1TqG1hi8zKpLFbdlocr31ecHCC);
				num = (int)(num2 * 1614108089) ^ -991383972;
			}
		}
	}
}
