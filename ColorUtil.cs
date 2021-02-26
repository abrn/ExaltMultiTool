using System.Drawing;
using System.IO;
using ExaltMultiTool.Proxy.Networking.Packets;

internal struct ColorUtil
{
	public byte _Alpha;

	public byte _Blue;

	public byte _Green;

	public byte _Red;

	public ColorUtil(uint argb)
	{
		_Alpha = (byte)((argb & 0xFF000000u) >> 24);
		_Red = (byte)((argb & 0xFF0000) >> 16);
		_Green = (byte)((argb & 0xFF00) >> 8);
		_Blue = (byte)(argb & 0xFFu);
	}

	public ColorUtil(byte a, byte r, byte g, byte b)
	{
		_Alpha = a;
		_Red = r;
		_Green = g;
		_Blue = b;
	}

	public static ColorUtil Read(PacketReader r)
	{
		ColorUtil result = default(ColorUtil);
		result._Alpha = r.ReadByte();
		result._Red = r.ReadByte();
		result._Green = r.ReadByte();
		result._Blue = r.ReadByte();
		return result;
	}

	public void Read(PacketWriter w)
	{
		w.Write(_Alpha);
		w.Write(_Red);
		w.Write(_Blue);
		w.Write(_Green);
	}

	public void Write(BinaryWriter w)
	{
		w.Write(_Alpha);
		w.Write(_Red);
		w.Write(_Blue);
		w.Write(_Green);
	}

	public override string ToString()
	{
		return Color.FromArgb(_Alpha, _Red, _Green, _Blue).Name;
	}
}
