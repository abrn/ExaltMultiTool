using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class _sXxBcxQJ5OZEM8d0AIMUAzcF8In
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _JIEoAuG8OCNXb4FHMfGW1TwWXVn
	{
		public static readonly _JIEoAuG8OCNXb4FHMfGW1TwWXVn _003C_003E9 = new _JIEoAuG8OCNXb4FHMfGW1TwWXVn();

		public static Func<char, bool> _003C_003E9__4_1;

		internal bool _lipIcUcmAhsDO4TVmjbEEG1DBbW(char c)
		{
			if (!char.IsLetterOrDigit(c))
			{
				while (true)
				{
					int num = 212579801;
					while (true)
					{
						uint num2;
						switch ((num2 = (uint)num ^ 0xDE26FE2u) % 4u)
						{
						case 2u:
							break;
						case 3u:
						{
							int num3;
							int num4;
							if (c == '.')
							{
								num3 = -158807755;
								num4 = num3;
							}
							else
							{
								num3 = -694170600;
								num4 = num3;
							}
							num = num3 ^ (int)(num2 * 1129387666);
							continue;
						}
						case 0u:
							return c == '-';
						default:
							goto IL_0061;
						}
						break;
					}
				}
			}
			goto IL_0061;
			IL_0061:
			return true;
		}
	}

	private Client _50w8wVuv8bL5nhKaR2EHxjrTamB;

	private string _ServerHostname;

	public _sXxBcxQJ5OZEM8d0AIMUAzcF8In(Client client)
	{
		while (true)
		{
			int num = 415592121;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x393F6292u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0028;
				case 1u:
					return;
				}
				break;
				IL_0028:
				_50w8wVuv8bL5nhKaR2EHxjrTamB = client;
				num = ((int)num2 * -1553192729) ^ 0x4C688440;
			}
		}
	}

	public void GetServerIP(string ip)
	{
		_ServerHostname = ip;
	}

	public void HandlePlayerCommand(PlayerTextPacket playerText)
	{
		if (!Settings.Default.EnableGotoCommand)
		{
			goto IL_000f;
		}
		goto IL_01d2;
		IL_01d2:
		int num;
		int num2;
		if (playerText._Message.StartsWith("/"))
		{
			num = -184337631;
			num2 = num;
		}
		else
		{
			num = -1517235003;
			num2 = num;
		}
		goto IL_0014;
		IL_0014:
		string[] array = default(string[]);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xE1B2BB24u) % 15u)
			{
			case 13u:
				break;
			default:
				return;
			case 10u:
			{
				int num6;
				int num7;
				if (array[0] == "/ip")
				{
					num6 = 1792502034;
					num7 = num6;
				}
				else
				{
					num6 = 698822585;
					num7 = num6;
				}
				num = num6 ^ ((int)num3 * -985111412);
				continue;
			}
			case 4u:
				goto IL_008d;
			case 3u:
				return;
			case 6u:
				return;
			case 2u:
			{
				_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Server IP: " + _ServerHostname);
				Thread thread = new Thread((ThreadStart)delegate
				{
					Clipboard.SetText(_ServerHostname);
				});
				thread.SetApartmentState(ApartmentState.STA);
				thread.Start();
				num = (int)(num3 * 1103150964) ^ -1716114833;
				continue;
			}
			case 8u:
				playerText._Send = false;
				num = ((int)num3 * -685168380) ^ -671761443;
				continue;
			case 0u:
				array = playerText._Message.Split(' ');
				num = -500983293;
				continue;
			case 7u:
				return;
			case 12u:
			{
				int num8;
				int num9;
				if (array.Length >= 2)
				{
					num8 = -1632455468;
					num9 = num8;
				}
				else
				{
					num8 = -2097540126;
					num9 = num8;
				}
				num = num8 ^ ((int)num3 * -265559845);
				continue;
			}
			case 5u:
			{
				string ip = new string(array[1].Where(delegate(char c)
				{
					if (!char.IsLetterOrDigit(c))
					{
						while (true)
						{
							int num11 = 212579801;
							while (true)
							{
								uint num12;
								switch ((num12 = (uint)num11 ^ 0xDE26FE2u) % 4u)
								{
								case 2u:
									break;
								case 3u:
								{
									int num13;
									int num14;
									if (c == '.')
									{
										num13 = -158807755;
										num14 = num13;
									}
									else
									{
										num13 = -694170600;
										num14 = num13;
									}
									num11 = num13 ^ (int)(num12 * 1129387666);
									continue;
								}
								case 0u:
									return c == '-';
								default:
									goto IL_0061;
								}
								break;
							}
						}
					}
					goto IL_0061;
					IL_0061:
					return true;
				}).ToArray());
				ConnectToHostname(ip);
				num = -828669762;
				continue;
			}
			case 14u:
				goto IL_01d2;
			case 9u:
				playerText._Send = false;
				num = (int)(num3 * 4425787) ^ -440414735;
				continue;
			case 11u:
			{
				int num4;
				int num5;
				if (string.IsNullOrEmpty(array[1]))
				{
					num4 = 2079224214;
					num5 = num4;
				}
				else
				{
					num4 = 1662400866;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -1900441634);
				continue;
			}
			case 1u:
				return;
			}
			break;
			IL_008d:
			int num10;
			if (!(array[0] == "/goto"))
			{
				num = -828669762;
				num10 = num;
			}
			else
			{
				num = -181681680;
				num10 = num;
			}
		}
		goto IL_000f;
		IL_000f:
		num = -513758749;
		goto IL_0014;
	}

	private void ConnectToHostname(string ip)
	{
		string s = Guid.NewGuid().ToString();
		ReconnectPacket reconnectPacket = default(ReconnectPacket);
		ReconnectPacket ourReconnect = default(ReconnectPacket);
		string key = default(string);
		byte[] bytes = default(byte[]);
		while (true)
		{
			int num = 695607180;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1195C44Eu) % 16u)
				{
				case 9u:
					break;
				default:
					return;
				case 14u:
					reconnectPacket._KeyTime = -1;
					num = (int)(num2 * 847301290) ^ -447121975;
					continue;
				case 7u:
					ourReconnect._Port = 2050;
					num = ((int)num2 * -1756224868) ^ -1139738377;
					continue;
				case 5u:
					key = Client._fvjeDdCWCcAa9Yq1lOCAy0ktNXt(bytes);
					ourReconnect = (ReconnectPacket)Packet.CreatePacketFromType(PacketType.RECONNECT);
					num = ((int)num2 * -1850591630) ^ -1298746286;
					continue;
				case 8u:
					ourReconnect._MapName = "Recon";
					num = (int)((num2 * 1540626680) ^ 0x31DA498D);
					continue;
				case 1u:
					_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Connecting to: " + ip);
					num = (int)(num2 * 1503746227) ^ -2081493219;
					continue;
				case 15u:
					reconnectPacket._GameId = -2;
					reconnectPacket._Hostname = "127.0.0.1";
					reconnectPacket._Port = 2050;
					reconnectPacket._IsFromArena = false;
					num = ((int)num2 * -1141512054) ^ 0x5D95DADC;
					continue;
				case 13u:
					ourReconnect._IsFromArena = false;
					num = (int)((num2 * 896203018) ^ 0x26D443D0);
					continue;
				case 11u:
					reconnectPacket._MapName = "Realm";
					_50w8wVuv8bL5nhKaR2EHxjrTamB._DumVMPhENnNVyQvhZaHdKZdaaMD._JlhuftEwIx9QqEcmrh5juOLuNhE.TryAdd(key, ourReconnect);
					num = ((int)num2 * -1731393153) ^ 0x10B3F5A;
					continue;
				case 6u:
					ourReconnect._GameId = -2;
					ourReconnect._Hostname = ip;
					num = ((int)num2 * -2103217220) ^ -228243231;
					continue;
				case 12u:
					ourReconnect._Key = new byte[0];
					ourReconnect._KeyTime = -1;
					num = ((int)num2 * -702639827) ^ -505394950;
					continue;
				case 0u:
					_50w8wVuv8bL5nhKaR2EHxjrTamB.SendToClient(reconnectPacket);
					num = (int)(num2 * 2145446387) ^ -379275228;
					continue;
				case 4u:
					reconnectPacket._Key = bytes;
					num = (int)((num2 * 2141346971) ^ 0x316C309C);
					continue;
				case 3u:
					reconnectPacket = (ReconnectPacket)Packet.CreatePacketFromType(PacketType.RECONNECT);
					num = (int)(num2 * 126422092) ^ -2068186299;
					continue;
				case 2u:
					bytes = Encoding.ASCII.GetBytes(s);
					num = ((int)num2 * -268025994) ^ 0x189A11A7;
					continue;
				case 10u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void CopyIPToClipboard()
	{
		Clipboard.SetText(_ServerHostname);
	}
}
