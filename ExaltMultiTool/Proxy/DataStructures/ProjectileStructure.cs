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
				_It1aIrgN2hpi17Mr9UNmoUQ00pO[effect.Value] = effect._4qMIb2N5gf9DdhWw9LENt8TJhOK("duration", "0")._y09e3EoPW54jYelUtQzj66l0jRF();
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
			ID = (byte)projectile._4qMIb2N5gf9DdhWw9LENt8TJhOK("id", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
			Damage = projectile._bUyefY83pIQc4tdCSCBCAwGEWxF("Damage", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
			Speed = projectile._bUyefY83pIQc4tdCSCBCAwGEWxF("Speed", "0")._y09e3EoPW54jYelUtQzj66l0jRF() / 10000f;
			Size = projectile._bUyefY83pIQc4tdCSCBCAwGEWxF("Size", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
			Lifetime = projectile._bUyefY83pIQc4tdCSCBCAwGEWxF("LifetimeMS", "0")._y09e3EoPW54jYelUtQzj66l0jRF();
			MaxDamage = projectile._bUyefY83pIQc4tdCSCBCAwGEWxF("MaxDamage", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
			MinDamage = projectile._bUyefY83pIQc4tdCSCBCAwGEWxF("MinDamage", "0")._sO4kfypgWPkSczoRzkVQIGw3fyF();
			Magnitude = projectile._bUyefY83pIQc4tdCSCBCAwGEWxF("Magnitude", "0")._y09e3EoPW54jYelUtQzj66l0jRF();
			Amplitude = projectile._bUyefY83pIQc4tdCSCBCAwGEWxF("Amplitude", "0")._y09e3EoPW54jYelUtQzj66l0jRF();
			Frequency = projectile._bUyefY83pIQc4tdCSCBCAwGEWxF("Frequency", "0")._y09e3EoPW54jYelUtQzj66l0jRF();
			Wavy = projectile._ujE3VgDdVnbxGy9qIazxpFzbjrY("Wavy");
			Parametric = projectile._ujE3VgDdVnbxGy9qIazxpFzbjrY("Parametric");
			Boomerang = projectile._ujE3VgDdVnbxGy9qIazxpFzbjrY("Boomerang");
			ArmorPiercing = projectile._ujE3VgDdVnbxGy9qIazxpFzbjrY("ArmorPiercing");
			MultiHit = projectile._ujE3VgDdVnbxGy9qIazxpFzbjrY("MultiHit");
			PassesCover = projectile._ujE3VgDdVnbxGy9qIazxpFzbjrY("PassesCover");
			Dictionary<string, float> _It1aIrgN2hpi17Mr9UNmoUQ00pO = new Dictionary<string, float>();
			projectile.Elements("ConditionEffect")._rvkyhEufCiuaZq8jbaYgthJoLEx(delegate(XElement effect)
			{
				_It1aIrgN2hpi17Mr9UNmoUQ00pO[effect.Value] = effect._4qMIb2N5gf9DdhWw9LENt8TJhOK("duration", "0")._y09e3EoPW54jYelUtQzj66l0jRF();
			});
			StatusEffects = _It1aIrgN2hpi17Mr9UNmoUQ00pO;
			Name = projectile._bUyefY83pIQc4tdCSCBCAwGEWxF("ObjectId", "");
		}

		public override string ToString()
		{
			return $"Projectile: {Name} (0x{ID:X})";
		}
	}
}
