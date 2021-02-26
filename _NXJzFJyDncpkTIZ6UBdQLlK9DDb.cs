using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using ExaltMultiTool;

internal class _NXJzFJyDncpkTIZ6UBdQLlK9DDb
{
	private const int _oEFoQ1HgCzc5TKzHp8oAyolQSSH = 513;

	private const int _PXPZ6uDcfHG7EfYnwY7secPIfmD = 514;

	private Client _50w8wVuv8bL5nhKaR2EHxjrTamB;

	private DateTime _lk4TXx0LrA0Y1fFpntuJjMzmkAb = DateTime.Now;

	private WorldPosData _LAY5qDOXeCwwE8WGSZkOMs9oNKh = WorldPosData.Initial;

	[DllImport("user32.dll", EntryPoint = "PostMessage")]
	private static extern bool _pJUJvZoXSjrgx8QMiXvHh3JZaJF(IntPtr hWnd, uint Msg, int wParam, int lParam);

	public _NXJzFJyDncpkTIZ6UBdQLlK9DDb(Client client)
	{
		while (true)
		{
			int num = -1276601446;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCC7AA0A9u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_003e;
				case 1u:
					return;
				}
				break;
				IL_003e:
				_50w8wVuv8bL5nhKaR2EHxjrTamB = client;
				num = (int)(num2 * 1630030542) ^ -1452032125;
			}
		}
	}

	public void _tX4Fl2mBYL4XNqNEIW0OPnopM9i(MovePacket move)
	{
		//Discarded unreachable code: IL_0095
		if (!Settings.Default.EnableAntiAFK)
		{
			goto IL_000f;
		}
		goto IL_019b;
		IL_019b:
		DateTime now = DateTime.Now;
		int num;
		int num2;
		if (_LAY5qDOXeCwwE8WGSZkOMs9oNKh._PositionX != move._NewPosition._PositionX)
		{
			num = -893787978;
			num2 = num;
		}
		else
		{
			num = -1561388819;
			num2 = num;
		}
		goto IL_0014;
		IL_0014:
		Process[] processesByName = default(Process[]);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xBC60D0C9u) % 11u)
			{
			case 0u:
				break;
			default:
				return;
			case 5u:
			{
				int num6;
				int num7;
				if (_LAY5qDOXeCwwE8WGSZkOMs9oNKh._PositionY != move._NewPosition._PositionY)
				{
					num6 = -1515855326;
					num7 = num6;
				}
				else
				{
					num6 = -511799426;
					num7 = num6;
				}
				num = num6 ^ ((int)num3 * -1746480963);
				continue;
			}
			case 9u:
				_lk4TXx0LrA0Y1fFpntuJjMzmkAb = now;
				num = -1805755535;
				continue;
			case 2u:
				return;
			case 10u:
				goto IL_00a7;
			case 4u:
				_pJUJvZoXSjrgx8QMiXvHh3JZaJF(processesByName.First().MainWindowHandle, 513u, 1, 1);
				Thread.Sleep(32);
				_pJUJvZoXSjrgx8QMiXvHh3JZaJF(processesByName.First().MainWindowHandle, 514u, 0, 1);
				num = ((int)num3 * -586613325) ^ -809795664;
				continue;
			case 3u:
			{
				_lk4TXx0LrA0Y1fFpntuJjMzmkAb = now;
				processesByName = Process.GetProcessesByName("RotMG Exalt");
				int num4;
				int num5;
				if (!processesByName.Any())
				{
					num4 = 1115580018;
					num5 = num4;
				}
				else
				{
					num4 = 688981905;
					num5 = num4;
				}
				num = num4 ^ ((int)num3 * -1937885201);
				continue;
			}
			case 6u:
				_LAY5qDOXeCwwE8WGSZkOMs9oNKh = move._NewPosition;
				num = (int)(num3 * 849265353) ^ -1527796078;
				continue;
			case 8u:
				Program._JWptdPwuTlZYlLpGrinhw8DeS3h("client", "Activating Anti AFK");
				num = ((int)num3 * -1373275299) ^ -1315480851;
				continue;
			case 7u:
				goto IL_019b;
			case 1u:
				return;
			}
			break;
			IL_00a7:
			int num8;
			if (!(now.Subtract(_lk4TXx0LrA0Y1fFpntuJjMzmkAb) > TimeSpan.FromMinutes(5.0)))
			{
				num = -2023818197;
				num8 = num;
			}
			else
			{
				num = -1136649474;
				num8 = num;
			}
		}
		goto IL_000f;
		IL_000f:
		num = -1588894782;
		goto IL_0014;
	}
}
