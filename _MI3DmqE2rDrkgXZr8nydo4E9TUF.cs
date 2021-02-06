using ExaltMultiTool.Proxy.Networking.Packets;

internal class _MI3DmqE2rDrkgXZr8nydo4E9TUF : Packet
{
	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public int _fn2CRnBpjyTWHR9K8SU4iOwhDtK;

	public int _O0glnQ0AXJDBFp472Nmh0tyva0Y;

	public byte _DCs8IfrY8xS4SdKXu6WaowAtixe;

	public string _Q6HRtFjBgAzGe3VdpxgzUe9DcHp;

	public string _N9zjozggCA9FymbKtC3I9dZkIib;

	public string _UnipZyIx4rTweGDsmuta2VmGNQo;

	public bool _IJHhZrhYx4brCPyUS9uuF6VzviG;

	public int _vxsCJzmdRYrmPmbsGMbGDXxmbJY;

	public override PacketType pType => PacketType.TEXT;

	public override void readPacketData(PacketReader r)
	{
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
		while (true)
		{
			int num = 364811841;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x67912990u) % 7u)
				{
				case 0u:
					break;
				default:
					return;
				case 4u:
					_Q6HRtFjBgAzGe3VdpxgzUe9DcHp = r.ReadString();
					_N9zjozggCA9FymbKtC3I9dZkIib = r.ReadString();
					num = (int)((num2 * 1546735298) ^ 0x1FF173);
					continue;
				case 2u:
					_vxsCJzmdRYrmPmbsGMbGDXxmbJY = r.ReadInt32();
					num = (int)((num2 * 101038557) ^ 0x318F4947);
					continue;
				case 1u:
					_UnipZyIx4rTweGDsmuta2VmGNQo = r.ReadString();
					_IJHhZrhYx4brCPyUS9uuF6VzviG = r.ReadBoolean();
					num = ((int)num2 * -2097026475) ^ -493552127;
					continue;
				case 5u:
					_fn2CRnBpjyTWHR9K8SU4iOwhDtK = r.ReadInt32();
					_O0glnQ0AXJDBFp472Nmh0tyva0Y = r.ReadInt32();
					num = ((int)num2 * -736259367) ^ -1606620075;
					continue;
				case 6u:
					_DCs8IfrY8xS4SdKXu6WaowAtixe = r.ReadByte();
					num = ((int)num2 * -1933059090) ^ -102478244;
					continue;
				case 3u:
					return;
				}
				break;
			}
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
		w.Write(_fn2CRnBpjyTWHR9K8SU4iOwhDtK);
		w.Write(_O0glnQ0AXJDBFp472Nmh0tyva0Y);
		while (true)
		{
			int num = -817637188;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC376B8B3u) % 6u)
				{
				case 3u:
					break;
				default:
					return;
				case 0u:
					w.Write(_vxsCJzmdRYrmPmbsGMbGDXxmbJY);
					num = (int)(num2 * 1770425168) ^ -1711777732;
					continue;
				case 4u:
					w.Write(_N9zjozggCA9FymbKtC3I9dZkIib);
					w.Write(_UnipZyIx4rTweGDsmuta2VmGNQo);
					w.Write(_IJHhZrhYx4brCPyUS9uuF6VzviG);
					num = ((int)num2 * -1064221428) ^ 0x321D4105;
					continue;
				case 2u:
					w.Write(_Q6HRtFjBgAzGe3VdpxgzUe9DcHp);
					num = ((int)num2 * -2018308361) ^ 0x73315D23;
					continue;
				case 5u:
					w.Write(_DCs8IfrY8xS4SdKXu6WaowAtixe);
					num = (int)(num2 * 836863151) ^ -1369516394;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public static _MI3DmqE2rDrkgXZr8nydo4E9TUF _jf4J7SveOGCE7tqXXRlsHws4AXg(string sender, string message)
	{
		_MI3DmqE2rDrkgXZr8nydo4E9TUF obj = (_MI3DmqE2rDrkgXZr8nydo4E9TUF)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.TEXT);
		obj._DCs8IfrY8xS4SdKXu6WaowAtixe = 0;
		obj._UnipZyIx4rTweGDsmuta2VmGNQo = message;
		obj._WL2DOBxBuX9DARzf2KPoaJbgZiCb = (sender.StartsWith("#") ? sender : ("#" + sender));
		obj._O0glnQ0AXJDBFp472Nmh0tyva0Y = -1;
		obj._fn2CRnBpjyTWHR9K8SU4iOwhDtK = -1;
		obj._Q6HRtFjBgAzGe3VdpxgzUe9DcHp = "";
		obj._N9zjozggCA9FymbKtC3I9dZkIib = (string.IsNullOrEmpty(sender) ? message : ("<" + sender + "> " + message));
		return obj;
	}

	public static _MI3DmqE2rDrkgXZr8nydo4E9TUF _AXNXHsenc7q4bGIXtJncJXAdxxW(string message)
	{
		_MI3DmqE2rDrkgXZr8nydo4E9TUF obj = (_MI3DmqE2rDrkgXZr8nydo4E9TUF)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.TEXT);
		obj._DCs8IfrY8xS4SdKXu6WaowAtixe = 0;
		obj._UnipZyIx4rTweGDsmuta2VmGNQo = message;
		obj._WL2DOBxBuX9DARzf2KPoaJbgZiCb = string.Empty;
		obj._O0glnQ0AXJDBFp472Nmh0tyva0Y = -1;
		obj._fn2CRnBpjyTWHR9K8SU4iOwhDtK = -1;
		obj._Q6HRtFjBgAzGe3VdpxgzUe9DcHp = string.Empty;
		obj._N9zjozggCA9FymbKtC3I9dZkIib = message;
		return obj;
	}

	public static _MI3DmqE2rDrkgXZr8nydo4E9TUF _cuj5TuKzQrJc4m81deq6Jyw3r0H(string name, string message)
	{
		_MI3DmqE2rDrkgXZr8nydo4E9TUF obj = (_MI3DmqE2rDrkgXZr8nydo4E9TUF)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.TEXT);
		obj._DCs8IfrY8xS4SdKXu6WaowAtixe = 0;
		obj._UnipZyIx4rTweGDsmuta2VmGNQo = message;
		obj._WL2DOBxBuX9DARzf2KPoaJbgZiCb = name;
		obj._O0glnQ0AXJDBFp472Nmh0tyva0Y = -1;
		obj._fn2CRnBpjyTWHR9K8SU4iOwhDtK = -1;
		obj._Q6HRtFjBgAzGe3VdpxgzUe9DcHp = string.Empty;
		obj._N9zjozggCA9FymbKtC3I9dZkIib = message;
		return obj;
	}
}
