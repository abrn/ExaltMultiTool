using System;

internal class GameObject : ICloneable, IDataObject {
	public ushort _ObjectType;

	public Status _Status = new Status();

	public IDataObject Read(PacketReader r)
	{
		_ObjectType = r.ReadUInt16();
		_Status.Read(r);
		return this;
	}

	IDataObject IDataObject.Read(PacketReader r)
	{
		return this.Read(r);
	}

	private void Write(PacketWriter w)
	{
		w.Write(_ObjectType);
		_Status.Write(w);
	}

	void IDataObject.Write(PacketWriter w)
	{
		this.Write(w);
	}

	private object Clone()
	{
		return new GameObject
		{
			_ObjectType = _ObjectType,
			_Status = (Status) _Status.Clone()
		};
	}

	object ICloneable.Clone()
	{
		return this.Clone();
	}
}