// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Agents.Plant
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking.Monitoring;
using Eco.Shared.Serialization;
using Eco.Simulation.Types;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.Agents;

[Serialized]
public abstract class Plant : Organism, INetTrafficCategory
{
  [Serialized]
  public double NextSeedTime;
  public double TimeTillMatureHours;

  public PlantPack PlantPack { get; set; }

  [Serialized]
  public double DeathTime { get; set; }

  [Serialized]
  public bool Tended { get; set; }

  public PlantSpecies Species { get; }

  public override float GrowthPercent { get; set; }

  public virtual bool GrowthBlocked { get; }

  public virtual bool UpRooted { get; }

  /// <summary> If possible, returns collection of position where plant leave the seeds. Can seed only once in SeedingTime. </summary>
  public void TrySeed(double time, List<Vector2i> seeds);

  public Plant(PlantSpecies species, WorldPosition3i position, PlantPack plantPack);

  protected Plant();

  public override void Tick();

  public LocString GetEcosystemInfo();

  public void MarkDirty();

  public override void Destroy();

  public virtual bool Ripe { get; }

  public virtual void RandomizeAge();

  public virtual bool WillDecay { get; }

  public bool ShouldDecay();

  protected virtual int CalculateResourceYield(Range range, float bonusMultiplier = 1f);

  public virtual string NetTrafficCategory { get; }
}
