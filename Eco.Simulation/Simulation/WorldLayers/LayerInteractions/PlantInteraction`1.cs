// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.LayerInteractions.PlantInteraction`1
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Simulation.Types;

#nullable disable
namespace Eco.Simulation.WorldLayers.LayerInteractions;

/// <summary> Base class for Plant interactions. Contains common methods. </summary>
public abstract class PlantInteraction<TIntermediateDescription> : 
  WorldLayerInteraction<TIntermediateDescription>
{
  protected readonly PlantSpecies Species;

  protected PlantInteraction(PlantSpecies species);

  /// <summary> Applies resource limit to current limit modifier. </summary>
  /// <param name="habitability">Current limit modifier [0; 1]. May be reduced if restricted by resources.</param>
  /// <param name="layerName">Restricting layer name if any layer reduced limit.</param>
  /// <param name="dependencyValues">Dependency values for calculations.</param>
  protected void ApplyResourceConstraints(
    ref float habitability,
    ref string layerName,
    float[] dependencyValues);

  /// <summary>
  /// Applies capacity constraints to <paramref name="availablePopulationExtension" />.
  /// It uses two layers {Plant}Capacity and {Plant}ConsumedCapacity for calculation.
  /// For every plant there may be few capacity constraints like required fertile ground per plant and required canopy space per plant.
  /// Then it calculates how plants may be planted in available capacity (total - consumed) and reduces <paramref name="availablePopulationExtension" /> if it is greater than the value.
  /// After applying these constraints it ensures that layer value is capped by all capacities (can't be increased more than for updated <paramref name="availablePopulationExtension" />).
  /// </summary>
  /// <param name="availablePopulationExtension">Currently available population extension.</param>
  /// <param name="layerName">Restricting layer name if any layer reduced limit.</param>
  /// <param name="dependencyValues">Dependency values for calculations.</param>
  protected void ApplyCapacityConstraints(
    ref float availablePopulationExtension,
    ref string layerName,
    float[] dependencyValues);

  protected float EnvironmentHabitability(float[] dependencyValues);
}
