using ExaltMultiTool.Proxy.Networking.Packets;

internal class _DJYMvdNvmgERnWgfcUW8wYZDzjE : Packet
{
	public bool _PJSppIZJztu4HXLKvqK1ZeiDLym;

	public string _YQHu6PgPYmZlbS8T6Pv7Vtj9Ktc;

	public override PacketType pType => PacketType.GUILDRESULT;

	public override void readPacketData(PacketReader r)
	{
		_PJSppIZJztu4HXLKvqK1ZeiDLym = r.ReadBoolean();
		_YQHu6PgPYmZlbS8T6Pv7Vtj9Ktc = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_PJSppIZJztu4HXLKvqK1ZeiDLym);
		while (true)
		{
			int num = 1397994490;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE920011u) % 3u)
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
				w.Write(_YQHu6PgPYmZlbS8T6Pv7Vtj9Ktc);
				num = ((int)num2 * -1582084390) ^ 0x4EC1E2C2;
			}
		}
	}
}
