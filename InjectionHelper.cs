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

	public static List<int> _ProcessIds;

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
						_ProcessIds = new List<int>();
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
										AppDomain.CurrentDomain.ProcessExit += DeleteLibraries;
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

	private static void DeleteLibraries(object sender, EventArgs e)
	{
		try {
			File.Delete(_PyAy1AUj53IAIhfdIDSm8z1dUPT);
			File.Delete(_cdyBaJMdzdveeFZzPT2GyKrT35Z);
		}
		catch {
			Program.LogNetworkInfo("core", "Lib is in use...");
		}
	}

	public static bool StartExaltLauncher(bool steam)
	{
		try {
			if (!steam) {
				IL_0003:
				num = 817047041;
				goto IL_0008;
				
				path = Settings.Default.ExaltLauncherPath;
				
			}

			string path = Settings.Default.ExaltSteamPath;
			goto IL_003b;
			IL_0025:
			path = Settings.Default.ExaltLauncherPath;
			goto IL_003b;
			IL_003b:
			ProcessInjection.ProcessInfo processInfo =
				GetProcessInfo(path, string.Empty);
			InjectProcessHandle(processInfo.ProcHandle,
				_cdyBaJMdzdveeFZzPT2GyKrT35Z);
			ProcessInjection.ResumeThread(processInfo
				.ProcThread);
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

	public static bool StartExalt(string guid, string password)
	{
		try {
			ProcessInjection.ProcessInfo processInfo =
				GetProcessInfo(Settings.Default.ExaltGamePath,
					GetFormattedCredentials(guid, password));
			InjectProcessHandle(processInfo.ProcHandle,
				_PyAy1AUj53IAIhfdIDSm8z1dUPT);
			ProcessInjection.ResumeThread(processInfo
				.ProcThread);
			return true;
		}
		catch (Exception ex) {
			MessageBox.Show(
				"Failed to start Exalt Game:\n" + ex?.ToString() + "\nLast Error: " + Marshal.GetLastWin32Error(),
				"RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
	}

	private static ProcessInjection.ProcessInfo GetProcessInfo(string path,
		string args)
	{
		string text = Path.Combine(Path.GetDirectoryName(path) ?? string.Empty, "UnityCrashHandler64.exe");
		string text2 = Path.Combine(
				Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\RealmOfTheMadGod\\Production",
				"UnityCrashHandler64.exe");
		uint num3;
		try {
			if (File.Exists(text)) {
				File.Delete(text);
			}
			if (File.Exists(text2)) {
				num = 529988894;
				num2 = num;
				// goto 0
				File.Delete(text2);
			}

			goto IL_0039;
			IL_0039:
			while (true) {
				// goto 1
				switch ((num3 = (uint) num ^ 0x44DC41C7u) % 5u) {
					case 2u:
						break;
					case 1u:
						
						num = (int) ((num3 * 1621851804) ^ 0x70CC75E5);
						// goto 3
						continue;
					case 0u:
						File.Delete(text2);
						num = (int) (num3 * 691057605) ^ -854448889;
						continue;
					case 3u:
						int num;
						int num2;
						if (File.Exists(text2)) {
							num = 529988894;
							num2 = num;
							// goto 0
						}
				}

				break;
			}

			goto IL_0034;
			IL_0034:
			num = 717499741;
			goto IL_0039;
		}
		catch (Exception innerException) {
			throw new Exception(
				"PLEASE DELETE THE FOLLOWING FILES TO MAKE IT WORK:\n- " + text + "\n- " + text2 +
				"\n\nOnly if they exist.", innerException);
		}

		ProcessInjection.ProcStartupInfo lpStartupInfo =
			default(ProcessInjection.ProcStartupInfo);
		if (!ProcessInjection.CreateProc(path, args, IntPtr.Zero, IntPtr.Zero,
			bInheritHandles: true, 4u, IntPtr.Zero, IntPtr.Zero, ref lpStartupInfo, out var lpProcessInformation)) {
			goto IL_0106;
		}

		goto IL_0148;
		IL_0106:
		int num4 = 778529178;
		goto IL_010b;
		IL_0148:
		_ProcessIds.Add(lpProcessInformation._Xfy86MzBYkDHYV6eC0jeyWpmMqW);
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

	private static void InjectProcessHandle(IntPtr pHandle, string path)
	{
		var bytes = Encoding.Default.GetBytes(path);
		var lpNumberOfBytesWritten = 0u;
		var lpThreadId = 0u;

		var intPtr = ProcessInjection.GetProcAddrPtr(
			ProcessInjection.GetModuleHandlePtr("kernel32.dll"), "LoadLibraryA");

		if (intPtr == IntPtr.Zero) throw new Exception("GetProcAddress");
		var intPtr2 = ProcessInjection.VirtualAllocExPtr(pHandle, IntPtr.Zero,
			(uint) bytes.Length, 12288u, 64u);

		if (intPtr2 == IntPtr.Zero) throw new Exception("VirtualAllocEx");
		if (!ProcessInjection.WriteProcMemory(pHandle, intPtr2, bytes,
			(uint) bytes.Length, ref lpNumberOfBytesWritten)) {
			Program.LogInfoMessage("core",
				$"Injected Successfully: {pHandle} {path}");
			return;
		}

		IntPtr intPtr3 = ProcessInjection.CreateRemoteThrdPtr(pHandle, IntPtr.Zero,
			0u, intPtr, intPtr2, 0u, ref lpThreadId);
		if (intPtr3 == IntPtr.Zero) {
			throw new Exception("CreateRemoteThread");
		}

		ProcessInjection.WaitForObj(intPtr3, uint.MaxValue);
		ProcessInjection.CloseHandle(intPtr3);
		Program.LogInfoMessage("core",
			$"Injected Successfully: {pHandle} {path}");

		// throw new Exception("WriteProcessMemory");
	}

	private static string GetFormattedCredentials(string guid, string password)
	{
		var text = ConvertToBase64(password);
		string guidBase64 = default;

		if (!guid.Contains("@")) {
			guid = guid.Replace("steamworks_", "steamworks:");
			guidBase64 = ConvertToBase64(guid);

			string[] array = guid.Split(':');
			if (array.Length != 2) {
				throw new Exception("Malformed Steam GUID: " + guid);
			}

			var value = ConvertToBase64(array[1]);
			StringBuilder stringBuilder = new StringBuilder("data:{platform:Steam,env:4");
			stringBuilder.Append(",guid:");
			stringBuilder.Append(guidBase64);
			stringBuilder.Append(",secret:");
			stringBuilder.Append(text);
			stringBuilder.Append(",steamId:");
			stringBuilder.Append(value);
			stringBuilder.Append(",platformToken:");
			stringBuilder.Append(ConvertToBase64(""));
			return stringBuilder.ToString();
		}

		guidBase64 = ConvertToBase64(guid);
		return "data:{platform:Deca,password:" + text + ",guid:" + guidBase64 + ",env:4}";
	}

	private static string ConvertToBase64(string plainText)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
	}
}