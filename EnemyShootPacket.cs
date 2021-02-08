using ExaltMultiTool.Proxy.Networking.Packets;

internal class EnemyShootPacket : Packet
{
	public byte _isVjytSCPjaQXfnhSgmbShfAEYC;

	public int _qL8Qk0RJEu4lcCGcJpKfz1Fn8tb;

	public byte _XkoPVTLGPjjI2mDSH9xlH0vbBOe;

	public WorldPosData _hZZqGJ97TiaLFTbiTFhvTTSGkIb;

	public float _hjRbCZIgEE6lGZJqDLlpYixCdUT;

	public short _C3mvDTxTLKOCwcaeO4BKeVV1ydo;

	public byte _wQ07ok3AId78vEC0Lsubhb1cWYS;

	public float _N4vByLWf2vYahbCTJLzB54nzBwt;

	public override PacketType pType => PacketType.ENEMYSHOOT;

	public override void readPacketData(PacketReader r)
	{
		//Discarded unreachable code: IL_00de
		_isVjytSCPjaQXfnhSgmbShfAEYC = r.ReadByte();
		while (true)
		{
			int num = -1219967054;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x80DFE17Du) % 10u)
				{
				case 9u:
					break;
				case 0u:
					_N4vByLWf2vYahbCTJLzB54nzBwt = r.ReadSingle();
					num = ((int)num2 * -1551670473) ^ 0x60FD50ED;
					continue;
				case 3u:
					_wQ07ok3AId78vEC0Lsubhb1cWYS = 1;
					num = -325889187;
					continue;
				case 1u:
					_qL8Qk0RJEu4lcCGcJpKfz1Fn8tb = r.ReadInt32();
					_XkoPVTLGPjjI2mDSH9xlH0vbBOe = r.ReadByte();
					num = ((int)num2 * -923264740) ^ -143795482;
					continue;
				case 5u:
					_hZZqGJ97TiaLFTbiTFhvTTSGkIb = new WorldPosData(r);
					num = ((int)num2 * -2084748929) ^ -425792433;
					continue;
				case 2u:
					_wQ07ok3AId78vEC0Lsubhb1cWYS = r.ReadByte();
					num = (int)(num2 * 1974321692) ^ -315187693;
					continue;
				case 8u:
					return;
				case 7u:
					_hjRbCZIgEE6lGZJqDLlpYixCdUT = r.ReadSingle();
					_C3mvDTxTLKOCwcaeO4BKeVV1ydo = r.ReadInt16();
					num = ((int)num2 * -104699378) ^ -1146602393;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if (r.BaseStream.Position < r.BaseStream.Length)
					{
						num3 = -310398639;
						num4 = num3;
					}
					else
					{
						num3 = -1253619800;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 199129477);
					continue;
				}
				default:
					_N4vByLWf2vYahbCTJLzB54nzBwt = 0f;
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
			int num = -789238233;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF6456CBu) % 9u)
				{
				case 6u:
					break;
				default:
					return;
				case 2u:
					w.Write(_N4vByLWf2vYahbCTJLzB54nzBwt);
					num = (int)(num2 * 382806897) ^ -963859607;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (_wQ07ok3AId78vEC0Lsubhb1cWYS == 1)
					{
						num3 = 1848529561;
						num4 = num3;
					}
					else
					{
						num3 = 1512859616;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 61551273);
					continue;
				}
				case 1u:
					w.Write(_XkoPVTLGPjjI2mDSH9xlH0vbBOe);
					_hZZqGJ97TiaLFTbiTFhvTTSGkIb.Write(w);
					num = (int)(num2 * 193273343) ^ -776366404;
					continue;
				case 4u:
					w.Write(_wQ07ok3AId78vEC0Lsubhb1cWYS);
					num = (int)((num2 * 746280829) ^ 0x3615BBC4);
					continue;
				case 0u:
					w.Write(_hjRbCZIgEE6lGZJqDLlpYixCdUT);
					num = (int)((num2 * 2235815) ^ 0x4CB5EB1);
					continue;
				case 5u:
					w.Write(_C3mvDTxTLKOCwcaeO4BKeVV1ydo);
					num = (int)((num2 * 212173970) ^ 0x698AC84B);
					continue;
				case 7u:
					w.Write(_qL8Qk0RJEu4lcCGcJpKfz1Fn8tb);
					num = (int)((num2 * 602233466) ^ 0x95FFD73);
					continue;
				case 8u:
					return;
				}
				break;
			}
		}
	}
}
