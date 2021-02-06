using ExaltMultiTool.Proxy.Networking.Packets;

internal class FilePacket : Packet
{
	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public byte[] _0WMjfJphUj6JnIm1ZkD3ScpYc0F;

	public override PacketType pType => PacketType.FILE;

	public override void readPacketData(PacketReader r)
	{
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
		while (true)
		{
			int num = -199922606;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA4F41D9Bu) % 4u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					_0WMjfJphUj6JnIm1ZkD3ScpYc0F = new byte[r.ReadInt32()];
					num = (int)((num2 * 60234481) ^ 0x102BC7F2);
					continue;
				case 0u:
					_0WMjfJphUj6JnIm1ZkD3ScpYc0F = r.ReadBytes(_0WMjfJphUj6JnIm1ZkD3ScpYc0F.Length);
					num = ((int)num2 * -276348520) ^ 0x7BC5FB54;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
		w.Write(_0WMjfJphUj6JnIm1ZkD3ScpYc0F.Length);
		while (true)
		{
			int num = 1285378402;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x41F062FEu) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_003c;
				case 1u:
					return;
				}
				break;
				IL_003c:
				w.Write(_0WMjfJphUj6JnIm1ZkD3ScpYc0F);
				num = ((int)num2 * -1952060053) ^ -666896987;
			}
		}
	}
}
