using ExaltMultiTool.Proxy.Networking.Packets;

internal class ExaltationRedeemPacket : Packet
{
	public short _ObjectId;

	public int _MamaX4JKMQb7mwH8zsj2tH0wBbm;

	public int _enqLoF2wkbykd5HP5ECm7tJoBei;

	public int _9ThOXrA9ODzXg6wTtdBcI6jEfX0;

	public int _adsJ1zavKPklSAlnUA63xUWNzDG;

	public int _nMaG5GTWkDVVngUKjpCbf2dSuQn;

	public int _ixwcW6zy5jkM9OAtEbibDGSG6cL;

	public int _kK89095IOsdVAiJNQMQjlsoUmth;

	public int _aUEd61EwB5eTqpK2iARmc5wOEJN;

	public override PacketType pType => PacketType.EXALTATIONINFORMATION;

	public override void readPacketData(PacketReader r)
	{
		_ObjectId = r.ReadInt16();
		_ixwcW6zy5jkM9OAtEbibDGSG6cL = CompressedInt.Read(r);
		_nMaG5GTWkDVVngUKjpCbf2dSuQn = CompressedInt.Read(r);
		while (true)
		{
			int num = 1825072442;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x513F687u) % 4u)
				{
				case 0u:
					break;
				case 1u:
					_aUEd61EwB5eTqpK2iARmc5wOEJN = CompressedInt.Read(r);
					num = (int)(num2 * 900078649) ^ -2020882148;
					continue;
				case 2u:
					_kK89095IOsdVAiJNQMQjlsoUmth = CompressedInt.Read(r);
					_adsJ1zavKPklSAlnUA63xUWNzDG = CompressedInt.Read(r);
					_9ThOXrA9ODzXg6wTtdBcI6jEfX0 = CompressedInt.Read(r);
					_enqLoF2wkbykd5HP5ECm7tJoBei = CompressedInt.Read(r);
					num = (int)((num2 * 402375307) ^ 0x11516A2E);
					continue;
				default:
					_MamaX4JKMQb7mwH8zsj2tH0wBbm = CompressedInt.Read(r);
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_ObjectId);
		while (true)
		{
			int num = 141828012;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x64D3EE73u) % 6u)
				{
				case 5u:
					break;
				default:
					return;
				case 4u:
					CompressedInt.Write(w, _enqLoF2wkbykd5HP5ECm7tJoBei);
					CompressedInt.Write(w, _MamaX4JKMQb7mwH8zsj2tH0wBbm);
					num = (int)(num2 * 621596617) ^ -2115040405;
					continue;
				case 0u:
					CompressedInt.Write(w, _aUEd61EwB5eTqpK2iARmc5wOEJN);
					CompressedInt.Write(w, _kK89095IOsdVAiJNQMQjlsoUmth);
					CompressedInt.Write(w, _adsJ1zavKPklSAlnUA63xUWNzDG);
					num = ((int)num2 * -1490935030) ^ -877703108;
					continue;
				case 1u:
					CompressedInt.Write(w, _ixwcW6zy5jkM9OAtEbibDGSG6cL);
					CompressedInt.Write(w, _nMaG5GTWkDVVngUKjpCbf2dSuQn);
					num = (int)(num2 * 443834525) ^ -1232921910;
					continue;
				case 3u:
					CompressedInt.Write(w, _9ThOXrA9ODzXg6wTtdBcI6jEfX0);
					num = ((int)num2 * -1682477755) ^ -851266282;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}
}
