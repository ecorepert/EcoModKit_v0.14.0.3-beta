// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.LayerInteractions.SpreadInteraction
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers.LayerInteractions;

[Localized(true, false, "", false)]
public class SpreadInteraction : WorldLayerInteraction<float>
{
  public override bool RequiresNeighborhood { get; }

  public override string[] DependencyLayerNames { get; }

  public override string[] WorldInitDependencyLayerNames { get; }

  public override string OutputLayerName { get; }

  [LocDescription("The layer to spread.")]
  public string ModifiedLayerName { get; set; }

  [LocDescription("The proportion of the layer that spreads to the adjacent locations each tick (on a flat plain).")]
  public float SpreadRatio { get; set; }

  [LocDescription("The degree to which the spread prefers going downhill. 0 = ignores height, 1 = never spreads uphill, -1 = never spreads downhill.")]
  public float HeightBias { get; set; }

  [LocDescription("The number of times this interaction should be ticked after its modified layer has otherwise been initialized (but before it is used by any other interactions).")]
  public int PostWorldgenTicks { get; set; }

  [LocDescription("Flag which if set then won't decrease (distribute) the source value, but only will increase values in adjacent cells. Default: false.")]
  public bool IncreaseOnly { get; set; }

  public override float Apply(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  public override float PostWorldgen(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  public override string DescribeGeneral { get; }

  protected override float DescribeSpecific(
    float currentValue,
    float[] dependencyValues,
    WorldLayerNeighborInfo[] neighborValues);

  protected override string DescribeAggregated(IEnumerable<float> intermediateDescriptions);
}
