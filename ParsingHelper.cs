using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

internal static class ParsingHelper
{
	public static IEnumerable<T> _rvkyhEufCiuaZq8jbaYgthJoLEx<T>(this IEnumerable<T> input, Action<T> action)
	{
		var rvkyhEufCiuaZq8JbaYgthJoLEx = input.ToList();
		IEnumerator<T> enumerator = rvkyhEufCiuaZq8JbaYgthJoLEx.GetEnumerator();
		try
		{
			T current = default(T);
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
						return rvkyhEufCiuaZq8JbaYgthJoLEx;
					case 4u:
						return rvkyhEufCiuaZq8JbaYgthJoLEx;
					}
					break;
				}
			}
		}
		finally
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
			end_IL_0072:;
		}
	}

	public static bool ContainsElement(this XElement element, XName name)
	{
		return element.Elements(name).Any();
	}

	public static string GetElementAttrib(this XElement element, XName name, string @default)
	{
		return element.Attributes(name).Any() ? element.Attribute(name)?.Value : @default;
	}

	public static string GetChildValue(this XElement element, XName name, string @default)
	{
		return element.Elements(name).Any() ? element.Element(name)?.Value : @default;
	}

	public static int ToInt32(this string input)
	{
		return Convert.ToInt32(input, 16);
	}

	public static int ParseInt(this string input)
	{
		return int.Parse(input, CultureInfo.InvariantCulture);
	}

	public static float ParseFloat(this string input)
	{
		return float.Parse(input, CultureInfo.InvariantCulture);
	}
}
