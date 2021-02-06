using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

internal static class _rdMCw9C9LaemtQR2ZnzJk97z12o
{
	public static IEnumerable<_0001> _rvkyhEufCiuaZq8jbaYgthJoLEx<_0001>(this IEnumerable<_0001> input, Action<_0001> action)
	{
		IEnumerator<_0001> enumerator = input.GetEnumerator();
		try
		{
			_0001 current = default(_0001);
			while (true)
			{
				int num;
				int num2;
				if (!enumerator.MoveNext())
				{
					num = -307112213;
					num2 = num;
				}
				else
				{
					num = -883242129;
					num2 = num;
				}
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num ^ 0xF6D0B476u) % 5u)
					{
					case 3u:
						num = -883242129;
						continue;
					case 2u:
						break;
					case 0u:
						action(current);
						num = ((int)num3 * -1689739159) ^ -1313475927;
						continue;
					case 1u:
						current = enumerator.Current;
						num = -1716658162;
						continue;
					default:
						return input;
					case 4u:
						return input;
					}
					break;
				}
			}
		}
		finally
		{
			if (enumerator != null)
			{
				while (true)
				{
					int num4 = -97837675;
					while (true)
					{
						uint num3;
						switch ((num3 = (uint)num4 ^ 0xF6D0B476u) % 3u)
						{
						case 0u:
							break;
						default:
							goto end_IL_0072;
						case 2u:
							goto IL_0097;
						case 1u:
							goto end_IL_0072;
						}
						break;
						IL_0097:
						enumerator.Dispose();
						num4 = ((int)num3 * -1533384395) ^ 0x5C817FFB;
					}
				}
			}
			end_IL_0072:;
		}
	}

	public static bool _ujE3VgDdVnbxGy9qIazxpFzbjrY(this XElement element, XName name)
	{
		return element.Elements(name).Any();
	}

	public static string _4qMIb2N5gf9DdhWw9LENt8TJhOK(this XElement element, XName name, string @default)
	{
		//Discarded unreachable code: IL_0032
		if (!element.Attributes(name).Any())
		{
			while (true)
			{
				uint num;
				switch ((num = 0x53719D3Au ^ 0xD343544u) % 3u)
				{
				case 2u:
					continue;
				case 1u:
					return @default;
				}
				break;
			}
		}
		return element.Attribute(name).Value;
	}

	public static string _bUyefY83pIQc4tdCSCBCAwGEWxF(this XElement element, XName name, string @default)
	{
		//Discarded unreachable code: IL_0032
		if (!element.Elements(name).Any())
		{
			while (true)
			{
				uint num;
				switch ((num = 0x8E447D69u ^ 0xE7497751u) % 3u)
				{
				case 0u:
					continue;
				case 1u:
					return @default;
				}
				break;
			}
		}
		return element.Element(name).Value;
	}

	public static int _59ab9VkqetpIwwmGzw45eRNlLMg(this string input)
	{
		return Convert.ToInt32(input, 16);
	}

	public static int _sO4kfypgWPkSczoRzkVQIGw3fyF(this string input)
	{
		return int.Parse(input, CultureInfo.InvariantCulture);
	}

	public static float _y09e3EoPW54jYelUtQzj66l0jRF(this string input)
	{
		return float.Parse(input, CultureInfo.InvariantCulture);
	}
}
