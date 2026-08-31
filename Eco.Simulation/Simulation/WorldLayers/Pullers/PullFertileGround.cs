// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Pullers.PullFertileGround
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Simulation.WorldLayers.Pullers;

public class PullFertileGround : WorldLayerPuller<float>
{
  public override string OutputLayerName { get; }

  public PullFertileGround(string outputLayerName, bool underwater = false);

  public override float Apply(WorldArea area);

  public override float ApplyDestructive(WorldArea area);

  public override string DescribeGeneral { get; }

  protected override float DescribeSpecific(WorldArea area);

  protected override string DescribeAggregated(IEnumerable<float> intermediateDescriptions);
}
