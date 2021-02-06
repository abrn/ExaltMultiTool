internal class _5gQBYpWvIJQibBR6ggclQe9CpXV
{
	private int _fsOXXPte1p3BX8HsXOLFJ0YHG98;

	public void _kcBjTzBYfTPCpKNctSQjw45y1mb()
	{
		_fsOXXPte1p3BX8HsXOLFJ0YHG98 = 0;
	}

	public void _RaJfLbqtDAWcw1IcTvMZKk5jtcu(GuildInviteRequestPacket invitedToGuild)
	{
		int num = _fsOXXPte1p3BX8HsXOLFJ0YHG98++;
		while (true)
		{
			int num2 = 1810426925;
			while (true)
			{
				uint num3;
				switch ((num3 = (uint)num2 ^ 0x5F0DD5B0u) % 4u)
				{
				case 3u:
					break;
				default:
					return;
				case 1u:
				{
					int num4;
					int num5;
					if (num > 5)
					{
						num4 = -1522931448;
						num5 = num4;
					}
					else
					{
						num4 = -79882402;
						num5 = num4;
					}
					num2 = num4 ^ ((int)num3 * -1711460648);
					continue;
				}
				case 0u:
					invitedToGuild._Send = false;
					num2 = ((int)num3 * -103019715) ^ 0x1048E6E6;
					continue;
				case 2u:
					return;
				}
				break;
			}
		}
	}
}
