using ExaltMultiTool.Proxy.Networking.Packets;

internal class ChangeGuildRankPacket : Packet
{
	public string _Username;

	public int _Rank;

	public override PacketType pType => PacketType.CHANGEGUILDRANK;

	public override void readPacketData(PacketReader r)
	{
		_Username = r.ReadString();
		_Rank = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Username);
		w.Write(_Rank);
	}
}
