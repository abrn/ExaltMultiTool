using ExaltMultiTool.Proxy.Networking.Packets;

internal class HatchPetPacket : Packet
{
	public string _SIuNuzYezRZFjanIYSxxmXzAbRg;

	public int _xr9gHUVxYJbMIhCeZpQcnzZaj1F;

	public int _yHzo4xTb5UzqZLQ0cfYFhy0sDUn;

	public override PacketType pType => PacketType.HATCHPET;

	public override void readPacketData(PacketReader r)
	{
		_SIuNuzYezRZFjanIYSxxmXzAbRg = r.ReadString();
		_xr9gHUVxYJbMIhCeZpQcnzZaj1F = r.ReadInt32();
		_yHzo4xTb5UzqZLQ0cfYFhy0sDUn = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_SIuNuzYezRZFjanIYSxxmXzAbRg);
		while (true)
		{
			int num = 353978026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5D2008E6u) % 3u)
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
				w.Write(_xr9gHUVxYJbMIhCeZpQcnzZaj1F);
				w.Write(_yHzo4xTb5UzqZLQ0cfYFhy0sDUn);
				num = ((int)num2 * -492618349) ^ 0x3218CADE;
			}
		}
	}
}
