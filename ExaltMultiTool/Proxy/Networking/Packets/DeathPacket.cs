using ExaltMultiTool.Proxy.Networking.Packets;

internal class DeathPacket : Packet
{
	public string _fSKKbuiGLkwVuWz5bsJJqEiapf9;

	public int _IviHfWXXb2hAeeAcf2nbh2a7Zo;

	public string _wi6uoGpCUJziwDjOevBcL5nTwFd;

	public int _tjVjFwqJvTDJurk8Z8rBlq92FuB;

	public short _1DoCH0mpWaflwoQYn6KAazpVlvl;

	public string _M5JWfqz5mAzF5l7Bqm9i9bP3XCh;

	public override PacketType pType => PacketType.DEATH;

	public override void readPacketData(PacketReader r)
	{
		_fSKKbuiGLkwVuWz5bsJJqEiapf9 = r.ReadString();
		_IviHfWXXb2hAeeAcf2nbh2a7Zo = CompressedInt.Read(r);
		while (true)
		{
			int num = -184669873;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC88B1FDu) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					_wi6uoGpCUJziwDjOevBcL5nTwFd = r.ReadString();
					_tjVjFwqJvTDJurk8Z8rBlq92FuB = r.ReadInt32();
					_1DoCH0mpWaflwoQYn6KAazpVlvl = r.ReadInt16();
					num = (int)(num2 * 1031844492) ^ -801504188;
					continue;
				case 1u:
					_M5JWfqz5mAzF5l7Bqm9i9bP3XCh = r.ReadString();
					num = (int)(num2 * 1157749157) ^ -634341877;
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
		w.Write(_fSKKbuiGLkwVuWz5bsJJqEiapf9);
		CompressedInt.Write(w, _IviHfWXXb2hAeeAcf2nbh2a7Zo);
		w.Write(_wi6uoGpCUJziwDjOevBcL5nTwFd);
		w.Write(_tjVjFwqJvTDJurk8Z8rBlq92FuB);
		w.Write(_1DoCH0mpWaflwoQYn6KAazpVlvl);
		w.Write(_M5JWfqz5mAzF5l7Bqm9i9bP3XCh);
	}
}
