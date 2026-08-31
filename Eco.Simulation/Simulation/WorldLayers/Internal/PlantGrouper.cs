// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Internal.PlantGrouper
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Simulation.Types;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers.Internal;

/// <summary> This class creates groups of plants when world is generating. It allows to group them into two levels:
/// 1) Clusters. Big circle in the world defined via % of world size. Attempted to have gameplay value by limiting recourses to some areas.
/// 2) Plant groups. Mostly for visuals, so plants will look logically grouped. </summary>
public static class PlantGrouper
{
  public static Dictionary<PlantSpecies, List<PlantGrouper.Cluster>> ClustersBySpecies;

  /// <summary> This function should be use to decide if plant will be spawned in group or not. It spawns in groups only at world generation phase, after that plants already will be statistically tend to group because of reproduction near already existing species.  </summary>
  public static bool ShouldBeSpanwedAsAGroup(PlantSpecies species);

  /// <summary> If there are any group of plants close enough it will add them to the group and remove the free spot from group. If there are no such group, it will return false. </summary>
  public static bool TryAddPlantToTheGroup(PlantSpecies species, Vector2i position);

  /// <summary> Generates clusters and groups, edits layer values. </summary>
  public static void Initialize();

  public static bool BiomeCheck(PlantSpecies species, Vector2i worldPos);

  /// <summary> Represents some big area of the world where plant will be spawned. It matters only at world generation. </summary>
  public class Cluster
  {
    public Vector2i WorldPos;
    public Vector2i LayerPos;
    public float RadiusInWorldSizes;
    public List<PlantGrouper.PlantGroup> Groups;
  }

  /// <summary> Represents a particular small group of plants. Like 5 tomatoes growing each next to other. Its used mostly for visual grouping so similar plants spawned near. </summary>
  public class PlantGroup
  {
    public int FreeSpots;
    public Vector2 WorldPos;
    public float Radius;
    public float MinDistanceToOtherGroup;

    public bool TryAddPlant();
  }
}
