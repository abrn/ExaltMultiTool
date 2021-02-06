using ExaltMultiTool.Proxy.Networking.Packets;

internal class _hGYadtqaPivfBQqN2hayNDq4l5db : Packet
{
	public int _y7cs4TXR4NM2vDkB34Q4hVWm55k;

	public int _JnhhrD6KN8GbKRpobDBqW7TZR0u;

	public int _SCka8D1BswTyjGHn4E0eb2PZbNA;

	public override PacketType pType => PacketType.LOGINREWARDMSG;

	public override void readPacketData(PacketReader r)
	{
		_y7cs4TXR4NM2vDkB34Q4hVWm55k = r.ReadInt32();
		while (true)
		{
			int num = -2974041;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF0E9584Cu) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					_JnhhrD6KN8GbKRpobDBqW7TZR0u = r.ReadInt32();
					num = (int)((num2 * 1937240750) ^ 0x62C173CF);
					continue;
				case 1u:
					_SCka8D1BswTyjGHn4E0eb2PZbNA = r.ReadInt32();
					num = ((int)num2 * -816606119) ^ 0x55794DC7;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_y7cs4TXR4NM2vDkB34Q4hVWm55k);
		w.Write(_JnhhrD6KN8GbKRpobDBqW7TZR0u);
		w.Write(_SCka8D1BswTyjGHn4E0eb2PZbNA);
	}
}
