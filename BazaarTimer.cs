using ExaltMultiTool;

internal class BazaarTimer
{
	private Client _50w8wVuv8bL5nhKaR2EHxjrTamB;

	private int _FWeRrJeEUAPVIWA2J2od8vfnvJh = 30;

	public BazaarTimer(Client client)
	{
		while (true)
		{
			int num = 641218720;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F611A4Eu) % 3u)
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
				_50w8wVuv8bL5nhKaR2EHxjrTamB = client;
				num = (int)((num2 * 1114728959) ^ 0x7F03CDE7);
			}
		}
	}

	public void SetDefadultTimer()
	{
		_FWeRrJeEUAPVIWA2J2od8vfnvJh = 30;
	}

	public void _LYllxX1tdQbcE7Ay0idETQ7uwOS()
	{
		if (!Settings.Default.EnableBazaarTimer) {
			return;
		}
		goto IL_0104;
		IL_0104:
		int num;
		int num2;
		if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._XJlaeK8gdtamxYwZJIRc2tEXKcQA.Contains("Bazaar"))
		{
			num = 352386156;
			num2 = num;
		}
		else
		{
			num = 743799382;
			num2 = num;
		}
		goto IL_0014;
		IL_0014:
		int num4 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x7C44BDD5u) % 9u)
			{
			case 3u:
				break;
			default:
				return;
			case 8u:
				return;
			case 6u:
				num4 = _FWeRrJeEUAPVIWA2J2od8vfnvJh--;
				num = (int)(num3 * 156611108) ^ -78161964;
				continue;
			case 5u:
			{
				int num5;
				int num6;
				if (num4 % 5 != 0)
				{
					num5 = 631048496;
					num6 = num5;
				}
				else
				{
					num5 = 422576025;
					num6 = num5;
				}
				num = num5 ^ (int)(num3 * 293956748);
				continue;
			}
			case 7u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB.sendChatNotification("Bazaar Timer", _FWeRrJeEUAPVIWA2J2od8vfnvJh + " seconds until you can enter portals");
				num = (int)((num3 * 1730820426) ^ 0x43F873EC);
				continue;
			case 0u:
				return;
			case 1u:
				goto IL_00e7;
			case 2u:
				goto IL_0104;
			case 4u:
				return;
			}
			break;
			IL_00e7:
			int num7;
			if (_FWeRrJeEUAPVIWA2J2od8vfnvJh > 0)
			{
				num = 1063512220;
				num7 = num;
			}
			else
			{
				num = 1212166284;
				num7 = num;
			}
		}
		goto IL_000f;
		IL_000f:
		num = 864517364;
		goto IL_0014;
	}

	private int _GzL3tpUK57dZuf2yDfFBQYL16Rj(int percent)
	{
		//Discarded unreachable code: IL_0038
		if (percent > 50)
		{
			while (true)
			{
				uint num;
				switch ((num = 0xBE7E49B6u ^ 0xB1A821C0u) % 3u)
				{
				case 0u:
					continue;
				case 1u:
					return 65280 + 327680 * (100 - percent);
				}
				break;
			}
		}
		return 16776960 - 1280 * (50 - percent);
	}
}
