using ExaltMultiTool.Proxy.Networking.Packets;

internal class QueueCancelPacket : Packet
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public short _Qh0BQXXjPEcRT8iSpFFQRoYAmun;

	public override PacketType pType => PacketType.UNKNOWNA; // QUEUE_CANCEL

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		_Qh0BQXXjPEcRT8iSpFFQRoYAmun = r.ReadInt16();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		while (true)
		{
			int num = 1058659067;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F40B9F8u) % 3u)
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
				w.Write(_Qh0BQXXjPEcRT8iSpFFQRoYAmun);
				num = (int)((num2 * 210021114) ^ 0x686B83BA);
			}
		}
	}
}
