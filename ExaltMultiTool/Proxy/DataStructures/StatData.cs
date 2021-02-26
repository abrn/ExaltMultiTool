using System;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class StatData : ICloneable {
	public StatType _StatType;

	public int _StatValue;

	public string _StringStatValue;

	public byte _MagicByte;

	public bool IsStringStat()
	{
		return _StatType.IsStringStat();
	}

	public StatData()
	{
	}

	public StatData(PacketReader r)
	{
		_StatType = StatType.CreateStatFromByte(r.ReadByte());

		if (!IsStringStat()) {
			_StatValue = CompressedInt.Read(r);
		}
		else {
			_StringStatValue = r.ReadString();
		}

		_MagicByte = r.ReadByte();
	}

	public void Write(PacketWriter w)
	{
		w.Write(StatType.GetStatByteType(_StatType));
		if (IsStringStat()) {
			w.Write(_StringStatValue);
		}
		else {
			CompressedInt.Write(w, _StatValue);
		}

		w.Write(_MagicByte);
	}

	public object Clone()
	{
		return new StatData
		{
			_StatType = _StatType,
			_StatValue = _StatValue,
			_StringStatValue = _StringStatValue,
			_MagicByte = _MagicByte
		};
	}

	public override string ToString()
	{
		return
			$"({Enum.GetName(typeof(StatDataEnum), StatType.GetStatByteType(_StatType))} = {(IsStringStat() ? _StringStatValue : _StatValue.ToString())} (Extra: {_MagicByte}))";
	}
}