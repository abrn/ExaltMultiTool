using ExaltMultiTool.Proxy.Networking.Packets;

internal class ReconnectPacket : Packet
{
	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public string _Hostname;

	public int _Port;

	public int _GameId;

	public int _KeyTime;

	public bool _IsFromArena;

	public byte[] _Key;

	public override PacketType pType => PacketType.RECONNECT;

	public override void readPacketData(PacketReader r)
	{
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
		_Hostname = r.ReadString();
		while (true)
		{
			int num = 2059478389;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3BF5EB04u) % 3u)
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
				_Port = r.ReadInt32();
				_GameId = r.ReadInt32();
				_KeyTime = r.ReadInt32();
				_IsFromArena = r.ReadBoolean();
				_Key = r.ReadBytes(r.ReadInt16());
				num = (int)(num2 * 1666187204) ^ -174296439;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
		while (true)
		{
			int num = -1716207121;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9866A50u) % 6u)
				{
				case 5u:
					break;
				case 1u:
					w.Write(_Hostname);
					num = ((int)num2 * -185136301) ^ -1241282276;
					continue;
				case 4u:
					w.Write(_GameId);
					w.Write(_KeyTime);
					w.Write(_IsFromArena);
					num = (int)((num2 * 1886926833) ^ 0x180785B4);
					continue;
				case 0u:
					w.Write((short)_Key.Length);
					num = ((int)num2 * -2112839093) ^ -1797959762;
					continue;
				case 3u:
					w.Write(_Port);
					num = ((int)num2 * -1644936129) ^ 0x57D942C5;
					continue;
				default:
					w.Write(_Key);
					return;
				}
				break;
			}
		}
	}
}
