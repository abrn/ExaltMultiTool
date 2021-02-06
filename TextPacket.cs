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


		while (true) {
			int num = 364811841;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0x67912990u) % 7u) {
					case 0u:
						break;
					default:
						return;
					case 4u:
						_Recipient = r.ReadString();
						_CleanMessage = r.ReadString();
						num = (int) ((num2 * 1546735298) ^ 0x1FF173);
						continue;
					case 2u:
						_BubbleTime = r.ReadInt32();
						num = (int) ((num2 * 101038557) ^ 0x318F4947);
						continue;
					case 1u:
						_Message = r.ReadString();
						_FromSupporter = r.ReadBoolean();
						num = ((int) num2 * -2097026475) ^ -493552127;
						continue;
					case 5u:

						num = ((int) num2 * -736259367) ^ -1606620075;
						continue;
					case 6u:
						_StarBackground = r.ReadByte();
						num = ((int) num2 * -1933059090) ^ -102478244;
						continue;
					case 3u:
						return;
				}

				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Name);
		w.Write(_ObjectId);
		w.Write(_NumStars);
		while (true) {
			int num = -817637188;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0xC376B8B3u) % 6u) {
					case 3u:
						break;
					default:
						return;
					case 0u:
						w.Write(_BubbleTime);
						num = (int) (num2 * 1770425168) ^ -1711777732;
						continue;
					case 4u:
						w.Write(_CleanMessage);
						w.Write(_Message);
						w.Write(_FromSupporter);
						num = ((int) num2 * -1064221428) ^ 0x321D4105;
						continue;
					case 2u:
						w.Write(_Recipient);
						num = ((int) num2 * -2018308361) ^ 0x73315D23;
						continue;
					case 5u:
						w.Write(_StarBackground);
						num = (int) (num2 * 836863151) ^ -1369516394;
						continue;
					case 1u:
						return;
				}

				break;
			}
		}
	}

	public static TextPacket SendToPlayer(string sender, string message)
	{
		TextPacket obj = (TextPacket) Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.TEXT);
		obj._StarBackground = 0;
		obj._Message = message;
		obj._Name = (sender.StartsWith("#") ? sender : ("#" + sender));
		obj._NumStars = -1;
		obj._ObjectId = -1;
		obj._Recipient = "";
		obj._CleanMessage = (string.IsNullOrEmpty(sender) ? message : ("<" + sender + "> " + message));
		return obj;
	}

	public static TextPacket _AXNXHsenc7q4bGIXtJncJXAdxxW(string message)
	{
		TextPacket obj = (TextPacket) Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.TEXT);
		obj._StarBackground = 0;
		obj._Message = message;
		obj._Name = string.Empty;
		obj._NumStars = -1;
		obj._ObjectId = -1;
		obj._Recipient = string.Empty;
		obj._CleanMessage = message;
		return obj;
	}

	public static TextPacket _cuj5TuKzQrJc4m81deq6Jyw3r0H(string name, string message)
	{
		TextPacket obj = (TextPacket) Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.TEXT);
		obj._StarBackground = 0;
		obj._Message = message;
		obj._Name = name;
		obj._NumStars = -1;
		obj._ObjectId = -1;
		obj._Recipient = string.Empty;
		obj._CleanMessage = message;
		return obj;
	}
}