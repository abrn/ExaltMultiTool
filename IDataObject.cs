using System;

internal interface IDataObject : ICloneable
{
	IDataObject Read(PacketReader r);

	void Write(PacketWriter w);
}
