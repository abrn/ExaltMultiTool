using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ExaltMultiTool.Proxy.DataStructures
{
	public class ProjectileStructure : IDataStructure<byte>
	{
	
		public int Damage;

		public float Speed;

		public int Size;

		public float Lifetime;

		public int MaxDamage;

		public int MinDamage;

		public float Magnitude;

		public float Amplitude;

		public float Frequency;

		public bool Wavy;

		public bool Parametric;

		public bool Boomerang;

		public bool ArmorPiercing;

		public bool MultiHit;

		public bool PassesCover;

		public Dictionary<string, float> StatusEffects;


		public byte Id
		{
			get;
			private set;
		}

		private string Name
		{
			get;
			set;
		}

		public ProjectileStructure(XElement projectile)
		{
			Id = (byte)projectile.GetElementAttrib("id", "0").ParseInt();
			Damage = projectile.GetChildValue("Damage", "0").ParseInt();
			Speed = projectile.GetChildValue("Speed", "0").ParseFloat() / 10000f;
			Size = projectile.GetChildValue("Size", "0").ParseInt();
			Lifetime = projectile.GetChildValue("LifetimeMS", "0").ParseFloat();
			MaxDamage = projectile.GetChildValue("MaxDamage", "0").ParseInt();
			MinDamage = projectile.GetChildValue("MinDamage", "0").ParseInt();
			Magnitude = projectile.GetChildValue("Magnitude", "0").ParseFloat();
			Amplitude = projectile.GetChildValue("Amplitude", "0").ParseFloat();
			Frequency = projectile.GetChildValue("Frequency", "0").ParseFloat();
			Wavy = projectile.ContainsElement("Wavy");
			Parametric = projectile.ContainsElement("Parametric");
			Boomerang = projectile.ContainsElement("Boomerang");
			ArmorPiercing = projectile.ContainsElement("ArmorPiercing");
			MultiHit = projectile.ContainsElement("MultiHit");
			PassesCover = projectile.ContainsElement("PassesCover");
			Dictionary<string, float> conditionEffects = new Dictionary<string, float>();
			projectile.Elements("ConditionEffect")._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(XElement effect)
			{
				conditionEffects[effect.Value] = effect.GetElementAttrib("duration", "0").ParseFloat();
			});
			StatusEffects = conditionEffects;
			Name = projectile.GetChildValue("ObjectId", "");
		}

		public override string ToString()
		{
			return $"Projectile: {Name} (0x{Id:X})";
		}

		public string _ItemName { get; set;  }
		public byte _ItemId { get; set;  }
	}
}
