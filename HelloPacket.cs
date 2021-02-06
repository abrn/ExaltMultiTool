using ExaltMultiTool.Proxy.Networking.Packets;

internal class HelloPacket : Packet
{
	public string _GfmkzrVWAfImTFxA9RJnJTXkb3k;

	public int _mohOnMj4BzApB71G6voSGWkazsN;

	public string _vw1iZ0g0gM2Jnv67ofhKq2lPYyC;

	public int _2YR8l930hg89G6B65rxYZ6rWUJB;

	public string _6ndefRdmjz9ThJdbUMMsQkovdUe;

	public int _WDZU3bp76s5FXEoq4PwbL0MocF;

	public string _hdTOEZsuxAH0ZBDRBk75KYH82ze;

	public int _TsKPJcEcXXpSwuINY9rvCt7eSxg;

	public byte[] _caEPyMhZIywru545koF9xeYmUrA;

	public string _NHpfzqUT66vabPP826CZeNFwcHC;

	public string _ig6wccaJwxykSCxVe6rxiJVe7Uf;

	public string _XIWmR5lk02foPUtYWF2JL1Zanoo;

	public string _Q4xAoSUBuQ2wwQnAwJv7UyaqJ0fA;

	public string _2x96AsjHsGUoY0Hf6NIYgjPUrgN;

	public string _qaFjfbsRbarhCYDjEuQqvi8idoV;

	public string _NYFe8vPwL8kTGXvLVmBCbryvlDP;

	public string _UK96J1x6VT6MW3hocR4mGIRfkdg;

	public string _aaNefOWGYHcKzKuoxz8aTrAOPEfA;

	public override PacketType pType => PacketType.HELLO;

	public override void readPacketData(PacketReader r)
	{
		_GfmkzrVWAfImTFxA9RJnJTXkb3k = r.ReadString();
		while (true)
		{
			int num = -726164396;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD64C3293u) % 12u)
				{
				case 5u:
					break;
				default:
					return;
				case 4u:
					_NHpfzqUT66vabPP826CZeNFwcHC = r.ReadUTF8String();
					_ig6wccaJwxykSCxVe6rxiJVe7Uf = r.ReadString();
					_XIWmR5lk02foPUtYWF2JL1Zanoo = r.ReadString();
					_Q4xAoSUBuQ2wwQnAwJv7UyaqJ0fA = r.ReadString();
					num = (int)(num2 * 1503366975) ^ -1572445734;
					continue;
				case 9u:
					_2x96AsjHsGUoY0Hf6NIYgjPUrgN = r.ReadString();
					num = ((int)num2 * -821844095) ^ -598372232;
					continue;
				case 1u:
					_aaNefOWGYHcKzKuoxz8aTrAOPEfA = r.ReadString();
					num = (int)(num2 * 319463378) ^ -90341370;
					continue;
				case 7u:
					_TsKPJcEcXXpSwuINY9rvCt7eSxg = r.ReadInt32();
					_caEPyMhZIywru545koF9xeYmUrA = r.ReadBytes(r.ReadInt16());
					num = ((int)num2 * -1071461171) ^ 0x501F161C;
					continue;
				case 6u:
					_qaFjfbsRbarhCYDjEuQqvi8idoV = r.ReadString();
					_NYFe8vPwL8kTGXvLVmBCbryvlDP = r.ReadString();
					_UK96J1x6VT6MW3hocR4mGIRfkdg = r.ReadString();
					num = (int)((num2 * 1671544577) ^ 0x4BC71C58);
					continue;
				case 2u:
					_WDZU3bp76s5FXEoq4PwbL0MocF = r.ReadInt32();
					_hdTOEZsuxAH0ZBDRBk75KYH82ze = r.ReadString();
					num = ((int)num2 * -1467370430) ^ 0x380DBD10;
					continue;
				case 11u:
					_mohOnMj4BzApB71G6voSGWkazsN = r.ReadInt32();
					num = (int)((num2 * 570492986) ^ 0x2DFE106D);
					continue;
				case 10u:
					_2YR8l930hg89G6B65rxYZ6rWUJB = r.ReadInt32();
					num = (int)((num2 * 200576496) ^ 0x25055CE7);
					continue;
				case 8u:
					_6ndefRdmjz9ThJdbUMMsQkovdUe = r.ReadString();
					num = ((int)num2 * -1260321376) ^ -241885711;
					continue;
				case 0u:
					_vw1iZ0g0gM2Jnv67ofhKq2lPYyC = r.ReadString();
					num = ((int)num2 * -1271580252) ^ 0x2A6C7E91;
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
		w.Write(_GfmkzrVWAfImTFxA9RJnJTXkb3k);
		while (true)
		{
			int num = 168921586;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2CDCCA8Bu) % 10u)
				{
				case 5u:
					break;
				default:
					return;
				case 0u:
					w.Write(_ig6wccaJwxykSCxVe6rxiJVe7Uf);
					w.Write(_XIWmR5lk02foPUtYWF2JL1Zanoo);
					w.Write(_Q4xAoSUBuQ2wwQnAwJv7UyaqJ0fA);
					w.Write(_2x96AsjHsGUoY0Hf6NIYgjPUrgN);
					w.Write(_qaFjfbsRbarhCYDjEuQqvi8idoV);
					w.Write(_NYFe8vPwL8kTGXvLVmBCbryvlDP);
					num = ((int)num2 * -1167222333) ^ -729684330;
					continue;
				case 3u:
					w.Write(_UK96J1x6VT6MW3hocR4mGIRfkdg);
					w.Write(_aaNefOWGYHcKzKuoxz8aTrAOPEfA);
					num = (int)((num2 * 61943627) ^ 0x61191506);
					continue;
				case 6u:
					w.Write(_caEPyMhZIywru545koF9xeYmUrA);
					num = ((int)num2 * -1240027382) ^ 0x78BF8648;
					continue;
				case 1u:
					w.Write(_mohOnMj4BzApB71G6voSGWkazsN);
					w.Write(_vw1iZ0g0gM2Jnv67ofhKq2lPYyC);
					w.Write(_2YR8l930hg89G6B65rxYZ6rWUJB);
					num = ((int)num2 * -1661848882) ^ -1839205943;
					continue;
				case 9u:
					w._9UoQbcRa99e4xjcrtzdQLYTHK2N(_NHpfzqUT66vabPP826CZeNFwcHC);
					num = ((int)num2 * -1011963423) ^ 0x12B1FEE2;
					continue;
				case 2u:
					w.Write(_TsKPJcEcXXpSwuINY9rvCt7eSxg);
					w.Write((short)_caEPyMhZIywru545koF9xeYmUrA.Length);
					num = (int)((num2 * 435742420) ^ 0x1AB9830B);
					continue;
				case 7u:
					w.Write(_hdTOEZsuxAH0ZBDRBk75KYH82ze);
					num = (int)((num2 * 468751106) ^ 0x4B33B791);
					continue;
				case 4u:
					w.Write(_6ndefRdmjz9ThJdbUMMsQkovdUe);
					w.Write(_WDZU3bp76s5FXEoq4PwbL0MocF);
					num = ((int)num2 * -1511274359) ^ -1777667948;
					continue;
				case 8u:
					return;
				}
				break;
			}
		}
	}
}
