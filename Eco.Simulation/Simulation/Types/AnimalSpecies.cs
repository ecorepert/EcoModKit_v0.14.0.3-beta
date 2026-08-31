// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Types.AnimalSpecies
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Simulation.WorldLayers.Layers;
using Eco.Stats;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.Types;

[Localized(true, false, "", false)]
[Tag("Animal")]
[Stat("Animals", Unit.Organisms, StatType.ContinuousValue)]
[HasIcon(null)]
public abstract class AnimalSpecies : Species
{
  [SyncToView(null, true)]
  public PathRegionType PathRegionType { get; set; }

  [SyncToView(null, true)]
  public bool IsFishable { get; set; }

  [SyncToView(null, true)]
  public bool Nocturnal { get; set; }

  [SyncToView(null, true)]
  public float TooCloseDistance { get; set; }

  [SyncToView(null, true)]
  public float MaxVisibilityDistance { get; set; }

  [SyncToView(null, true)]
  public float MaxVisibilityAngle { get; set; }

  [SyncToView(null, true)]
  public float AttackRange { get; set; }

  [SyncToView(null, true)]
  public float ChanceToAttack { get; set; }

  [SyncToView(null, true)]
  public float ChanceToAttackUnprovoked { get; set; }

  [SyncToView(null, true)]
  public float AttackUnprovokedDistance { get; set; }

  [SyncToView(null, true)]
  public float ChanceOfAlertNoise { get; set; }

  [SyncToView(null, true)]
  public float AnimalDamage { get; set; }

  [SyncToView(null, true)]
  public float PlayerDamage { get; set; }

  [SyncToView(null, true)]
  public float TolerateTramplePercent { get; set; }

  [SyncToView(null, true)]
  public Eco.Shared.Math.Range HerdSize { get; set; }

  [SyncToView(null, true)]
  public string EatTags { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<Species> FoodSourcesSpecies { get; }

  [SyncToView(null, true)]
  public AnimalSkittishness AnimalSkittishness { get; set; }

  [SyncToView(null, true)]
  public float HeavyFootstep { get; set; }

  /// <summary>How long it takes the population to rise 50% closer to the max in its cell.</summary>
  [SyncToView(null, true)]
  public float TimeTill50PercentCloserToMaxInHours { get; set; }

  /// <summary>How many hours it takes to reach 1 organism from 0 in a neighboring cell.</summary>
  [SyncToView(null, true)]
  public float TimeToSpread1ToNeighborInHours { get; set; }

  /// <summary>Caps total growth rate, both population increase and spread</summary>
  [SyncToView(null, true)]
  public float MaxGrowthRatePerHour { get; set; }

  public List<Type> FoodSources { get; set; }

  public bool CanSwimNearCoast { get; set; }

  [SyncToView(null, true)]
  public float Health { get; set; }

  public string PopulationLayer { get; }

  public bool Swimming { get; }

  public bool Eats(Species species);

  public bool Aquatic { get; }

  public bool FlatEnough(int flattness);

  public AnimalLayer AnimalLayer { get; }
}
