using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

internal class _VHWgt8pn9AXryODuVtLv9GmmHeH<_0001, _0002> where _0002 : class, IDataStructure<_0001>
{
	[CompilerGenerated]
	private sealed class _3mrdENzEjZ2oydMXMsbMJhQDXUZA
	{
		public string _r3fk3kS68X0yhIs2zUOR9wPYMag;

		internal bool _hPZ3Qk5vdL1qjb6o5PpX0gnKNed(KeyValuePair<_0001, _0002> e)
		{
			return e.Value._WL2DOBxBuX9DARzf2KPoaJbgZiCb == _r3fk3kS68X0yhIs2zUOR9wPYMag;
		}
	}

	[CompilerGenerated]
	private sealed class _iGt01X7FqhTi6BF0vECljpsD8aE
	{
		public Func<_0002, bool> _7x8cM0i7N32DAphZXxi9plfe0Ol;

		internal bool _1xT0ef36KSZb5FAZEaooCnJQ9j2(KeyValuePair<_0001, _0002> e)
		{
			return _7x8cM0i7N32DAphZXxi9plfe0Ol(e.Value);
		}
	}

	[CompilerGenerated]
	private Dictionary<_0001, _0002> _uFztNd2Pq8KG5caXAHZCirlDEtA;

	public Dictionary<_0001, _0002> _oQlNWqxOoe5LqobGdGJlgo4YIsh
	{
		get;
		private set;
	}

	private _VHWgt8pn9AXryODuVtLv9GmmHeH()
	{
	}

	public _VHWgt8pn9AXryODuVtLv9GmmHeH(Dictionary<_0001, _0002> map)
	{
		while (true)
		{
			int num = 1625518127;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x65B27978u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 2u:
					goto IL_0028;
				case 1u:
					return;
				}
				break;
				IL_0028:
				_oQlNWqxOoe5LqobGdGJlgo4YIsh = map;
				num = ((int)num2 * -35741701) ^ -1000981878;
			}
		}
	}

	public _0002 ById(_0001 id)
	{
		//Discarded unreachable code: IL_0038
		if (_oQlNWqxOoe5LqobGdGJlgo4YIsh.TryGetValue(id, out var value))
		{
			goto IL_0010;
		}
		goto IL_0047;
		IL_0047:
		_0002 result = null;
		int num = 1408130199;
		goto IL_0015;
		IL_0015:
		uint num2;
		switch ((num2 = (uint)num ^ 0x2A9E375Eu) % 4u)
		{
		case 0u:
			break;
		case 3u:
			return value;
		case 2u:
			goto IL_0047;
		default:
			return result;
		}
		goto IL_0010;
		IL_0010:
		num = 889380033;
		goto IL_0015;
	}

	public _0002 ByName(string name)
	{
		//Discarded unreachable code: IL_008c
		_0002 result = default(_0002);
		KeyValuePair<_0001, _0002> keyValuePair = default(KeyValuePair<_0001, _0002>);
		IEnumerable<KeyValuePair<_0001, _0002>> source = default(IEnumerable<KeyValuePair<_0001, _0002>>);
		string _r3fk3kS68X0yhIs2zUOR9wPYMag;
		while (true)
		{
			int num = -1355731708;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD86F34E3u) % 7u)
				{
				case 0u:
					break;
				case 6u:
					result = null;
					num = -2112624851;
					continue;
				case 5u:
					keyValuePair = source.First();
					num = ((int)num2 * -1769130042) ^ 0x7033FFE0;
					continue;
				case 3u:
				{
					int num3;
					int num4;
					if (source.Any())
					{
						num3 = 828803428;
						num4 = num3;
					}
					else
					{
						num3 = 1660399791;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -882774647);
					continue;
				}
				case 4u:
					return keyValuePair.Value;
				case 1u:
					_r3fk3kS68X0yhIs2zUOR9wPYMag = name;
					source = _oQlNWqxOoe5LqobGdGJlgo4YIsh.Where((KeyValuePair<_0001, _0002> e) => e.Value._WL2DOBxBuX9DARzf2KPoaJbgZiCb == _r3fk3kS68X0yhIs2zUOR9wPYMag);
					num = (int)((num2 * 1932747763) ^ 0x5453EBD1);
					continue;
				default:
					return result;
				}
				break;
			}
		}
	}

	public _0002 _dO9kxkfC4iCbBWLJvERy1ZxOTwaA(Func<_0002, bool> f)
	{
		return _oQlNWqxOoe5LqobGdGJlgo4YIsh.First((KeyValuePair<_0001, _0002> e) => f(e.Value)).Value;
	}
}
