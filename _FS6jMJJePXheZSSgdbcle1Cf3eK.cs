using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExaltMultiTool;

internal class _FS6jMJJePXheZSSgdbcle1Cf3eK : UserControl
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _pK1Y3F0HUnQbCy46KEZjg1380yb
	{
		public static readonly _pK1Y3F0HUnQbCy46KEZjg1380yb _003C_003E9 = new _pK1Y3F0HUnQbCy46KEZjg1380yb();

		public static Func<string, string> _003C_003E9__3_0;

		internal string _lRLRRFGVTyPuhCuCekzkhW0TBhu(string key)
		{
			return key;
		}
	}

	private int _9Coezm0vxBE08bEqBB0AlKC3e7B;

	private IContainer _CQeJ5ARN3cqDqwayOhiu7devmaC;

	private PictureBox _0qGoS0gG6nkz5C4R8Fk8qHyrYxe;

	private Label _BfCSHocEZu2fHOwL6DmJjSSPawh;

	private Panel _lTp6hjCbS79k7Z460nAmnxPpEdR;

	private PictureBox _EBxXDix5QPbDEezimhG3OPAp5qH;

	private PictureBox _3jl2H0bgWczvL9BUCNai9TybAKQ;

	private Label _20fPZCc3nsQmihPXcPpG1Tnf0ws;

	private ComboBox _9rOrNZAwGRGO2proNFoPGZzEnYb;

	private Panel _9KCHoFs7FqHYn7zPZyocfuvj28A;

	private Label _gjXMrcyPb1wH60zX4hBQwjcfFsq;

	private PictureBox _joBBcOo8YtX7ZmmDcsbW9AT1mIr;

	private Label _Vn2AMJ3vS21ub73iXsz1jBjzIMn;

	private Panel _Tg0A8vEUmocOpWFnMQ38NBuenJe;

	private Button _xGcemkferOYaV9EwhgUwmU2hbUq;

	private Button _W7JDb8veqQNdRvGCv5DnIy2PefyA;

	private Button _dabQ09RqFyQBXKS8Z40lCLNsOYF;

	private Button _9hLUR30R9yHjFZ599KDnViddAyn;

	private Label _YK9LgNhW9s3ybH8MO0GbtOtGjVM;

	private TableLayoutPanel _ohNIROwvVE8wbEpjavUYv3oIsMI;

	private Label _o4vOZ1dKPcU7QTX5GdNbBpkQ1cE;

	private Label _t8PGdOTcYr81haXpqgi0bXuhMeX;

	private Label _ZHJ9qfxdATvxNQ05O7vQDdkyxt;

	private Label _s4VQneiCiMhQLVgRe1blYM8RYwh;

	public _FS6jMJJePXheZSSgdbcle1Cf3eK()
	{
		while (true)
		{
			int num = 1402786648;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6D30888Au) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_0028;
				case 2u:
					return;
				}
				break;
				IL_0028:
				_LNN7j16YxFjRwCTXxBG3QnekdGe();
				Settings.SettingsChanged += delegate
				{
					Invoke((MethodInvoker)delegate
					{
						_9rOrNZAwGRGO2proNFoPGZzEnYb.SelectedItem = Settings.Default.CurrentServer;
					});
				};
				num = ((int)num2 * -947206137) ^ 0x276CB7CC;
			}
		}
	}

	private void _rGBdqcPppetT8GOuUNqdPfWz7BU(object sender, EventArgs e)
	{
		if (_9rOrNZAwGRGO2proNFoPGZzEnYb.SelectedIndex == -1)
		{
			return;
		}
		while (true)
		{
			int num = 1713471031;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x24498446u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0030;
				case 1u:
					return;
				}
				break;
				IL_0030:
				Settings.Default.CurrentServer = _9rOrNZAwGRGO2proNFoPGZzEnYb.Items[_9rOrNZAwGRGO2proNFoPGZzEnYb.SelectedIndex].ToString();
				num = ((int)num2 * -995989682) ^ 0x4EDF2798;
			}
		}
	}

	[AsyncStateMachine(typeof(_RooWSZWAEe8X8oc6vNpfx2GdiyAA))]
	private void _pDySdsFKJYCnhmAow4lZefX41PQ(object sender, EventArgs e)
	{
		_RooWSZWAEe8X8oc6vNpfx2GdiyAA stateMachine = default(_RooWSZWAEe8X8oc6vNpfx2GdiyAA);
		stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo = AsyncVoidMethodBuilder.Create();
		stateMachine._7DEudk1H4zeA6HRBegB5UK6RcSYA = this;
		stateMachine._PBb43473kLxvAWjGhIbcR02LyrK = -1;
		while (true)
		{
			int num = -764940746;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC78F0D01u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_003e;
				case 2u:
					return;
				}
				break;
				IL_003e:
				stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo.Start(ref stateMachine);
				num = (int)((num2 * 1522812929) ^ 0x259758E7);
			}
		}
	}

	private void _ef9NpCfDRyiHJud6bSLHoyxOQQg(object sender, EventArgs e)
	{
		Process.Start("https://realmstock.com/");
	}

	private void _TJfdCWIMZ7aKn3jLB7KUjZWetMc(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0054
		string text = default(string);
		OpenFileDialog openFileDialog = default(OpenFileDialog);
		while (true)
		{
			int num;
			int num2;
			if (File.Exists(Settings.Default.ExaltLauncherPath))
			{
				num = 1674229535;
				num2 = num;
			}
			else
			{
				num = 528158761;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x49127115u) % 13u)
				{
				case 5u:
					num = 528158761;
					continue;
				default:
					return;
				case 9u:
					return;
				case 4u:
					num = ((int)num3 * -1246952813) ^ 0x4EC73515;
					continue;
				case 2u:
				{
					MessageBox.Show(base.ParentForm, "Please locate the RotMG Exalt Launcher file where you installed it so that we can start RotMG.\n\nDefault location is similar to: " + text, "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					openFileDialog = new OpenFileDialog
					{
						Title = "Locate RotMG Exalt Launcher file...",
						Filter = "RotMG Exalt Launcher (*.exe)|*.exe",
						InitialDirectory = Path.GetDirectoryName(text)
					};
					int num9;
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						num = 1987652544;
						num9 = num;
					}
					else
					{
						num = 1382908775;
						num9 = num;
					}
					continue;
				}
				case 7u:
					num = ((int)num3 * -1293352952) ^ -1853952199;
					continue;
				case 12u:
				{
					int num5;
					int num6;
					if (Control.ModifierKeys != Keys.Alt)
					{
						num5 = 1813751601;
						num6 = num5;
					}
					else
					{
						num5 = 1225935927;
						num6 = num5;
					}
					num = num5 ^ (int)(num3 * 453148931);
					continue;
				}
				case 3u:
				{
					int num7;
					int num8;
					if (!openFileDialog.FileName.EndsWith("RotMG Exalt Launcher.exe"))
					{
						num7 = 1631030908;
						num8 = num7;
					}
					else
					{
						num7 = 1435228392;
						num8 = num7;
					}
					num = num7 ^ (int)(num3 * 58908719);
					continue;
				}
				case 6u:
					Settings.Default.ExaltLauncherPath = text;
					num = (int)((num3 * 1433228881) ^ 0x3656112F);
					continue;
				case 11u:
					Settings.Default.ExaltLauncherPath = openFileDialog.FileName;
					Settings.Default.Save();
					num = (int)((num3 * 835169391) ^ 0xA1BE23B);
					continue;
				case 0u:
					InjectionHelper._sMhhfUgb6MrcF41LT6KCITIMEBjA(steam: false);
					num = (int)((num3 * 1886435683) ^ 0x46384376);
					continue;
				case 8u:
				{
					text = "C:\\Program Files\\RotMG Exalt Launcher\\RotMG Exalt Launcher.exe";
					int num4;
					if (File.Exists(text))
					{
						num = 404055925;
						num4 = num;
					}
					else
					{
						num = 1408753620;
						num4 = num;
					}
					continue;
				}
				case 10u:
					break;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void _GYGRookhWKYMM7vvKDWIhmMntqC(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_01cc
		string text = default(string);
		OpenFileDialog openFileDialog = default(OpenFileDialog);
		while (true)
		{
			int num;
			int num2;
			if (File.Exists(Settings.Default.ExaltSteamPath))
			{
				num = 1343518495;
				num2 = num;
			}
			else
			{
				num = 1705827363;
				num2 = num;
			}
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num ^ 0x7AB30788u) % 14u)
				{
				case 11u:
					num = 1705827363;
					continue;
				default:
					return;
				case 3u:
					Settings.Default.ExaltSteamPath = text;
					num = ((int)num3 * -1057661310) ^ -341259494;
					continue;
				case 10u:
					Settings.Default.ExaltSteamPath = openFileDialog.FileName;
					num = ((int)num3 * -1220258881) ^ -1360540552;
					continue;
				case 7u:
					MessageBox.Show(base.ParentForm, "Please locate the STEAM RotMG Exalt Launcher file where you installed it so that we can start RotMG.\n\nDefault location is similar to: " + text, "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					num = 1958602680;
					continue;
				case 13u:
					text = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86), "Steam\\steamapps\\common\\Realm of the Mad God\\RotMG Exalt Launcher.exe");
					num = 972796400;
					continue;
				case 6u:
				{
					openFileDialog = new OpenFileDialog
					{
						Title = "Locate RotMG Exalt Launcher file...",
						Filter = "RotMG Exalt Launcher (*.exe)|*.exe",
						InitialDirectory = Path.GetDirectoryName(text)
					};
					int num8;
					int num9;
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						num8 = 738860720;
						num9 = num8;
					}
					else
					{
						num8 = 1528560152;
						num9 = num8;
					}
					num = num8 ^ (int)(num3 * 2026771333);
					continue;
				}
				case 2u:
				{
					int num10;
					int num11;
					if (File.Exists(text))
					{
						num10 = 277921427;
						num11 = num10;
					}
					else
					{
						num10 = 1419891481;
						num11 = num10;
					}
					num = num10 ^ (int)(num3 * 558089057);
					continue;
				}
				case 4u:
					break;
				case 5u:
					InjectionHelper._sMhhfUgb6MrcF41LT6KCITIMEBjA(steam: true);
					num = (int)(num3 * 1183748340) ^ -220159981;
					continue;
				case 12u:
					Settings.Default.Save();
					num = (int)((num3 * 1865312333) ^ 0x106346);
					continue;
				case 9u:
				{
					int num6;
					int num7;
					if (Control.ModifierKeys == Keys.Alt)
					{
						num6 = 1442904138;
						num7 = num6;
					}
					else
					{
						num6 = 1431101038;
						num7 = num6;
					}
					num = num6 ^ (int)(num3 * 1668723455);
					continue;
				}
				case 8u:
					return;
				case 0u:
				{
					int num4;
					int num5;
					if (openFileDialog.FileName.EndsWith("RotMG Exalt Launcher.exe"))
					{
						num4 = -238937754;
						num5 = num4;
					}
					else
					{
						num4 = -505181688;
						num5 = num4;
					}
					num = num4 ^ (int)(num3 * 1961302012);
					continue;
				}
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void _8oPM3VHU7XKNB30XxFjCRfroQLo(object sender, EventArgs e)
	{
		(base.ParentForm as MainForm)._8oPM3VHU7XKNB30XxFjCRfroQLo(this, EventArgs.Empty);
	}

	private void _dl99YbsnwqYz8uI071Hc8pG9m5b(object sender, EventArgs e)
	{
		(base.ParentForm as MainForm)._GU6csqtcZcVmT42WMdJViL1lkGK(this, EventArgs.Empty);
	}

	private void _GhasnjnxdyWhdtjfDTytt09c71bA(object sender, EventArgs e)
	{
		Settings.Default.ExaltLauncherPath = string.Empty;
		while (true)
		{
			int num = -1246043096;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA097B7BDu) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					Settings.Default.ExaltSteamPath = string.Empty;
					num = (int)(num2 * 1261964228) ^ -1184964217;
					continue;
				case 2u:
					MessageBox.Show("Your paths have been reset.\nPlease click a launcher button to choose a new path.", "RealmStock MultiTool");
					num = (int)((num2 * 1175605801) ^ 0x482A6FB8);
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	protected override void _8H2QqjADGkx30Hq77Uf9ZGuRzFD(bool disposing)
	{
		if (disposing)
		{
			goto IL_0003;
		}
		goto IL_002d;
		IL_002d:
		Dispose(disposing);
		int num = -505302446;
		goto IL_0008;
		IL_0008:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x86098090u) % 5u)
			{
			case 2u:
				break;
			default:
				return;
			case 0u:
				goto IL_002d;
			case 3u:
				_CQeJ5ARN3cqDqwayOhiu7devmaC.Dispose();
				num = (int)(num2 * 499223601) ^ -741415335;
				continue;
			case 1u:
			{
				int num3;
				int num4;
				if (_CQeJ5ARN3cqDqwayOhiu7devmaC == null)
				{
					num3 = -584850691;
					num4 = num3;
				}
				else
				{
					num3 = -593704252;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 1058184709);
				continue;
			}
			case 4u:
				return;
			}
			break;
		}
		goto IL_0003;
		IL_0003:
		num = -281952149;
		goto IL_0008;
	}

	private void _LNN7j16YxFjRwCTXxBG3QnekdGe()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_FS6jMJJePXheZSSgdbcle1Cf3eK));
		while (true)
		{
			int num = 945621853;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2507088u) % 185u)
				{
				case 89u:
					break;
				default:
					return;
				case 174u:
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn.Size = new Size(161, 13);
					num = ((int)num2 * -745440852) ^ -80346899;
					continue;
				case 164u:
					_joBBcOo8YtX7ZmmDcsbW9AT1mIr.Name = "pbxProxyServer";
					_joBBcOo8YtX7ZmmDcsbW9AT1mIr.Size = new Size(40, 40);
					num = (int)(num2 * 1576783148) ^ -1123586000;
					continue;
				case 88u:
					_t8PGdOTcYr81haXpqgi0bXuhMeX = new Label();
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE = new Label();
					num = ((int)num2 * -1757558609) ^ -1444367975;
					continue;
				case 9u:
					_lTp6hjCbS79k7Z460nAmnxPpEdR = new Panel();
					num = (int)(num2 * 1374532874) ^ -1524064054;
					continue;
				case 101u:
					base.AutoScaleMode = AutoScaleMode.Dpi;
					BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
					num = ((int)num2 * -695885249) ^ 0x7DC1D7DC;
					continue;
				case 46u:
					_gjXMrcyPb1wH60zX4hBQwjcfFsq.ForeColor = Color.Gold;
					_gjXMrcyPb1wH60zX4hBQwjcfFsq.Location = new Point(42, 2);
					_gjXMrcyPb1wH60zX4hBQwjcfFsq.Name = "lblCurrentServer";
					num = (int)(num2 * 130636237) ^ -380396105;
					continue;
				case 105u:
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = (int)(num2 * 87273640) ^ -759091625;
					continue;
				case 154u:
					_xGcemkferOYaV9EwhgUwmU2hbUq.Size = new Size(120, 56);
					_xGcemkferOYaV9EwhgUwmU2hbUq.TabIndex = 7;
					num = ((int)num2 * -643481996) ^ -1102695139;
					continue;
				case 91u:
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.Click += _8oPM3VHU7XKNB30XxFjCRfroQLo;
					num = (int)(num2 * 1607755372) ^ -1791018311;
					continue;
				case 182u:
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn = new Label();
					_joBBcOo8YtX7ZmmDcsbW9AT1mIr = new PictureBox();
					_Tg0A8vEUmocOpWFnMQ38NBuenJe = new Panel();
					num = ((int)num2 * -1174842760) ^ 0x71CF92E5;
					continue;
				case 21u:
					_xGcemkferOYaV9EwhgUwmU2hbUq.FlatAppearance.BorderColor = Color.Gold;
					num = (int)(num2 * 901336796) ^ -1554026253;
					continue;
				case 181u:
					_xGcemkferOYaV9EwhgUwmU2hbUq.Margin = new Padding(1);
					_xGcemkferOYaV9EwhgUwmU2hbUq.Name = "btnExaltLauncher";
					num = ((int)num2 * -334933668) ^ -708703482;
					continue;
				case 144u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A.TabIndex = 16;
					num = ((int)num2 * -427716856) ^ -1798990605;
					continue;
				case 82u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A.Controls.Add(_joBBcOo8YtX7ZmmDcsbW9AT1mIr);
					_9KCHoFs7FqHYn7zPZyocfuvj28A.Font = new Font("Segoe UI", 8.25f);
					num = (int)(num2 * 1465158537) ^ -1672434190;
					continue;
				case 176u:
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.Name = "pnlLaunch";
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.Size = new Size(494, 103);
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.TabIndex = 17;
					num = ((int)num2 * -2130226327) ^ 0x5AEB6DD8;
					continue;
				case 2u:
					_gjXMrcyPb1wH60zX4hBQwjcfFsq.BackColor = Color.Transparent;
					num = ((int)num2 * -2123503428) ^ 0x7E75EB03;
					continue;
				case 98u:
					SuspendLayout();
					num = (int)((num2 * 22937068) ^ 0x6546FA21);
					continue;
				case 163u:
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn.Text = "Use '/con' to change in-game!";
					_joBBcOo8YtX7ZmmDcsbW9AT1mIr.Image = (Image)componentResourceManager.GetObject("pbxProxyServer.Image");
					num = ((int)num2 * -544025100) ^ -829640553;
					continue;
				case 29u:
					_9hLUR30R9yHjFZ599KDnViddAyn.FlatAppearance.BorderColor = Color.Silver;
					num = (int)(num2 * 331118569) ^ -264736602;
					continue;
				case 110u:
					_xGcemkferOYaV9EwhgUwmU2hbUq.Location = new Point(1, 1);
					num = ((int)num2 * -560065952) ^ -1778829566;
					continue;
				case 26u:
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.TextAlign = ContentAlignment.TopCenter;
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.UseVisualStyleBackColor = false;
					num = ((int)num2 * -460162223) ^ 0x1914004C;
					continue;
				case 81u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.Controls.Add(_xGcemkferOYaV9EwhgUwmU2hbUq, 0, 0);
					num = (int)(num2 * 1953432410) ^ -1801222940;
					continue;
				case 16u:
					_9hLUR30R9yHjFZ599KDnViddAyn.BackColor = Color.FromArgb(162, 57, 202);
					num = ((int)num2 * -1404598446) ^ -2077536185;
					continue;
				case 99u:
					((ISupportInitialize)_3jl2H0bgWczvL9BUCNai9TybAKQ).EndInit();
					((ISupportInitialize)_EBxXDix5QPbDEezimhG3OPAp5qH).EndInit();
					num = ((int)num2 * -571726399) ^ 0x4372CC8;
					continue;
				case 68u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.Controls.Add(_dabQ09RqFyQBXKS8Z40lCLNsOYF, 1, 0);
					num = ((int)num2 * -1256521309) ^ 0x4D39302C;
					continue;
				case 117u:
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.Dock = DockStyle.Fill;
					num = (int)((num2 * 571209282) ^ 0xFD447D);
					continue;
				case 58u:
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn.TabIndex = 16;
					num = (int)(num2 * 2020829188) ^ -1851383515;
					continue;
				case 138u:
					BackgroundImageLayout = ImageLayout.Stretch;
					base.Controls.Add(_Tg0A8vEUmocOpWFnMQ38NBuenJe);
					base.Controls.Add(_9KCHoFs7FqHYn7zPZyocfuvj28A);
					base.Controls.Add(_lTp6hjCbS79k7Z460nAmnxPpEdR);
					num = ((int)num2 * -1154160296) ^ -957828380;
					continue;
				case 158u:
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.BackColor = Color.FromArgb(162, 57, 202);
					num = (int)((num2 * 1755007648) ^ 0x40CD5E86);
					continue;
				case 87u:
					_20fPZCc3nsQmihPXcPpG1Tnf0ws.ForeColor = Color.LimeGreen;
					_20fPZCc3nsQmihPXcPpG1Tnf0ws.Location = new Point(44, 44);
					_20fPZCc3nsQmihPXcPpG1Tnf0ws.Name = "lblClientsConnected";
					num = (int)(num2 * 1815530448) ^ -1380548268;
					continue;
				case 180u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A.Controls.Add(_9rOrNZAwGRGO2proNFoPGZzEnYb);
					num = ((int)num2 * -1336225083) ^ 0x6E9F88DA;
					continue;
				case 72u:
					_EBxXDix5QPbDEezimhG3OPAp5qH.Name = "pbxClientsConnectedIcon";
					num = ((int)num2 * -706959149) ^ 0x26D591F1;
					continue;
				case 32u:
					_9rOrNZAwGRGO2proNFoPGZzEnYb.Font = new Font("Segoe UI", 10f);
					num = (int)(num2 * 1541179906) ^ -1669335176;
					continue;
				case 160u:
					_gjXMrcyPb1wH60zX4hBQwjcfFsq = new Label();
					num = ((int)num2 * -1821206534) ^ -1630460734;
					continue;
				case 167u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
					_ohNIROwvVE8wbEpjavUYv3oIsMI.Controls.Add(_9hLUR30R9yHjFZ599KDnViddAyn, 3, 0);
					num = (int)((num2 * 1250371297) ^ 0x3FF36486);
					continue;
				case 11u:
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn.RightToLeft = RightToLeft.No;
					num = (int)((num2 * 729277341) ^ 0x52858084);
					continue;
				case 65u:
					_BfCSHocEZu2fHOwL6DmJjSSPawh = new Label();
					num = (int)((num2 * 1382541778) ^ 0x19AAEDE0);
					continue;
				case 178u:
					_BfCSHocEZu2fHOwL6DmJjSSPawh.BackColor = Color.Transparent;
					num = (int)((num2 * 152374086) ^ 0x19C64C81);
					continue;
				case 40u:
					_9rOrNZAwGRGO2proNFoPGZzEnYb.SelectedIndexChanged += _rGBdqcPppetT8GOuUNqdPfWz7BU;
					_9KCHoFs7FqHYn7zPZyocfuvj28A.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = (int)((num2 * 992293257) ^ 0x776AD4FA);
					continue;
				case 54u:
					_EBxXDix5QPbDEezimhG3OPAp5qH.TabStop = false;
					num = ((int)num2 * -1333182707) ^ 0x5AADB737;
					continue;
				case 126u:
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn.Font = new Font("Segoe UI", 8.25f);
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn.ForeColor = Color.Gold;
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn.Location = new Point(43, 24);
					num = (int)(num2 * 2090704705) ^ -433212593;
					continue;
				case 4u:
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.Name = "lblConnectionInfo";
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.RightToLeft = RightToLeft.No;
					num = ((int)num2 * -584737092) ^ 0x7F33CCDB;
					continue;
				case 34u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.Controls.Add(_W7JDb8veqQNdRvGCv5DnIy2PefyA, 2, 0);
					_ohNIROwvVE8wbEpjavUYv3oIsMI.Location = new Point(1, 42);
					_ohNIROwvVE8wbEpjavUYv3oIsMI.Margin = new Padding(1);
					num = ((int)num2 * -2008776373) ^ 0x6FEA3781;
					continue;
				case 35u:
					_9rOrNZAwGRGO2proNFoPGZzEnYb.DropDownStyle = ComboBoxStyle.DropDownList;
					num = ((int)num2 * -1954981774) ^ 0x2CF37E9E;
					continue;
				case 147u:
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.Size = new Size(128, 21);
					num = ((int)num2 * -83189316) ^ -1100534055;
					continue;
				case 66u:
					Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					base.Name = "StartControl";
					base.Size = new Size(500, 300);
					num = ((int)num2 * -1590289409) ^ 0x59543DA2;
					continue;
				case 77u:
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.Click += _ef9NpCfDRyiHJud6bSLHoyxOQQg;
					_BfCSHocEZu2fHOwL6DmJjSSPawh.AutoSize = true;
					num = (int)(num2 * 1085178592) ^ -888148304;
					continue;
				case 30u:
					_lTp6hjCbS79k7Z460nAmnxPpEdR.TabIndex = 8;
					num = ((int)num2 * -557822381) ^ 0x4AB5C133;
					continue;
				case 168u:
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE.Name = "label1";
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE.RightToLeft = RightToLeft.No;
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE.Size = new Size(280, 13);
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE.TabIndex = 18;
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE.Text = "You must start RotMG from below to enable our tool!";
					_ohNIROwvVE8wbEpjavUYv3oIsMI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = (int)((num2 * 439893491) ^ 0x7556A371);
					continue;
				case 55u:
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM.TabIndex = 15;
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM.Text = "Start RotMG Exalt";
					num = ((int)num2 * -1888071137) ^ 0x5A631ECB;
					continue;
				case 175u:
					_joBBcOo8YtX7ZmmDcsbW9AT1mIr.Location = new Point(-1, -2);
					num = ((int)num2 * -1190874631) ^ 0x9B7B80D;
					continue;
				case 143u:
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.BackColor = Color.FromArgb(162, 57, 202);
					num = ((int)num2 * -752702476) ^ -695575279;
					continue;
				case 129u:
					_BfCSHocEZu2fHOwL6DmJjSSPawh.Font = new Font("Segoe UI", 8.25f);
					_BfCSHocEZu2fHOwL6DmJjSSPawh.ForeColor = Color.LimeGreen;
					num = ((int)num2 * -1186490332) ^ -301216799;
					continue;
				case 173u:
					_s4VQneiCiMhQLVgRe1blYM8RYwh.TabIndex = 16;
					num = (int)(num2 * 1788510288) ^ -1498641520;
					continue;
				case 142u:
					base.Load += _pDySdsFKJYCnhmAow4lZefX41PQ;
					num = ((int)num2 * -1519533933) ^ 0x5A33F164;
					continue;
				case 70u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A = new Panel();
					num = ((int)num2 * -1100739995) ^ -215112618;
					continue;
				case 170u:
					_9rOrNZAwGRGO2proNFoPGZzEnYb = new ComboBox();
					num = (int)((num2 * 1364598906) ^ 0x201D0084);
					continue;
				case 179u:
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.Margin = new Padding(1);
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.Name = "btnSteamLauncher";
					num = ((int)num2 * -1124960944) ^ 0x4714F709;
					continue;
				case 137u:
					_gjXMrcyPb1wH60zX4hBQwjcfFsq.RightToLeft = RightToLeft.No;
					_gjXMrcyPb1wH60zX4hBQwjcfFsq.Size = new Size(190, 21);
					num = ((int)num2 * -1632015833) ^ -2074119086;
					continue;
				case 148u:
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.BorderStyle = BorderStyle.FixedSingle;
					num = (int)((num2 * 623729460) ^ 0x7CF23A75);
					continue;
				case 162u:
					_s4VQneiCiMhQLVgRe1blYM8RYwh.Size = new Size(204, 13);
					num = ((int)num2 * -100412172) ^ -486853926;
					continue;
				case 0u:
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.BackColor = Color.Transparent;
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.Cursor = Cursors.Hand;
					num = (int)((num2 * 1289512910) ^ 0x6614CB97);
					continue;
				case 136u:
					((ISupportInitialize)_3jl2H0bgWczvL9BUCNai9TybAKQ).BeginInit();
					num = (int)(num2 * 237569228) ^ -1851957645;
					continue;
				case 31u:
					_xGcemkferOYaV9EwhgUwmU2hbUq.TextAlign = ContentAlignment.TopCenter;
					num = ((int)num2 * -333612599) ^ 0x66D1BA2A;
					continue;
				case 93u:
					_9hLUR30R9yHjFZ599KDnViddAyn.ForeColor = Color.FromArgb(224, 224, 224);
					_9hLUR30R9yHjFZ599KDnViddAyn.Location = new Point(367, 1);
					num = ((int)num2 * -499775480) ^ 0x12E960D6;
					continue;
				case 131u:
					_t8PGdOTcYr81haXpqgi0bXuhMeX.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					_t8PGdOTcYr81haXpqgi0bXuhMeX.AutoSize = true;
					num = ((int)num2 * -1551746841) ^ -1371709724;
					continue;
				case 165u:
					((ISupportInitialize)_joBBcOo8YtX7ZmmDcsbW9AT1mIr).EndInit();
					num = ((int)num2 * -1121642058) ^ 0x363B17C2;
					continue;
				case 59u:
					_t8PGdOTcYr81haXpqgi0bXuhMeX.Location = new Point(421, 25);
					num = ((int)num2 * -561531971) ^ 0x4BAF71F6;
					continue;
				case 106u:
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.Anchor = AnchorStyles.None;
					num = (int)((num2 * 1292233911) ^ 0x24E464F1);
					continue;
				case 111u:
					_lTp6hjCbS79k7Z460nAmnxPpEdR.Controls.Add(_s4VQneiCiMhQLVgRe1blYM8RYwh);
					_lTp6hjCbS79k7Z460nAmnxPpEdR.Controls.Add(_ZHJ9qfxdATvxNQ05O7vQDdkyxt);
					_lTp6hjCbS79k7Z460nAmnxPpEdR.Controls.Add(_20fPZCc3nsQmihPXcPpG1Tnf0ws);
					num = (int)((num2 * 791173380) ^ 0x2A27C1F6);
					continue;
				case 67u:
					_xGcemkferOYaV9EwhgUwmU2hbUq.FlatStyle = FlatStyle.Flat;
					_xGcemkferOYaV9EwhgUwmU2hbUq.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					_xGcemkferOYaV9EwhgUwmU2hbUq.ForeColor = Color.Gold;
					num = ((int)num2 * -1839553766) ^ -300788904;
					continue;
				case 62u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.Size = new Size(490, 58);
					_ohNIROwvVE8wbEpjavUYv3oIsMI.TabIndex = 17;
					num = ((int)num2 * -1020257964) ^ -972133597;
					continue;
				case 140u:
					_20fPZCc3nsQmihPXcPpG1Tnf0ws.Text = "0 Exalt Clients Connected";
					_3jl2H0bgWczvL9BUCNai9TybAKQ.Image = (Image)componentResourceManager.GetObject("pbxPlayersOnlineIcon.Image");
					_3jl2H0bgWczvL9BUCNai9TybAKQ.Location = new Point(-1, 1);
					num = (int)(num2 * 1522660423) ^ -1321982567;
					continue;
				case 183u:
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.ForeColor = Color.Aquamarine;
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.Location = new Point(123, 1);
					num = (int)((num2 * 135203562) ^ 0x3B2CA881);
					continue;
				case 19u:
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM.AutoSize = true;
					num = ((int)num2 * -1366532125) ^ 0x2569F71F;
					continue;
				case 113u:
					_20fPZCc3nsQmihPXcPpG1Tnf0ws = new Label();
					_3jl2H0bgWczvL9BUCNai9TybAKQ = new PictureBox();
					num = (int)(num2 * 400351894) ^ -29365533;
					continue;
				case 20u:
					((ISupportInitialize)_EBxXDix5QPbDEezimhG3OPAp5qH).BeginInit();
					_9KCHoFs7FqHYn7zPZyocfuvj28A.SuspendLayout();
					num = (int)((num2 * 1679887355) ^ 0x18CF574A);
					continue;
				case 122u:
					_EBxXDix5QPbDEezimhG3OPAp5qH.Image = (Image)componentResourceManager.GetObject("pbxClientsConnectedIcon.Image");
					_EBxXDix5QPbDEezimhG3OPAp5qH.Location = new Point(-1, 1);
					num = ((int)num2 * -1698918319) ^ -1648440364;
					continue;
				case 84u:
					_9hLUR30R9yHjFZ599KDnViddAyn.BackgroundImage = (Image)componentResourceManager.GetObject("btnInstructions.BackgroundImage");
					_9hLUR30R9yHjFZ599KDnViddAyn.BackgroundImageLayout = ImageLayout.Zoom;
					_9hLUR30R9yHjFZ599KDnViddAyn.Dock = DockStyle.Fill;
					num = ((int)num2 * -424483224) ^ -177878881;
					continue;
				case 3u:
					_9hLUR30R9yHjFZ599KDnViddAyn.UseVisualStyleBackColor = false;
					num = ((int)num2 * -1440040472) ^ 0x1968320D;
					continue;
				case 7u:
					_20fPZCc3nsQmihPXcPpG1Tnf0ws.Size = new Size(137, 13);
					num = (int)((num2 * 1675994367) ^ 0x2F912BE0);
					continue;
				case 123u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.RowStyles.Add(new RowStyle(SizeType.Absolute, 60f));
					num = (int)(num2 * 83527881) ^ -738587773;
					continue;
				case 94u:
					_xGcemkferOYaV9EwhgUwmU2hbUq.Click += _TJfdCWIMZ7aKn3jLB7KUjZWetMc;
					num = ((int)num2 * -1780265453) ^ -739212547;
					continue;
				case 61u:
					_EBxXDix5QPbDEezimhG3OPAp5qH.TabIndex = 7;
					num = (int)((num2 * 43834398) ^ 0x2484EAEC);
					continue;
				case 90u:
					_3jl2H0bgWczvL9BUCNai9TybAKQ.Name = "pbxPlayersOnlineIcon";
					_3jl2H0bgWczvL9BUCNai9TybAKQ.Size = new Size(40, 40);
					_3jl2H0bgWczvL9BUCNai9TybAKQ.SizeMode = PictureBoxSizeMode.Zoom;
					_3jl2H0bgWczvL9BUCNai9TybAKQ.TabIndex = 9;
					_3jl2H0bgWczvL9BUCNai9TybAKQ.TabStop = false;
					num = ((int)num2 * -817068185) ^ 0x24C088F8;
					continue;
				case 28u:
					_lTp6hjCbS79k7Z460nAmnxPpEdR.BackColor = Color.FromArgb(44, 31, 52);
					_lTp6hjCbS79k7Z460nAmnxPpEdR.BorderStyle = BorderStyle.FixedSingle;
					num = ((int)num2 * -1003876123) ^ -642503093;
					continue;
				case 63u:
					_s4VQneiCiMhQLVgRe1blYM8RYwh.Name = "lblProxyWarning";
					_s4VQneiCiMhQLVgRe1blYM8RYwh.RightToLeft = RightToLeft.No;
					num = ((int)num2 * -1036488444) ^ -2106512932;
					continue;
				case 44u:
					_joBBcOo8YtX7ZmmDcsbW9AT1mIr.TabStop = false;
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.BackColor = Color.FromArgb(44, 31, 52);
					num = (int)((num2 * 2090626599) ^ 0x512B658E);
					continue;
				case 18u:
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.Text = "Connection Info";
					num = (int)((num2 * 2040279484) ^ 0x5990224B);
					continue;
				case 184u:
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.TabIndex = 15;
					num = (int)((num2 * 717998347) ^ 0x6EC9506A);
					continue;
				case 47u:
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM.Size = new Size(139, 21);
					num = ((int)num2 * -1825889947) ^ 0x2B93855D;
					continue;
				case 127u:
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.Image = (Image)componentResourceManager.GetObject("pbxLogo.Image");
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.Location = new Point(3, 3);
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.Name = "pbxLogo";
					num = ((int)num2 * -1634534747) ^ -2137233611;
					continue;
				case 107u:
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.ForeColor = Color.Gold;
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.Location = new Point(42, 2);
					num = ((int)num2 * -1365869787) ^ -1171351217;
					continue;
				case 177u:
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = ((int)num2 * -1022023394) ^ 0xE5EE853;
					continue;
				case 116u:
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.Controls.Add(_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE);
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.Controls.Add(_ohNIROwvVE8wbEpjavUYv3oIsMI);
					num = (int)(num2 * 232634195) ^ -2033681642;
					continue;
				case 153u:
					_9hLUR30R9yHjFZ599KDnViddAyn.FlatStyle = FlatStyle.Flat;
					_9hLUR30R9yHjFZ599KDnViddAyn.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
					num = (int)(num2 * 615967256) ^ -1592642015;
					continue;
				case 42u:
					_lTp6hjCbS79k7Z460nAmnxPpEdR.PerformLayout();
					num = ((int)num2 * -1338713228) ^ 0x798A69FE;
					continue;
				case 92u:
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.BackgroundImage = (Image)componentResourceManager.GetObject("btnMultiLogin.BackgroundImage");
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.BackgroundImageLayout = ImageLayout.Zoom;
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.Dock = DockStyle.Fill;
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.FlatAppearance.BorderColor = Color.Lime;
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.FlatStyle = FlatStyle.Flat;
					num = (int)(num2 * 9889038) ^ -2134451597;
					continue;
				case 12u:
					_t8PGdOTcYr81haXpqgi0bXuhMeX.Name = "btnClearLocations";
					_t8PGdOTcYr81haXpqgi0bXuhMeX.Size = new Size(68, 12);
					_t8PGdOTcYr81haXpqgi0bXuhMeX.TabIndex = 19;
					_t8PGdOTcYr81haXpqgi0bXuhMeX.Text = "Clear locations";
					num = (int)(num2 * 789340778) ^ -1814115262;
					continue;
				case 79u:
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.FlatAppearance.BorderColor = Color.LightSkyBlue;
					num = (int)(num2 * 1403742305) ^ -1916797599;
					continue;
				case 22u:
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.Controls.Add(_t8PGdOTcYr81haXpqgi0bXuhMeX);
					num = (int)((num2 * 1279940034) ^ 0x485194FF);
					continue;
				case 6u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
					num = ((int)num2 * -655353334) ^ -85719082;
					continue;
				case 73u:
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.PerformLayout();
					_ohNIROwvVE8wbEpjavUYv3oIsMI.ResumeLayout(performLayout: false);
					ResumeLayout(performLayout: false);
					num = ((int)num2 * -1276977478) ^ 0x1EDF3648;
					continue;
				case 45u:
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn.AutoSize = true;
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn.BackColor = Color.Transparent;
					num = ((int)num2 * -225709983) ^ -1684550117;
					continue;
				case 150u:
					_EBxXDix5QPbDEezimhG3OPAp5qH.Size = new Size(40, 40);
					num = (int)(num2 * 342600816) ^ -283211016;
					continue;
				case 141u:
					_9rOrNZAwGRGO2proNFoPGZzEnYb.Name = "lstServers";
					_9rOrNZAwGRGO2proNFoPGZzEnYb.Size = new Size(207, 25);
					_9rOrNZAwGRGO2proNFoPGZzEnYb.TabIndex = 13;
					num = ((int)num2 * -614052186) ^ 0x5BCA2237;
					continue;
				case 83u:
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.Location = new Point(3, 194);
					num = ((int)num2 * -1340284831) ^ -1237871264;
					continue;
				case 8u:
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.Click += _GYGRookhWKYMM7vvKDWIhmMntqC;
					num = ((int)num2 * -1978981446) ^ 0x8336879;
					continue;
				case 124u:
					_lTp6hjCbS79k7Z460nAmnxPpEdR.Controls.Add(_BfCSHocEZu2fHOwL6DmJjSSPawh);
					num = (int)((num2 * 872588074) ^ 0xD37682F);
					continue;
				case 114u:
					((ISupportInitialize)_0qGoS0gG6nkz5C4R8Fk8qHyrYxe).EndInit();
					_lTp6hjCbS79k7Z460nAmnxPpEdR.ResumeLayout(performLayout: false);
					num = ((int)num2 * -133884759) ^ 0x2A35A95A;
					continue;
				case 52u:
					_gjXMrcyPb1wH60zX4hBQwjcfFsq.AutoSize = true;
					num = (int)(num2 * 1401902807) ^ -53898723;
					continue;
				case 33u:
					_s4VQneiCiMhQLVgRe1blYM8RYwh.BackColor = Color.Transparent;
					_s4VQneiCiMhQLVgRe1blYM8RYwh.Font = new Font("Segoe UI", 8.25f);
					num = ((int)num2 * -371927241) ^ -2131019752;
					continue;
				case 78u:
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.AutoSize = true;
					num = ((int)num2 * -486938383) ^ -1125867851;
					continue;
				case 120u:
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.Size = new Size(120, 56);
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.TabIndex = 9;
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.Text = "Multi Login";
					num = (int)((num2 * 2043300640) ^ 0x75203EC2);
					continue;
				case 50u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A.Size = new Size(234, 82);
					num = (int)(num2 * 2059893184) ^ -72929631;
					continue;
				case 108u:
					_20fPZCc3nsQmihPXcPpG1Tnf0ws.TabIndex = 12;
					num = ((int)num2 * -401766184) ^ -1893132952;
					continue;
				case 14u:
					_gjXMrcyPb1wH60zX4hBQwjcfFsq.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = (int)((num2 * 1919436321) ^ 0x3B231A85);
					continue;
				case 104u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
					num = ((int)num2 * -1419280695) ^ 0x690AEBDA;
					continue;
				case 57u:
					_s4VQneiCiMhQLVgRe1blYM8RYwh.ForeColor = Color.Gold;
					_s4VQneiCiMhQLVgRe1blYM8RYwh.Location = new Point(43, 24);
					num = ((int)num2 * -1730512688) ^ -184503127;
					continue;
				case 132u:
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.TabIndex = 8;
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.Text = "Steam Launcher";
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.TextAlign = ContentAlignment.TopCenter;
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.UseVisualStyleBackColor = false;
					num = (int)(num2 * 557380215) ^ -1040346447;
					continue;
				case 139u:
					_xGcemkferOYaV9EwhgUwmU2hbUq = new Button();
					_dabQ09RqFyQBXKS8Z40lCLNsOYF = new Button();
					_W7JDb8veqQNdRvGCv5DnIy2PefyA = new Button();
					num = ((int)num2 * -2023518129) ^ 0x6916EAC;
					continue;
				case 27u:
					_s4VQneiCiMhQLVgRe1blYM8RYwh = new Label();
					num = (int)((num2 * 1770419454) ^ 0x15C676FF);
					continue;
				case 121u:
					_9hLUR30R9yHjFZ599KDnViddAyn.Margin = new Padding(1);
					_9hLUR30R9yHjFZ599KDnViddAyn.Name = "btnInstructions";
					_9hLUR30R9yHjFZ599KDnViddAyn.Size = new Size(122, 56);
					_9hLUR30R9yHjFZ599KDnViddAyn.TabIndex = 10;
					_9hLUR30R9yHjFZ599KDnViddAyn.Text = "Instructions";
					num = ((int)num2 * -948625317) ^ -1249650232;
					continue;
				case 102u:
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.FlatStyle = FlatStyle.Flat;
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
					num = (int)(num2 * 728535059) ^ -132965022;
					continue;
				case 71u:
					_9hLUR30R9yHjFZ599KDnViddAyn.Click += _dl99YbsnwqYz8uI071Hc8pG9m5b;
					_xGcemkferOYaV9EwhgUwmU2hbUq.BackColor = Color.FromArgb(162, 57, 202);
					num = (int)(num2 * 469774242) ^ -45166557;
					continue;
				case 133u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A.Controls.Add(_gjXMrcyPb1wH60zX4hBQwjcfFsq);
					num = (int)((num2 * 1384086421) ^ 0x72A2A42D);
					continue;
				case 25u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.ColumnCount = 4;
					_ohNIROwvVE8wbEpjavUYv3oIsMI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
					_ohNIROwvVE8wbEpjavUYv3oIsMI.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
					num = (int)(num2 * 378849613) ^ -540318457;
					continue;
				case 37u:
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.ResumeLayout(performLayout: false);
					num = (int)((num2 * 1446492830) ^ 0x608DFE8C);
					continue;
				case 159u:
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt = new Label();
					num = (int)((num2 * 1498816053) ^ 0x784D9967);
					continue;
				case 74u:
					_ZHJ9qfxdATvxNQ05O7vQDdkyxt.BackColor = Color.Transparent;
					num = (int)(num2 * 858790845) ^ -102967376;
					continue;
				case 157u:
					_t8PGdOTcYr81haXpqgi0bXuhMeX.Cursor = Cursors.Hand;
					_t8PGdOTcYr81haXpqgi0bXuhMeX.Font = new Font("Segoe UI", 7f);
					_t8PGdOTcYr81haXpqgi0bXuhMeX.ForeColor = Color.Gold;
					num = ((int)num2 * -621057538) ^ -1127327141;
					continue;
				case 146u:
					_EBxXDix5QPbDEezimhG3OPAp5qH = new PictureBox();
					num = (int)((num2 * 727618683) ^ 0x2E8D899F);
					continue;
				case 161u:
					DoubleBuffered = true;
					num = ((int)num2 * -657623805) ^ -1141495831;
					continue;
				case 48u:
					_20fPZCc3nsQmihPXcPpG1Tnf0ws.AutoSize = true;
					_20fPZCc3nsQmihPXcPpG1Tnf0ws.BackColor = Color.Transparent;
					num = ((int)num2 * -1169438590) ^ 0x1C37AF0D;
					continue;
				case 41u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.SuspendLayout();
					num = (int)(num2 * 1018624050) ^ -529871982;
					continue;
				case 76u:
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.Controls.Add(_YK9LgNhW9s3ybH8MO0GbtOtGjVM);
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.Font = new Font("Segoe UI", 8.25f);
					num = (int)((num2 * 1983380279) ^ 0x283BC4AD);
					continue;
				case 69u:
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
					num = (int)((num2 * 1127543154) ^ 0x77B7C694);
					continue;
				case 130u:
					_joBBcOo8YtX7ZmmDcsbW9AT1mIr.TabIndex = 15;
					num = ((int)num2 * -503649904) ^ 0x9B51398;
					continue;
				case 80u:
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM = new Label();
					((ISupportInitialize)_0qGoS0gG6nkz5C4R8Fk8qHyrYxe).BeginInit();
					num = (int)((num2 * 1150193480) ^ 0x2B109C64);
					continue;
				case 152u:
					_9hLUR30R9yHjFZ599KDnViddAyn.TextAlign = ContentAlignment.TopCenter;
					num = (int)(num2 * 1133790591) ^ -457015410;
					continue;
				case 115u:
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM.BackColor = Color.Transparent;
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = (int)((num2 * 2078267329) ^ 0x36A67568);
					continue;
				case 151u:
					_xGcemkferOYaV9EwhgUwmU2hbUq.UseVisualStyleBackColor = false;
					num = ((int)num2 * -1557700390) ^ -2054045021;
					continue;
				case 135u:
					_xGcemkferOYaV9EwhgUwmU2hbUq.Text = "Exalt Launcher";
					num = (int)(num2 * 1476288748) ^ -1048262669;
					continue;
				case 1u:
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM.RightToLeft = RightToLeft.No;
					num = ((int)num2 * -111769452) ^ 0x48DF74C9;
					continue;
				case 64u:
					_lTp6hjCbS79k7Z460nAmnxPpEdR.Controls.Add(_3jl2H0bgWczvL9BUCNai9TybAKQ);
					_lTp6hjCbS79k7Z460nAmnxPpEdR.Font = new Font("Segoe UI", 8.25f);
					_lTp6hjCbS79k7Z460nAmnxPpEdR.Location = new Point(3, 109);
					_lTp6hjCbS79k7Z460nAmnxPpEdR.Name = "pnlAbout";
					_lTp6hjCbS79k7Z460nAmnxPpEdR.Size = new Size(257, 82);
					num = (int)(num2 * 888874561) ^ -950180438;
					continue;
				case 85u:
					base.AutoScaleDimensions = new SizeF(96f, 96f);
					num = ((int)num2 * -156902739) ^ 0x51B8A93D;
					continue;
				case 17u:
					_BfCSHocEZu2fHOwL6DmJjSSPawh.Text = "0 RotMG Players Online";
					_lTp6hjCbS79k7Z460nAmnxPpEdR.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
					num = (int)(num2 * 127309006) ^ -485639542;
					continue;
				case 112u:
					_lTp6hjCbS79k7Z460nAmnxPpEdR.SuspendLayout();
					num = ((int)num2 * -2096671641) ^ 0x6B59F45C;
					continue;
				case 43u:
					_20fPZCc3nsQmihPXcPpG1Tnf0ws.Font = new Font("Segoe UI", 8.25f);
					num = ((int)num2 * -1948770490) ^ -829983354;
					continue;
				case 60u:
					_9rOrNZAwGRGO2proNFoPGZzEnYb.FormattingEnabled = true;
					num = (int)((num2 * 2140283939) ^ 0xF887859);
					continue;
				case 13u:
					_gjXMrcyPb1wH60zX4hBQwjcfFsq.TabIndex = 14;
					_gjXMrcyPb1wH60zX4hBQwjcfFsq.Text = "Proxy Server Destination";
					num = (int)(num2 * 487144343) ^ -1009552872;
					continue;
				case 53u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A.BackColor = Color.FromArgb(44, 31, 52);
					_9KCHoFs7FqHYn7zPZyocfuvj28A.BorderStyle = BorderStyle.FixedSingle;
					num = (int)((num2 * 865676282) ^ 0x603E4C91);
					continue;
				case 36u:
					_9rOrNZAwGRGO2proNFoPGZzEnYb.Location = new Point(13, 47);
					num = ((int)num2 * -634880032) ^ -182115145;
					continue;
				case 38u:
					_Vn2AMJ3vS21ub73iXsz1jBjzIMn.Name = "lblServerChangeInfo";
					num = (int)((num2 * 1268629268) ^ 0x20CD112E);
					continue;
				case 51u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI = new TableLayoutPanel();
					_9hLUR30R9yHjFZ599KDnViddAyn = new Button();
					num = (int)(num2 * 1273255120) ^ -219239669;
					continue;
				case 15u:
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.Controls.Add(_EBxXDix5QPbDEezimhG3OPAp5qH);
					num = ((int)num2 * -1034848953) ^ 0x36F37DF3;
					continue;
				case 103u:
					_xGcemkferOYaV9EwhgUwmU2hbUq.BackgroundImage = (Image)componentResourceManager.GetObject("btnExaltLauncher.BackgroundImage");
					_xGcemkferOYaV9EwhgUwmU2hbUq.BackgroundImageLayout = ImageLayout.Zoom;
					_xGcemkferOYaV9EwhgUwmU2hbUq.Dock = DockStyle.Fill;
					num = ((int)num2 * -1252224499) ^ 0x4406D016;
					continue;
				case 171u:
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.BackgroundImage = (Image)componentResourceManager.GetObject("btnSteamLauncher.BackgroundImage");
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.BackgroundImageLayout = ImageLayout.Zoom;
					num = ((int)num2 * -1877279059) ^ -1012968459;
					continue;
				case 169u:
					base.Controls.Add(_0qGoS0gG6nkz5C4R8Fk8qHyrYxe);
					num = ((int)num2 * -945534693) ^ 0x2E898664;
					continue;
				case 86u:
					((ISupportInitialize)_joBBcOo8YtX7ZmmDcsbW9AT1mIr).BeginInit();
					num = ((int)num2 * -1415603590) ^ 0x653DA7CA;
					continue;
				case 5u:
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE.AutoSize = true;
					num = (int)((num2 * 1512949746) ^ 0xB7AE117);
					continue;
				case 172u:
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM.ForeColor = Color.Gold;
					num = ((int)num2 * -728070044) ^ -264550040;
					continue;
				case 97u:
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe = new PictureBox();
					num = ((int)num2 * -881712433) ^ -1215733779;
					continue;
				case 166u:
					_9rOrNZAwGRGO2proNFoPGZzEnYb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
					num = ((int)num2 * -123903211) ^ -490372691;
					continue;
				case 49u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A.ResumeLayout(performLayout: false);
					_9KCHoFs7FqHYn7zPZyocfuvj28A.PerformLayout();
					num = (int)((num2 * 585552365) ^ 0x4680670C);
					continue;
				case 155u:
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM.Location = new Point(42, 2);
					_YK9LgNhW9s3ybH8MO0GbtOtGjVM.Name = "lblStart";
					num = (int)(num2 * 548376993) ^ -1199187679;
					continue;
				case 128u:
					_s4VQneiCiMhQLVgRe1blYM8RYwh.AutoSize = true;
					num = (int)((num2 * 130878361) ^ 0x4CDEA81D);
					continue;
				case 134u:
					_Tg0A8vEUmocOpWFnMQ38NBuenJe.SuspendLayout();
					num = ((int)num2 * -1999132629) ^ -1745362801;
					continue;
				case 125u:
					_dabQ09RqFyQBXKS8Z40lCLNsOYF.Size = new Size(120, 56);
					num = (int)((num2 * 1477581686) ^ 0x4F2E8F3E);
					continue;
				case 156u:
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE.BackColor = Color.Transparent;
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE.Font = new Font("Segoe UI", 8.25f);
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE.ForeColor = Color.Gold;
					_o4vOZ1dKPcU7QTX5GdNbBpkQ1cE.Location = new Point(43, 24);
					num = ((int)num2 * -66212480) ^ -409774330;
					continue;
				case 10u:
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.Size = new Size(494, 106);
					num = ((int)num2 * -1629930456) ^ 0x6622F331;
					continue;
				case 119u:
					_t8PGdOTcYr81haXpqgi0bXuhMeX.Click += _GhasnjnxdyWhdtjfDTytt09c71bA;
					num = (int)(num2 * 1960757031) ^ -1892110465;
					continue;
				case 23u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A.Location = new Point(263, 109);
					num = (int)((num2 * 1497288554) ^ 0x3C12A1C5);
					continue;
				case 96u:
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.ForeColor = Color.Lime;
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.Location = new Point(245, 1);
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.Margin = new Padding(1);
					_W7JDb8veqQNdRvGCv5DnIy2PefyA.Name = "btnMultiLogin";
					num = (int)((num2 * 827499257) ^ 0x75166E10);
					continue;
				case 149u:
					_s4VQneiCiMhQLVgRe1blYM8RYwh.Text = "You must be connected to Proxy Server";
					num = (int)(num2 * 1575475242) ^ -34058679;
					continue;
				case 24u:
					_20fPZCc3nsQmihPXcPpG1Tnf0ws.RightToLeft = RightToLeft.No;
					num = ((int)num2 * -1836292148) ^ -1180632280;
					continue;
				case 39u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A.Controls.Add(_Vn2AMJ3vS21ub73iXsz1jBjzIMn);
					num = (int)(num2 * 470520313) ^ -1947403084;
					continue;
				case 95u:
					_9KCHoFs7FqHYn7zPZyocfuvj28A.Name = "pnlServerSelect";
					num = ((int)num2 * -217167352) ^ -338913767;
					continue;
				case 109u:
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.SizeMode = PictureBoxSizeMode.Zoom;
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.TabIndex = 1;
					_0qGoS0gG6nkz5C4R8Fk8qHyrYxe.TabStop = false;
					num = (int)(num2 * 837435316) ^ -862191612;
					continue;
				case 100u:
					_BfCSHocEZu2fHOwL6DmJjSSPawh.Location = new Point(44, 58);
					_BfCSHocEZu2fHOwL6DmJjSSPawh.Name = "lblPlayersOnine";
					_BfCSHocEZu2fHOwL6DmJjSSPawh.RightToLeft = RightToLeft.No;
					_BfCSHocEZu2fHOwL6DmJjSSPawh.Size = new Size(128, 13);
					_BfCSHocEZu2fHOwL6DmJjSSPawh.TabIndex = 6;
					num = (int)(num2 * 1024054040) ^ -706691096;
					continue;
				case 56u:
					_EBxXDix5QPbDEezimhG3OPAp5qH.SizeMode = PictureBoxSizeMode.Zoom;
					num = (int)(num2 * 1746492855) ^ -2123117508;
					continue;
				case 145u:
					_joBBcOo8YtX7ZmmDcsbW9AT1mIr.SizeMode = PictureBoxSizeMode.Zoom;
					num = (int)(num2 * 256543752) ^ -2135574341;
					continue;
				case 75u:
					_ohNIROwvVE8wbEpjavUYv3oIsMI.Name = "tableLaunchers";
					_ohNIROwvVE8wbEpjavUYv3oIsMI.RowCount = 1;
					num = (int)((num2 * 252131256) ^ 0x14233077);
					continue;
				case 118u:
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void _pRK4hVMUzp2H6Go81UTy9RBMdGe(object s, EventArgs e)
	{
		Invoke((MethodInvoker)delegate
		{
			_9rOrNZAwGRGO2proNFoPGZzEnYb.SelectedItem = Settings.Default.CurrentServer;
		});
	}

	[CompilerGenerated]
	private void _D7CcWZWAjlgZso34RBB8G6pNWxF()
	{
		_9rOrNZAwGRGO2proNFoPGZzEnYb.SelectedItem = Settings.Default.CurrentServer;
	}

	[CompilerGenerated]
	private void _hW7PpTf6lHJhlyeU7g2Pg0KKTOd(Client c)
	{
		Invoke((MethodInvoker)delegate
		{
			_20fPZCc3nsQmihPXcPpG1Tnf0ws.Text = $"{++_9Coezm0vxBE08bEqBB0AlKC3e7B} Exalt Client{((_9Coezm0vxBE08bEqBB0AlKC3e7B > 1 || _9Coezm0vxBE08bEqBB0AlKC3e7B == 0) ? 's' : ' ')} Connected";
		});
	}

	[CompilerGenerated]
	private void _iaZermLvF0rDR8HCkLMbzHvKXSn()
	{
		_20fPZCc3nsQmihPXcPpG1Tnf0ws.Text = $"{++_9Coezm0vxBE08bEqBB0AlKC3e7B} Exalt Client{((_9Coezm0vxBE08bEqBB0AlKC3e7B > 1 || _9Coezm0vxBE08bEqBB0AlKC3e7B == 0) ? 's' : ' ')} Connected";
	}

	[CompilerGenerated]
	private void _Qh8D2HTdPv3OLiHIOROlSXMWrsZ(Client c)
	{
		Invoke((MethodInvoker)delegate
		{
			_20fPZCc3nsQmihPXcPpG1Tnf0ws.Text = $"{--_9Coezm0vxBE08bEqBB0AlKC3e7B} Exalt Client{((_9Coezm0vxBE08bEqBB0AlKC3e7B > 1 || _9Coezm0vxBE08bEqBB0AlKC3e7B == 0) ? 's' : ' ')} Connected";
		});
	}

	[CompilerGenerated]
	private void _cfcqrYq50vc9tLcoXs671jcuETE()
	{
		_20fPZCc3nsQmihPXcPpG1Tnf0ws.Text = $"{--_9Coezm0vxBE08bEqBB0AlKC3e7B} Exalt Client{((_9Coezm0vxBE08bEqBB0AlKC3e7B > 1 || _9Coezm0vxBE08bEqBB0AlKC3e7B == 0) ? 's' : ' ')} Connected";
	}
}
