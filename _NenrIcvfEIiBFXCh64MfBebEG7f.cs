using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExaltMultiTool;

internal class _NenrIcvfEIiBFXCh64MfBebEG7f : Form
{
	[CompilerGenerated]
	private sealed class _KUnPbFafor0J3QMB4AvJb8s9qrI
	{
		public string _nXF60KE2IKbrh4yi4vZrXhicucj;

		internal bool _ej91vz2gOj3VIAxci4pjGbkUcbF(string name)
		{
			return name != _nXF60KE2IKbrh4yi4vZrXhicucj;
		}
	}

	private IContainer _CQeJ5ARN3cqDqwayOhiu7devmaC;

	private Panel _8IQDVUNGP3kUFvRXSJ5CYjmtONf;

	private Label _f5kDiRV6JVB3PeAj27HgG3gctN;

	public _NenrIcvfEIiBFXCh64MfBebEG7f()
	{
		int num3 = default(int);
		CheckBox checkBox = default(CheckBox);
		DescriptionAttribute descriptionAttribute = default(DescriptionAttribute);
		string text = default(string);
		string[] names = default(string[]);
		int num4 = default(int);
		Type typeFromHandle = default(Type);
		while (true)
		{
			int num = 522643942;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC0596A4u) % 16u)
				{
				case 15u:
					break;
				default:
					return;
				case 9u:
					num = ((int)num2 * -339748457) ^ -587542847;
					continue;
				case 1u:
					num3 = 5;
					num = (int)(num2 * 807854659) ^ -214556572;
					continue;
				case 5u:
				{
					CheckBox checkBox2 = checkBox;
					checkBox2.Text = checkBox2.Text + " | " + descriptionAttribute.Description;
					num = ((int)num2 * -2026765632) ^ 0xE25ABE9;
					continue;
				}
				case 0u:
				{
					int num6;
					int num7;
					if (descriptionAttribute != null)
					{
						num6 = 1838719792;
						num7 = num6;
					}
					else
					{
						num6 = 1077297689;
						num7 = num6;
					}
					num = num6 ^ (int)(num2 * 1740703477);
					continue;
				}
				case 13u:
					checkBox.CheckedChanged += _q7RYGTdCtUsJtGQPA18Fyo5efHu;
					num = 977783519;
					continue;
				case 2u:
					_LNN7j16YxFjRwCTXxBG3QnekdGe();
					num = (int)(num2 * 1481464187) ^ -1505336477;
					continue;
				case 4u:
				{
					int num8;
					int num9;
					if (!string.IsNullOrWhiteSpace(descriptionAttribute.Description))
					{
						num8 = 590142201;
						num9 = num8;
					}
					else
					{
						num8 = 440253025;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 985691458);
					continue;
				}
				case 14u:
					text = names[num4];
					num = 318335427;
					continue;
				case 3u:
					typeFromHandle = typeof(_IjlO5UMx1JU6cnQE4rkBstwQlDe);
					num = ((int)num2 * -160752310) ^ 0x229499A6;
					continue;
				case 8u:
					num4 = 0;
					num = (int)((num2 * 773617134) ^ 0x62186EFD);
					continue;
				case 12u:
					names = Enum.GetNames(typeFromHandle);
					num = (int)(num2 * 180467208) ^ -1297225156;
					continue;
				case 11u:
					num4++;
					num = ((int)num2 * -1814906677) ^ 0xD3385C7;
					continue;
				case 10u:
				{
					int num5;
					if (num4 < names.Length)
					{
						num = 1515405658;
						num5 = num;
					}
					else
					{
						num = 1665089922;
						num5 = num;
					}
					continue;
				}
				case 7u:
				{
					FieldInfo field = typeFromHandle.GetField(text);
					checkBox = new CheckBox();
					_8IQDVUNGP3kUFvRXSJ5CYjmtONf.Controls.Add(checkBox);
					checkBox.AutoSize = true;
					checkBox.Font = _8IQDVUNGP3kUFvRXSJ5CYjmtONf.Font;
					checkBox.Text = "Ignore '" + text + "'";
					checkBox.Tag = text;
					checkBox.Checked = Settings.Default.AntiLagIgnoredEffects.Contains(text);
					checkBox.Location = new Point(5, num3);
					num3 += checkBox.Height + 5;
					descriptionAttribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;
					num = ((int)num2 * -1650939685) ^ 0x5DB812C9;
					continue;
				}
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void _q7RYGTdCtUsJtGQPA18Fyo5efHu(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_00b1
		CheckBox checkBox = sender as CheckBox;
		if (checkBox == null)
		{
			return;
		}
		_KUnPbFafor0J3QMB4AvJb8s9qrI kUnPbFafor0J3QMB4AvJb8s9qrI = default(_KUnPbFafor0J3QMB4AvJb8s9qrI);
		while (true)
		{
			int num = 1748845744;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5C6BA5D3u) % 7u)
				{
				case 0u:
					break;
				default:
					return;
				case 3u:
				{
					int num3;
					int num4;
					if (checkBox.Checked)
					{
						num3 = -1475497193;
						num4 = num3;
					}
					else
					{
						num3 = -868147484;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1331324475);
					continue;
				}
				case 4u:
					kUnPbFafor0J3QMB4AvJb8s9qrI._nXF60KE2IKbrh4yi4vZrXhicucj = checkBox.Tag as string;
					num = ((int)num2 * -901998545) ^ -2001110271;
					continue;
				case 1u:
					Settings.Default.AntiLagIgnoredEffects = Settings.Default.AntiLagIgnoredEffects.Concat(new string[1]
					{
						kUnPbFafor0J3QMB4AvJb8s9qrI._nXF60KE2IKbrh4yi4vZrXhicucj
					}).ToArray();
					return;
				case 5u:
					kUnPbFafor0J3QMB4AvJb8s9qrI = new _KUnPbFafor0J3QMB4AvJb8s9qrI();
					num = (int)((num2 * 68694512) ^ 0x21F09B63);
					continue;
				case 2u:
					Settings.Default.AntiLagIgnoredEffects = Settings.Default.AntiLagIgnoredEffects.Where(kUnPbFafor0J3QMB4AvJb8s9qrI._ej91vz2gOj3VIAxci4pjGbkUcbF).ToArray();
					num = 908684054;
					continue;
				case 6u:
					return;
				}
				break;
			}
		}
	}

	private void _iiRje7pLOCPJBJq4FQkrKjkBqvc(object sender, FormClosedEventArgs e)
	{
		Settings.Default.Save();
	}

	protected override void _8H2QqjADGkx30Hq77Uf9ZGuRzFD(bool disposing)
	{
		if (disposing)
		{
			goto IL_0003;
		}
		goto IL_004e;
		IL_004e:
		Dispose(disposing);
		int num = -1313651137;
		goto IL_0008;
		IL_0008:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xD8635D0Fu) % 5u)
			{
			case 0u:
				break;
			default:
				return;
			case 2u:
			{
				int num3;
				int num4;
				if (_CQeJ5ARN3cqDqwayOhiu7devmaC == null)
				{
					num3 = 350760997;
					num4 = num3;
				}
				else
				{
					num3 = 1332854666;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -1159360978);
				continue;
			}
			case 1u:
				goto IL_004e;
			case 4u:
				_CQeJ5ARN3cqDqwayOhiu7devmaC.Dispose();
				num = (int)(num2 * 435472972) ^ -972306903;
				continue;
			case 3u:
				return;
			}
			break;
		}
		goto IL_0003;
		IL_0003:
		num = -503256345;
		goto IL_0008;
	}

	private void _LNN7j16YxFjRwCTXxBG3QnekdGe()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_NenrIcvfEIiBFXCh64MfBebEG7f));
		_8IQDVUNGP3kUFvRXSJ5CYjmtONf = new Panel();
		_f5kDiRV6JVB3PeAj27HgG3gctN = new Label();
		SuspendLayout();
		while (true)
		{
			int num = -1004114684;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD7DAA43Du) % 22u)
				{
				case 21u:
					break;
				default:
					return;
				case 9u:
					_8IQDVUNGP3kUFvRXSJ5CYjmtONf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = (int)(num2 * 432632474) ^ -1078534145;
					continue;
				case 5u:
					base.Controls.Add(_f5kDiRV6JVB3PeAj27HgG3gctN);
					num = (int)(num2 * 1719190271) ^ -751978648;
					continue;
				case 6u:
					base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
					base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = (int)((num2 * 373155985) ^ 0x7FDC10EA);
					continue;
				case 3u:
					_f5kDiRV6JVB3PeAj27HgG3gctN.TabIndex = 15;
					_f5kDiRV6JVB3PeAj27HgG3gctN.Text = "Ignored Game Effects";
					base.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)(num2 * 546947390) ^ -956744835;
					continue;
				case 14u:
					_8IQDVUNGP3kUFvRXSJ5CYjmtONf.Location = new Point(17, 37);
					num = (int)(num2 * 1043474602) ^ -1303737856;
					continue;
				case 17u:
					_8IQDVUNGP3kUFvRXSJ5CYjmtONf.Name = "pnlEffects";
					num = (int)(num2 * 755535772) ^ -556916327;
					continue;
				case 13u:
					base.Name = "FrmSettingsIgnoredEffects";
					base.StartPosition = FormStartPosition.Manual;
					num = ((int)num2 * -242569742) ^ 0x7C9055E1;
					continue;
				case 11u:
					_f5kDiRV6JVB3PeAj27HgG3gctN.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					_f5kDiRV6JVB3PeAj27HgG3gctN.ForeColor = Color.Gold;
					_f5kDiRV6JVB3PeAj27HgG3gctN.Location = new Point(12, 9);
					_f5kDiRV6JVB3PeAj27HgG3gctN.Name = "lblEffects";
					_f5kDiRV6JVB3PeAj27HgG3gctN.Size = new Size(203, 25);
					num = ((int)num2 * -1131910642) ^ 0x2EC4DC90;
					continue;
				case 1u:
					BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
					num = ((int)num2 * -1397231354) ^ 0x36391A77;
					continue;
				case 16u:
					DoubleBuffered = true;
					Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = (int)((num2 * 482442565) ^ 0x173422F1);
					continue;
				case 4u:
					_8IQDVUNGP3kUFvRXSJ5CYjmtONf.AutoScroll = true;
					_8IQDVUNGP3kUFvRXSJ5CYjmtONf.BackColor = Color.FromArgb(34, 21, 42);
					num = ((int)num2 * -1183560818) ^ 0x49CDC2BA;
					continue;
				case 2u:
					_8IQDVUNGP3kUFvRXSJ5CYjmtONf.Font = new Font("Segoe UI", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = ((int)num2 * -726189019) ^ -926885241;
					continue;
				case 12u:
					base.AutoScaleMode = AutoScaleMode.Dpi;
					BackColor = SystemColors.ActiveCaptionText;
					num = (int)(num2 * 1430587833) ^ -176760298;
					continue;
				case 0u:
					_8IQDVUNGP3kUFvRXSJ5CYjmtONf.Size = new Size(450, 330);
					num = (int)(num2 * 702614517) ^ -2010371581;
					continue;
				case 19u:
					_8IQDVUNGP3kUFvRXSJ5CYjmtONf.BorderStyle = BorderStyle.FixedSingle;
					num = ((int)num2 * -1356112493) ^ -171337658;
					continue;
				case 18u:
					_8IQDVUNGP3kUFvRXSJ5CYjmtONf.TabIndex = 16;
					_f5kDiRV6JVB3PeAj27HgG3gctN.AutoSize = true;
					_f5kDiRV6JVB3PeAj27HgG3gctN.BackColor = Color.Transparent;
					num = ((int)num2 * -578121199) ^ 0x29630674;
					continue;
				case 8u:
					BackgroundImageLayout = ImageLayout.Stretch;
					base.ClientSize = new Size(484, 386);
					base.Controls.Add(_8IQDVUNGP3kUFvRXSJ5CYjmtONf);
					num = ((int)num2 * -53890612) ^ -1531615566;
					continue;
				case 15u:
					base.FormClosed += _iiRje7pLOCPJBJq4FQkrKjkBqvc;
					ResumeLayout(performLayout: false);
					PerformLayout();
					num = (int)((num2 * 2017675554) ^ 0x3407109C);
					continue;
				case 10u:
					Text = "RealmStock Multi-Tool";
					num = (int)(num2 * 1120495058) ^ -732000548;
					continue;
				case 20u:
					ForeColor = Color.Gainsboro;
					num = (int)(num2 * 311307493) ^ -277474611;
					continue;
				case 7u:
					return;
				}
				break;
			}
		}
	}
}
