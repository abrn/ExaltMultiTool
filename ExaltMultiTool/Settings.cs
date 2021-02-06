using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace ExaltMultiTool {
	[Serializable]
	public class Settings {
		private static string _path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			"ExaltMultiTool_Settings.bin");

		private static Settings _default;

		public string ExaltGamePath = "";

		public string ExaltLauncherPath = "";

		public string[] SavedAccounts = new string[0];

		public bool EnableAutoNexus = true;
		public int AutoNexusPercentageThreshold = 25;

		public string CurrentServer = "USWest";

		public bool EnableAutoAbility = true;

		public bool EnableAutoLoot = true;
		public int AutoLootWeaponTierThreshold = 11;
		public int AutoLootArmorTierThreshold = 11;
		public int AutoLootRingTierThreshold = 6;
		public int AutoLootAbilityTierThreshold = 6;
		public bool AutoLootStatPotions = true;
		public bool AutoLootUTs = true;
		public bool AutoLootHealingPotions = true;
		
		public bool IgnoreBlind = true;
		public bool IgnoreHallucinating = true;
		public bool IgnoreDrunk = true;
		public bool IgnoreConfused = true;
		public bool IgnoreUnstable;
		public bool IgnoreDarkness = true;
		public bool IgnoreQuiet;
		public bool IgnoreWeak;
		public bool IgnoreSlowed;
		public bool IgnoreSick;
		public bool IgnoreDazed;
		public bool IgnoreStunned;
		public bool IgnoreParalyzed;
		public bool IgnoreBleeding;
		public bool IgnoreArmorBreak;
		public bool IgnorePetStasis;
		public bool IgnorePetrified;
		public bool IgnoreSilence;

		public bool EnableSafeWalk = true;
		public bool SafeWalkInShatters;
		public bool AntiLagIgnoreEffects = true;
		
		public bool AutoAbilityClosestEnemy;
		public bool AutoAbilityWeakestEnemy;
		
		public int AutoAbilityMinimumEnemyHealthThreshold = 200;
		public int AutoAbilityMinimumManaLeftThreshold = 100;
		public int AbilityMinimumEnemyGroupSize = 3;
		public int AutoAbilityHealHpPercent = 45;
		public bool AutoAbilityStrongestEnemy = true;
		
		public bool EnableTeleportToPlayerCommand = true;
		public bool EnableTeleportToPlayerClosestToQuestCommand = true;
		
		public bool EnableAntiDebuffs = true;
		public bool IgnoreShowEffects;
		public bool BlockDamageNumbers;
		
		public bool EnemyIgnore;
		public bool EnableGlow = true;
		public bool AutoNexusShowInformation = true;
		public bool EnableCustomNexus = true;
		public bool EnableConnectCommand = true;
		public bool EnableGotoCommand = true;
		public bool DisableSystemMessages;
		public bool EnableBazaarTimer = true;
		public int[] FameIngoredEnemies = new int[0];
		public bool AutoAbilityNotifications = true;
		public string[] AntiLagIgnoredEffects = new string[6]
		{
			"Stream",
			"Line",
			"Burst",
			"Flow",
			"Ring",
			"Coneblast"
		};
		
		public bool EnableAntiAFK = true;
		public int AntiLagAllyPlayerSize = 100;
		public bool AntiLagHideAllyPets;
		public bool AntiLagApplyToGuildMates;
		public bool AntiLagApplyToLockList;
		
		public bool AutoLootQuests = true;
		public bool EnableMapHack = true;
		public bool AutoLootMarks;
		public int AutoNexusDrinkThreshold = 40;
		public string ExaltSteamPath = "";
		public Guid ID = Guid.NewGuid();
		public bool AutoLootOverFillMP;
		public bool AutoLootOverFillHP;
		public bool AutoLootBigBags = true;
		
		public bool EnableO3Helper = true;
		public bool O3IgnoreShield = true;
		public bool O3IgnoreCoins = true;
		public bool O3IgnoreDammah = true;
		
		public bool AutoAbilityAutoMP = true;
		public bool AutoNexusDrinkFromInventory = true;
		public bool ShowRealLHPot = true;
		public bool SafeWalkToggle;
		public bool EnableTeleportToSelf = true;
		public bool EnableLocCommand = true;
		public bool AutoLootEggs;
		public bool AutoNexusReplaceFameWithHealth;
		public int AutoNexusHpPotDelay = 400;
		public int AutoAbilityMinimumGroupSizeThreshold = 1;
		
		public bool AutoLootAutoDisable = true;
		public bool AutoLootDelay = true;
		public bool AutoNexusUseAnyHealingItem = true;

		public object this[string name] {
			get { return GetType().GetField(name).GetValue(this); }
			set { GetType().GetField(name).SetValue(this, value); }
		}

		public static Settings Default {
			get
			{
				if (_default == null) {
					CreateDefaultSettings();
				}
				return _default;
			}
		}

		public static event EventHandler SettingsChanged {
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = Settings.SettingsChanged;
				EventHandler eventHandler2 = default(EventHandler);
				EventHandler value2 = default(EventHandler);
				while (true) {
					int num = 1684180416;
					while (true) {
						uint num2;
						switch ((num2 = (uint) num ^ 0x450EABD3u) % 6u) {
							case 0u:
								break;
							default:
								return;
							case 3u:
								eventHandler2 = eventHandler;
								num = 2052854765;
								continue;
							case 2u: {
								int num3;
								int num4;
								if ((object) eventHandler == eventHandler2) {
									num3 = -1666435510;
									num4 = num3;
								}
								else {
									num3 = -23904932;
									num4 = num3;
								}

								num = num3 ^ (int) (num2 * 468598222);
								continue;
							}
							case 4u:
								value2 = (EventHandler) Delegate.Combine(eventHandler2, value);
								num = (int) (num2 * 1136829448) ^ -1146809694;
								continue;
							case 1u:
								eventHandler = Interlocked.CompareExchange(ref Settings.SettingsChanged, value2,
									eventHandler2);
								num = ((int) num2 * -1902459600) ^ 0x39B63761;
								continue;
							case 5u:
								return;
						}

						break;
					}
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = Settings.SettingsChanged;
				EventHandler eventHandler2 = default(EventHandler);
				while (true) {
					int num = 527541713;
					while (true) {
						uint num2;
						switch ((num2 = (uint) num ^ 0x30FB3327u) % 4u) {
							case 0u:
								break;
							default:
								return;
							case 2u: {
								eventHandler2 = eventHandler;
								EventHandler value2 = (EventHandler) Delegate.Remove(eventHandler2, value);
								eventHandler = Interlocked.CompareExchange(ref Settings.SettingsChanged, value2,
									eventHandler2);
								num = 39991554;
								continue;
							}
							case 1u: {
								int num3;
								int num4;
								if ((object) eventHandler != eventHandler2) {
									num3 = 782338460;
									num4 = num3;
								}
								else {
									num3 = 404482501;
									num4 = num3;
								}

								num = num3 ^ (int) (num2 * 1035222281);
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

		public void Change()
		{
			Settings.SettingsChanged?.Invoke(this, EventArgs.Empty);
		}

		public void Save()
		{
			string path = _path;
			bool lockTaken = false;
			
			try {
				Monitor.Enter(path, ref lockTaken);
				FileStream fileStream = File.OpenWrite(_path);
				try {
					new BinaryFormatter().Serialize(fileStream, _default);
				}
				finally {
					((IDisposable) fileStream).Dispose();
				}
			}
			finally {
				if (lockTaken) {
					Monitor.Exit(path);
				}
			}
		}

		public static void DeleteSettings()
		{
			string path = _path;
			bool lockTaken = false;
			
			try {
				Monitor.Enter(path, ref lockTaken);
				if (File.Exists(_path)) {
					File.Delete(_path);
				}
			}
			finally {
				if (lockTaken) {
					Monitor.Exit(path);
				}
			}
		}

		private static void CreateDefaultSettings()
		{
			if (File.Exists(_path)) {
				FileStream fileStream = File.OpenRead(_path);
				try {
					_default = (Settings) new BinaryFormatter().Deserialize(fileStream);
				}
				finally {
					((IDisposable) fileStream).Dispose();
				}
			}
			else {
				_default = new Settings();
			}
		}

		static Settings()
		{
			_default = null;
		}
	}
}