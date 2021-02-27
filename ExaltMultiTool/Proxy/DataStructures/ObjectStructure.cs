using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ExaltMultiTool.Proxy.DataStructures
{
	public class ObjectStructure : IDataStructure<ushort>
	{
		public string ObjectClass;

		public ushort MaxHP;

		public float XpMult;

		public bool Static;

		public bool OccupySquare;

		public bool EnemyOccupySquare;

		public bool FullOccupy;

		public bool BlocksSight;

		public bool ProtectFromGroundDamage;

		public bool ProtectFromSink;

		public bool Enemy;

		public bool Player;

		public bool Pet;

		public bool DrawOnGround;

		public ushort Size;

		public ushort ShadowSize;

		public ushort Defense;

		public bool Flying;

		public bool God;

		public bool Cube;

		public bool Quest;

		public bool Item;

		public bool Usable;

		public bool Soulbound;

		public ushort MpCost;

		public ProjectileStructure[] Projectiles;

		public bool Invulnerable;

		public bool Invincible;

		public ushort Id
		{
			get;
			private set;
		}

		public string Name
		{
			get;
			set;
		}

		internal static Dictionary<ushort, ObjectStructure> GetObjectDictionary(XDocument doc)
		{
			Dictionary<ushort, ObjectStructure> objectStructures = new Dictionary<ushort, ObjectStructure>();
			doc.Element("Objects")
				?.Elements("Object")._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(XElement obj)
			{
				ObjectStructure objectStructure = new ObjectStructure(obj);
				objectStructures[objectStructure.Id] = objectStructure;
			});
			return objectStructures;
		}

		public ObjectStructure(XElement obj)
		{
			Id = (ushort)obj.GetElementAttrib("type", "0x0").ToInt32();
			ObjectClass = obj.GetChildValue("Class", "GameObject");
			MaxHP = (ushort)obj.GetChildValue("MaxHitPoints", "0").ToInt32();
			XpMult = obj.GetChildValue("XpMult", "0").ParseFloat();
			Static = obj.ContainsElement("Static");
			OccupySquare = obj.ContainsElement("OccupySquare");
			EnemyOccupySquare = obj.ContainsElement("EnemyOccupySquare");
			FullOccupy = obj.ContainsElement("FullOccupy");
			BlocksSight = obj.ContainsElement("BlocksSight");
			ProtectFromGroundDamage = obj.ContainsElement("ProtectFromGroundDamage");
			ProtectFromSink = obj.ContainsElement("ProtectFromSink");
			Enemy = obj.ContainsElement("Enemy");
			Player = obj.ContainsElement("Player");
			Pet = obj.ContainsElement("Pet");
			DrawOnGround = obj.ContainsElement("DrawOnGround");
			Size = (ushort)obj.GetChildValue("Size", "0").ToInt32();
			ShadowSize = (ushort)obj.GetChildValue("ShadowSize", "0").ToInt32();
			Defense = (ushort)obj.GetChildValue("Defense", "0").ToInt32();
			Flying = obj.ContainsElement("Flying");
			God = obj.ContainsElement("God");
			Cube = obj.ContainsElement("Cube");
			Quest = obj.ContainsElement("Quest");
			Invulnerable = obj.ContainsElement("Invulnerable");
			Invincible = obj.ContainsElement("Invincible");
			Item = obj.ContainsElement("Item");
			Usable = obj.ContainsElement("Usable");
			Soulbound = obj.ContainsElement("Soulbound");
			MpCost = (ushort)obj.GetChildValue("MpCost", "0").ToInt32();
			List<ProjectileStructure> projectileStructures = new List<ProjectileStructure>();
			obj.Elements("Projectile")._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(XElement projectile)
			{
				projectileStructures.Add(new ProjectileStructure(projectile));
			});
			Projectiles = projectileStructures.ToArray();
			this.Name = obj.GetElementAttrib("id", "");
			if (!Player) return;
			ClassStats classStats = new ClassStats();
			if (!int.TryParse(obj.Element("MaxHitPoints")?.Attribute("max")?.Value, out classStats.LifeMax))
			{
				Console.WriteLine($"Failed parsing player stats of {Id} {ObjectClass}");
			}
			if (!int.TryParse(obj.Element("MaxMagicPoints")?.Attribute("max")?.Value, out classStats.ManaMax))
			{
				Console.WriteLine($"Failed parsing player stats of {Id} {ObjectClass}");
			}
			if (!int.TryParse(obj.Element("Attack")?.Attribute("max")?.Value, out classStats.AttackMax))
			{
				Console.WriteLine($"Failed parsing player stats of {Id} {ObjectClass}");
			}
			if (!int.TryParse(obj.Element("Defense")?.Attribute("max")?.Value, out classStats.DefenseMax))
			{
				Console.WriteLine($"Failed parsing player stats of {Id} {ObjectClass}");
			}
			if (!int.TryParse(obj.Element("Speed")?.Attribute("max")?.Value, out classStats.SpeedMax))
			{
				Console.WriteLine($"Failed parsing player stats of {Id} {ObjectClass}");
			}
			if (!int.TryParse(obj.Element("Dexterity")?.Attribute("max")?.Value, out classStats.DexterityMax))
			{
				Console.WriteLine($"Failed parsing player stats of {Id} {ObjectClass}");
			}
			if (!int.TryParse(obj.Element("HpRegen")?.Attribute("max")?.Value, out classStats.VitalityMax))
			{
				Console.WriteLine($"Failed parsing player stats of {Id} {ObjectClass}");
			}
			if (!int.TryParse(obj.Element("MpRegen")?.Attribute("max")?.Value, out classStats.WisdomMax))
			{
				Console.WriteLine($"Failed parsing player stats of {Id} {ObjectClass}");
			}
			ClassStats.Map.Add(Id, classStats);
		}

		public override string ToString()
		{
			return $"Object: {Name} (0x{Id:X})";
		}

		public string _ItemName { get; set;  }
		public ushort _ItemId { get; set; }
	}
}
