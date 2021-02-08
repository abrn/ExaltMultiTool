using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

internal class ServerList
{
	[CompilerGenerated]
	private static Dictionary<string, string> _n9VcfhrortuyRmTzzlfmx4XJ2io = new Dictionary<string, string>();

	[CompilerGenerated]
	private static Dictionary<string, string> _NR5hIaCz0jhcJtAcM1w2uHNPLhE = new Dictionary<string, string>();

	public static Dictionary<string, string> _ServerList
	{
		get;
		private set;
	}

	public static Dictionary<string, string> _aCrqUtEobC4JELAJ9SKdNpyMHvF
	{
		get;
		private set;
	}

	public static void _J120yKYbtEVgxfxC5akH1UoBgjq()
	{
		//Discarded unreachable code: IL_0419
		Program.LogInfoMessage("core", "Parsing servers...");
		XmlDocument xmlDocument = default(XmlDocument);
		StringBuilder stringBuilder = default(StringBuilder);
		XmlNode xmlNode3 = default(XmlNode);
		XmlNode xmlNode = default(XmlNode);
		int num8 = default(int);
		char c = default(char);
		string innerText = default(string);
		XmlNode xmlNode2 = default(XmlNode);
		while (true)
		{
			int num = -1075592845;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFC2282E7u) % 3u)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0032;
				default:
				{
					WebClient webClient = new WebClient();
					try
					{
						string xml = webClient.DownloadString($"https://www.realmofthemadgod.com/char/list?guid={Environment.TickCount}");
						xmlDocument.LoadXml(xml);
					}
					finally
					{
						if (webClient != null)
						{
							while (true)
							{
								int num3 = -826988592;
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0xFC2282E7u) % 3u)
									{
									case 0u:
										break;
									default:
										goto end_IL_0072;
									case 1u:
										goto IL_0098;
									case 2u:
										goto end_IL_0072;
									}
									break;
									IL_0098:
									((IDisposable)webClient).Dispose();
									num3 = (int)(num2 * 1402648206) ^ -536106229;
								}
							}
						}
						end_IL_0072:;
					}
					IEnumerator enumerator = (xmlDocument.SelectNodes("Chars/Servers/Server") ?? throw new Exception("Failed to grab server list! Possibly rate limited by DECA, wait 10 minutes and try again.")).GetEnumerator();
					try
					{
						while (true)
						{
							int num4;
							int num5;
							if (!enumerator.MoveNext())
							{
								num4 = -720321871;
								num5 = num4;
							}
							else
							{
								num4 = -893649623;
								num5 = num4;
							}
							while (true)
							{
								switch ((num2 = (uint)num4 ^ 0xFC2282E7u) % 20u)
								{
								case 11u:
									num4 = -893649623;
									continue;
								default:
									goto end_IL_00ce;
								case 16u:
									_aCrqUtEobC4JELAJ9SKdNpyMHvF.Add(stringBuilder.ToString().ToLower(), xmlNode3.InnerText);
									num4 = (int)((num2 * 2014193611) ^ 0x440C9E1D);
									continue;
								case 0u:
									num4 = ((int)num2 * -755488762) ^ 0x6B1B300;
									continue;
								case 12u:
								{
									int num15;
									int num16;
									if (!xmlNode3.InnerText.StartsWith("CU"))
									{
										num15 = -1561295346;
										num16 = num15;
									}
									else
									{
										num15 = -1463578878;
										num16 = num15;
									}
									num4 = num15 ^ (int)(num2 * 1053437665);
									continue;
								}
								case 15u:
									Program.LogNetworkError("core", "Failed parsing server " + xmlNode.OuterXml);
									num4 = -1158821992;
									continue;
								case 10u:
									xmlNode = (XmlNode)enumerator.Current;
									xmlNode3 = xmlNode.SelectSingleNode("Name");
									num4 = -2113089688;
									continue;
								case 18u:
									num8++;
									num4 = -1991472849;
									continue;
								case 5u:
								{
									c = innerText[num8];
									int num10;
									if (!char.IsUpper(c))
									{
										num4 = -377921837;
										num10 = num4;
									}
									else
									{
										num4 = -179918834;
										num10 = num4;
									}
									continue;
								}
								case 19u:
									num8 = 0;
									num4 = (int)(num2 * 1451369474) ^ -1422481671;
									continue;
								case 2u:
								{
									int num13;
									int num14;
									if (xmlNode3 == null)
									{
										num13 = 1679325894;
										num14 = num13;
									}
									else
									{
										num13 = 1568450172;
										num14 = num13;
									}
									num4 = num13 ^ (int)(num2 * 1703492799);
									continue;
								}
								case 9u:
									stringBuilder.Append(c);
									num4 = -520114439;
									continue;
								case 17u:
									_ServerList.Add(xmlNode3.InnerText, xmlNode2.InnerText);
									num4 = (int)(num2 * 34315307) ^ -110680839;
									continue;
								case 1u:
								{
									int num11;
									int num12;
									if (xmlNode2 == null)
									{
										num11 = -1147412883;
										num12 = num11;
									}
									else
									{
										num11 = -450330098;
										num12 = num11;
									}
									num4 = num11 ^ ((int)num2 * -1524464687);
									continue;
								}
								case 13u:
									stringBuilder = new StringBuilder();
									innerText = xmlNode3.InnerText;
									num4 = -1888677108;
									continue;
								case 8u:
								{
									int num9;
									if (num8 >= innerText.Length)
									{
										num4 = -1791877125;
										num9 = num4;
									}
									else
									{
										num4 = -1415836466;
										num9 = num4;
									}
									continue;
								}
								case 3u:
									break;
								case 14u:
									_aCrqUtEobC4JELAJ9SKdNpyMHvF.Add(xmlNode3.InnerText.ToLower(), xmlNode3.InnerText);
									num4 = ((int)num2 * -1020911847) ^ 0x7F06393D;
									continue;
								case 4u:
								{
									int num6;
									int num7;
									if (char.IsDigit(c))
									{
										num6 = -1840462366;
										num7 = num6;
									}
									else
									{
										num6 = -2013936875;
										num7 = num6;
									}
									num4 = num6 ^ ((int)num2 * -2035762521);
									continue;
								}
								case 7u:
									xmlNode2 = xmlNode.SelectSingleNode("DNS");
									num4 = ((int)num2 * -1953929650) ^ -62066553;
									continue;
								case 6u:
									goto end_IL_00ce;
								}
								break;
							}
						}
						end_IL_00ce:;
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
						{
							while (true)
							{
								int num17 = -680833208;
								while (true)
								{
									switch ((num2 = (uint)num17 ^ 0xFC2282E7u) % 3u)
									{
									case 0u:
										break;
									default:
										goto end_IL_0398;
									case 1u:
										goto IL_03c7;
									case 2u:
										goto end_IL_0398;
									}
									break;
									IL_03c7:
									disposable.Dispose();
									num17 = ((int)num2 * -284008395) ^ -1312770521;
								}
							}
						}
						end_IL_0398:;
					}
					if (_ServerList.Count != 0)
					{
						return;
					}
					while (true)
					{
						switch ((num2 = 0xA08123EFu ^ 0xFC2282E7u) % 3u)
						{
						case 0u:
							break;
						default:
							return;
						case 1u:
							throw new Exception("Was not able to parse any RotMG servers!");
						case 2u:
							return;
						}
					}
				}
				}
				break;
				IL_0032:
				xmlDocument = new XmlDocument();
				num = (int)(num2 * 1425265625) ^ -1315739863;
			}
		}
	}
}
