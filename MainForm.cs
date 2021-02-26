using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExaltMultiTool;

internal class MainForm : Form {
	[CompilerGenerated] private LocalProxy _IKOmts76oBl90Xlm0Aw2A4moJcd;

	private _FS6jMJJePXheZSSgdbcle1Cf3eK _sPErbpKqY0mmEI36IOE5n9JEeUB;

	private _K3TiPWyBDUpgQKKDVFVeRQ0N4cX _0p3Brd5rbHU6G4v0UTyLsnWPJ2d;

	private ControlPanelForm ctrlPanelForm;

	private InstructionsForm instructionsForm;

	private IContainer _Container;

	private ImageList imageList;

	private Panel pnlContent;

	private Panel pnlStrip;

	private MenuStrip menuStrip;

	private ToolStripMenuItem btnAbout;

	private ToolStripMenuItem btnHacks;

	private ToolStripMenuItem lblVersion;

	private ToolStripMenuItem instructionsToolStripMenuItem;

	private Timer timer;

	public LocalProxy _ProxyServer { get; private set; }

	public MainForm()
	{
		LoadResources();
		_ProxyServer = new LocalProxy();
	}

	[AsyncStateMachine(typeof(_FjdiqLrGVaHBcAu4Rq92FM9vL7I))]
	private void _PnabFdaHeNip6yrE1w2T0lOQNY5(object sender, EventArgs e)
	{
		_FjdiqLrGVaHBcAu4Rq92FM9vL7I stateMachine = default(_FjdiqLrGVaHBcAu4Rq92FM9vL7I);
		stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo = AsyncVoidMethodBuilder.Create();
		while (true) {
			int num = -840091936;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0x9F747F5Du) % 4u) {
					case 3u:
						break;
					case 1u:
						stateMachine._7DEudk1H4zeA6HRBegB5UK6RcSYA = this;
						num = (int) (num2 * 625157375) ^ -364582438;
						continue;
					case 0u:
						stateMachine._PBb43473kLxvAWjGhIbcR02LyrK = -1;
						num = (int) ((num2 * 1243890228) ^ 0x18B80AAF);
						continue;
					default:
						stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo.Start(ref stateMachine);
						return;
				}

				break;
			}
		}
	}

	private void _nWNC2n3d6mM4TKIRjZMk5IcaAc3(object sender, EventArgs e)
	{
		_sPErbpKqY0mmEI36IOE5n9JEeUB.BringToFront();
	}

	private void _cjAqFPFbW329JYZnkT0wAIi7ehk(object sender, EventArgs e)
	{
		_0p3Brd5rbHU6G4v0UTyLsnWPJ2d.BringToFront();
	}

	public void _8oPM3VHU7XKNB30XxFjCRfroQLo(object sender, EventArgs e)
	{
		ctrlPanelForm.BringToFront();
	}

	public void _GU6csqtcZcVmT42WMdJViL1lkGK(object sender, EventArgs e)
	{
		instructionsForm.BringToFront();
	}

	private void OnClientLinkClick(object sender, EventArgs e)
	{
		Process.Start("https://realmstock.com/pages/rotmg-unity-exalt-hacks-cheats");
	}

	private void OnCloseWindow(object sender, FormClosingEventArgs e)
	{
		if (!menuStrip.Enabled) {
			return;
		}

		DialogResult dialogResult = MessageBox.Show(base.ParentForm, "Are you sure you want to EXIT?",
			"RealmStock Multi-Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		e.Cancel = dialogResult == DialogResult.No;
	}

	private void onFormClose(object sender, FormClosedEventArgs e)
	{
		Settings.Default.Save();
	}

	public void OnSetHotKey(int id, Keys key)
	{
		ProcessInjection.RegisterHotKey(base.Handle, id, 0, key.GetHashCode());
	}

	public void OnUnsetHotKey(int id)
	{
		ProcessInjection.UnregisterHotKey(base.Handle, id);
	}

	protected override void _o9LC3d2fqsm2Dt4NyGei59EBiIn(ref Message m)
	{
		WndProc(ref m);
		int id = default(int);
		IntPtr wParam = default(IntPtr);
		while (true) {
			int num = 1991720026;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0x65293D0Cu) % 7u) {
					case 4u:
						break;
					default:
						return;
					case 5u: {
						int num3;
						int num4;
						if (m.Msg == 786) {
							num3 = -443738030;
							num4 = num3;
						}
						else {
							num3 = -223662011;
							num4 = num3;
						}

						num = num3 ^ ((int) num2 * -518101423);
						continue;
					}
					case 2u:
						_ProxyServer._VEPDVp0jqs3FA5VFgwULGcPV6RZ(id);
						num = (int) ((num2 * 1645570847) ^ 0x1FEED4DB);
						continue;
					case 1u:
						id = wParam.ToInt32();
						num = ((int) num2 * -64415464) ^ -871532900;
						continue;
					case 3u:
						_ = ((int) m.LParam >> 16) & 0xFFFF;
						wParam = m.WParam;
						num = ((int) num2 * -1718558528) ^ 0x335E8644;
						continue;
					case 6u: {
						ProcessInjection.WindowThreadProcessId(
							ProcessInjection.GetForegroundWindow(), out var _);
						num = (int) (num2 * 47308567) ^ -438787740;
						continue;
					}
					case 0u:
						return;
				}

				break;
			}
		}
	}

	private void OnStartLauncherClick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("RotMG Exalt Launcher");
		int num3 = default(int);
		Process process = default(Process);
		while (true) {
			int num = 2081880138;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0x6C946EDDu) % 9u) {
					case 6u:
						break;
					default:
						return;
					case 3u:
						num3 = 0;
						num = (int) ((num2 * 393131106) ^ 0x72FDDE5B);
						continue;
					case 7u: {
						int num5;
						int num6;
						if (!InjectionHelper.ProcessIds.Contains(process.Id)) {
							num5 = 1155318803;
							num6 = num5;
						}
						else {
							num5 = 2135247566;
							num6 = num5;
						}

						num = num5 ^ ((int) num2 * -1560391316);
						continue;
					}
					case 1u:
						InjectionHelper.ProcessIds.Add(process.Id);
						MessageBox.Show("RotMG Exalt must be launched via the Multi Tool in order for hacks to apply!",
							"Exalt Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						num = (int) (num2 * 621592506) ^ -1340124238;
						continue;
					case 0u:
						num = ((int) num2 * -6825139) ^ 0x7274BAA2;
						continue;
					case 4u:
						process = processesByName[num3];
						num = 1944410761;
						continue;
					case 8u:
						num3++;
						num = 1344364554;
						continue;
					case 5u: {
						int num4;
						if (num3 < processesByName.Length) {
							num = 1034247995;
							num4 = num;
						}
						else {
							num = 991801330;
							num4 = num;
						}

						continue;
					}
					case 2u:
						return;
				}

				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing) {
			goto IL_0003;
		}

		goto IL_002d;
		IL_002d:
		Dispose(disposing);
		int num = 200713001;
		goto IL_0008;
		IL_0008:
		while (true) {
			uint num2;
			switch ((num2 = (uint) num ^ 0x5BE119DFu) % 5u) {
				case 4u:
					break;
				default:
					return;
				case 3u:
					goto IL_002d;
				case 2u:
					_Container.Dispose();
					num = (int) (num2 * 143079904) ^ -1438456499;
					continue;
				case 1u: {
					int num3;
					int num4;
					if (_Container != null) {
						num3 = -1325774401;
						num4 = num3;
					}
					else {
						num3 = -702490257;
						num4 = num3;
					}

					num = num3 ^ (int) (num2 * 2142066987);
					continue;
				}
				case 0u:
					return;
			}

			break;
		}

		goto IL_0003;
		IL_0003:
		num = 2030818169;
		goto IL_0008;
	}

	private void LoadResources()
	{
		_Container = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		while (true) {
			int num = -980225411;
			while (true) {
				uint num2;
				switch ((num2 = (uint) num ^ 0xB2AFB436u) % 48u) {
					case 8u:
						break;
					case 0u:
						lblVersion.Text = "For Exalt X1.3.1.0.0";
						num = ((int) num2 * -360168117) ^ -1384489657;
						continue;
					case 35u:
						btnAbout.Click += _nWNC2n3d6mM4TKIRjZMk5IcaAc3;
						num = ((int) num2 * -39973096) ^ 0x466EF761;
						continue;
					case 16u:
						base.AutoScaleMode = AutoScaleMode.Dpi;
						BackColor = Color.Black;
						num = ((int) num2 * -1047768317) ^ 0x785CE354;
						continue;
					case 19u:
						base.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
						base.MaximizeBox = false;
						num = ((int) num2 * -1728412453) ^ 0x2CCDFF6E;
						continue;
					case 28u:
						btnAbout.Text = "Start";
						num = ((int) num2 * -1461797703) ^ -1893020231;
						continue;
					case 30u:
						DoubleBuffered = true;
						Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
						num = ((int) num2 * -891468744) ^ 0x2181CD45;
						continue;
					case 20u:
						menuStrip.ResumeLayout(performLayout: false);
						menuStrip.PerformLayout();
						num = ((int) num2 * -1400860324) ^ 0x8F351EB;
						continue;
					case 18u:
						pnlStrip.SuspendLayout();
						menuStrip.SuspendLayout();
						SuspendLayout();
						num = ((int) num2 * -41414382) ^ -601297836;
						continue;
					case 27u:
						menuStrip = new MenuStrip();
						num = (int) ((num2 * 667676371) ^ 0x43BE611D);
						continue;
					case 4u:
						lblVersion.Image =
							(Image) componentResourceManager.GetObject("lblVersion.Image");
						lblVersion.Name = "lblVersion";
						num = (int) ((num2 * 1117308565) ^ 0x11927395);
						continue;
					case 14u:
						pnlContent.Name = "pnlContent";
						pnlContent.Size = new Size(560, 342);
						num = ((int) num2 * -878268699) ^ -621013233;
						continue;
					case 41u:
						MinimumSize = new Size(600, 450);
						base.Name = "FrmMultiTool";
						Text = "RealmStock Exalt Multi-Tool v0.23d";
						base.FormClosing += OnCloseWindow;
						num = (int) ((num2 * 882658797) ^ 0x4DD90D45);
						continue;
					case 34u:
						btnHacks.Image =
							(Image) componentResourceManager.GetObject("btnHacks.Image");
						btnHacks.Name = "btnHacks";
						btnHacks.Size = new Size(85, 33);
						btnHacks.Text = "Hacks";
						btnHacks.Click += _cjAqFPFbW329JYZnkT0wAIi7ehk;
						lblVersion.Alignment = ToolStripItemAlignment.Right;
						lblVersion.ForeColor = Color.Gold;
						num = ((int) num2 * -3383682) ^ 0x3BAFB7E;
						continue;
					case 23u:
						pnlContent = new Panel();
						pnlStrip = new Panel();
						num = ((int) num2 * -1326145905) ^ -803245292;
						continue;
					case 32u:
						instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
						instructionsToolStripMenuItem.Size = new Size(121, 33);
						instructionsToolStripMenuItem.Text = "Instructions";
						num = ((int) num2 * -551465386) ^ -1161875193;
						continue;
					case 9u:
						pnlStrip.PerformLayout();
						num = (int) (num2 * 525322542) ^ -271075268;
						continue;
					case 44u:
						BackgroundImageLayout = ImageLayout.Stretch;
						num = ((int) num2 * -1163938881) ^ -1402246489;
						continue;
					case 21u:
						base.ClientSize = new Size(584, 411);
						base.Controls.Add(pnlStrip);
						base.Controls.Add(pnlContent);
						num = ((int) num2 * -56046519) ^ 0x5A7134E5;
						continue;
					case 46u:
						base.Shown += _PnabFdaHeNip6yrE1w2T0lOQNY5;
						num = (int) ((num2 * 1105271890) ^ 0x353F7DA0);
						continue;
					case 36u:
						btnAbout.Image =
							(Image) componentResourceManager.GetObject("btnAbout.Image");
						btnAbout.Name = "btnAbout";
						btnAbout.Size = new Size(77, 33);
						num = (int) (num2 * 1393430669) ^ -1440301394;
						continue;
					case 13u:
						pnlContent.BorderStyle = BorderStyle.FixedSingle;
						pnlContent.Location = new Point(12, 57);
						num = ((int) num2 * -1853723983) ^ 0x43513875;
						continue;
					case 38u:
						base.FormClosed += onFormClose;
						num = ((int) num2 * -1347633006) ^ 0x6F2602D4;
						continue;
					case 15u:
						pnlContent.TabIndex = 1;
						num = (int) (num2 * 1809742800) ^ -2002911046;
						continue;
					case 25u:
						pnlContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
						                                      AnchorStyles.Left | AnchorStyles.Right;
						pnlContent.BackColor = Color.FromArgb(14, 11, 22);
						pnlContent.BackgroundImage =
							(Image) componentResourceManager.GetObject("pnlContent.BackgroundImage");
						num = (int) (num2 * 1946084431) ^ -2119255767;
						continue;
					case 42u:
						timer.Interval = 3000;
						timer.Tick += OnStartLauncherClick;
						num = ((int) num2 * -1394676259) ^ -89096063;
						continue;
					case 5u:
						base.AutoScaleDimensions = new SizeF(96f, 96f);
						num = ((int) num2 * -540032257) ^ -533037427;
						continue;
					case 6u:
						imageList.ImageStream =
							(ImageListStreamer) componentResourceManager.GetObject("imagesTabs.ImageStream");
						imageList.TransparentColor = Color.Transparent;
						num = ((int) num2 * -200336298) ^ 0x49CA0C67;
						continue;
					case 2u:
						BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
						num = (int) (num2 * 1918292426) ^ -2099668482;
						continue;
					case 3u:
						btnHacks.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
						btnHacks.ForeColor = Color.Gold;
						num = (int) ((num2 * 1157351681) ^ 0x3F0AE6C7);
						continue;
					case 43u:
						imageList = new ImageList(_Container);
						num = (int) ((num2 * 1146838945) ^ 0x2A42382A);
						continue;
					case 40u:
						pnlContent.BackgroundImageLayout = ImageLayout.Zoom;
						num = (int) (num2 * 414665822) ^ -935751221;
						continue;
					case 11u:
						menuStrip.Enabled = false;
						menuStrip.ImageScalingSize = new Size(24, 24);
						menuStrip.Items.AddRange(new ToolStripItem[4]
						{
							btnAbout,
							instructionsToolStripMenuItem,
							btnHacks,
							lblVersion
						});
						num = ((int) num2 * -1967784721) ^ 0x781B6725;
						continue;
					case 22u:
						menuStrip.Location = new Point(0, 0);
						num = (int) (num2 * 1708947951) ^ -29506013;
						continue;
					case 17u:
						pnlStrip.Name = "pnlStrip";
						num = (int) ((num2 * 1868666428) ^ 0xB4FFA37);
						continue;
					case 31u:
						menuStrip.Name = "stripMain";
						menuStrip.Size = new Size(558, 37);
						menuStrip.TabIndex = 2;
						menuStrip.Text = "menuStrip1";
						btnAbout.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
						btnAbout.ForeColor = Color.Gold;
						num = ((int) num2 * -2037727789) ^ -2011314785;
						continue;
					case 10u:
						pnlStrip.ResumeLayout(performLayout: false);
						num = (int) (num2 * 2106473021) ^ -2076455043;
						continue;
					case 45u:
						pnlStrip.Size = new Size(560, 39);
						pnlStrip.TabIndex = 2;
						menuStrip.BackgroundImage =
							(Image) componentResourceManager.GetObject("stripMain.BackgroundImage");
						menuStrip.Dock = DockStyle.Fill;
						num = (int) (num2 * 242745370) ^ -449790337;
						continue;
					case 33u:
						lblVersion.Click += OnClientLinkClick;
						num = (int) ((num2 * 469677311) ^ 0x6CDE9F1E);
						continue;
					case 24u:
						lblVersion = new ToolStripMenuItem();
						timer = new Timer(_Container);
						num = ((int) num2 * -191228145) ^ -1894647636;
						continue;
					case 47u:
						instructionsToolStripMenuItem.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
						instructionsToolStripMenuItem.ForeColor = Color.Gold;
						instructionsToolStripMenuItem.Image =
							(Image) componentResourceManager.GetObject("instructionsToolStripMenuItem.Image");
						num = (int) ((num2 * 315973106) ^ 0x156547E8);
						continue;
					case 12u:
						pnlStrip.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
						pnlStrip.BorderStyle = BorderStyle.FixedSingle;
						pnlStrip.Controls.Add(menuStrip);
						pnlStrip.Location = new Point(12, 12);
						num = (int) ((num2 * 535178139) ^ 0x279318C3);
						continue;
					case 1u:
						instructionsToolStripMenuItem.Click += _GU6csqtcZcVmT42WMdJViL1lkGK;
						num = ((int) num2 * -740485682) ^ -1190279413;
						continue;
					case 26u:
						btnAbout = new ToolStripMenuItem();
						instructionsToolStripMenuItem = new ToolStripMenuItem();
						btnHacks = new ToolStripMenuItem();
						num = (int) ((num2 * 558971674) ^ 0x2DD6D94A);
						continue;
					case 39u:
						timer.Enabled = true;
						num = ((int) num2 * -1331710237) ^ -2045404391;
						continue;
					case 37u:
						imageList.Images.SetKeyName(0, "Crown.png");
						num = ((int) num2 * -492535975) ^ -765312382;
						continue;
					case 7u:
						lblVersion.Size = new Size(139, 33);
						num = ((int) num2 * -1204561361) ^ 0xE57226F;
						continue;
					default:
						ResumeLayout(performLayout: false);
						return;
				}

				break;
			}
		}
	}

	[CompilerGenerated]
	private void StartProxy()
	{
		try {
			Program.LogInfoMessage("core", "Initializing proxy...");
			ResourceDownloader._uLt6b1uwFNgoZycBDqE02WmgdfB();
			ServerList.GetServerList();
			while (true) {
				int num = 1317307132;
				while (true) {
					uint num2;
					switch ((num2 = (uint) num ^ 0x50FFB520u) % 3u) {
						case 0u:
							break;
						default:
							return;
						case 2u:
							goto IL_003b;
						case 1u:
							return;
					}

					break;
					IL_003b:
					_ProxyServer.Start();
					num = (int) (num2 * 1401915683) ^ -2028665882;
				}
			}
		}
		catch (Exception ex) {
			while (true) {
				int num3 = 1520978539;
				while (true) {
					uint num2;
					Form parentForm;
					string obj;
					switch ((num2 = (uint) num3 ^ 0x50FFB520u) % 3u) {
						case 2u:
							break;
						default:
							return;
						case 1u:
							parentForm = base.ParentForm;
							obj = ex?.ToString();
							goto IL_0092;
						case 0u:
							return;
					}

					break;
					IL_0092:
					MessageBox.Show(parentForm,
						"Failed to initialize Proxy!\n\nPlease make sure:\n- Your AntiVirus is not blocking this program\n- This no other Exalt tools are running\n- Loading the client normally works fine\n\nMore details:\n" +
						obj);
					Close();
					num3 = 1335130281;
				}
			}
		}
	}
}