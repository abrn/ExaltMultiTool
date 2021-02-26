using ExaltMultiTool.Proxy.Networking.Packets;

internal class HelloPacket : Packet {
	public string _BuildVersion;

	public int _GameId;

	public string _Guid;

	public int _Random1;

	public string _Password;

	public int _Random2;

	public string _Secret;

	public int _KeyTime;

	public byte[] _Key;

	public string _MapJSON;

	public string _EntryTag;

	public string _GameNet;

	public string _GameNetUserId;

	public string _PlayPlatform;

	public string _PlatformToken;

	public string _UserToken;

	public string _Trailer;

	public string _PreviousConnectionGuid;

	public override PacketType pType => PacketType.HELLO;

	public override void readPacketData(PacketReader r)
	{
		_BuildVersion = r.ReadString();
		_GameId = r.ReadInt32();
		_Guid = r.ReadString();
		_Random1 = r.ReadInt32();
		_Password = r.ReadString();
		_Random2 = r.ReadInt32();
		_Secret = r.ReadString();
		_KeyTime = r.ReadInt32();
		_Key = r.ReadBytes(r.ReadInt16());
		_MapJSON = r.ReadUTF8String();
		_EntryTag = r.ReadString();
		_GameNet = r.ReadString();
		_GameNetUserId = r.ReadString();
		_PlayPlatform = r.ReadString();
		_PlatformToken = r.ReadString();
		_UserToken = r.ReadString();
		_Trailer = r.ReadString();
		_PreviousConnectionGuid = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_BuildVersion);
		w.Write(_GameId);
		w.Write(_Guid);
		w.Write(_Random1);
		w.Write(_Password);
		w.Write(_Random2);
		w.Write(_Secret);
		w.Write(_KeyTime);
		w.Write((short) _Key.Length);
		w.Write(_Key);
		w.WriteString(_MapJSON);
		w.Write(_EntryTag);
		w.Write(_GameNet);
		w.Write(_GameNetUserId);
		w.Write(_PlayPlatform);
		w.Write(_PlatformToken);
		w.Write(_UserToken);
		w.Write(_Trailer);
		w.Write(_PreviousConnectionGuid);
	}
}