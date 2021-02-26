using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using ExaltMultiTool.Proxy.DataStructures;

internal class ParseXML : IDataStructure<ushort>
{
	[Serializable]
	[CompilerGenerated]
	private sealed class _FaPUGXnwUk3sNBpjBZwILUnnusO
	{
		public static readonly _FaPUGXnwUk3sNBpjBZwILUnnusO _003C_003E9 = new _FaPUGXnwUk3sNBpjBZwILUnnusO();

		public static Func<XElement, bool> _003C_003E9__0_0;

		internal bool _Pw88G78SkWrXeOpMnSnAqolpzwm(XElement elem)
		{
			return elem.ContainsElement("Item");
		}
	}

	public ProjectileStructure Projectile;

	public int _NumProjectiles;

	public EquipTierEnum _Tier;

	public byte _SlotType;

	public float _RateOfFire;

	public uint _FeedPower;

	public byte _BagType;

	public byte _MpCost;

	public decimal _Cooldown;

	public float _I9LOulXQ6dWoDQOn1L5GkchnJUC;

	public byte _FameBonus;

	public bool _IsSoulbound;

	public bool _IsUseable;

	public bool _IsConsumable;

	public bool _IsPotion;

	public List<_jsZwrE9lzYULBcuBQfPr4S2Du8c> _jCpZRWOsJvipfVcsNeGLqx7e6rd = new List<_jsZwrE9lzYULBcuBQfPr4S2Du8c>();

	public ushort _ItemId
	{
		get;
		private set;
	}

	public string _ItemName
	{
		get;
		private set;
	}

	internal static Dictionary<ushort, ParseXML> _uLt6b1uwFNgoZycBDqE02WmgdfB(XDocument doc)
	{
		Dictionary<ushort, ParseXML> _Y47d6cq6yur6qR7gPJQSTOJl5Wm = new Dictionary<ushort, ParseXML>();
		(from elem in doc.Element("Objects").Elements("Object")
			where elem.ContainsElement("Item")
			select elem)._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(XElement item)
		{
			ParseXML parseXml = new ParseXML(item);
			_Y47d6cq6yur6qR7gPJQSTOJl5Wm[parseXml._ItemId] = parseXml;
		});
		return _Y47d6cq6yur6qR7gPJQSTOJl5Wm;
	}

	public ParseXML(XElement item)
	{
		_ItemId = (ushort)item.GetElementAttrib("type", "0x0").ToInt32();
		_Tier = (item.ContainsElement("Tier") ? ((EquipTierEnum)item.Element("Tier").Value.ParseInt()) : EquipTierEnum.UT);
		_SlotType = (byte)item.GetChildValue("SlotType", "0").ParseInt();
		_RateOfFire = item.GetChildValue("RateOfFire", "1").ParseFloat();
		_FeedPower = (uint)item.GetChildValue("feedPower", "0").ParseInt();
		_BagType = (byte)item.GetChildValue("BagType", "0").ParseInt();
		_MpCost = (byte)item.GetChildValue("MpCost", "0").ParseInt();
		_Cooldown = (decimal)item.GetChildValue("Cooldown", "0").ParseFloat();
		_FameBonus = (byte)item.GetChildValue("FameBonus", "0").ParseInt();
		_IsPotion = item.ContainsElement("Potion");
		if (item.ContainsElement("Activate"))
		{
			ParseActivations(item.Elements("Activate"));
		}
		if (item.ContainsElement("Activate"))
		{
			foreach (XElement item2 in item.Elements("Activate"))
			{
				XAttribute xAttribute = item2.Attribute("radius");
				if (xAttribute != null)
				{
					float.TryParse(xAttribute.Value, out _I9LOulXQ6dWoDQOn1L5GkchnJUC);
				}
			}
		}
		_IsSoulbound = item.ContainsElement("Soulbound");
		_IsUseable = item.ContainsElement("Usable");
		_IsConsumable = item.ContainsElement("Consumable");
		_ItemName = item.GetElementAttrib("id", "");
		_NumProjectiles = item.GetChildValue("NumProjectiles", "0").ParseInt();
		if (item.ContainsElement("Projectile"))
		{
			Projectile = new ProjectileStructure(item.Element("Projectile"));
		}
	}

	private void ParseActivations(IEnumerable<XElement> activateXMLs)
	{
		foreach (XElement activateXML in activateXMLs)
		{
			_jCpZRWOsJvipfVcsNeGLqx7e6rd.Add(new _jsZwrE9lzYULBcuBQfPr4S2Du8c(activateXML));
		}
	}

	public override string ToString()
	{
		return $"Item: {_ItemName} (0x{_ItemId:X})";
	}
}
