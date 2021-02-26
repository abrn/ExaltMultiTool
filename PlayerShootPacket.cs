using ExaltMultiTool.Proxy.Networking.Packets;

internal class PlayerShootPacket : Packet {
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public byte _isVjytSCPjaQXfnhSgmbShfAEYC;

	public short _5oFaCQNi71DUAwr2GsRcpozHzAC;

	public WorldPosData _ObXrbtVZcdprxclR2Ggz9jKwlp;

	public float _hjRbCZIgEE6lGZJqDLlpYixCdUT;

	public short _1K9XU0pOHsH3lm9AES9OGdyBWYp;

	public short _pAyGvgNraG4uBolDCqyzfEBMvFg;

	public byte _KETrwnOxl1uhRjelIfp6DpWYYtc;

	public override PacketType pType => PacketType.PLAYERSHOOT;

	public override void readPacketData(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		while (true) {
			int num = -1790622236;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0xCD9E5645u) % 6u) {
					case 3u:
						break;
					default:
						return;
					case 1u:
						_isVjytSCPjaQXfnhSgmbShfAEYC = r.ReadByte();
						_5oFaCQNi71DUAwr2GsRcpozHzAC = r.ReadInt16();
						_ObXrbtVZcdprxclR2Ggz9jKwlp = new WorldPosData(r);
						num = (int) (num2 * 739109896) ^ -1341771371;
						continue;
					case 2u:
						_pAyGvgNraG4uBolDCqyzfEBMvFg = r.ReadInt16();
						num = (int) ((num2 * 1171083854) ^ 0x3CC7F4D8);
						continue;
					case 4u:
						_hjRbCZIgEE6lGZJqDLlpYixCdUT = r.ReadSingle();
						_1K9XU0pOHsH3lm9AES9OGdyBWYp = r.ReadInt16();
						num = ((int) num2 * -501519096) ^ -897048205;
						continue;
					case 5u:
						_KETrwnOxl1uhRjelIfp6DpWYYtc = r.ReadByte();
						num = (int) ((num2 * 261896377) ^ 0x70336650);
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
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		while (true) {
			int num = 584321607;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0x2E567C91u) % 8u) {
					case 4u:
						break;
					default:
						return;
					case 6u:
						w.Write(_isVjytSCPjaQXfnhSgmbShfAEYC);
						num = ((int) num2 * -273560263) ^ 0x6AEB432D;
						continue;
					case 2u:
						w.Write(_5oFaCQNi71DUAwr2GsRcpozHzAC);
						num = ((int) num2 * -320569708) ^ -388892798;
						continue;
					case 1u:
						w.Write(_pAyGvgNraG4uBolDCqyzfEBMvFg);
						w.Write(_KETrwnOxl1uhRjelIfp6DpWYYtc);
						num = (int) (num2 * 642629705) ^ -2116979048;
						continue;
					case 3u:
						_ObXrbtVZcdprxclR2Ggz9jKwlp.Write(w);
						num = (int) ((num2 * 1420179149) ^ 0x20110AF9);
						continue;
					case 7u:
						w.Write(_hjRbCZIgEE6lGZJqDLlpYixCdUT);
						num = ((int) num2 * -33282396) ^ 0xD2A37C0;
						continue;
					case 5u:
						w.Write(_1K9XU0pOHsH3lm9AES9OGdyBWYp);
						num = ((int) num2 * -523260751) ^ 0x47C9BEAD;
						continue;
					case 0u:
						return;
				}

				break;
			}
		}
	}
}