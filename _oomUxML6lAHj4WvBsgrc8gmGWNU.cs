using ExaltMultiTool.Proxy.Networking.Packets;

internal class _oomUxML6lAHj4WvBsgrc8gmGWNU : Packet
{
	public int _QJzwbDuzkS2qWoyVl5LHx24odpG;

	public override PacketType pType => PacketType.UNLOCKINFORMATION;

	public override void readPacketData(PacketReader r)
	{
		_QJzwbDuzkS2qWoyVl5LHx24odpG = r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_QJzwbDuzkS2qWoyVl5LHx24odpG);
	}
}
