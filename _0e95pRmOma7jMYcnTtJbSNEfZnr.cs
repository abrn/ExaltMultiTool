using System;

internal class _0e95pRmOma7jMYcnTtJbSNEfZnr : ICloneable, IDataObject
{
	public int _rIRcn4TDcyMlLqN1Jvr04oaxPOE;

	public int _8vNcgGDuWbW1NeAU33KZ6cm2n7i;

	public bool _BZ8xdLd7SaHwxyF1KBqksYHAcKg;

	public bool _JOcDEIHRWYNHRVpTSleTAd3NAPP;

	public _0e95pRmOma7jMYcnTtJbSNEfZnr()
	{
	}

	public _0e95pRmOma7jMYcnTtJbSNEfZnr(PacketReader r)
	{
		while (true)
		{
			int num = -982462812;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xD11C2461u) % 4u)
				{
				case 0u:
					break;
				case 1u:
					_rIRcn4TDcyMlLqN1Jvr04oaxPOE = r.ReadInt32();
					num = (int)(num2 * 1069450430) ^ -1451637532;
					continue;
				case 3u:
					_8vNcgGDuWbW1NeAU33KZ6cm2n7i = r.ReadInt32();
					num = ((int)num2 * -1851968742) ^ 0x301265BD;
					continue;
				default:
					_BZ8xdLd7SaHwxyF1KBqksYHAcKg = r.ReadBoolean();
					_JOcDEIHRWYNHRVpTSleTAd3NAPP = r.ReadBoolean();
					return;
				}
				break;
			}
		}
	}

	public IDataObject _kCo2RCMYpYNoTPdfGQVnKgPh7Fc(PacketReader r)
	{
		_rIRcn4TDcyMlLqN1Jvr04oaxPOE = r.ReadInt32();
		_8vNcgGDuWbW1NeAU33KZ6cm2n7i = r.ReadInt32();
		_BZ8xdLd7SaHwxyF1KBqksYHAcKg = r.ReadBoolean();
		while (true)
		{
			int num = -1072548370;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xBDA3D637u) % 3u)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0046;
				default:
					return this;
				}
				break;
				IL_0046:
				_JOcDEIHRWYNHRVpTSleTAd3NAPP = r.ReadBoolean();
				num = (int)((num2 * 1048453248) ^ 0x1C5C7D92);
			}
		}
	}

	IDataObject IDataObject.Read(PacketReader r)
	{
		//ILSpy generated this explicit interface implementation from .override directive in readPacketData
		return this._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r);
	}

	public void _3Wc8kZJjhbRt6nttAKwD2698imm(PacketWriter w)
	{
		w.Write(_rIRcn4TDcyMlLqN1Jvr04oaxPOE);
		while (true)
		{
			int num = 224970002;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x40C8A053u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_002e;
				case 2u:
					return;
				}
				break;
				IL_002e:
				w.Write(_8vNcgGDuWbW1NeAU33KZ6cm2n7i);
				w.Write(_BZ8xdLd7SaHwxyF1KBqksYHAcKg);
				w.Write(_JOcDEIHRWYNHRVpTSleTAd3NAPP);
				num = (int)((num2 * 1886025436) ^ 0x1090A717);
			}
		}
	}

	void IDataObject.Write(PacketWriter w)
	{
		//ILSpy generated this explicit interface implementation from .override directive in writePacketData
		this._3Wc8kZJjhbRt6nttAKwD2698imm(w);
	}

	public object Clone()
	{
		return new _0e95pRmOma7jMYcnTtJbSNEfZnr
		{
			_rIRcn4TDcyMlLqN1Jvr04oaxPOE = _rIRcn4TDcyMlLqN1Jvr04oaxPOE,
			_8vNcgGDuWbW1NeAU33KZ6cm2n7i = _8vNcgGDuWbW1NeAU33KZ6cm2n7i,
			_BZ8xdLd7SaHwxyF1KBqksYHAcKg = _BZ8xdLd7SaHwxyF1KBqksYHAcKg,
			_JOcDEIHRWYNHRVpTSleTAd3NAPP = _JOcDEIHRWYNHRVpTSleTAd3NAPP
		};
	}

	object ICloneable.Clone()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clone
		return this.Clone();
	}

	public override string _SflzbyPcrkdh9uZXinsV7KrbBMw()
	{
		return "{ ItemItem=" + _rIRcn4TDcyMlLqN1Jvr04oaxPOE + ", SlotType=" + _8vNcgGDuWbW1NeAU33KZ6cm2n7i + ", Tradable=" + _BZ8xdLd7SaHwxyF1KBqksYHAcKg + ", Included=" + _JOcDEIHRWYNHRVpTSleTAd3NAPP + " }";
	}
}
