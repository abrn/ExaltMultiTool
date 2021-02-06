using System;
using System.Xml.Linq;

internal class _jsZwrE9lzYULBcuBQfPr4S2Du8c
{
	public _8syfAqvj4kYi6KUbWf82OVQIauP _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public int _Qh0BQXXjPEcRT8iSpFFQRoYAmun;

	public float _GqTyCW3dGiBN9DxAMWAsMjwS9AY;

	public float _Z5wTZXZR7WNAVYbrlBqkpXlqERC;

	public StatDataEnum _iRJdNjdNO3i4OWssXs6R7kraxXo;

	public _jsZwrE9lzYULBcuBQfPr4S2Du8c(XElement activate)
	{
		string text = default(string);
		while (true)
		{
			int num = -1129465167;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCAC6601Bu) % 11u)
				{
				case 9u:
					break;
				default:
					return;
				case 2u:
					text = activate._4qMIb2N5gf9DdhWw9LENt8TJhOK("stat", "");
					num = ((int)num2 * -1823707508) ^ -1804385891;
					continue;
				case 7u:
					Program.LogNetworkError("core", $"Failed to parse {activate} as an ActivateType");
					num = (int)((num2 * 7086867) ^ 0x530EB2D5);
					continue;
				case 3u:
					_GqTyCW3dGiBN9DxAMWAsMjwS9AY = activate._4qMIb2N5gf9DdhWw9LENt8TJhOK("duration", "0")._y09e3EoPW54jYelUtQzj66l0jRF();
					num = ((int)num2 * -1761234068) ^ -778895462;
					continue;
				case 6u:
				{
					int num5;
					int num6;
					if (!string.IsNullOrWhiteSpace(text))
					{
						num5 = 2030783646;
						num6 = num5;
					}
					else
					{
						num5 = 1557401122;
						num6 = num5;
					}
					num = num5 ^ (int)(num2 * 526581216);
					continue;
				}
				case 4u:
					Program.LogNetworkError("core", "Failed to parse " + text + " as a StatsType");
					num = ((int)num2 * -1995378946) ^ 0x36F8A1BA;
					continue;
				case 5u:
					_Qh0BQXXjPEcRT8iSpFFQRoYAmun = activate._4qMIb2N5gf9DdhWw9LENt8TJhOK("amount", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
					num = -1267578482;
					continue;
				case 1u:
				{
					int num7;
					int num8;
					if (!Enum.TryParse<_8syfAqvj4kYi6KUbWf82OVQIauP>(activate.Value, out _WL2DOBxBuX9DARzf2KPoaJbgZiCb))
					{
						num7 = 384404279;
						num8 = num7;
					}
					else
					{
						num7 = 1411171661;
						num8 = num7;
					}
					num = num7 ^ (int)(num2 * 754809977);
					continue;
				}
				case 0u:
				{
					int num3;
					int num4;
					if (Enum.TryParse<StatDataEnum>(text, out _iRJdNjdNO3i4OWssXs6R7kraxXo))
					{
						num3 = 1065933758;
						num4 = num3;
					}
					else
					{
						num3 = 1158645587;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 1640775980);
					continue;
				}
				case 10u:
					_Z5wTZXZR7WNAVYbrlBqkpXlqERC = activate._4qMIb2N5gf9DdhWw9LENt8TJhOK("range", "0")._y09e3EoPW54jYelUtQzj66l0jRF();
					num = (int)(num2 * 162106928) ^ -994261581;
					continue;
				case 8u:
					return;
				}
				break;
			}
		}
	}
}
