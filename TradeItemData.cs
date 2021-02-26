using System;

internal class TradeItemData : ICloneable, IDataObject
{
	public int _ItemId;

	public int _SlotType;

	public bool _Tradeable;

	public bool _Included;

	public TradeItemData()
	{
	}

	public TradeItemData(PacketReader r)
	{
		_ItemId = r.ReadInt32();
		_SlotType = r.ReadInt32();
		_Tradeable = r.ReadBoolean();
		_Included = r.ReadBoolean();
	}

	public IDataObject Read(PacketReader r)
	{
		_ItemId = r.ReadInt32();
		_SlotType = r.ReadInt32();
		_Tradeable = r.ReadBoolean();
		_Included = r.ReadBoolean();
		return this;
	}

	IDataObject IDataObject.Read(PacketReader r)
	{
		return this.Read(r);
	}

	public void Write(PacketWriter w)
	{
		w.Write(_ItemId);
		w.Write(_SlotType);
		w.Write(_Tradeable);
		w.Write(_Included);
	}

	void IDataObject.Write(PacketWriter w)
	{
		this.Write(w);
	}

	public object Clone()
	{
		return new TradeItemData
		{
			_ItemId = _ItemId,
			_SlotType = _SlotType,
			_Tradeable = _Tradeable,
			_Included = _Included
		};
	}

	object ICloneable.Clone()
	{
		return this.Clone();
	}

	public override string ToString()
	{
		return "{ ItemItem=" + _ItemId + ", SlotType=" + _SlotType + ", Tradable=" + _Tradeable + ", Included=" + _Included + " }";
	}
}
