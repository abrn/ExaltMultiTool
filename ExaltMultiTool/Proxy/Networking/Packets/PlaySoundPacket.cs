using ExaltMultiTool.Proxy.Networking.Packets;

internal class PlaySoundPacket : Packet {
	public int _OwnerId;

	public int _SoundId;

	public override PacketType pType => PacketType.PLAYSOUND;

	public override void readPacketData(PacketReader r)
	{
		_OwnerId = r.ReadInt32();
		_SoundId = r.ReadByte();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_OwnerId);
		w.Write((byte) _SoundId);
	}
}