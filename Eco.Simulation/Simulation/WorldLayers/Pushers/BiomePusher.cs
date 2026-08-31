// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Pushers.BiomePusher
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Simulation.WorldLayers.Pushers;

public class BiomePusher : WorldLayerPusher<
#nullable disable
Dictionary<Tuple<Type, Type>, int>>
{
  public override string[] DependencyLayerNames { get; }

  public override void Apply(
    WorldArea area,
    float[] layerValues,
    WorldLayerNeighborInfo[] neighborValues,
    int length);

  public override string DescribeGeneral { get; }

  protected override Dictionary<Tuple<Type, Type>, int> DescribeSpecific(
    WorldArea area,
    float[] layerValues,
    WorldLayerNeighborInfo[] neighborValues);

  protected override string DescribeAggregated(
    IEnumerable<Dictionary<Tuple<Type, Type>, int>> intermediateDescriptions);

  public static void AddFrozenColumn(Vector2i worldColumn);

  public static void ClearFrozenColumns();
}
