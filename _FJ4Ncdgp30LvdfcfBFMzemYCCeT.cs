using ExaltMultiTool.Proxy.Networking.Packets;

internal class _FJ4Ncdgp30LvdfcfBFMzemYCCeT : Packet
{
	public WorldPosData _hZZqGJ97TiaLFTbiTFhvTTSGkIb;

	public float _I9LOulXQ6dWoDQOn1L5GkchnJUC;

	public ushort _C3mvDTxTLKOCwcaeO4BKeVV1ydo;

	public _PUpefZ8WOU2tKcPbBOBoE74Yj5m _kvTyEminxJMM6fREzgqsVjHaInC;

	public float _4ryHqycpd0BcdbojLHcVLB3vF4Z;

	public ushort _Rgo6h5q8HOGdwEcalhyNY8ouOAE;

	public int _JEsT6uIdK1eySUKAfntb2FPG6xS;

	public bool _l0mdLwT0Lqvn0oV26TZ8wa7mjTf;

	public override PacketType pType => PacketType.AOE;

	public override void readPacketData(PacketReader r)
	{
		_hZZqGJ97TiaLFTbiTFhvTTSGkIb = new WorldPosData(r);
		while (true)
		{
			int num = -1874733940;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF6F27B48u) % 7u)
				{
				case 0u:
					break;
				default:
					return;
				case 5u:
					_I9LOulXQ6dWoDQOn1L5GkchnJUC = r.ReadSingle();
					_C3mvDTxTLKOCwcaeO4BKeVV1ydo = r.ReadUInt16();
					num = ((int)num2 * -1167073322) ^ 0x4F5527F3;
					continue;
				case 4u:
					_l0mdLwT0Lqvn0oV26TZ8wa7mjTf = r.ReadBoolean();
					num = ((int)num2 * -462229276) ^ 0x5A2C3CFB;
					continue;
				case 2u:
					_Rgo6h5q8HOGdwEcalhyNY8ouOAE = r.ReadUInt16();
					num = ((int)num2 * -1541488491) ^ -1790075071;
					continue;
				case 1u:
					_JEsT6uIdK1eySUKAfntb2FPG6xS = r.ReadInt32();
					num = (int)((num2 * 610912363) ^ 0x250567CF);
					continue;
				case 3u:
					_kvTyEminxJMM6fREzgqsVjHaInC = (_PUpefZ8WOU2tKcPbBOBoE74Yj5m)r.ReadByte();
					_4ryHqycpd0BcdbojLHcVLB3vF4Z = r.ReadSingle();
					num = ((int)num2 * -1923755977) ^ -778616339;
					continue;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		_hZZqGJ97TiaLFTbiTFhvTTSGkIb.Write(w);
		w.Write(_I9LOulXQ6dWoDQOn1L5GkchnJUC);
		while (true)
		{
			int num = -1086730584;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x953BE2D4u) % 6u)
				{
				case 5u:
					break;
				default:
					return;
				case 2u:
					w.Write(_C3mvDTxTLKOCwcaeO4BKeVV1ydo);
					w.Write((byte)_kvTyEminxJMM6fREzgqsVjHaInC);
					w.Write(_4ryHqycpd0BcdbojLHcVLB3vF4Z);
					num = (int)((num2 * 256438984) ^ 0x5B7A8083);
					continue;
				case 1u:
					w.Write(_JEsT6uIdK1eySUKAfntb2FPG6xS);
					num = ((int)num2 * -980257480) ^ 0x4A03A550;
					continue;
				case 3u:
					w.Write(_Rgo6h5q8HOGdwEcalhyNY8ouOAE);
					num = (int)(num2 * 162810919) ^ -1553958314;
					continue;
				case 4u:
					w.Write(_l0mdLwT0Lqvn0oV26TZ8wa7mjTf);
					num = ((int)num2 * -1353870095) ^ -340254494;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}
}
