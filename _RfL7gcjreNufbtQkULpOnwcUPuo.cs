using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.DataStructures;

internal class _RfL7gcjreNufbtQkULpOnwcUPuo : Form
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _jUWaQ5L2pqzJuXIYrRVijuF7a8D
	{
		public static readonly _jUWaQ5L2pqzJuXIYrRVijuF7a8D _003C_003E9 = new _jUWaQ5L2pqzJuXIYrRVijuF7a8D();

		public static Func<int, ObjectStructure> _003C_003E9__0_0;

		public static Func<ObjectStructure, bool> _003C_003E9__0_1;

		public static Func<ObjectStructure, string> _003C_003E9__0_2;

		public static Func<ObjectStructure, bool> _003C_003E9__3_0;

		public static Func<ObjectStructure, string> _003C_003E9__3_1;

		public static Func<string, int> _003C_003E9__8_0;

		internal ObjectStructure _YDal1jzeWBTkOMhBAAsQkEvXRIl(int id)
		{
			return ResourceDownloader._VPArsrlUa0uEsW6OxAYV9WHJAMK._EOUVvVncv0meCCDQkGXOyUOLU5F((ushort)id);
		}

		internal bool _kylyGEB0rsulS95oMki2R2rU02G(ObjectStructure type)
		{
			return type.Enemy;
		}

		internal string _jGYAvuChjj4cIvzaZ9CT5sXZEZaA(ObjectStructure type)
		{
			return type.Name;
		}

		internal bool _3oODK4qiRl4mzbgJIDJaHVPYMWh(ObjectStructure type)
		{
			return type.Enemy;
		}

		internal string _yqUboxvLK82OZyipsIXuUbJwVEl(ObjectStructure type)
		{
			return type.Name;
		}

		internal int _hNDxNn71hkz4t8qiRafNirPLSOd(string Item)
		{
			return ResourceDownloader._VPArsrlUa0uEsW6OxAYV9WHJAMK._CIP8YWjFYfHaxjiqS7kJqwxkotm(Item).ID;
		}
	}

	[CompilerGenerated]
	private sealed class _C6fMzfXibY846cToyNJtz6f6SWG
	{
		public string _3VUqGiVvV7FjTf0llC5g9L1DDfq;

		internal bool _c89bWSCAhBYgjaCfjSBJ6a2YBs1A(string name)
		{
			//Discarded unreachable code: IL_0046
			if (!(_3VUqGiVvV7FjTf0llC5g9L1DDfq == ""))
			{
				while (true)
				{
					uint num;
					switch ((num = 0x506972D3u ^ 0x4EC17E12u) % 3u)
					{
					case 0u:
						continue;
					case 1u:
						return name.ToLower().Contains(_3VUqGiVvV7FjTf0llC5g9L1DDfq);
					}
					break;
				}
			}
			return true;
		}
	}

	private IContainer _CQeJ5ARN3cqDqwayOhiu7devmaC;

	private Label _2tenHROwoapg2MzRcZcChMnKr0o;

	private Panel _2CuA0wnmuwYgJPWBwFlIKzC701FA;

	private ListBox _93gIKT2AuhpAu6Mg44FufhOwddm;

	private Button _p5qrmztmwMPri0E7BbinX5kzAkb;

	private Label _PITZqRQLeEieZA2aJ8aVuaMVo1A;

	private Panel _oMpPVADEZ7THjfpbw1AOqDls6Xi;

	private ListBox _TQVy1n9sXJC4L2B1RVg2HB1vFwg;

	private TextBox _GpH9ahPvwYwjLjY4oAxkxib5WgC;

	private Button _jTnbQCCLLRWs73ZbPcdZ6sniZTN;

	private Button _co2SOmpcgGCbwipicCZUdDcCvcDA;

	public _RfL7gcjreNufbtQkULpOnwcUPuo()
	{
		while (true)
		{
			int num = 744211026;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5F8A8505u) % 5u)
				{
				case 3u:
					break;
				default:
					return;
				case 2u:
					_LNN7j16YxFjRwCTXxBG3QnekdGe();
					num = (int)((num2 * 1945880750) ^ 0x6029621B);
					continue;
				case 4u:
				{
					ListBox.ObjectCollection items = _TQVy1n9sXJC4L2B1RVg2HB1vFwg.Items;
					object[] items2 = (from id in Settings.Default.FameIngoredEnemies
						select ResourceDownloader._VPArsrlUa0uEsW6OxAYV9WHJAMK._EOUVvVncv0meCCDQkGXOyUOLU5F((ushort)id) into type
						where type.Enemy
						select type.Name).ToArray();
					items.AddRange(items2);
					_47uIeAt3CL9eFAtlSoyGwQU3wMs();
					_93gIKT2AuhpAu6Mg44FufhOwddm.SelectedIndex = 0;
					num = 248912664;
					continue;
				}
				case 0u:
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.SelectedIndex = -1;
					num = ((int)num2 * -871994711) ^ -183245817;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	private void _2s1bmV4H7eSNResk7kqJAwctIiB(object sender, EventArgs e)
	{
		_GpH9ahPvwYwjLjY4oAxkxib5WgC.Clear();
	}

	private void _zl2J8stSwNh2bNvVcR6KBvTfebs(object sender, EventArgs e)
	{
		_47uIeAt3CL9eFAtlSoyGwQU3wMs(_GpH9ahPvwYwjLjY4oAxkxib5WgC.Text);
	}

	private void _47uIeAt3CL9eFAtlSoyGwQU3wMs(string filter = "")
	{
		filter = filter.ToLower();
		_93gIKT2AuhpAu6Mg44FufhOwddm.Items.Clear();
		ListBox.ObjectCollection items = _93gIKT2AuhpAu6Mg44FufhOwddm.Items;
		object[] items2 = (from type in ResourceDownloader._VPArsrlUa0uEsW6OxAYV9WHJAMK._oQlNWqxOoe5LqobGdGJlgo4YIsh.Values
			where type.Enemy
			select type.Name).Where(delegate(string name)
		{
			//Discarded unreachable code: IL_0046
			if (!(filter == ""))
			{
				while (true)
				{
					uint num;
					switch ((num = 0x506972D3u ^ 0x4EC17E12u) % 3u)
					{
					case 0u:
						continue;
					case 1u:
						return name.ToLower().Contains(filter);
					}
					break;
				}
			}
			return true;
		}).ToArray();
		items.AddRange(items2);
	}

	private void _081oVjPpjfCIAiRKRwYhy9t5dSB(object sender, EventArgs e)
	{
		_p5qrmztmwMPri0E7BbinX5kzAkb.Enabled = _93gIKT2AuhpAu6Mg44FufhOwddm.SelectedIndex > -1;
	}

	private void _CnpLE6oYA3Cs5cFEfzEDGK6aHIR(object sender, EventArgs e)
	{
		_co2SOmpcgGCbwipicCZUdDcCvcDA.Enabled = _TQVy1n9sXJC4L2B1RVg2HB1vFwg.SelectedIndex > -1;
	}

	private void _RNNFD8MJInJ8RoBjPUca6uI9kHV(object sender, EventArgs e)
	{
		if (_TQVy1n9sXJC4L2B1RVg2HB1vFwg.Items.Contains(_93gIKT2AuhpAu6Mg44FufhOwddm.SelectedItem))
		{
			return;
		}
		while (true)
		{
			int num = 775939362;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x501BFBA7u) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_003f;
				case 0u:
					return;
				}
				break;
				IL_003f:
				_TQVy1n9sXJC4L2B1RVg2HB1vFwg.Items.Add(_93gIKT2AuhpAu6Mg44FufhOwddm.SelectedItem);
				_Ki0ZDyZ2DkunPLe4H3Ix7qOIfK();
				num = (int)(num2 * 999361319) ^ -612365186;
			}
		}
	}

	private void _aJvbXhn9QlAqeOoYWXQ7wRtLuGh(object sender, EventArgs e)
	{
		_TQVy1n9sXJC4L2B1RVg2HB1vFwg.Items.Remove(_TQVy1n9sXJC4L2B1RVg2HB1vFwg.SelectedItem);
		_Ki0ZDyZ2DkunPLe4H3Ix7qOIfK();
	}

	private void _Ki0ZDyZ2DkunPLe4H3Ix7qOIfK()
	{
		Settings.Default.FameIngoredEnemies = _TQVy1n9sXJC4L2B1RVg2HB1vFwg.Items.Cast<string>().Select((Func<string, int>)((string Item) => ResourceDownloader._VPArsrlUa0uEsW6OxAYV9WHJAMK._CIP8YWjFYfHaxjiqS7kJqwxkotm(Item).ID)).ToArray();
		while (true)
		{
			int num = 761271567;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x196CDB6Du) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0065;
				case 1u:
					return;
				}
				break;
				IL_0065:
				Settings.Default.Save();
				num = (int)(num2 * 2140233947) ^ -662208232;
			}
		}
	}

	private void _ZnDZ9HpCs2maCcm1OpBhSBai5Zdb(object sender, EventArgs e)
	{
		_TQVy1n9sXJC4L2B1RVg2HB1vFwg.Items.Clear();
		while (true)
		{
			int num = -758017153;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9208F3E1u) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0032;
				case 0u:
					return;
				}
				break;
				IL_0032:
				_Ki0ZDyZ2DkunPLe4H3Ix7qOIfK();
				num = (int)((num2 * 349112160) ^ 0x666A09B3);
			}
		}
	}

	protected override void _8H2QqjADGkx30Hq77Uf9ZGuRzFD(bool disposing)
	{
		if (disposing)
		{
			while (true)
			{
				int num = -611294446;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xF8901CE7u) % 4u)
					{
					case 2u:
						break;
					case 1u:
					{
						int num3;
						int num4;
						if (_CQeJ5ARN3cqDqwayOhiu7devmaC != null)
						{
							num3 = -1000271283;
							num4 = num3;
						}
						else
						{
							num3 = -479834982;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -1846283919);
						continue;
					}
					case 3u:
						_CQeJ5ARN3cqDqwayOhiu7devmaC.Dispose();
						num = (int)(num2 * 732815218) ^ -2109399023;
						continue;
					default:
						goto IL_0064;
					}
					break;
				}
			}
		}
		goto IL_0064;
		IL_0064:
		Dispose(disposing);
	}

	private void _LNN7j16YxFjRwCTXxBG3QnekdGe()
	{
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(_RfL7gcjreNufbtQkULpOnwcUPuo));
		_2tenHROwoapg2MzRcZcChMnKr0o = new Label();
		_2CuA0wnmuwYgJPWBwFlIKzC701FA = new Panel();
		_p5qrmztmwMPri0E7BbinX5kzAkb = new Button();
		while (true)
		{
			int num = -656099806;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC1284052u) % 84u)
				{
				case 38u:
					break;
				case 5u:
					_co2SOmpcgGCbwipicCZUdDcCvcDA.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = ((int)num2 * -2141776277) ^ 0xD90B58F;
					continue;
				case 13u:
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.Text = "Search...";
					num = (int)(num2 * 1095870221) ^ -1435957632;
					continue;
				case 47u:
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.FormattingEnabled = true;
					num = ((int)num2 * -1967641493) ^ 0x725BBCB3;
					continue;
				case 20u:
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.UseVisualStyleBackColor = false;
					num = (int)(num2 * 859963258) ^ -1405652808;
					continue;
				case 25u:
					_2tenHROwoapg2MzRcZcChMnKr0o.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = (int)((num2 * 1671194598) ^ 0x7FEDD5E7);
					continue;
				case 30u:
					_2CuA0wnmuwYgJPWBwFlIKzC701FA.Size = new Size(244, 272);
					_2CuA0wnmuwYgJPWBwFlIKzC701FA.TabIndex = 14;
					num = ((int)num2 * -222403040) ^ 0x2F9B15B8;
					continue;
				case 22u:
					_PITZqRQLeEieZA2aJ8aVuaMVo1A.Font = new Font("Segoe UI", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					_PITZqRQLeEieZA2aJ8aVuaMVo1A.ForeColor = Color.Gold;
					_PITZqRQLeEieZA2aJ8aVuaMVo1A.Location = new Point(262, 9);
					num = ((int)num2 * -1093668152) ^ -1517657350;
					continue;
				case 67u:
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.Size = new Size(244, 22);
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.TabIndex = 13;
					num = ((int)num2 * -1610275060) ^ 0x1DBA8A63;
					continue;
				case 2u:
					_2CuA0wnmuwYgJPWBwFlIKzC701FA.ResumeLayout(performLayout: false);
					num = (int)(num2 * 961080653) ^ -1012345573;
					continue;
				case 77u:
					_PITZqRQLeEieZA2aJ8aVuaMVo1A.TabIndex = 9;
					num = (int)(num2 * 609961684) ^ -998802754;
					continue;
				case 24u:
					_co2SOmpcgGCbwipicCZUdDcCvcDA.Click += _aJvbXhn9QlAqeOoYWXQ7wRtLuGh;
					base.AutoScaleDimensions = new SizeF(96f, 96f);
					num = (int)((num2 * 1240119784) ^ 0x3BF232A);
					continue;
				case 52u:
					_2tenHROwoapg2MzRcZcChMnKr0o.Size = new Size(112, 25);
					num = (int)((num2 * 1948580699) ^ 0x343CAE91);
					continue;
				case 41u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.Click += _RNNFD8MJInJ8RoBjPUca6uI9kHV;
					num = (int)(num2 * 97767753) ^ -1710392672;
					continue;
				case 58u:
					_oMpPVADEZ7THjfpbw1AOqDls6Xi.SuspendLayout();
					num = ((int)num2 * -1822657972) ^ 0x2BBB79D4;
					continue;
				case 49u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.BackColor = Color.FromArgb(162, 57, 202);
					num = ((int)num2 * -329546613) ^ 0x50CB01F9;
					continue;
				case 18u:
					_co2SOmpcgGCbwipicCZUdDcCvcDA.ForeColor = Color.Gold;
					num = ((int)num2 * -1266135322) ^ 0x5EC9672A;
					continue;
				case 36u:
					_PITZqRQLeEieZA2aJ8aVuaMVo1A.Text = "Ignored Enemies";
					num = (int)(num2 * 1745593268) ^ -596406813;
					continue;
				case 33u:
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN = new Button();
					num = ((int)num2 * -430669643) ^ 0xCE82740;
					continue;
				case 61u:
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.Font = new Font("Segoe UI", 8.25f);
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.ForeColor = Color.Gold;
					num = (int)(num2 * 271613538) ^ -9583969;
					continue;
				case 51u:
					BackgroundImage = (Image)componentResourceManager.GetObject("$this.BackgroundImage");
					num = ((int)num2 * -900220842) ^ 0x15E17087;
					continue;
				case 0u:
					base.Name = "FrmSettingsIgnoredEnemies";
					num = ((int)num2 * -519991400) ^ -238479639;
					continue;
				case 27u:
					_co2SOmpcgGCbwipicCZUdDcCvcDA.TabIndex = 12;
					num = ((int)num2 * -372454174) ^ 0x39F90DB1;
					continue;
				case 21u:
					_93gIKT2AuhpAu6Mg44FufhOwddm.Dock = DockStyle.Fill;
					num = ((int)num2 * -109718767) ^ 0x27B31B92;
					continue;
				case 81u:
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.BackColor = Color.FromArgb(14, 11, 22);
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.FlatAppearance.BorderColor = Color.Gray;
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.FlatStyle = FlatStyle.Flat;
					num = (int)(num2 * 74881639) ^ -2128552872;
					continue;
				case 15u:
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.SelectedIndexChanged += _CnpLE6oYA3Cs5cFEfzEDGK6aHIR;
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = (int)((num2 * 2054739961) ^ 0x5BAD53F4);
					continue;
				case 76u:
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.Size = new Size(200, 22);
					num = (int)((num2 * 1455683785) ^ 0x6714C717);
					continue;
				case 8u:
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.IntegralHeight = false;
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.Location = new Point(0, 0);
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.Name = "lstIgnored";
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.Size = new Size(200, 272);
					num = (int)(num2 * 197156608) ^ -1022212559;
					continue;
				case 57u:
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg = new ListBox();
					num = (int)((num2 * 1639049230) ^ 0x7A37EC);
					continue;
				case 60u:
					_co2SOmpcgGCbwipicCZUdDcCvcDA.Name = "btnRemove";
					num = ((int)num2 * -1104673898) ^ -726318013;
					continue;
				case 53u:
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.BackColor = Color.FromArgb(14, 11, 22);
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.BorderStyle = BorderStyle.FixedSingle;
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.ForeColor = Color.Gold;
					num = ((int)num2 * -973915486) ^ -1171108138;
					continue;
				case 74u:
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.Location = new Point(17, 315);
					num = ((int)num2 * -1838073568) ^ 0x4366640C;
					continue;
				case 56u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.Enabled = false;
					num = ((int)num2 * -2140980338) ^ -2026537818;
					continue;
				case 75u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.ForeColor = Color.Gold;
					_p5qrmztmwMPri0E7BbinX5kzAkb.Location = new Point(17, 343);
					num = (int)((num2 * 678233639) ^ 0x44121E8F);
					continue;
				case 66u:
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.Click += _ZnDZ9HpCs2maCcm1OpBhSBai5Zdb;
					num = (int)(num2 * 1210723231) ^ -490592474;
					continue;
				case 23u:
					_2tenHROwoapg2MzRcZcChMnKr0o.ForeColor = Color.Gold;
					num = (int)(num2 * 1696930194) ^ -1625102492;
					continue;
				case 50u:
					SuspendLayout();
					_2tenHROwoapg2MzRcZcChMnKr0o.AutoSize = true;
					_2tenHROwoapg2MzRcZcChMnKr0o.BackColor = Color.Transparent;
					num = ((int)num2 * -100478418) ^ -703788241;
					continue;
				case 73u:
					base.Controls.Add(_oMpPVADEZ7THjfpbw1AOqDls6Xi);
					num = (int)(num2 * 412410139) ^ -1109218183;
					continue;
				case 12u:
					base.Controls.Add(_GpH9ahPvwYwjLjY4oAxkxib5WgC);
					num = ((int)num2 * -390730815) ^ -314018447;
					continue;
				case 28u:
					base.Controls.Add(_2CuA0wnmuwYgJPWBwFlIKzC701FA);
					num = ((int)num2 * -948057848) ^ 0x594D399A;
					continue;
				case 59u:
					_co2SOmpcgGCbwipicCZUdDcCvcDA = new Button();
					num = (int)((num2 * 2072205593) ^ 0x3724DF);
					continue;
				case 1u:
					_PITZqRQLeEieZA2aJ8aVuaMVo1A.Size = new Size(161, 25);
					num = ((int)num2 * -1059337087) ^ -1374229506;
					continue;
				case 4u:
					_GpH9ahPvwYwjLjY4oAxkxib5WgC = new TextBox();
					_93gIKT2AuhpAu6Mg44FufhOwddm = new ListBox();
					num = ((int)num2 * -329972490) ^ -2042605485;
					continue;
				case 65u:
					_co2SOmpcgGCbwipicCZUdDcCvcDA.Size = new Size(200, 25);
					num = (int)((num2 * 1586071251) ^ 0x15E241C6);
					continue;
				case 34u:
					base.ClientSize = new Size(484, 386);
					num = (int)(num2 * 1547152360) ^ -1811472797;
					continue;
				case 45u:
					base.Controls.Add(_jTnbQCCLLRWs73ZbPcdZ6sniZTN);
					num = (int)((num2 * 206175007) ^ 0x4288ACA0);
					continue;
				case 10u:
					_2CuA0wnmuwYgJPWBwFlIKzC701FA.SuspendLayout();
					num = (int)((num2 * 1236029570) ^ 0x6D79C680);
					continue;
				case 79u:
					_2tenHROwoapg2MzRcZcChMnKr0o.TabIndex = 0;
					num = ((int)num2 * -1589985998) ^ -1370526338;
					continue;
				case 39u:
					_oMpPVADEZ7THjfpbw1AOqDls6Xi.ResumeLayout(performLayout: false);
					num = (int)((num2 * 1266108226) ^ 0xED14666);
					continue;
				case 14u:
					base.FormBorderStyle = FormBorderStyle.SizableToolWindow;
					base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
					num = ((int)num2 * -106975712) ^ 0x4AE7CE9E;
					continue;
				case 31u:
					base.Controls.Add(_co2SOmpcgGCbwipicCZUdDcCvcDA);
					num = (int)(num2 * 622311531) ^ -151980735;
					continue;
				case 83u:
					_93gIKT2AuhpAu6Mg44FufhOwddm.SelectedIndexChanged += _081oVjPpjfCIAiRKRwYhy9t5dSB;
					num = (int)((num2 * 844940651) ^ 0x5CFAD3EE);
					continue;
				case 80u:
					_PITZqRQLeEieZA2aJ8aVuaMVo1A = new Label();
					_oMpPVADEZ7THjfpbw1AOqDls6Xi = new Panel();
					num = (int)(num2 * 379387014) ^ -857331257;
					continue;
				case 9u:
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.TabIndex = 16;
					num = ((int)num2 * -1721075318) ^ 0x38CCA161;
					continue;
				case 37u:
					_co2SOmpcgGCbwipicCZUdDcCvcDA.Text = "Remove Selected";
					_co2SOmpcgGCbwipicCZUdDcCvcDA.UseVisualStyleBackColor = false;
					num = ((int)num2 * -561344649) ^ -1472224575;
					continue;
				case 43u:
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.TabIndex = 10;
					num = (int)(num2 * 520387698) ^ -1102338961;
					continue;
				case 17u:
					_oMpPVADEZ7THjfpbw1AOqDls6Xi.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
					_oMpPVADEZ7THjfpbw1AOqDls6Xi.Controls.Add(_TQVy1n9sXJC4L2B1RVg2HB1vFwg);
					_oMpPVADEZ7THjfpbw1AOqDls6Xi.Location = new Point(267, 37);
					_oMpPVADEZ7THjfpbw1AOqDls6Xi.Name = "pnlIgnored";
					num = (int)(num2 * 1586204335) ^ -295725711;
					continue;
				case 69u:
					_93gIKT2AuhpAu6Mg44FufhOwddm.ForeColor = Color.Gainsboro;
					_93gIKT2AuhpAu6Mg44FufhOwddm.FormattingEnabled = true;
					num = ((int)num2 * -1396841400) ^ -1099624579;
					continue;
				case 72u:
					_93gIKT2AuhpAu6Mg44FufhOwddm.TabIndex = 8;
					num = ((int)num2 * -880277840) ^ -1933948395;
					continue;
				case 64u:
					_PITZqRQLeEieZA2aJ8aVuaMVo1A.Name = "lblIgnored";
					num = ((int)num2 * -1200504977) ^ -1842705333;
					continue;
				case 62u:
					_co2SOmpcgGCbwipicCZUdDcCvcDA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
					_co2SOmpcgGCbwipicCZUdDcCvcDA.BackColor = Color.FromArgb(162, 57, 202);
					_co2SOmpcgGCbwipicCZUdDcCvcDA.FlatAppearance.BorderSize = 0;
					_co2SOmpcgGCbwipicCZUdDcCvcDA.FlatStyle = FlatStyle.Flat;
					num = (int)((num2 * 635635978) ^ 0x6F9AC2EB);
					continue;
				case 82u:
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.Name = "tbxFilter";
					num = ((int)num2 * -650176402) ^ 0x5A2CB025;
					continue;
				case 44u:
					base.AutoScaleMode = AutoScaleMode.Dpi;
					BackColor = SystemColors.ActiveCaptionText;
					num = ((int)num2 * -1708314057) ^ 0x6F236321;
					continue;
				case 54u:
					_2tenHROwoapg2MzRcZcChMnKr0o.Text = "All Enemies";
					_2CuA0wnmuwYgJPWBwFlIKzC701FA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					_2CuA0wnmuwYgJPWBwFlIKzC701FA.Controls.Add(_93gIKT2AuhpAu6Mg44FufhOwddm);
					_2CuA0wnmuwYgJPWBwFlIKzC701FA.Location = new Point(17, 37);
					_2CuA0wnmuwYgJPWBwFlIKzC701FA.Name = "pnlEnemies";
					num = ((int)num2 * -353540539) ^ 0x69BF313A;
					continue;
				case 29u:
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.Text = "Remove All";
					num = (int)((num2 * 446581133) ^ 0x4CAC946F);
					continue;
				case 68u:
					_co2SOmpcgGCbwipicCZUdDcCvcDA.Location = new Point(267, 343);
					num = ((int)num2 * -407540393) ^ 0x2879594A;
					continue;
				case 19u:
					_93gIKT2AuhpAu6Mg44FufhOwddm.IntegralHeight = false;
					_93gIKT2AuhpAu6Mg44FufhOwddm.Location = new Point(0, 0);
					_93gIKT2AuhpAu6Mg44FufhOwddm.Name = "lstEnemies";
					_93gIKT2AuhpAu6Mg44FufhOwddm.Size = new Size(244, 272);
					num = ((int)num2 * -473427229) ^ 0x68E48DB7;
					continue;
				case 6u:
					_oMpPVADEZ7THjfpbw1AOqDls6Xi.TabIndex = 15;
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.BackColor = Color.FromArgb(14, 11, 22);
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.BorderStyle = BorderStyle.FixedSingle;
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.Dock = DockStyle.Fill;
					_TQVy1n9sXJC4L2B1RVg2HB1vFwg.ForeColor = Color.Gainsboro;
					num = (int)(num2 * 1414598178) ^ -1383849283;
					continue;
				case 48u:
					_2tenHROwoapg2MzRcZcChMnKr0o.Location = new Point(12, 9);
					num = (int)((num2 * 1885985975) ^ 0xA2E56F8);
					continue;
				case 32u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.FlatAppearance.BorderSize = 0;
					_p5qrmztmwMPri0E7BbinX5kzAkb.FlatStyle = FlatStyle.Flat;
					_p5qrmztmwMPri0E7BbinX5kzAkb.Font = new Font("Segoe UI", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
					num = (int)((num2 * 1855968233) ^ 0x5DB22D79);
					continue;
				case 63u:
					BackgroundImageLayout = ImageLayout.Stretch;
					num = (int)(num2 * 1057643616) ^ -2113087772;
					continue;
				case 35u:
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.Click += _2s1bmV4H7eSNResk7kqJAwctIiB;
					_GpH9ahPvwYwjLjY4oAxkxib5WgC.TextChanged += _zl2J8stSwNh2bNvVcR6KBvTfebs;
					_93gIKT2AuhpAu6Mg44FufhOwddm.BackColor = Color.FromArgb(14, 11, 22);
					_93gIKT2AuhpAu6Mg44FufhOwddm.BorderStyle = BorderStyle.FixedSingle;
					num = ((int)num2 * -1291835574) ^ 0x68F59369;
					continue;
				case 46u:
					ForeColor = Color.Gainsboro;
					num = (int)((num2 * 1100105218) ^ 0x6D8DE58C);
					continue;
				case 7u:
					_PITZqRQLeEieZA2aJ8aVuaMVo1A.BackColor = Color.Transparent;
					num = ((int)num2 * -1296958990) ^ 0xD7B7BFA;
					continue;
				case 16u:
					_oMpPVADEZ7THjfpbw1AOqDls6Xi.Size = new Size(200, 272);
					num = (int)(num2 * 1867027321) ^ -1018608844;
					continue;
				case 70u:
					_2tenHROwoapg2MzRcZcChMnKr0o.Name = "lblEnemies";
					num = (int)(num2 * 1812893070) ^ -1679426010;
					continue;
				case 11u:
					_PITZqRQLeEieZA2aJ8aVuaMVo1A.Anchor = AnchorStyles.Top | AnchorStyles.Right;
					_PITZqRQLeEieZA2aJ8aVuaMVo1A.AutoSize = true;
					num = ((int)num2 * -1709777010) ^ 0x1A5E25D7;
					continue;
				case 40u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.Name = "btnAdd";
					_p5qrmztmwMPri0E7BbinX5kzAkb.Size = new Size(244, 25);
					_p5qrmztmwMPri0E7BbinX5kzAkb.TabIndex = 11;
					_p5qrmztmwMPri0E7BbinX5kzAkb.Text = "Add Selected";
					_p5qrmztmwMPri0E7BbinX5kzAkb.UseVisualStyleBackColor = false;
					num = (int)((num2 * 1360442503) ^ 0x3159B1A3);
					continue;
				case 71u:
					base.StartPosition = FormStartPosition.Manual;
					Text = "RealmStock Multi-Tool";
					num = (int)(num2 * 816490295) ^ -1614961519;
					continue;
				case 78u:
					base.Controls.Add(_p5qrmztmwMPri0E7BbinX5kzAkb);
					base.Controls.Add(_PITZqRQLeEieZA2aJ8aVuaMVo1A);
					base.Controls.Add(_2tenHROwoapg2MzRcZcChMnKr0o);
					DoubleBuffered = true;
					Font = new Font("Segoe UI", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
					num = ((int)num2 * -1925281432) ^ -1287509120;
					continue;
				case 26u:
					_p5qrmztmwMPri0E7BbinX5kzAkb.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
					num = ((int)num2 * -1506183969) ^ -2093802603;
					continue;
				case 55u:
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.Name = "btnRemoveAll";
					num = ((int)num2 * -1873632730) ^ -112365256;
					continue;
				case 3u:
					_jTnbQCCLLRWs73ZbPcdZ6sniZTN.Location = new Point(267, 315);
					num = ((int)num2 * -2045804508) ^ -1214679883;
					continue;
				default:
					ResumeLayout(performLayout: false);
					PerformLayout();
					return;
				}
				break;
			}
		}
	}
}
