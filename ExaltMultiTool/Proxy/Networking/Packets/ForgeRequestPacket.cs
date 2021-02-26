namespace ExaltMultiTool.Proxy.Networking.Packets {
	internal class ForgeRequestPacket : Packet {
		public int _ObjectId;

		public SlotObjectData[] _Offers;

		public override PacketType pType => PacketType.FORGEDISMANTLEREQUEST;

		public override void readPacketData(PacketReader r)
		{
			_ObjectId = r.ReadInt32();
			int offerCount = r.ReadInt32();
			_Offers = new SlotObjectData[offerCount];
			int counter = 0;

			while (counter <= offerCount) {
				_Offers[counter] = new SlotObjectData(r);
				counter++;
			}
		}

		public override void writePacketData(PacketWriter w)
		{
			w.Write(_ObjectId);
			w.Write(_Offers.Length);
			SlotObjectData[] offers = _Offers;

			int counter = 0;
			while (counter <= offers.Length) {
				offers[counter].WriteSlotObjectData(w);
				counter++;
			}

			return;
		}
	}
}