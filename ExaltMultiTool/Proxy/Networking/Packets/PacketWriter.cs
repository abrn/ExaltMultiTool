using System;
using System.IO;
using System.Net;
using System.Text;

internal class PacketWriter : BinaryWriter
{
	public PacketWriter(MemoryStream input)
		: base(input)
	{
	}

	public override void _3Wc8kZJjhbRt6nttAKwD2698imm(short value)
	{
		base.Write(IPAddress.NetworkToHostOrder(value));
	}

	public override void _3Wc8kZJjhbRt6nttAKwD2698imm(ushort value)
	{
		base.Write((ushort)IPAddress.HostToNetworkOrder((short)value));
	}

	public override void _3Wc8kZJjhbRt6nttAKwD2698imm(int value)
	{
		base.Write(IPAddress.NetworkToHostOrder(value));
	}

	public override void _3Wc8kZJjhbRt6nttAKwD2698imm(float value)
	{
		byte[] bytes = BitConverter.GetBytes(value);
		while (true)
		{
			int num = -1195528764;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA1FAB846u) % 3u)
				{
				case 2u:
					break;
				case 1u:
					goto IL_0029;
				default:
					base.Write(bytes);
					return;
				}
				break;
				IL_0029:
				Array.Reverse(bytes);
				num = (int)((num2 * 693452861) ^ 0x526B744B);
			}
		}
	}

	public override void _3Wc8kZJjhbRt6nttAKwD2698imm(string value)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(value);
		Write((short)bytes.Length);
		base.Write(bytes);
	}

	public void _9UoQbcRa99e4xjcrtzdQLYTHK2N(string value)
	{
		Write(value.Length);
		Write(Encoding.UTF8.GetBytes(value));
	}

	public static void _XIRKdXnWUNtF0ipzDYlXXjcMYic(byte[] data, int int32)
	{
		byte[] bytes = BitConverter.GetBytes(IPAddress.NetworkToHostOrder(int32));
		data[0] = bytes[0];
		while (true)
		{
			int num = 2120138889;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x11278C8Cu) % 4u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					data[1] = bytes[1];
					num = ((int)num2 * -1243954259) ^ -350625298;
					continue;
				case 3u:
					data[2] = bytes[2];
					data[3] = bytes[3];
					num = ((int)num2 * -972352185) ^ -91484579;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}
}
