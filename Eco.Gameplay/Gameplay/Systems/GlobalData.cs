// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.GlobalData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.DebugStatistic;
using Eco.Core.Systems;
using Eco.Core.Systems.Mods;
using Eco.Gameplay.Achievements;
using Eco.Gameplay.Buffs;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Civics.Immigration;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Economy.WorkParties;
using Eco.Gameplay.EcopediaRoot;
using Eco.Gameplay.Holidays;
using Eco.Gameplay.InfluenceObjects;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.InventoryRelated;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Minimap;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Settlements.Culture;
using Eco.Gameplay.Skills;
using Eco.Gameplay.StrangeCloudGameplay;
using Eco.Gameplay.Systems.EcoMarketplace;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Gameplay.Systems.Exhaustion;
using Eco.Gameplay.Systems.Messaging.Chat.Channels;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.Streaming;
using Eco.Gameplay.Systems.UserTextures;
using Eco.Gameplay.Types;
using Eco.Gameplay.Voice;
using Eco.Gameplay.Weather;
using Eco.Shared.Networking;
using Eco.Shared.Services;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Simulation.Animals;
using Eco.Simulation.WorldLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems;

public sealed class GlobalData : 
  AutoSingleton<GlobalData>,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [SyncToView(null, true)]
  public string DiscordInviteCode { get; set; }

  [SyncToView(null, true)]
  public int MaxConnections { get; set; }

  [SyncToView(null, true)]
  public HolidayManager HolidayManager { get; }

  [SyncToView(null, true)]
  public NetworkStabilityStatistics NetworkStabilityStatistics { get; }

  [SyncToView(null, true)]
  public DiscoveryManager DiscoveryManager { get; }

  [SyncToView(null, true)]
  public BankAccountManager BankAccounts { get; }

  [SyncToView(null, true)]
  public ElectionManager ElectionManager { get; }

  [SyncToView(null, true)]
  public Dictionary<string, Eco.Simulation.Types.Species> Species { get; }

  [SyncToView(null, true)]
  public VoiceChatUsers VoiceChatUsers { get; }

  [SyncToView(null, true)]
  public WorkPartyManager WorkPartyManager { get; }

  [SyncToView(null, true)]
  public ContractManager ContractManager { get; }

  [SyncToView(null, true)]
  public ConstitutionManager ConstitutionManager { get; }

  [SyncToView(null, true)]
  public Ecopedia Ecopedia { get; }

  [SyncToView(null, true)]
  public GameValueManager GameValueManager { get; }

  [SyncToView(null, true)]
  public GameEventManager GameEventManager { get; }

  [SyncToView(null, true)]
  public SystemCultureInfoManager SystemCultureInfoManager { get; }

  [SyncToView(null, true)]
  public Objectives Objectives { get; }

  [SyncToView(null, true)]
  public InfluenceManager InfluenceManager { get; }

  [SyncToView(null, true)]
  public SettlementManager SettlementManager { get; }

  [SyncToView(null, true)]
  public WorldLayerManager WorldLayerManager { get; }

  [SyncToView(null, true)]
  public PropertyManager PropertyManager { get; }

  [SyncToView(null, true)]
  public FeatureConfig FeatureConfig { get; }

  [SyncToView(null, true)]
  public VoidStorageManager VoidStorageManager { get; }

  [SyncToView(null, true)]
  public AreaBuffManager AreaBuffManager { get; }

  [SyncToView(null, true)]
  public SkillTree[] SkillTrees { get; }

  [SyncToView(null, true)]
  public SkillTree[] ResearchSkillTrees { get; }

  [SyncToView(null, true)]
  public DifficultySettingsConfig DifficultyConfig { get; }

  [SyncToView(null, true)]
  public ExhaustionConfig ExhaustionConfig { get; }

  [SyncToView(null, true)]
  public AchievementManager AchievementManager { get; }

  [SyncToView(null, true)]
  public TooltipManagerServer TooltipManagerServer { get; }

  [SyncToView(null, true)]
  public ChannelManager Channels { get; }

  [SyncToView(null, true)]
  public UserManager UserManager { get; }

  [SyncToView(null, true)]
  public UserTextureManagerServer UserTextureManager { get; }

  [SyncToView(null, true)]
  public SleepManager SleepManager { get; }

  [SyncToView(null, true)]
  public CivicsManager CivicsManager { get; }

  [SyncToView(null, true)]
  public MinimapManager MinimapManager { get; }

  [SyncToView(null, true)]
  public ItemInfoManager ItemInfoManager { get; }

  [SyncToView(null, true)]
  public EcoTypes EcoTypes { get; }

  [SyncToView(null, true)]
  public ServerInteractionManager ServerInteractionManager { get; }

  [SyncToView(null, true)]
  public int MaxAttachDepth { get; }

  [SyncToView(null, true)]
  public EnvVarManager EnvVarManager { get; }

  [SyncToView(null, true)]
  public InitialSpawnManager InitialSpawnManager { get; }

  [SyncToView(null, true)]
  public BiomeRestrictionsManager BiomeRestrictionsManager { get; }

  [SyncToView(null, true)]
  public ServerLogHandler ServerLogHandler { get; }

  [SyncToView(null, true)]
  public CultureManager CultureManager { get; }

  [SyncToView(null, true)]
  public EcoMarketplaceManager EcoMarketplaceManager { get; }

  [SyncToView(null, true)]
  public StrangeWorldsConfig StrangeWorldsConfig { get; }

  [SyncToView(null, true)]
  public string ServerName { get; }

  [SyncToView(null, true)]
  public User ServerOwner { get; }

  [SyncToView(null, true)]
  public ModManager ModManager { get; }

  [SyncToView(null, true)]
  public StreamerManager StreamerManager { get; }

  [SyncToView(null, true)]
  public AnimalsManager AnimalsManager { get; }

  [SyncToView(null, true)]
  public Dictionary<string, List<Recipe>> AllRecipes { get; }

  [SyncToView(null, true)]
  public DinnerPartyManager DinnerPartyManager { get; }

  [SyncToView(null, true)]
  public WeatherManager WeatherManager { get; }

  public static string ServerID { get; set; }

  public static Guid ServerGuid { get; set; }

  [SyncToView(null, true)]
  public Guid ServerGUID { get; }

  [SyncToView(null, true)]
  public Dictionary<string, IRegistrar> Registrars { get; set; }

  [SyncToView(null, true)]
  public Eco.Gameplay.Systems.Messaging.Chat.ChatSettings ChatSettings(User user);

  [RPC]
  public void SetGameSettings(User user, GameSettings settings);

  public void PreInit();

  public void Init();

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
