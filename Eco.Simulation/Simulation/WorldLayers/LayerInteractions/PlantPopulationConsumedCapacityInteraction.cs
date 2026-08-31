// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.LayerInteractions.PlantPopulationConsumedCapacityInteraction
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Simulation.Types;

#nullable disable
namespace Eco.Simulation.WorldLayers.LayerInteractions;

/// <summary>
/// This interaction used by plant species to update consumed capacity in capacity layers. It inherits from <see cref="T:Eco.Simulation.WorldLayers.LayerInteractions.ProportionalInteraction" />,
/// but ensures only fully spawned plants consumed capacity to avoid situation with overcrowding and non-spawning from fractional plants.
/// </summary>
public class PlantPopulationConsumedCapacityInteraction : ProportionalInteraction
{
  public PlantPopulationConsumedCapacityInteraction(
    PlantSpecies species,
    PlantSpecies.CapacityConstraint capacityConstraint);

  /// <summary> Trim to integer number of plants to avoid consume capacity for fractional plants which may prevent plants from grow and spawn. </summary>
  protected override float GetValue(float[] dependencyValues);
}
