namespace ExaltMultiTool.Proxy.DataStructures
{
	public class PotionInfo
	{
		public int Type;

		public byte Quantity;

		public PotionInfo(int type, byte quantity)
		{
			while (true)
			{
				int num = 594202830;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x35FCE612u) % 3u)
					{
					case 0u:
						break;
					case 2u:
						goto IL_0028;
					default:
						Quantity = quantity;
						return;
					}
					break;
					IL_0028:
					Type = type;
					num = (int)(num2 * 1649181839) ^ -1480250762;
				}
			}
		}
	}
}
