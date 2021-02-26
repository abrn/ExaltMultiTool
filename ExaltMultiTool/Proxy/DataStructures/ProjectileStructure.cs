using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ExaltMultiTool.Proxy.DataStructures
{
	public class ProjectileStructure : IDataStructure<byte>
	{
		[CompilerGenerated]
		private sealed class _3BtQdzUWkrjng0fw7sq7yZkiTkC
		{
			public Dictionary<string, float> _It1aIrgN2hpi17Mr9UNmoUQ00pO;

			internal void _IZjAljPdl5GZBrivAgReV1Wxf62(XElement effect)
			{
				_It1aIrgN2hpi17Mr9UNmoUQ00pO[effect.Value] = effect.GetElementAttrib("duration", "0").ParseFloat();
			}
		}

		[CompilerGenerated]
		private byte _p6MAdQUIoeJwjajDnswJBZlM1l9;

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

		[CompilerGenerated]
		private string _Qc96P7YDwjC6nKoSJ1iVZ312wic;

		public byte ID
		{
			get;
			private set;
		}

		public string Name
		{
			get;
			private set;
		}

		public ProjectileStructure(XElement projectile)
		{
			ID = (byte)projectile.GetElementAttrib("id", "0").ParseInt();
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
			Dictionary<string, float> _It1aIrgN2hpi17Mr9UNmoUQ00pO = new Dictionary<string, float>();
			projectile.Elements("ConditionEffect")._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(XElement effect)
			{
				_It1aIrgN2hpi17Mr9UNmoUQ00pO[effect.Value] = effect.GetElementAttrib("duration", "0").ParseFloat();
			});
			StatusEffects = _It1aIrgN2hpi17Mr9UNmoUQ00pO;
			Name = projectile.GetChildValue("ObjectId", "");
		}

		public override string ToString()
		{
			return $"Projectile: {Name} (0x{ID:X})";
		}

		public string _ItemName { get; }
		public byte _ItemId { get; }
	}
}
