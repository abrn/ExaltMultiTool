using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class LocalProxy
{
	private TcpListener _Listener;

	public ConcurrentDictionary<string, ReconnectPacket> _JlhuftEwIx9QqEcmrh5juOLuNhE;

	public event _KcBslMXpDkB2TvFqzjAsEACA1kK _ZdQQinTBhMRIy64E6jFDeZ4fNKA
	{
		[CompilerGenerated]
		add
		{
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK = this._ZdQQinTBhMRIy64E6jFDeZ4fNKA;
			while (true)
			{
				int num = -1268577320;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xC5E67F26u) % 3u)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
					{
						_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK2 = kcBslMXpDkB2TvFqzjAsEACA1kK;
						_KcBslMXpDkB2TvFqzjAsEACA1kK value2 = (_KcBslMXpDkB2TvFqzjAsEACA1kK)Delegate.Combine(kcBslMXpDkB2TvFqzjAsEACA1kK2, value);
						kcBslMXpDkB2TvFqzjAsEACA1kK = Interlocked.CompareExchange(ref this._ZdQQinTBhMRIy64E6jFDeZ4fNKA, value2, kcBslMXpDkB2TvFqzjAsEACA1kK2);
						int num3;
						if ((object)kcBslMXpDkB2TvFqzjAsEACA1kK != kcBslMXpDkB2TvFqzjAsEACA1kK2)
						{
							num = -1268577320;
							num3 = num;
						}
						else
						{
							num = -445218743;
							num3 = num;
						}
						continue;
					}
					case 2u:
						return;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK = this._ZdQQinTBhMRIy64E6jFDeZ4fNKA;
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK2 = default(_KcBslMXpDkB2TvFqzjAsEACA1kK);
			_KcBslMXpDkB2TvFqzjAsEACA1kK value2 = default(_KcBslMXpDkB2TvFqzjAsEACA1kK);
			while (true)
			{
				int num = 1568740585;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x74C8A49u) % 6u)
					{
					case 0u:
						break;
					default:
						return;
					case 4u:
						kcBslMXpDkB2TvFqzjAsEACA1kK2 = kcBslMXpDkB2TvFqzjAsEACA1kK;
						num = 1021324996;
						continue;
					case 1u:
					{
						int num3;
						int num4;
						if ((object)kcBslMXpDkB2TvFqzjAsEACA1kK == kcBslMXpDkB2TvFqzjAsEACA1kK2)
						{
							num3 = -205491604;
							num4 = num3;
						}
						else
						{
							num3 = -173569421;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 494860082);
						continue;
					}
					case 5u:
						value2 = (_KcBslMXpDkB2TvFqzjAsEACA1kK)Delegate.Remove(kcBslMXpDkB2TvFqzjAsEACA1kK2, value);
						num = (int)((num2 * 2019779129) ^ 0x436A2FF0);
						continue;
					case 2u:
						kcBslMXpDkB2TvFqzjAsEACA1kK = Interlocked.CompareExchange(ref this._ZdQQinTBhMRIy64E6jFDeZ4fNKA, value2, kcBslMXpDkB2TvFqzjAsEACA1kK2);
						num = ((int)num2 * -812245709) ^ 0x51015448;
						continue;
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	public event _KcBslMXpDkB2TvFqzjAsEACA1kK _4eIapRPtQrSln4ftqlIqI1L6dwK
	{
		[CompilerGenerated]
		add
		{
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK = this._4eIapRPtQrSln4ftqlIqI1L6dwK;
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK2 = default(_KcBslMXpDkB2TvFqzjAsEACA1kK);
			while (true)
			{
				int num = -736986552;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xA89E27B6u) % 5u)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
					{
						int num3;
						int num4;
						if ((object)kcBslMXpDkB2TvFqzjAsEACA1kK != kcBslMXpDkB2TvFqzjAsEACA1kK2)
						{
							num3 = 1242071648;
							num4 = num3;
						}
						else
						{
							num3 = 319825914;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -709904100);
						continue;
					}
					case 4u:
					{
						_KcBslMXpDkB2TvFqzjAsEACA1kK value2 = (_KcBslMXpDkB2TvFqzjAsEACA1kK)Delegate.Combine(kcBslMXpDkB2TvFqzjAsEACA1kK2, value);
						kcBslMXpDkB2TvFqzjAsEACA1kK = Interlocked.CompareExchange(ref this._4eIapRPtQrSln4ftqlIqI1L6dwK, value2, kcBslMXpDkB2TvFqzjAsEACA1kK2);
						num = (int)((num2 * 844070448) ^ 0x278D2E0);
						continue;
					}
					case 1u:
						kcBslMXpDkB2TvFqzjAsEACA1kK2 = kcBslMXpDkB2TvFqzjAsEACA1kK;
						num = -887117533;
						continue;
					case 3u:
						return;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK = this._4eIapRPtQrSln4ftqlIqI1L6dwK;
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK2 = default(_KcBslMXpDkB2TvFqzjAsEACA1kK);
			_KcBslMXpDkB2TvFqzjAsEACA1kK value2 = default(_KcBslMXpDkB2TvFqzjAsEACA1kK);
			while (true)
			{
				int num = -1709494166;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x85BEA4DDu) % 5u)
					{
					case 0u:
						break;
					default:
						return;
					case 2u:
						kcBslMXpDkB2TvFqzjAsEACA1kK2 = kcBslMXpDkB2TvFqzjAsEACA1kK;
						num = -1821104484;
						continue;
					case 3u:
					{
						kcBslMXpDkB2TvFqzjAsEACA1kK = Interlocked.CompareExchange(ref this._4eIapRPtQrSln4ftqlIqI1L6dwK, value2, kcBslMXpDkB2TvFqzjAsEACA1kK2);
						int num3;
						int num4;
						if ((object)kcBslMXpDkB2TvFqzjAsEACA1kK != kcBslMXpDkB2TvFqzjAsEACA1kK2)
						{
							num3 = 1642696857;
							num4 = num3;
						}
						else
						{
							num3 = 1917916897;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -210904731);
						continue;
					}
					case 4u:
						value2 = (_KcBslMXpDkB2TvFqzjAsEACA1kK)Delegate.Remove(kcBslMXpDkB2TvFqzjAsEACA1kK2, value);
						num = ((int)num2 * -674577217) ^ -1054031403;
						continue;
					case 1u:
						return;
					}
					break;
				}
			}
		}
	}

	public event _KcBslMXpDkB2TvFqzjAsEACA1kK _dGfef8mxCbgdggCGNPQHdP7NYuB
	{
		[CompilerGenerated]
		add
		{
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK = this._dGfef8mxCbgdggCGNPQHdP7NYuB;
			_KcBslMXpDkB2TvFqzjAsEACA1kK value2 = default(_KcBslMXpDkB2TvFqzjAsEACA1kK);
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK2 = default(_KcBslMXpDkB2TvFqzjAsEACA1kK);
			while (true)
			{
				int num = 1443009236;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x7A277C0Du) % 5u)
					{
					case 2u:
						break;
					default:
						return;
					case 3u:
					{
						kcBslMXpDkB2TvFqzjAsEACA1kK = Interlocked.CompareExchange(ref this._dGfef8mxCbgdggCGNPQHdP7NYuB, value2, kcBslMXpDkB2TvFqzjAsEACA1kK2);
						int num3;
						int num4;
						if ((object)kcBslMXpDkB2TvFqzjAsEACA1kK == kcBslMXpDkB2TvFqzjAsEACA1kK2)
						{
							num3 = -977540678;
							num4 = num3;
						}
						else
						{
							num3 = -1408252435;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -832876223);
						continue;
					}
					case 4u:
						value2 = (_KcBslMXpDkB2TvFqzjAsEACA1kK)Delegate.Combine(kcBslMXpDkB2TvFqzjAsEACA1kK2, value);
						num = (int)(num2 * 590414816) ^ -1222294668;
						continue;
					case 1u:
						kcBslMXpDkB2TvFqzjAsEACA1kK2 = kcBslMXpDkB2TvFqzjAsEACA1kK;
						num = 2035496433;
						continue;
					case 0u:
						return;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK = this._dGfef8mxCbgdggCGNPQHdP7NYuB;
			_KcBslMXpDkB2TvFqzjAsEACA1kK kcBslMXpDkB2TvFqzjAsEACA1kK2 = default(_KcBslMXpDkB2TvFqzjAsEACA1kK);
			while (true)
			{
				int num = -93763372;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xE0B0EE78u) % 5u)
					{
					case 4u:
						break;
					default:
						return;
					case 1u:
						kcBslMXpDkB2TvFqzjAsEACA1kK2 = kcBslMXpDkB2TvFqzjAsEACA1kK;
						num = -476159642;
						continue;
					case 2u:
					{
						_KcBslMXpDkB2TvFqzjAsEACA1kK value2 = (_KcBslMXpDkB2TvFqzjAsEACA1kK)Delegate.Remove(kcBslMXpDkB2TvFqzjAsEACA1kK2, value);
						kcBslMXpDkB2TvFqzjAsEACA1kK = Interlocked.CompareExchange(ref this._dGfef8mxCbgdggCGNPQHdP7NYuB, value2, kcBslMXpDkB2TvFqzjAsEACA1kK2);
						num = ((int)num2 * -60950536) ^ 0x53EE716B;
						continue;
					}
					case 0u:
					{
						int num3;
						int num4;
						if ((object)kcBslMXpDkB2TvFqzjAsEACA1kK == kcBslMXpDkB2TvFqzjAsEACA1kK2)
						{
							num3 = 1274348684;
							num4 = num3;
						}
						else
						{
							num3 = 785948529;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -203770569);
						continue;
					}
					case 3u:
						return;
					}
					break;
				}
			}
		}
	}

	public event _aRa8l3GoOtWAxr3fiZXNh135ASk _2CvKeg0KKFqznJb6G6ih951C31B
	{
		[CompilerGenerated]
		add
		{
			_aRa8l3GoOtWAxr3fiZXNh135ASk aRa8l3GoOtWAxr3fiZXNh135ASk = this._2CvKeg0KKFqznJb6G6ih951C31B;
			_aRa8l3GoOtWAxr3fiZXNh135ASk aRa8l3GoOtWAxr3fiZXNh135ASk2 = default(_aRa8l3GoOtWAxr3fiZXNh135ASk);
			_aRa8l3GoOtWAxr3fiZXNh135ASk value2 = default(_aRa8l3GoOtWAxr3fiZXNh135ASk);
			while (true)
			{
				int num = -942861076;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0xD261EB5Eu) % 6u)
					{
					case 5u:
						break;
					default:
						return;
					case 2u:
						aRa8l3GoOtWAxr3fiZXNh135ASk2 = aRa8l3GoOtWAxr3fiZXNh135ASk;
						num = -368951037;
						continue;
					case 1u:
						value2 = (_aRa8l3GoOtWAxr3fiZXNh135ASk)Delegate.Combine(aRa8l3GoOtWAxr3fiZXNh135ASk2, value);
						num = (int)(num2 * 514812928) ^ -998022468;
						continue;
					case 4u:
						aRa8l3GoOtWAxr3fiZXNh135ASk = Interlocked.CompareExchange(ref this._2CvKeg0KKFqznJb6G6ih951C31B, value2, aRa8l3GoOtWAxr3fiZXNh135ASk2);
						num = ((int)num2 * -368927534) ^ -166972414;
						continue;
					case 0u:
					{
						int num3;
						int num4;
						if ((object)aRa8l3GoOtWAxr3fiZXNh135ASk != aRa8l3GoOtWAxr3fiZXNh135ASk2)
						{
							num3 = -1539486292;
							num4 = num3;
						}
						else
						{
							num3 = -1864477459;
							num4 = num3;
						}
						num = num3 ^ ((int)num2 * -776651368);
						continue;
					}
					case 3u:
						return;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			_aRa8l3GoOtWAxr3fiZXNh135ASk aRa8l3GoOtWAxr3fiZXNh135ASk = this._2CvKeg0KKFqznJb6G6ih951C31B;
			while (true)
			{
				int num = 1278935289;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x19D8B946u) % 3u)
					{
					case 0u:
						break;
					default:
						return;
					case 1u:
					{
						_aRa8l3GoOtWAxr3fiZXNh135ASk aRa8l3GoOtWAxr3fiZXNh135ASk2 = aRa8l3GoOtWAxr3fiZXNh135ASk;
						_aRa8l3GoOtWAxr3fiZXNh135ASk value2 = (_aRa8l3GoOtWAxr3fiZXNh135ASk)Delegate.Remove(aRa8l3GoOtWAxr3fiZXNh135ASk2, value);
						aRa8l3GoOtWAxr3fiZXNh135ASk = Interlocked.CompareExchange(ref this._2CvKeg0KKFqznJb6G6ih951C31B, value2, aRa8l3GoOtWAxr3fiZXNh135ASk2);
						int num3;
						if ((object)aRa8l3GoOtWAxr3fiZXNh135ASk != aRa8l3GoOtWAxr3fiZXNh135ASk2)
						{
							num = 1278935289;
							num3 = num;
						}
						else
						{
							num = 2106890515;
							num3 = num;
						}
						continue;
					}
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}

	public void Start()
	{
		Program.LogInfoMessage("listener", "Starting local listener....");
		_JlhuftEwIx9QqEcmrh5juOLuNhE = new ConcurrentDictionary<string, ReconnectPacket>();
		
		_Listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 2050);
		_Listener.Server.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, optionValue: true);
		
		_Listener.Start();
		_Listener.BeginAcceptTcpClient(_8Dhu8OpskIzADqDh1q7XgEt1n3g, null);
		
		Program.LogNetworkInfo("listener", "Started local listener.");

		return;
	}

	private void _8Dhu8OpskIzADqDh1q7XgEt1n3g(IAsyncResult ar)
	{
		try
		{
			TcpClient client = _Listener.EndAcceptTcpClient(ar);
			while (true)
			{
				int num = -1144780258;
				while (true)
				{
					uint num2;
					Client client2;
					_KcBslMXpDkB2TvFqzjAsEACA1kK zdQQinTBhMRIy64E6jFDeZ4fNKA;
					switch ((num2 = (uint)num ^ 0xC45FC69Du) % 3u)
					{
					case 0u:
						break;
					default:
						goto end_IL_0000;
					case 2u:
						client2 = new Client(this, client);
						Program.LogInfoMessage("listener", " Client recieved.");
						zdQQinTBhMRIy64E6jFDeZ4fNKA = this._ZdQQinTBhMRIy64E6jFDeZ4fNKA;
						if (zdQQinTBhMRIy64E6jFDeZ4fNKA != null)
						{
							goto IL_0053;
						}
						goto end_IL_0000;
					case 1u:
						goto end_IL_0000;
					}
					break;
					IL_0053:
					zdQQinTBhMRIy64E6jFDeZ4fNKA(client2);
					num = -1543772942;
				}
			}
			end_IL_0000:;
		}
		catch (Exception ex)
		{
			Program.LogNetworkError("listener", "Failed to accept client!\nReason:\n" + ex);
		}
		try
		{
			_Listener?.BeginAcceptTcpClient(_8Dhu8OpskIzADqDh1q7XgEt1n3g, null);
		}
		catch (Exception innerException)
		{
			throw new Exception("Failed to listen for clients!", innerException);
		}
	}

	public void _brocD93D6xr1tNwKL9dn3DKnZ58(Client client)
	{
		this._4eIapRPtQrSln4ftqlIqI1L6dwK?.Invoke(client);
	}

	public void _ggyYCUsqC4xC7xRoNrdJgcMMFWy(Client client)
	{
		this._dGfef8mxCbgdggCGNPQHdP7NYuB?.Invoke(client);
	}

	public void _VEPDVp0jqs3FA5VFgwULGcPV6RZ(int id)
	{
		this._2CvKeg0KKFqznJb6G6ih951C31B?.Invoke(id);
	}
}
