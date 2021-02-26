using System;
using ExaltMultiTool.Proxy.Networking.Packets;

internal interface IDataObject : ICloneable
{
	IDataObject Read(PacketReader r);

	void Write(PacketWriter w);
}
