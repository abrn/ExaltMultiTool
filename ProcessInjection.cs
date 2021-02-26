using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal static class ProcessInjection
{
	internal struct PipeAttributes
	{
		public int _mEbPYUUehKpduXYDS9B1ORcMJaN;

		public IntPtr _hcwH4Fm4tBiDnVSAtMMdVsfd2tB;

		public int _GEcCGP3uzQHyvjpOoZfeVh1Uzl;
	}

	internal enum Win32AccessErrorCodes
	{
		All = 2035711,
		Terminate = 1,
		CreateThread = 2,
		VirtualMemoryOperation = 8,
		VirtualMemoryRead = 0x10,
		VirtualMemoryWrite = 0x20,
		DuplicateHandle = 0x40,
		CreateProcess = 0x80,
		SetQuota = 0x100,
		SetInformation = 0x200,
		QueryInformation = 0x400,
		QueryLimitedInformation = 0x1000,
		Synchronize = 0x100000
	}

	internal enum MemorySetType
	{
		MEM_COMMIT = 0x1000,
		MEM_RESERVE = 0x2000,
		MEM_RESET = 0x80000,
		MEM_RESET_UNDO = 0x1000000,
		SecCommit = 0x8000000
	}

	internal enum Win32AccessPermissions
	{
		PAGE_EXECUTE = 0x10,
		PAGE_EXECUTE_READ = 0x20,
		PAGE_EXECUTE_READWRITE = 0x40,
		PAGE_EXECUTE_WRITECOPY = 0x80,
		PAGE_NOACCESS = 1,
		PAGE_READONLY = 2,
		PAGE_READWRITE = 4,
		PAGE_WRITECOPY = 8,
		PAGE_TARGETS_INVALID = 0x40000000,
		PAGE_TARGETS_NO_UPDATE = 0x40000000
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct ProcStartupInfo
	{
		public int _mdWEP8NZZlu3FiC9tO1hmdgtuYf;

		public string _9bUAN6pqJ746euXmG8pCJScURInA;

		public string _FEvOIOopDC0rRiMx4AEguyMh22d;

		public string _yY1dKISMb9UZA67sMr6fojWx93t;

		public int _YjRLRQzBa9AwCdQL6WR4Ji5xaXk;

		public int _pxZvhL1aUkuXSGUpU9OpxM4pl0A;

		public int _hmOc8H6fAYBctF2WaLIrEd4DVqd;

		public int _SEL0ujY9Z4F6Le2fJzhAbbtrXcA;

		public int _1svglca7LWIzv7JF4caYJ1HOZXA;

		public int _5occC5eN01FGiEYEXDu6ktsV2JK;

		public int _yEUjhTSulqon13pYWQnZgVy02O;

		public int _Qs9VjQFrP19Alh9WuC7FrIBGOqBA;

		public short _XHAbIdiIhxJpoT1yp9iDJd9ILkk;

		public short _6ASQR98UpY2bVge5q9Jz1VewbVf;

		public IntPtr _aCkol9wfrhIrG0BW0vXHAXaCQGA;

		public IntPtr _PRNALmtgOR4clx3BlOu7t4aChOab;

		public IntPtr _Bk7unpL6GtDgyueJi8COGoF61MG;

		public IntPtr _yMCAg5Qr3jEREKHfwkloM16c9Xm;
	}

	internal struct ProcessInfo
	{
		public IntPtr ProcHandle;

		public IntPtr ProcThread;

		public int _Xfy86MzBYkDHYV6eC0jeyWpmMqW;

		public int _VfdJwuvT8GagDI6chBlDFH20VjJ;
	}

	private struct ScreenPosition
	{
		public int PosLeft;

		public int PosTop;

		public int PosRight;

		public int PosBottom;

		internal ScreenPosition(int left, int top, int right, int bottom)
		{
			PosLeft = left;
			PosTop = top;
			PosRight = right;
			PosBottom = bottom;
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "GetConsoleWindow")]
	public static extern IntPtr GetConsoleWindowPtr();

	[DllImport("user32.dll", EntryPoint = "ShowWindow")]
	public static extern bool WindowShown(IntPtr hWnd, int nCmdShow);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CreatePipe", SetLastError = true)]
	public static extern bool CreatePipe(out IntPtr hReadPipe, out IntPtr hWritePipe, ref PipeAttributes lpPipeAttributes, int nSize);

	[DllImport("kernel32.dll", EntryPoint = "GetStdHandle", SetLastError = true)]
	public static extern IntPtr GetStdHandlePtr(int nStdHandle);

	[DllImport("user32.dll", EntryPoint = "SetProcessDPIAware", SetLastError = true)]
	public static extern bool SetProcDPIAware();

	[DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool AllocConsole();

	[DllImport("user32.dll", EntryPoint = "RegisterHotKey")]
	public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

	[DllImport("user32.dll", EntryPoint = "UnregisterHotKey")]
	public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

	[DllImport("Kernel32", EntryPoint = "OpenProcess", SetLastError = true)]
	public static extern IntPtr OpenProcessPtr(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	[DllImport("kernel32", EntryPoint = "GetProcAddress", SetLastError = true)]
	public static extern IntPtr GetProcAddrPtr(IntPtr hModule, string procName);

	[DllImport("kernel32.dll", EntryPoint = "GetModuleHandleA", SetLastError = true)]
	public static extern IntPtr GetModuleHandlePtr(string lpModuleName);

	[DllImport("Kernel32", EntryPoint = "VirtualAllocEx", SetLastError = true)]
	public static extern IntPtr VirtualAllocExPtr(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[DllImport("Kernel32", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	public static extern bool WriteProcMemory(IntPtr hProcess, IntPtr lpBaseAddress, [MarshalAs(UnmanagedType.AsAny)] object lpBuffer, uint nSize, ref uint lpNumberOfBytesWritten);

	[DllImport("Kernel32", EntryPoint = "CreateRemoteThread", SetLastError = true)]
	public static extern IntPtr CreateRemoteThrdPtr(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, ref uint lpThreadId);

	[DllImport("Kernel32", EntryPoint = "CloseHandle", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hObject);

	[DllImport("Kernel32", EntryPoint = "WaitForSingleObject", SetLastError = true)]
	public static extern bool WaitForObj(IntPtr hHandle, uint dwMilliseconds);

	[DllImport("kernel32.dll", EntryPoint = "SetConsoleMode", SetLastError = true)]
	public static extern bool SetConsoleMode(IntPtr hConsoleHandle, int mode);

	[DllImport("kernel32.dll", EntryPoint = "GetConsoleMode", SetLastError = true)]
	public static extern bool GetConsoleMode(IntPtr handle, out int mode);

	[DllImport("kernel32.dll", EntryPoint = "ResumeThread", SetLastError = true)]
	internal static extern uint ResumeThread(IntPtr hThread);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateProcess", SetLastError = true)]
	internal static extern bool CreateProc(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, IntPtr lpCurrentDirectory, [In] ref ProcStartupInfo lpStartupInfo, out ProcessInfo lpProcessInformation);

	[DllImport("user32.dll", EntryPoint = "GetClientRect")]
	private static extern bool GetClientRect(IntPtr hWnd, ref ScreenPosition lpRect);

	[DllImport("user32.dll", EntryPoint = "ClientToScreen")]
	private static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

	[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
	public static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
	public static extern int WindowThreadProcessId(IntPtr hWnd, out int processId);

	public static Size GetWindowSize(IntPtr h)
	{
		ScreenPosition lpRect = default;

		GetClientRect(h, ref lpRect);
		var result = default(Size);
		result.Width = lpRect.PosRight - lpRect.PosLeft;
		result.Height = lpRect.PosBottom - lpRect.PosTop;
		return result;
	}

	public static Point GetDll32Pointer(IntPtr h)
	{
		Point lpPoint = Point.Empty;
		ClientToScreen(h, ref lpPoint);
		return lpPoint;
	}
}
