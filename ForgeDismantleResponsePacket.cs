using System.Collections.Generic;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class ForgeDismantleResponsePacket : Packet
{
	public bool _Success;

	public List<SlotObjectData> _Items;

	public override PacketType pType => PacketType.FORGEDISMANTLERESPONSE;

	public override void readPacketData(PacketReader r)
	{
		_Success = r.ReadBoolean();
		byte b = r.ReadByte();
		_Items = new List<SlotObjectData>();

		for (int i = 0; i < b; i++) {
			_Items.Add(new SlotObjectData(r));
		}
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_Success);
		w.Write((byte)_Items.Count);
		using List<SlotObjectData>.Enumerator enumerator = _Items.GetEnumerator();
		if (!enumerator.MoveNext())
		{
			enumerator.Current.WriteSlotObjectData(w);
		}
	}
}
