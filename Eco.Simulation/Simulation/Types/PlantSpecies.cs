// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Types.PlantSpecies
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Simulation.WorldLayers.Layers;
using Eco.Simulation.WorldLayers.Pullers;
using Eco.Stats;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Simulation.Types;

[Localized(true, false, "", false)]
[Tag("Plant")]
[Stat("Plants", Unit.Organisms, StatType.ContinuousValue)]
[HasIcon(null)]
public abstract class PlantSpecies : Species
{
  public const float MinHabitability = 0.4f;
  public const 
  #nullable disable
  string YieldPotentialLayerSuffix = "YieldPotential";
  public const string SeedsLayerSuffix = "Seeds";
  public const string GrowthLayerSuffix = "Growth";
  [LocCategory("Generation")]
  [LocDescription("This setting defines how plants will be grouped when the world generates. It have two levels of grouping: clusters and groups. A cluster is a large area of the world where a particular type of plant exists, and it affects gameplay by limiting where specific plants can be spawned. Groups are primarily for visual purposes, so plants of the same species grow together with only a small distance between them.")]
  public PlantGroupDefinition GenerationDefinitions;
  [LocCategory("WorldLayers")]
  [LocDescription("The number of calories in a single voxel column of this plant at population density 1.")]
  public float CaloriesPerVoxelColumnPerDensity;
  public Lazy<Dictionary<string, PlantSpecies.ResourceConstraint>> ResourceConstraintsByLayer;
  public Lazy<Dictionary<string, PlantSpecies.CapacityConstraint>> CapacityConstraintsByLayer;

  [LocCategory("Info")]
  [LocDescription("Decorative plants are not simulated after being spawned")]
  public bool Decorative { get; set; }

  [LocCategory("Info")]
  [LocDescription("Use for spawn finder")]
  public bool IsConsideredNearbyFoodDuringSpawnCheck { get; set; }

  [LocCategory("Info")]
  [LocDescription("For plants that shouldn't ever grow more. Old growth, mostly. Normal growth is needed for world gen to work properly.")]
  public bool NoSpread { get; set; }

  [LocCategory("Generation")]
  [LocDescription("Lives under water")]
  public bool Water { get; set; }

  [LocCategory("Generation")]
  [LocDescription("Height of the plant")]
  public int Height { get; set; }

  [LocCategory("Resources")]
  [LocDescription("After harvesting, we reset their growth percent to this value, 0 -1.  0 means kill the plant.")]
  [SyncToView(null, true)]
  public float PostHarvestingGrowth { get; set; }

  [LocCategory("Resources")]
  [LocDescription("If this gets scythed, does it die?")]
  public bool ScythingKills { get; set; }

  [LocCategory("Resources")]
  [LocDescription("Prevent removal if no resources would be gained.")]
  public bool RequireHarvestable { get; set; }

  [LocCategory("Resources")]
  [LocDescription("If I can pick this, at what percent is that possible?")]
  [SyncToView(null, true)]
  public float PickableAtPercent { get; set; }

  [LocCategory("Resources")]
  [LocDescription("Experience given per harvest.")]
  public float ExperiencePerHarvest { get; set; }

  [LocCategory("Resources")]
  [LocDescription("How many calories must be expended to plant this seed..")]
  public float CaloriesToPlant { get; set; }

  [LocCategory("Visuals")]
  public Type BlockType { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The exponential rate parameter describing the birth rate of the species in ideal growth conditions and no competition.  The % of the population in the area that will reproduce in one tick.")]
  public float MaxGrowthRate { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The exponential rate parameter describing the death rate of the species in ideal growth conditions and no competition.  The % of the population in the area that will die in one tick.  Should always be LESS than MaxGrowthRate.")]
  public float MaxDeathRate { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The exponential rate parameter describing the rate at which the plant spreads to adjacent locations.")]
  public float SpreadRate { get; set; }

  [LocCategory("Resources")]
  [LocDescription("The time elapsed in hours between each attempt at spreading seeds to new tiles.")]
  public double SeedingTime { get; set; }

  [LocCategory("Resources")]
  [LocDescription("The total count of new plants allowed to spread per attempt once the seeding timer has been reached.")]
  public int SeedsCount { get; set; }

  [LocCategory("Resources")]
  [LocDescription("The distance check for how far a new plant is allowed to generate calculated from the existing parent plant.")]
  public float SeedingArea { get; set; }

  [LocCategory("Resources")]
  [LocDescription("The age of a plant necessary to spread to new tiles in percent of total age calculated against its MaturityAgeDays.")]
  public float PlantAgeToSeed { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("Consumable resources that limit growth.")]
  public List<PlantSpecies.ResourceConstraint> ResourceConstraints { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("Environment capacities that limit growth.")]
  public List<PlantSpecies.CapacityConstraint> CapacityConstraints { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("Percentage of habitability that gets spawned in the beginning.  Should be between 0 (no plants) and 1 (use all available capacity).")]
  public float BlanketSpawnPercent { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("How many spawn locations the plant gets relative to the valid area size. Must be < 1.")]
  public float GenerationSpawnPointMultiplier { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("How spread the plant spawns are.")]
  public Eco.Shared.Math.Range GenerationSpawnSpread { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("How many plants per spawn point.")]
  public Eco.Shared.Math.Range GenerationSpawnCountPerPoint { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The plant's preferred temperature range.  Temperatures in this range won't inhibit population growth or reduce yield.")]
  public Eco.Shared.Math.Range IdealTemperatureRange { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The plant's preferred moisture range.  Moisture in this range won't inhibit population growth or reduce yield.")]
  public Eco.Shared.Math.Range IdealMoistureRange { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The plant's preferred salt water range.  Water in this range won't inhibit population growth or reduce yield.")]
  public Eco.Shared.Math.Range IdealWaterRange { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The temperature range that can support this plant (albeit at reduced efficiency if the temperature is not also within the ideal range).  Temperatures outside this range prohibit reproduction entirely and prevent any yield at all.")]
  public Eco.Shared.Math.Range TemperatureExtremes { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The rainfall range that can support this plant (albeit at reduced efficiency if the rainfall is not also within the ideal range).  Rainfall outside this range prohibits reproduction entirely and prevent any yield at all.")]
  public Eco.Shared.Math.Range MoistureExtremes { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The salt water range that can support this plant (albeit at reduced efficiency if the salt water is not also within the ideal range).  Salt water outside this range prohibits reproduction entirely and prevent any yield at all.")]
  public Eco.Shared.Math.Range WaterExtremes { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The ground pollution density (0-1) at or above which the plant cannot reproduce and has zero yield. Between PollutionDensityTolerance and this value, yield falls off linearly.")]
  public float MaxPollutionDensity { get; set; }

  [LocCategory("WorldLayers")]
  [LocDescription("The ground pollution density (0-1) up to which the plant is unaffected. Effects begin above this value. GroundPollution is now capped at 1, so this reads directly as a percentage.")]
  public float PollutionDensityTolerance { get; set; }

  public float MoveThroughCost { get; set; }

  public void CalculateMoveThroughCost();

  public void CreateLayerInteractions();

  public void CreateSubLayerSettings();

  public string PopulationLayer { get; }

  public string GrowthLayer { get; }

  public string YieldLayer { get; }

  public string SeedsLayer { get; }

  public PlantPopulationPuller PopulationPuller { get; }

  public LocString DescribeSpace(LayerPosition layerPosition);

  public LocString DescribeHabitability(LayerPosition layerPosition);

  public float HabitabilityModifier(
    float temperature,
    float moisture,
    float pollution,
    float saltwater);

  public static float RangesToModifier(Eco.Shared.Math.Range outerRange, Eco.Shared.Math.Range innerRange, float value);

  public float CheckAreaForHabitability(
    LayerPosition layerPosition,
    out float temperature,
    out float moisture,
    out float pollution,
    out float saltwater);

  /// <summary>Checks if <paramref name="placementPosition" /> is good for that plant species.</summary>
  public bool IsGoodPlacement(WrappedWorldPosition3i placementPosition);

  [Localized(true, false, "", false)]
  public class ResourceConstraint
  {
    [LocDescription("The world layer describing the concentration of the nutrient.")]
    public string LayerName { get; set; }

    [LocDescription("The concentration of the nutrient at which the plant grows at half its max rate. 0 = plant is not constrained.")]
    public float HalfSpeedConcentration { get; set; }

    [LocDescription("The concentration of the nutrient (amount / voxel column) in an adult plant.")]
    public float MaxResourceContent { get; set; }

    /// <summary> Calculates habitability for this resource constraint for given <paramref name="resourceConcentration" />. </summary>
    public float Habitability(float resourceConcentration);

    public override string ToString();
  }

  [Localized(true, false, "", false)]
  public class CapacityConstraint
  {
    public string ConsumedCapacityLayerName;

    [LocDescription("The world layer describing the local capacity.")]
    public string CapacityLayerName { get; set; }

    [LocDescription("The density of capacity consumed by this organism, in voxel columns occupied per organism.")]
    public float ConsumedCapacityPerPop { get; set; }

    /// <summary> Calculates habitability for given <paramref name="capacity" />. It is based on <see cref="P:Eco.Simulation.Types.PlantSpecies.CapacityConstraint.ConsumedCapacityPerPop" />. <paramref name="capacity" /> is density per voxel column. </summary>
    public float Habitability(float capacity);

    /// <summary> Calculates growth rate in range [0; 1]. It then can be used in formula N + N * growthRate to get new population size. </summary>
    public static float GrowthRate(float consumedCapacity, float capacity);

    public override string ToString();
  }
}
