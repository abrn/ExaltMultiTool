using ExaltMultiTool.Proxy.Networking.Packets;

internal class SetConditionPacket : Packet
{
	public byte _WAdR1yG1bhPVsW0vElMerqQhog;

	public float _YxVQnvbQlewTxxySkKR16jHej6e;

	public override PacketType pType => PacketType.SETCONDITION;

	public override void readPacketData(PacketReader r)
	{
		_WAdR1yG1bhPVsW0vElMerqQhog = r.ReadByte();
		_YxVQnvbQlewTxxySkKR16jHej6e = r.ReadSingle();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WAdR1yG1bhPVsW0vElMerqQhog);
		w.Write(_YxVQnvbQlewTxxySkKR16jHej6e);
	}
}
