internal class _X6f9REQnd8GedncwYfuKQX9BeNq : WorldPosData
{
	public int _IBSqBdwNTiXSzhZbDhEFMC0Gc51;

	public _X6f9REQnd8GedncwYfuKQX9BeNq(int time, double x, double y)
	{
		while (true)
		{
			int num = 1819614313;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x494072CBu) % 4u)
				{
				case 0u:
					break;
				case 2u:
					_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = time;
					num = (int)((num2 * 557837938) ^ 0x5B5D76AC);
					continue;
				case 3u:
					_PositionX = x;
					num = ((int)num2 * -237423107) ^ 0x1EDFC9D9;
					continue;
				default:
					_PositionY = y;
					return;
				}
				break;
			}
		}
	}

	public _X6f9REQnd8GedncwYfuKQX9BeNq(PacketReader r)
	{
		while (true)
		{
			int num = -536987467;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8C3CC202u) % 4u)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
					_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
					num = (int)((num2 * 1849517763) ^ 0x7D51C083);
					continue;
				case 0u:
					base.Read(r);
					num = ((int)num2 * -1983092170) ^ -388642789;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public override IDataObject Read(PacketReader r)
	{
		_IBSqBdwNTiXSzhZbDhEFMC0Gc51 = r.ReadInt32();
		while (true)
		{
			int num = 14197837;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x3CEDE5FAu) % 3u)
				{
				case 0u:
					break;
				case 1u:
					goto IL_002e;
				default:
					return this;
				}
				break;
				IL_002e:
				base.Read(r);
				num = (int)((num2 * 878898289) ^ 0x3610F880);
			}
		}
	}

	public override void Write(PacketWriter w)
	{
		w.Write(_IBSqBdwNTiXSzhZbDhEFMC0Gc51);
		base.Write(w);
	}

	public override object _fFrzINN4428s60nDsq4NVS5FVCb()
	{
		return new _X6f9REQnd8GedncwYfuKQX9BeNq(_IBSqBdwNTiXSzhZbDhEFMC0Gc51, _PositionX, _PositionY);
	}

	public override string ToString()
	{
		return "{ Time=" + _IBSqBdwNTiXSzhZbDhEFMC0Gc51 + ", X=" + _PositionX + ", Y=" + _PositionY + " }";
	}
}
