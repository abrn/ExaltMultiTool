using ExaltMultiTool.Proxy.Networking.Packets;

internal class NewAbilityPacket : Packet
{
	public _tAHBHched3PZoxIRth1tEToCLCz _6wLhh38CI3MUIHT5JBGbz7HRJrn;

	public override PacketType pType => PacketType.NEWABILITY;

	public override void readPacketData(PacketReader r)
	{
		_6wLhh38CI3MUIHT5JBGbz7HRJrn = (_tAHBHched3PZoxIRth1tEToCLCz)r.ReadInt32();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write((int)_6wLhh38CI3MUIHT5JBGbz7HRJrn);
	}
}
