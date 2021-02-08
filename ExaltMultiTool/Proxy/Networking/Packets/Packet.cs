using System;
using System.IO;
using System.Reflection;
using System.Text;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class Packet {
	public bool _Send = true;

	public byte ID;

	public byte[] _p6Ga5HaW6HbwlLT3tvYuJi2GRQN = new byte[0];

	private byte[] _PacketBytes;

	public virtual PacketType pType => PacketType.UNKNOWN;

	public virtual void readPacketData(PacketReader r)
	{
		_PacketBytes = r.ReadBytes((int) r.BaseStream.Length - 5);
		Program.LogNetworkError("client",
			string.Format("System: Read unknown packet ID {0} [{1}]\n{2}", ID,
				_PacketBytes.Length, string.Join(",", _PacketBytes)));
	}

	public virtual void writePacketData(PacketWriter w)
	{
		w.Write(_PacketBytes);
	}

	public static Packet CreatePacketFromType(PacketType type)
	{
		PacketStructure packetStructure =
			ResourceDownloader._PP85pw5fC3jVm7LDMzFra717hdB.ByName(type.ToString());
		Packet obj = (Packet) Activator.CreateInstance(packetStructure._bjQd3Vpt6RdoySpzKxn7K2gQGoM);
		obj.ID = packetStructure._QjKHGXZ7ohXwrDQImauPaSixsVg;
		return obj;
	}

	public static _0001 CreatePacketFromType<_0001>(PacketType type)
	{
		Packet obj = (Packet) Activator.CreateInstance(typeof(_0001));
		obj.ID = ResourceDownloader._PP85pw5fC3jVm7LDMzFra717hdB
			.ByName(type.ToString())._QjKHGXZ7ohXwrDQImauPaSixsVg;
		return (_0001) Convert.ChangeType(obj, typeof(_0001));
	}

	public _0001 _p13VSaI2reB14Aq4kYbHNdlptPE<_0001>()
	{
		return (_0001) Convert.ChangeType(this, typeof(_0001));
	}

	public static Packet CreatePacketFromType(byte[] data)
	{
		PacketReader packetReader = new PacketReader(new MemoryStream(data));
		try {
			packetReader.ReadInt32();
			byte b = packetReader.ReadByte();
			PacketStructure packetStructure = default(PacketStructure);
			Packet rI3eJ3XrDMu6I9id6v1cRdIj9o = default(Packet);
			long position = default(long);
			long length = default(long);
			int count = default(int);
			Packet result = default(Packet);
			while (true) {
				int num = -1129298162;
				while (true) {
					uint num2;
					Type type;
					switch ((num2 = (uint) num ^ 0xD787D2DFu) % 9u) {
						case 8u:
							break;
						case 1u:
							packetStructure = ResourceDownloader._PP85pw5fC3jVm7LDMzFra717hdB
								.ById(b);
							num = (int) (num2 * 1863705160) ^ -398980535;
							continue;
						case 7u:
							Program.LogNetworkError("client",
								$"Extra Packet (id {rI3eJ3XrDMu6I9id6v1cRdIj9o.ID}, type {rI3eJ3XrDMu6I9id6v1cRdIj9o.pType}) Bytes [{position}/{length}]:\n{_oAqYnHyz3WN1ohkC8nPl0RlExIv(data)}");
							count = (int) (length - position);
							num = ((int) num2 * -1869518791) ^ 0x3B2A5BB2;
							continue;
						case 2u:
							if (packetStructure != null) {
								num = (int) (num2 * 625897205) ^ -960359570;
								continue;
							}

							type = typeof(Packet);
							goto IL_0173;
						case 4u: {
							rI3eJ3XrDMu6I9id6v1cRdIj9o.readPacketData(packetReader);
							position = packetReader.BaseStream.Position;
							length = packetReader.BaseStream.Length;
							int num3;
							int num4;
							if (position < length) {
								num3 = -1036910096;
								num4 = num3;
							}
							else {
								num3 = -1720739956;
								num4 = num3;
							}

							num = num3 ^ ((int) num2 * -371424941);
							continue;
						}
						case 6u:
							rI3eJ3XrDMu6I9id6v1cRdIj9o._p6Ga5HaW6HbwlLT3tvYuJi2GRQN = packetReader.ReadBytes(count);
							num = (int) ((num2 * 1663235230) ^ 0x31C5D7DA);
							continue;
						case 3u:
							type = packetStructure._bjQd3Vpt6RdoySpzKxn7K2gQGoM;
							goto IL_0173;
						case 0u:
							result = rI3eJ3XrDMu6I9id6v1cRdIj9o;
							num = -1867448207;
							continue;
						default:
							return result;
						case 5u: {
							return result;
						}
							IL_0173:
							rI3eJ3XrDMu6I9id6v1cRdIj9o = (Packet) Activator.CreateInstance(type);
							rI3eJ3XrDMu6I9id6v1cRdIj9o.ID = b;
							num = -1665879579;
							continue;
					}

					break;
				}
			}
		}
		finally {
			if (packetReader != null) {
				((IDisposable) packetReader).Dispose();
			}
		}
	}

	public static string _oAqYnHyz3WN1ohkC8nPl0RlExIv(byte[] input)
	{
		char[] array = new char[input.Length * 2];
		int num = 0;
		int num5 = default(int);
		while (true) {
			int num2;
			int num3;
			if (num < input.Length) {
				num2 = 1214535970;
				num3 = num2;
			}
			else {
				num2 = 1966021819;
				num3 = num2;
			}

			while (true) {
				uint num4;
				switch ((num4 = (uint) num2 ^ 0x2E237F12u) % 7u) {
					case 0u:
						num2 = 1214535970;
						continue;
					case 5u:
						num++;
						num2 = ((int) num4 * -852095289) ^ 0x4C07C8C1;
						continue;
					case 4u:
						num5 = input[num] & 0xF;
						array[num * 2 + 1] = (char) (55 + num5 + ((num5 - 10 >> 31) & -7));
						num2 = ((int) num4 * -604181210) ^ 0x5439DD07;
						continue;
					case 6u:
						array[num * 2] = (char) (55 + num5 + ((num5 - 10 >> 31) & -7));
						num2 = (int) ((num4 * 674959572) ^ 0x2BFB8DDB);
						continue;
					case 2u:
						break;
					case 3u:
						num5 = input[num] >> 4;
						num2 = 1251939993;
						continue;
					default:
						return new string(array);
				}

				break;
			}
		}
	}

	private static bool _J2zSa3Pi55JBq33YmgBGt7heSAv(PacketType packetType)
	{
		//Discarded unreachable code: IL_00db
		if (packetType <= PacketType.UPDATEACK) {
			goto IL_0008;
		}

		goto IL_00e5;
		IL_00e5:
		int num;
		int num2;
		if (packetType != PacketType.NEWTICK) {
			num = -66330526;
			num2 = num;
		}
		else {
			num = -483994014;
			num2 = num;
		}

		goto IL_000d;
		IL_000d:
		while (true) {
			uint num3;
			switch ((num3 = (uint) num ^ 0x8A7FD27Eu) % 9u) {
				case 3u:
					break;
				case 5u:
					num = (int) (num3 * 2103203666) ^ -2023172249;
					continue;
				case 1u: {
					int num8;
					int num9;
					if ((uint) (packetType - 10) <= 1u) {
						num8 = -417145343;
						num9 = num8;
					}
					else {
						num8 = -1841629666;
						num9 = num8;
					}

					num = num8 ^ ((int) num3 * -1844066627);
					continue;
				}
				case 6u: {
					int num6;
					int num7;
					if ((uint) (packetType - 22) <= 1u) {
						num6 = -630534358;
						num7 = num6;
					}
					else {
						num6 = -2012193554;
						num7 = num6;
					}

					num = num6 ^ (int) (num3 * 1136008606);
					continue;
				}
				case 8u: {
					int num10;
					int num11;
					if (packetType != PacketType.ALLYSHOOT) {
						num10 = -1604299255;
						num11 = num10;
					}
					else {
						num10 = -1094235398;
						num11 = num10;
					}

					num = num10 ^ ((int) num3 * -310763959);
					continue;
				}
				case 4u: {
					int num4;
					int num5;
					if (packetType == PacketType.MOVE) {
						num4 = 1974777162;
						num5 = num4;
					}
					else {
						num4 = 1488174281;
						num5 = num4;
					}

					num = num4 ^ (int) (num3 * 2042863044);
					continue;
				}
				case 7u:
					return true;
				case 2u:
					goto IL_00e5;
				default:
					return false;
			}

			break;
		}

		goto IL_0008;
		IL_0008:
		num = -1538730476;
		goto IL_000d;
	}

	public override string _SflzbyPcrkdh9uZXinsV7KrbBMw()
	{
		FieldInfo[] fields = GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(pType.ToString() + "(" + ID +
		                     ") Packet Instance");
		FieldInfo[] array = fields;
		FieldInfo fieldInfo = default(FieldInfo);
		int num3 = default(int);
		while (true) {
			int num = -1262219465;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0xAF78B7C6u) % 8u) {
					case 0u:
						break;
					case 5u:
						stringBuilder.Append("\n\t" + fieldInfo.Name + " => " + fieldInfo.GetValue(this));
						num = -839051903;
						continue;
					case 7u:
						num3++;
						num = (int) (num2 * 2126986517) ^ -1538716761;
						continue;
					case 2u: {
						int num4;
						if (num3 >= array.Length) {
							num = -55145632;
							num4 = num;
						}
						else {
							num = -238710;
							num4 = num;
						}

						continue;
					}
					case 1u:
						num3 = 0;
						num = ((int) num2 * -2129254954) ^ 0x68A956B3;
						continue;
					case 3u:
						num = ((int) num2 * -289083987) ^ -1453892237;
						continue;
					case 4u:
						fieldInfo = array[num3];
						num = -1092957269;
						continue;
					default:
						return stringBuilder.ToString();
				}

				break;
			}
		}
	}

	public string _FJWpRUh7aDIc41P04RFyrZedPYB()
	{
		FieldInfo[] fields = GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(pType.ToString() + " [" +
		                     ResourceDownloader._PP85pw5fC3jVm7LDMzFra717hdB
			                     .ByName(pType.ToString())
			                     ._QjKHGXZ7ohXwrDQImauPaSixsVg + "] \nPacket Structure:\n{");
		FieldInfo[] array = fields;
		int num3 = default(int);
		FieldInfo fieldInfo = default(FieldInfo);
		while (true) {
			int num = -1708127868;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0x95ECE506u) % 9u) {
					case 7u:
						break;
					case 3u:
						num3++;
						num = (int) ((num2 * 1955689863) ^ 0x2A45B210);
						continue;
					case 8u:
						num = (int) ((num2 * 2096037699) ^ 0x2E449D55);
						continue;
					case 4u:
						stringBuilder.Append("\n}");
						num = (int) (num2 * 1251536725) ^ -1635915542;
						continue;
					case 6u:
						stringBuilder.Append("\n  " + fieldInfo.Name + " => " + fieldInfo.FieldType.Name);
						num = ((int) num2 * -1552293257) ^ 0xFF65F60;
						continue;
					case 2u: {
						int num4;
						if (num3 >= array.Length) {
							num = -5605793;
							num4 = num;
						}
						else {
							num = -517832450;
							num4 = num;
						}

						continue;
					}
					case 5u:
						fieldInfo = array[num3];
						num = -1834453745;
						continue;
					case 1u:
						num3 = 0;
						num = ((int) num2 * -753435695) ^ -1818387686;
						continue;
					default:
						return stringBuilder.ToString();
				}

				break;
			}
		}
	}
}