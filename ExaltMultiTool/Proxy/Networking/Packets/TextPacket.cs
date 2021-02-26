using ExaltMultiTool.Proxy.Networking.Packets;

internal class TextPacket : Packet {
	public string _Name;

	public int _ObjectId;

	public int _NumStars;

	public byte _StarBackground;

	public string _Recipient;

	public string _CleanMessage;

	public string _Message;

	public bool _FromSupporter;

	public int _BubbleTime;

	public override PacketType pType => PacketType.TEXT;

	public override void readPacketData(PacketReader r)
	{
		_Name = r.ReadString();
		_ObjectId = r.ReadInt32();
		_NumStars = r.ReadInt32();
		_StarBackground = r.ReadByte();
		_Recipient = r.ReadString();
		_CleanMessage = r.ReadString();
		_Message = r.ReadString();
		_FromSupporter = r.ReadBoolean();
		_BubbleTime = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Name);
		w.Write(_ObjectId);
		w.Write(_NumStars);
		w.Write(_StarBackground);
		w.Write(_Recipient);
		w.Write(_CleanMessage);
		w.Write(_Message);
		w.Write(_FromSupporter);
		w.Write(_BubbleTime);
	}

	public static TextPacket SendToPlayer(string sender, string message)
	{
		TextPacket obj = (TextPacket) Packet.CreatePacketFromType(PacketType.TEXT);
		obj._StarBackground = 0;
		obj._Message = message;
		obj._Name = (sender.StartsWith("#") ? sender : ("#" + sender));
		obj._NumStars = -1;
		obj._ObjectId = -1;
		obj._Recipient = "";
		obj._CleanMessage = (string.IsNullOrEmpty(sender) ? message : ("<" + sender + "> " + message));
		return obj;
	}

	public static TextPacket SendSystemMessage(string message)
	{
		TextPacket obj = (TextPacket) Packet.CreatePacketFromType(PacketType.TEXT);
		obj._StarBackground = 0;
		obj._Message = message;
		obj._Name = string.Empty;
		obj._NumStars = -1;
		obj._ObjectId = -1;
		obj._Recipient = string.Empty;
		obj._CleanMessage = message;
		return obj;
	}
}