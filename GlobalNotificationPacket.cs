using ExaltMultiTool.Proxy.Networking.Packets;

internal class GlobalNotificationPacket : Packet
{
	public int _Time;

	public string _Message;

	public override PacketType pType => PacketType.GLOBALNOTIFICATION;

	public override void readPacketData(PacketReader r)
	{
		_Time = r.ReadInt32();
		_Message = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Time);
		w.Write(_Message);
	}
}
