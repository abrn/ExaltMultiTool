using ExaltMultiTool.Proxy.Networking.Packets;

internal class QuestRedeemResponsePacket : Packet {
	public bool _Result;

	public string _Message;

	public override PacketType pType => PacketType.QUESTREDEEMRESPONSE;

	public override void readPacketData(PacketReader r)
	{
		_Result = r.ReadBoolean();
		_Message = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Result);
		w.Write(_Message);
	}
}