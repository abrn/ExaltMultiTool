using System;
using System.Drawing;
using System.Runtime.InteropServices;

internal static class _KOjvofkzBAzqmEvHRZRNmFojQZH
{
	internal struct _OoJRoKxh0utfWeMP3aFZXh1BWhq
	{
		public int _mEbPYUUehKpduXYDS9B1ORcMJaN;

		public IntPtr _hcwH4Fm4tBiDnVSAtMMdVsfd2tB;

		public int _GEcCGP3uzQHyvjpOoZfeVh1Uzl;
	}

	internal enum _R7VIlSbaO4x4qOemwVuxI4f9qBh
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

	internal enum _63ZPHflV8tPr2rRQbGy2GzPZ7Pf
	{
		MEM_COMMIT = 0x1000,
		MEM_RESERVE = 0x2000,
		MEM_RESET = 0x80000,
		MEM_RESET_UNDO = 0x1000000,
		SecCommit = 0x8000000
	}

	internal enum _v3DTWBzBMHBbeiVoqERXY4sz4nd
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
	internal struct _pGtEmbuQs0gMWAdcBAhhr6gMqgX
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

	internal struct _zjgiwwJZUA8aZTeMCSZeihp47Dw
	{
		public IntPtr _QjPrTpWj4dJdFgwgkKtVC8NhIyC;

		public IntPtr _JwYWFGBftDuvPOaDpMAqYYZmRpM;

		public int _Xfy86MzBYkDHYV6eC0jeyWpmMqW;

		public int _VfdJwuvT8GagDI6chBlDFH20VjJ;
	}

	private struct _dR1Hu3vgXgl5E9Q5TY3KHrChRxG
	{
		public int _bPiafC1vzur71V1bAm1hpLkob2G;

		public int _YtMAJhKAM7Gk3cR4KOw2UCivrX;

		public int _ye5cw2VT4AcyeKPEPVNce4acT2q;

		public int _aOQLlkaFr1eGsCVZmHpsJX8zRsA;

		internal _dR1Hu3vgXgl5E9Q5TY3KHrChRxG(int left, int top, int right, int bottom)
		{
			_bPiafC1vzur71V1bAm1hpLkob2G = left;
			_YtMAJhKAM7Gk3cR4KOw2UCivrX = top;
			_ye5cw2VT4AcyeKPEPVNce4acT2q = right;
			_aOQLlkaFr1eGsCVZmHpsJX8zRsA = bottom;
		}
	}

	public const int _Y4MAL8AVbMRxpBHrPFdRhOOm0sj = 0;

	public const int _u9sdbAuPi9K33tMKaMoMe418jNL = 5;

	[DllImport("kernel32.dll", EntryPoint = "GetConsoleWindow")]
	public static extern IntPtr _F4d2TGYd32CefpAHjoOmnZbgvCkb();

	[DllImport("user32.dll", EntryPoint = "ShowWindow")]
	public static extern bool _d2DbtJKY9HneawJSRKefBeKIcNi(IntPtr hWnd, int nCmdShow);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CreatePipe", SetLastError = true)]
	public static extern bool _eZsfnUgbAukknt7JFdL5HMS53wm(out IntPtr hReadPipe, out IntPtr hWritePipe, ref _OoJRoKxh0utfWeMP3aFZXh1BWhq lpPipeAttributes, int nSize);

	[DllImport("kernel32.dll", EntryPoint = "GetStdHandle", SetLastError = true)]
	public static extern IntPtr _v3uV5i4dzWksns6Q6XeKKw8eCFo(int nStdHandle);

	[DllImport("user32.dll", EntryPoint = "SetProcessDPIAware", SetLastError = true)]
	public static extern bool _axlrZfcSb8gyZSepzTKbbvUFwkF();

	[DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool _mctOsq0P6OgKSXWnN9lcNn5Inxf();

	[DllImport("user32.dll", EntryPoint = "RegisterHotKey")]
	public static extern bool _ays3S5z2xKCPIbcZFwkO0Be8WEE(IntPtr hWnd, int id, int fsModifiers, int vk);

	[DllImport("user32.dll", EntryPoint = "UnregisterHotKey")]
	public static extern bool _HXVpLlj5YH2Zu8xy1nZBQFDbcJf(IntPtr hWnd, int id);

	[DllImport("Kernel32", EntryPoint = "OpenProcess", SetLastError = true)]
	public static extern IntPtr _INfE8TPjISGD5RZE9CVwrdDdvLp(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	[DllImport("kernel32", EntryPoint = "GetProcAddress", SetLastError = true)]
	public static extern IntPtr _zqkXaS0fbgW5SfjaOy5EpA6o5N1(IntPtr hModule, string procName);

	[DllImport("kernel32.dll", EntryPoint = "GetModuleHandleA", SetLastError = true)]
	public static extern IntPtr _MpECyuu0ww9WE1mc2JaGfXy7YeQ(string lpModuleName);

	[DllImport("Kernel32", EntryPoint = "VirtualAllocEx", SetLastError = true)]
	public static extern IntPtr _N0XwljYi7pJKWgAAdvUmfa7ccXE(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[DllImport("Kernel32", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	public static extern bool _O8k7xYpkG5pQyqFh433YTQ9woVE(IntPtr hProcess, IntPtr lpBaseAddress, [MarshalAs(UnmanagedType.AsAny)] object lpBuffer, uint nSize, ref uint lpNumberOfBytesWritten);

	[DllImport("Kernel32", EntryPoint = "CreateRemoteThread", SetLastError = true)]
	public static extern IntPtr _KueE2yTPEjNDAJT08H2DGsGNt7N(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, ref uint lpThreadId);

	[DllImport("Kernel32", EntryPoint = "CloseHandle", SetLastError = true)]
	public static extern bool _ncvsNr9oXhkaIirRo2KAJ4c9g4y(IntPtr hObject);

	[DllImport("Kernel32", EntryPoint = "WaitForSingleObject", SetLastError = true)]
	public static extern bool _PxyT4CEJyj4HnJ5DrPzPmhvvhIM(IntPtr hHandle, uint dwMilliseconds);

	[DllImport("kernel32.dll", EntryPoint = "SetConsoleMode", SetLastError = true)]
	public static extern bool _XOXrSxeqaweHkDitAaSTRWG1GLo(IntPtr hConsoleHandle, int mode);

	[DllImport("kernel32.dll", EntryPoint = "GetConsoleMode", SetLastError = true)]
	public static extern bool _l02Th1Qv5Vru0NgUCuGd1xJmQKG(IntPtr handle, out int mode);

	[DllImport("kernel32.dll", EntryPoint = "ResumeThread", SetLastError = true)]
	internal static extern uint _kQdGqTbeSNpbEs07G8GfCURPn6cA(IntPtr hThread);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "CreateProcess", SetLastError = true)]
	internal static extern bool _Ke0Dh6gvqJBjghnfyca8KN8GfxC(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, IntPtr lpCurrentDirectory, [In] ref _pGtEmbuQs0gMWAdcBAhhr6gMqgX lpStartupInfo, out _zjgiwwJZUA8aZTeMCSZeihp47Dw lpProcessInformation);

	[DllImport("user32.dll", EntryPoint = "GetClientRect")]
	private static extern bool _B9mt75Xcr88LkCEh7UsT57a3zBb(IntPtr hWnd, ref _dR1Hu3vgXgl5E9Q5TY3KHrChRxG lpRect);

	[DllImport("user32.dll", EntryPoint = "ClientToScreen")]
	private static extern bool _yLGGhk0CwILOXYx24dLZC5RGxtd(IntPtr hWnd, ref Point lpPoint);

	[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
	public static extern IntPtr _l5H7QhLROi9mbdVdXeaft7JR9IC();

	[DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
	public static extern bool _fO4qvqGTT5HMdweoLUi5LAVqnxC(IntPtr hWnd);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId")]
	public static extern int _wFKfbaEwZOTe2nf2ykF62N0jDyf(IntPtr hWnd, out int processId);

	public static Size _XDPabd71DYUFI2ijOdsHblAClVKb(IntPtr h)
	{
		_dR1Hu3vgXgl5E9Q5TY3KHrChRxG lpRect = default(_dR1Hu3vgXgl5E9Q5TY3KHrChRxG);
		Size result = default(Size);
		while (true)
		{
			int num = 592156571;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x394AC2FAu) % 4u)
				{
				case 3u:
					break;
				case 1u:
					_B9mt75Xcr88LkCEh7UsT57a3zBb(h, ref lpRect);
					result = default(Size);
					result.Width = lpRect._ye5cw2VT4AcyeKPEPVNce4acT2q - lpRect._bPiafC1vzur71V1bAm1hpLkob2G;
					num = ((int)num2 * -1594917739) ^ 0xDB371A3;
					continue;
				case 0u:
					result.Height = lpRect._aOQLlkaFr1eGsCVZmHpsJX8zRsA - lpRect._YtMAJhKAM7Gk3cR4KOw2UCivrX;
					num = (int)(num2 * 585719635) ^ -1481710604;
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	public static Point _NSJ3GrIfVJ7vx20dnsm0AVQdIcj(IntPtr h)
	{
		Point lpPoint = Point.Empty;
		_yLGGhk0CwILOXYx24dLZC5RGxtd(h, ref lpPoint);
		return lpPoint;
	}
}
