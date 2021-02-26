using ExaltMultiTool.Proxy.Networking.Packets;

internal class ForgeUnlockedBlueprintsPacket : Packet
{
	public byte _UnlockCount;

	public int[] _UnlockedBlueprints;

	public override PacketType pType => PacketType.FORGEUNLOCKEDBLUEPRINTS;

	public override void readPacketData(PacketReader r)
	{
		_UnlockCount = r.ReadByte();
		for (var i = 0; i < _UnlockCount; i++) {
			_UnlockedBlueprints[i] = CompressedInt.Read(r);
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_UnlockCount);
		for (var i = 0; i < _UnlockCount; i++) {
			CompressedInt.Write(w, _UnlockedBlueprints[i]);
		}
	}
}