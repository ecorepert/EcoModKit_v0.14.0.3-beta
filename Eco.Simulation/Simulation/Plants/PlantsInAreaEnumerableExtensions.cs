// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Plants.PlantsInAreaEnumerableExtensions
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Utils;
using Eco.Simulation.Agents;
using NetFabric.Hyperlinq;

#nullable disable
namespace Eco.Simulation.Plants;

/// <summary> Allows to use Enumerable.AsValueEnumerable without boxing. </summary>
public static class PlantsInAreaEnumerableExtensions
{
  public static ValueEnumerableExtensions.ValueEnumerable<PlantsInAreaEnumerable, PoolableListEnumerator<Plant>, PoolableListEnumerator<Plant>, Plant, FunctionWrapper<PlantsInAreaEnumerable, PoolableListEnumerator<Plant>>, FunctionWrapper<PlantsInAreaEnumerable, PoolableListEnumerator<Plant>>> AsValueEnumerable(
    this PlantsInAreaEnumerable enumerable);
}
