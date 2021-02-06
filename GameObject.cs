using System;

internal class GameObject : ICloneable, IDataObject
{
	public ushort _ObjectType;

	public Status _gVz37u8P9es5e8QAguAJW13BAYh = new Status();

	public IDataObject Read(PacketReader r)
	{
		_ObjectType = r.ReadUInt16();
		_gVz37u8P9es5e8QAguAJW13BAYh._kCo2RCMYpYNoTPdfGQVnKgPh7Fc(r);
		return this;
	}

	IDataObject IDataObject.Read(PacketReader r)
	{
		//ILSpy generated this explicit interface implementation from .override directive in readPacketData
		return this.Read(r);
	}

	public void Write(PacketWriter w)
	{
		w.Write(_ObjectType);
		_gVz37u8P9es5e8QAguAJW13BAYh._3Wc8kZJjhbRt6nttAKwD2698imm(w);
	}

	void IDataObject.Write(PacketWriter w)
	{
		//ILSpy generated this explicit interface implementation from .override directive in writePacketData
		this.Write(w);
	}

	public object Clone()
	{
		return new GameObject
		{
			_ObjectType = _ObjectType,
			_gVz37u8P9es5e8QAguAJW13BAYh = (Status)_gVz37u8P9es5e8QAguAJW13BAYh.Clone()
		};
	}

	object ICloneable.Clone()
	{
		//ILSpy generated this explicit interface implementation from .override directive in Clone
		return this.Clone();
	}
}
