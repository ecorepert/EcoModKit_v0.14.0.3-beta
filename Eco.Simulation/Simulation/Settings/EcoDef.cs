// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Settings.EcoDef
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Plugins;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Simulation.WorldLayers;
using Eco.Simulation.WorldLayers.History;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Simulation.Settings;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Localized(true, false, "", false)]
public sealed class EcoDef : 
  IMasterList<IWorldLayerInteraction>,
  IVersionedConfig,
  IValidatableConfig
{
  public static EcoDef Obj;
  public const double DefaultWorldLayerTickTime = 600.0;
  public const double DefaultDaysPerTick = 0.0069444444444444441;
  public static double DefaultTicksPerHour;

  [Browsable(false)]
  [IgnoreHostedWorlds]
  public int LastConfigVersion { get; }

  [Browsable(false)]
  [IgnoreHostedWorlds]
  public int ConfigVersion { get; set; }

  [LocCategory("WorldLayers")]
  public ClimateSettings ClimateSettings { get; set; }

  [LocCategory("WorldLayers")]
  public SerializedSynchronizedCollection<IWorldLayerInteraction> Interactions { get; set; }

  public bool PushToWorld { get; set; }

  public bool PullFromWorld { get; set; }

  [LocDescription("Should animals tick less when they're not being observed by a player?")]
  public bool AnimalBehaviorLodding { get; set; }

  [LocDescription("Game progress time advances at this rate.")]
  public float TimeMult { get; set; }

  [LocDescription("Minimum distance between trees. Lower values can impact performance negatively.")]
  public int MinTreeSpawnDistance { get; set; }

  [Browsable(false)]
  public int MinTreeSpawnDistanceSq { get; }

  [LocDescription("Base skill rate gain.")]
  public float BaseSkillGainRate { get; set; }

  [LocDescription("Scales skill penalty due to suffocation. (0 to disable)")]
  public float SkillDamageMultiplier { get; set; }

  public WorldLayerHistoryOptions RecordLayerHistory { get; set; }

  [LocDescription("Number of layer images/day to store in save file. (Default: 4)")]
  public float LayerHistoryBackupsPerDay { get; set; }

  [LocCategory("Time")]
  [LocDescription("Scales how time of day matches real time.  Higher numbers result in shorter day/night cycles, but will not affect simulation speed.")]
  public float TimeOfDayScale { get; set; }

  IList<IWorldLayerInteraction> IMasterList<IWorldLayerInteraction>.GetMasterList();

  public bool Verify(List<LocString> errors);

  public static float TonsToPPM(float tons);
}
