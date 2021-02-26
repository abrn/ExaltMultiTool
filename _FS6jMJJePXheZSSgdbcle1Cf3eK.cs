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

	private PictureBox pbxLogo;

	private Label lblPlayersOnline;

	private Panel pnlAbout;

	private PictureBox pbxClientsConnectedIcon;

	private PictureBox pbxPlayersOnlineIcon;

	private Label pbxPlayersOnlineText;

	private ComboBox lstServers;

	private Panel pnlServerSelect;

	private Label lblCurrentServer;

	private PictureBox pbxProxyServer;

	private Label lblChangeServer;

	private Panel pnlLaunch;

	private Button btnExaltLauncher;

	private Button btnMultiLogin;

	private Button btnSteamLauncher;

	private Button btnInstructions;

	private Label lblStartExalt;

	private TableLayoutPanel tableLaunchers;

	private Label lblStartWarning;

	private Label btnClearLocations;

	private Label lblConnectionInfo;

	private Label lblProxyWarning;

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
						lstServers.SelectedItem = Settings.Default.CurrentServer;
					});
				};
				num = ((int)num2 * -947206137) ^ 0x276CB7CC;
			}
		}
	}

	private void _rGBdqcPppetT8GOuUNqdPfWz7BU(object sender, EventArgs e)
	{
		if (lstServers.SelectedIndex == -1)
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
				Settings.Default.CurrentServer = lstServers.Items[lstServers.SelectedIndex].ToString();
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

	private void OnSiteClick(object sender, EventArgs e)
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
					InjectionHelper.StartExaltLauncher(steam: false);
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
					InjectionHelper.StartExaltLauncher(steam: true);
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

	private void OnMultiLoginClick(object sender, EventArgs e)
	{
		(base.ParentForm as MainForm)._8oPM3VHU7XKNB30XxFjCRfroQLo(this, EventArgs.Empty);
	}

	private void OnInstructionsClick(object sender, EventArgs e)
	{
		(base.ParentForm as MainForm)._GU6csqtcZcVmT42WMdJViL1lkGK(this, EventArgs.Empty);
	}

	private void OnClearLocations(object sender, EventArgs e)
	{
		Settings.Default.ExaltLauncherPath = string.Empty;
		Settings.Default.ExaltSteamPath = string.Empty;
		
		MessageBox.Show("Your paths have been reset.\nPlease click a launcher button to choose a new path.", "RealmStock MultiTool");
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
					lblChangeServer.Size = new Size(161, 13);
					num = ((int)num2 * -745440852) ^ -80346899;
					continue;
				case 164u:
					pbxProxyServer.Name = "pbxProxyServer";
					pbxProxyServer.Size = new Size(40, 40);
					num = (int)(num2 * 1576783148) ^ -1123586000;
					continue;
				case 88u:
					btnClearLocations = new Label();
					lblStartWarning = new Label();
					num = ((int)num2 * -1757558609) ^ -1444367975;
					continue;
				case 9u:
					pnlAbout = new Panel();
					num = (int)(num2 * 1374532874) ^ -1524064054;
					continue;
				case 101u:
					base.AutoScaleMode = AutoScaleMode.Dpi;
					BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
					num = ((int)num2 * -695885249) ^ 0x7DC1D7DC;
					continue;
				case 46u:
					lblCurrentServer.ForeColor = Color.Gold;
					lblCurrentServer.Location = new Point(42, 2);
					lblCurrentServer.Name = "lblCurrentServer";
					num = (int)(num2 * 130636237) ^ -380396105;
					continue;
				case 105u:
					lblConnectionInfo.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = (int)(num2 * 87273640) ^ -759091625;
					continue;
				case 154u:
					btnExaltLauncher.Size = new Size(120, 56);
					btnExaltLauncher.TabIndex = 7;
					num = ((int)num2 * -643481996) ^ -1102695139;
					continue;
				case 91u:
					btnMultiLogin.Click += OnMultiLoginClick;
					num = (int)(num2 * 1607755372) ^ -1791018311;
					continue;
				case 182u:
					lblChangeServer = new Label();
					pbxProxyServer = new PictureBox();
					pnlLaunch = new Panel();
					num = ((int)num2 * -1174842760) ^ 0x71CF92E5;
					continue;
				case 21u:
					btnExaltLauncher.FlatAppearance.BorderColor = Color.Gold;
					num = (int)(num2 * 901336796) ^ -1554026253;
					continue;
				case 181u:
					btnExaltLauncher.Margin = new Padding(1);
					btnExaltLauncher.Name = "btnExaltLauncher";
					num = ((int)num2 * -334933668) ^ -708703482;
					continue;
				case 144u:
					pnlServerSelect.TabIndex = 16;
					num = ((int)num2 * -427716856) ^ -1798990605;
					continue;
				case 82u:
					pnlServerSelect.Controls.Add(pbxProxyServer);
					pnlServerSelect.Font = new Font("Segoe UI", 8.25f);
					num = (int)(num2 * 1465158537) ^ -1672434190;
					continue;
				case 176u:
					pnlLaunch.Name = "pnlLaunch";
					pnlLaunch.Size = new Size(494, 103);
					pnlLaunch.TabIndex = 17;
					num = ((int)num2 * -2130226327) ^ 0x5AEB6DD8;
					continue;
				case 2u:
					lblCurrentServer.BackColor = Color.Transparent;
					num = ((int)num2 * -2123503428) ^ 0x7E75EB03;
					continue;
				case 98u:
					SuspendLayout();
					num = (int)((num2 * 22937068) ^ 0x6546FA21);
					continue;
				case 163u:
					lblChangeServer.Text = "Use '/con' to change in-game!";
					pbxProxyServer.Image = (Image)componentResourceManager.GetObject("pbxProxyServer.Image");
					num = ((int)num2 * -544025100) ^ -829640553;
					continue;
				case 29u:
					btnInstructions.FlatAppearance.BorderColor = Color.Silver;
					num = (int)(num2 * 331118569) ^ -264736602;
					continue;
				case 110u:
					btnExaltLauncher.Location = new Point(1, 1);
					num = ((int)num2 * -560065952) ^ -1778829566;
					continue;
				case 26u:
					btnMultiLogin.TextAlign = ContentAlignment.TopCenter;
					btnMultiLogin.UseVisualStyleBackColor = false;
					num = ((int)num2 * -460162223) ^ 0x1914004C;
					continue;
				case 81u:
					tableLaunchers.Controls.Add(btnExaltLauncher, 0, 0);
					num = (int)(num2 * 1953432410) ^ -1801222940;
					continue;
				case 16u:
					btnInstructions.BackColor = Color.FromArgb(162, 57, 202);
					num = ((int)num2 * -1404598446) ^ -2077536185;
					continue;
				case 99u:
					((ISupportInitialize)pbxPlayersOnlineIcon).EndInit();
					((ISupportInitialize)pbxClientsConnectedIcon).EndInit();
					num = ((int)num2 * -571726399) ^ 0x4372CC8;
					continue;
				case 68u:
					tableLaunchers.Controls.Add(btnSteamLauncher, 1, 0);
					num = ((int)num2 * -1256521309) ^ 0x4D39302C;
					continue;
				case 117u:
					btnSteamLauncher.Dock = DockStyle.Fill;
					num = (int)((num2 * 571209282) ^ 0xFD447D);
					continue;
				case 58u:
					lblChangeServer.TabIndex = 16;
					num = (int)(num2 * 2020829188) ^ -1851383515;
					continue;
				case 138u:
					BackgroundImageLayout = ImageLayout.Stretch;
					base.Controls.Add(pnlLaunch);
					base.Controls.Add(pnlServerSelect);
					base.Controls.Add(pnlAbout);
					num = ((int)num2 * -1154160296) ^ -957828380;
					continue;
				case 158u:
					btnMultiLogin.BackColor = Color.FromArgb(162, 57, 202);
					num = (int)((num2 * 1755007648) ^ 0x40CD5E86);
					continue;
				case 87u:
					pbxPlayersOnlineText.ForeColor = Color.LimeGreen;
					pbxPlayersOnlineText.Location = new Point(44, 44);
					pbxPlayersOnlineText.Name = "lblClientsConnected";
					num = (int)(num2 * 1815530448) ^ -1380548268;
					continue;
				case 180u:
					pnlServerSelect.Controls.Add(lstServers);
					num = ((int)num2 * -1336225083) ^ 0x6E9F88DA;
					continue;
				case 72u:
					pbxClientsConnectedIcon.Name = "pbxClientsConnectedIcon";
					num = ((int)num2 * -706959149) ^ 0x26D591F1;
					continue;
				case 32u:
					lstServers.Font = new Font("Segoe UI", 10f);
					num = (int)(num2 * 1541179906) ^ -1669335176;
					continue;
				case 160u:
					lblCurrentServer = new Label();
					num = ((int)num2 * -1821206534) ^ -1630460734;
					continue;
				case 167u:
					tableLaunchers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
					tableLaunchers.Controls.Add(btnInstructions, 3, 0);
					num = (int)((num2 * 1250371297) ^ 0x3FF36486);
					continue;
				case 11u:
					lblChangeServer.RightToLeft = RightToLeft.No;
					num = (int)((num2 * 729277341) ^ 0x52858084);
					continue;
				case 65u:
					lblPlayersOnline = new Label();
					num = (int)((num2 * 1382541778) ^ 0x19AAEDE0);
					continue;
				case 178u:
					lblPlayersOnline.BackColor = Color.Transparent;
					num = (int)((num2 * 152374086) ^ 0x19C64C81);
					continue;
				case 40u:
					lstServers.SelectedIndexChanged += _rGBdqcPppetT8GOuUNqdPfWz7BU;
					pnlServerSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = (int)((num2 * 992293257) ^ 0x776AD4FA);
					continue;
				case 54u:
					pbxClientsConnectedIcon.TabStop = false;
					num = ((int)num2 * -1333182707) ^ 0x5AADB737;
					continue;
				case 126u:
					lblChangeServer.Font = new Font("Segoe UI", 8.25f);
					lblChangeServer.ForeColor = Color.Gold;
					lblChangeServer.Location = new Point(43, 24);
					num = (int)(num2 * 2090704705) ^ -433212593;
					continue;
				case 4u:
					lblConnectionInfo.Name = "lblConnectionInfo";
					lblConnectionInfo.RightToLeft = RightToLeft.No;
					num = ((int)num2 * -584737092) ^ 0x7F33CCDB;
					continue;
				case 34u:
					tableLaunchers.Controls.Add(btnMultiLogin, 2, 0);
					tableLaunchers.Location = new Point(1, 42);
					tableLaunchers.Margin = new Padding(1);
					num = ((int)num2 * -2008776373) ^ 0x6FEA3781;
					continue;
				case 35u:
					lstServers.DropDownStyle = ComboBoxStyle.DropDownList;
					num = ((int)num2 * -1954981774) ^ 0x2CF37E9E;
					continue;
				case 147u:
					lblConnectionInfo.Size = new Size(128, 21);
					num = ((int)num2 * -83189316) ^ -1100534055;
					continue;
				case 66u:
					Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					base.Name = "StartControl";
					base.Size = new Size(500, 300);
					num = ((int)num2 * -1590289409) ^ 0x59543DA2;
					continue;
				case 77u:
					pbxLogo.Click += OnSiteClick;
					lblPlayersOnline.AutoSize = true;
					num = (int)(num2 * 1085178592) ^ -888148304;
					continue;
				case 30u:
					pnlAbout.TabIndex = 8;
					num = ((int)num2 * -557822381) ^ 0x4AB5C133;
					continue;
				case 168u:
					lblStartWarning.Name = "label1";
					lblStartWarning.RightToLeft = RightToLeft.No;
					lblStartWarning.Size = new Size(280, 13);
					lblStartWarning.TabIndex = 18;
					lblStartWarning.Text = "You must start RotMG from below to enable our tool!";
					tableLaunchers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = (int)((num2 * 439893491) ^ 0x7556A371);
					continue;
				case 55u:
					lblStartExalt.TabIndex = 15;
					lblStartExalt.Text = "Start RotMG Exalt";
					num = ((int)num2 * -1888071137) ^ 0x5A631ECB;
					continue;
				case 175u:
					pbxProxyServer.Location = new Point(-1, -2);
					num = ((int)num2 * -1190874631) ^ 0x9B7B80D;
					continue;
				case 143u:
					btnSteamLauncher.BackColor = Color.FromArgb(162, 57, 202);
					num = ((int)num2 * -752702476) ^ -695575279;
					continue;
				case 129u:
					lblPlayersOnline.Font = new Font("Segoe UI", 8.25f);
					lblPlayersOnline.ForeColor = Color.LimeGreen;
					num = ((int)num2 * -1186490332) ^ -301216799;
					continue;
				case 173u:
					lblProxyWarning.TabIndex = 16;
					num = (int)(num2 * 1788510288) ^ -1498641520;
					continue;
				case 142u:
					base.Load += _pDySdsFKJYCnhmAow4lZefX41PQ;
					num = ((int)num2 * -1519533933) ^ 0x5A33F164;
					continue;
				case 70u:
					pnlServerSelect = new Panel();
					num = ((int)num2 * -1100739995) ^ -215112618;
					continue;
				case 170u:
					lstServers = new ComboBox();
					num = (int)((num2 * 1364598906) ^ 0x201D0084);
					continue;
				case 179u:
					btnSteamLauncher.Margin = new Padding(1);
					btnSteamLauncher.Name = "btnSteamLauncher";
					num = ((int)num2 * -1124960944) ^ 0x4714F709;
					continue;
				case 137u:
					lblCurrentServer.RightToLeft = RightToLeft.No;
					lblCurrentServer.Size = new Size(190, 21);
					num = ((int)num2 * -1632015833) ^ -2074119086;
					continue;
				case 148u:
					pnlLaunch.BorderStyle = BorderStyle.FixedSingle;
					num = (int)((num2 * 623729460) ^ 0x7CF23A75);
					continue;
				case 162u:
					lblProxyWarning.Size = new Size(204, 13);
					num = ((int)num2 * -100412172) ^ -486853926;
					continue;
				case 0u:
					pbxLogo.BackColor = Color.Transparent;
					pbxLogo.Cursor = Cursors.Hand;
					num = (int)((num2 * 1289512910) ^ 0x6614CB97);
					continue;
				case 136u:
					((ISupportInitialize)pbxPlayersOnlineIcon).BeginInit();
					num = (int)(num2 * 237569228) ^ -1851957645;
					continue;
				case 31u:
					btnExaltLauncher.TextAlign = ContentAlignment.TopCenter;
					num = ((int)num2 * -333612599) ^ 0x66D1BA2A;
					continue;
				case 93u:
					btnInstructions.ForeColor = Color.FromArgb(224, 224, 224);
					btnInstructions.Location = new Point(367, 1);
					num = ((int)num2 * -499775480) ^ 0x12E960D6;
					continue;
				case 131u:
					btnClearLocations.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					btnClearLocations.AutoSize = true;
					num = ((int)num2 * -1551746841) ^ -1371709724;
					continue;
				case 165u:
					((ISupportInitialize)pbxProxyServer).EndInit();
					num = ((int)num2 * -1121642058) ^ 0x363B17C2;
					continue;
				case 59u:
					btnClearLocations.Location = new Point(421, 25);
					num = ((int)num2 * -561531971) ^ 0x4BAF71F6;
					continue;
				case 106u:
					lblConnectionInfo.Anchor = AnchorStyles.None;
					num = (int)((num2 * 1292233911) ^ 0x24E464F1);
					continue;
				case 111u:
					pnlAbout.Controls.Add(lblProxyWarning);
					pnlAbout.Controls.Add(lblConnectionInfo);
					pnlAbout.Controls.Add(pbxPlayersOnlineText);
					num = (int)((num2 * 791173380) ^ 0x2A27C1F6);
					continue;
				case 67u:
					btnExaltLauncher.FlatStyle = FlatStyle.Flat;
					btnExaltLauncher.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
					btnExaltLauncher.ForeColor = Color.Gold;
					num = ((int)num2 * -1839553766) ^ -300788904;
					continue;
				case 62u:
					tableLaunchers.Size = new Size(490, 58);
					tableLaunchers.TabIndex = 17;
					num = ((int)num2 * -1020257964) ^ -972133597;
					continue;
				case 140u:
					pbxPlayersOnlineText.Text = "0 Exalt Clients Connected";
					pbxPlayersOnlineIcon.Image = (Image)componentResourceManager.GetObject("pbxPlayersOnlineIcon.Image");
					pbxPlayersOnlineIcon.Location = new Point(-1, 1);
					num = (int)(num2 * 1522660423) ^ -1321982567;
					continue;
				case 183u:
					btnSteamLauncher.ForeColor = Color.Aquamarine;
					btnSteamLauncher.Location = new Point(123, 1);
					num = (int)((num2 * 135203562) ^ 0x3B2CA881);
					continue;
				case 19u:
					lblStartExalt.AutoSize = true;
					num = ((int)num2 * -1366532125) ^ 0x2569F71F;
					continue;
				case 113u:
					pbxPlayersOnlineText = new Label();
					pbxPlayersOnlineIcon = new PictureBox();
					num = (int)(num2 * 400351894) ^ -29365533;
					continue;
				case 20u:
					((ISupportInitialize)pbxClientsConnectedIcon).BeginInit();
					pnlServerSelect.SuspendLayout();
					num = (int)((num2 * 1679887355) ^ 0x18CF574A);
					continue;
				case 122u:
					pbxClientsConnectedIcon.Image = (Image)componentResourceManager.GetObject("pbxClientsConnectedIcon.Image");
					pbxClientsConnectedIcon.Location = new Point(-1, 1);
					num = ((int)num2 * -1698918319) ^ -1648440364;
					continue;
				case 84u:
					btnInstructions.BackgroundImage = (Image)componentResourceManager.GetObject("btnInstructions.BackgroundImage");
					btnInstructions.BackgroundImageLayout = ImageLayout.Zoom;
					btnInstructions.Dock = DockStyle.Fill;
					num = ((int)num2 * -424483224) ^ -177878881;
					continue;
				case 3u:
					btnInstructions.UseVisualStyleBackColor = false;
					num = ((int)num2 * -1440040472) ^ 0x1968320D;
					continue;
				case 7u:
					pbxPlayersOnlineText.Size = new Size(137, 13);
					num = (int)((num2 * 1675994367) ^ 0x2F912BE0);
					continue;
				case 123u:
					tableLaunchers.RowStyles.Add(new RowStyle(SizeType.Absolute, 60f));
					num = (int)(num2 * 83527881) ^ -738587773;
					continue;
				case 94u:
					btnExaltLauncher.Click += _TJfdCWIMZ7aKn3jLB7KUjZWetMc;
					num = ((int)num2 * -1780265453) ^ -739212547;
					continue;
				case 61u:
					pbxClientsConnectedIcon.TabIndex = 7;
					num = (int)((num2 * 43834398) ^ 0x2484EAEC);
					continue;
				case 90u:
					pbxPlayersOnlineIcon.Name = "pbxPlayersOnlineIcon";
					pbxPlayersOnlineIcon.Size = new Size(40, 40);
					pbxPlayersOnlineIcon.SizeMode = PictureBoxSizeMode.Zoom;
					pbxPlayersOnlineIcon.TabIndex = 9;
					pbxPlayersOnlineIcon.TabStop = false;
					num = ((int)num2 * -817068185) ^ 0x24C088F8;
					continue;
				case 28u:
					pnlAbout.BackColor = Color.FromArgb(44, 31, 52);
					pnlAbout.BorderStyle = BorderStyle.FixedSingle;
					num = ((int)num2 * -1003876123) ^ -642503093;
					continue;
				case 63u:
					lblProxyWarning.Name = "lblProxyWarning";
					lblProxyWarning.RightToLeft = RightToLeft.No;
					num = ((int)num2 * -1036488444) ^ -2106512932;
					continue;
				case 44u:
					pbxProxyServer.TabStop = false;
					pnlLaunch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					pnlLaunch.BackColor = Color.FromArgb(44, 31, 52);
					num = (int)((num2 * 2090626599) ^ 0x512B658E);
					continue;
				case 18u:
					lblConnectionInfo.Text = "Connection Info";
					num = (int)((num2 * 2040279484) ^ 0x5990224B);
					continue;
				case 184u:
					lblConnectionInfo.TabIndex = 15;
					num = (int)((num2 * 717998347) ^ 0x6EC9506A);
					continue;
				case 47u:
					lblStartExalt.Size = new Size(139, 21);
					num = ((int)num2 * -1825889947) ^ 0x2B93855D;
					continue;
				case 127u:
					pbxLogo.Image = (Image)componentResourceManager.GetObject("pbxLogo.Image");
					pbxLogo.Location = new Point(3, 3);
					pbxLogo.Name = "pbxLogo";
					num = ((int)num2 * -1634534747) ^ -2137233611;
					continue;
				case 107u:
					lblConnectionInfo.ForeColor = Color.Gold;
					lblConnectionInfo.Location = new Point(42, 2);
					num = ((int)num2 * -1365869787) ^ -1171351217;
					continue;
				case 177u:
					pbxLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = ((int)num2 * -1022023394) ^ 0xE5EE853;
					continue;
				case 116u:
					pnlLaunch.Controls.Add(lblStartWarning);
					pnlLaunch.Controls.Add(tableLaunchers);
					num = (int)(num2 * 232634195) ^ -2033681642;
					continue;
				case 153u:
					btnInstructions.FlatStyle = FlatStyle.Flat;
					btnInstructions.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
					num = (int)(num2 * 615967256) ^ -1592642015;
					continue;
				case 42u:
					pnlAbout.PerformLayout();
					num = ((int)num2 * -1338713228) ^ 0x798A69FE;
					continue;
				case 92u:
					btnMultiLogin.BackgroundImage = (Image)componentResourceManager.GetObject("btnMultiLogin.BackgroundImage");
					btnMultiLogin.BackgroundImageLayout = ImageLayout.Zoom;
					btnMultiLogin.Dock = DockStyle.Fill;
					btnMultiLogin.FlatAppearance.BorderColor = Color.Lime;
					btnMultiLogin.FlatStyle = FlatStyle.Flat;
					num = (int)(num2 * 9889038) ^ -2134451597;
					continue;
				case 12u:
					btnClearLocations.Name = "btnClearLocations";
					btnClearLocations.Size = new Size(68, 12);
					btnClearLocations.TabIndex = 19;
					btnClearLocations.Text = "Clear locations";
					num = (int)(num2 * 789340778) ^ -1814115262;
					continue;
				case 79u:
					btnSteamLauncher.FlatAppearance.BorderColor = Color.LightSkyBlue;
					num = (int)(num2 * 1403742305) ^ -1916797599;
					continue;
				case 22u:
					pnlLaunch.Controls.Add(btnClearLocations);
					num = (int)((num2 * 1279940034) ^ 0x485194FF);
					continue;
				case 6u:
					tableLaunchers.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
					num = ((int)num2 * -655353334) ^ -85719082;
					continue;
				case 73u:
					pnlLaunch.PerformLayout();
					tableLaunchers.ResumeLayout(performLayout: false);
					ResumeLayout(performLayout: false);
					num = ((int)num2 * -1276977478) ^ 0x1EDF3648;
					continue;
				case 45u:
					lblChangeServer.AutoSize = true;
					lblChangeServer.BackColor = Color.Transparent;
					num = ((int)num2 * -225709983) ^ -1684550117;
					continue;
				case 150u:
					pbxClientsConnectedIcon.Size = new Size(40, 40);
					num = (int)(num2 * 342600816) ^ -283211016;
					continue;
				case 141u:
					lstServers.Name = "lstServers";
					lstServers.Size = new Size(207, 25);
					lstServers.TabIndex = 13;
					num = ((int)num2 * -614052186) ^ 0x5BCA2237;
					continue;
				case 83u:
					pnlLaunch.Location = new Point(3, 194);
					num = ((int)num2 * -1340284831) ^ -1237871264;
					continue;
				case 8u:
					btnSteamLauncher.Click += _GYGRookhWKYMM7vvKDWIhmMntqC;
					num = ((int)num2 * -1978981446) ^ 0x8336879;
					continue;
				case 124u:
					pnlAbout.Controls.Add(lblPlayersOnline);
					num = (int)((num2 * 872588074) ^ 0xD37682F);
					continue;
				case 114u:
					((ISupportInitialize)pbxLogo).EndInit();
					pnlAbout.ResumeLayout(performLayout: false);
					num = ((int)num2 * -133884759) ^ 0x2A35A95A;
					continue;
				case 52u:
					lblCurrentServer.AutoSize = true;
					num = (int)(num2 * 1401902807) ^ -53898723;
					continue;
				case 33u:
					lblProxyWarning.BackColor = Color.Transparent;
					lblProxyWarning.Font = new Font("Segoe UI", 8.25f);
					num = ((int)num2 * -371927241) ^ -2131019752;
					continue;
				case 78u:
					lblConnectionInfo.AutoSize = true;
					num = ((int)num2 * -486938383) ^ -1125867851;
					continue;
				case 120u:
					btnMultiLogin.Size = new Size(120, 56);
					btnMultiLogin.TabIndex = 9;
					btnMultiLogin.Text = "Multi Login";
					num = (int)((num2 * 2043300640) ^ 0x75203EC2);
					continue;
				case 50u:
					pnlServerSelect.Size = new Size(234, 82);
					num = (int)(num2 * 2059893184) ^ -72929631;
					continue;
				case 108u:
					pbxPlayersOnlineText.TabIndex = 12;
					num = ((int)num2 * -401766184) ^ -1893132952;
					continue;
				case 14u:
					lblCurrentServer.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = (int)((num2 * 1919436321) ^ 0x3B231A85);
					continue;
				case 104u:
					tableLaunchers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
					num = ((int)num2 * -1419280695) ^ 0x690AEBDA;
					continue;
				case 57u:
					lblProxyWarning.ForeColor = Color.Gold;
					lblProxyWarning.Location = new Point(43, 24);
					num = ((int)num2 * -1730512688) ^ -184503127;
					continue;
				case 132u:
					btnSteamLauncher.TabIndex = 8;
					btnSteamLauncher.Text = "Steam Launcher";
					btnSteamLauncher.TextAlign = ContentAlignment.TopCenter;
					btnSteamLauncher.UseVisualStyleBackColor = false;
					num = (int)(num2 * 557380215) ^ -1040346447;
					continue;
				case 139u:
					btnExaltLauncher = new Button();
					btnSteamLauncher = new Button();
					btnMultiLogin = new Button();
					num = ((int)num2 * -2023518129) ^ 0x6916EAC;
					continue;
				case 27u:
					lblProxyWarning = new Label();
					num = (int)((num2 * 1770419454) ^ 0x15C676FF);
					continue;
				case 121u:
					btnInstructions.Margin = new Padding(1);
					btnInstructions.Name = "btnInstructions";
					btnInstructions.Size = new Size(122, 56);
					btnInstructions.TabIndex = 10;
					btnInstructions.Text = "Instructions";
					num = ((int)num2 * -948625317) ^ -1249650232;
					continue;
				case 102u:
					btnSteamLauncher.FlatStyle = FlatStyle.Flat;
					btnSteamLauncher.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
					num = (int)(num2 * 728535059) ^ -132965022;
					continue;
				case 71u:
					btnInstructions.Click += OnInstructionsClick;
					btnExaltLauncher.BackColor = Color.FromArgb(162, 57, 202);
					num = (int)(num2 * 469774242) ^ -45166557;
					continue;
				case 133u:
					pnlServerSelect.Controls.Add(lblCurrentServer);
					num = (int)((num2 * 1384086421) ^ 0x72A2A42D);
					continue;
				case 25u:
					tableLaunchers.ColumnCount = 4;
					tableLaunchers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
					tableLaunchers.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25f));
					num = (int)(num2 * 378849613) ^ -540318457;
					continue;
				case 37u:
					pnlLaunch.ResumeLayout(performLayout: false);
					num = (int)((num2 * 1446492830) ^ 0x608DFE8C);
					continue;
				case 159u:
					lblConnectionInfo = new Label();
					num = (int)((num2 * 1498816053) ^ 0x784D9967);
					continue;
				case 74u:
					lblConnectionInfo.BackColor = Color.Transparent;
					num = (int)(num2 * 858790845) ^ -102967376;
					continue;
				case 157u:
					btnClearLocations.Cursor = Cursors.Hand;
					btnClearLocations.Font = new Font("Segoe UI", 7f);
					btnClearLocations.ForeColor = Color.Gold;
					num = ((int)num2 * -621057538) ^ -1127327141;
					continue;
				case 146u:
					pbxClientsConnectedIcon = new PictureBox();
					num = (int)((num2 * 727618683) ^ 0x2E8D899F);
					continue;
				case 161u:
					DoubleBuffered = true;
					num = ((int)num2 * -657623805) ^ -1141495831;
					continue;
				case 48u:
					pbxPlayersOnlineText.AutoSize = true;
					pbxPlayersOnlineText.BackColor = Color.Transparent;
					num = ((int)num2 * -1169438590) ^ 0x1C37AF0D;
					continue;
				case 41u:
					tableLaunchers.SuspendLayout();
					num = (int)(num2 * 1018624050) ^ -529871982;
					continue;
				case 76u:
					pnlLaunch.Controls.Add(lblStartExalt);
					pnlLaunch.Font = new Font("Segoe UI", 8.25f);
					num = (int)((num2 * 1983380279) ^ 0x283BC4AD);
					continue;
				case 69u:
					btnMultiLogin.Font = new Font("Segoe UI", 9.75f, FontStyle.Bold);
					num = (int)((num2 * 1127543154) ^ 0x77B7C694);
					continue;
				case 130u:
					pbxProxyServer.TabIndex = 15;
					num = ((int)num2 * -503649904) ^ 0x9B51398;
					continue;
				case 80u:
					lblStartExalt = new Label();
					((ISupportInitialize)pbxLogo).BeginInit();
					num = (int)((num2 * 1150193480) ^ 0x2B109C64);
					continue;
				case 152u:
					btnInstructions.TextAlign = ContentAlignment.TopCenter;
					num = (int)(num2 * 1133790591) ^ -457015410;
					continue;
				case 115u:
					lblStartExalt.BackColor = Color.Transparent;
					lblStartExalt.Font = new Font("Segoe UI Semibold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = (int)((num2 * 2078267329) ^ 0x36A67568);
					continue;
				case 151u:
					btnExaltLauncher.UseVisualStyleBackColor = false;
					num = ((int)num2 * -1557700390) ^ -2054045021;
					continue;
				case 135u:
					btnExaltLauncher.Text = "Exalt Launcher";
					num = (int)(num2 * 1476288748) ^ -1048262669;
					continue;
				case 1u:
					lblStartExalt.RightToLeft = RightToLeft.No;
					num = ((int)num2 * -111769452) ^ 0x48DF74C9;
					continue;
				case 64u:
					pnlAbout.Controls.Add(pbxPlayersOnlineIcon);
					pnlAbout.Font = new Font("Segoe UI", 8.25f);
					pnlAbout.Location = new Point(3, 109);
					pnlAbout.Name = "pnlAbout";
					pnlAbout.Size = new Size(257, 82);
					num = (int)(num2 * 888874561) ^ -950180438;
					continue;
				case 85u:
					base.AutoScaleDimensions = new SizeF(96f, 96f);
					num = ((int)num2 * -156902739) ^ 0x51B8A93D;
					continue;
				case 17u:
					lblPlayersOnline.Text = "0 RotMG Players Online";
					pnlAbout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
					num = (int)(num2 * 127309006) ^ -485639542;
					continue;
				case 112u:
					pnlAbout.SuspendLayout();
					num = ((int)num2 * -2096671641) ^ 0x6B59F45C;
					continue;
				case 43u:
					pbxPlayersOnlineText.Font = new Font("Segoe UI", 8.25f);
					num = ((int)num2 * -1948770490) ^ -829983354;
					continue;
				case 60u:
					lstServers.FormattingEnabled = true;
					num = (int)((num2 * 2140283939) ^ 0xF887859);
					continue;
				case 13u:
					lblCurrentServer.TabIndex = 14;
					lblCurrentServer.Text = "Proxy Server Destination";
					num = (int)(num2 * 487144343) ^ -1009552872;
					continue;
				case 53u:
					pnlServerSelect.BackColor = Color.FromArgb(44, 31, 52);
					pnlServerSelect.BorderStyle = BorderStyle.FixedSingle;
					num = (int)((num2 * 865676282) ^ 0x603E4C91);
					continue;
				case 36u:
					lstServers.Location = new Point(13, 47);
					num = ((int)num2 * -634880032) ^ -182115145;
					continue;
				case 38u:
					lblChangeServer.Name = "lblServerChangeInfo";
					num = (int)((num2 * 1268629268) ^ 0x20CD112E);
					continue;
				case 51u:
					tableLaunchers = new TableLayoutPanel();
					btnInstructions = new Button();
					num = (int)(num2 * 1273255120) ^ -219239669;
					continue;
				case 15u:
					pnlLaunch.Controls.Add(pbxClientsConnectedIcon);
					num = ((int)num2 * -1034848953) ^ 0x36F37DF3;
					continue;
				case 103u:
					btnExaltLauncher.BackgroundImage = (Image)componentResourceManager.GetObject("btnExaltLauncher.BackgroundImage");
					btnExaltLauncher.BackgroundImageLayout = ImageLayout.Zoom;
					btnExaltLauncher.Dock = DockStyle.Fill;
					num = ((int)num2 * -1252224499) ^ 0x4406D016;
					continue;
				case 171u:
					btnSteamLauncher.BackgroundImage = (Image)componentResourceManager.GetObject("btnSteamLauncher.BackgroundImage");
					btnSteamLauncher.BackgroundImageLayout = ImageLayout.Zoom;
					num = ((int)num2 * -1877279059) ^ -1012968459;
					continue;
				case 169u:
					base.Controls.Add(pbxLogo);
					num = ((int)num2 * -945534693) ^ 0x2E898664;
					continue;
				case 86u:
					((ISupportInitialize)pbxProxyServer).BeginInit();
					num = ((int)num2 * -1415603590) ^ 0x653DA7CA;
					continue;
				case 5u:
					lblStartWarning.AutoSize = true;
					num = (int)((num2 * 1512949746) ^ 0xB7AE117);
					continue;
				case 172u:
					lblStartExalt.ForeColor = Color.Gold;
					num = ((int)num2 * -728070044) ^ -264550040;
					continue;
				case 97u:
					pbxLogo = new PictureBox();
					num = ((int)num2 * -881712433) ^ -1215733779;
					continue;
				case 166u:
					lstServers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
					num = ((int)num2 * -123903211) ^ -490372691;
					continue;
				case 49u:
					pnlServerSelect.ResumeLayout(performLayout: false);
					pnlServerSelect.PerformLayout();
					num = (int)((num2 * 585552365) ^ 0x4680670C);
					continue;
				case 155u:
					lblStartExalt.Location = new Point(42, 2);
					lblStartExalt.Name = "lblStart";
					num = (int)(num2 * 548376993) ^ -1199187679;
					continue;
				case 128u:
					lblProxyWarning.AutoSize = true;
					num = (int)((num2 * 130878361) ^ 0x4CDEA81D);
					continue;
				case 134u:
					pnlLaunch.SuspendLayout();
					num = ((int)num2 * -1999132629) ^ -1745362801;
					continue;
				case 125u:
					btnSteamLauncher.Size = new Size(120, 56);
					num = (int)((num2 * 1477581686) ^ 0x4F2E8F3E);
					continue;
				case 156u:
					lblStartWarning.BackColor = Color.Transparent;
					lblStartWarning.Font = new Font("Segoe UI", 8.25f);
					lblStartWarning.ForeColor = Color.Gold;
					lblStartWarning.Location = new Point(43, 24);
					num = ((int)num2 * -66212480) ^ -409774330;
					continue;
				case 10u:
					pbxLogo.Size = new Size(494, 106);
					num = ((int)num2 * -1629930456) ^ 0x6622F331;
					continue;
				case 119u:
					btnClearLocations.Click += OnClearLocations;
					num = (int)(num2 * 1960757031) ^ -1892110465;
					continue;
				case 23u:
					pnlServerSelect.Location = new Point(263, 109);
					num = (int)((num2 * 1497288554) ^ 0x3C12A1C5);
					continue;
				case 96u:
					btnMultiLogin.ForeColor = Color.Lime;
					btnMultiLogin.Location = new Point(245, 1);
					btnMultiLogin.Margin = new Padding(1);
					btnMultiLogin.Name = "btnMultiLogin";
					num = (int)((num2 * 827499257) ^ 0x75166E10);
					continue;
				case 149u:
					lblProxyWarning.Text = "You must be connected to Proxy Server";
					num = (int)(num2 * 1575475242) ^ -34058679;
					continue;
				case 24u:
					pbxPlayersOnlineText.RightToLeft = RightToLeft.No;
					num = ((int)num2 * -1836292148) ^ -1180632280;
					continue;
				case 39u:
					pnlServerSelect.Controls.Add(lblChangeServer);
					num = (int)(num2 * 470520313) ^ -1947403084;
					continue;
				case 95u:
					pnlServerSelect.Name = "pnlServerSelect";
					num = ((int)num2 * -217167352) ^ -338913767;
					continue;
				case 109u:
					pbxLogo.SizeMode = PictureBoxSizeMode.Zoom;
					pbxLogo.TabIndex = 1;
					pbxLogo.TabStop = false;
					num = (int)(num2 * 837435316) ^ -862191612;
					continue;
				case 100u:
					lblPlayersOnline.Location = new Point(44, 58);
					lblPlayersOnline.Name = "lblPlayersOnine";
					lblPlayersOnline.RightToLeft = RightToLeft.No;
					lblPlayersOnline.Size = new Size(128, 13);
					lblPlayersOnline.TabIndex = 6;
					num = (int)(num2 * 1024054040) ^ -706691096;
					continue;
				case 56u:
					pbxClientsConnectedIcon.SizeMode = PictureBoxSizeMode.Zoom;
					num = (int)(num2 * 1746492855) ^ -2123117508;
					continue;
				case 145u:
					pbxProxyServer.SizeMode = PictureBoxSizeMode.Zoom;
					num = (int)(num2 * 256543752) ^ -2135574341;
					continue;
				case 75u:
					tableLaunchers.Name = "tableLaunchers";
					tableLaunchers.RowCount = 1;
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
			lstServers.SelectedItem = Settings.Default.CurrentServer;
		});
	}

	[CompilerGenerated]
	private void _D7CcWZWAjlgZso34RBB8G6pNWxF()
	{
		lstServers.SelectedItem = Settings.Default.CurrentServer;
	}

	[CompilerGenerated]
	private void _hW7PpTf6lHJhlyeU7g2Pg0KKTOd(Client c)
	{
		Invoke((MethodInvoker)delegate
		{
			pbxPlayersOnlineText.Text = $"{++_9Coezm0vxBE08bEqBB0AlKC3e7B} Exalt Client{((_9Coezm0vxBE08bEqBB0AlKC3e7B > 1 || _9Coezm0vxBE08bEqBB0AlKC3e7B == 0) ? 's' : ' ')} Connected";
		});
	}

	[CompilerGenerated]
	private void _iaZermLvF0rDR8HCkLMbzHvKXSn()
	{
		pbxPlayersOnlineText.Text = $"{++_9Coezm0vxBE08bEqBB0AlKC3e7B} Exalt Client{((_9Coezm0vxBE08bEqBB0AlKC3e7B > 1 || _9Coezm0vxBE08bEqBB0AlKC3e7B == 0) ? 's' : ' ')} Connected";
	}

	[CompilerGenerated]
	private void _Qh8D2HTdPv3OLiHIOROlSXMWrsZ(Client c)
	{
		Invoke((MethodInvoker)delegate
		{
			pbxPlayersOnlineText.Text = $"{--_9Coezm0vxBE08bEqBB0AlKC3e7B} Exalt Client{((_9Coezm0vxBE08bEqBB0AlKC3e7B > 1 || _9Coezm0vxBE08bEqBB0AlKC3e7B == 0) ? 's' : ' ')} Connected";
		});
	}

	[CompilerGenerated]
	private void _cfcqrYq50vc9tLcoXs671jcuETE()
	{
		pbxPlayersOnlineText.Text = $"{--_9Coezm0vxBE08bEqBB0AlKC3e7B} Exalt Client{((_9Coezm0vxBE08bEqBB0AlKC3e7B > 1 || _9Coezm0vxBE08bEqBB0AlKC3e7B == 0) ? 's' : ' ')} Connected";
	}
}
