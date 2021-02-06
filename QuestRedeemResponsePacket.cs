using ExaltMultiTool.Proxy.Networking.Packets;

internal class QuestRedeemResponsePacket : Packet
{
	public bool _Result;

	public string _Message;

	public override PacketType pType => PacketType.QUESTREDEEMRESPONSE;

	public override void readPacketData(PacketReader r)
	{
		_Result = r.ReadBoolean();
		while (true)
		{
			int num = 1238542463;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x37AEDC12u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002e;
				case 2u:
					return;
				}
				break;
				IL_002e:
				_Message = r.ReadString();
				num = (int)((num2 * 1070509493) ^ 0x4D5199EC);
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Result);
		while (true)
		{
			int num = -1117792727;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC3DCDABCu) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_002e;
				case 0u:
					return;
				}
				break;
				IL_002e:
				w.Write(_Message);
				num = (int)((num2 * 42434458) ^ 0x78CD7FFE);
			}
		}
	}
}
