using ExaltMultiTool.Proxy.Networking.Packets;

internal class VaultUpdatePacket : Packet
{
	public bool _gFPvIIgzPNQqrOLNrwLvt9L0YiH;

	public int _itBzbWMkvo0AuQGuR19us26p4TP;

	public int _mVrHB9iWE8fKC1cy09EH2Tg38G;

	public int _29Cygi7ILPhL4sLWfXR3KEYpYle;

	public int[] _zGfl045ehROhk6jo6nvkc12rcvH;

	public int[] _Pg28U1MUv2y9I7GawSrEglFuQNv;

	public int[] _geK4oHsbAS9nZM9pjvAHYVUnwQs;

	public short _e3RATqJaUe962rwkkNNGGp3K5fg;

	public short _SnY8tYqjFdsGou7tQre0ohb35wH;

	public short _OoTaNfxf9MEA7YO4QSx56MgA64d;

	public short _WAaOWv8iKrXujiwJ5aa8fkLcoFm;

	public override PacketType pType => PacketType.VAULTINFORMATION;

	public override void readPacketData(PacketReader r)
	{
		_gFPvIIgzPNQqrOLNrwLvt9L0YiH = r.ReadBoolean();
		_itBzbWMkvo0AuQGuR19us26p4TP = CompressedInt.Read(r);
		_mVrHB9iWE8fKC1cy09EH2Tg38G = CompressedInt.Read(r);
		int num4 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num = -1089216750;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x96B684EEu) % 23u)
				{
				case 10u:
					break;
				default:
					return;
				case 8u:
					_Pg28U1MUv2y9I7GawSrEglFuQNv = new int[num4];
					num = ((int)num2 * -706913800) ^ 0x7881B7B9;
					continue;
				case 2u:
					_e3RATqJaUe962rwkkNNGGp3K5fg = r.ReadInt16();
					num = ((int)num2 * -1374587949) ^ 0x73E4FE90;
					continue;
				case 16u:
				{
					int num6;
					if (num3 >= num4)
					{
						num = -1733225645;
						num6 = num;
					}
					else
					{
						num = -2040706139;
						num6 = num;
					}
					continue;
				}
				case 22u:
					_Pg28U1MUv2y9I7GawSrEglFuQNv[num3] = CompressedInt.Read(r);
					num3++;
					num = -574903308;
					continue;
				case 12u:
					_29Cygi7ILPhL4sLWfXR3KEYpYle = CompressedInt.Read(r);
					num = ((int)num2 * -1358332318) ^ 0x4A2667E0;
					continue;
				case 18u:
					num = ((int)num2 * -635695813) ^ 0x5E614FC2;
					continue;
				case 19u:
					num4 = CompressedInt.Read(r);
					_geK4oHsbAS9nZM9pjvAHYVUnwQs = new int[num4];
					num3 = 0;
					num = (int)(num2 * 1890681941) ^ -789243023;
					continue;
				case 9u:
				{
					int num7;
					if (num3 < num4)
					{
						num = -955605494;
						num7 = num;
					}
					else
					{
						num = -1590175190;
						num7 = num;
					}
					continue;
				}
				case 4u:
					num3 = 0;
					num = ((int)num2 * -801368018) ^ -1898154682;
					continue;
				case 5u:
					num4 = CompressedInt.Read(r);
					num = ((int)num2 * -1959087971) ^ 0x4DB5BA45;
					continue;
				case 0u:
					_geK4oHsbAS9nZM9pjvAHYVUnwQs[num3] = CompressedInt.Read(r);
					num3++;
					num = -1779697461;
					continue;
				case 7u:
					num3++;
					num = ((int)num2 * -1108285097) ^ 0x75F06A7C;
					continue;
				case 21u:
					num = ((int)num2 * -1847187443) ^ 0x19FCF367;
					continue;
				case 6u:
					_OoTaNfxf9MEA7YO4QSx56MgA64d = r.ReadInt16();
					num = (int)(num2 * 458179125) ^ -378790107;
					continue;
				case 13u:
					_WAaOWv8iKrXujiwJ5aa8fkLcoFm = r.ReadInt16();
					num = (int)(num2 * 1546147650) ^ -1947664762;
					continue;
				case 11u:
				{
					int num5;
					if (num3 < num4)
					{
						num = -1577443610;
						num5 = num;
					}
					else
					{
						num = -1748687462;
						num5 = num;
					}
					continue;
				}
				case 20u:
					_SnY8tYqjFdsGou7tQre0ohb35wH = r.ReadInt16();
					num = (int)((num2 * 1670547451) ^ 0x1974C0FC);
					continue;
				case 3u:
					num4 = CompressedInt.Read(r);
					_zGfl045ehROhk6jo6nvkc12rcvH = new int[num4];
					num = (int)(num2 * 389102119) ^ -1515335158;
					continue;
				case 17u:
					_zGfl045ehROhk6jo6nvkc12rcvH[num3] = CompressedInt.Read(r);
					num = -625941633;
					continue;
				case 1u:
					num = (int)(num2 * 2042049623) ^ -1809297511;
					continue;
				case 15u:
					num3 = 0;
					num = (int)((num2 * 1328398955) ^ 0x3CBF6700);
					continue;
				case 14u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_gFPvIIgzPNQqrOLNrwLvt9L0YiH);
		CompressedInt.Write(w, _itBzbWMkvo0AuQGuR19us26p4TP);
		int value2 = default(int);
		int[] array = default(int[]);
		int num3 = default(int);
		while (true)
		{
			int num = 977581040;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F15B5ABu) % 23u)
				{
				case 21u:
					break;
				default:
					return;
				case 6u:
					value2 = array[num3];
					num = 959036017;
					continue;
				case 3u:
					array = _Pg28U1MUv2y9I7GawSrEglFuQNv;
					num = (int)(num2 * 36611475) ^ -1184011531;
					continue;
				case 5u:
					CompressedInt.Write(w, _mVrHB9iWE8fKC1cy09EH2Tg38G);
					num = ((int)num2 * -894590573) ^ 0x47A15075;
					continue;
				case 12u:
					w.Write(_WAaOWv8iKrXujiwJ5aa8fkLcoFm);
					num = (int)((num2 * 894434991) ^ 0x6BFA97D7);
					continue;
				case 14u:
				{
					int num6;
					if (num3 < array.Length)
					{
						num = 1563487542;
						num6 = num;
					}
					else
					{
						num = 628428482;
						num6 = num;
					}
					continue;
				}
				case 11u:
				{
					int value3 = array[num3];
					CompressedInt.Write(w, value3);
					num = 266767504;
					continue;
				}
				case 7u:
					num = (int)((num2 * 2007767239) ^ 0x15F006B3);
					continue;
				case 13u:
					CompressedInt.Write(w, _29Cygi7ILPhL4sLWfXR3KEYpYle);
					num = ((int)num2 * -1728410121) ^ 0x65283AA3;
					continue;
				case 1u:
					CompressedInt.Write(w, _geK4oHsbAS9nZM9pjvAHYVUnwQs.Length);
					num = ((int)num2 * -1887655639) ^ 0x7A0F1423;
					continue;
				case 4u:
					CompressedInt.Write(w, _zGfl045ehROhk6jo6nvkc12rcvH.Length);
					array = _zGfl045ehROhk6jo6nvkc12rcvH;
					num3 = 0;
					num = (int)(num2 * 585392407) ^ -104694037;
					continue;
				case 19u:
					num3 = 0;
					num = (int)((num2 * 11366053) ^ 0x2D0C66C);
					continue;
				case 22u:
				{
					int num5;
					if (num3 < array.Length)
					{
						num = 1986098461;
						num5 = num;
					}
					else
					{
						num = 881327163;
						num5 = num;
					}
					continue;
				}
				case 18u:
					num3++;
					num = ((int)num2 * -779111419) ^ 0x2E083D0B;
					continue;
				case 17u:
					w.Write(_e3RATqJaUe962rwkkNNGGp3K5fg);
					w.Write(_SnY8tYqjFdsGou7tQre0ohb35wH);
					num = ((int)num2 * -2035658055) ^ 0x366E1743;
					continue;
				case 15u:
					w.Write(_OoTaNfxf9MEA7YO4QSx56MgA64d);
					num = ((int)num2 * -192860514) ^ -1412175719;
					continue;
				case 20u:
					CompressedInt.Write(w, value2);
					num3++;
					num = (int)((num2 * 824317827) ^ 0x69E2E31E);
					continue;
				case 9u:
					CompressedInt.Write(w, _Pg28U1MUv2y9I7GawSrEglFuQNv.Length);
					num = (int)(num2 * 1056074650) ^ -7496857;
					continue;
				case 10u:
				{
					int num4;
					if (num3 < array.Length)
					{
						num = 68636749;
						num4 = num;
					}
					else
					{
						num = 1221070974;
						num4 = num;
					}
					continue;
				}
				case 16u:
				{
					int value = array[num3];
					CompressedInt.Write(w, value);
					num3++;
					num = 873889578;
					continue;
				}
				case 8u:
					array = _geK4oHsbAS9nZM9pjvAHYVUnwQs;
					num3 = 0;
					num = (int)((num2 * 1758200408) ^ 0x12D05A0C);
					continue;
				case 0u:
					num = (int)(num2 * 804966987) ^ -1817495951;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}
}
