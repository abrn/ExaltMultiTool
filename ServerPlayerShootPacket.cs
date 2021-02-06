using ExaltMultiTool.Proxy.Networking.Packets;

internal class ServerPlayerShootPacket : Packet
{
	public byte _isVjytSCPjaQXfnhSgmbShfAEYC;

	public int _qL8Qk0RJEu4lcCGcJpKfz1Fn8tb;

	public int _5oFaCQNi71DUAwr2GsRcpozHzAC;

	public WorldPosData _StartPosition;

	public float _hjRbCZIgEE6lGZJqDLlpYixCdUT;

	public short _C3mvDTxTLKOCwcaeO4BKeVV1ydo;

	public override PacketType pType => PacketType.SERVERPLAYERSHOOT;

	public override void readPacketData(PacketReader r)
	{
		_isVjytSCPjaQXfnhSgmbShfAEYC = r.ReadByte();
		while (true)
		{
			int num = 572124549;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67F2698Cu) % 6u)
				{
				case 5u:
					break;
				default:
					return;
				case 3u:
					_hjRbCZIgEE6lGZJqDLlpYixCdUT = r.ReadSingle();
					num = ((int)num2 * -729938459) ^ -452685311;
					continue;
				case 4u:
					_StartPosition = new WorldPosData(r);
					num = ((int)num2 * -253987375) ^ 0x1040E77B;
					continue;
				case 1u:
					_qL8Qk0RJEu4lcCGcJpKfz1Fn8tb = r.ReadInt32();
					_5oFaCQNi71DUAwr2GsRcpozHzAC = r.ReadInt32();
					num = ((int)num2 * -1124507529) ^ -1896697499;
					continue;
				case 2u:
					_C3mvDTxTLKOCwcaeO4BKeVV1ydo = r.ReadInt16();
					num = ((int)num2 * -1220768311) ^ -478873242;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_isVjytSCPjaQXfnhSgmbShfAEYC);
		while (true)
		{
			int num = 256597923;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x56D05277u) % 3u)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002e;
				default:
					w.Write(_5oFaCQNi71DUAwr2GsRcpozHzAC);
					_StartPosition.Write(w);
					w.Write(_hjRbCZIgEE6lGZJqDLlpYixCdUT);
					w.Write(_C3mvDTxTLKOCwcaeO4BKeVV1ydo);
					return;
				}
				break;
				IL_002e:
				w.Write(_qL8Qk0RJEu4lcCGcJpKfz1Fn8tb);
				num = (int)(num2 * 820731604) ^ -332202799;
			}
		}
	}
}
