using ExaltMultiTool.Proxy.Networking.Packets;

internal class NewCharacterInfoPacket : Packet
{
	public string _s17ONVNls0UApcVs4zcregsvhfG;

	public override PacketType pType => PacketType.NEWCHARACTERINFORMATION;

	public override void readPacketData(PacketReader r)
	{
		_s17ONVNls0UApcVs4zcregsvhfG = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_s17ONVNls0UApcVs4zcregsvhfG);
	}
}
