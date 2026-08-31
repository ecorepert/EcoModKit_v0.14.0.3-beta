// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.LayerInteractions.BiomeRater
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers.LayerInteractions;

public sealed class BiomeRater : WorldLayerInteraction<Tuple<float, float>>
{
  [LocCategory("Biome")]
  public string BiomeLayerName { get; set; }

  [LocCategory("Biome")]
  [LocDescription("Target moisture.")]
  [LocDisplayName("Moisture Range")]
  public Eco.Shared.Math.Range MoistureRange { get; set; }

  [LocCategory("Biome")]
  [LocDescription("Target temperature.")]
  [LocDisplayName("Temperature Range")]
  public Eco.Shared.Math.Range TemperatureRange { get; set; }

  [LocCategory("Biome")]
  [LocDescription("Target water")]
  [LocDisplayName("water Range")]
  public Eco.Shared.Math.Range WaterRange { get; set; }

  [LocCategory("Biome")]
  [LocDescription("Values below this threshold are clamped to 0 to suppress residual fuzz at biome borders.")]
  public float MinThreshold { get; set; }

  public override string[] DependencyLayerNames { get; }

  public override string[] WorldInitDependencyLayerNames { get; }

  public override string OutputLayerName { get; }

  public override string DescribeGeneral { get; }

  public override float PostWorldgen(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  public override float Apply(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  protected override Tuple<float, float> DescribeSpecific(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  protected override string DescribeAggregated(
    IEnumerable<Tuple<float, float>> intermediateDescriptions);

  public override bool Verify(List<LocString> errors);

  private enum DependencyTypes
  {
    Moisture,
    Temperature,
    SaltWater,
  }
}
