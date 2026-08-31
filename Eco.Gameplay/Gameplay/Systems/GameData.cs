// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.GameData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Serialization;
using Eco.Core.Stats;
using Eco.Core.Systems;
using Eco.Core.Systems.Mods;
using Eco.Core.Utils;
using Eco.Gameplay.Achievements;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.InventoryRelated;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Gameplay.Systems.EcoMarketplace;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.Streaming;
using Eco.Gameplay.Systems.UserTextures;
using Eco.Gameplay.Types;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;

#nullable disable
namespace Eco.Gameplay.Systems;

[Serialized]
public class GameData : Singleton<GameData>, IStorage, ISerializable
{
  [Serialized]
  public TagManager TagManager;
  [Serialized]
  public Registrar<StatEntry> StatsRegistrar;
  [Serialized]
  public VoidStorageManager VoidStorageManager;
  [Serialized]
  public TrackedGameStats TrackedStats;
  [Serialized]
  public AchievementManager AchievementManager;
  [Serialized]
  public UserTextureManagerServer UserTextureManager;
  [Serialized]
  public TalentManager TalentManager;
  public EcoMarketplaceManager EcoMarketplaceManager;
  public SkillManager SkillManager;
  public UserCountManager UserCountManager;
  public TooltipManagerServer TooltipManagerServer;
  public ServerInteractionManager InteractionInfoManager;
  public EcoTypes EcoTypes;
  public BiomeRestrictionsManager BiomeRestrictions;
  public ModManager ModManager;
  public StreamerManager StreamerManager;
  public Func<string> GetServerName;
  public static Initializer Init;

  public IPersistent StorageHandle { get; set; }

  internal void InitializeRegistrars();

  public void Initialize();
}
