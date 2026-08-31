// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.LayerInteractions.PlantYield
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Simulation.Types;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers.LayerInteractions;

public sealed class PlantYield : PlantInteraction<Tuple<float, float, ConstrainingLayer>>
{
  public PlantYield(PlantSpecies species);

  public override string[] DependencyLayerNames { get; }

  public override string[] WorldInitDependencyLayerNames { get; }

  public override string OutputLayerName { get; }

  public override float Apply(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  public override float PostWorldgen(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  public override string DescribeGeneral { get; }

  protected override Tuple<float, float, ConstrainingLayer> DescribeSpecific(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  protected override string DescribeAggregated(
    IEnumerable<Tuple<float, float, ConstrainingLayer>> intermediateDescriptions);
}
