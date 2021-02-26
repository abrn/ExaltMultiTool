using System.Linq;
using System.Runtime.CompilerServices;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.DataStructures;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class SafeWalk {
	[CompilerGenerated]
	private sealed class Tile {
		public TileObject _gNqSu0ttbd15HIOb5VM8P14kmgd;

		internal bool _qLjbfvpvv4ok8fhIivprcWtJuAB(TileStructure type)
		{
			return type.ID == _gNqSu0ttbd15HIOb5VM8P14kmgd._TileType;
		}
	}

	private Client CurrentClient;

	private bool[] _SafeTiles;

	private bool _InShatters;

	private readonly ushort _EBuPkvI54JU1sFVONydkDVTfF5c = ResourceDownloader.GetTile.ByName("EH Secret Floor").ID;

	private TileStructure _slbUxvbdQHycDlSLDv7Fp9vzLwcA =
		ResourceDownloader.GetTile.ByName("Crystal Cave Shallow Water");

	private TileStructure[] _qg9vWVSuFk5KWGQxb00C7qZd1yP = new TileStructure[5]
	{
		ResourceDownloader.GetTile.ByName("Pool"),
		ResourceDownloader.GetTile.ById(14605),
		ResourceDownloader.GetTile.ById(14788),
		ResourceDownloader.GetTile.ById(14812),
		ResourceDownloader.GetTile.ById(14771)
	};

	public SafeWalk(Client client)
	{
		CurrentClient = client;
	}

	private bool GetTileSafety(int x, int y)
	{
		int num = x * CurrentClient._PositionX + y;
		return _SafeTiles[num];
	}

	private void SetTileSafety(int x, int y, bool value)
	{
		int num = x * CurrentClient._PositionX + y;
		_SafeTiles[num] = value;
	}

	public void OnMapInfo(MapInfoPacket mapInfo)
	{
		_InShatters = mapInfo._DisplayName.ToLower().Contains("shatters");
		_SafeTiles = new bool[mapInfo._Width * mapInfo._Height];
	}

	public void OnUpdate(UpdatePacket update)
	{
		GameObject[] lakUpSXZB1zdJcCECL20tl6SVrT = update._NewObjects;
		int num = 0;
		GameObject gameObject = default(GameObject);
		TileObject[] _2CIHnoEa49dfPXyqt9nkkBlUcQf = default(TileObject[]);
		MapStructure mapStructure = default(MapStructure);
		ObjectStructure objectStructure = default(ObjectStructure);
		Tile jDuaG31Xe8XJ3zd9YVFcuUiYrW = default(Tile);
		while (true) {
			int num2;
			int num3;
			if (num >= lakUpSXZB1zdJcCECL20tl6SVrT.Length) {
				num2 = 2010952782;
				num3 = num2;
			}
			else {
				num2 = 1620547635;
				num3 = num2;
			}

			while (true) {
				uint num4;
				switch ((num4 = (uint) num2 ^ 0x7E3FB22Du) % 24u) {
					case 12u:
						num2 = 1620547635;
						continue;
					default:
						return;
					case 13u:
						SetTileSafety((int) gameObject._Status._Position._PositionX,
							(int) gameObject._Status._Position._PositionY, value: true);
						num2 = ((int) num4 * -961744554) ^ -243430478;
						continue;
					case 16u: {
						int num9;
						if (num >= _2CIHnoEa49dfPXyqt9nkkBlUcQf.Length) {
							num2 = 1733640553;
							num9 = num2;
						}
						else {
							num2 = 333317702;
							num9 = num2;
						}

						continue;
					}
					case 17u: {
						int num16;
						if (mapStructure._Tile.MinDamage <= 0) {
							num2 = 261571655;
							num16 = num2;
						}
						else {
							num2 = 2001023909;
							num16 = num2;
						}

						continue;
					}
					case 6u:
						gameObject = lakUpSXZB1zdJcCECL20tl6SVrT[num];
						num2 = 1685888117;
						continue;
					case 2u:
						break;
					case 19u: {
						int num20;
						int num21;
						if (objectStructure.ProtectFromGroundDamage) {
							num20 = 622838595;
							num21 = num20;
						}
						else {
							num20 = 2028001239;
							num21 = num20;
						}

						num2 = num20 ^ (int) (num4 * 444209681);
						continue;
					}
					case 7u:
						num++;
						num2 = 880993805;
						continue;
					case 22u:
						jDuaG31Xe8XJ3zd9YVFcuUiYrW._gNqSu0ttbd15HIOb5VM8P14kmgd._TileType =
							_EBuPkvI54JU1sFVONydkDVTfF5c;
						num2 = ((int) num4 * -1205964094) ^ 0x2364D6FE;
						continue;
					case 18u: {
						int num17;
						if (Settings.Default.EnableCustomNexus) {
							num2 = 1026700347;
							num17 = num2;
						}
						else {
							num2 = 724304106;
							num17 = num2;
						}

						continue;
					}
					case 1u:
						num2 = (int) (num4 * 1662897317) ^ -1961276272;
						continue;
					case 11u:
						_2CIHnoEa49dfPXyqt9nkkBlUcQf = update._Tiles;
						num = 0;
						num2 = (int) ((num4 * 913737150) ^ 0x16DB2CE);
						continue;
					case 3u:
						jDuaG31Xe8XJ3zd9YVFcuUiYrW = new Tile();
						num2 = 973742447;
						continue;
					case 10u:
						jDuaG31Xe8XJ3zd9YVFcuUiYrW._gNqSu0ttbd15HIOb5VM8P14kmgd = _2CIHnoEa49dfPXyqt9nkkBlUcQf[num];
						num2 = ((int) num4 * -1810827798) ^ -1443243532;
						continue;
					case 0u: {
						int num7;
						int num8;
						if (GetTileSafety(jDuaG31Xe8XJ3zd9YVFcuUiYrW._gNqSu0ttbd15HIOb5VM8P14kmgd._PositionX,
							jDuaG31Xe8XJ3zd9YVFcuUiYrW._gNqSu0ttbd15HIOb5VM8P14kmgd._PositionY)) {
							num7 = 1353074527;
							num8 = num7;
						}
						else {
							num7 = 9589883;
							num8 = num7;
						}

						num2 = num7 ^ ((int) num4 * -2049079085);
						continue;
					}
					case 9u:
						num++;
						num2 = 1979409927;
						continue;
					case 23u:
						jDuaG31Xe8XJ3zd9YVFcuUiYrW._gNqSu0ttbd15HIOb5VM8P14kmgd._TileType =
							_slbUxvbdQHycDlSLDv7Fp9vzLwcA.ID;
						num2 = (int) ((num4 * 608639521) ^ 0x79920E7D);
						continue;
					case 8u: {
						objectStructure = ResourceDownloader._VPArsrlUa0uEsW6OxAYV9WHJAMK.ById(gameObject._ObjectType);
						int num18;
						int num19;
						if (objectStructure != null) {
							num18 = 1857957430;
							num19 = num18;
						}
						else {
							num18 = 1782474652;
							num19 = num18;
						}

						num2 = num18 ^ ((int) num4 * -1345241816);
						continue;
					}
					case 15u:
						num2 = ((int) num4 * -454551400) ^ -1798317566;
						continue;
					case 21u: {
						mapStructure = CurrentClient._psKBaUvFAGf2xFOCwHRyUMbhDXG(
							jDuaG31Xe8XJ3zd9YVFcuUiYrW._gNqSu0ttbd15HIOb5VM8P14kmgd._PositionX,
							jDuaG31Xe8XJ3zd9YVFcuUiYrW._gNqSu0ttbd15HIOb5VM8P14kmgd._PositionY);
						int num14;
						int num15;
						if (Settings.Default.EnableSafeWalk) {
							num14 = -1811936846;
							num15 = num14;
						}
						else {
							num14 = -2049887611;
							num15 = num14;
						}

						num2 = num14 ^ (int) (num4 * 1505269834);
						continue;
					}
					case 14u: {
						int num12;
						int num13;
						if (!_qg9vWVSuFk5KWGQxb00C7qZd1yP.Any(jDuaG31Xe8XJ3zd9YVFcuUiYrW._qLjbfvpvv4ok8fhIivprcWtJuAB)
						) {
							num12 = -851351540;
							num13 = num12;
						}
						else {
							num12 = -988112004;
							num13 = num12;
						}

						num2 = num12 ^ (int) (num4 * 637285689);
						continue;
					}
					case 5u: {
						int num10;
						int num11;
						if (_InShatters) {
							num10 = -656176903;
							num11 = num10;
						}
						else {
							num10 = -1130790076;
							num11 = num10;
						}

						num2 = num10 ^ ((int) num4 * -1437320632);
						continue;
					}
					case 20u: {
						int num5;
						int num6;
						if (!Settings.Default.SafeWalkInShatters) {
							num5 = 477215579;
							num6 = num5;
						}
						else {
							num5 = 1882433648;
							num6 = num5;
						}

						num2 = num5 ^ (int) (num4 * 2131303929);
						continue;
					}
					case 4u:
						return;
				}

				break;
			}
		}
	}
}