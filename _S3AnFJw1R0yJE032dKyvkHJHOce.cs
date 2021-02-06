using ExaltMultiTool.Proxy.Networking.Packets;

internal class _S3AnFJw1R0yJE032dKyvkHJHOce : Packet
{
	public byte[] _2DY6E9dpul70tPtcfSsfVBiSEBR;

	public string _WL2DOBxBuX9DARzf2KPoaJbgZiCb;

	public string _MnmGYCb8dvGB8oUd7qbruz9VBWQ;

	public string _qY4RhGK8KlGmc68Uu1fU0TMTZCF;

	public override PacketType pType => PacketType.KEYINFORESPONSE;

	public override void readPacketData(PacketReader r)
	{
		_WL2DOBxBuX9DARzf2KPoaJbgZiCb = r.ReadString();
		_MnmGYCb8dvGB8oUd7qbruz9VBWQ = r.ReadString();
		_qY4RhGK8KlGmc68Uu1fU0TMTZCF = r.ReadString();
	}

	public override void writePacketData(PacketWriter w)
	{
		w.Write(_WL2DOBxBuX9DARzf2KPoaJbgZiCb);
		w.Write(_MnmGYCb8dvGB8oUd7qbruz9VBWQ);
		while (true)
		{
			int num = 1395649948;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x764BEA4Fu) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					goto IL_003a;
				case 2u:
					return;
				}
				break;
				IL_003a:
				w.Write(_qY4RhGK8KlGmc68Uu1fU0TMTZCF);
				num = (int)((num2 * 2100944074) ^ 0x4E89B4BA);
			}
		}
	}
}
