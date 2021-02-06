using ExaltMultiTool.Proxy.Networking.Packets;

internal class _3UhdqvdbZ0ParS6o6piDivI6gFl : Packet
{
	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public int _YRroKjuptZsglvSk5lNddIuLAUG;

	public override PacketType pType => PacketType.CLIENTSTAT;

	public override void readPacketData(PacketReader r)
	{
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
		while (true)
		{
			int num = 1475050179;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xDDCA26Au) % 3u)
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
				_YRroKjuptZsglvSk5lNddIuLAUG = r.ReadInt32();
				num = ((int)num2 * -791248380) ^ 0x2580490C;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
		w.Write(_YRroKjuptZsglvSk5lNddIuLAUG);
	}
}
