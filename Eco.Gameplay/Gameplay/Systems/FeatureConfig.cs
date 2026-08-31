// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.FeatureConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems;

[Localized(true, false, "", false)]
public class FeatureConfig : 
  Singleton<FeatureConfig>,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [LocDescription("Allows players to rent access to a given deed from one another when enabled.")]
  [SyncToView(null, true)]
  public bool RentEnabled { get; set; }

  [LocDescription("When enabled, players will be able to use voice chat.")]
  [SyncToView(null, true)]
  public bool VoiceChatEnabled { get; set; }

  [LocDescription("When enabled, the variety of food you eat will provide a bonus.")]
  [SyncToView(null, true)]
  public bool FoodVarietyMultiplierEnabled { get; set; }

  [LocDescription("When enabled, each player has unique preferences for each type of food that yields a bonus, and periodic 'cravings' will emerge for an additional bonus.")]
  [SyncToView(null, true)]
  public bool FoodTastinessMultiplierEnabled { get; set; }

  [DebugCategory]
  [LocDescription("Allows creation of schools and a different skill system that supports getting educated for easier gains. (Note: this system is not finished yet and currently disabled)")]
  [SyncToView(null, true)]
  public bool EducationEnabled { get; }

  [LocDescription("Should the settlement system be used, or should the old style be set? Forced to false for servers migrated from before V0.10. Note: changing this will automatically change the config enabling/disabling spawning of claim stakes and papers in the Balance Config.")]
  [SyncToView(null, true)]
  public bool SettlementEnabled { get; set; }

  [SyncToView(null, true)]
  [DependsOn("SettlementEnabled")]
  [LocDescription("Is the settlement system being used?")]
  public bool UseSettlementSystem { get; }

  [LocDescription("Should the culture system be used, which allows settlements to take over neighboring settlements when their level is high enough?")]
  [SyncToView(null, true)]
  public bool CultureEnabled { get; set; }

  [LocDescription("Allows players to use facetracking feature")]
  [SyncToView(null, true)]
  public bool AllowFaceTrackingOnServer { get; set; }

  [LocDescription("Should the achievements be enabled or not?")]
  [SyncToView(null, true)]
  public bool AchievementsEnabled { get; set; }

  [LocDescription("Should the Camera mode be enabled?")]
  [SyncToView(null, true)]
  public bool CameraModeEnabled { get; set; }

  [LocDescription("When set, new users will treated to a delightful smorgasbord of initial spawn positions to choose from.  Will also show settlements accepting new citizens. When false, will spawn at the default position without user prompting.")]
  [SyncToView(null, true)]
  public bool InitialSpawnSelection { get; set; }

  [LocDescription("When enabled, players can pick more than one talent per skill level. When disabled, only one talent can be chosen per level.")]
  [SyncToView(null, true)]
  public bool AllowMultipleTalentPicks { get; set; }

  [LocDescription("When enabled, explosions destroy owned WorldObjects (including doors and vehicles) in their radius and replace them with MixedGarbage blocks at their occupied positions.")]
  [SyncToView(null, true)]
  public bool ExplosionCanDestroyWorldObjects { get; set; }

  [LocDescription("When enabled, explosions destroy Constructed blocks (walls, floors, etc.) in their radius and replace them with MixedGarbage blocks based on their SalvageCost.")]
  [SyncToView(null, true)]
  public bool ExplosionCanDestroyConstructedBlocks { get; set; }

  /// <summary> Checks if the type has any related feature and returns true if all its related features are enabled. </summary>
  public static bool IsFeatureOfTypeAvailable(Type type, out RelatedFeatureAttribute attribute);

  public ref int ControllerID { get; }
}
