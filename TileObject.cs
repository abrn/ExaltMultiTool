using System;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class TileObject : ICloneable, IDataObject {
	public short _PositionX;

	public short _PositionY;

	public ushort _TileType;

	public TileObject()
	{
	}

	public TileObject(short x, short y, ushort type)
	{
		_PositionX = x;
		_PositionY = y;
		_TileType = type;
	}

	public IDataObject Read(PacketReader r)
	{
		_PositionX = r.ReadInt16();
		_PositionY = r.ReadInt16();
		_TileType = r.ReadUInt16();
		return this;
	}

	public void Write(PacketWriter w)
	{
		w.Write(_PositionX);
		w.Write(_PositionY);
		w.Write(_TileType);
	}

	public object Clone()
	{
		return new TileObject(_PositionX, _PositionY, _TileType);
	}

	public override string ToString()
	{
		return $"{{ X={_PositionX}, Y={_PositionY}, Type={_TileType} }}";
	}
}