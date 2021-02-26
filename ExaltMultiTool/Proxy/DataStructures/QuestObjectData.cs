using System;
using System.Linq;
using System.Runtime.CompilerServices;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class QuestObjectData : ICloneable, IDataObject {
	public string _Id;

	public string _Name;

	public string _Description;

	public string _Expiration;

	public int[] _Requirements;

	public int[] _Rewards;

	public bool _Completed;

	public bool _ItemOfChoice;

	public bool _Repeatable;

	public int _Category;

	public int _Unknown;

	public QuestObjectData()
	{
	}

	public QuestObjectData(PacketReader r)
	{
		_Id = r.ReadString();
		_Name = r.ReadString();
		_Description = r.ReadString();
		_Expiration = r.ReadString();
		_Unknown = r.ReadInt32();
		_Category = r.ReadInt32();
		_Requirements = new int[r.ReadInt16()];
		for (int i = 0; i < _Requirements.Length; i++) {
			_Requirements[i] = r.ReadInt32();
		}

		_Rewards = new int[r.ReadInt16()];
		for (int j = 0; j < _Rewards.Length; j++) {
			_Rewards[j] = r.ReadInt32();
		}

		_Completed = r.ReadBoolean();
		_ItemOfChoice = r.ReadBoolean();
		_Repeatable = r.ReadBoolean();
	}

	private IDataObject Read(PacketReader r)
	{
		_Id = r.ReadString();
		_Name = r.ReadString();
		_Description = r.ReadString();
		_Expiration = r.ReadString();
		_Unknown = r.ReadInt32();
		_Category = r.ReadInt32();
		_Requirements = new int[r.ReadInt16()];
		for (int i = 0; i < _Requirements.Length; i++) {
			_Requirements[i] = r.ReadInt32();
		}

		_Rewards = new int[r.ReadInt16()];
		for (int j = 0; j < _Rewards.Length; j++) {
			_Rewards[j] = r.ReadInt32();
		}

		_Completed = r.ReadBoolean();
		_ItemOfChoice = r.ReadBoolean();
		_Repeatable = r.ReadBoolean();
		return this;
	}

	IDataObject IDataObject.Read(PacketReader r)
	{
		return Read(r);
	}

	public void Write(PacketWriter w)
	{
		w.Write(_Id);
		w.Write(_Name);
		w.Write(_Description);
		w.Write(_Expiration);
		w.Write(_Category);
		w.Write(_Unknown);
		w.Write((short) _Requirements.Length);
		foreach (var t in _Requirements) {
			w.Write(t);
		}

		w.Write((short) _Rewards.Length);
		foreach (var t in _Rewards) {
			w.Write(t);
		}

		w.Write(_Completed);
		w.Write(_ItemOfChoice);
		w.Write(_Repeatable);
	}

	void IDataObject.Write(PacketWriter w)
	{
		Write(w);
	}

	private object Clone()
	{
		return new QuestObjectData
		{
			_Id = _Id,
			_Name = _Name,
			_Description = _Description,
			_Requirements = _Requirements,
			_Rewards = _Rewards,
			_Completed = _Completed,
			_ItemOfChoice = _ItemOfChoice,
			_Category = _Category,
			_Repeatable = _Repeatable
		};
	}

	object ICloneable.Clone()
	{
		return Clone();
	}

	public override string ToString()
	{
		return
			$"{{ Id={_Id}, Name={_Name}, Description={_Description}, Requirements={_Requirements.Select((int x) => x + " ")}, Rewards={_Rewards.Select((int x) => x + " ")}, Completed={_Completed}, ItemOfChoice={_ItemOfChoice}, Category={_Category}, Repeatable={_Repeatable} }}";
	}
}