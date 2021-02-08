using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ExaltMultiTool;

internal class InjectionHelper {
	private static readonly string _PyAy1AUj53IAIhfdIDSm8z1dUPT;

	private static readonly string _cdyBaJMdzdveeFZzPT2GyKrT35Z;

	public static List<int> _xybJ0vsmMJNJo4QA7CWP9YTKANn;

	static InjectionHelper()
	{
		_PyAy1AUj53IAIhfdIDSm8z1dUPT = Path.Combine(Path.GetTempPath(), "rs.dll");
		string text2 = default(string);
		while (true) {
			int num = -995533425;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0xFA58FFC0u) % 5u) {
					case 0u:
						break;
					case 4u:
						_cdyBaJMdzdveeFZzPT2GyKrT35Z = Path.Combine(Path.GetTempPath(), "rsl.dll");
						_xybJ0vsmMJNJo4QA7CWP9YTKANn = new List<int>();
						num = ((int) num2 * -1184945543) ^ 0x4C211F8E;
						continue;
					case 3u:
						text2 = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".old");
						num = ((int) num2 * -1715959244) ^ 0x5E054CFA;
						continue;
					case 2u:
						if (File.Exists(_PyAy1AUj53IAIhfdIDSm8z1dUPT)) {
							num = ((int) num2 * -492639244) ^ 0x4B1070D5;
							continue;
						}

						goto IL_0189;
					default: {
						string text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".old");

						File.Move(_PyAy1AUj53IAIhfdIDSm8z1dUPT, text2);
						File.Move(_cdyBaJMdzdveeFZzPT2GyKrT35Z, text);
						try {
							File.Delete(text2);
							File.Delete(text);
						}
						catch {
							Program.LogNetworkInfo("core", "Old lib is in use...");
						}

						goto IL_0189;
					}
						IL_0189:
						File.WriteAllBytes(_PyAy1AUj53IAIhfdIDSm8z1dUPT,
							Resources.ExaltKit);
						while (true) {
							int num5 = -496090244;
							while (true) {
								switch ((num2 = (uint) num5 ^ 0xFA58FFC0u) % 3u) {
									case 2u:
										break;
									case 1u:
										goto IL_01ba;
									default:
										AppDomain.CurrentDomain.ProcessExit += _81EDGjH7DiJ0M2nDBOho1QbOi3i;
										return;
								}

								break;
								IL_01ba:
								File.WriteAllBytes(_cdyBaJMdzdveeFZzPT2GyKrT35Z,
									Resources.ExaltKitLauncher);
								num5 = (int) ((num2 * 2056268191) ^ 0xA2CE205);
							}
						}
				}

				break;
			}
		}
	}

	private static void _81EDGjH7DiJ0M2nDBOho1QbOi3i(object sender, EventArgs e)
	{
		try {
			File.Delete(_PyAy1AUj53IAIhfdIDSm8z1dUPT);
			File.Delete(_cdyBaJMdzdveeFZzPT2GyKrT35Z);
		}
		catch {
			Program.LogNetworkInfo("core", "Lib is in use...");
		}
	}

	public static bool _sMhhfUgb6MrcF41LT6KCITIMEBjA(bool steam)
	{
		try {
			if (!steam) {
				IL_0003:
				num = 817047041;
				goto IL_0008;
			}

			string path = Settings.Default.ExaltSteamPath;
			goto IL_003b;
			IL_0025:
			path = Settings.Default.ExaltLauncherPath;
			goto IL_003b;
			IL_003b:
			ProcessInjection._zjgiwwJZUA8aZTeMCSZeihp47Dw zjgiwwJZUA8aZTeMCSZeihp47Dw =
				_KgZs1nuPvFKfOIInCAin5WfVfsb(path, string.Empty);
			_0kO1k5GUTQHAW84jJNygXOtABJW(zjgiwwJZUA8aZTeMCSZeihp47Dw._QjPrTpWj4dJdFgwgkKtVC8NhIyC,
				_cdyBaJMdzdveeFZzPT2GyKrT35Z);
			ProcessInjection._kQdGqTbeSNpbEs07G8GfCURPn6cA(zjgiwwJZUA8aZTeMCSZeihp47Dw
				._JwYWFGBftDuvPOaDpMAqYYZmRpM);
			int num = 344324600;
			goto IL_0008;
			IL_0008:
			uint num2;
			switch ((num2 = (uint) num ^ 0x2FF73170u) % 3u) {
				case 0u:
					break;
				case 1u:
					goto IL_0025;
				default:
					return true;
			}
		}
		catch (Exception ex) {
			string obj = ex?.ToString();
			MessageBox.Show("Failed to start Exalt Launcher:\n" + obj + "\nLast Error: " + Marshal.GetLastWin32Error(),
				"RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	public static bool _xkSr2Dl3BGfiJPH2Sb33zOcYN0P(string guid, string password)
	{
		try {
			ProcessInjection._zjgiwwJZUA8aZTeMCSZeihp47Dw zjgiwwJZUA8aZTeMCSZeihp47Dw =
				_KgZs1nuPvFKfOIInCAin5WfVfsb(Settings.Default.ExaltGamePath,
					GetFormattedCredentials(guid, password));
			_0kO1k5GUTQHAW84jJNygXOtABJW(zjgiwwJZUA8aZTeMCSZeihp47Dw._QjPrTpWj4dJdFgwgkKtVC8NhIyC,
				_PyAy1AUj53IAIhfdIDSm8z1dUPT);
			ProcessInjection._kQdGqTbeSNpbEs07G8GfCURPn6cA(zjgiwwJZUA8aZTeMCSZeihp47Dw
				._JwYWFGBftDuvPOaDpMAqYYZmRpM);
			return true;
		}
		catch (Exception ex) {
			MessageBox.Show(
				"Failed to start Exalt Game:\n" + ex?.ToString() + "\nLast Error: " + Marshal.GetLastWin32Error(),
				"RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
	}

	private static ProcessInjection._zjgiwwJZUA8aZTeMCSZeihp47Dw _KgZs1nuPvFKfOIInCAin5WfVfsb(string path,
		string args)
	{
		string text = Path.Combine(Path.GetDirectoryName(path), "UnityCrashHandler64.exe");
		string text2 =
			Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\RealmOfTheMadGod\\Production",
				"UnityCrashHandler64.exe");
		uint num3;
		try {
			if (File.Exists(text)) {
				goto IL_0034;
			}

			goto IL_008b;
			IL_008b:
			int num;
			int num2;
			if (File.Exists(text2)) {
				num = 529988894;
				num2 = num;
			}
			else {
				num = 1630349562;
				num2 = num;
			}

			goto IL_0039;
			IL_0039:
			while (true) {
				switch ((num3 = (uint) num ^ 0x44DC41C7u) % 5u) {
					case 2u:
						break;
					default:
						goto end_IL_002c;
					case 1u:
						File.Delete(text);
						num = (int) ((num3 * 1621851804) ^ 0x70CC75E5);
						continue;
					case 0u:
						File.Delete(text2);
						num = (int) (num3 * 691057605) ^ -854448889;
						continue;
					case 3u:
						goto IL_008b;
					case 4u:
						goto end_IL_002c;
				}

				break;
			}

			goto IL_0034;
			IL_0034:
			num = 717499741;
			goto IL_0039;
			end_IL_002c: ;
		}
		catch (Exception innerException) {
			throw new Exception(
				"PLEASE DELETE THE FOLLOWING FILES TO MAKE IT WORK:\n- " + text + "\n- " + text2 +
				"\n\nOnly if they exist.", innerException);
		}

		ProcessInjection._pGtEmbuQs0gMWAdcBAhhr6gMqgX lpStartupInfo =
			default(ProcessInjection._pGtEmbuQs0gMWAdcBAhhr6gMqgX);
		if (!ProcessInjection._Ke0Dh6gvqJBjghnfyca8KN8GfxC(path, args, IntPtr.Zero, IntPtr.Zero,
			bInheritHandles: true, 4u, IntPtr.Zero, IntPtr.Zero, ref lpStartupInfo, out var lpProcessInformation)) {
			goto IL_0106;
		}

		goto IL_0148;
		IL_0106:
		int num4 = 778529178;
		goto IL_010b;
		IL_0148:
		_xybJ0vsmMJNJo4QA7CWP9YTKANn.Add(lpProcessInformation._Xfy86MzBYkDHYV6eC0jeyWpmMqW);
		num4 = 1395666657;
		goto IL_010b;
		IL_010b:
		switch ((num3 = (uint) num4 ^ 0x44DC41C7u) % 4u) {
			case 3u:
				break;
			case 1u:
				throw new Exception("CreateProcess");
			case 0u:
				goto IL_0148;
			default:
				Program.LogInfoMessage("core", "Started Process: " + path);
				return lpProcessInformation;
		}

		goto IL_0106;
	}

	private static void _0kO1k5GUTQHAW84jJNygXOtABJW(IntPtr pHandle, string path)
	{
		//Discarded unreachable code: IL_0115, IL_0133, IL_019f
		byte[] bytes = Encoding.Default.GetBytes(path);
		uint lpNumberOfBytesWritten = 0u;
		uint lpThreadId = 0u;
		IntPtr intPtr2 = default(IntPtr);
		IntPtr intPtr = default(IntPtr);
		while (true) {
			int num = 723786822;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0x36BD24C3u) % 11u) {
					case 4u:
						break;
					case 7u: {
						int num6;
						int num7;
						if (!(intPtr2 == IntPtr.Zero)) {
							num6 = 202654642;
							num7 = num6;
						}
						else {
							num6 = 1295378471;
							num7 = num6;
						}

						num = num6 ^ (int) (num2 * 92227725);
						continue;
					}
					case 3u: {
						IntPtr intPtr3 = ProcessInjection._KueE2yTPEjNDAJT08H2DGsGNt7N(pHandle, IntPtr.Zero,
							0u, intPtr, intPtr2, 0u, ref lpThreadId);
						if (intPtr3 == IntPtr.Zero) {
							throw new Exception("CreateRemoteThread");
						}

						ProcessInjection._PxyT4CEJyj4HnJ5DrPzPmhvvhIM(intPtr3, uint.MaxValue);
						ProcessInjection._ncvsNr9oXhkaIirRo2KAJ4c9g4y(intPtr3);
						num = 81467254;
						continue;
					}
					case 0u:
						intPtr2 = ProcessInjection._N0XwljYi7pJKWgAAdvUmfa7ccXE(pHandle, IntPtr.Zero,
							(uint) bytes.Length, 12288u, 64u);
						num = 1319501678;
						continue;
					case 8u:
						intPtr = ProcessInjection._zqkXaS0fbgW5SfjaOy5EpA6o5N1(
							ProcessInjection._MpECyuu0ww9WE1mc2JaGfXy7YeQ("kernel32.dll"), "LoadLibraryA");
						num = ((int) num2 * -326581998) ^ 0x1653E0B7;
						continue;
					case 9u:
						throw new Exception("VirtualAllocEx");
					case 10u:
						throw new Exception("GetProcAddress");
					case 5u: {
						int num5;
						if (!ProcessInjection._O8k7xYpkG5pQyqFh433YTQ9woVE(pHandle, intPtr2, bytes,
							(uint) bytes.Length, ref lpNumberOfBytesWritten)) {
							num = 1164344880;
							num5 = num;
						}
						else {
							num = 1644889787;
							num5 = num;
						}

						continue;
					}
					case 2u: {
						int num3;
						int num4;
						if (!(intPtr == IntPtr.Zero)) {
							num3 = -852549433;
							num4 = num3;
						}
						else {
							num3 = -1621898582;
							num4 = num3;
						}

						num = num3 ^ (int) (num2 * 1039310759);
						continue;
					}
					case 1u:
						throw new Exception("WriteProcessMemory");
					default:
						Program.LogInfoMessage("core",
							$"Injected Successfully: {pHandle} {path}");
						return;
				}

				break;
			}
		}
	}

	private static string GetFormattedCredentials(string guid, string password)
	{
		string text = ConvertToBase64(password);
		string value = default(string);
		string text2 = default(string);
		while (true) {
			int num = -1604878215;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0xDF6869D3u) % 8u) {
					case 4u:
						break;
					case 6u: {
						string[] array = guid.Split(':');
						if (array.Length != 2) {
							throw new Exception("Malformed Steam GUID: " + guid);
						}

						value = ConvertToBase64(array[1]);
						num = -205990524;
						continue;
					}
					case 3u:
						text2 = ConvertToBase64(guid);
						num = (int) ((num2 * 161787779) ^ 0x3D995F9B);
						continue;
					case 0u:
						text2 = ConvertToBase64(guid);
						num = ((int) num2 * -639367618) ^ 0x52E3727D;
						continue;
					case 2u: {
						int num3;
						int num4;
						if (!guid.Contains("@")) {
							num3 = 1843780762;
							num4 = num3;
						}
						else {
							num3 = 1341432844;
							num4 = num3;
						}

						num = num3 ^ ((int) num2 * -550178934);
						continue;
					}
					case 5u:
						guid = guid.Replace("steamworks_", "steamworks:");
						num = -667744317;
						continue;
					case 1u:
						return "data:{platform:Deca,password:" + text + ",guid:" + text2 + ",env:4}";
					default: {
						StringBuilder stringBuilder = new StringBuilder("data:{platform:Steam,env:4");
						stringBuilder.Append(",guid:");
						stringBuilder.Append(text2);
						stringBuilder.Append(",secret:");
						stringBuilder.Append(text);
						stringBuilder.Append(",steamId:");
						stringBuilder.Append(value);
						stringBuilder.Append(",platformToken:");
						stringBuilder.Append(ConvertToBase64(""));
						return stringBuilder.ToString();
					}
				}

				break;
			}
		}
	}

	private static string ConvertToBase64(string plainText)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
	}
}