using ExaltMultiTool.Proxy.Networking.Packets;

internal class PetChangeFormPacket : Packet {
	public int _tjbHiRznBpNOVIqL5wnfaZ7vOZB;

	public int _70G5LaqIOoEvlgmBXWdgMBSJuMT;

	public SlotObjectData _pPnXctzJayWPUUCyEk8VAuhuFpD;

	public override PacketType pType => PacketType.PETCHANGEFORMMSG;

	public override void readPacketData(PacketReader r)
	{
		_tjbHiRznBpNOVIqL5wnfaZ7vOZB = r.ReadInt32();
		_70G5LaqIOoEvlgmBXWdgMBSJuMT = r.ReadInt32();
		_pPnXctzJayWPUUCyEk8VAuhuFpD = new SlotObjectData(r);
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_tjbHiRznBpNOVIqL5wnfaZ7vOZB);
		w.Write(_70G5LaqIOoEvlgmBXWdgMBSJuMT);
		_pPnXctzJayWPUUCyEk8VAuhuFpD.WriteSlotObjectData(w);
	}
}