// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Plants.PlantCache
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Shared.Pools.Collections;
using Eco.Simulation.Agents;
using Eco.Simulation.Types;
using System.Collections.Generic;

#nullable enable
namespace Eco.Simulation.Plants;

/// <summary> This clase provides access to plants by species acording cell size. It allows fast lookup by area and plant species for most cases.
/// Internally it saves plants in cells of diferent sizes: by example 0-5, 5-10 and 0-10. It helps to be able provide fast access for areas of diferent sizes: in case if area match some cell, it can just return data inside of it.
/// </summary>
public class PlantCache
{
  /// <summary> Accepts an enumerable of cell sizes that will be saved in the cache. Something like 5,10,20,40 should cover most requests.
  /// It will represent the cell sizes in which it saves the data, by example for 5, 10 it will save plants in cells 0-5, 5-10, 0-10. </summary>
  public PlantCache(
  #nullable disable
  IEnumerable<int> cellSizes);

  /// <summary> Use this as low-memory allocation option for iterating over plants in area. Internally it will use a lock and pooled list to get plants and release the pooled list in the end of iteration.
  /// Can be used with linq methods, like Sum </summary>
  public PlantsInAreaEnumerable EnumerableOfArea(WorldArea area, PlantSpecies plantSpecies);

  /// <summary> Adds plant to all cells that match it, by example position 4 would match cell 0-5, 0-10 and 0-20.
  /// It uses lock instead of thread-safe collection in order to sacrify a little performance but have gain in less memory allocations. </summary>
  public void AddPlant(Plant plant);

  /// <summary> Removes plant from all cells that match it. As AddPlant, it uses lock aproach instead of thread-safe collections. </summary>
  public void RemovePlant(Plant plant);

  /// <summary> Entry method to cache. Area may match or not internal cells, it will automaticly make all transformations requiered, the area can be not-wraped.  </summary>
  public void CollectPlantsInArea(
    WorldArea area,
    PoolableListWrapper<Plant> list,
    PlantSpecies species = null);
}
