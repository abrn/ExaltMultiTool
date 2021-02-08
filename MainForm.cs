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

	private ControlPanelForm _nG2MucfACsUyiknR5T0En28BPR9;

	private InstructionsForm _tWgVuVjdz9gN1kXjtaNba3vSuog;

	private IContainer _Container;

	private ImageList _flZd9LBaLgVakccv6pbLoGboeCNC;

	private Panel _cfQ2nBR9VK5laOFiZilpN0GbzVR;

	private Panel _pAd0oJasDmAkdcjhMZe1JDlbSjr;

	private MenuStrip _hb5d30EUq0EopY266mbeS55K6Ii;

	private ToolStripMenuItem _FX7AVuhJzGgyhrUztEbr6Gya5ZO;

	private ToolStripMenuItem _EfkqSC9gduqvfMt8mYtx5jO0THg;

	private ToolStripMenuItem _xtcKg1sWRCBuiuJxm3CtyQ3G3sc;

	private ToolStripMenuItem _oT4alXeTqsHmh8APqbHB941Uzlc;

	private Timer _O3LpaCvM1vP0FMX2OknddbMCJAn;

	public LocalProxy _K7ZdnyAWKqJeAPIhC4xsrSzRGat { get; private set; }

	public MainForm()
	{
		LoadResources();
		_K7ZdnyAWKqJeAPIhC4xsrSzRGat = new LocalProxy();
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
		_nG2MucfACsUyiknR5T0En28BPR9.BringToFront();
	}

	public void _GU6csqtcZcVmT42WMdJViL1lkGK(object sender, EventArgs e)
	{
		_tWgVuVjdz9gN1kXjtaNba3vSuog.BringToFront();
	}

	private void _OcW4ga88AD1dLk4jK6VSMcUIehK(object sender, EventArgs e)
	{
		Process.Start("https://realmstock.com/pages/rotmg-unity-exalt-hacks-cheats");
	}

	private void _WrLHruSzr730Cwj4t9rYX0YJtGe(object sender, FormClosingEventArgs e)
	{
		//Discarded unreachable code: IL_0038
		if (!_hb5d30EUq0EopY266mbeS55K6Ii.Enabled) {
			goto IL_000d;
		}

		goto IL_0060;
		IL_0060:
		DialogResult dialogResult = MessageBox.Show(base.ParentForm, "Are you sure you want to EXIT?",
			"RealmStock Multi-Tool", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
		int num = 1625179209;
		goto IL_0012;
		IL_0012:
		while (true) {
			uint num2;
			switch ((num2 = (uint) num ^ 0x1F9A9EFEu) % 5u) {
				case 0u:
					break;
				default:
					return;
				case 3u:
					return;
				case 1u:
					e.Cancel = dialogResult == DialogResult.No;
					num = (int) (num2 * 1692052679) ^ -1068942345;
					continue;
				case 4u:
					goto IL_0060;
				case 2u:
					return;
			}

			break;
		}

		goto IL_000d;
		IL_000d:
		num = 2029686428;
		goto IL_0012;
	}

	private void onFormClose(object sender, FormClosedEventArgs e)
	{
		Settings.Default.Save();
	}

	public void _QKylz9L5nSub0zyZUBw5cjpWDdL(int id, Keys key)
	{
		ProcessInjection._ays3S5z2xKCPIbcZFwkO0Be8WEE(base.Handle, id, 0, key.GetHashCode());
	}

	public void _YnA0nTNh4MhhIPLXkJj3JrCKP6g(int id)
	{
		ProcessInjection._HXVpLlj5YH2Zu8xy1nZBQFDbcJf(base.Handle, id);
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
						_K7ZdnyAWKqJeAPIhC4xsrSzRGat._VEPDVp0jqs3FA5VFgwULGcPV6RZ(id);
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

	private void _AhpKC6FE5BCubyreqY5O2lZYQAN(object sender, EventArgs e)
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
						if (!InjectionHelper._xybJ0vsmMJNJo4QA7CWP9YTKANn.Contains(process.Id)) {
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
						InjectionHelper._xybJ0vsmMJNJo4QA7CWP9YTKANn.Add(process.Id);
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

	protected override void _8H2QqjADGkx30Hq77Uf9ZGuRzFD(bool disposing)
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
						_xtcKg1sWRCBuiuJxm3CtyQ3G3sc.Text = "For Exalt X1.3.1.0.0";
						num = ((int) num2 * -360168117) ^ -1384489657;
						continue;
					case 35u:
						_FX7AVuhJzGgyhrUztEbr6Gya5ZO.Click += _nWNC2n3d6mM4TKIRjZMk5IcaAc3;
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
						_FX7AVuhJzGgyhrUztEbr6Gya5ZO.Text = "Start";
						num = ((int) num2 * -1461797703) ^ -1893020231;
						continue;
					case 30u:
						DoubleBuffered = true;
						Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
						num = ((int) num2 * -891468744) ^ 0x2181CD45;
						continue;
					case 20u:
						_hb5d30EUq0EopY266mbeS55K6Ii.ResumeLayout(performLayout: false);
						_hb5d30EUq0EopY266mbeS55K6Ii.PerformLayout();
						num = ((int) num2 * -1400860324) ^ 0x8F351EB;
						continue;
					case 18u:
						_pAd0oJasDmAkdcjhMZe1JDlbSjr.SuspendLayout();
						_hb5d30EUq0EopY266mbeS55K6Ii.SuspendLayout();
						SuspendLayout();
						num = ((int) num2 * -41414382) ^ -601297836;
						continue;
					case 27u:
						_hb5d30EUq0EopY266mbeS55K6Ii = new MenuStrip();
						num = (int) ((num2 * 667676371) ^ 0x43BE611D);
						continue;
					case 4u:
						_xtcKg1sWRCBuiuJxm3CtyQ3G3sc.Image =
							(Image) componentResourceManager.GetObject("lblVersion.Image");
						_xtcKg1sWRCBuiuJxm3CtyQ3G3sc.Name = "lblVersion";
						num = (int) ((num2 * 1117308565) ^ 0x11927395);
						continue;
					case 14u:
						_cfQ2nBR9VK5laOFiZilpN0GbzVR.Name = "pnlContent";
						_cfQ2nBR9VK5laOFiZilpN0GbzVR.Size = new Size(560, 342);
						num = ((int) num2 * -878268699) ^ -621013233;
						continue;
					case 41u:
						MinimumSize = new Size(600, 450);
						base.Name = "FrmMultiTool";
						Text = "RealmStock Exalt Multi-Tool v0.23d";
						base.FormClosing += _WrLHruSzr730Cwj4t9rYX0YJtGe;
						num = (int) ((num2 * 882658797) ^ 0x4DD90D45);
						continue;
					case 34u:
						_EfkqSC9gduqvfMt8mYtx5jO0THg.Image =
							(Image) componentResourceManager.GetObject("btnHacks.Image");
						_EfkqSC9gduqvfMt8mYtx5jO0THg.Name = "btnHacks";
						_EfkqSC9gduqvfMt8mYtx5jO0THg.Size = new Size(85, 33);
						_EfkqSC9gduqvfMt8mYtx5jO0THg.Text = "Hacks";
						_EfkqSC9gduqvfMt8mYtx5jO0THg.Click += _cjAqFPFbW329JYZnkT0wAIi7ehk;
						_xtcKg1sWRCBuiuJxm3CtyQ3G3sc.Alignment = ToolStripItemAlignment.Right;
						_xtcKg1sWRCBuiuJxm3CtyQ3G3sc.ForeColor = Color.Gold;
						num = ((int) num2 * -3383682) ^ 0x3BAFB7E;
						continue;
					case 23u:
						_cfQ2nBR9VK5laOFiZilpN0GbzVR = new Panel();
						_pAd0oJasDmAkdcjhMZe1JDlbSjr = new Panel();
						num = ((int) num2 * -1326145905) ^ -803245292;
						continue;
					case 32u:
						_oT4alXeTqsHmh8APqbHB941Uzlc.Name = "instructionsToolStripMenuItem";
						_oT4alXeTqsHmh8APqbHB941Uzlc.Size = new Size(121, 33);
						_oT4alXeTqsHmh8APqbHB941Uzlc.Text = "Instructions";
						num = ((int) num2 * -551465386) ^ -1161875193;
						continue;
					case 9u:
						_pAd0oJasDmAkdcjhMZe1JDlbSjr.PerformLayout();
						num = (int) (num2 * 525322542) ^ -271075268;
						continue;
					case 44u:
						BackgroundImageLayout = ImageLayout.Stretch;
						num = ((int) num2 * -1163938881) ^ -1402246489;
						continue;
					case 21u:
						base.ClientSize = new Size(584, 411);
						base.Controls.Add(_pAd0oJasDmAkdcjhMZe1JDlbSjr);
						base.Controls.Add(_cfQ2nBR9VK5laOFiZilpN0GbzVR);
						num = ((int) num2 * -56046519) ^ 0x5A7134E5;
						continue;
					case 46u:
						base.Shown += _PnabFdaHeNip6yrE1w2T0lOQNY5;
						num = (int) ((num2 * 1105271890) ^ 0x353F7DA0);
						continue;
					case 36u:
						_FX7AVuhJzGgyhrUztEbr6Gya5ZO.Image =
							(Image) componentResourceManager.GetObject("btnAbout.Image");
						_FX7AVuhJzGgyhrUztEbr6Gya5ZO.Name = "btnAbout";
						_FX7AVuhJzGgyhrUztEbr6Gya5ZO.Size = new Size(77, 33);
						num = (int) (num2 * 1393430669) ^ -1440301394;
						continue;
					case 13u:
						_cfQ2nBR9VK5laOFiZilpN0GbzVR.BorderStyle = BorderStyle.FixedSingle;
						_cfQ2nBR9VK5laOFiZilpN0GbzVR.Location = new Point(12, 57);
						num = ((int) num2 * -1853723983) ^ 0x43513875;
						continue;
					case 38u:
						base.FormClosed += onFormClose;
						num = ((int) num2 * -1347633006) ^ 0x6F2602D4;
						continue;
					case 15u:
						_cfQ2nBR9VK5laOFiZilpN0GbzVR.TabIndex = 1;
						num = (int) (num2 * 1809742800) ^ -2002911046;
						continue;
					case 25u:
						_cfQ2nBR9VK5laOFiZilpN0GbzVR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |
						                                      AnchorStyles.Left | AnchorStyles.Right;
						_cfQ2nBR9VK5laOFiZilpN0GbzVR.BackColor = Color.FromArgb(14, 11, 22);
						_cfQ2nBR9VK5laOFiZilpN0GbzVR.BackgroundImage =
							(Image) componentResourceManager.GetObject("pnlContent.BackgroundImage");
						num = (int) (num2 * 1946084431) ^ -2119255767;
						continue;
					case 42u:
						_O3LpaCvM1vP0FMX2OknddbMCJAn.Interval = 3000;
						_O3LpaCvM1vP0FMX2OknddbMCJAn.Tick += _AhpKC6FE5BCubyreqY5O2lZYQAN;
						num = ((int) num2 * -1394676259) ^ -89096063;
						continue;
					case 5u:
						base.AutoScaleDimensions = new SizeF(96f, 96f);
						num = ((int) num2 * -540032257) ^ -533037427;
						continue;
					case 6u:
						_flZd9LBaLgVakccv6pbLoGboeCNC.ImageStream =
							(ImageListStreamer) componentResourceManager.GetObject("imagesTabs.ImageStream");
						_flZd9LBaLgVakccv6pbLoGboeCNC.TransparentColor = Color.Transparent;
						num = ((int) num2 * -200336298) ^ 0x49CA0C67;
						continue;
					case 2u:
						BackgroundImage = (Image) componentResourceManager.GetObject("$this.BackgroundImage");
						num = (int) (num2 * 1918292426) ^ -2099668482;
						continue;
					case 3u:
						_EfkqSC9gduqvfMt8mYtx5jO0THg.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
						_EfkqSC9gduqvfMt8mYtx5jO0THg.ForeColor = Color.Gold;
						num = (int) ((num2 * 1157351681) ^ 0x3F0AE6C7);
						continue;
					case 43u:
						_flZd9LBaLgVakccv6pbLoGboeCNC = new ImageList(_Container);
						num = (int) ((num2 * 1146838945) ^ 0x2A42382A);
						continue;
					case 40u:
						_cfQ2nBR9VK5laOFiZilpN0GbzVR.BackgroundImageLayout = ImageLayout.Zoom;
						num = (int) (num2 * 414665822) ^ -935751221;
						continue;
					case 11u:
						_hb5d30EUq0EopY266mbeS55K6Ii.Enabled = false;
						_hb5d30EUq0EopY266mbeS55K6Ii.ImageScalingSize = new Size(24, 24);
						_hb5d30EUq0EopY266mbeS55K6Ii.Items.AddRange(new ToolStripItem[4]
						{
							_FX7AVuhJzGgyhrUztEbr6Gya5ZO,
							_oT4alXeTqsHmh8APqbHB941Uzlc,
							_EfkqSC9gduqvfMt8mYtx5jO0THg,
							_xtcKg1sWRCBuiuJxm3CtyQ3G3sc
						});
						num = ((int) num2 * -1967784721) ^ 0x781B6725;
						continue;
					case 22u:
						_hb5d30EUq0EopY266mbeS55K6Ii.Location = new Point(0, 0);
						num = (int) (num2 * 1708947951) ^ -29506013;
						continue;
					case 17u:
						_pAd0oJasDmAkdcjhMZe1JDlbSjr.Name = "pnlStrip";
						num = (int) ((num2 * 1868666428) ^ 0xB4FFA37);
						continue;
					case 31u:
						_hb5d30EUq0EopY266mbeS55K6Ii.Name = "stripMain";
						_hb5d30EUq0EopY266mbeS55K6Ii.Size = new Size(558, 37);
						_hb5d30EUq0EopY266mbeS55K6Ii.TabIndex = 2;
						_hb5d30EUq0EopY266mbeS55K6Ii.Text = "menuStrip1";
						_FX7AVuhJzGgyhrUztEbr6Gya5ZO.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
						_FX7AVuhJzGgyhrUztEbr6Gya5ZO.ForeColor = Color.Gold;
						num = ((int) num2 * -2037727789) ^ -2011314785;
						continue;
					case 10u:
						_pAd0oJasDmAkdcjhMZe1JDlbSjr.ResumeLayout(performLayout: false);
						num = (int) (num2 * 2106473021) ^ -2076455043;
						continue;
					case 45u:
						_pAd0oJasDmAkdcjhMZe1JDlbSjr.Size = new Size(560, 39);
						_pAd0oJasDmAkdcjhMZe1JDlbSjr.TabIndex = 2;
						_hb5d30EUq0EopY266mbeS55K6Ii.BackgroundImage =
							(Image) componentResourceManager.GetObject("stripMain.BackgroundImage");
						_hb5d30EUq0EopY266mbeS55K6Ii.Dock = DockStyle.Fill;
						num = (int) (num2 * 242745370) ^ -449790337;
						continue;
					case 33u:
						_xtcKg1sWRCBuiuJxm3CtyQ3G3sc.Click += _OcW4ga88AD1dLk4jK6VSMcUIehK;
						num = (int) ((num2 * 469677311) ^ 0x6CDE9F1E);
						continue;
					case 24u:
						_xtcKg1sWRCBuiuJxm3CtyQ3G3sc = new ToolStripMenuItem();
						_O3LpaCvM1vP0FMX2OknddbMCJAn = new Timer(_Container);
						num = ((int) num2 * -191228145) ^ -1894647636;
						continue;
					case 47u:
						_oT4alXeTqsHmh8APqbHB941Uzlc.Font = new Font("Segoe UI", 10.5f, FontStyle.Bold);
						_oT4alXeTqsHmh8APqbHB941Uzlc.ForeColor = Color.Gold;
						_oT4alXeTqsHmh8APqbHB941Uzlc.Image =
							(Image) componentResourceManager.GetObject("instructionsToolStripMenuItem.Image");
						num = (int) ((num2 * 315973106) ^ 0x156547E8);
						continue;
					case 12u:
						_pAd0oJasDmAkdcjhMZe1JDlbSjr.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
						_pAd0oJasDmAkdcjhMZe1JDlbSjr.BorderStyle = BorderStyle.FixedSingle;
						_pAd0oJasDmAkdcjhMZe1JDlbSjr.Controls.Add(_hb5d30EUq0EopY266mbeS55K6Ii);
						_pAd0oJasDmAkdcjhMZe1JDlbSjr.Location = new Point(12, 12);
						num = (int) ((num2 * 535178139) ^ 0x279318C3);
						continue;
					case 1u:
						_oT4alXeTqsHmh8APqbHB941Uzlc.Click += _GU6csqtcZcVmT42WMdJViL1lkGK;
						num = ((int) num2 * -740485682) ^ -1190279413;
						continue;
					case 26u:
						_FX7AVuhJzGgyhrUztEbr6Gya5ZO = new ToolStripMenuItem();
						_oT4alXeTqsHmh8APqbHB941Uzlc = new ToolStripMenuItem();
						_EfkqSC9gduqvfMt8mYtx5jO0THg = new ToolStripMenuItem();
						num = (int) ((num2 * 558971674) ^ 0x2DD6D94A);
						continue;
					case 39u:
						_O3LpaCvM1vP0FMX2OknddbMCJAn.Enabled = true;
						num = ((int) num2 * -1331710237) ^ -2045404391;
						continue;
					case 37u:
						_flZd9LBaLgVakccv6pbLoGboeCNC.Images.SetKeyName(0, "Crown.png");
						num = ((int) num2 * -492535975) ^ -765312382;
						continue;
					case 7u:
						_xtcKg1sWRCBuiuJxm3CtyQ3G3sc.Size = new Size(139, 33);
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
	private void _MCH6UlJVJa7Eth5XB55s5irFMTF()
	{
		try {
			Program.LogInfoMessage("core", "Initializing proxy...");
			ResourceDownloader._uLt6b1uwFNgoZycBDqE02WmgdfB();
			ServerList._J120yKYbtEVgxfxC5akH1UoBgjq();
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
					_K7ZdnyAWKqJeAPIhC4xsrSzRGat.Start();
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