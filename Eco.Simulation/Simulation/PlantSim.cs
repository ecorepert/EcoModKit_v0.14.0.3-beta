// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.PlantSim
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Simulation.Agents;
using Eco.Simulation.Plants;
using Eco.Simulation.Types;
using Eco.Simulation.WorldLayers;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Simulation;

public class PlantSim
{
  public PlantCache PlantCellCache;

  public Dictionary<string, AccumulatingPuller> NutrientLayers { get; }

  public int NumPlants { get; }

  public IEnumerable<Plant> All { get; }

  public void Tick();

  /// <summary> Use this as low-memory allocation option for iterating over plants in area. Internally it will use a lock and pooled list to get plants and release the pooled list in the end of iteration.
  /// Can be used with linq methods, like Sum, but HyperLinq is prefered since it won't create allocations. </summary>
  public PlantsInAreaEnumerable EnumerableOfArea(WorldArea area, PlantSpecies species = null);

  public void ForEachPlant(Action<Plant> action);

  public Plant SpawnPlant(PlantSpecies species, WorldPosition3i pos, bool addToPuller = true);

  /// <summary> Turn the plant into a gross dead version. Leave the block and the plant entry.</summary>
  public void KillPlant(Plant plant, DeathType deathType, bool addToPuller = true);

  public void Clear();

  public void DestroyPlant(Plant plant, DeathType deathType, bool addToPuller = true, object killer = null);

  public void OnPlantBlockDestroyed(Plant plant);

  public void UpRootPlant(Plant plant);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Plant GetPlant(Vector3i position);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Plant GetPlant(WrappedWorldPosition3i position);

  public Plant GetPlant(WorldPosition3i position);

  public bool Fertile(Vector2i pos);

  public IEnumerable<Vector3i> AllFertileSpaces(WorldArea worldRange);

  public IEnumerable<Vector3i> FertileSpaces(WorldArea worldArea, bool underwater = false);

  /// <summary> Calculates total fertility over <paramref name="worldArea" />. Either for ground or <paramref name="underwater" /> blocks. </summary>
  public float TotalFertility(WorldArea worldArea, bool underwater);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public IEnumerable<Plant> PlantsWithinRange(
    Vector3 pos,
    float radius,
    Predicate<Plant> predicate);

  public IEnumerable<Plant> PlantsWithinRange(
    Eco.Shared.Math.Vector2 pos,
    float radius,
    Predicate<Plant> predicate);

  public bool AnyPlantsWithinRange(
    WrappedWorldPosition3i pos,
    float radius,
    Predicate<Plant> predicate);

  /// <summary>Enumerates plants in bounds specified by center point and extents.</summary>
  public PlantsInAreaEnumerable PlantsInBounds(Eco.Shared.Math.Vector2 center, Eco.Shared.Math.Vector2 extents);

  public void MarkAllDirty();
}
