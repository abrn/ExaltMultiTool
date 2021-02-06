using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ExaltMultiTool;

internal static class Program {
	private static StringBuilder DebugMessages = new StringBuilder();

	[STAThread]
	private static void _JNpXAQtl22CH9YoBkXPbqOkmi9r()
	{
		_KOjvofkzBAzqmEvHRZRNmFojQZH._d2DbtJKY9HneawJSRKefBeKIcNi(
			_KOjvofkzBAzqmEvHRZRNmFojQZH._F4d2TGYd32CefpAHjoOmnZbgvCkb(), 0);
		_KOjvofkzBAzqmEvHRZRNmFojQZH._axlrZfcSb8gyZSepzTKbbvUFwkF();
		ProcessStartInfo processStartInfo = default(ProcessStartInfo);
		string location = default(string);

		while (true) {
			int num = -1138190251;
			while (true) {
				uint num2;
				
				switch ((num2 = (uint) num ^ 0xE9B49C66u) % 7u) {
					case 3u:
						break;
					case 4u:
						processStartInfo.Verb = "runas";
						num = ((int) num2 * -862456819) ^ -1828266696;
						continue;
					case 6u:
						processStartInfo = new ProcessStartInfo();
						num = (int) (num2 * 207032272) ^ -923700360;
						continue;
					case 2u:
						ServicePointManager.Expect100Continue = false;
						num = ((int) num2 * -1314856197) ^ 0x3FE5744;
						continue;
					case 5u: {
						if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole
							.Administrator)) {
							num = (int) (num2 * 1407420649) ^ -1014592676;
							continue;
						}

						bool createdNew;
						Mutex mutex = new Mutex(initiallyOwned: true, "ExaltMultiTool", out createdNew);
						try {
							if (!createdNew) {
								MessageBox.Show(
									"Another copy of Exalt Multi-Tool is already running!\nPlease close it. You may need to check Task Manager process list to find it.",
									"Exalt Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return;
							}

							try {
								Settings.Default.Save();
							}
							catch {
								try {
									Settings.DeleteSettings();
									Settings.Default.Save();
								}
								catch (Exception ex2) {
									MessageBox.Show("Failed to load settings!\n" + ex2, "Exalt Multi-Tool",
										MessageBoxButtons.OK, MessageBoxIcon.Hand);
									return;
								}
							}

							Settings.Default.AutoAbilityAutoMP = false;
							Settings.Default.AutoNexusDrinkFromInventory = false;
							Settings.Default.AutoNexusDrinkThreshold = 0;

							try {
								TcpListener tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 2050);
								tcpListener.Server.NoDelay = true;
								tcpListener.Start();
								tcpListener.Stop();
							}
							catch (Exception ex3) {
								MessageBox.Show(
									"Unable to bind to port 2050!\nPlease make sure no program is currently open and using that port!\nRESTART YOUR COMPUTER TO FIX THIS ISSUE!\n\nMore info:\n" +
									ex3, "Exalt Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								return;
							}

							Application.EnableVisualStyles();
							Application.SetCompatibleTextRenderingDefault(defaultValue: false);

							Application.Run(new MainForm());
							ReportClientUseStats();
						}

						continue;
						case 0u:
						location = Assembly.GetExecutingAssembly().Location;
						num = ((int) num2 * -1341657265) ^ -661778367;
						continue;
						default:
						processStartInfo.FileName = location;
						try {
							Process.Start(processStartInfo);
						}
						catch (Win32Exception) {
						}

						return;
					}
				}
			}
		}
	}

	public static void ReportClientUseStats()
	{
		string StatURL = "https://realmstock.network/Public/ExaltReport" + $"?identity={Settings.Default.ID}";
		
		try {
			WebClient webClient = new WebClient();
			try {
				webClient.Headers.Add(HttpRequestHeader.Accept, "application/json, */*");
				webClient.Headers.Add(HttpRequestHeader.ContentType, "application/json");
				webClient.UploadString(StatURL,
					"\"" + _xGOIk3wAIdG3vZO36b23MT3rjhL(DebugMessages.ToString()) + "\"");
			}
			finally {
				((IDisposable) webClient).Dispose();
			}
		}
		catch (Exception arg) {
			MessageBox.Show(
				$"Failed to start logging! Please report this issue as the tool cannot function.\n{StatURL}\n{arg}",
				"Exalt Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}
	private static string _xGOIk3wAIdG3vZO36b23MT3rjhL(string str)
	{
		int num = 65519;
		int num5 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		int num4 = default(int);
		while (true) {
			int num2 = -578768193;
			while (true) {
				uint num3;
				switch ((num3 = (uint) num2 ^ 0xFFDAB214u) % 8u) {
					case 4u:
						break;
					case 6u:
						num5 = 0;
						num2 = (int) ((num3 * 1094168627) ^ 0xA10C89C);
						continue;
					case 5u:
						stringBuilder.Append(Uri.EscapeDataString((num5 < num4)
							? str.Substring(num * num5, num)
							: str.Substring(num * num5)));
						num5++;
						num2 = -728494037;
						continue;
					case 3u:
						stringBuilder = new StringBuilder();
						num2 = ((int) num3 * -1674625440) ^ -812929436;
						continue;
					case 2u:
						num2 = (int) ((num3 * 1480946413) ^ 0x1CA1AD91);
						continue;
					case 7u: {
						int num6;
						if (num5 > num4) {
							num2 = -1193940627;
							num6 = num2;
						}
						else {
							num2 = -1464742591;
							num6 = num2;
						}

						continue;
					}
					case 0u:
						num4 = str.Length / num;
						num2 = ((int) num3 * -602870034) ^ -222099430;
						continue;
					default:
						return stringBuilder.ToString();
				}

				break;
			}
		}
	}

	public static void LogInfoMessage(string source, string message)
	{
		LogDebugMessage(source, '*', message);
	}

	public static void _JWptdPwuTlZYlLpGrinhw8DeS3h(string source, string message)
	{
		LogDebugMessage(source, '#', message);
	}

	public static void LogNetworkError(string source, string message)
	{
		LogDebugMessage(source, '-', message);
	}

	public static void _et8c2Heqb7KWtXL1gFN1nBBGIVP(string source, string message)
	{
		LogDebugMessage(source, '!', message);
	}

	private static void LogDebugMessage(string source, char reason, string message)
	{
		string value = $"[{reason}] [{source}] {message}\n";
		DebugMessages.Append(value);
	}
}