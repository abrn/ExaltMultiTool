using ExaltMultiTool.Proxy.Networking.Packets;

internal class InvResultPacket : Packet
{
	public bool _7bgQ9tATPTEeDmObXreEdLoiHz6;

	public SlotObjectData _sEYqjeelWD912mJ6sF5MhQRyISf;

	public SlotObjectData _YnPcTOJB6UrXk2tL1AzY4w0ohpAA;

	public override PacketType pType => PacketType.INVRESULT;

	public override void readPacketData(PacketReader r)
	{
		_7bgQ9tATPTEeDmObXreEdLoiHz6 = r.ReadBoolean();
		_sEYqjeelWD912mJ6sF5MhQRyISf = new SlotObjectData(r);
		while (true)
		{
			int num = 1641534664;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C50C298u) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_003a;
				case 0u:
					return;
				}
				break;
				IL_003a:
				_YnPcTOJB6UrXk2tL1AzY4w0ohpAA = new SlotObjectData(r);
				num = (int)(num2 * 1045608898) ^ -2023441846;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_7bgQ9tATPTEeDmObXreEdLoiHz6);
		_sEYqjeelWD912mJ6sF5MhQRyISf.WriteSlotObjectData(w);
		_YnPcTOJB6UrXk2tL1AzY4w0ohpAA.WriteSlotObjectData(w);
	}
}
