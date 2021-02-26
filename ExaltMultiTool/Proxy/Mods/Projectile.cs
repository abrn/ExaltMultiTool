using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ExaltMultiTool.Proxy.DataStructures;

namespace ExaltMultiTool.Proxy.Mods
{
	public struct Projectile
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class _Nk7N3VJjoFabdfex8f7ymPKcHzI
		{
			public static readonly _Nk7N3VJjoFabdfex8f7ymPKcHzI _003C_003E9 = new _Nk7N3VJjoFabdfex8f7ymPKcHzI();

			public static Action<ObjectStructure> _003C_003E9__11_0;

			internal void _19Lde4gkcANgQee3MdN6VOHdP58(ObjectStructure enemy)
			{
				if (!enemy.Projectiles.Any())
				{
					goto IL_0010;
				}
				goto IL_0159;
				IL_0159:
				List<byte> list = new List<byte>();
				List<byte> list2 = new List<byte>();
				Dictionary<byte, ProjectileStructure> dictionary = new Dictionary<byte, ProjectileStructure>();
				ProjectileStructure[] projectiles = enemy.Projectiles;
				int num = 905614278;
				goto IL_0015;
				IL_0015:
				int num3 = default(int);
				ProjectileStructure projectileStructure = default(ProjectileStructure);
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x1CCAF84Au) % 16u)
					{
					case 14u:
						break;
					default:
						return;
					case 8u:
						goto IL_006b;
					case 0u:
						_9dlEBQRajgHUPe01BLJS9ymRjkc.Add(enemy.ID, list2);
						num = (int)(num2 * 191264179) ^ -517369544;
						continue;
					case 12u:
						num3 = 0;
						num = (int)(num2 * 1296187777) ^ -122392875;
						continue;
					case 4u:
						list2.Add(projectileStructure.ID);
						num = ((int)num2 * -1591650231) ^ -166307041;
						continue;
					case 13u:
						_ZBH1FpPAnW1jZrUD0KruZCQObYF.Add(enemy.ID, list);
						num = ((int)num2 * -1204996809) ^ -1873362783;
						continue;
					case 1u:
						dictionary.Add(projectileStructure.ID, projectileStructure);
						num3++;
						num = 339316962;
						continue;
					case 7u:
					{
						int num4;
						int num5;
						if (!projectileStructure.ArmorPiercing)
						{
							num4 = 66105209;
							num5 = num4;
						}
						else
						{
							num4 = 686859107;
							num5 = num4;
						}
						num = num4 ^ ((int)num2 * -1688931420);
						continue;
					}
					case 3u:
						num = ((int)num2 * -127758595) ^ 0x43068B25;
						continue;
					case 9u:
						goto IL_0159;
					case 5u:
						list.Add(projectileStructure.ID);
						num = ((int)num2 * -1857351975) ^ 0x17861208;
						continue;
					case 2u:
						ObjectTypeToProjectileIdStructureMap.Add(enemy.ID, dictionary);
						num = (int)((num2 * 876159021) ^ 0x26122D1B);
						continue;
					case 10u:
						projectileStructure = projectiles[num3];
						num = 645494957;
						continue;
					case 15u:
						goto IL_01d0;
					case 6u:
						return;
					case 11u:
						return;
					}
					break;
					IL_01d0:
					int num6;
					if (projectileStructure.StatusEffects.ContainsKey("Armor Broken"))
					{
						num = 892400558;
						num6 = num;
					}
					else
					{
						num = 785489691;
						num6 = num;
					}
					continue;
					IL_006b:
					int num7;
					if (num3 >= projectiles.Length)
					{
						num = 1446484999;
						num7 = num;
					}
					else
					{
						num = 1365763216;
						num7 = num;
					}
				}
				goto IL_0010;
				IL_0010:
				num = 1880347740;
				goto IL_0015;
			}
		}

		private static readonly Dictionary<int, List<byte>> _ZBH1FpPAnW1jZrUD0KruZCQObYF = new Dictionary<int, List<byte>>();

		private static readonly Dictionary<int, List<byte>> _9dlEBQRajgHUPe01BLJS9ymRjkc = new Dictionary<int, List<byte>>();

		public static readonly Dictionary<int, Dictionary<byte, ProjectileStructure>> ObjectTypeToProjectileIdStructureMap = new Dictionary<int, Dictionary<byte, ProjectileStructure>>();

		private static bool _263QE1fWcJWpQPNDEcgmZApCd9h = false;

		public int OwnerId;

		public byte Id;

		public byte ProjectileType;

		public int Damage;

		public ProjectileStructure Structure;

		public static bool IsPiercing(int enemyType, byte projectileType)
		{
			if (_ZBH1FpPAnW1jZrUD0KruZCQObYF.ContainsKey(enemyType))
			{
				while (true)
				{
					uint num;
					switch ((num = 0xF5C007B6u ^ 0xE9AC1AEEu) % 3u)
					{
					case 2u:
						continue;
					case 1u:
						return _ZBH1FpPAnW1jZrUD0KruZCQObYF[enemyType].Contains(projectileType);
					}
					break;
				}
			}
			return false;
		}

		public static bool IsArmorBreaking(int enemyType, byte projectileType)
		{
			if (_9dlEBQRajgHUPe01BLJS9ymRjkc.ContainsKey(enemyType))
			{
				while (true)
				{
					uint num;
					switch ((num = 0xB68EA44u ^ 0x7E4E14AEu) % 3u)
					{
					case 0u:
						continue;
					case 1u:
						return _9dlEBQRajgHUPe01BLJS9ymRjkc[enemyType].Contains(projectileType);
					}
					break;
				}
			}
			return false;
		}

		public static void Initialize()
		{
			if (_263QE1fWcJWpQPNDEcgmZApCd9h)
			{
				goto IL_0007;
			}
			goto IL_006c;
			IL_006c:
			_263QE1fWcJWpQPNDEcgmZApCd9h = true;
			int num = -906312898;
			goto IL_000c;
			IL_000c:
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84C44801u) % 5u)
				{
				case 4u:
					break;
				default:
					return;
				case 1u:
					ResourceDownloader._VPArsrlUa0uEsW6OxAYV9WHJAMK._oQlNWqxOoe5LqobGdGJlgo4YIsh.Values._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(ObjectStructure enemy)
					{
						if (!enemy.Projectiles.Any())
						{
							goto IL_0010;
						}
						goto IL_0159;
						IL_0159:
						List<byte> list = new List<byte>();
						List<byte> list2 = new List<byte>();
						Dictionary<byte, ProjectileStructure> dictionary = new Dictionary<byte, ProjectileStructure>();
						ProjectileStructure[] projectiles = enemy.Projectiles;
						int num3 = 905614278;
						goto IL_0015;
						IL_0015:
						int num5 = default(int);
						ProjectileStructure projectileStructure = default(ProjectileStructure);
						while (true)
						{
							uint num4;
							switch ((num4 = (uint)num3 ^ 0x1CCAF84Au) % 16u)
							{
							case 14u:
								break;
							default:
								return;
							case 8u:
								goto IL_006b;
							case 0u:
								_9dlEBQRajgHUPe01BLJS9ymRjkc.Add(enemy.ID, list2);
								num3 = (int)(num4 * 191264179) ^ -517369544;
								continue;
							case 12u:
								num5 = 0;
								num3 = (int)(num4 * 1296187777) ^ -122392875;
								continue;
							case 4u:
								list2.Add(projectileStructure.ID);
								num3 = ((int)num4 * -1591650231) ^ -166307041;
								continue;
							case 13u:
								_ZBH1FpPAnW1jZrUD0KruZCQObYF.Add(enemy.ID, list);
								num3 = ((int)num4 * -1204996809) ^ -1873362783;
								continue;
							case 1u:
								dictionary.Add(projectileStructure.ID, projectileStructure);
								num5++;
								num3 = 339316962;
								continue;
							case 7u:
							{
								int num6;
								int num7;
								if (!projectileStructure.ArmorPiercing)
								{
									num6 = 66105209;
									num7 = num6;
								}
								else
								{
									num6 = 686859107;
									num7 = num6;
								}
								num3 = num6 ^ ((int)num4 * -1688931420);
								continue;
							}
							case 3u:
								num3 = ((int)num4 * -127758595) ^ 0x43068B25;
								continue;
							case 9u:
								goto IL_0159;
							case 5u:
								list.Add(projectileStructure.ID);
								num3 = ((int)num4 * -1857351975) ^ 0x17861208;
								continue;
							case 2u:
								ObjectTypeToProjectileIdStructureMap.Add(enemy.ID, dictionary);
								num3 = (int)((num4 * 876159021) ^ 0x26122D1B);
								continue;
							case 10u:
								projectileStructure = projectiles[num5];
								num3 = 645494957;
								continue;
							case 15u:
								goto IL_01d0;
							case 6u:
								return;
							case 11u:
								return;
							}
							break;
							IL_01d0:
							int num8;
							if (projectileStructure.StatusEffects.ContainsKey("Armor Broken"))
							{
								num3 = 892400558;
								num8 = num3;
							}
							else
							{
								num3 = 785489691;
								num8 = num3;
							}
							continue;
							IL_006b:
							int num9;
							if (num5 >= projectiles.Length)
							{
								num3 = 1446484999;
								num9 = num3;
							}
							else
							{
								num3 = 1365763216;
								num9 = num3;
							}
						}
						goto IL_0010;
						IL_0010:
						num3 = 1880347740;
						goto IL_0015;
					});
					num = -1037050082;
					continue;
				case 0u:
					goto IL_006c;
				case 3u:
					return;
				case 2u:
					return;
				}
				break;
			}
			goto IL_0007;
			IL_0007:
			num = -1797369473;
			goto IL_000c;
		}
	}
}
