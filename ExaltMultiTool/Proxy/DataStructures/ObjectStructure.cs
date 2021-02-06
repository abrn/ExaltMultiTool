using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ExaltMultiTool.Proxy.DataStructures
{
	public class ObjectStructure : IDataStructure<ushort>
	{
		[CompilerGenerated]
		private sealed class _42SoAOn7Z0XYm6cpiIxcfk9fsVv
		{
			public Dictionary<ushort, ObjectStructure> _Y47d6cq6yur6qR7gPJQSTOJl5Wm;

			internal void _Iu71vpYAaRocerWHxtZjwfWPbMA(XElement obj)
			{
				ObjectStructure objectStructure = new ObjectStructure(obj);
				_Y47d6cq6yur6qR7gPJQSTOJl5Wm[objectStructure.ID] = objectStructure;
			}
		}

		[CompilerGenerated]
		private sealed class _sTbDMXqF9HeMn0Lda14uXKLE4RD
		{
			public List<ProjectileStructure> _1Y65ux6ODW11oQa4WNlqrraKG6e;

			internal void _IZjAljPdl5GZBrivAgReV1Wxf62(XElement projectile)
			{
				_1Y65ux6ODW11oQa4WNlqrraKG6e.Add(new ProjectileStructure(projectile));
			}
		}

		[CompilerGenerated]
		private ushort _p6MAdQUIoeJwjajDnswJBZlM1l9;

		public string ObjectClass;

		public ushort MaxHP;

		public float XPMult;

		public bool Static;

		public bool OccupySquare;

		public bool EnemyOccupySquare;

		public bool FullOccupy;

		public bool BlocksSight;

		public bool ProtectFromGroundDamage;

		public bool ProtectFromSink;

		public bool Enemy;

		public bool Player;

		public bool Pet;

		public bool DrawOnGround;

		public ushort Size;

		public ushort ShadowSize;

		public ushort Defense;

		public bool Flying;

		public bool God;

		public bool Cube;

		public bool Quest;

		public bool Item;

		public bool Usable;

		public bool Soulbound;

		public ushort MpCost;

		public ProjectileStructure[] Projectiles;

		public bool Invulnerable;

		public bool Invincible;

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

		internal static Dictionary<ushort, ObjectStructure> _uLt6b1uwFNgoZycBDqE02WmgdfB(XDocument doc)
		{
			Dictionary<ushort, ObjectStructure> _Y47d6cq6yur6qR7gPJQSTOJl5Wm = default(Dictionary<ushort, ObjectStructure>);
			while (true)
			{
				int num = 921482770;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7B050B3Au) % 3u)
					{
					case 0u:
						break;
					case 2u:
						goto IL_0028;
					default:
						return _Y47d6cq6yur6qR7gPJQSTOJl5Wm;
					}
					break;
					IL_0028:
					_Y47d6cq6yur6qR7gPJQSTOJl5Wm = new Dictionary<ushort, ObjectStructure>();
					doc.Element("Objects").Elements("Object")._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(XElement obj)
					{
						ObjectStructure objectStructure = new ObjectStructure(obj);
						_Y47d6cq6yur6qR7gPJQSTOJl5Wm[objectStructure.ID] = objectStructure;
					});
					num = (int)((num2 * 182052573) ^ 0x3EC99DBE);
				}
			}
		}

		public ObjectStructure(XElement obj)
		{
			ClassStats classStats = default(ClassStats);
			_sTbDMXqF9HeMn0Lda14uXKLE4RD sTbDMXqF9HeMn0Lda14uXKLE4RD = default(_sTbDMXqF9HeMn0Lda14uXKLE4RD);
			while (true)
			{
				int num = 497663125;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x46FE958Cu) % 37u)
					{
					case 23u:
						break;
					default:
						return;
					case 17u:
						Size = (ushort)obj._bUyefY83pIQc4tdCSCBCAwGEWxF("Size", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
						num = (int)((num2 * 99713434) ^ 0x2D57A715);
						continue;
					case 18u:
						OccupySquare = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("OccupySquare");
						num = ((int)num2 * -1384973929) ^ -1760575149;
						continue;
					case 31u:
						Console.WriteLine($"Failed parsing player stats of {ID} {ObjectClass}");
						num = ((int)num2 * -1844473694) ^ -912645136;
						continue;
					case 27u:
						Console.WriteLine($"Failed parsing player stats of {ID} {ObjectClass}");
						num = (int)((num2 * 1171460625) ^ 0x476FC9DA);
						continue;
					case 25u:
						EnemyOccupySquare = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("EnemyOccupySquare");
						FullOccupy = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("FullOccupy");
						num = ((int)num2 * -140336572) ^ 0x6BDACD59;
						continue;
					case 12u:
						Console.WriteLine($"Failed parsing player stats of {ID} {ObjectClass}");
						num = ((int)num2 * -494917739) ^ 0x1F374055;
						continue;
					case 3u:
					{
						int num12;
						if (int.TryParse(obj.Element("Dexterity").Attribute("max").Value, out classStats.DexterityMax))
						{
							num = 1689255643;
							num12 = num;
						}
						else
						{
							num = 490275465;
							num12 = num;
						}
						continue;
					}
					case 1u:
						Flying = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Flying");
						num = (int)(num2 * 1168361225) ^ -1332595424;
						continue;
					case 8u:
						BlocksSight = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("BlocksSight");
						num = (int)((num2 * 1605934978) ^ 0x6F2FB3F2);
						continue;
					case 11u:
						Defense = (ushort)obj._bUyefY83pIQc4tdCSCBCAwGEWxF("Defense", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
						num = (int)(num2 * 1891330989) ^ -957009768;
						continue;
					case 36u:
					{
						int num9;
						if (!int.TryParse(obj.Element("MaxMagicPoints").Attribute("max").Value, out classStats.ManaMax))
						{
							num = 1053327410;
							num9 = num;
						}
						else
						{
							num = 1508676335;
							num9 = num;
						}
						continue;
					}
					case 32u:
					{
						int num6;
						if (!int.TryParse(obj.Element("Attack").Attribute("max").Value, out classStats.AttackMax))
						{
							num = 210637865;
							num6 = num;
						}
						else
						{
							num = 1761975762;
							num6 = num;
						}
						continue;
					}
					case 0u:
						Console.WriteLine($"Failed parsing player stats of {ID} {ObjectClass}");
						num = (int)((num2 * 892328211) ^ 0x41BF39F5);
						continue;
					case 33u:
						Console.WriteLine($"Failed parsing player stats of {ID} {ObjectClass}");
						num = ((int)num2 * -92039837) ^ -1240747724;
						continue;
					case 4u:
						sTbDMXqF9HeMn0Lda14uXKLE4RD = new _sTbDMXqF9HeMn0Lda14uXKLE4RD();
						ID = (ushort)obj._4qMIb2N5gf9DdhWw9LENt8TJhOK("type", "0x0")._59ab9VkqetpIwwmGzw45eRNlLMg();
						ObjectClass = obj._bUyefY83pIQc4tdCSCBCAwGEWxF("Class", "GameObject");
						num = (int)((num2 * 176662042) ^ 0x8757B7F);
						continue;
					case 15u:
						ClassStats.Map.Add(ID, classStats);
						num = 581223406;
						continue;
					case 24u:
					{
						int num13;
						if (int.TryParse(obj.Element("Defense").Attribute("max").Value, out classStats.DefenseMax))
						{
							num = 111212480;
							num13 = num;
						}
						else
						{
							num = 336383764;
							num13 = num;
						}
						continue;
					}
					case 29u:
						Pet = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Pet");
						DrawOnGround = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("DrawOnGround");
						num = ((int)num2 * -1488010765) ^ -1760201955;
						continue;
					case 10u:
					{
						int num11;
						if (!int.TryParse(obj.Element("Speed").Attribute("max").Value, out classStats.SpeedMax))
						{
							num = 1923083999;
							num11 = num;
						}
						else
						{
							num = 550376055;
							num11 = num;
						}
						continue;
					}
					case 14u:
						classStats = new ClassStats();
						num = (int)((num2 * 589989725) ^ 0x3A26DF27);
						continue;
					case 20u:
						God = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("God");
						Cube = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Cube");
						Quest = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Quest");
						Invulnerable = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Invulnerable");
						Invincible = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Invincible");
						num = ((int)num2 * -162984076) ^ -175663583;
						continue;
					case 16u:
						Console.WriteLine($"Failed parsing player stats of {ID} {ObjectClass}");
						num = (int)(num2 * 584067999) ^ -1652292354;
						continue;
					case 34u:
						Console.WriteLine($"Failed parsing player stats of {ID} {ObjectClass}");
						num = ((int)num2 * -1817706582) ^ -562659223;
						continue;
					case 21u:
					{
						int num10;
						if (!int.TryParse(obj.Element("HpRegen").Attribute("max").Value, out classStats.VitalityMax))
						{
							num = 896093345;
							num10 = num;
						}
						else
						{
							num = 652113165;
							num10 = num;
						}
						continue;
					}
					case 7u:
					{
						int num7;
						int num8;
						if (!Player)
						{
							num7 = -1395069913;
							num8 = num7;
						}
						else
						{
							num7 = -1886195190;
							num8 = num7;
						}
						num = num7 ^ ((int)num2 * -414654363);
						continue;
					}
					case 19u:
						Player = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Player");
						num = ((int)num2 * -1144756049) ^ -693728569;
						continue;
					case 13u:
					{
						int num4;
						int num5;
						if (int.TryParse(obj.Element("MaxHitPoints").Attribute("max").Value, out classStats.LifeMax))
						{
							num4 = 1794567446;
							num5 = num4;
						}
						else
						{
							num4 = 406414080;
							num5 = num4;
						}
						num = num4 ^ (int)(num2 * 586078078);
						continue;
					}
					case 9u:
						Console.WriteLine($"Failed parsing player stats of {ID} {ObjectClass}");
						num = ((int)num2 * -888289257) ^ 0x68C01001;
						continue;
					case 35u:
						Static = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Static");
						num = (int)((num2 * 1324164087) ^ 0x3DBE28FF);
						continue;
					case 2u:
					{
						int num3;
						if (!int.TryParse(obj.Element("MpRegen").Attribute("max").Value, out classStats.WisdomMax))
						{
							num = 797609020;
							num3 = num;
						}
						else
						{
							num = 1464566565;
							num3 = num;
						}
						continue;
					}
					case 26u:
						MaxHP = (ushort)obj._bUyefY83pIQc4tdCSCBCAwGEWxF("MaxHitPoints", "0")._59ab9VkqetpIwwmGzw45eRNlLMg();
						XPMult = obj._bUyefY83pIQc4tdCSCBCAwGEWxF("XpMult", "0")._y09e3EoPW54jYelUtQzj66l0jRF();
						num = ((int)num2 * -1842834529) ^ 0x1C532820;
						continue;
					case 5u:
						ShadowSize = (ushort)obj._bUyefY83pIQc4tdCSCBCAwGEWxF("ShadowSize", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
						num = ((int)num2 * -887962358) ^ 0x3590B683;
						continue;
					case 6u:
						ProtectFromSink = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("ProtectFromSink");
						Enemy = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Enemy");
						num = ((int)num2 * -834111851) ^ -660226433;
						continue;
					case 28u:
						ProtectFromGroundDamage = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("ProtectFromGroundDamage");
						num = (int)(num2 * 2041484975) ^ -621457841;
						continue;
					case 30u:
						Item = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Item");
						Usable = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Usable");
						Soulbound = obj._ujE3VgDdVnbxGy9qIazxpFzbjrY("Soulbound");
						MpCost = (ushort)obj._bUyefY83pIQc4tdCSCBCAwGEWxF("MpCost", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
						sTbDMXqF9HeMn0Lda14uXKLE4RD._1Y65ux6ODW11oQa4WNlqrraKG6e = new List<ProjectileStructure>();
						obj.Elements("Projectile")._rvkyhEufCiuaZq8jbaYgthJoLEx(sTbDMXqF9HeMn0Lda14uXKLE4RD._IZjAljPdl5GZBrivAgReV1Wxf62);
						Projectiles = sTbDMXqF9HeMn0Lda14uXKLE4RD._1Y65ux6ODW11oQa4WNlqrraKG6e.ToArray();
						Name = obj._4qMIb2N5gf9DdhWw9LENt8TJhOK("id", "");
						num = ((int)num2 * -861282579) ^ 0x75A6C6FC;
						continue;
					case 22u:
						return;
					}
					break;
				}
			}
		}

		public override string ToString()
		{
			return $"Object: {Name} (0x{ID:X})";
		}
	}
}
