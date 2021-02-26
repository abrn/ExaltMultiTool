internal class _Jb0feCILTkEl6pcg2T1V15k3pU9
{
	public readonly WorldPosData _hZZqGJ97TiaLFTbiTFhvTTSGkIb;

	public readonly ushort _C3mvDTxTLKOCwcaeO4BKeVV1ydo;

	public readonly ushort _Rgo6h5q8HOGdwEcalhyNY8ouOAE;

	public readonly float _I9LOulXQ6dWoDQOn1L5GkchnJUC;

	public readonly bool _l0mdLwT0Lqvn0oV26TZ8wa7mjTf;

	public _Jb0feCILTkEl6pcg2T1V15k3pU9(AoEPacket aoe)
	{
		while (true)
		{
			int num = -2082444439;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC2540B31u) % 5u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					_I9LOulXQ6dWoDQOn1L5GkchnJUC = aoe._Radius;
					_l0mdLwT0Lqvn0oV26TZ8wa7mjTf = aoe._ArmorBreaking;
					num = ((int)num2 * -243770936) ^ 0x3A92E4BF;
					continue;
				case 3u:
					_Rgo6h5q8HOGdwEcalhyNY8ouOAE = aoe._OriginalType;
					num = ((int)num2 * -2064468243) ^ 0x2E0F76DB;
					continue;
				case 4u:
					_hZZqGJ97TiaLFTbiTFhvTTSGkIb = aoe._Position;
					_C3mvDTxTLKOCwcaeO4BKeVV1ydo = aoe._Damage;
					num = (int)(num2 * 1659428364) ^ -390479236;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
