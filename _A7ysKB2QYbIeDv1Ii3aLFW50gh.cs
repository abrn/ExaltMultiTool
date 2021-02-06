using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using ExaltMultiTool;
using ExaltMultiTool.Proxy.DataStructures;
using ExaltMultiTool.Proxy.Networking.Packets;

internal class _A7ysKB2QYbIeDv1Ii3aLFW50gh
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _q5bAS2GGlyEXggyfH1UYW81UmnS
	{
		public _A7ysKB2QYbIeDv1Ii3aLFW50gh _7DEudk1H4zeA6HRBegB5UK6RcSYA;

		public bool _4Tblsoxfo8TVJiRYvAqCkKYEa4o;

		public int _JSzc4U6HcYYF1eHd7UjhDniLfLf;

		public float _TQs3I5HnEqElZoiO4Dsa88IEj3u;
	}

	private _PlferqYaObizDfc28C5jdKSLGq5 _50w8wVuv8bL5nhKaR2EHxjrTamB;

	private bool _oV73NEwk247WZa6wM3sxIJwPEei;

	private int _0hr61i6lYmaIftqbkMyFhV54sxC;

	private int _QVjGB66zFJuKS0AifvnmBrMmpUA;

	private bool _g2ed0KEBqIrhCPMnJz2fI3hXM2CA;

	private bool _F83qcJjBWlsOfjlt8CcrQ3L7Tko;

	private WorldPosData _REqTtrf1f1UI7k1CKnC1oikFdjd = WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R;

	private Thread _5YLCCls8uJRZvkiXNMgUQHqL4Xk;

	private readonly List<string> _R6F8IoYb9DitnbDrGVDuvkGs87c = new List<string>
	{
		"Nexus",
		"Vault",
		"Guild Hall",
		"Guild Hall 2",
		"Guild Hall 3",
		"Guild Hall 4",
		"Guild Hall 5",
		"Cloth Bazaar",
		"Nexus Explanation",
		"Vault Explanation",
		"Guild Explanation",
		"Daily Quest Room",
		"Daily Login Room",
		"Pet Yard",
		"Pet Yard 2",
		"Pet Yard 3",
		"Pet Yard 4",
		"Pet Yard 5"
	};

	public _A7ysKB2QYbIeDv1Ii3aLFW50gh(_PlferqYaObizDfc28C5jdKSLGq5 client)
	{
		while (true)
		{
			int num = 199829830;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x2A4FDFBAu) % 3u)
				{
				case 2u:
					break;
				default:
					return;
				case 1u:
					goto IL_0104;
				case 0u:
					return;
				}
				break;
				IL_0104:
				_50w8wVuv8bL5nhKaR2EHxjrTamB = client;
				num = (int)(num2 * 705422145) ^ -225396577;
			}
		}
	}

	public void _YZBUA9d1NRteoNEIGwJjUbTmHLC()
	{
	}

	private void _Dm3CvUqoxz7bN0VdcJ8tOugfZI8()
	{
		Thread.Sleep(5000);
		_dPrfWu73gpRoGZKabrRKV7ZZrCs dPrfWu73gpRoGZKabrRKV7ZZrCs = default(_dPrfWu73gpRoGZKabrRKV7ZZrCs);
		while (true)
		{
			int num = 1768634811;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xC77C7C5u) % 7u)
				{
				case 2u:
					break;
				default:
					return;
				case 3u:
				{
					int num4;
					if (_50w8wVuv8bL5nhKaR2EHxjrTamB._vqEVLR4cyc2SGuohfuGXIfgjXjA)
					{
						num = 1026126166;
						num4 = num;
					}
					else
					{
						num = 1900297396;
						num4 = num;
					}
					continue;
				}
				case 1u:
					_50w8wVuv8bL5nhKaR2EHxjrTamB._xRCQ3Y8enVTevEwMAZe8WUmANbE(dPrfWu73gpRoGZKabrRKV7ZZrCs);
					num = (int)(num2 * 486706613) ^ -2014501258;
					continue;
				case 6u:
				{
					int num3;
					if (!Settings.Default.EnableAutoAbility)
					{
						num = 306939241;
						num3 = num;
					}
					else
					{
						num = 1767413190;
						num3 = num;
					}
					continue;
				}
				case 4u:
					dPrfWu73gpRoGZKabrRKV7ZZrCs = (_dPrfWu73gpRoGZKabrRKV7ZZrCs)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.PING);
					dPrfWu73gpRoGZKabrRKV7ZZrCs._Z7iWeS1W3Ht6ch6jgJJ8aFPGFTj = -1;
					num = ((int)num2 * -1372790358) ^ 0x2A1F13EC;
					continue;
				case 5u:
					Thread.Sleep(100);
					num = 680177216;
					continue;
				case 0u:
					return;
				}
				break;
			}
		}
	}

	public void _DT5vfLbxw23gMixKpQ7yxEiQkEe(MapInfoPacket mapInfo)
	{
		_oV73NEwk247WZa6wM3sxIJwPEei = _R6F8IoYb9DitnbDrGVDuvkGs87c.Contains(mapInfo._MapName);
		while (true)
		{
			int num = -1114924188;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA6E37B7Du) % 3u)
				{
				case 0u:
					break;
				case 2u:
					goto IL_0039;
				default:
					_0hr61i6lYmaIftqbkMyFhV54sxC = 0;
					return;
				}
				break;
				IL_0039:
				_QVjGB66zFJuKS0AifvnmBrMmpUA = 0;
				num = ((int)num2 * -28199372) ^ 0x727C4742;
			}
		}
	}

	public void _AcQdxLqe2Qsfg5dAgI14UK7PVxab(_KGw7UmnaW2UG2pY4rWmZNZTrFCh playerShoot)
	{
		_REqTtrf1f1UI7k1CKnC1oikFdjd = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP._KxM3gmGBMkIUCunUOzDZpSVchT0(playerShoot._hjRbCZIgEE6lGZJqDLlpYixCdUT, 6.0);
	}

	public void _taxEBWytYWTbIPVQiT7CFc8K58q(_nV9aomeHIThwTmnJfuHyMX6d9RG useItem)
	{
		//Discarded unreachable code: IL_0090
		if (useItem._obJo3i4uC8yf7c2aS8NBvEttXTO._ObjectId == _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC)
		{
			while (true)
			{
				int num = 679903666;
				while (true)
				{
					uint num2;
					switch ((num2 = (uint)num ^ 0x3D7A43D5u) % 8u)
					{
					case 4u:
						break;
					case 0u:
						useItem._Send = false;
						num = ((int)num2 * -2002034293) ^ 0x45CAC24C;
						continue;
					case 3u:
					{
						int num5;
						int num6;
						if (Settings.Default.EnableAutoAbility)
						{
							num5 = 1043249658;
							num6 = num5;
						}
						else
						{
							num5 = 220089789;
							num6 = num5;
						}
						num = num5 ^ (int)(num2 * 573454087);
						continue;
					}
					case 6u:
						return;
					case 2u:
					{
						int num7;
						int num8;
						if (useItem._IBSqBdwNTiXSzhZbDhEFMC0Gc51 - _QVjGB66zFJuKS0AifvnmBrMmpUA >= 500)
						{
							num7 = -289627450;
							num8 = num7;
						}
						else
						{
							num7 = -760042413;
							num8 = num7;
						}
						num = num7 ^ ((int)num2 * -743259741);
						continue;
					}
					case 7u:
					{
						int num3;
						int num4;
						if (useItem._obJo3i4uC8yf7c2aS8NBvEttXTO._SlotId == 1)
						{
							num3 = 516065268;
							num4 = num3;
						}
						else
						{
							num3 = 189565642;
							num4 = num3;
						}
						num = num3 ^ (int)(num2 * 495468894);
						continue;
					}
					case 1u:
						_50w8wVuv8bL5nhKaR2EHxjrTamB.sendChatNotification("AutoAbility", "Ability is on cooldown!");
						num = ((int)num2 * -938611376) ^ 0x45E756B;
						continue;
					default:
						goto IL_0120;
					}
					break;
				}
			}
		}
		goto IL_0120;
		IL_0120:
		_QVjGB66zFJuKS0AifvnmBrMmpUA = useItem._IBSqBdwNTiXSzhZbDhEFMC0Gc51;
	}

	public void _kcBjTzBYfTPCpKNctSQjw45y1mb()
	{
		bool flag = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._NZkIxbUdmBjjOtUfYiWJzYBCOdP();
		while (true)
		{
			int num = -1068856169;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x84E7276Au) % 8u)
				{
				case 0u:
					break;
				case 7u:
					_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("Sending fake AOE");
					num = ((int)num2 * -271269706) ^ -639106846;
					continue;
				case 6u:
				{
					int num7;
					int num8;
					if (!_g2ed0KEBqIrhCPMnJz2fI3hXM2CA)
					{
						num7 = 1866832624;
						num8 = num7;
					}
					else
					{
						num7 = 275666691;
						num8 = num7;
					}
					num = num7 ^ ((int)num2 * -896307596);
					continue;
				}
				case 3u:
				{
					int num5;
					int num6;
					if (!Settings.Default.AutoAbilityAutoMP)
					{
						num5 = 375543954;
						num6 = num5;
					}
					else
					{
						num5 = 1650328702;
						num6 = num5;
					}
					num = num5 ^ ((int)num2 * -204926674);
					continue;
				}
				case 1u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 950680500;
						num10 = num9;
					}
					else
					{
						num9 = 140514074;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 1523251292);
					continue;
				}
				case 5u:
				{
					int num3;
					int num4;
					if (!Settings.Default.EnableAutoAbility)
					{
						num3 = -865948997;
						num4 = num3;
					}
					else
					{
						num3 = -1026342190;
						num4 = num3;
					}
					num = num3 ^ ((int)num2 * -2038554161);
					continue;
				}
				case 4u:
				{
					_g2ed0KEBqIrhCPMnJz2fI3hXM2CA = false;
					_F83qcJjBWlsOfjlt8CcrQ3L7Tko = true;
					_FJ4Ncdgp30LvdfcfBFMzemYCCeT obj = (_FJ4Ncdgp30LvdfcfBFMzemYCCeT)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.AOE);
					obj._JEsT6uIdK1eySUKAfntb2FPG6xS = 0;
					obj._C3mvDTxTLKOCwcaeO4BKeVV1ydo = 0;
					obj._kvTyEminxJMM6fREzgqsVjHaInC = _PUpefZ8WOU2tKcPbBOBoE74Yj5m.Dead;
					obj._hZZqGJ97TiaLFTbiTFhvTTSGkIb = WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R;
					obj._I9LOulXQ6dWoDQOn1L5GkchnJUC = 0f;
					obj._l0mdLwT0Lqvn0oV26TZ8wa7mjTf = false;
					obj._4ryHqycpd0BcdbojLHcVLB3vF4Z = 0f;
					obj._Rgo6h5q8HOGdwEcalhyNY8ouOAE = 1536;
					num = (int)(num2 * 1650920370) ^ -2075628211;
					continue;
				}
				default:
					_g2ed0KEBqIrhCPMnJz2fI3hXM2CA = flag;
					return;
				}
				break;
			}
		}
	}

	public void _f8Cv4bMnfjjwRWfQwllvwFZDPuI(_Gya6cTkZfLW7T3Mt937EMw3XUvC aoeAck)
	{
		//Discarded unreachable code: IL_00a0, IL_00c5
		if (!_F83qcJjBWlsOfjlt8CcrQ3L7Tko)
		{
			return;
		}
		int num4 = default(int);
		PotionInfo potionInfo = default(PotionInfo);
		int num3 = default(int);
		while (true)
		{
			int num = -290947965;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E5C9902u) % 16u)
				{
				case 8u:
					break;
				default:
					return;
				case 10u:
					num4++;
					num = -2732596;
					continue;
				case 12u:
				{
					potionInfo = _50w8wVuv8bL5nhKaR2EHxjrTamB._nhFLD7A5r9NSgescGUZ6OSUXLbm[num3];
					int num10;
					if (potionInfo.Type == 2595)
					{
						num = -1808640590;
						num10 = num;
					}
					else
					{
						num = -2071937433;
						num10 = num;
					}
					continue;
				}
				case 6u:
					return;
				case 2u:
					num = (int)(num2 * 146957699) ^ -1252347558;
					continue;
				case 13u:
					return;
				case 15u:
					_20ZlLRRKR3DBHjWNv9JH1t5WaLt(aoeAck._IBSqBdwNTiXSzhZbDhEFMC0Gc51, 2595, num4, aoeAck._ObXrbtVZcdprxclR2Ggz9jKwlp);
					num = ((int)num2 * -284973362) ^ 0x711BE466;
					continue;
				case 5u:
					num3++;
					num = -1791553819;
					continue;
				case 1u:
					_F83qcJjBWlsOfjlt8CcrQ3L7Tko = false;
					num3 = 0;
					num = ((int)num2 * -640869816) ^ 0x504BA8AD;
					continue;
				case 3u:
					num4 = 4;
					num = ((int)num2 * -1655684006) ^ -1572669154;
					continue;
				case 0u:
				{
					int num8;
					int num9;
					if (potionInfo.Quantity <= 0)
					{
						num8 = 880510951;
						num9 = num8;
					}
					else
					{
						num8 = 526800150;
						num9 = num8;
					}
					num = num8 ^ (int)(num2 * 868909000);
					continue;
				}
				case 11u:
				{
					int num7;
					if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[num4] == 2595)
					{
						num = -962120403;
						num7 = num;
					}
					else
					{
						num = -1724328056;
						num7 = num;
					}
					continue;
				}
				case 7u:
				{
					int num6;
					if (num3 >= _50w8wVuv8bL5nhKaR2EHxjrTamB._nhFLD7A5r9NSgescGUZ6OSUXLbm.Length)
					{
						num = -1526753199;
						num6 = num;
					}
					else
					{
						num = -1279039522;
						num6 = num;
					}
					continue;
				}
				case 14u:
				{
					int num5;
					if (num4 < _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory.Length)
					{
						num = -1877122567;
						num5 = num;
					}
					else
					{
						num = -1220066661;
						num5 = num;
					}
					continue;
				}
				case 4u:
					_20ZlLRRKR3DBHjWNv9JH1t5WaLt(aoeAck._IBSqBdwNTiXSzhZbDhEFMC0Gc51, 2595, 1000000 + num3, aoeAck._ObXrbtVZcdprxclR2Ggz9jKwlp);
					_50w8wVuv8bL5nhKaR2EHxjrTamB._xlRUy72uPQ98Hy5AvYCNwBvoQ4K(num3);
					num = (int)(num2 * 1864907521) ^ -1029886693;
					continue;
				case 9u:
					return;
				}
				break;
			}
		}
	}

	public void _w523XOeezIrQZ8eMr8WGCIMyQ8N(_ghXR5d4B0MeXoLdmxvlpWeEF3en pong)
	{
		//Discarded unreachable code: IL_02b7, IL_02cb, IL_030f, IL_03d0, IL_03e4, IL_0479, IL_04b9, IL_054c, IL_05a3, IL_061a, IL_062e, IL_0655, IL_07ac, IL_0823, IL_089f, IL_08d3, IL_095d, IL_0971, IL_0985, IL_09e0, IL_0a17, IL_0a3c, IL_0a6c, IL_0a80, IL_0aca, IL_0ade
		if (pong._Z7iWeS1W3Ht6ch6jgJJ8aFPGFTj == -1)
		{
			goto IL_000c;
		}
		goto IL_085c;
		IL_085c:
		int num;
		int num2;
		if (!_F83qcJjBWlsOfjlt8CcrQ3L7Tko)
		{
			num = 1763639038;
			num2 = num;
		}
		else
		{
			num = 781772099;
			num2 = num;
		}
		goto IL_0011;
		IL_0011:
		int num4 = default(int);
		_x0bFEWbxXdGdRfNpGQ1c34l1w5r x0bFEWbxXdGdRfNpGQ1c34l1w5r = default(_x0bFEWbxXdGdRfNpGQ1c34l1w5r);
		int num7 = default(int);
		int iBSqBdwNTiXSzhZbDhEFMC0Gc = default(int);
		ushort y2nCjecGeYsmqDEzaplcuBvYtN = default(ushort);
		PotionInfo potionInfo = default(PotionInfo);
		int num14 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x5F017014u) % 81u)
			{
			case 36u:
				break;
			default:
				return;
			case 70u:
				num4++;
				num = 137778655;
				continue;
			case 79u:
				goto IL_0179;
			case 73u:
			{
				int num8;
				int num9;
				if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._v6scruPI8GbKsVXu2rpqDMycX0Q * 100 / _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fBkfBLhhMp7FH6BVjSag96CvhnT > Settings.Default.AutoAbilityHealHpPercent)
				{
					num8 = 261586315;
					num9 = num8;
				}
				else
				{
					num8 = 707737423;
					num9 = num8;
				}
				num = num8 ^ (int)(num3 * 1914907727);
				continue;
			}
			case 0u:
				x0bFEWbxXdGdRfNpGQ1c34l1w5r = ResourceDownloader._3ndzvDGHhvqls1BD8vzizSQBDdI._EOUVvVncv0meCCDQkGXOyUOLU5F((ushort)num7);
				num = 721113957;
				continue;
			case 33u:
				goto IL_01fa;
			case 21u:
				goto IL_0220;
			case 49u:
				goto IL_0246;
			case 9u:
				goto IL_0262;
			case 46u:
				_1ewKC7M4NL9N81VglwFrDKTJTfK(x0bFEWbxXdGdRfNpGQ1c34l1w5r, iBSqBdwNTiXSzhZbDhEFMC0Gc, double.NaN, _xtAgQ5haM04bei6mwatHB09hm8E(x0bFEWbxXdGdRfNpGQ1c34l1w5r._QjKHGXZ7ohXwrDQImauPaSixsVg), _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP);
				return;
			case 34u:
				return;
			case 50u:
				switch (y2nCjecGeYsmqDEzaplcuBvYtN)
				{
				case 782:
					break;
				default:
					goto IL_02fb;
				case 785:
					goto IL_0428;
				case 784:
					goto IL_0aad;
				case 783:
					return;
				}
				goto IL_01fa;
			case 72u:
				return;
			case 64u:
				goto IL_0322;
			case 58u:
				goto IL_0345;
			case 7u:
				goto IL_0361;
			case 31u:
				_bgSVetCGPR3zNWnEkr4cuYlGGJg(x0bFEWbxXdGdRfNpGQ1c34l1w5r, iBSqBdwNTiXSzhZbDhEFMC0Gc, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP, 1);
				num = 934895401;
				continue;
			case 15u:
				num = ((int)num3 * -2090542387) ^ 0x50673E57;
				continue;
			case 28u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB._xlRUy72uPQ98Hy5AvYCNwBvoQ4K(num4);
				return;
			case 59u:
				return;
			case 61u:
				goto IL_03f7;
			case 4u:
				goto IL_0428;
			case 10u:
				_1ewKC7M4NL9N81VglwFrDKTJTfK(x0bFEWbxXdGdRfNpGQ1c34l1w5r, iBSqBdwNTiXSzhZbDhEFMC0Gc, double.NaN, 9.0, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP);
				return;
			case 18u:
				_bgSVetCGPR3zNWnEkr4cuYlGGJg(x0bFEWbxXdGdRfNpGQ1c34l1w5r, iBSqBdwNTiXSzhZbDhEFMC0Gc, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP, 1);
				num = ((int)num3 * -1896787685) ^ 0x6393C5F2;
				continue;
			case 54u:
				return;
			case 1u:
			{
				int num17;
				int num18;
				if (potionInfo.Quantity > 0)
				{
					num17 = 1003505775;
					num18 = num17;
				}
				else
				{
					num17 = 1584776011;
					num18 = num17;
				}
				num = num17 ^ ((int)num3 * -1392061177);
				continue;
			}
			case 26u:
				num14 = 4;
				num = ((int)num3 * -1398517248) ^ 0x15E8688B;
				continue;
			case 48u:
				goto IL_0509;
			case 39u:
				goto IL_0525;
			case 29u:
				return;
			case 5u:
			{
				int num15;
				int num16;
				if (x0bFEWbxXdGdRfNpGQ1c34l1w5r != null)
				{
					num15 = -295600776;
					num16 = num15;
				}
				else
				{
					num15 = -1771341126;
					num16 = num15;
				}
				num = num15 ^ (int)(num3 * 495726285);
				continue;
			}
			case 24u:
				_20ZlLRRKR3DBHjWNv9JH1t5WaLt(pong._IBSqBdwNTiXSzhZbDhEFMC0Gc51, 2595, num14, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP);
				return;
			case 13u:
				_F83qcJjBWlsOfjlt8CcrQ3L7Tko = false;
				num = (int)((num3 * 1705750302) ^ 0x4289666A);
				continue;
			case 47u:
				num14++;
				num = 258178820;
				continue;
			case 53u:
				num = ((int)num3 * -1955631711) ^ -1972593986;
				continue;
			case 23u:
				goto IL_05f3;
			case 80u:
				return;
			case 63u:
				return;
			case 65u:
				_PRhnVDn3ZtczdfIW02GMGzedebA(x0bFEWbxXdGdRfNpGQ1c34l1w5r, iBSqBdwNTiXSzhZbDhEFMC0Gc);
				num = 1575038679;
				continue;
			case 6u:
				return;
			case 20u:
				goto IL_0668;
			case 22u:
				_bgSVetCGPR3zNWnEkr4cuYlGGJg(x0bFEWbxXdGdRfNpGQ1c34l1w5r, iBSqBdwNTiXSzhZbDhEFMC0Gc, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP, 1);
				num = (int)((num3 * 1492989263) ^ 0x2B783B1A);
				continue;
			case 25u:
			{
				int num12;
				int num13;
				if (iBSqBdwNTiXSzhZbDhEFMC0Gc - _QVjGB66zFJuKS0AifvnmBrMmpUA < 500)
				{
					num12 = 1916162276;
					num13 = num12;
				}
				else
				{
					num12 = 1088551564;
					num13 = num12;
				}
				num = num12 ^ (int)(num3 * 794400073);
				continue;
			}
			case 56u:
				num7 = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[1];
				num = 514220764;
				continue;
			case 75u:
				goto IL_06fe;
			case 55u:
				num4 = 0;
				num = ((int)num3 * -1145880087) ^ -1696210439;
				continue;
			case 57u:
				goto IL_0741;
			case 35u:
				goto IL_0785;
			case 78u:
				return;
			case 43u:
				_1ewKC7M4NL9N81VglwFrDKTJTfK(x0bFEWbxXdGdRfNpGQ1c34l1w5r, iBSqBdwNTiXSzhZbDhEFMC0Gc, double.NaN, 12.0, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP);
				num = ((int)num3 * -1495283867) ^ -1591803500;
				continue;
			case 30u:
				goto IL_07fc;
			case 51u:
				return;
			case 60u:
				goto IL_0836;
			case 14u:
				goto IL_085c;
			case 38u:
				goto IL_0878;
			case 69u:
				return;
			case 2u:
				goto IL_08b2;
			case 74u:
				return;
			case 77u:
				goto IL_08e6;
			case 12u:
				switch (y2nCjecGeYsmqDEzaplcuBvYtN)
				{
				case 803:
					break;
				case 797:
				case 799:
					goto IL_0322;
				case 802:
					goto IL_0525;
				case 800:
					goto IL_05f3;
				case 801:
					goto IL_07fc;
				case 806:
					goto IL_0878;
				default:
					goto IL_0949;
				case 796:
					goto IL_09f3;
				case 805:
					goto IL_0b15;
				case 798:
				case 804:
					return;
				}
				goto IL_0220;
			case 68u:
				return;
			case 67u:
				return;
			case 32u:
				return;
			case 66u:
			{
				int num10;
				int num11;
				if (num7 == -1)
				{
					num10 = 1923842903;
					num11 = num10;
				}
				else
				{
					num10 = 72103502;
					num11 = num10;
				}
				num = num10 ^ (int)(num3 * 2008555262);
				continue;
			}
			case 62u:
			{
				int num5;
				int num6;
				if (y2nCjecGeYsmqDEzaplcuBvYtN != 768)
				{
					num5 = -709478113;
					num6 = num5;
				}
				else
				{
					num5 = -1399824141;
					num6 = num5;
				}
				num = num5 ^ ((int)num3 * -1312726546);
				continue;
			}
			case 44u:
				return;
			case 45u:
				goto IL_09f3;
			case 19u:
				return;
			case 40u:
				iBSqBdwNTiXSzhZbDhEFMC0Gc = pong._IBSqBdwNTiXSzhZbDhEFMC0Gc51;
				num = 1929473237;
				continue;
			case 17u:
				return;
			case 42u:
				y2nCjecGeYsmqDEzaplcuBvYtN = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._y2nCjecGeYsmqDEzaplcuBvYtN7;
				num = 1329759523;
				continue;
			case 3u:
				return;
			case 8u:
				return;
			case 71u:
				pong._Send = false;
				num = (int)(num3 * 497695543) ^ -437012586;
				continue;
			case 41u:
				goto IL_0aad;
			case 52u:
				return;
			case 27u:
				return;
			case 76u:
				goto IL_0af1;
			case 37u:
				goto IL_0b15;
			case 16u:
				_20ZlLRRKR3DBHjWNv9JH1t5WaLt(pong._IBSqBdwNTiXSzhZbDhEFMC0Gc51, 2595, 1000000 + num4, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP);
				num = (int)(num3 * 1264397979) ^ -687601629;
				continue;
			case 11u:
				return;
				IL_09f3:
				_bgSVetCGPR3zNWnEkr4cuYlGGJg(x0bFEWbxXdGdRfNpGQ1c34l1w5r, iBSqBdwNTiXSzhZbDhEFMC0Gc, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP, 1);
				num = 33984751;
				continue;
				IL_0949:
				num = (int)((num3 * 1725044678) ^ 0x2F7060F3);
				continue;
				IL_0322:
				_bgSVetCGPR3zNWnEkr4cuYlGGJg(x0bFEWbxXdGdRfNpGQ1c34l1w5r, iBSqBdwNTiXSzhZbDhEFMC0Gc, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP, 1);
				num = 141522170;
				continue;
				IL_02fb:
				num = ((int)num3 * -1716170865) ^ 0x6DD10FB0;
				continue;
			}
			break;
			IL_0af1:
			int num19;
			if (num4 < _50w8wVuv8bL5nhKaR2EHxjrTamB._nhFLD7A5r9NSgescGUZ6OSUXLbm.Length)
			{
				num = 62381122;
				num19 = num;
			}
			else
			{
				num = 1478186574;
				num19 = num;
			}
			continue;
			IL_0428:
			int num20;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._lgMifiCLrejnMztlnTpKHxYmG3E())
			{
				num = 433288628;
				num20 = num;
			}
			else
			{
				num = 33984751;
				num20 = num;
			}
			continue;
			IL_06fe:
			int num21;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[num14] == 2595)
			{
				num = 269183436;
				num21 = num;
			}
			else
			{
				num = 1967432393;
				num21 = num;
			}
			continue;
			IL_0b15:
			int num22;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._lgMifiCLrejnMztlnTpKHxYmG3E())
			{
				num = 1759627644;
				num22 = num;
			}
			else
			{
				num = 33984751;
				num22 = num;
			}
			continue;
			IL_0741:
			int num23;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._kL78aC3fQlfwdoczYeIaP61dqe3 * 100 / _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fF7gBqWhNS2rU2VVZ6MjwK2DhTU >= Settings.Default.AutoAbilityMinimumManaLeftThreshold)
			{
				num = 1299634104;
				num23 = num;
			}
			else
			{
				num = 1816950831;
				num23 = num;
			}
			continue;
			IL_03f7:
			potionInfo = _50w8wVuv8bL5nhKaR2EHxjrTamB._nhFLD7A5r9NSgescGUZ6OSUXLbm[num4];
			int num24;
			if (potionInfo.Type == 2595)
			{
				num = 1373500492;
				num24 = num;
			}
			else
			{
				num = 708908323;
				num24 = num;
			}
			continue;
			IL_08e6:
			int num25;
			if (num14 < _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory.Length)
			{
				num = 1098754622;
				num25 = num;
			}
			else
			{
				num = 1763639038;
				num25 = num;
			}
			continue;
			IL_0668:
			int num26;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC == null)
			{
				num = 1011869876;
				num26 = num;
			}
			else
			{
				num = 2076077817;
				num26 = num;
			}
			continue;
			IL_0179:
			int num27;
			if (iBSqBdwNTiXSzhZbDhEFMC0Gc < _0hr61i6lYmaIftqbkMyFhV54sxC)
			{
				num = 1630814292;
				num27 = num;
			}
			else
			{
				num = 502377736;
				num27 = num;
			}
			continue;
			IL_08b2:
			int num28;
			if (!Settings.Default.EnableAutoAbility)
			{
				num = 106286818;
				num28 = num;
			}
			else
			{
				num = 518494639;
				num28 = num;
			}
			continue;
			IL_0220:
			int num29;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._lgMifiCLrejnMztlnTpKHxYmG3E())
			{
				num = 33984751;
				num29 = num;
			}
			else
			{
				num = 738366170;
				num29 = num;
			}
			continue;
			IL_05f3:
			int num30;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._lgMifiCLrejnMztlnTpKHxYmG3E())
			{
				num = 101648945;
				num30 = num;
			}
			else
			{
				num = 1031185096;
				num30 = num;
			}
			continue;
			IL_0878:
			int num31;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._KG2rM9oPz7YTVnnGu1fHJm8zZQB())
			{
				num = 234813398;
				num31 = num;
			}
			else
			{
				num = 33984751;
				num31 = num;
			}
			continue;
			IL_0345:
			int num32;
			if (num7 != 2650)
			{
				num = 1100143294;
				num32 = num;
			}
			else
			{
				num = 33984751;
				num32 = num;
			}
			continue;
			IL_0246:
			int num33;
			if (!_oV73NEwk247WZa6wM3sxIJwPEei)
			{
				num = 1077444371;
				num33 = num;
			}
			else
			{
				num = 1450293809;
				num33 = num;
			}
			continue;
			IL_0836:
			int num34;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._QpgZcrpUzDvD724s39cRtNW05SF())
			{
				num = 1838029410;
				num34 = num;
			}
			else
			{
				num = 1184073724;
				num34 = num;
			}
			continue;
			IL_0525:
			int num35;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._lgMifiCLrejnMztlnTpKHxYmG3E())
			{
				num = 1031185096;
				num35 = num;
			}
			else
			{
				num = 33984751;
				num35 = num;
			}
			continue;
			IL_01fa:
			int num36;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._lgMifiCLrejnMztlnTpKHxYmG3E())
			{
				num = 931302649;
				num36 = num;
			}
			else
			{
				num = 33984751;
				num36 = num;
			}
			continue;
			IL_07fc:
			int num37;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._lgMifiCLrejnMztlnTpKHxYmG3E())
			{
				num = 1031185096;
				num37 = num;
			}
			else
			{
				num = 661564763;
				num37 = num;
			}
			continue;
			IL_0aad:
			int num38;
			if (num7 != 1976)
			{
				num = 337502024;
				num38 = num;
			}
			else
			{
				num = 666819115;
				num38 = num;
			}
			continue;
			IL_0509:
			int num39;
			if (x0bFEWbxXdGdRfNpGQ1c34l1w5r._Hgcuj8Yk2qRXttXX0EHvRYXq7I == 0)
			{
				num = 1592370997;
				num39 = num;
			}
			else
			{
				num = 550716620;
				num39 = num;
			}
			continue;
			IL_0785:
			int num40;
			if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._NZkIxbUdmBjjOtUfYiWJzYBCOdP())
			{
				num = 1164645145;
				num40 = num;
			}
			else
			{
				num = 2057783252;
				num40 = num;
			}
			continue;
			IL_0262:
			int num41;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._OmrvgK9zU9Rzw8cBaUJhDmZVvpQ())
			{
				num = 271534256;
				num41 = num;
			}
			else
			{
				num = 1215955060;
				num41 = num;
			}
			continue;
			IL_0361:
			int num42;
			if (x0bFEWbxXdGdRfNpGQ1c34l1w5r._YhNTfG1vuMJNUDMG7X4kP1ERPFD <= _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._kL78aC3fQlfwdoczYeIaP61dqe3)
			{
				num = 1772834625;
				num42 = num;
			}
			else
			{
				num = 605759776;
				num42 = num;
			}
		}
		goto IL_000c;
		IL_000c:
		num = 1004171730;
		goto IL_0011;
	}

	private float _xtAgQ5haM04bei6mwatHB09hm8E(ushort itemId)
	{
		if (itemId != 8994)
		{
			goto IL_0008;
		}
		goto IL_007b;
		IL_007b:
		float result = 4.6f;
		int num = 379512226;
		goto IL_000d;
		IL_000d:
		while (true)
		{
			uint num2;
			switch ((num2 = (uint)num ^ 0x4A0E8C63u) % 9u)
			{
			case 7u:
				break;
			case 2u:
				result = 6.4f;
				num = 592983156;
				continue;
			case 5u:
				result = 4.4f;
				num = 1339415936;
				continue;
			case 3u:
				num = (int)(num2 * 244673853) ^ -384793987;
				continue;
			case 8u:
				num = (int)(num2 * 2120689452) ^ -69076620;
				continue;
			case 0u:
				goto IL_007b;
			case 6u:
			{
				int num3;
				int num4;
				if (itemId != 9152)
				{
					num3 = -296674567;
					num4 = num3;
				}
				else
				{
					num3 = -104763219;
					num4 = num3;
				}
				num = num3 ^ ((int)num2 * -502986342);
				continue;
			}
			case 4u:
				num = (int)(num2 * 638271310) ^ -1207270413;
				continue;
			default:
				return result;
			}
			break;
		}
		goto IL_0008;
		IL_0008:
		num = 1052336987;
		goto IL_000d;
	}

	public void _1UIxXEL495RF9327ls9jIZFBwaA(_QVbPZZRiBkqcm6oZy5pZrM4S8aD invSwap)
	{
		//Discarded unreachable code: IL_0130
		if (invSwap._sEYqjeelWD912mJ6sF5MhQRyISf._ObjectId == _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC)
		{
			goto IL_001b;
		}
		goto IL_00af;
		IL_00af:
		int num;
		int num2;
		if (invSwap._YnPcTOJB6UrXk2tL1AzY4w0ohpAA._ObjectId != _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC)
		{
			num = -1448837816;
			num2 = num;
		}
		else
		{
			num = -764390699;
			num2 = num;
		}
		goto IL_0020;
		IL_0020:
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0xBCEE1556u) % 8u)
			{
			case 5u:
				break;
			default:
				return;
			case 7u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[1] = invSwap._sEYqjeelWD912mJ6sF5MhQRyISf._ObjectType;
				num = ((int)num3 * -1581448077) ^ 0x10ACAC2D;
				continue;
			case 2u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[1] = invSwap._YnPcTOJB6UrXk2tL1AzY4w0ohpAA._ObjectType;
				num = (int)((num3 * 1330916770) ^ 0x2FD0825A);
				continue;
			case 4u:
				goto IL_00af;
			case 3u:
			{
				int num6;
				int num7;
				if (invSwap._YnPcTOJB6UrXk2tL1AzY4w0ohpAA._SlotId != 1)
				{
					num6 = 2076402859;
					num7 = num6;
				}
				else
				{
					num6 = 231225458;
					num7 = num6;
				}
				num = num6 ^ ((int)num3 * -1055328735);
				continue;
			}
			case 1u:
			{
				int num4;
				int num5;
				if (invSwap._sEYqjeelWD912mJ6sF5MhQRyISf._SlotId == 1)
				{
					num4 = -564293412;
					num5 = num4;
				}
				else
				{
					num4 = -1258380064;
					num5 = num4;
				}
				num = num4 ^ (int)(num3 * 272430248);
				continue;
			}
			case 0u:
				return;
			case 6u:
				return;
			}
			break;
		}
		goto IL_001b;
		IL_001b:
		num = -1168517257;
		goto IL_0020;
	}

	private void _20ZlLRRKR3DBHjWNv9JH1t5WaLt(int time, int itemType, int slotId, WorldPosData location)
	{
		_nV9aomeHIThwTmnJfuHyMX6d9RG nV9aomeHIThwTmnJfuHyMX6d9RG = (_nV9aomeHIThwTmnJfuHyMX6d9RG)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.USEITEM);
		nV9aomeHIThwTmnJfuHyMX6d9RG._obJo3i4uC8yf7c2aS8NBvEttXTO = new SlotObjectData
		{
			_ObjectId = _50w8wVuv8bL5nhKaR2EHxjrTamB._UqAoky1lauc0gYPMEYUcYfMlJkC,
			_ObjectType = itemType,
			_SlotId = slotId
		};
		nV9aomeHIThwTmnJfuHyMX6d9RG._IBSqBdwNTiXSzhZbDhEFMC0Gc51 = time;
		nV9aomeHIThwTmnJfuHyMX6d9RG._hik7MnmCWLUNupBgHpKPyvAspMh = location;
		while (true)
		{
			int num = 875251240;
			while (true)
			{
				uint num2;
				int num3;
				switch ((num2 = (uint)num ^ 0xD4F9267u) % 3u)
				{
				case 0u:
					break;
				default:
					return;
				case 1u:
					num3 = ((slotId < 1000000) ? 1 : 0);
					goto IL_0075;
				case 2u:
					return;
				}
				break;
				IL_0075:
				nV9aomeHIThwTmnJfuHyMX6d9RG._if0d81H88w2JolCC4orFfcsIICeA = (byte)num3;
				_50w8wVuv8bL5nhKaR2EHxjrTamB._WEI99xvr4YqzD1PAnL2WmiBhWKJ(nV9aomeHIThwTmnJfuHyMX6d9RG);
				num = 1690754912;
			}
		}
	}

	private void _bgSVetCGPR3zNWnEkr4cuYlGGJg(_x0bFEWbxXdGdRfNpGQ1c34l1w5r item, int time, WorldPosData position = null, byte useType = 1)
	{
		if (position == null)
		{
			goto IL_0006;
		}
		goto IL_00ad;
		IL_00ad:
		int num = (int)item._un2pqQ1kxK1zeYQjxzNqrHVDGKD;
		int num2;
		if (num != 0)
		{
			num2 = -921610864;
			goto IL_000b;
		}
		int num3 = 500;
		goto IL_01b6;
		IL_01a8:
		num3 = num * 1000;
		goto IL_01b6;
		IL_0006:
		num2 = -153531675;
		goto IL_000b;
		IL_01b6:
		num = num3;
		num2 = -1111240528;
		goto IL_000b;
		IL_000b:
		_nV9aomeHIThwTmnJfuHyMX6d9RG nV9aomeHIThwTmnJfuHyMX6d9RG = default(_nV9aomeHIThwTmnJfuHyMX6d9RG);
		while (true)
		{
			uint num4;
			switch ((num4 = (uint)num2 ^ 0xECCF5C4Au) % 13u)
			{
			case 5u:
				break;
			default:
				return;
			case 10u:
				position = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP;
				num2 = ((int)num4 * -1849057531) ^ -1620100871;
				continue;
			case 0u:
				_QVjGB66zFJuKS0AifvnmBrMmpUA = time;
				num2 = (int)((num4 * 1632045695) ^ 0x21F0D9A9);
				continue;
			case 9u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB._TVcgSr7bcouFhNfw8PyT9bbBIM0("AutoAbility activated!");
				num2 = (int)(num4 * 1894828040) ^ -833331290;
				continue;
			case 8u:
				goto IL_00ad;
			case 6u:
				nV9aomeHIThwTmnJfuHyMX6d9RG._hik7MnmCWLUNupBgHpKPyvAspMh = position;
				_50w8wVuv8bL5nhKaR2EHxjrTamB._WEI99xvr4YqzD1PAnL2WmiBhWKJ(nV9aomeHIThwTmnJfuHyMX6d9RG);
				num2 = (int)(num4 * 1543429164) ^ -28080670;
				continue;
			case 4u:
				nV9aomeHIThwTmnJfuHyMX6d9RG._if0d81H88w2JolCC4orFfcsIICeA = useType;
				num2 = (int)(num4 * 103324718) ^ -360325201;
				continue;
			case 7u:
			{
				int num5;
				int num6;
				if (Settings.Default.AutoAbilityNotifications)
				{
					num5 = 1914644019;
					num6 = num5;
				}
				else
				{
					num5 = 1724437654;
					num6 = num5;
				}
				num2 = num5 ^ ((int)num4 * -1840812778);
				continue;
			}
			case 11u:
				nV9aomeHIThwTmnJfuHyMX6d9RG._IBSqBdwNTiXSzhZbDhEFMC0Gc51 = time;
				num2 = ((int)num4 * -1423276821) ^ 0x21856828;
				continue;
			case 3u:
				nV9aomeHIThwTmnJfuHyMX6d9RG = (_nV9aomeHIThwTmnJfuHyMX6d9RG)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.USEITEM);
				nV9aomeHIThwTmnJfuHyMX6d9RG._obJo3i4uC8yf7c2aS8NBvEttXTO = new SlotObjectData
				{
					_ObjectId = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fn2CRnBpjyTWHR9K8SU4iOwhDtK,
					_SlotId = 1,
					_ObjectType = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[1]
				};
				num2 = (int)((num4 * 695724290) ^ 0x60D8F24);
				continue;
			case 1u:
				goto IL_01a8;
			case 2u:
				_0hr61i6lYmaIftqbkMyFhV54sxC = time + num;
				num2 = (int)(num4 * 150120905) ^ -1123920861;
				continue;
			case 12u:
				return;
			}
			break;
		}
		goto IL_0006;
	}

	private void _PRhnVDn3ZtczdfIW02GMGzedebA(_x0bFEWbxXdGdRfNpGQ1c34l1w5r item, int time, bool requireHeal = false)
	{
		_q5bAS2GGlyEXggyfH1UYW81UmnS q5bAS2GGlyEXggyfH1UYW81UmnS = default(_q5bAS2GGlyEXggyfH1UYW81UmnS);
		q5bAS2GGlyEXggyfH1UYW81UmnS._7DEudk1H4zeA6HRBegB5UK6RcSYA = this;
		PlayerData jI4Bueou7dItYp5S7QML5vyC6Rc = default(PlayerData);
		int num12 = default(int);
		int autoAbilityMinimumGroupSizeThreshold = default(int);
		int num11 = default(int);
		PlayerData current = default(PlayerData);
		while (true)
		{
			int num = -1678755560;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xCF0E79F5u) % 4u)
				{
				case 0u:
					break;
				case 1u:
					q5bAS2GGlyEXggyfH1UYW81UmnS._4Tblsoxfo8TVJiRYvAqCkKYEa4o = requireHeal;
					q5bAS2GGlyEXggyfH1UYW81UmnS._TQs3I5HnEqElZoiO4Dsa88IEj3u = item._I9LOulXQ6dWoDQOn1L5GkchnJUC * item._I9LOulXQ6dWoDQOn1L5GkchnJUC;
					jI4Bueou7dItYp5S7QML5vyC6Rc = null;
					num = (int)(num2 * 1630015053) ^ -115886417;
					continue;
				case 3u:
					num12 = 0;
					q5bAS2GGlyEXggyfH1UYW81UmnS._JSzc4U6HcYYF1eHd7UjhDniLfLf = Settings.Default.AutoAbilityMinimumEnemyHealthThreshold;
					autoAbilityMinimumGroupSizeThreshold = Settings.Default.AutoAbilityMinimumGroupSizeThreshold;
					num = ((int)num2 * -1708332962) ^ -98947003;
					continue;
				default:
				{
					using (Dictionary<int, PlayerData>.ValueCollection.Enumerator enumerator = _50w8wVuv8bL5nhKaR2EHxjrTamB._Aq9hW2NyDqEkITmxzYm6OCQLaDB.Values.GetEnumerator())
					{
						while (true)
						{
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = -53244758;
								num4 = num3;
							}
							else
							{
								num3 = -1098699264;
								num4 = num3;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0xCF0E79F5u) % 15u)
								{
								case 5u:
									num3 = -1098699264;
									continue;
								default:
									goto end_IL_00a2;
								case 6u:
								{
									int num13;
									int num14;
									if (num11 > num12)
									{
										num13 = 784070265;
										num14 = num13;
									}
									else
									{
										num13 = 1771542121;
										num14 = num13;
									}
									num3 = num13 ^ ((int)num2 * -2002954568);
									continue;
								}
								case 4u:
									break;
								case 2u:
								{
									int num7;
									int num8;
									if (current._9zLynim4HlmFvQv3AqAl2vIblhc())
									{
										num7 = -376659974;
										num8 = num7;
									}
									else
									{
										num7 = -1675136218;
										num8 = num7;
									}
									num3 = num7 ^ ((int)num2 * -1556658271);
									continue;
								}
								case 13u:
								{
									int num15;
									if (!(_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP._l97JYrnBrV9Ws5bD3UnHa879cYh(current._FLMczMOk4gNIJMbSsAnIDIvYlDP) > 144.0))
									{
										num3 = -1056592192;
										num15 = num3;
									}
									else
									{
										num3 = -471660239;
										num15 = num3;
									}
									continue;
								}
								case 14u:
								{
									int num20;
									int num21;
									if (current._fBkfBLhhMp7FH6BVjSag96CvhnT > q5bAS2GGlyEXggyfH1UYW81UmnS._JSzc4U6HcYYF1eHd7UjhDniLfLf)
									{
										num20 = -1160381862;
										num21 = num20;
									}
									else
									{
										num20 = -1979434304;
										num21 = num20;
									}
									num3 = num20 ^ (int)(num2 * 96449575);
									continue;
								}
								case 0u:
								{
									int num16;
									int num17;
									if (current._DGVRAcMHLhkT7cE8sbBDj7EHf0j())
									{
										num16 = -1991593214;
										num17 = num16;
									}
									else
									{
										num16 = -1400781186;
										num17 = num16;
									}
									num3 = num16 ^ ((int)num2 * -1090700639);
									continue;
								}
								case 3u:
									jI4Bueou7dItYp5S7QML5vyC6Rc = current;
									num3 = ((int)num2 * -679410265) ^ 0x4D92A2B9;
									continue;
								case 10u:
								{
									int num18;
									int num19;
									if (num11 > autoAbilityMinimumGroupSizeThreshold)
									{
										num18 = 385728311;
										num19 = num18;
									}
									else
									{
										num18 = 563789566;
										num19 = num18;
									}
									num3 = num18 ^ ((int)num2 * -1693364709);
									continue;
								}
								case 7u:
									num12 = num11;
									num3 = ((int)num2 * -1984966787) ^ -990234575;
									continue;
								case 1u:
									current = enumerator.Current;
									num3 = -353931490;
									continue;
								case 8u:
									num11 = _XGY0dKXAFuLaWx4T7tQ9XLiiZ54(current, ref q5bAS2GGlyEXggyfH1UYW81UmnS);
									num3 = (int)((num2 * 1648128001) ^ 0x5FA7F69D);
									continue;
								case 11u:
								{
									int num9;
									int num10;
									if (q5bAS2GGlyEXggyfH1UYW81UmnS._4Tblsoxfo8TVJiRYvAqCkKYEa4o)
									{
										num9 = -677974856;
										num10 = num9;
									}
									else
									{
										num9 = -1129733637;
										num10 = num9;
									}
									num3 = num9 ^ (int)(num2 * 1451105606);
									continue;
								}
								case 9u:
								{
									int num5;
									int num6;
									if (!current._P8Pe7KoeoiWl4D1BHuWF4YTFunp())
									{
										num5 = 186773318;
										num6 = num5;
									}
									else
									{
										num5 = 1461725137;
										num6 = num5;
									}
									num3 = num5 ^ ((int)num2 * -1177325580);
									continue;
								}
								case 12u:
									goto end_IL_00a2;
								}
								break;
							}
						}
						end_IL_00a2:;
					}
					if (jI4Bueou7dItYp5S7QML5vyC6Rc == null)
					{
						return;
					}
					while (true)
					{
						int num22 = -585102403;
						while (true)
						{
							switch ((num2 = (uint)num22 ^ 0xCF0E79F5u) % 3u)
							{
							case 0u:
								break;
							default:
								return;
							case 1u:
								goto IL_02eb;
							case 2u:
								return;
							}
							break;
							IL_02eb:
							_bgSVetCGPR3zNWnEkr4cuYlGGJg(item, time, jI4Bueou7dItYp5S7QML5vyC6Rc._IlcbhoOIM3MRszn9mfn3IKjnXc0, 1);
							num22 = ((int)num2 * -1440386528) ^ -1232339449;
						}
					}
				}
				}
				break;
			}
		}
	}

	private void _tExbGVr38Q9WmU2JSuGsUJ2EITe(int Time)
	{
		//Discarded unreachable code: IL_00e1, IL_0135, IL_0274, IL_0319, IL_032d, IL_03f2, IL_0423
		if (_oV73NEwk247WZa6wM3sxIJwPEei)
		{
			goto IL_000b;
		}
		goto IL_0340;
		IL_0340:
		int num;
		int num2;
		if (_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC != null)
		{
			num = 1786572071;
			num2 = num;
		}
		else
		{
			num = 1492116373;
			num2 = num;
		}
		goto IL_0010;
		IL_0010:
		_mb69C48hRlTLSdF1p30JoqLeKBj mb69C48hRlTLSdF1p30JoqLeKBj = default(_mb69C48hRlTLSdF1p30JoqLeKBj);
		_KGw7UmnaW2UG2pY4rWmZNZTrFCh kGw7UmnaW2UG2pY4rWmZNZTrFCh = default(_KGw7UmnaW2UG2pY4rWmZNZTrFCh);
		int num4 = default(int);
		int iBSqBdwNTiXSzhZbDhEFMC0Gc = default(int);
		_x0bFEWbxXdGdRfNpGQ1c34l1w5r x0bFEWbxXdGdRfNpGQ1c34l1w5r = default(_x0bFEWbxXdGdRfNpGQ1c34l1w5r);
		int num9 = default(int);
		while (true)
		{
			uint num3;
			switch ((num3 = (uint)num ^ 0x260FDBEEu) % 30u)
			{
			case 29u:
				break;
			default:
				return;
			case 22u:
				mb69C48hRlTLSdF1p30JoqLeKBj._5oFaCQNi71DUAwr2GsRcpozHzAC = kGw7UmnaW2UG2pY4rWmZNZTrFCh._5oFaCQNi71DUAwr2GsRcpozHzAC;
				num = ((int)num3 * -680668146) ^ -83327966;
				continue;
			case 0u:
			{
				int num7;
				int num8;
				if (num4 != -1)
				{
					num7 = 1462874795;
					num8 = num7;
				}
				else
				{
					num7 = 1899021301;
					num8 = num7;
				}
				num = num7 ^ ((int)num3 * -442642225);
				continue;
			}
			case 27u:
				return;
			case 6u:
				kGw7UmnaW2UG2pY4rWmZNZTrFCh._hjRbCZIgEE6lGZJqDLlpYixCdUT = 0f;
				num = ((int)num3 * -545284984) ^ -564965075;
				continue;
			case 14u:
				mb69C48hRlTLSdF1p30JoqLeKBj._isVjytSCPjaQXfnhSgmbShfAEYC = kGw7UmnaW2UG2pY4rWmZNZTrFCh._isVjytSCPjaQXfnhSgmbShfAEYC;
				num = (int)(num3 * 2097832356) ^ -737268968;
				continue;
			case 17u:
				return;
			case 20u:
				mb69C48hRlTLSdF1p30JoqLeKBj._hjRbCZIgEE6lGZJqDLlpYixCdUT = kGw7UmnaW2UG2pY4rWmZNZTrFCh._hjRbCZIgEE6lGZJqDLlpYixCdUT;
				num = (int)(num3 * 1604748324) ^ -885872964;
				continue;
			case 15u:
				goto IL_0169;
			case 1u:
				kGw7UmnaW2UG2pY4rWmZNZTrFCh._ObXrbtVZcdprxclR2Ggz9jKwlp = new WorldPosData(_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP._PositionX + Math.Cos(kGw7UmnaW2UG2pY4rWmZNZTrFCh._hjRbCZIgEE6lGZJqDLlpYixCdUT) * 0.3, _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._FLMczMOk4gNIJMbSsAnIDIvYlDP._PositionY + Math.Sin(kGw7UmnaW2UG2pY4rWmZNZTrFCh._hjRbCZIgEE6lGZJqDLlpYixCdUT) * 0.3);
				kGw7UmnaW2UG2pY4rWmZNZTrFCh._IBSqBdwNTiXSzhZbDhEFMC0Gc51 = iBSqBdwNTiXSzhZbDhEFMC0Gc;
				kGw7UmnaW2UG2pY4rWmZNZTrFCh._isVjytSCPjaQXfnhSgmbShfAEYC = _50w8wVuv8bL5nhKaR2EHxjrTamB._5F11zlatiaeKtzrzg30JrtdXmjH();
				kGw7UmnaW2UG2pY4rWmZNZTrFCh._5oFaCQNi71DUAwr2GsRcpozHzAC = (short)x0bFEWbxXdGdRfNpGQ1c34l1w5r._QjKHGXZ7ohXwrDQImauPaSixsVg;
				num = (int)((num3 * 1440970593) ^ 0x17243C03);
				continue;
			case 18u:
				x0bFEWbxXdGdRfNpGQ1c34l1w5r = ResourceDownloader._3ndzvDGHhvqls1BD8vzizSQBDdI._EOUVvVncv0meCCDQkGXOyUOLU5F((ushort)num4);
				num = 1980099783;
				continue;
			case 28u:
				mb69C48hRlTLSdF1p30JoqLeKBj._qL8Qk0RJEu4lcCGcJpKfz1Fn8tb = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._fn2CRnBpjyTWHR9K8SU4iOwhDtK;
				num = (int)((num3 * 1762302371) ^ 0x2B34C990);
				continue;
			case 19u:
				return;
			case 10u:
				kGw7UmnaW2UG2pY4rWmZNZTrFCh = (_KGw7UmnaW2UG2pY4rWmZNZTrFCh)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.PLAYERSHOOT);
				num = ((int)num3 * -1574473455) ^ 0x6F3F2378;
				continue;
			case 23u:
				num9 = 0;
				num = 243953911;
				continue;
			case 16u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB._xRCQ3Y8enVTevEwMAZe8WUmANbE(mb69C48hRlTLSdF1p30JoqLeKBj);
				num9++;
				num = ((int)num3 * -968646561) ^ 0x223390D;
				continue;
			case 26u:
				mb69C48hRlTLSdF1p30JoqLeKBj = (_mb69C48hRlTLSdF1p30JoqLeKBj)Packet._dEXwEtTmoE7bx8WSEboFALz7jek(PacketType.ALLYSHOOT);
				num = (int)((num3 * 1554793405) ^ 0x745818BA);
				continue;
			case 21u:
			{
				int num5;
				int num6;
				if (x0bFEWbxXdGdRfNpGQ1c34l1w5r != null)
				{
					num5 = 1832987712;
					num6 = num5;
				}
				else
				{
					num5 = 919270215;
					num6 = num5;
				}
				num = num5 ^ (int)(num3 * 2016891520);
				continue;
			}
			case 12u:
				return;
			case 13u:
				return;
			case 7u:
				goto IL_0340;
			case 24u:
				_50w8wVuv8bL5nhKaR2EHxjrTamB._WEI99xvr4YqzD1PAnL2WmiBhWKJ(kGw7UmnaW2UG2pY4rWmZNZTrFCh);
				num = ((int)num3 * -1102663789) ^ -1280874214;
				continue;
			case 2u:
				goto IL_0381;
			case 9u:
				goto IL_03a7;
			case 8u:
				goto IL_03c4;
			case 3u:
				_ = x0bFEWbxXdGdRfNpGQ1c34l1w5r._owzIa4SA35UDyEgHwZLCFxJRPQ4;
				num = 659381070;
				continue;
			case 25u:
				return;
			case 11u:
				num4 = _50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC.Inventory[1];
				num = 53621624;
				continue;
			case 4u:
				return;
			case 5u:
				return;
			}
			break;
			IL_03c4:
			int num10;
			if (x0bFEWbxXdGdRfNpGQ1c34l1w5r._Hgcuj8Yk2qRXttXX0EHvRYXq7I == 0)
			{
				num = 1538023833;
				num10 = num;
			}
			else
			{
				num = 916727722;
				num10 = num;
			}
			continue;
			IL_0381:
			int num11;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._QpgZcrpUzDvD724s39cRtNW05SF())
			{
				num = 663709774;
				num11 = num;
			}
			else
			{
				num = 218585465;
				num11 = num;
			}
			continue;
			IL_0169:
			iBSqBdwNTiXSzhZbDhEFMC0Gc = Time;
			int num12;
			if (!_50w8wVuv8bL5nhKaR2EHxjrTamB._W6bpBrAw6dPSILcVRK394JGD7tC._SysWm7wHzXLG03yfcsOJjhD8d8R())
			{
				num = 1178452604;
				num12 = num;
			}
			else
			{
				num = 1666893384;
				num12 = num;
			}
			continue;
			IL_03a7:
			int num13;
			if (num9 < x0bFEWbxXdGdRfNpGQ1c34l1w5r._Hgcuj8Yk2qRXttXX0EHvRYXq7I)
			{
				num = 1956691123;
				num13 = num;
			}
			else
			{
				num = 440882673;
				num13 = num;
			}
		}
		goto IL_000b;
		IL_000b:
		num = 1762217111;
		goto IL_0010;
	}

	private void _1ewKC7M4NL9N81VglwFrDKTJTfK(_x0bFEWbxXdGdRfNpGQ1c34l1w5r item, int time, double projSpeed, double maxDist, WorldPosData playerPos)
	{
		//Discarded unreachable code: IL_0345, IL_08be, IL_0ce7
		maxDist *= maxDist;
		int num23 = default(int);
		WorldPosData worldPosData = default(WorldPosData);
		bool flag = default(bool);
		int num68 = default(int);
		double num11 = default(double);
		WorldPosData location = default(WorldPosData);
		int num36 = default(int);
		WorldPosData y0mQWlPZGeLjvZsyRyxZmdIZ3qh2 = default(WorldPosData);
		int num67 = default(int);
		bool enemyIgnore = default(bool);
		int autoAbilityMinimumEnemyHealthThreshold = default(int);
		bool flag3 = default(bool);
		bool flag2 = default(bool);
		PlayerData current3 = default(PlayerData);
		double num10 = default(double);
		PlayerData current2 = default(PlayerData);
		PlayerData current = default(PlayerData);
		while (true)
		{
			int num = 1932886848;
			while (true)
			{
				int num105;
				uint num2;
				switch ((num2 = (uint)num ^ 0x6F221B2Au) % 19u)
				{
				case 10u:
					break;
				case 12u:
					num23 = 5;
					num = 1113833624;
					continue;
				case 14u:
					worldPosData = WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R;
					num = (int)((num2 * 377539524) ^ 0x584BC354);
					continue;
				case 9u:
					flag = true;
					num = ((int)num2 * -1227733544) ^ 0x7E00D983;
					continue;
				case 4u:
					num68 = int.MinValue;
					num = (int)((num2 * 985719548) ^ 0x62934FB);
					continue;
				case 6u:
					num11 = double.MaxValue;
					num = ((int)num2 * -1597258823) ^ -2131113055;
					continue;
				case 18u:
					location = new WorldPosData(_REqTtrf1f1UI7k1CKnC1oikFdjd._PositionX, _REqTtrf1f1UI7k1CKnC1oikFdjd._PositionY);
					num = ((int)num2 * -1128870117) ^ 0x56EEED80;
					continue;
				case 0u:
					num36 = 2;
					num = (int)(num2 * 67561700) ^ -1404854509;
					continue;
				case 15u:
					num23 *= num23;
					num = ((int)num2 * -495146731) ^ -1719349955;
					continue;
				case 3u:
					num36 = 1;
					num = ((int)num2 * -661068916) ^ -211260078;
					continue;
				case 2u:
					y0mQWlPZGeLjvZsyRyxZmdIZ3qh2 = WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R;
					num = (int)((num2 * 703622841) ^ 0x1E896559);
					continue;
				case 7u:
					num67 = int.MinValue;
					num = (int)(num2 * 1966740454) ^ -353436952;
					continue;
				case 11u:
					enemyIgnore = Settings.Default.EnemyIgnore;
					autoAbilityMinimumEnemyHealthThreshold = Settings.Default.AutoAbilityMinimumEnemyHealthThreshold;
					num = ((int)num2 * -1795286862) ^ -587596315;
					continue;
				case 1u:
					num36 = 2;
					num = (int)((num2 * 1712850470) ^ 0x59D64B07);
					continue;
				case 5u:
					flag3 = true;
					num = (int)((num2 * 2023249737) ^ 0x6E3B1085);
					continue;
				case 17u:
				{
					int num111;
					int num112;
					if (!Settings.Default.AutoAbilityClosestEnemy)
					{
						num111 = 1062961465;
						num112 = num111;
					}
					else
					{
						num111 = 1273340108;
						num112 = num111;
					}
					num = num111 ^ ((int)num2 * -527381646);
					continue;
				}
				case 8u:
				{
					int num110;
					if (Settings.Default.AutoAbilityStrongestEnemy)
					{
						num = 301665203;
						num110 = num;
					}
					else
					{
						num = 942461950;
						num110 = num;
					}
					continue;
				}
				case 13u:
					flag2 = false;
					if (num36 == 0)
					{
						num = 1471013986;
						continue;
					}
					switch (num36)
					{
					case 1:
					{
						using (Dictionary<int, PlayerData>.ValueCollection.Enumerator enumerator = _50w8wVuv8bL5nhKaR2EHxjrTamB._Aq9hW2NyDqEkITmxzYm6OCQLaDB.Values.GetEnumerator())
						{
							while (true)
							{
								int num65;
								int num66;
								if (!enumerator.MoveNext())
								{
									num65 = 129811734;
									num66 = num65;
								}
								else
								{
									num65 = 1768088149;
									num66 = num65;
								}
								while (true)
								{
									switch ((num2 = (uint)num65 ^ 0x6F221B2Au) % 36u)
									{
									case 23u:
										num65 = 1768088149;
										continue;
									default:
										goto end_IL_069a;
									case 26u:
									{
										int num77;
										int num78;
										if (current3._fBkfBLhhMp7FH6BVjSag96CvhnT >= num67)
										{
											num77 = 284604886;
											num78 = num77;
										}
										else
										{
											num77 = 2026438590;
											num78 = num77;
										}
										num65 = num77 ^ (int)(num2 * 83598780);
										continue;
									}
									case 15u:
									{
										int num96;
										int num97;
										if (double.IsNaN(projSpeed))
										{
											num96 = 1400967785;
											num97 = num96;
										}
										else
										{
											num96 = 776034325;
											num97 = num96;
										}
										num65 = num96 ^ (int)(num2 * 653454504);
										continue;
									}
									case 20u:
									{
										int num92;
										if (worldPosData == WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R)
										{
											num65 = 1224477398;
											num92 = num65;
										}
										else
										{
											num65 = 622903404;
											num92 = num65;
										}
										continue;
									}
									case 12u:
									{
										int num71;
										int num72;
										if (current3._DGVRAcMHLhkT7cE8sbBDj7EHf0j())
										{
											num71 = 1541741610;
											num72 = num71;
										}
										else
										{
											num71 = 1656033467;
											num72 = num71;
										}
										num65 = num71 ^ ((int)num2 * -1419912261);
										continue;
									}
									case 19u:
										worldPosData = new WorldPosData(current3._IlcbhoOIM3MRszn9mfn3IKjnXc0._PositionX, current3._IlcbhoOIM3MRszn9mfn3IKjnXc0._PositionY);
										num65 = ((int)num2 * -1536051940) ^ -965279473;
										continue;
									case 10u:
									{
										int num84;
										int num85;
										if (flag2)
										{
											num84 = 585676399;
											num85 = num84;
										}
										else
										{
											num84 = 513117136;
											num85 = num84;
										}
										num65 = num84 ^ ((int)num2 * -60690313);
										continue;
									}
									case 8u:
									{
										int num104;
										if (num10 < maxDist)
										{
											num65 = 1890919303;
											num104 = num65;
										}
										else
										{
											num65 = 1224477398;
											num104 = num65;
										}
										continue;
									}
									case 7u:
									{
										int num95;
										if (current3._9zLynim4HlmFvQv3AqAl2vIblhc())
										{
											num65 = 1224477398;
											num95 = num65;
										}
										else
										{
											num65 = 1798023238;
											num95 = num65;
										}
										continue;
									}
									case 14u:
										num10 = playerPos._l97JYrnBrV9Ws5bD3UnHa879cYh(current3._FLMczMOk4gNIJMbSsAnIDIvYlDP);
										num65 = 1753802518;
										continue;
									case 32u:
										break;
									case 24u:
									{
										int num75;
										int num76;
										if (num10 >= maxDist)
										{
											num75 = -1630888954;
											num76 = num75;
										}
										else
										{
											num75 = -1623812704;
											num76 = num75;
										}
										num65 = num75 ^ (int)(num2 * 1308114700);
										continue;
									}
									case 34u:
										goto end_IL_069a;
									case 17u:
										num65 = ((int)num2 * -170150610) ^ 0x10014DA0;
										continue;
									case 5u:
									{
										int num100;
										int num101;
										if (Settings.Default.FameIngoredEnemies.Contains(current3._y2nCjecGeYsmqDEzaplcuBvYtN7))
										{
											num100 = -1157165311;
											num101 = num100;
										}
										else
										{
											num100 = -493706766;
											num101 = num100;
										}
										num65 = num100 ^ ((int)num2 * -1816711401);
										continue;
									}
									case 1u:
										flag3 = false;
										y0mQWlPZGeLjvZsyRyxZmdIZ3qh2 = worldPosData;
										num65 = (int)(num2 * 1358221036) ^ -1272852828;
										continue;
									case 31u:
										y0mQWlPZGeLjvZsyRyxZmdIZ3qh2 = (WorldPosData)worldPosData.Clone();
										num65 = ((int)num2 * -392957249) ^ 0x6BA8C9FB;
										continue;
									case 30u:
									{
										int num90;
										int num91;
										if (!(flag && flag2))
										{
											num90 = -2051524789;
											num91 = num90;
										}
										else
										{
											num90 = -864650739;
											num91 = num90;
										}
										num65 = num90 ^ (int)(num2 * 1866679385);
										continue;
									}
									case 11u:
										current3 = enumerator.Current;
										num65 = 1237792207;
										continue;
									case 33u:
									{
										int num86;
										int num87;
										if (!(num10 > num11))
										{
											num86 = 158548506;
											num87 = num86;
										}
										else
										{
											num86 = 1720478822;
											num87 = num86;
										}
										num65 = num86 ^ ((int)num2 * -1768994320);
										continue;
									}
									case 27u:
										worldPosData = new WorldPosData(current3._FLMczMOk4gNIJMbSsAnIDIvYlDP._PositionX, current3._FLMczMOk4gNIJMbSsAnIDIvYlDP._PositionY);
										num65 = 21607826;
										continue;
									case 0u:
									{
										int num79;
										int num80;
										if (!current3._P8Pe7KoeoiWl4D1BHuWF4YTFunp())
										{
											num79 = 1938331706;
											num80 = num79;
										}
										else
										{
											num79 = 1256654578;
											num80 = num79;
										}
										num65 = num79 ^ (int)(num2 * 1110663915);
										continue;
									}
									case 2u:
										num10 = playerPos._l97JYrnBrV9Ws5bD3UnHa879cYh(current3._FLMczMOk4gNIJMbSsAnIDIvYlDP);
										num65 = (int)((num2 * 1040524434) ^ 0x3E116A2B);
										continue;
									case 9u:
										num67 = current3._fBkfBLhhMp7FH6BVjSag96CvhnT;
										num68 = current3._v6scruPI8GbKsVXu2rpqDMycX0Q;
										num65 = (int)((num2 * 1270512381) ^ 0x121DAA03);
										continue;
									case 25u:
									{
										int num102;
										int num103;
										if (current3._v6scruPI8GbKsVXu2rpqDMycX0Q < 0)
										{
											num102 = -903902542;
											num103 = num102;
										}
										else
										{
											num102 = -1437806556;
											num103 = num102;
										}
										num65 = num102 ^ (int)(num2 * 239269748);
										continue;
									}
									case 21u:
										num65 = ((int)num2 * -1354747668) ^ -1780199106;
										continue;
									case 22u:
									{
										int num98;
										int num99;
										if (flag)
										{
											num98 = -634384924;
											num99 = num98;
										}
										else
										{
											num98 = -2044322035;
											num99 = num98;
										}
										num65 = num98 ^ (int)(num2 * 1583220030);
										continue;
									}
									case 29u:
									{
										flag2 = current3._VnfPKrmQ7LzLqcF4PWxx5FYDsVP;
										int num93;
										int num94;
										if (current3._0uAKPjtnSdQDHNDBbKEF3hRerjh)
										{
											num93 = -449416709;
											num94 = num93;
										}
										else
										{
											num93 = -1627160439;
											num94 = num93;
										}
										num65 = num93 ^ (int)(num2 * 947682291);
										continue;
									}
									case 18u:
									{
										int num88;
										int num89;
										if (current3._v6scruPI8GbKsVXu2rpqDMycX0Q > num68)
										{
											num88 = 1979056240;
											num89 = num88;
										}
										else
										{
											num88 = 515787250;
											num89 = num88;
										}
										num65 = num88 ^ ((int)num2 * -1954951791);
										continue;
									}
									case 13u:
									{
										int num82;
										int num83;
										if (current3._v6scruPI8GbKsVXu2rpqDMycX0Q != num68)
										{
											num82 = -1144970498;
											num83 = num82;
										}
										else
										{
											num82 = -969755701;
											num83 = num82;
										}
										num65 = num82 ^ ((int)num2 * -609134492);
										continue;
									}
									case 35u:
									{
										int num81;
										if (current3._fBkfBLhhMp7FH6BVjSag96CvhnT >= autoAbilityMinimumEnemyHealthThreshold)
										{
											num65 = 1002039285;
											num81 = num65;
										}
										else
										{
											num65 = 1224477398;
											num81 = num65;
										}
										continue;
									}
									case 6u:
									{
										int num73;
										int num74;
										if (!enemyIgnore)
										{
											num73 = 1610823079;
											num74 = num73;
										}
										else
										{
											num73 = 1417911785;
											num74 = num73;
										}
										num65 = num73 ^ ((int)num2 * -1910507250);
										continue;
									}
									case 28u:
									{
										int num69;
										int num70;
										if (current3._fBkfBLhhMp7FH6BVjSag96CvhnT == num67)
										{
											num69 = -1491990196;
											num70 = num69;
										}
										else
										{
											num69 = -758837948;
											num70 = num69;
										}
										num65 = num69 ^ (int)(num2 * 651858472);
										continue;
									}
									case 3u:
										num67 = current3._fBkfBLhhMp7FH6BVjSag96CvhnT;
										num68 = current3._v6scruPI8GbKsVXu2rpqDMycX0Q;
										num11 = num10;
										num65 = 2004556345;
										continue;
									case 4u:
										y0mQWlPZGeLjvZsyRyxZmdIZ3qh2 = (WorldPosData)worldPosData.Clone();
										num11 = num10;
										num65 = ((int)num2 * -277543897) ^ -995221017;
										continue;
									case 16u:
										goto end_IL_069a;
									}
									break;
								}
							}
							end_IL_069a:;
						}
						break;
					}
					case 2:
					{
						using (Dictionary<int, PlayerData>.ValueCollection.Enumerator enumerator = _50w8wVuv8bL5nhKaR2EHxjrTamB._Aq9hW2NyDqEkITmxzYm6OCQLaDB.Values.GetEnumerator())
						{
							while (true)
							{
								int num37;
								int num38;
								if (!enumerator.MoveNext())
								{
									num37 = 1427565832;
									num38 = num37;
								}
								else
								{
									num37 = 916910124;
									num38 = num37;
								}
								while (true)
								{
									switch ((num2 = (uint)num37 ^ 0x6F221B2Au) % 26u)
									{
									case 23u:
										num37 = 916910124;
										continue;
									default:
										goto end_IL_0bf3;
									case 2u:
									{
										int num52;
										int num53;
										if (!flag2)
										{
											num52 = 845090902;
											num53 = num52;
										}
										else
										{
											num52 = 402681387;
											num53 = num52;
										}
										num37 = num52 ^ (int)(num2 * 904842871);
										continue;
									}
									case 1u:
									{
										int num44;
										int num45;
										if (current2._v6scruPI8GbKsVXu2rpqDMycX0Q >= 0)
										{
											num44 = -630499238;
											num45 = num44;
										}
										else
										{
											num44 = -2015207143;
											num45 = num44;
										}
										num37 = num44 ^ ((int)num2 * -1037064461);
										continue;
									}
									case 9u:
										y0mQWlPZGeLjvZsyRyxZmdIZ3qh2 = (WorldPosData)worldPosData.Clone();
										num37 = (int)(num2 * 1807013942) ^ -2063388856;
										continue;
									case 24u:
										goto end_IL_0bf3;
									case 16u:
										break;
									case 4u:
									{
										int num56;
										int num57;
										if (!flag)
										{
											num56 = -116444907;
											num57 = num56;
										}
										else
										{
											num56 = -1375608308;
											num57 = num56;
										}
										num37 = num56 ^ (int)(num2 * 1229492965);
										continue;
									}
									case 25u:
									{
										int num60;
										int num61;
										if (flag && flag2)
										{
											num60 = -1448895915;
											num61 = num60;
										}
										else
										{
											num60 = -484835688;
											num61 = num60;
										}
										num37 = num60 ^ ((int)num2 * -482087616);
										continue;
									}
									case 15u:
									{
										flag2 = current2._VnfPKrmQ7LzLqcF4PWxx5FYDsVP;
										int num54;
										int num55;
										if (current2._0uAKPjtnSdQDHNDBbKEF3hRerjh)
										{
											num54 = -1451629385;
											num55 = num54;
										}
										else
										{
											num54 = -1997713283;
											num55 = num54;
										}
										num37 = num54 ^ (int)(num2 * 1934574849);
										continue;
									}
									case 12u:
										worldPosData = new WorldPosData(current2._FLMczMOk4gNIJMbSsAnIDIvYlDP._PositionX, current2._FLMczMOk4gNIJMbSsAnIDIvYlDP._PositionY);
										num37 = 1584080509;
										continue;
									case 10u:
									{
										int num64;
										if (num10 < num11)
										{
											num37 = 426264840;
											num64 = num37;
										}
										else
										{
											num37 = 739136466;
											num64 = num37;
										}
										continue;
									}
									case 20u:
										num11 = num10;
										num37 = (int)(num2 * 1796018381) ^ -1105319001;
										continue;
									case 21u:
									{
										int num62;
										if (current2._fBkfBLhhMp7FH6BVjSag96CvhnT < autoAbilityMinimumEnemyHealthThreshold)
										{
											num37 = 739136466;
											num62 = num37;
										}
										else
										{
											num37 = 262385306;
											num62 = num37;
										}
										continue;
									}
									case 17u:
									{
										int num48;
										int num49;
										if (current2._DGVRAcMHLhkT7cE8sbBDj7EHf0j())
										{
											num48 = -1584047260;
											num49 = num48;
										}
										else
										{
											num48 = -289277611;
											num49 = num48;
										}
										num37 = num48 ^ (int)(num2 * 1293916894);
										continue;
									}
									case 6u:
										current2 = enumerator.Current;
										num37 = 1649984389;
										continue;
									case 11u:
										worldPosData = new WorldPosData(current2._IlcbhoOIM3MRszn9mfn3IKjnXc0._PositionX, current2._IlcbhoOIM3MRszn9mfn3IKjnXc0._PositionY);
										num37 = ((int)num2 * -1231349145) ^ 0x3EB01D28;
										continue;
									case 22u:
									{
										int num41;
										int num42;
										if (num10 < maxDist)
										{
											num41 = -784079291;
											num42 = num41;
										}
										else
										{
											num41 = -1823692162;
											num42 = num41;
										}
										num37 = num41 ^ (int)(num2 * 626782313);
										continue;
									}
									case 5u:
										flag3 = false;
										y0mQWlPZGeLjvZsyRyxZmdIZ3qh2 = (WorldPosData)worldPosData.Clone();
										num37 = (int)(num2 * 356167627) ^ -1387044761;
										continue;
									case 3u:
									{
										int num63;
										if (!current2._9zLynim4HlmFvQv3AqAl2vIblhc())
										{
											num37 = 1557135774;
											num63 = num37;
										}
										else
										{
											num37 = 739136466;
											num63 = num37;
										}
										continue;
									}
									case 14u:
										num10 = playerPos._l97JYrnBrV9Ws5bD3UnHa879cYh(current2._FLMczMOk4gNIJMbSsAnIDIvYlDP);
										num37 = ((int)num2 * -1104049786) ^ -1050221418;
										continue;
									case 8u:
									{
										int num58;
										int num59;
										if (current2._P8Pe7KoeoiWl4D1BHuWF4YTFunp())
										{
											num58 = 1061121058;
											num59 = num58;
										}
										else
										{
											num58 = 790068495;
											num59 = num58;
										}
										num37 = num58 ^ ((int)num2 * -2139858068);
										continue;
									}
									case 13u:
									{
										int num50;
										int num51;
										if (enemyIgnore)
										{
											num50 = 951510345;
											num51 = num50;
										}
										else
										{
											num50 = 172356963;
											num51 = num50;
										}
										num37 = num50 ^ ((int)num2 * -385022268);
										continue;
									}
									case 19u:
									{
										int num46;
										int num47;
										if (Settings.Default.FameIngoredEnemies.Contains(current2._y2nCjecGeYsmqDEzaplcuBvYtN7))
										{
											num46 = -1739257335;
											num47 = num46;
										}
										else
										{
											num46 = -600192578;
											num47 = num46;
										}
										num37 = num46 ^ ((int)num2 * -1453593537);
										continue;
									}
									case 7u:
									{
										int num43;
										if (worldPosData == WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R)
										{
											num37 = 739136466;
											num43 = num37;
										}
										else
										{
											num37 = 576808898;
											num43 = num37;
										}
										continue;
									}
									case 0u:
									{
										int num39;
										int num40;
										if (double.IsNaN(projSpeed))
										{
											num39 = -1685410071;
											num40 = num39;
										}
										else
										{
											num39 = -1473526902;
											num40 = num39;
										}
										num37 = num39 ^ (int)(num2 * 1270703286);
										continue;
									}
									case 18u:
										goto end_IL_0bf3;
									}
									break;
								}
							}
							end_IL_0bf3:;
						}
						break;
					}
					}
					goto IL_0fbb;
				default:
					{
						using (Dictionary<int, PlayerData>.ValueCollection.Enumerator enumerator = _50w8wVuv8bL5nhKaR2EHxjrTamB._Aq9hW2NyDqEkITmxzYm6OCQLaDB.Values.GetEnumerator())
						{
							while (true)
							{
								int num3;
								int num4;
								if (enumerator.MoveNext())
								{
									num3 = 958038400;
									num4 = num3;
								}
								else
								{
									num3 = 1617074498;
									num4 = num3;
								}
								while (true)
								{
									switch ((num2 = (uint)num3 ^ 0x6F221B2Au) % 29u)
									{
									case 3u:
										num3 = 958038400;
										continue;
									default:
										goto end_IL_0252;
									case 11u:
									{
										int num9;
										if (!current._9zLynim4HlmFvQv3AqAl2vIblhc())
										{
											num3 = 348541521;
											num9 = num3;
										}
										else
										{
											num3 = 1025370440;
											num9 = num3;
										}
										continue;
									}
									case 2u:
										num10 = playerPos._l97JYrnBrV9Ws5bD3UnHa879cYh(location);
										num3 = (int)((num2 * 975080289) ^ 0x6EBDDD2C);
										continue;
									case 10u:
									{
										int num17;
										int num18;
										if (!enemyIgnore)
										{
											num17 = 1714554636;
											num18 = num17;
										}
										else
										{
											num17 = 714076682;
											num18 = num17;
										}
										num3 = num17 ^ (int)(num2 * 1255993415);
										continue;
									}
									case 9u:
										goto end_IL_0252;
									case 5u:
									{
										int num29;
										int num30;
										if (double.IsNaN(projSpeed))
										{
											num29 = 1879713278;
											num30 = num29;
										}
										else
										{
											num29 = 678757581;
											num30 = num29;
										}
										num3 = num29 ^ (int)(num2 * 375317371);
										continue;
									}
									case 27u:
									{
										int num24;
										int num25;
										if (num10 > (double)num23)
										{
											num24 = -721145520;
											num25 = num24;
										}
										else
										{
											num24 = -661224367;
											num25 = num24;
										}
										num3 = num24 ^ ((int)num2 * -1577407848);
										continue;
									}
									case 0u:
									{
										int num27;
										int num28;
										if (current._v6scruPI8GbKsVXu2rpqDMycX0Q >= 0)
										{
											num27 = -1077087323;
											num28 = num27;
										}
										else
										{
											num27 = -1244140102;
											num28 = num27;
										}
										num3 = num27 ^ ((int)num2 * -583100418);
										continue;
									}
									case 7u:
										flag2 = current._VnfPKrmQ7LzLqcF4PWxx5FYDsVP;
										num3 = (int)((num2 * 331816366) ^ 0x4A5119E8);
										continue;
									case 17u:
										worldPosData = new WorldPosData(current._IlcbhoOIM3MRszn9mfn3IKjnXc0._PositionX, current._IlcbhoOIM3MRszn9mfn3IKjnXc0._PositionY);
										num3 = ((int)num2 * -796506752) ^ 0x1DE42C4A;
										continue;
									case 12u:
									{
										int num14;
										int num15;
										if (!current._0uAKPjtnSdQDHNDBbKEF3hRerjh)
										{
											num14 = 1979329976;
											num15 = num14;
										}
										else
										{
											num14 = 1634565731;
											num15 = num14;
										}
										num3 = num14 ^ (int)(num2 * 57114492);
										continue;
									}
									case 23u:
										worldPosData = new WorldPosData(current._FLMczMOk4gNIJMbSsAnIDIvYlDP._PositionX, current._FLMczMOk4gNIJMbSsAnIDIvYlDP._PositionY);
										num3 = 66855471;
										continue;
									case 22u:
									{
										int num33;
										if (current._fBkfBLhhMp7FH6BVjSag96CvhnT < autoAbilityMinimumEnemyHealthThreshold)
										{
											num3 = 1025370440;
											num33 = num3;
										}
										else
										{
											num3 = 1119042539;
											num33 = num3;
										}
										continue;
									}
									case 8u:
										num3 = ((int)num2 * -1470643687) ^ -1725349681;
										continue;
									case 25u:
									{
										int num21;
										int num22;
										if (!current._DGVRAcMHLhkT7cE8sbBDj7EHf0j())
										{
											num21 = 1920134127;
											num22 = num21;
										}
										else
										{
											num21 = 635766794;
											num22 = num21;
										}
										num3 = num21 ^ (int)(num2 * 2017316278);
										continue;
									}
									case 15u:
										break;
									case 6u:
									{
										int num16;
										if (worldPosData != WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R)
										{
											num3 = 2130493823;
											num16 = num3;
										}
										else
										{
											num3 = 1025370440;
											num16 = num3;
										}
										continue;
									}
									case 24u:
									{
										int num7;
										int num8;
										if (!(flag && flag2))
										{
											num7 = 1820308971;
											num8 = num7;
										}
										else
										{
											num7 = 1406844984;
											num8 = num7;
										}
										num3 = num7 ^ (int)(num2 * 143957576);
										continue;
									}
									case 14u:
									{
										int num34;
										int num35;
										if (!Settings.Default.FameIngoredEnemies.Contains(current._y2nCjecGeYsmqDEzaplcuBvYtN7))
										{
											num34 = -1779654505;
											num35 = num34;
										}
										else
										{
											num34 = -283083394;
											num35 = num34;
										}
										num3 = num34 ^ ((int)num2 * -1933032818);
										continue;
									}
									case 19u:
									{
										int num31;
										int num32;
										if (flag2)
										{
											num31 = -2043254273;
											num32 = num31;
										}
										else
										{
											num31 = -921295090;
											num32 = num31;
										}
										num3 = num31 ^ (int)(num2 * 1578359449);
										continue;
									}
									case 28u:
										y0mQWlPZGeLjvZsyRyxZmdIZ3qh2 = (WorldPosData)worldPosData.Clone();
										num3 = ((int)num2 * -1396991228) ^ 0x2ABBCD4C;
										continue;
									case 16u:
									{
										int num26;
										if (num10 > num11)
										{
											num3 = 1025370440;
											num26 = num3;
										}
										else
										{
											num3 = 464938311;
											num26 = num3;
										}
										continue;
									}
									case 13u:
									{
										num10 = playerPos._l97JYrnBrV9Ws5bD3UnHa879cYh(current._FLMczMOk4gNIJMbSsAnIDIvYlDP);
										int num19;
										int num20;
										if (num10 > maxDist)
										{
											num19 = 731212602;
											num20 = num19;
										}
										else
										{
											num19 = 1865488559;
											num20 = num19;
										}
										num3 = num19 ^ (int)(num2 * 1020227242);
										continue;
									}
									case 21u:
									{
										int num12;
										int num13;
										if (!flag)
										{
											num12 = -522888444;
											num13 = num12;
										}
										else
										{
											num12 = -1306499679;
											num13 = num12;
										}
										num3 = num12 ^ ((int)num2 * -521599707);
										continue;
									}
									case 26u:
										current = enumerator.Current;
										num3 = 1833561439;
										continue;
									case 18u:
										num11 = num10;
										num3 = (int)((num2 * 674656754) ^ 0x4EF6C961);
										continue;
									case 4u:
										flag3 = false;
										y0mQWlPZGeLjvZsyRyxZmdIZ3qh2 = (WorldPosData)worldPosData.Clone();
										num3 = ((int)num2 * -59261414) ^ 0x57A4629B;
										continue;
									case 1u:
									{
										int num5;
										int num6;
										if (current._P8Pe7KoeoiWl4D1BHuWF4YTFunp())
										{
											num5 = -417038232;
											num6 = num5;
										}
										else
										{
											num5 = -1164231879;
											num6 = num5;
										}
										num3 = num5 ^ (int)(num2 * 1340023136);
										continue;
									}
									case 20u:
										goto end_IL_0252;
									}
									break;
								}
							}
							end_IL_0252:;
						}
						goto IL_0fbb;
					}
					IL_0fbb:
					if (flag)
					{
						goto IL_0fc2;
					}
					goto IL_1084;
					IL_1084:
					flag3 = false;
					num105 = 1284037631;
					goto IL_0fc7;
					IL_0fc7:
					while (true)
					{
						switch ((num2 = (uint)num105 ^ 0x6F221B2Au) % 9u)
						{
						case 0u:
							break;
						default:
							return;
						case 2u:
						{
							int num108;
							int num109;
							if (!flag3)
							{
								num108 = 945959471;
								num109 = num108;
							}
							else
							{
								num108 = 127845404;
								num109 = num108;
							}
							num105 = num108 ^ ((int)num2 * -625673175);
							continue;
						}
						case 6u:
							_bgSVetCGPR3zNWnEkr4cuYlGGJg(item, time, y0mQWlPZGeLjvZsyRyxZmdIZ3qh2, 1);
							num105 = ((int)num2 * -772452253) ^ -601614050;
							continue;
						case 1u:
							goto IL_1039;
						case 7u:
							num105 = (int)((num2 * 205361937) ^ 0x647B0B76);
							continue;
						case 3u:
						{
							int num106;
							int num107;
							if (!y0mQWlPZGeLjvZsyRyxZmdIZ3qh2.Equals(WorldPosData._wqLcCTm1kWDEf2iYSYXvp4mO05R))
							{
								num106 = -1440015492;
								num107 = num106;
							}
							else
							{
								num106 = -936141830;
								num107 = num106;
							}
							num105 = num106 ^ ((int)num2 * -749584691);
							continue;
						}
						case 4u:
							goto IL_1084;
						case 5u:
							flag = false;
							num105 = (int)(num2 * 919813767) ^ -1539323495;
							continue;
						case 8u:
							return;
						}
						break;
						IL_1039:
						if (!flag3)
						{
							num105 = 126983359;
							continue;
						}
						goto case 13u;
					}
					goto IL_0fc2;
					IL_0fc2:
					num105 = 217894522;
					goto IL_0fc7;
				}
				break;
			}
		}
	}

	private WorldPosData _hsbR29Jmhj7ZEZaixrStnsNWcMh(WorldPosData playerCoords, WorldPosData targetCoords, WorldPosData targetVec, double projSpeed)
	{
		WorldPosData worldPosData = targetCoords._81bc1KQkWPvwZVKwf5M4k6wRSXe(playerCoords);
		double num8 = default(double);
		double num7 = default(double);
		while (true)
		{
			int num = 719349651;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x559052B6u) % 9u)
				{
				case 4u:
					break;
				case 5u:
					targetVec.AddDistance(num8);
					num = ((int)num2 * -553774394) ^ -593856962;
					continue;
				case 0u:
					num = ((int)num2 * -1049134520) ^ -2048528570;
					continue;
				case 7u:
				{
					int num11;
					int num12;
					if (num7 < num8)
					{
						num11 = -1966787681;
						num12 = num11;
					}
					else
					{
						num11 = -979928929;
						num12 = num11;
					}
					num = num11 ^ ((int)num2 * -1547267947);
					continue;
				}
				case 1u:
				{
					int num13;
					if (num8 < 0.0)
					{
						num = 530576646;
						num13 = num;
					}
					else
					{
						num = 1166797314;
						num13 = num;
					}
					continue;
				}
				case 3u:
					targetVec.AddDistance(num7);
					num = ((int)num2 * -1550192065) ^ -988827426;
					continue;
				case 2u:
				{
					int num9;
					int num10;
					if (num7 >= 0.0)
					{
						num9 = -398674762;
						num10 = num9;
					}
					else
					{
						num9 = -1465105626;
						num10 = num9;
					}
					num = num9 ^ (int)(num2 * 621092622);
					continue;
				}
				case 8u:
				{
					double num3 = 2.0 * (targetVec._PSG5NwhlzdKDqstY2H9MXEITdTC(targetVec) - projSpeed * projSpeed);
					double num4 = 2.0 * worldPosData._PSG5NwhlzdKDqstY2H9MXEITdTC(targetVec);
					double num5 = worldPosData._PSG5NwhlzdKDqstY2H9MXEITdTC(worldPosData);
					double num6 = Math.Sqrt(num4 * num4 - 2.0 * num3 * num5);
					num7 = (0.0 - num4 + num6) / num3;
					num8 = (0.0 - num4 - num6) / num3;
					num = ((int)num2 * -687829616) ^ -791779821;
					continue;
				}
				default:
					return targetCoords._UhmQhgJbHmzkOAp7eqNlTZqWAY1(targetVec);
				}
				break;
			}
		}
	}

	public void _CgwO1K8tgdyKPdKvCtJupNhapLD(PlayerTextPacket playerText)
	{
		//Discarded unreachable code: IL_007a
		if (string.IsNullOrEmpty(playerText._Message))
		{
			return;
		}
		while (true)
		{
			int num = -2121248255;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xA0CD200Cu) % 6u)
				{
				case 2u:
					break;
				case 5u:
					Settings.Default.EnableAutoAbility = !Settings.Default.EnableAutoAbility;
					Settings.Default.Change();
					num = (int)((num2 * 1957002023) ^ 0x2942AF1C);
					continue;
				case 4u:
					playerText._Send = false;
					num = -1216035525;
					continue;
				case 0u:
					return;
				case 1u:
				{
					int num3;
					int num4;
					if (playerText._Message != "/aa")
					{
						num3 = 151415301;
						num4 = num3;
					}
					else
					{
						num3 = 991557423;
						num4 = num3;
					}
					num = num3 ^ (int)(num2 * 997938959);
					continue;
				}
				default:
					_50w8wVuv8bL5nhKaR2EHxjrTamB.sendChatNotification("AutoAbility", Settings.Default.EnableAutoAbility ? "Enabled" : "Disabled");
					return;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private int _XGY0dKXAFuLaWx4T7tQ9XLiiZ54(PlayerData target, ref _q5bAS2GGlyEXggyfH1UYW81UmnS P_1)
	{
		int num = 0;
		using Dictionary<int, PlayerData>.ValueCollection.Enumerator enumerator = _50w8wVuv8bL5nhKaR2EHxjrTamB._Aq9hW2NyDqEkITmxzYm6OCQLaDB.Values.GetEnumerator();
		PlayerData current = default(PlayerData);
		while (true)
		{
			int num2;
			int num3;
			if (enumerator.MoveNext())
			{
				num2 = 1979653302;
				num3 = num2;
			}
			else
			{
				num2 = 2125648713;
				num3 = num2;
			}
			while (true)
			{
				uint num4;
				switch ((num4 = (uint)num2 ^ 0x2F3EF329u) % 11u)
				{
				case 7u:
					num2 = 1979653302;
					continue;
				case 0u:
					break;
				case 10u:
				{
					int num6;
					int num7;
					if (current._DGVRAcMHLhkT7cE8sbBDj7EHf0j())
					{
						num6 = -308467829;
						num7 = num6;
					}
					else
					{
						num6 = -1850330281;
						num7 = num6;
					}
					num2 = num6 ^ (int)(num4 * 534727914);
					continue;
				}
				case 5u:
					current = enumerator.Current;
					num2 = 1750701465;
					continue;
				case 8u:
					num++;
					num2 = (int)(num4 * 1380772808) ^ -457642565;
					continue;
				case 2u:
				{
					int num14;
					int num15;
					if (!current._P8Pe7KoeoiWl4D1BHuWF4YTFunp())
					{
						num14 = -510287379;
						num15 = num14;
					}
					else
					{
						num14 = -2051176205;
						num15 = num14;
					}
					num2 = num14 ^ ((int)num4 * -1333847269);
					continue;
				}
				case 6u:
				{
					int num10;
					int num11;
					if (current._fBkfBLhhMp7FH6BVjSag96CvhnT <= P_1._JSzc4U6HcYYF1eHd7UjhDniLfLf)
					{
						num10 = -30235203;
						num11 = num10;
					}
					else
					{
						num10 = -528506153;
						num11 = num10;
					}
					num2 = num10 ^ (int)(num4 * 344737046);
					continue;
				}
				case 1u:
				{
					int num12;
					int num13;
					if (!P_1._4Tblsoxfo8TVJiRYvAqCkKYEa4o)
					{
						num12 = -1022122313;
						num13 = num12;
					}
					else
					{
						num12 = -182025335;
						num13 = num12;
					}
					num2 = num12 ^ (int)(num4 * 1572639901);
					continue;
				}
				case 4u:
				{
					int num8;
					int num9;
					if (current._9zLynim4HlmFvQv3AqAl2vIblhc())
					{
						num8 = 1207796003;
						num9 = num8;
					}
					else
					{
						num8 = 1842131929;
						num9 = num8;
					}
					num2 = num8 ^ (int)(num4 * 718610422);
					continue;
				}
				case 3u:
				{
					int num5;
					if (!(target._FLMczMOk4gNIJMbSsAnIDIvYlDP._l97JYrnBrV9Ws5bD3UnHa879cYh(current._FLMczMOk4gNIJMbSsAnIDIvYlDP) <= (double)P_1._TQs3I5HnEqElZoiO4Dsa88IEj3u))
					{
						num2 = 885423107;
						num5 = num2;
					}
					else
					{
						num2 = 1447756294;
						num5 = num2;
					}
					continue;
				}
				default:
					return num;
				case 9u:
					return num;
				}
				break;
			}
		}
	}
}
