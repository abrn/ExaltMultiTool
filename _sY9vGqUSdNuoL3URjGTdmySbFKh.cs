using ExaltMultiTool.Proxy.Networking.Packets;

internal class _sY9vGqUSdNuoL3URjGTdmySbFKh : Packet
{
	public int _oj2QIz6GMkXYEj16O5EmVcndgnI;

	public bool _CZWGmSCWcd73uPXE8SnbyFjkm9O;

	public override PacketType pType => PacketType.LOAD;

	public override void readPacketData(PacketReader r)
	{
		_oj2QIz6GMkXYEj16O5EmVcndgnI = r.ReadInt32();
		while (true)
		{
			int num = 692125861;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x48D069F6u) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_002e;
				case 0u:
					return;
				}
				break;
				IL_002e:
				_CZWGmSCWcd73uPXE8SnbyFjkm9O = r.ReadBoolean();
				num = ((int)num2 * -1435200158) ^ -281749612;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_oj2QIz6GMkXYEj16O5EmVcndgnI);
		w.Write(_CZWGmSCWcd73uPXE8SnbyFjkm9O);
	}
}
