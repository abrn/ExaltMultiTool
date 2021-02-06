using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ExaltMultiTool.Proxy.DataStructures
{
	public class TileStructure : IDataStructure<ushort>
	{
		[CompilerGenerated]
		private sealed class _FkYCdb0HAsjFI1gDLclFsknaSWDB
		{
			public Dictionary<ushort, TileStructure> _Y47d6cq6yur6qR7gPJQSTOJl5Wm;

			internal void _Iu71vpYAaRocerWHxtZjwfWPbMA(XElement tile)
			{
				TileStructure tileStructure = new TileStructure(tile);
				while (true)
				{
					int num = -1171025006;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0x9B81FC23u) % 3u)
						{
						case 0u:
							break;
						default:
							return;
						case 1u:
							goto IL_0029;
						case 2u:
							return;
						}
						break;
						IL_0029:
						_Y47d6cq6yur6qR7gPJQSTOJl5Wm[tileStructure.ID] = tileStructure;
						num = (int)(num2 * 1999882083) ^ -976377929;
					}
				}
			}
		}

		[CompilerGenerated]
		private ushort _p6MAdQUIoeJwjajDnswJBZlM1l9;

		public bool NoWalk;

		public float Speed;

		public bool Sink;

		public ushort MinDamage;

		public ushort MaxDamage;

		[CompilerGenerated]
		private string _Qc96P7YDwjC6nKoSJ1iVZ312wic;

		public ushort ID
		{
			get;
			private set;
		}

		public string Name
		{
			get;
			private set;
		}

		internal static Dictionary<ushort, TileStructure> _uLt6b1uwFNgoZycBDqE02WmgdfB(XDocument doc)
		{
			Dictionary<ushort, TileStructure> _Y47d6cq6yur6qR7gPJQSTOJl5Wm = default(Dictionary<ushort, TileStructure>);
			while (true)
			{
				int num = 557210898;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x72B9B6B5u) % 3u)
					{
					case 2u:
						break;
					case 1u:
						goto IL_0028;
					default:
						doc.Element("GroundTypes").Elements("Ground")._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(XElement tile)
						{
							TileStructure tileStructure = new TileStructure(tile);
							while (true)
							{
								int num3 = -1171025006;
								while (true)
								{
									uint num4;
									switch ((num4 = (uint)num3 ^ 0x9B81FC23u) % 3u)
									{
									case 0u:
										break;
									default:
										return;
									case 1u:
										goto IL_0029;
									case 2u:
										return;
									}
									break;
									IL_0029:
									_Y47d6cq6yur6qR7gPJQSTOJl5Wm[tileStructure.ID] = tileStructure;
									num3 = (int)(num4 * 1999882083) ^ -976377929;
								}
							}
						});
						return _Y47d6cq6yur6qR7gPJQSTOJl5Wm;
					}
					break;
					IL_0028:
					_Y47d6cq6yur6qR7gPJQSTOJl5Wm = new Dictionary<ushort, TileStructure>();
					num = (int)((num2 * 864682942) ^ 0x7D12DDC7);
				}
			}
		}

		public TileStructure(XElement tile)
		{
			while (true)
			{
				int num = 598008957;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x63AB73EFu) % 7u)
					{
					case 0u:
						break;
					default:
						return;
					case 3u:
						MaxDamage = (ushort)tile._bUyefY83pIQc4tdCSCBCAwGEWxF("MaxDamage", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
						Name = tile._4qMIb2N5gf9DdhWw9LENt8TJhOK("id", "");
						num = (int)(num2 * 1341983415) ^ -1138864212;
						continue;
					case 2u:
						Speed = tile._bUyefY83pIQc4tdCSCBCAwGEWxF("Speed", "1")._y09e3EoPW54jYelUtQzj66l0jRF();
						num = (int)(num2 * 885202684) ^ -1854957785;
						continue;
					case 5u:
						MinDamage = (ushort)tile._bUyefY83pIQc4tdCSCBCAwGEWxF("MinDamage", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
						num = ((int)num2 * -1751959065) ^ 0x4C8A942;
						continue;
					case 1u:
						Sink = tile._ujE3VgDdVnbxGy9qIazxpFzbjrY("Sink");
						num = ((int)num2 * -1698047252) ^ -1056319404;
						continue;
					case 4u:
						ID = (ushort)tile._4qMIb2N5gf9DdhWw9LENt8TJhOK("type", "0x0")._59ab9VkqetpIwwmGzw45eRNlLMg();
						NoWalk = tile._ujE3VgDdVnbxGy9qIazxpFzbjrY("NoWalk");
						num = ((int)num2 * -1890881105) ^ -934611142;
						continue;
					case 6u:
						return;
					}
					break;
				}
			}
		}

		public override string ToString()
		{
			return $"Tile: {Name} (0x{ID:X})";
		}
	}
}
