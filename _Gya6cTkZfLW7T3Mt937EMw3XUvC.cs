using ExaltMultiTool.Proxy.Networking.Packets;

internal class _Gya6cTkZfLW7T3Mt937EMw3XUvC : Packet
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public WorldPosData _ObXrbtVZcdprxclR2Ggz9jKwlp;

	public override PacketType pType => PacketType.AOEACK;

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		while (true)
		{
			int num = -771640784;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBBD33FC4u) % 3u)
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
				_ObXrbtVZcdprxclR2Ggz9jKwlp = new WorldPosData(r);
				num = (int)((num2 * 515334107) ^ 0x792BC73B);
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		_ObXrbtVZcdprxclR2Ggz9jKwlp.Write(w);
	}
}
