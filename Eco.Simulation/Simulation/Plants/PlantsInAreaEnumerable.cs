// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Plants.PlantsInAreaEnumerable
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using Eco.Shared.Utils;
using Eco.Simulation.Agents;
using Eco.Simulation.Types;
using NetFabric.Hyperlinq;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.Plants;

/// <summary> Allows to iterate through plants in area with almost no memory alloactions by using poolablelist inside of enumerator </summary>
public readonly struct PlantsInAreaEnumerable : 
  IEnumerable<Plant>,
  IEnumerable,
  IValueEnumerable<Plant, PoolableListEnumerator<Plant>>
{
  private readonly WorldArea area;
  private readonly PlantSpecies species;
  private readonly PlantCache cache;

  public PlantsInAreaEnumerable(WorldArea area, PlantSpecies species, PlantCache cache);

  public PoolableListEnumerator<Plant> GetEnumerator();

  IEnumerator<Plant> IEnumerable<Plant>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();
}
