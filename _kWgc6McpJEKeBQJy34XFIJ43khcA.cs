using System;

internal class _kWgc6McpJEKeBQJy34XFIJ43khcA : ICloneable, _o4HuntyroiA06gchVr3BoA3ebes
{
	public ushort _y2nCjecGeYsmqDEzaplcuBvYtN7;

	public _AunOm2zlKr0KANkRBzogPcg538K _gVz37u8P9es5e8QAguAJW13BAYh = new _AunOm2zlKr0KANkRBzogPcg538K();

	public _o4HuntyroiA06gchVr3BoA3ebes _kCo2RCMYpYNoTPdfGQVnKgPh7Fc(PacketReader r)
	{
		_y2nCjecGeYsmqDEzaplcuBvYtN7 = r.ReadUInt16();
		_gVz37u8P9es5e8QAguAJW13BAYh._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r);
		return this;
	}

	_o4HuntyroiA06gchVr3BoA3ebes _o4HuntyroiA06gchVr3BoA3ebes.readTileData(PacketReader r)
	{
		//ILSpy generated this explicit interface implementation from .override directive in readPacketData
		return this._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r);
	}

	public void _3Wc8kZJjhbRt6nttAKwD2698imm(PacketWriter w)
	{
		w.Write(_y2nCjecGeYsmqDEzaplcuBvYtN7);
		_gVz37u8P9es5e8QAguAJW13BAYh._3Wc8kZJjhbRt6nttAKwD2698imm(w);
	}

	void _o4HuntyroiA06gchVr3BoA3ebes.writeTileData(PacketWriter w)
	{
		//ILSpy generated this explicit interface implementation from .override directive in writePacketData
		this._3Wc8kZJjhbRt6nttAKwD2698imm(w);
	}

	public object Clone()
	{
		return new _kWgc6McpJEKeBQJy34XFIJ43khcA
		{
			_y2nCjecGeYsmqDEzaplcuBvYtN7 = _y2nCjecGeYsmqDEzaplcuBvYtN7,
			_gVz37u8P9es5e8QAguAJW13BAYh = (_AunOm2zlKr0KANkRBzogPcg538K)_gVz37u8P9es5e8QAguAJW13BAYh.Clone()
		};
	}

	object ICloneable.Clone()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clone
		return this.Clone();
	}
}
