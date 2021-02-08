using System;

[Flags]
internal enum DebuffBitmaskEnum
{
	Dead = 0x1,
	Quiet = 0x2,
	Weak = 0x4,
	Slowed = 0x8,
	Sick = 0x10,
	Dazed = 0x20,
	Stunned = 0x40,
	Blind = 0x80,
	Hallucinating = 0x100,
	Drunk = 0x200,
	Confused = 0x400,
	StunImmume = 0x800,
	Invisible = 0x1000,
	Paralyzed = 0x2000,
	Speedy = 0x4000,
	Bleeding = 0x8000,
	ArmorBrokenImmune = 0x10000,
	Healing = 0x20000,
	Damaging = 0x40000,
	Berserk = 0x80000,
	Paused = 0x100000,
	Stasis = 0x200000,
	StasisImmune = 0x400000,
	Invincible = 0x800000,
	Invulnerable = 0x1000000,
	Armored = 0x2000000,
	ArmorBroken = 0x4000000,
	Hexed = 0x8000000,
	AnotherSpeedy = 0x10000000,
	Unstable = 0x20000000,
	Darkness = 0x40000000,
	HpBoost = 0x100000
}
