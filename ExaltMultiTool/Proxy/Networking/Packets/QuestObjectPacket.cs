namespace ExaltMultiTool.Proxy.Networking.Packets {
	internal class QuestObjectPacket : Packet
	{
		public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

		public int[] _0m8NlaV4OCNiAPRjFijgkuWdRKi;

		public override PacketType pType => PacketType.QUESTOBJID;

		public override void readPacketData(PacketReader r)
		{
			_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
			int num4 = default(int);
			int num3 = default(int);
			while (true)
			{
				int num = -890323734;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xDBB3C55Fu) % 9u)
					{
						case 2u:
							break;
						default:
							return;
						case 0u:
							num4++;
							num = (int)((num2 * 1382914508) ^ 0x5BA29011);
							continue;
						case 8u:
							num = (int)(num2 * 939735231) ^ -452427194;
							continue;
						case 5u:
							_0m8NlaV4OCNiAPRjFijgkuWdRKi[num4] = CompressedInt.Read(r);
							num = -1930086851;
							continue;
						case 4u:
						{
							int num5;
							if (num4 >= num3)
							{
								num = -377010023;
								num5 = num;
							}
							else
							{
								num = -1228787294;
								num5 = num;
							}
							continue;
						}
						case 3u:
							num4 = 0;
							num = (int)(num2 * 798761728) ^ -243507666;
							continue;
						case 1u:
							num3 = CompressedInt.Read(r);
							num = ((int)num2 * -2005919501) ^ 0x50F259B7;
							continue;
						case 7u:
							_0m8NlaV4OCNiAPRjFijgkuWdRKi = new int[num3];
							num = ((int)num2 * -831199538) ^ -1576077550;
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
			w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
			int num3 = default(int);
			int[] array = default(int[]);
			while (true)
			{
				int num = -534206622;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xAA59D237u) % 8u)
					{
						case 7u:
							break;
						default:
							return;
						case 3u:
						{
							int num4;
							if (num3 < array.Length)
							{
								num = -2137476202;
								num4 = num;
							}
							else
							{
								num = -778737315;
								num4 = num;
							}
							continue;
						}
						case 1u:
						{
							int value = array[num3];
							CompressedInt.Write(w, value);
							num = -1355846221;
							continue;
						}
						case 0u:
							num = (int)(num2 * 980667508) ^ -1824651948;
							continue;
						case 6u:
							num3 = 0;
							num = ((int)num2 * -1500272918) ^ -1747861037;
							continue;
						case 5u:
							CompressedInt.Write(w, _0m8NlaV4OCNiAPRjFijgkuWdRKi.Length);
							array = _0m8NlaV4OCNiAPRjFijgkuWdRKi;
							num = (int)(num2 * 533298544) ^ -2092753487;
							continue;
						case 4u:
							num3++;
							num = ((int)num2 * -318000647) ^ 0x99FD150;
							continue;
						case 2u:
							return;
					}
					break;
				}
			}
		}
	}
}
