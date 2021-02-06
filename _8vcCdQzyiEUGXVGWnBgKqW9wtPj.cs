using System;

internal class _8vcCdQzyiEUGXVGWnBgKqW9wtPj
{
	public int _fdhdgbDNnGsziNt15HHWiCEQcDD;

	public byte[] _0WMjfJphUj6JnIm1ZkD3ScpYc0F;

	public _8vcCdQzyiEUGXVGWnBgKqW9wtPj()
	{
		_0WMjfJphUj6JnIm1ZkD3ScpYc0F = new byte[4];
	}

	public void _fAg2Eh0mr3Wy8jCQDKVeuEDrx8F(int newSize)
	{
		//Discarded unreachable code: IL_003d
		if (newSize > 1048576)
		{
			goto IL_0008;
		}
		goto IL_0071;
		IL_0071:
		byte[] array = _0WMjfJphUj6JnIm1ZkD3ScpYc0F;
		_0WMjfJphUj6JnIm1ZkD3ScpYc0F = new byte[newSize];
		_0WMjfJphUj6JnIm1ZkD3ScpYc0F[0] = array[0];
		int num = -1864873228;
		goto IL_000d;
		IL_000d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0xADE5EF90u) % 5u)
			{
			case 3u:
				break;
			case 1u:
				throw new ArgumentException("New buffer size is too large");
			case 2u:
				_0WMjfJphUj6JnIm1ZkD3ScpYc0F[1] = array[1];
				_0WMjfJphUj6JnIm1ZkD3ScpYc0F[2] = array[2];
				num = (int)(num2 * 812958834) ^ -381413422;
				continue;
			case 0u:
				goto IL_0071;
			default:
				_0WMjfJphUj6JnIm1ZkD3ScpYc0F[3] = array[3];
				return;
			}
			break;
		}
		goto IL_0008;
		IL_0008:
		num = -590478727;
		goto IL_000d;
	}

	public void _ztBNihDAzvcXHBqDzFiIELG5x64(int numBytes)
	{
		_fdhdgbDNnGsziNt15HHWiCEQcDD += numBytes;
	}

	public void _bNSgTzhOj4L5qA7BwtW8kYZek7f()
	{
		_0WMjfJphUj6JnIm1ZkD3ScpYc0F = new byte[4];
		_fdhdgbDNnGsziNt15HHWiCEQcDD = 0;
	}

	public int _2JmVdDBcqtY2wRGdELyp9Bcuv9AA()
	{
		return _0WMjfJphUj6JnIm1ZkD3ScpYc0F.Length - _fdhdgbDNnGsziNt15HHWiCEQcDD;
	}

	public void _8H2QqjADGkx30Hq77Uf9ZGuRzFD()
	{
		_0WMjfJphUj6JnIm1ZkD3ScpYc0F = null;
	}
}
