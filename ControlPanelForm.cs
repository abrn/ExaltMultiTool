using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExaltMultiTool;
using Microsoft.VisualBasic;

internal class ControlPanelForm : UserControl
{
	private IContainer _CQeJ5ARN3cqDqwayOhiu7devmaC;

	private Timer _dGGXwr4vGLPn1yrHd6xw3dTdsIM;

	private Button _8EAk3K8O8FArnCzDrWUDDiK6p3l;

	private Button _p5qrmztmwMPri0E7BbinX5kzAkb;

	private Button _w27DsyUsxVIbG8n0ovaJ6b4QAnT;

	private Button _D4k8DLKUizxFC6S0XDt7Ib2AEuB;

	private LinkLabel _HqQbu6Q6mkC2l97KQp7Q3ikYJ3g;

	private Label _F1U2XLtdy2HFJAVFAdfdrXCd4sb;

	private ListBox _0tDYu1wkyKBkjLMcGP57spRp1Mb;

	private Panel _dwq5XV0lJ3UXrmYKjuoMLudnh3f;

	private Panel _sFeh6KdTMDE6U6wD1KDZoonfRxF;

	private Label _BdRbzxyTQVRYdkyraudzIi2X20d;

	private Panel _rcvmj3hjPGfCTHCUBeuDHEEGGlbA;

	private LinkLabel _5Zt4FAYcZlEsQPxkGvQRMBr5cZB;

	public ControlPanelForm()
	{
		_LNN7j16YxFjRwCTXxBG3QnekdGe();
		ListBox.ObjectCollection items = _0tDYu1wkyKBkjLMcGP57spRp1Mb.Items;
		object[] items2 = Settings.Default.SavedAccounts.Cast<string>().ToArray();
		items.AddRange(items2);
	}

	private void _QRcwaZj653csryjbBV8hLrGY0Kj(object sender, EventArgs e)
	{
		if (File.Exists(Settings.Default.ExaltGamePath))
		{
			goto IL_0011;
		}
		goto IL_0079;
		IL_0079:
		_0tDYu1wkyKBkjLMcGP57spRp1Mb.Enabled = false;
		int num = 1066630272;
		goto IL_0016;
		IL_0016:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x5C8DF2A9u) % 6u)
			{
			case 0u:
				break;
			case 2u:
				_0tDYu1wkyKBkjLMcGP57spRp1Mb.Enabled = true;
				num = ((int)num2 * -494111659) ^ -1148766373;
				continue;
			case 4u:
				_F1U2XLtdy2HFJAVFAdfdrXCd4sb.Text = "Exalt found.";
				num = (int)(num2 * 807079363) ^ -837796372;
				continue;
			case 1u:
				goto IL_0079;
			case 5u:
				return;
			default:
				_F1U2XLtdy2HFJAVFAdfdrXCd4sb.Text = "Exalt install not detected!";
				return;
			}
			break;
		}
		goto IL_0011;
		IL_0011:
		num = 1493025347;
		goto IL_0016;
	}

	public void _VjekxqyBg5uLJB863nppdC1OsDI(object sender, LinkLabelLinkClickedEventArgs e)
	{
		MessageBox.Show("Please locate RotMG Exalt.exe within your Documents folder so it can be used with MultiLogin.", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		OpenFileDialog openFileDialog = default(OpenFileDialog);
		while (true)
		{
			int num = -1766302675;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD6A81EE4u) % 11u)
				{
				case 9u:
					break;
				default:
					return;
				case 5u:
					openFileDialog = new OpenFileDialog();
					num = (int)(num2 * 1300583435) ^ -1893751771;
					continue;
				case 1u:
					Settings.Default.ExaltGamePath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\RealmOfTheMadGod\\Production";
					num = (int)(num2 * 263548255) ^ -994785757;
					continue;
				case 0u:
					_Lp8SMlY5tOI2VsNb5wgdeWoqvcV();
					num = (int)((num2 * 1687510808) ^ 0x57449FCB);
					continue;
				case 4u:
					openFileDialog.InitialDirectory = Settings.Default.ExaltGamePath;
					num = -1063164058;
					continue;
				case 6u:
					openFileDialog.Title = "Locate RotMG Exalt game file...";
					openFileDialog.Filter = "RotMG Exalt (*.exe)|*.exe";
					num = (int)((num2 * 1174862915) ^ 0x445DB5F1);
					continue;
				case 3u:
					Settings.Default.ExaltGamePath = openFileDialog.FileName;
					num = (int)(num2 * 343513372) ^ -35917758;
					continue;
				case 7u:
				{
					int num7;
					int num8;
					if (!openFileDialog.FileName.EndsWith("RotMG Exalt.exe"))
					{
						num7 = 638859587;
						num8 = num7;
					}
					else
					{
						num7 = 2040928164;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 199656392);
					continue;
				}
				case 2u:
				{
					int num5;
					int num6;
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						num5 = 1977316563;
						num6 = num5;
					}
					else
					{
						num5 = 543220407;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -722780298);
					continue;
				}
				case 10u:
				{
					int num3;
					int num4;
					if (!string.IsNullOrWhiteSpace(Settings.Default.ExaltGamePath))
					{
						num3 = 95896559;
						num4 = num3;
					}
					else
					{
						num3 = 999669302;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 964194669);
					continue;
				}
				case 8u:
					return;
				}
				break;
			}
		}
	}

	private void _JrdDH89fZHbAicw0ARw9HFFDHFV(object sender, EventArgs e)
	{
		bool enabled = _0tDYu1wkyKBkjLMcGP57spRp1Mb.SelectedIndex != -1;
		while (true)
		{
			int num = -506774934;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x92EC5371u) % 3u)
				{
				case 0u:
					break;
				case 1u:
					goto IL_0034;
				default:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.Enabled = enabled;
					return;
				}
				break;
				IL_0034:
				_w27DsyUsxVIbG8n0ovaJ6b4QAnT.Enabled = enabled;
				num = (int)((num2 * 932562613) ^ 0xB8C9C33);
			}
		}
	}

	[AsyncStateMachine(typeof(_DDOqO0f0C3moNfBsXFdNJLMFGnD))]
	private void _RNNFD8MJInJ8RoBjPUca6uI9kHV(object sender, EventArgs e)
	{
		_DDOqO0f0C3moNfBsXFdNJLMFGnD stateMachine = default(_DDOqO0f0C3moNfBsXFdNJLMFGnD);
		stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo = AsyncVoidMethodBuilder.Create();
		stateMachine._7DEudk1H4zeA6HRBegB5UK6RcSYA = this;
		while (true)
		{
			int num = 1142594244;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C36818u) % 3u)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0036;
				default:
					stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo.Start(ref stateMachine);
					return;
				}
				break;
				IL_0036:
				stateMachine._PBb43473kLxvAWjGhIbcR02LyrK = -1;
				num = ((int)num2 * -1276340882) ^ -608411281;
			}
		}
	}

	private void _GqgGvgCRZ5QJJ5UyfoyJ456tYVb(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = _C3AfjFhWoqFhx3X66WyLSXtO17F();
		while (true)
		{
			int num = 1645290867;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5B21B412u) % 5u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					_Lp8SMlY5tOI2VsNb5wgdeWoqvcV();
					num = ((int)num2 * -952640026) ^ -1474139675;
					continue;
				case 4u:
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.Items.Add(text);
					num = (int)(num2 * 695501051) ^ -674869224;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (text != string.Empty)
					{
						num3 = 66438289;
						num4 = num3;
					}
					else
					{
						num3 = 1400484482;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -1573085141);
					continue;
				}
				case 3u:
					return;
				}
				break;
			}
		}
	}

	private void _cE4VGyGL26Yd4Kd6mXFvPO65kd(object sender, EventArgs e)
	{
		object selectedItem = _0tDYu1wkyKBkjLMcGP57spRp1Mb.SelectedItem;
		while (true)
		{
			int num = 171589860;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x53422B82u) % 4u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
				{
					int num3;
					int num4;
					if (selectedItem == null)
					{
						num3 = 1828851287;
						num4 = num3;
					}
					else
					{
						num3 = 1276165497;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 569605228);
					continue;
				}
				case 3u:
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.Items.Remove(selectedItem);
					_Lp8SMlY5tOI2VsNb5wgdeWoqvcV();
					num = ((int)num2 * -2143414113) ^ 0x84164B2;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_uUkdo2t45ljSEYVhxf9chelrj2B))]
	private void _pUCcjZ57gbYjnaLx1V7UWh5xefL(object sender, EventArgs e)
	{
		_uUkdo2t45ljSEYVhxf9chelrj2B stateMachine = default(_uUkdo2t45ljSEYVhxf9chelrj2B);
		stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo = AsyncVoidMethodBuilder.Create();
		while (true)
		{
			int num = -1717612333;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xAF0B9A79u) % 3u)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002e;
				default:
					stateMachine._PBb43473kLxvAWjGhIbcR02LyrK = -1;
					stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo.Start(ref stateMachine);
					return;
				}
				break;
				IL_002e:
				stateMachine._7DEudk1H4zeA6HRBegB5UK6RcSYA = this;
				num = ((int)num2 * -1421430495) ^ 0x23840EE;
			}
		}
	}

	private void _BZABXjKLnE64O1pYeWPLWvBZ4KM(object sender, EventArgs e)
	{
		object selectedItem = _0tDYu1wkyKBkjLMcGP57spRp1Mb.SelectedItem;
		string text = default(string);
		while (true)
		{
			int num = 127017156;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B309A20u) % 11u)
				{
				case 6u:
					break;
				default:
					return;
				case 9u:
					return;
				case 4u:
				{
					text = selectedItem as string;
					int num6;
					int num7;
					if (!text.StartsWith("steamworks:"))
					{
						num6 = 1613467255;
						num7 = num6;
					}
					else
					{
						num6 = 3440003;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 1245658981);
					continue;
				}
				case 7u:
				{
					int num5;
					if (!File.Exists(Settings.Default.ExaltGamePath))
					{
						num = 2045228813;
						num5 = num;
					}
					else
					{
						num = 1459322312;
						num5 = num;
					}
					continue;
				}
				case 0u:
				{
					string[] array = text.Split(':');
					InjectionHelper.StartExalt(array[0], array[1]);
					num = 587591612;
					continue;
				}
				case 1u:
				{
					int num3;
					int num4;
					if (selectedItem == null)
					{
						num3 = -174555225;
						num4 = num3;
					}
					else
					{
						num3 = -1409773120;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -15666266);
					continue;
				}
				case 8u:
					text = text.Replace("steamworks:", "steamworks_");
					num = ((int)num2 * -2096413269) ^ 0x603A8686;
					continue;
				case 2u:
					return;
				case 10u:
					MessageBox.Show("Please select an account!", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					num = (int)(num2 * 2033311807) ^ -1041737573;
					continue;
				case 5u:
					MessageBox.Show("You must locate the game location!", "RealmStock Multi-Tool", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					num = 179060749;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_iC6zrjO1AWnceEaVVJvhW4hWJRg))]
	private Task<string> _qTNJV9ifRKprddsTWdOCG7WyhlK(string email = "", string password = "")
	{
		_iC6zrjO1AWnceEaVVJvhW4hWJRg stateMachine = default(_iC6zrjO1AWnceEaVVJvhW4hWJRg);
		stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo = AsyncTaskMethodBuilder<string>.Create();
		while (true)
		{
			int num = 1286600154;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xB3B17E4u) % 4u)
				{
				case 0u:
					break;
				case 2u:
					stateMachine._tqdo18j1yiG5aAD7QH0FcXJJ8Em = email;
					stateMachine._NynTu1DqubcvLjtw94jbB9ulOaj = password;
					stateMachine._PBb43473kLxvAWjGhIbcR02LyrK = -1;
					num = ((int)num2 * -44495067) ^ -1937040283;
					continue;
				case 3u:
					stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo.Start(ref stateMachine);
					num = (int)((num2 * 53494575) ^ 0x65995B7C);
					continue;
				default:
					return stateMachine._nQ1vWeyyHbbH14Es0GXdAMpXCJo.Task;
				}
				break;
			}
		}
	}

	private string _C3AfjFhWoqFhx3X66WyLSXtO17F(string guid = "", string secret = "")
	{
		if (MessageBox.Show("WARNING: This is for advanced users only.\nAccounts using this method are not verified - If you enter incorrect details, you will just be stock loading forever when you launch Exalt.\nAlso, you will not be able to purchase gold when in game, due to the client needing to be linked to Steam.\n\nContinue?", "RealmStock Multi-Tool", MessageBoxButtons.YesNo) == DialogResult.No)
		{
			goto IL_0016;
		}
		goto IL_00bc;
		IL_00bc:
		string text = Interaction.InputBox("Please enter the 'GUID' token for the RotMG Steam Account:\n", "RealmStock", guid);
		int num;
		int num2;
		if (!string.IsNullOrEmpty(text))
		{
			num = 1150528715;
			num2 = num;
		}
		else
		{
			num = 1427253308;
			num2 = num;
		}
		goto IL_001b;
		IL_001b:
		string text2 = default(string);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x74E33345u) % 7u)
			{
			case 4u:
				break;
			case 1u:
				return string.Empty;
			case 2u:
				return string.Empty;
			case 0u:
				goto IL_0075;
			case 3u:
				return string.Empty;
			case 5u:
				goto IL_00bc;
			default:
				return text + ":" + text2;
			}
			break;
			IL_0075:
			text2 = Interaction.InputBox("Please enter the 'SECRET' token for the RotMG Steam Account:", "RealmStock", secret);
			int num4;
			if (string.IsNullOrEmpty(text2))
			{
				num = 1176564859;
				num4 = num;
			}
			else
			{
				num = 1868753968;
				num4 = num;
			}
		}
		goto IL_0016;
		IL_0016:
		num = 114696201;
		goto IL_001b;
	}

	private void _Lp8SMlY5tOI2VsNb5wgdeWoqvcV()
	{
		Settings.Default.SavedAccounts = _0tDYu1wkyKBkjLMcGP57spRp1Mb.Items.Cast<string>().ToArray();
		Settings.Default.Save();
	}

	protected override void _8H2QqjADGkx30Hq77Uf9ZGuRzFD(bool disposing)
	{
		if (disposing)
		{
			goto IL_0003;
		}
		goto IL_0068;
		IL_0068:
		Dispose(disposing);
		int num = -1613156987;
		goto IL_0008;
		IL_0008:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xDF6CB8EAu) % 5u)
			{
			case 4u:
				break;
			default:
				return;
			case 3u:
			{
				int num3;
				int num4;
				if (_CQeJ5ARN3cqDqwayOhiu7devmaC == null)
				{
					num3 = 484184039;
					num4 = num3;
				}
				else
				{
					num3 = 1268382566;
					num4 = num3;
				}
				num = num3 ^ (int)(num2 * 273389643);
				continue;
			}
			case 2u:
				_CQeJ5ARN3cqDqwayOhiu7devmaC.Dispose();
				num = ((int)num2 * -1889391724) ^ -750456983;
				continue;
			case 1u:
				goto IL_0068;
			case 0u:
				return;
			}
			break;
		}
		goto IL_0003;
		IL_0003:
		num = -2119037960;
		goto IL_0008;
	}

	private void _LNN7j16YxFjRwCTXxBG3QnekdGe()
	{
		_CQeJ5ARN3cqDqwayOhiu7devmaC = new Container();
		ComponentResourceManager componentResourceManager = default(ComponentResourceManager);
		while (true)
		{
			int num = -1040005740;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xE6B3D8D2u) % 98u)
				{
				case 97u:
					break;
				case 81u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.TabIndex = 9;
					num = ((int)num2 * -62083454) ^ -1468477539;
					continue;
				case 19u:
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.Controls.Add(_BdRbzxyTQVRYdkyraudzIi2X20d);
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.Font = new Font("Segoe UI", 8.25f);
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.Location = new Point(11, 61);
					num = (int)((num2 * 667193753) ^ 0x9F13F26);
					continue;
				case 36u:
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.FormattingEnabled = true;
					num = ((int)num2 * -2119936954) ^ 0x51060F2A;
					continue;
				case 58u:
					_BdRbzxyTQVRYdkyraudzIi2X20d.Location = new Point(3, 3);
					_BdRbzxyTQVRYdkyraudzIi2X20d.Name = "lblHelp";
					num = (int)((num2 * 1112337772) ^ 0x7BE8A316);
					continue;
				case 95u:
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.Text = "Advanced: Add Steam account";
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.LinkClicked += _GqgGvgCRZ5QJJ5UyfoyJ456tYVb;
					base.AutoScaleDimensions = new SizeF(96f, 96f);
					num = ((int)num2 * -2036224604) ^ -201862525;
					continue;
				case 86u:
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.TabIndex = 16;
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.Anchor = AnchorStyles.Top | AnchorStyles.Right;
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.AutoSize = true;
					num = ((int)num2 * -1370715774) ^ -1250945483;
					continue;
				case 33u:
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.FlatAppearance.BorderSize = 0;
					num = ((int)num2 * -1587456299) ^ 0x4FCE90E2;
					continue;
				case 82u:
					base.Controls.Add(_F1U2XLtdy2HFJAVFAdfdrXCd4sb);
					num = ((int)num2 * -2117491510) ^ 0x241117C8;
					continue;
				case 85u:
					base.Controls.Add(_rcvmj3hjPGfCTHCUBeuDHEEGGlbA);
					num = (int)((num2 * 1926010054) ^ 0x68C2FB7C);
					continue;
				case 29u:
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.Name = "btnLogin";
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.Size = new Size(100, 25);
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.TabIndex = 6;
					num = ((int)num2 * -1714115876) ^ -1778197650;
					continue;
				case 57u:
					_dGGXwr4vGLPn1yrHd6xw3dTdsIM.Enabled = true;
					num = ((int)num2 * -145852114) ^ 0x62196BE6;
					continue;
				case 80u:
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g.BackColor = Color.Transparent;
					num = ((int)num2 * -550709191) ^ 0x2E0CF5B9;
					continue;
				case 16u:
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.Dock = DockStyle.Fill;
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.Font = new Font("Segoe UI", 9.5f);
					num = ((int)num2 * -190908401) ^ 0x55D7B1B5;
					continue;
				case 72u:
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.IntegralHeight = false;
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.ItemHeight = 17;
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.Location = new Point(0, 0);
					num = (int)(num2 * 892429046) ^ -1393975328;
					continue;
				case 66u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.ForeColor = Color.Gold;
					num = (int)((num2 * 284594985) ^ 0x51559122);
					continue;
				case 89u:
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.ForeColor = Color.Gold;
					num = ((int)num2 * -1504574022) ^ -1262026027;
					continue;
				case 48u:
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.BorderStyle = BorderStyle.FixedSingle;
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.Controls.Add(_5Zt4FAYcZlEsQPxkGvQRMBr5cZB);
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.Controls.Add(_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g);
					num = (int)((num2 * 1706428305) ^ 0x10C48D4E);
					continue;
				case 5u:
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g.Location = new Point(3, 3);
					num = ((int)num2 * -678108820) ^ -402457005;
					continue;
				case 62u:
					_BdRbzxyTQVRYdkyraudzIi2X20d = new Label();
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA = new Panel();
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB = new LinkLabel();
					num = (int)((num2 * 1270943939) ^ 0x34B02E0C);
					continue;
				case 38u:
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.Size = new Size(478, 23);
					num = (int)(num2 * 1044190635) ^ -76317458;
					continue;
				case 8u:
					BackgroundImageLayout = ImageLayout.Stretch;
					num = (int)((num2 * 688646373) ^ 0x2D95ADFF);
					continue;
				case 30u:
					base.Controls.Add(_dwq5XV0lJ3UXrmYKjuoMLudnh3f);
					num = ((int)num2 * -57219555) ^ 0x181EEED6;
					continue;
				case 70u:
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.BackColor = Color.FromArgb(44, 31, 52);
					num = ((int)num2 * -1661365443) ^ 0x1DB98A43;
					continue;
				case 20u:
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.Click += _pUCcjZ57gbYjnaLx1V7UWh5xefL;
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.BackColor = Color.FromArgb(162, 57, 202);
					num = ((int)num2 * -646749052) ^ -2025900401;
					continue;
				case 31u:
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.Name = "pnlInfo";
					num = (int)(num2 * 1417039978) ^ -1200541198;
					continue;
				case 28u:
					_p5qrmztmwMPri0E7BbinX5kzAkb = new Button();
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT = new Button();
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB = new Button();
					num = ((int)num2 * -1826119105) ^ -998998632;
					continue;
				case 9u:
					base.AutoScaleMode = AutoScaleMode.Dpi;
					BackColor = Color.FromArgb(14, 11, 22);
					num = ((int)num2 * -440427269) ^ -297633898;
					continue;
				case 65u:
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.BackColor = Color.FromArgb(162, 57, 202);
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.Enabled = false;
					num = ((int)num2 * -892280279) ^ -194374558;
					continue;
				case 75u:
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.SuspendLayout();
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.SuspendLayout();
					SuspendLayout();
					num = (int)((num2 * 2036179967) ^ 0x552F247A);
					continue;
				case 17u:
					base.Controls.Add(_p5qrmztmwMPri0E7BbinX5kzAkb);
					base.Controls.Add(_w27DsyUsxVIbG8n0ovaJ6b4QAnT);
					num = (int)((num2 * 1424305240) ^ 0x45169E5F);
					continue;
				case 44u:
					componentResourceManager = new ComponentResourceManager(typeof(ControlPanelForm));
					_dGGXwr4vGLPn1yrHd6xw3dTdsIM = new Timer(_CQeJ5ARN3cqDqwayOhiu7devmaC);
					_8EAk3K8O8FArnCzDrWUDDiK6p3l = new Button();
					num = (int)(num2 * 1069616614) ^ -1262732896;
					continue;
				case 43u:
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g.LinkClicked += _VjekxqyBg5uLJB863nppdC1OsDI;
					_F1U2XLtdy2HFJAVFAdfdrXCd4sb.AutoSize = true;
					_F1U2XLtdy2HFJAVFAdfdrXCd4sb.BackColor = Color.Transparent;
					num = (int)(num2 * 830097158) ^ -2109156571;
					continue;
				case 64u:
					base.Controls.Add(_sFeh6KdTMDE6U6wD1KDZoonfRxF);
					num = (int)(num2 * 496962836) ^ -549859416;
					continue;
				case 22u:
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.Name = "btnEdit";
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.Size = new Size(48, 25);
					num = (int)(num2 * 337874495) ^ -1178672559;
					continue;
				case 24u:
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.Size = new Size(478, 23);
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.TabIndex = 15;
					_BdRbzxyTQVRYdkyraudzIi2X20d.AutoSize = true;
					_BdRbzxyTQVRYdkyraudzIi2X20d.BackColor = Color.Transparent;
					num = ((int)num2 * -332548861) ^ -486893908;
					continue;
				case 59u:
					base.Controls.Add(_D4k8DLKUizxFC6S0XDt7Ib2AEuB);
					num = ((int)num2 * -1246953729) ^ 0x67D7889B;
					continue;
				case 39u:
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g.TabStop = true;
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g.Text = "→ Click to locate RotMG Exalt.exe";
					num = ((int)num2 * -566788537) ^ 0x4A1DED4E;
					continue;
				case 54u:
					base.Controls.Add(_8EAk3K8O8FArnCzDrWUDDiK6p3l);
					num = (int)((num2 * 2142303124) ^ 0x16149851);
					continue;
				case 69u:
					ResumeLayout(performLayout: false);
					num = (int)((num2 * 248070996) ^ 0x5DF5A976);
					continue;
				case 0u:
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g.TabIndex = 11;
					num = ((int)num2 * -10990435) ^ -392729727;
					continue;
				case 79u:
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.FlatAppearance.BorderSize = 0;
					num = (int)(num2 * 512232237) ^ -832264206;
					continue;
				case 14u:
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.Name = "pnlButton";
					num = (int)((num2 * 1519613433) ^ 0x19419A10);
					continue;
				case 40u:
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.PerformLayout();
					num = ((int)num2 * -1345030886) ^ 0x4A62742D;
					continue;
				case 42u:
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.Name = "lstAccounts";
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.Size = new Size(478, 172);
					num = ((int)num2 * -1957039379) ^ 0x53867C11;
					continue;
				case 60u:
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g = new LinkLabel();
					num = ((int)num2 * -1911592825) ^ 0x6561AB29;
					continue;
				case 84u:
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.Font = new Font("Segoe UI", 8.25f);
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.Location = new Point(11, 35);
					num = (int)(num2 * 1921247855) ^ -1630193538;
					continue;
				case 71u:
					_F1U2XLtdy2HFJAVFAdfdrXCd4sb = new Label();
					_0tDYu1wkyKBkjLMcGP57spRp1Mb = new ListBox();
					_dwq5XV0lJ3UXrmYKjuoMLudnh3f = new Panel();
					_sFeh6KdTMDE6U6wD1KDZoonfRxF = new Panel();
					num = (int)((num2 * 1099176009) ^ 0x6EDAF983);
					continue;
				case 21u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.BackColor = Color.FromArgb(162, 57, 202);
					num = ((int)num2 * -85106652) ^ 0x36FFFDB7;
					continue;
				case 27u:
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.ForeColor = Color.Gainsboro;
					num = ((int)num2 * -938480321) ^ 0x19BFF461;
					continue;
				case 49u:
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.ResumeLayout(performLayout: false);
					num = ((int)num2 * -1540136290) ^ 0x62A4BC8C;
					continue;
				case 2u:
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.Name = "btnAddSteam";
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.Size = new Size(162, 13);
					num = ((int)num2 * -1960287455) ^ 0x11A86297;
					continue;
				case 46u:
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.BackColor = Color.FromArgb(44, 31, 52);
					num = ((int)num2 * -652375608) ^ 0x428CBF9C;
					continue;
				case 6u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.Click += _RNNFD8MJInJ8RoBjPUca6uI9kHV;
					num = (int)((num2 * 1919016051) ^ 0x4E983EBB);
					continue;
				case 32u:
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
					num = ((int)num2 * -321673931) ^ -1157019558;
					continue;
				case 96u:
					base.Size = new Size(500, 300);
					num = ((int)num2 * -563364068) ^ 0x58AEB14;
					continue;
				case 77u:
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g.Name = "btnSettings";
					num = ((int)num2 * -1280610500) ^ -338108146;
					continue;
				case 23u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.Text = "Delete";
					num = ((int)num2 * -1778021664) ^ 0x72D218E8;
					continue;
				case 34u:
					_BdRbzxyTQVRYdkyraudzIi2X20d.Font = new Font("Segoe UI", 8.25f);
					_BdRbzxyTQVRYdkyraudzIi2X20d.ForeColor = Color.Gold;
					num = (int)(num2 * 1004543146) ^ -516737250;
					continue;
				case 51u:
					BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
					num = (int)((num2 * 1210050728) ^ 0x5E57C1A);
					continue;
				case 3u:
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.BackColor = Color.FromArgb(44, 31, 52);
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.BorderStyle = BorderStyle.FixedSingle;
					num = ((int)num2 * -1522068601) ^ -155091306;
					continue;
				case 74u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					_p5qrmztmwMPri0E7BbinX5kzAkb.ForeColor = Color.Gold;
					_p5qrmztmwMPri0E7BbinX5kzAkb.Location = new Point(385, 264);
					_p5qrmztmwMPri0E7BbinX5kzAkb.Name = "btnAdd";
					_p5qrmztmwMPri0E7BbinX5kzAkb.Size = new Size(50, 25);
					_p5qrmztmwMPri0E7BbinX5kzAkb.TabIndex = 8;
					num = (int)((num2 * 866016418) ^ 0x22CEA589);
					continue;
				case 1u:
					_F1U2XLtdy2HFJAVFAdfdrXCd4sb.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold);
					num = ((int)num2 * -485850992) ^ -1526956719;
					continue;
				case 52u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.FlatStyle = FlatStyle.Flat;
					num = ((int)num2 * -1502129085) ^ -908874188;
					continue;
				case 35u:
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.Location = new Point(11, 264);
					num = ((int)num2 * -1786194594) ^ -1747531247;
					continue;
				case 10u:
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g.Size = new Size(177, 13);
					num = ((int)num2 * -1774476801) ^ 0x157ADE3E;
					continue;
				case 25u:
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.FlatStyle = FlatStyle.Flat;
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = ((int)num2 * -799320611) ^ -163637392;
					continue;
				case 73u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.Size = new Size(48, 25);
					num = ((int)num2 * -713883551) ^ 0x448F07F4;
					continue;
				case 7u:
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.FlatStyle = FlatStyle.Flat;
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
					num = ((int)num2 * -1791212504) ^ 0x122856F8;
					continue;
				case 68u:
					_dwq5XV0lJ3UXrmYKjuoMLudnh3f.ResumeLayout(performLayout: false);
					num = ((int)num2 * -923828783) ^ 0x564D38E7;
					continue;
				case 90u:
					_dGGXwr4vGLPn1yrHd6xw3dTdsIM.Interval = 1000;
					_dGGXwr4vGLPn1yrHd6xw3dTdsIM.Tick += _QRcwaZj653csryjbBV8hLrGY0Kj;
					num = (int)(num2 * 909822609) ^ -1512799985;
					continue;
				case 53u:
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.BackColor = Color.Transparent;
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.LinkColor = Color.Gold;
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.Location = new Point(311, 3);
					num = (int)((num2 * 1260125801) ^ 0xCD59B19);
					continue;
				case 91u:
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g.LinkColor = Color.Gold;
					num = (int)((num2 * 615183386) ^ 0x67AC386F);
					continue;
				case 41u:
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.TabIndex = 12;
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.SelectedIndexChanged += _JrdDH89fZHbAicw0ARw9HFFDHFV;
					_dwq5XV0lJ3UXrmYKjuoMLudnh3f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					_dwq5XV0lJ3UXrmYKjuoMLudnh3f.Controls.Add(_0tDYu1wkyKBkjLMcGP57spRp1Mb);
					_dwq5XV0lJ3UXrmYKjuoMLudnh3f.Location = new Point(11, 87);
					_dwq5XV0lJ3UXrmYKjuoMLudnh3f.Name = "pnlAccounts";
					_dwq5XV0lJ3UXrmYKjuoMLudnh3f.Size = new Size(478, 172);
					_dwq5XV0lJ3UXrmYKjuoMLudnh3f.TabIndex = 13;
					_sFeh6KdTMDE6U6wD1KDZoonfRxF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
					num = ((int)num2 * -1643003111) ^ -1639343792;
					continue;
				case 56u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.BackColor = Color.FromArgb(162, 57, 202);
					_p5qrmztmwMPri0E7BbinX5kzAkb.FlatAppearance.BorderSize = 0;
					num = (int)(num2 * 1603659623) ^ -1803441518;
					continue;
				case 18u:
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.ForeColor = Color.Lime;
					num = ((int)num2 * -910544178) ^ -638352235;
					continue;
				case 15u:
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.Location = new Point(117, 264);
					num = (int)((num2 * 1560598728) ^ 0x1E5A0A78);
					continue;
				case 47u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.Enabled = false;
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.FlatAppearance.BorderSize = 0;
					num = ((int)num2 * -138269802) ^ -278232105;
					continue;
				case 37u:
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.TabIndex = 12;
					_5Zt4FAYcZlEsQPxkGvQRMBr5cZB.TabStop = true;
					num = ((int)num2 * -1970832381) ^ 0x6BE5C550;
					continue;
				case 55u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.Text = "Add";
					_p5qrmztmwMPri0E7BbinX5kzAkb.UseVisualStyleBackColor = false;
					num = ((int)num2 * -239277810) ^ -846715212;
					continue;
				case 87u:
					_F1U2XLtdy2HFJAVFAdfdrXCd4sb.ForeColor = Color.Gold;
					_F1U2XLtdy2HFJAVFAdfdrXCd4sb.Location = new Point(6, 7);
					_F1U2XLtdy2HFJAVFAdfdrXCd4sb.Name = "lblStatus";
					_F1U2XLtdy2HFJAVFAdfdrXCd4sb.Size = new Size(236, 25);
					_F1U2XLtdy2HFJAVFAdfdrXCd4sb.TabIndex = 10;
					_F1U2XLtdy2HFJAVFAdfdrXCd4sb.Text = "Exalt install not detected!";
					num = (int)((num2 * 192953314) ^ 0x764EB1DC);
					continue;
				case 67u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.Name = "btnDelete";
					num = ((int)num2 * -2055067911) ^ -1828784766;
					continue;
				case 93u:
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
					num = (int)(num2 * 1717812712) ^ -2100795201;
					continue;
				case 13u:
					_0tDYu1wkyKBkjLMcGP57spRp1Mb.BorderStyle = BorderStyle.FixedSingle;
					num = ((int)num2 * -734314912) ^ 0x4D8D77D6;
					continue;
				case 4u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					num = ((int)num2 * -896412938) ^ 0x4FC52056;
					continue;
				case 94u:
					DoubleBuffered = true;
					Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					base.Name = "MultiLoginControl";
					num = (int)(num2 * 169161913) ^ -1154651694;
					continue;
				case 63u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.FlatStyle = FlatStyle.Flat;
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = ((int)num2 * -1569536352) ^ -353332226;
					continue;
				case 78u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.Location = new Point(441, 264);
					num = ((int)num2 * -994139157) ^ -1216798273;
					continue;
				case 45u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.Click += _cE4VGyGL26Yd4Kd6mXFvPO65kd;
					num = (int)((num2 * 1816354359) ^ 0x68CCB82F);
					continue;
				case 61u:
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.UseVisualStyleBackColor = false;
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.Click += _BZABXjKLnE64O1pYeWPLWvBZ4KM;
					num = (int)((num2 * 800572245) ^ 0x1E1B4A7D);
					continue;
				case 12u:
					_8EAk3K8O8FArnCzDrWUDDiK6p3l.UseVisualStyleBackColor = false;
					num = ((int)num2 * -607911674) ^ -722725469;
					continue;
				case 50u:
					_HqQbu6Q6mkC2l97KQp7Q3ikYJ3g.AutoSize = true;
					num = ((int)num2 * -1679241587) ^ 0x15310696;
					continue;
				case 11u:
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.TabIndex = 7;
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.Text = "Edit";
					_w27DsyUsxVIbG8n0ovaJ6b4QAnT.UseVisualStyleBackColor = false;
					num = ((int)num2 * -1221556433) ^ -777006225;
					continue;
				case 83u:
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.ResumeLayout(performLayout: false);
					_rcvmj3hjPGfCTHCUBeuDHEEGGlbA.PerformLayout();
					num = ((int)num2 * -1994533758) ^ 0x23AA5B9D;
					continue;
				case 76u:
					_BdRbzxyTQVRYdkyraudzIi2X20d.Size = new Size(151, 13);
					_BdRbzxyTQVRYdkyraudzIi2X20d.TabIndex = 13;
					_BdRbzxyTQVRYdkyraudzIi2X20d.Text = "Multi Login tool is optional!";
					num = ((int)num2 * -1525785819) ^ 0x77C5AF2;
					continue;
				case 92u:
					_D4k8DLKUizxFC6S0XDt7Ib2AEuB.Text = "Login";
					num = ((int)num2 * -1247829649) ^ -201161777;
					continue;
				case 26u:
					_dwq5XV0lJ3UXrmYKjuoMLudnh3f.SuspendLayout();
					num = (int)((num2 * 428320572) ^ 0x59C27F49);
					continue;
				default:
					PerformLayout();
					return;
				}
				break;
			}
		}
	}
}
