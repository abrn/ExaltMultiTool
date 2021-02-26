using System;
using System.Net;
using System.Xml.Linq;
using ExaltMultiTool.Proxy.DataStructures;

internal static class ResourceDownloader {
	public static _VHWgt8pn9AXryODuVtLv9GmmHeH<ushort, ParseXML> _3ndzvDGHhvqls1BD8vzizSQBDdI;

	public static _VHWgt8pn9AXryODuVtLv9GmmHeH<ushort, TileStructure> GetTile;

	public static _VHWgt8pn9AXryODuVtLv9GmmHeH<ushort, ObjectStructure> _VPArsrlUa0uEsW6OxAYV9WHJAMK;

	public static _VHWgt8pn9AXryODuVtLv9GmmHeH<byte, PacketStructure> _PP85pw5fC3jVm7LDMzFra717hdB;

	private const string PacketsURL = "https://realmstock.network/Public/PacketsExalt";

	private const string TilesXML = "https://realmstock.network/Public/GetTileXml";

	private const string ObjectsXML = "https://realmstock.network/Public/GetObjectXml";

	public static void _uLt6b1uwFNgoZycBDqE02WmgdfB()
	{
		WebClient webClient = new WebClient();
		try {
			Program.LogInfoMessage("core", "Downloading OBJECTS...");
			string objectData = Resources.Objects;

			Program.LogInfoMessage("core", "Downloading PACKETS...");
			string packetData = webClient.DownloadString("https://realmstock.network/Public/PacketsExalt");

			Program.LogInfoMessage("core", "Downloading TILES...");
			string tileData = Resources.GroundTypes;
			
			Program.LogInfoMessage("core", "Loading XML...");
			
			XDocument parsedObjects = XDocument.Parse(objectData);
			XDocument parsedPackets = XDocument.Parse(packetData);
			XDocument parsedTiles = XDocument.Parse(tileData);
			
			Program.LogInfoMessage("core", "Parsing Objects...");
			_VPArsrlUa0uEsW6OxAYV9WHJAMK =
				new _VHWgt8pn9AXryODuVtLv9GmmHeH<ushort, ObjectStructure>(
					ObjectStructure._uLt6b1uwFNgoZycBDqE02WmgdfB(parsedObjects));
			
			Program.LogInfoMessage("core", "Parsing Items...");
			_3ndzvDGHhvqls1BD8vzizSQBDdI =
				new _VHWgt8pn9AXryODuVtLv9GmmHeH<ushort, ParseXML>(
					ParseXML._uLt6b1uwFNgoZycBDqE02WmgdfB(parsedObjects));
			
			Program.LogInfoMessage("core", "Parsing Packets...");
			_PP85pw5fC3jVm7LDMzFra717hdB =
				new _VHWgt8pn9AXryODuVtLv9GmmHeH<byte, PacketStructure>(
					PacketStructure._uLt6b1uwFNgoZycBDqE02WmgdfB(parsedPackets));
			
			Program.LogInfoMessage("core", "Parsing Tiles...");
			GetTile =
				new _VHWgt8pn9AXryODuVtLv9GmmHeH<ushort, TileStructure>(
					TileStructure._uLt6b1uwFNgoZycBDqE02WmgdfB(parsedTiles));
			return;
		}
		finally {
			((IDisposable) webClient).Dispose();
		}
	}
}