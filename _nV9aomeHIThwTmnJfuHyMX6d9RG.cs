using ExaltMultiTool.Proxy.Networking.Packets;

internal class _nV9aomeHIThwTmnJfuHyMX6d9RG : Packet
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public SlotObjectData _obJo3i4uC8yf7c2aS8NBvEttXTO;

	public WorldPosData _hik7MnmCWLUNupBgHpKPyvAspMh;

	public byte _if0d81H88w2JolCC4orFfcsIICeA;

	public override PacketType pType => PacketType.USEITEM;

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		_obJo3i4uC8yf7c2aS8NBvEttXTO = new SlotObjectData(r);
		while (true)
		{
			int num = -1839946793;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC2743029u) % 4u)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
					_hik7MnmCWLUNupBgHpKPyvAspMh = new WorldPosData(r);
					num = (int)(num2 * 24728568) ^ -2002421508;
					continue;
				case 1u:
					_if0d81H88w2JolCC4orFfcsIICeA = r.ReadByte();
					num = (int)(num2 * 141963638) ^ -868882997;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		_obJo3i4uC8yf7c2aS8NBvEttXTO.WriteSlotObjectData(w);
		_hik7MnmCWLUNupBgHpKPyvAspMh._3Wc8kZJjhbRt6nttAKwD2698imm(w);
		w.Write(_if0d81H88w2JolCC4orFfcsIICeA);
	}
}
