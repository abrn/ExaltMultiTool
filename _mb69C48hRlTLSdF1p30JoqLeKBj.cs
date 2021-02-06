using ExaltMultiTool.Proxy.Networking.Packets;

internal class _mb69C48hRlTLSdF1p30JoqLeKBj : Packet
{
	public byte _isVjytSCPjaQXfnhSgmbShfAEYC;

	public int _qL8Qk0RJEu4lcCGcJpKfz1Fn8tb;

	public short _5oFaCQNi71DUAwr2GsRcpozHzAC;

	public float _hjRbCZIgEE6lGZJqDLlpYixCdUT;

	public bool _qMqVnMigWX1zRmCpC2cyz3VHSpB;

	public override PacketType pType => PacketType.ALLYSHOOT;

	public override void readPacketData(PacketReader r)
	{
		_isVjytSCPjaQXfnhSgmbShfAEYC = r.ReadByte();
		while (true)
		{
			int num = -1612257253;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE0249B12u) % 3u)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002e;
				default:
					_qMqVnMigWX1zRmCpC2cyz3VHSpB = r.ReadBoolean();
					return;
				}
				break;
				IL_002e:
				_qL8Qk0RJEu4lcCGcJpKfz1Fn8tb = r.ReadInt32();
				_5oFaCQNi71DUAwr2GsRcpozHzAC = r.ReadInt16();
				_hjRbCZIgEE6lGZJqDLlpYixCdUT = r.ReadSingle();
				num = ((int)num2 * -1900013277) ^ 0x4DBAD095;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_isVjytSCPjaQXfnhSgmbShfAEYC);
		w.Write(_qL8Qk0RJEu4lcCGcJpKfz1Fn8tb);
		while (true)
		{
			int num = -1299415180;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF9CF5709u) % 3u)
				{
				case 2u:
					break;
				case 1u:
					goto IL_003a;
				default:
					w.Write(_hjRbCZIgEE6lGZJqDLlpYixCdUT);
					w.Write(_qMqVnMigWX1zRmCpC2cyz3VHSpB);
					return;
				}
				break;
				IL_003a:
				w.Write(_5oFaCQNi71DUAwr2GsRcpozHzAC);
				num = (int)(num2 * 789352386) ^ -156671825;
			}
		}
	}
}
