using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ExaltMultiTool;

internal class InjectionHelper {
	private static readonly string RsDll;

	private static readonly string RslDll;

	public static List<int> ProcessIds;

	static InjectionHelper()
	{
		RsDll = Path.Combine(Path.GetTempPath(), "rs.dll");
		RslDll = Path.Combine(Path.GetTempPath(), "rsl.dll");
		ProcessIds = new List<int>();
		
		if (File.Exists(RsDll)) {
			var text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".old");
			var text2 = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + ".old");
			
			File.Move(RsDll, text2);
			File.Move(RslDll, text);
			try {
				File.Delete(text2);
				File.Delete(text);
			}
			catch {
				Program.LogNetworkInfo("core", "Old lib is in use...");
			}
		}
		File.WriteAllBytes(RslDll, Resources.ExaltKitLauncher);
		File.WriteAllBytes(RsDll, Resources.ExaltKit);
		AppDomain.CurrentDomain.ProcessExit += DeleteLibraries;
	}

	private static void DeleteLibraries(object sender, EventArgs e)
	{
		try {
			File.Delete(RsDll);
			File.Delete(RslDll);
		}
		catch {
			Program.LogNetworkInfo("core", "Lib is in use...");
		}
	}

	public static bool StartExaltLauncher(bool steam)
	{
		try
		{
			ProcessInjection.ProcessInfo processInfo = GetProcessInfo(steam ? Settings.Default.ExaltSteamPath : Settings.Default.ExaltLauncherPath, string.Empty);
			InjectProcessHandle(processInfo.ProcHandle, RslDll);
			ProcessInjection.ResumeThread(processInfo.ProcThread);
			return true;
		}
		catch (Exception ex)
		{
			MessageBox.Show("Failed to start Exalt Launcher:\n" + ex?.ToString() + "\nLast Error: " + Marshal.GetLastWin32Error(), "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
	}

	public static bool StartExalt(string guid, string password)
	{
		try {
			ProcessInjection.ProcessInfo processInfo = GetProcessInfo(Settings.Default.ExaltGamePath, GetFormattedCredentials(guid, password));
			InjectProcessHandle(processInfo.ProcHandle, RsDll);
			ProcessInjection.ResumeThread(processInfo.ProcThread);
			return true;
		}
		catch (Exception ex) {
			MessageBox.Show(
				"Failed to start Exalt Game:\n" + ex?.ToString() + "\nLast Error: " + Marshal.GetLastWin32Error(),
				"RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			return false;
		}
	}

	private static ProcessInjection.ProcessInfo GetProcessInfo(string path, string args)
	{
		var text = Path.Combine(Path.GetDirectoryName(path) ?? string.Empty, "UnityCrashHandler64.exe");
		var text2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\RealmOfTheMadGod\\Production", "UnityCrashHandler64.exe");
		try
		{
			if (File.Exists(text))
			{
				File.Delete(text);
			}
			if (File.Exists(text2))
			{
				File.Delete(text2);
			}
		}
		catch (Exception innerException)
		{
			throw new Exception("PLEASE DELETE THE FOLLOWING FILES TO MAKE IT WORK:\n- " + text + "\n- " + text2 + "\n\nOnly if they exist.", innerException);
		}
		
		ProcessInjection.ProcStartupInfo lpStartupInfo = default;
		if (!ProcessInjection.CreateProc(path, args, IntPtr.Zero, IntPtr.Zero, bInheritHandles: true, 4u, IntPtr.Zero, IntPtr.Zero, ref lpStartupInfo, out var lpProcessInformation)) {
			throw new Exception("CreateProcess");
		}
		
		ProcessIds.Add(lpProcessInformation._Xfy86MzBYkDHYV6eC0jeyWpmMqW);
		Program.LogInfoMessage("core", "Started Process: " + path);
		return lpProcessInformation;
	}

	private static void InjectProcessHandle(IntPtr pHandle, string path)
	{
		var bytes = Encoding.Default.GetBytes(path);
		var lpNumberOfBytesWritten = 0u;
		var lpThreadId = 0u;

		IntPtr procAddress = ProcessInjection.GetProcAddrPtr(ProcessInjection.GetModuleHandlePtr("kernel32.dll"), "LoadLibraryA");
		if (procAddress == IntPtr.Zero) throw new Exception("GetProcAddress");
		
		var intPtr = ProcessInjection.VirtualAllocExPtr(pHandle, IntPtr.Zero, (uint) bytes.Length, 12288u, 64u);
		if (intPtr == IntPtr.Zero) throw new Exception("VirtualAllocEx");
		
		if (!ProcessInjection.WriteProcMemory(pHandle, intPtr, bytes, (uint) bytes.Length, ref lpNumberOfBytesWritten)) {
			throw new Exception("WriteProcessMemory");
		}
		
		IntPtr intPtr2 = ProcessInjection.CreateRemoteThrdPtr(pHandle, IntPtr.Zero,
			0u, intPtr, intPtr, 0u, ref lpThreadId);
		if (intPtr2 == IntPtr.Zero) {
			throw new Exception("CreateRemoteThread");
		}

		ProcessInjection.WaitForObj(intPtr2, uint.MaxValue);
		ProcessInjection.CloseHandle(intPtr2);
		Program.LogInfoMessage("core", $"Injected Successfully: {pHandle} {path}");
	}

	private static string GetFormattedCredentials(string guid, string password)
	{
		var text = ConvertToBase64(password);
		string guidBase64;

		if (!guid.Contains("@")) {
			guid = guid.Replace("steamworks_", "steamworks:");
			guidBase64 = ConvertToBase64(guid);

			var array = guid.Split(':');
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