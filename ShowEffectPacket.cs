using System;
using System.IO;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class ShowEffectPacket : Packet
{
	private const int BITMASK_COLOR = 1;

	private const int BITMASK_POS1_X = 2;

	private const int BITMASK_POS1_Y = 4;

	private const int BITMASK_POS2_X = 8;

	private const int BITMASK_POS2_Y = 16;

	private const int BITMASK_POS1 = 6;

	private const int BITMASK_POS2 = 24;

	private const int BITMASK_DURATION = 32;

	private const int BITMASK_BIT_ID = 64;

	private const int BITMASK_ = 128;

	private static readonly _yNixIvVlGhPCEfXGcNUaC9jZYRS _sEbsBUoH2nb2Xe0NgbAdtwAYgyn = new _yNixIvVlGhPCEfXGcNUaC9jZYRS(uint.MaxValue);

	public _IjlO5UMx1JU6cnQE4rkBstwQlDe _sSyCr8bFcSziFMiZ9YqQth5e6Uc;

	public int _91Zhx0OBsUhlR5optw0cihxmls4;

	public WorldPosData _eVyRGurHYqbAmno19xMZWSdv2to = WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R;

	public WorldPosData _LzqOSouCFw90pddCpHPi77ITQkB = WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R;

	public _yNixIvVlGhPCEfXGcNUaC9jZYRS _JEsT6uIdK1eySUKAfntb2FPG6xS;

	public float _GqTyCW3dGiBN9DxAMWAsMjwS9AY;

	public byte _Py6PkxjHTY3O6pw4WuxldaFbWxH;

	public override PacketType pType => PacketType.SHOWEFFECT;

	public override void readPacketData(PacketReader r)
	{
		_sSyCr8bFcSziFMiZ9YqQth5e6Uc = (_IjlO5UMx1JU6cnQE4rkBstwQlDe)r.ReadByte();
		byte b = r.ReadByte();
		while (true)
		{
			int num = 1449331065;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40D1E49Eu) % 8u)
				{
				case 4u:
					break;
				default:
					return;
				case 2u:
					_LzqOSouCFw90pddCpHPi77ITQkB._PositionY = (((b & 0x10u) != 0) ? r.ReadSingle() : 0f);
					num = 1157121933;
					continue;
				case 3u:
					_JEsT6uIdK1eySUKAfntb2FPG6xS = ((((uint)b & (true ? 1u : 0u)) != 0) ? _yNixIvVlGhPCEfXGcNUaC9jZYRS._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r) : _sEbsBUoH2nb2Xe0NgbAdtwAYgyn);
					_GqTyCW3dGiBN9DxAMWAsMjwS9AY = (((b & 0x20u) != 0) ? r.ReadSingle() : 1f);
					num = 324033816;
					continue;
				case 7u:
					_91Zhx0OBsUhlR5optw0cihxmls4 = (((b & 0x40u) != 0) ? CompressedInt.Read(r) : 0);
					num = 1116186011;
					continue;
				case 0u:
					_Py6PkxjHTY3O6pw4WuxldaFbWxH = r.ReadByte();
					num = (int)(num2 * 204275967) ^ -480569097;
					continue;
				case 6u:
				{
					int num3;
					int num4;
					if ((b & 0x80u) != 0)
					{
						num3 = 1165841944;
						num4 = num3;
					}
					else
					{
						num3 = 1167361425;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -168239607);
					continue;
				}
				case 5u:
					_eVyRGurHYqbAmno19xMZWSdv2to._PositionX = (((b & 2u) != 0) ? r.ReadSingle() : 0f);
					_eVyRGurHYqbAmno19xMZWSdv2to._PositionY = (((b & 4u) != 0) ? r.ReadSingle() : 0f);
					_LzqOSouCFw90pddCpHPi77ITQkB._PositionX = (((b & 8u) != 0) ? r.ReadSingle() : 0f);
					num = 415062908;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			PacketWriter packetWriter = new PacketWriter(memoryStream);
			try
			{
				byte b = 0;
				while (true)
				{
					int num = -1643238703;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x8C6FB7E4u) % 29u)
						{
						case 11u:
							break;
						default:
							return;
						case 9u:
							memoryStream.WriteTo(w.BaseStream);
							num = (int)(num2 * 346286873) ^ -1985620056;
							continue;
						case 18u:
							packetWriter.Write((float)_LzqOSouCFw90pddCpHPi77ITQkB._PositionX);
							num = (int)((num2 * 945097382) ^ 0x7B6A5ADD);
							continue;
						case 25u:
						{
							int num11;
							if (_Py6PkxjHTY3O6pw4WuxldaFbWxH == 0)
							{
								num = -197323536;
								num11 = num;
							}
							else
							{
								num = -2120525197;
								num11 = num;
							}
							continue;
						}
						case 10u:
							b = (byte)(b | 8u);
							num = (int)(num2 * 2033619886) ^ -785170886;
							continue;
						case 0u:
							packetWriter.Write(_GqTyCW3dGiBN9DxAMWAsMjwS9AY);
							num = ((int)num2 * -161462346) ^ -1470388677;
							continue;
						case 28u:
							b = (byte)(b | 0x40u);
							num = (int)(num2 * 1789375064) ^ -1124730381;
							continue;
						case 23u:
						{
							int num15;
							int num16;
							if (_91Zhx0OBsUhlR5optw0cihxmls4 != 0)
							{
								num15 = 462565304;
								num16 = num15;
							}
							else
							{
								num15 = 310953710;
								num16 = num15;
							}
							num = num15 ^ ((int)num2 * -1080753177);
							continue;
						}
						case 12u:
						{
							int num13;
							if (_GqTyCW3dGiBN9DxAMWAsMjwS9AY == 1f)
							{
								num = -1689447607;
								num13 = num;
							}
							else
							{
								num = -2007583895;
								num13 = num;
							}
							continue;
						}
						case 6u:
							b = (byte)(b | 4u);
							packetWriter.Write((float)_eVyRGurHYqbAmno19xMZWSdv2to._PositionY);
							num = (int)(num2 * 436325175) ^ -903555861;
							continue;
						case 27u:
						{
							int num8;
							if (_eVyRGurHYqbAmno19xMZWSdv2to._PositionY == 0.0)
							{
								num = -2027065892;
								num8 = num;
							}
							else
							{
								num = -1481296411;
								num8 = num;
							}
							continue;
						}
						case 13u:
							CompressedInt.write(packetWriter, _91Zhx0OBsUhlR5optw0cihxmls4);
							num = (int)(num2 * 1855593005) ^ -29472466;
							continue;
						case 7u:
							b = (byte)(b | 1u);
							num = -2113373362;
							continue;
						case 15u:
							b = (byte)(b | 0x10u);
							num = ((int)num2 * -1070754631) ^ 0x50385F63;
							continue;
						case 21u:
							b = (byte)(b | 2u);
							packetWriter.Write((float)_eVyRGurHYqbAmno19xMZWSdv2to._PositionX);
							num = (int)((num2 * 185745312) ^ 0x2EB5111);
							continue;
						case 22u:
							packetWriter.Write((float)_LzqOSouCFw90pddCpHPi77ITQkB._PositionY);
							num = ((int)num2 * -244112703) ^ 0xFD7BEFF;
							continue;
						case 4u:
							_JEsT6uIdK1eySUKAfntb2FPG6xS._3Wc8kZJjhbRt6nttAKwD2698imm(packetWriter);
							num = (int)(num2 * 1797545387) ^ -1883970504;
							continue;
						case 19u:
							b = (byte)(b | 0x80u);
							packetWriter.Write(_Py6PkxjHTY3O6pw4WuxldaFbWxH);
							num = ((int)num2 * -1299203401) ^ 0x50339801;
							continue;
						case 1u:
							w.Write((byte)_sSyCr8bFcSziFMiZ9YqQth5e6Uc);
							num = -1774599009;
							continue;
						case 17u:
						{
							int num17;
							if (_LzqOSouCFw90pddCpHPi77ITQkB._PositionY == 0.0)
							{
								num = -948864627;
								num17 = num;
							}
							else
							{
								num = -1414813831;
								num17 = num;
							}
							continue;
						}
						case 2u:
							b = (byte)(b | 0x20u);
							num = (int)(num2 * 1903102157) ^ -983092490;
							continue;
						case 20u:
						{
							int num14;
							if (_JEsT6uIdK1eySUKAfntb2FPG6xS._e83B5VoPYGBwUAJrm6D3QiZAjKN != _sEbsBUoH2nb2Xe0NgbAdtwAYgyn._e83B5VoPYGBwUAJrm6D3QiZAjKN)
							{
								num = -792965841;
								num14 = num;
							}
							else
							{
								num = -1583394594;
								num14 = num;
							}
							continue;
						}
						case 5u:
						{
							int num12;
							if (_eVyRGurHYqbAmno19xMZWSdv2to._PositionX != 0.0)
							{
								num = -177354050;
								num12 = num;
							}
							else
							{
								num = -296734895;
								num12 = num;
							}
							continue;
						}
						case 26u:
						{
							int num9;
							int num10;
							if (_JEsT6uIdK1eySUKAfntb2FPG6xS._h27dzUIWOz6YD4vVCMWISV9HD6E == _sEbsBUoH2nb2Xe0NgbAdtwAYgyn._h27dzUIWOz6YD4vVCMWISV9HD6E)
							{
								num9 = -1068243522;
								num10 = num9;
							}
							else
							{
								num9 = -1244906713;
								num10 = num9;
							}
							num = num9 ^ (int)(num2 * 1740823164);
							continue;
						}
						case 3u:
						{
							int num6;
							int num7;
							if (_JEsT6uIdK1eySUKAfntb2FPG6xS._iY21vLRI7ndcaxztdbqOkfd6QbK == _sEbsBUoH2nb2Xe0NgbAdtwAYgyn._iY21vLRI7ndcaxztdbqOkfd6QbK)
							{
								num6 = 1482066757;
								num7 = num6;
							}
							else
							{
								num6 = 1335526003;
								num7 = num6;
							}
							num = num6 ^ (int)(num2 * 1735514630);
							continue;
						}
						case 24u:
						{
							int num5;
							if (_LzqOSouCFw90pddCpHPi77ITQkB._PositionX != 0.0)
							{
								num = -906859684;
								num5 = num;
							}
							else
							{
								num = -381570231;
								num5 = num;
							}
							continue;
						}
						case 8u:
						{
							int num3;
							int num4;
							if (_JEsT6uIdK1eySUKAfntb2FPG6xS._FceRcYJFuOsQJwJEoG7HX1TihKF == _sEbsBUoH2nb2Xe0NgbAdtwAYgyn._FceRcYJFuOsQJwJEoG7HX1TihKF)
							{
								num3 = 1639746269;
								num4 = num3;
							}
							else
							{
								num3 = 664489256;
								num4 = num3;
							}
							num = num3 ^ (int)(num2 * 1967327571);
							continue;
						}
						case 14u:
							w.Write(b);
							num = (int)((num2 * 235014205) ^ 0x245760C7);
							continue;
						case 16u:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				if (packetWriter != null)
				{
					while (true)
					{
						int num18 = -1303908585;
						while (true)
						{
							uint num2;
							switch ((num2 = (uint)num18 ^ 0x8C6FB7E4u) % 3u)
							{
							case 0u:
								break;
							default:
								goto end_IL_0443;
							case 1u:
								goto IL_0468;
							case 2u:
								goto end_IL_0443;
							}
							break;
							IL_0468:
							((IDisposable)packetWriter).Dispose();
							num18 = (int)(num2 * 157554014) ^ -912679332;
						}
					}
				}
				end_IL_0443:;
			}
		}
		finally
		{
			if (memoryStream != null)
			{
				while (true)
				{
					int num19 = -1241995500;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num19 ^ 0x8C6FB7E4u) % 3u)
						{
						case 0u:
							break;
						default:
							goto end_IL_047e;
						case 2u:
							goto IL_04a3;
						case 1u:
							goto end_IL_047e;
						}
						break;
						IL_04a3:
						((IDisposable)memoryStream).Dispose();
						num19 = (int)((num2 * 1139420336) ^ 0x60D0F97);
					}
				}
			}
			end_IL_047e:;
		}
	}
}
