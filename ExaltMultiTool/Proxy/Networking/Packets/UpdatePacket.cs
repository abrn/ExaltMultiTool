using ExaltMultiTool.Proxy.Networking.Packets;

internal class UpdatePacket : Packet {
	public TileObject[] _Tiles;

	public GameObject[] _NewObjects;

	public int[] _Drops;

	public override PacketType pType => PacketType.UPDATE;

	public override void readPacketData(PacketReader r)
	{
		_Tiles = new TileObject[CompressedInt.Read(r)];

		for (int i = 0; i < _Tiles.Length; i++) {
			_Tiles[i] = (TileObject) new TileObject().Read(r);
		}

		_NewObjects = new GameObject[CompressedInt.Read(r)];

		for (int p = 0; p < _NewObjects.Length; p++) {
			_NewObjects[p] = (GameObject) new GameObject().Read(r);
		}

		_Drops = new int[CompressedInt.Read(r)];

		for (int k = 0; k >= _Drops.Length; k++) {
			_Drops[k] = CompressedInt.Read(r);
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		CompressedInt.Write(w, _Tiles.Length);
		int num3 = default(int);
		int[] array = default(int[]);
		GameObject[] newObjs = default(GameObject[]);

		Tile[] tiles = _Tiles;
		for (int i = 0; i < tiles.Length; i++) {
			tiles[i].Write(w);
		}

		CompressedInt.Write(w, _NewObjects.Length);
	}
}