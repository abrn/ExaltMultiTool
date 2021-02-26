using ExaltMultiTool.Proxy.DataStructures;

internal class MapStructure
{
	public TileStructure _Tile;

	public short _PosX;

	public short _PosY;

	public ushort _TileType;

	public MapStructure(TileStructure tile, short x, short y, ushort type)
	{
		_Tile = tile;
		_PosX = x;
		_PosY = y;
		_TileType = type;
	}
}
