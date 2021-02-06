using System;

internal class SlotObjectData : ICloneable
{
	public int _ObjectId;

	public int _SlotId;

	public int _ObjectType;

	public SlotObjectData()
	{
	}

	public SlotObjectData(int objectId, int slotId, int objectType)
	{
		_ObjectId = objectId;
		_SlotId = slotId;
		_ObjectType = objectType;
	}

	public SlotObjectData(PacketReader r)
	{
		_ObjectId = r.ReadInt32();
		_SlotId = r.ReadInt32();
		_ObjectType = r.ReadInt32();
	}

	public void WriteSlotObjectData(PacketWriter w)
	{
		w.Write(_ObjectId);
		w.Write(_SlotId);
		w.Write(_ObjectType);
	}

	public object Clone()
	{
		return new SlotObjectData
		{
			_ObjectId = _ObjectId,
			_ObjectType = _ObjectType,
			_SlotId = _SlotId
		};
	}

	public override string ToString()
	{
		return $"{{ ObjectId={_ObjectId}, SlotId={_SlotId}, ObjectType={_ObjectType} }}";
	}
}
