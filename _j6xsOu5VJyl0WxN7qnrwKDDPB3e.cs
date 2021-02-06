using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

internal class _j6xsOu5VJyl0WxN7qnrwKDDPB3e
{
	[CompilerGenerated]
	private sealed class _DSFouceBtGBqGiaMgsmLmN9SBWW
	{
		public string _b63N5Mg6R1tzfBl10RvBdgsEZ5n;

		internal bool _tMK8l56ch4azsRbGhrvaloLsTMO(string entry)
		{
			return _b63N5Mg6R1tzfBl10RvBdgsEZ5n.Contains(entry);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _4eeHdJvvTeHZUJ2bM9m3udGaViA
	{
		public static readonly _4eeHdJvvTeHZUJ2bM9m3udGaViA _003C_003E9 = new _4eeHdJvvTeHZUJ2bM9m3udGaViA();

		public static Func<char, bool> _003C_003E9__2_0;

		internal bool _rgWqmyOoWIKCrhlvjxCVCf6kwOk(char c)
		{
			//Discarded unreachable code: IL_0031
			if (!char.IsLetter(c))
			{
				while (true)
				{
					uint num;
					switch ((num = 0xE5D78F61u ^ 0xC59B1A02u) % 3u)
					{
					case 0u:
						continue;
					case 2u:
						return char.IsNumber(c);
					}
					break;
				}
			}
			return true;
		}
	}

	private Client _50w8wVuv8bL5nhKaR2EHxjrTamB;

	private static readonly string[] _xR5gzTubbjoNG0jCFXdHoVo0GFA = new string[52]
	{
		"oryxsh0p",
		"whtebagnet",
		"realmshopinfo",
		"realmshoplnfo",
		"rotmgmarketc",
		"realmitems",
		"reaimitems",
		"reaimltems",
		"realmltems",
		"realmpowernet",
		"reaimpowernet",
		"rea!mkingsxyz",
		"buyrotmgc",
		"lifepotorg",
		"rotmgmaxme",
		"oryxln",
		"rwtmg",
		"rotmgio",
		"realmpower",
		"reaimpower",
		"rwtstore",
		"rwtshop",
		"rotmgrwt",
		"realmgood",
		"reaimgood",
		"rpgrip",
		"rpgrlp",
		"realmshop",
		"reaimshop",
		"realmsh0p",
		"reaimsh0p",
		"realmp0wer",
		"reaimp0wer",
		"relmgood",
		"reimgood",
		"hyuk3d",
		"realmservices",
		"rotmgstore",
		"discordgg",
		"discordcom",
		"discordrwt",
		"rwt",
		"discorddupe",
		"dlscord",
		"dlsc0rd",
		"0rdgg",
		"ordgg",
		"realmdupe",
		"reaimdupe",
		"relmshop",
		"relmsh0p",
		"rotmgnetwork"
	};

	public _j6xsOu5VJyl0WxN7qnrwKDDPB3e(Client client)
	{
		_50w8wVuv8bL5nhKaR2EHxjrTamB = client;
	}

	public void _N9zjozggCA9FymbKtC3I9dZkIib(TextPacket text)
	{
		//Discarded unreachable code: IL_005e
		IEnumerable<string> source = default(IEnumerable<string>);
		string _b63N5Mg6R1tzfBl10RvBdgsEZ5n;
		string text2 = default(string);
		while (true)
		{
			int num = -1882376116;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xADA9AFB1u) % 7u)
				{
				case 0u:
					break;
				default:
					return;
				case 6u:
				{
					int num3;
					int num4;
					if (text._NumStars < 0)
					{
						num3 = 338835314;
						num4 = num3;
					}
					else
					{
						num3 = 1914325675;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1542904044);
					continue;
				}
				case 4u:
					return;
				case 5u:
					text._Send = !source.Any();
					num = (int)((num2 * 1956523866) ^ 0x18410AD1);
					continue;
				case 2u:
					_b63N5Mg6R1tzfBl10RvBdgsEZ5n = text2 + "|" + text2.Normalize(NormalizationForm.FormC) + "|" + text2.Normalize(NormalizationForm.FormD) + "|" + text2.Normalize(NormalizationForm.FormKC) + "|" + text2.Normalize(NormalizationForm.FormKD);
					source = _xR5gzTubbjoNG0jCFXdHoVo0GFA.Where((string entry) => _b63N5Mg6R1tzfBl10RvBdgsEZ5n.Contains(entry));
					num = (int)((num2 * 1175599272) ^ 0x77B7514);
					continue;
				case 3u:
					text2 = new string(text._CleanMessage.Where(delegate(char c)
					{
						//Discarded unreachable code: IL_0031
						if (!char.IsLetter(c))
						{
							while (true)
							{
								uint num5;
								switch ((num5 = 0xE5D78F61u ^ 0xC59B1A02u) % 3u)
								{
								case 0u:
									continue;
								case 2u:
									return char.IsNumber(c);
								}
								break;
							}
						}
						return true;
					}).ToArray()).ToLower();
					num = -340162442;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}
}
