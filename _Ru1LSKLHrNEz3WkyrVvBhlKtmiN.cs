using ExaltMultiTool.Proxy.Networking.Packets;

internal class _Ru1LSKLHrNEz3WkyrVvBhlKtmiN : Packet
{
	public const int _7VSSujIJwF6mzupj9vLObOJ5RCE = 1;

	public const int _9LsxDpD2Eg44SaJrCPEXCyONuIc = 2;

	public const int _ndtm0mzD7zShS4ROBXeXModSpJB = 3;

	public int _Mg3vcvTcJXOKNfcbJ0o921kDxTx;

	public uint _tjbHiRznBpNOVIqL5wnfaZ7vOZB;

	public override PacketType pType => PacketType.ACTIVEPETUPDATEREQUEST;

	public override void readPacketData(PacketReader r)
	{
		_Mg3vcvTcJXOKNfcbJ0o921kDxTx = r.ReadByte();
		while (true)
		{
			int num = -704281656;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9D745F35u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002e;
				case 2u:
					return;
				}
				break;
				IL_002e:
				_tjbHiRznBpNOVIqL5wnfaZ7vOZB = (uint)r.ReadInt32();
				num = ((int)num2 * -1603601955) ^ 0xBE12210;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write((byte)_Mg3vcvTcJXOKNfcbJ0o921kDxTx);
		w.Write((int)_tjbHiRznBpNOVIqL5wnfaZ7vOZB);
	}
}
