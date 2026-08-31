// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Types.PlantGroupDefinition
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Simulation.Types;

/// <summary> Contains configuration of plants grouping.
/// Grouping consists in two phases:
/// 1) Generation of "CountOfClusters" clusters. Cluster - most populated areas in the world.
/// 2) Each cluster will be populated with groups of plants. You can't control directly the number of groups, but you can control how far one to other they will be spawned. </summary>
public struct PlantGroupDefinition
{
  [LocCategory("Generation")]
  [LocDescription("The probability that the plant will be spawned ignoring the group distance. It still respects clusters.")]
  public float ChanceToBeSpawnOutsideOfGroup;
  [LocCategory("Generation")]
  [LocDescription("Distance between groups in order to be allowed to spawn.")]
  public Range MinDistanceBetweenGroups;
  [LocCategory("Generation")]
  [LocDescription("How many free spots groups have at the beginning.")]
  public Range PlantsInGroup;
  [LocCategory("Generation")]
  [LocDescription("How many clusters of this plant will be in the world.")]
  public Range CountOfClusters;
  [LocCategory("Generation")]
  [LocDescription("How close plants must be to the center of the group to be considered a part of the group.")]
  public Range RadiusOfGroup;
  [LocCategory("Generation")]
  [LocDescription("How big clusters are. Outside of clusters no plants will be spawned.")]
  public Range ClusterRadiusInWorldSize;
  [LocCategory("Generation")]
  [LocDescription("Biomes where plant can be spawned. Empty means any biome.")]
  public string StartBiomes;

  public PlantGroupDefinition();
}
