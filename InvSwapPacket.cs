using ExaltMultiTool.Proxy.Networking.Packets;

internal class InvSwapPacket : Packet
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public WorldPosData _ObXrbtVZcdprxclR2Ggz9jKwlp;

	public SlotObjectData _sEYqjeelWD912mJ6sF5MhQRyISf;

	public SlotObjectData _YnPcTOJB6UrXk2tL1AzY4w0ohpAA;

	public override PacketType pType => PacketType.INVSWAP;

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		_ObXrbtVZcdprxclR2Ggz9jKwlp = new WorldPosData(r);
		while (true)
		{
			int num = -25527131;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE7C04980u) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					_sEYqjeelWD912mJ6sF5MhQRyISf = new SlotObjectData(r);
					num = ((int)num2 * -1569470315) ^ 0x465A5CA7;
					continue;
				case 2u:
					_YnPcTOJB6UrXk2tL1AzY4w0ohpAA = new SlotObjectData(r);
					num = (int)((num2 * 215932601) ^ 0x2DD8CFAD);
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
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		_ObXrbtVZcdprxclR2Ggz9jKwlp.Write(w);
		while (true)
		{
			int num = 1916708976;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3B2DACBFu) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
					_sEYqjeelWD912mJ6sF5MhQRyISf.WriteSlotObjectData(w);
					num = ((int)num2 * -1816390442) ^ -1057768248;
					continue;
				case 1u:
					_YnPcTOJB6UrXk2tL1AzY4w0ohpAA.WriteSlotObjectData(w);
					num = (int)((num2 * 1535798710) ^ 0x6691F213);
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}
}
