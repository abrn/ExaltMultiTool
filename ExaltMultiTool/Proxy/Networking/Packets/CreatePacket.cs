using ExaltMultiTool.Proxy.Networking.Packets;

internal class CreatePacket : Packet
{
	public short _rEvsSM2mDSXW03AGDtCIKkHswsO;

	public short _fs5BJYKFK8FXABMGk6bv85f0d9kA;

	public override PacketType pType => PacketType.CREATE;

	public override void readPacketData(PacketReader r)
	{
		_rEvsSM2mDSXW03AGDtCIKkHswsO = r.ReadInt16();
		while (true)
		{
			int num = -1167559536;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD4D77E5Eu) % 3u)
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
				_fs5BJYKFK8FXABMGk6bv85f0d9kA = r.ReadInt16();
				num = ((int)num2 * -1020565530) ^ -111037703;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_rEvsSM2mDSXW03AGDtCIKkHswsO);
		w.Write(_fs5BJYKFK8FXABMGk6bv85f0d9kA);
	}
}
